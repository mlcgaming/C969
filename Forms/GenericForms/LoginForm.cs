using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.DBItems;
using C969.Events;
using C969.Exceptions;

namespace C969 {
    public partial class LoginForm : Form {
        public event EventHandler<UserLoggedInEventArgs> UserLoggedIn;

        public LoginForm() {
            InitializeComponent();
            SetFormTextByLanguage();

            btnLogin.Enabled = false;

            tboxUsername.TextChanged += OnLoginFieldsUpdated;
            tboxPassword.TextChanged += OnLoginFieldsUpdated;
            btnLogin.Click += OnLoginButtonPressed;
            btnClose.Click += OnCancelButtonPressed;
        }

        #region Form Functions
        private void SetFormTextByLanguage() {
            lblFormTitle.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_TITLE];
            lblUsername.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_USERNAME];
            lblPassword.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_PASSWORD];
            btnClose.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_CANCEL_BUTTON];
            btnLogin.Text = Settings.CurrentLabels[Settings.ID_LABEL_LOGIN_FORM_LOGIN_BUTTON];
        }
        private void ValidateLoginFields() {
            bool isFormValid = true;

            // Check if Username and Password fields are empty if all whitespace is removed
            string username = tboxUsername.Text;
            string password = tboxPassword.Text;

            if(username.Replace(" ", "").Length == 0) {
                isFormValid = false;
            }

            if(password.Replace(" ", "").Length == 0) {
                isFormValid = false;
            }

            // If Form has text in both Username and Password fields, enable the LOGIN button
            if(isFormValid) {
                btnLogin.Enabled = true;
            }
            else {
                btnLogin.Enabled = false;
            }
        }
        #endregion

        #region Event Functions
        private void OnUserLoggedIn(UserAccount user) {
            MessageBox.Show("Login Successful");
            EventLogger.LogSuccessfulLogin(user);
            UserLoggedIn?.Invoke(null, new UserLoggedInEventArgs(user));
            Close();
        }
        private void OnLoginButtonPressed(object sender, EventArgs args) {
            List<UserAccount> allUsers = DBManager.GetAllUserAccounts();

            try {
                foreach(UserAccount u in allUsers) {
                    if(u.Username == tboxUsername.Text) {
                        if(u.Password == tboxPassword.Text) {
                            // Login Successfull
                            OnUserLoggedIn(u);
                            return;
                        }
                        else {
                            // Username Matches, but Password Doesn't. Throw Exception
                            EventLogger.LogUnsuccessfulLogin(tboxUsername.Text);
                            throw new LoginInvalidException("Password does not match.");
                        }
                    }
                }

                // No matching Username was found. Throw Exception
                EventLogger.LogUnsuccessfulLogin(tboxUsername.Text);
                throw new LoginInvalidException("User account does not exist");
            }
            catch(LoginInvalidException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnCancelButtonPressed(object sender, EventArgs args) {
            Close();
        }
        private void OnLoginFieldsUpdated(object sender, EventArgs args) {
            ValidateLoginFields();
        }
        #endregion
    }
}
