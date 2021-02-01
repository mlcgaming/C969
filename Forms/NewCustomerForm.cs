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
    public partial class NewCustomerForm : Form {
        private UserAccount formOwner;

        public event EventHandler FormSaving;

        public NewCustomerForm(UserAccount user) {
            InitializeComponent();

            formOwner = user;
        }

        private void NewCustomerForm_Load(object sender, EventArgs e) {
            // Get New ID for Customer using DBManager
            tboxCustomerId.Text = DBManager.GetNewIdFromTable("customer", "customerId").ToString();

            // Get all Addresses and insert their ID's into the AddressID ComboBox
            List<Address> allAddresses = DBManager.GetAllAddresses();
            foreach(var addr in allAddresses) {
                cmbAddressId.Items.Add(addr.ID);
            }

            // Set Specific Controls to Defaults
            lblCustomerNameWarning.Visible = false;

            // Subscribe to Control Events
            cmbAddressId.SelectedIndexChanged += OnNewAddressSelected;
            cmbAddressId.SelectedIndexChanged += OnFormUpdated;
            tboxCustomerName.TextChanged += OnFormUpdated;
            checkCustomerActive.CheckedChanged += OnFormUpdated;
            btnSave.Click += OnSaveButtonClicked;
            btnCancel.Click += OnCancelButtonClicked;

            // Set Address Dropdown to First Item
            cmbAddressId.SelectedIndex = 0;
        }

        #region
        private void ValidateForm() {
            // Check Required Fields
            bool isFormValid = true;

            if(IsControlEmptyOrWhitespace(tboxCustomerName)) {
                isFormValid = false;
            }
            else {
                // Test to make sure name doesn't contain numbers and special characters
                string customerName = tboxCustomerName.Text;
                char[] invalidChars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '?', '>', '<', '/', '\\', 
                    '@', '#', '$', '%', '^', '&', '*', '(', ')', '{', '}', '|', '[', ']', '\'', '"', ';', ':', ',', '.' };

                for(int i = 0; i < invalidChars.Length; i++) {
                    if(customerName.Contains(invalidChars[i])) {
                        lblCustomerNameWarning.Visible = true;
                        isFormValid = false;
                        break;
                    }
                    else {
                        lblCustomerNameWarning.Visible = false;
                    }
                }
            }

            // If form is still valid, enable the Save button
            if(isFormValid == true) {
                btnSave.Enabled = true;
            }
            else {
                btnSave.Enabled = false;
            }
        }
        /// <summary>
        /// Checks if specified control's TEXT field is empty or only whitespace.
        /// </summary>
        /// <param name="control">Control to Test</param>
        /// <returns>TRUE if only spaces or empty. FALSE if text is present</returns>
        private bool IsControlEmptyOrWhitespace(Control control) {
            string controlText = control.Text;

            if(controlText.Replace(" ", "").Length == 0) {
                return true;
            }
            else { return false; }
        }
        #endregion

        #region Event Functions
        private void OnSaveButtonClicked(object sender, EventArgs e) {
            // Attempt to perform a Save to DB, if successful, fire off OnFormSaving so HomeForm knows to refresh its data, then Close
            Customer newCustomer = new Customer(int.Parse(tboxCustomerId.Text), tboxCustomerName.Text, int.Parse(cmbAddressId.SelectedItem.ToString()),
                checkCustomerActive.Checked, DateTime.Now, formOwner.Username, DateTime.Now, formOwner.Username);
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }

        private void OnNewAddressSelected(object sender, EventArgs e) {
            Address newAddress = DBManager.GetAddressById(int.Parse(cmbAddressId.SelectedItem.ToString()));

            if(newAddress != null) {
                StringBuilder fullAddress = new StringBuilder();
                fullAddress.Append($"{newAddress.Address1}");
                if(newAddress.Address2 != "") { fullAddress.Append($", {newAddress.Address2}"); }
                fullAddress.Append($"\r\n");
                fullAddress.Append($"{DBManager.GetCityById(newAddress.CityID).Name}, {newAddress.PostalCode}\r\n");
                fullAddress.Append($"{DBManager.GetCountryById(DBManager.GetCityById(newAddress.CityID).CountryID).Name}");
                lblCustomerAddressValue.Text = fullAddress.ToString();
                lblCustomerPhoneValue.Text = newAddress.Phone;
            }

            OnFormUpdated(null, EventArgs.Empty);
        }
        private void OnFormUpdated(object sender, EventArgs e) {
            ValidateForm();
        }
        private void OnFormSaving() {

        }
        #endregion
    }
}
