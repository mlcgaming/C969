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

            if(Validator.IsControlEmptyOrWhitespace(tboxCustomerName)) {
                lblCustomerNameWarning.Visible = false;
                isFormValid = false;
            }
            else {
                if(Validator.IsTextFreeOfSpecialCharacters(tboxCustomerName.Text) == false) {
                    lblCustomerNameWarning.Visible = true;
                    isFormValid = false;
                }
                else {
                    lblCustomerNameWarning.Visible = false;
                    isFormValid = true;
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
        #endregion

        #region Event Functions
        private void OnSaveButtonClicked(object sender, EventArgs e) {
            // Attempt to perform a Save to DB, if successful, fire off OnFormSaving so HomeForm knows to refresh its data, then Close
            Customer newCustomer = new Customer(int.Parse(tboxCustomerId.Text), tboxCustomerName.Text, int.Parse(cmbAddressId.SelectedItem.ToString()),
                checkCustomerActive.Checked, DateTime.Now, formOwner.Username, DateTime.Now, formOwner.Username);

            // Created a string to apply an INSERT INTO SQL command
            string insertValues = $"{newCustomer.CustomerID}, \"{newCustomer.Name}\", {newCustomer.AddressID}, {newCustomer.IsActive}, \"{newCustomer.DateCreated:yyyy-MM-dd HH:mm:ss}\", " +
                $"\"{newCustomer.CreatedBy}\", \"{newCustomer.DateLastUpdated:yyyy-MM-dd HH:mm:ss}\", \"{newCustomer.LastUpdatedBy}\"";

            int rowsAffected = DBManager.InsertNewRecord("customer", insertValues);

            // Check Rows Affected to see if the record saved correctly
            if(rowsAffected > 0) {
                // Success! Return to the HomeForm by triggering the FormSaved event (so HomeForm reloads its data from the Database)
                MessageBox.Show($"{rowsAffected} record(s) saved! Retuning to Home Form.");
                OnFormSaving();
            }
            else {
                // Something went wrong, exit with a warning
                MessageBox.Show("Record did not insert into the database. This customer has not been saved.");
            }
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
            FormSaving?.Invoke(null, EventArgs.Empty);
            Close();
        }
        #endregion
    }
}
