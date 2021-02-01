using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.DBItems;

namespace C969 {
    public partial class NewCountryForm : Form {
        private UserAccount formOwner;

        public event EventHandler FormSaved;

        public NewCountryForm(UserAccount user) {
            InitializeComponent();

            formOwner = user;
        }

        private void NewCountryForm_Load(object sender, EventArgs e) {
            // Set up Form with Default Information
            tboxCountryId.Text = DBManager.GetNewIdFromTable("country", "countryId").ToString();
            tboxCountryName.Text = "";

            // Disable Save Button until proper Validation has occurred
            btnSave.Enabled = false;

            // Subscribe to Control Events
            tboxCountryName.TextChanged += OnFormUpdated;
        }

        #region Form Functions
        private void ValidateForm() {
            
        }
        #endregion

        #region Event Functions
        private void OnFormSaved() {
            FormSaved?.Invoke(null, EventArgs.Empty);
            Close();
        }
        private void OnFormUpdated(object sender, EventArgs e) {

        }

        private void OnSaveButtonClicked(object sender, EventArgs e) {

        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
