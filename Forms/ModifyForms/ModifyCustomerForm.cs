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
    public partial class ModifyCustomerForm : SaveableForm {
        private Customer currentCustomer;

        public ModifyCustomerForm(UserAccount user, Customer currentCustomer) {
            InitializeComponent();

            formOwner = user;
            this.currentCustomer = currentCustomer;
        }

        private void ModifyCustomerForm_Load(object sender, EventArgs e) {
            ResetForm(currentCustomer);
        }

        #region Form Functions
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
        private void ResetForm(Customer currentCustomer) {
            // Get New ID for Customer using DBManager
            tboxCustomerId.Text = currentCustomer.CustomerID.ToString();

            // Get all Addresses and insert their ID's into the AddressID ComboBox
            List<Address> allAddresses = DBManager.GetAllAddresses();
            foreach(var addr in allAddresses) {
                cmbAddressId.Items.Add(addr.ID);
            }

            // Set Specific Controls to Defaults
            lblCustomerNameWarning.Visible = false;
            tboxCustomerName.Text = currentCustomer.Name;
            checkCustomerActive.Checked = currentCustomer.IsActive;

            // Subscribe to Control Events
            cmbAddressId.SelectedIndexChanged += OnNewAddressSelected;
            cmbAddressId.SelectedIndexChanged += OnFormUpdated;
            tboxCustomerName.TextChanged += OnFormUpdated;
            checkCustomerActive.CheckedChanged += OnFormUpdated;
            btnSave.Click += OnSaveButtonClicked;
            btnCancel.Click += OnCancelButtonClicked;

            // Set Address Dropdown to First Item
            cmbAddressId.SelectedItem = currentCustomer.AddressID;
        }
        #endregion

        #region Event Functions
        protected override void OnFormSaved() {
            base.OnFormSaved();
            Close();
        }
        private void OnFormUpdated(object sender, EventArgs e) {
            ValidateForm();
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

        private void OnSaveButtonClicked(object sender, EventArgs e) {
            // Attempt to perform a Save to DB, if successful, fire off OnFormSaving so HomeForm knows to refresh its data, then Close
            Customer newCustomer = new Customer(int.Parse(tboxCustomerId.Text), tboxCustomerName.Text, int.Parse(cmbAddressId.SelectedItem.ToString()),
                checkCustomerActive.Checked, currentCustomer.DateCreated, currentCustomer.CreatedBy, DateTime.Now, formOwner.Username);

            // Created a string to apply an INSERT INTO SQL command
            string insertValues = $"customerId = {newCustomer.CustomerID}, customerName = \"{newCustomer.Name}\", addressId = {newCustomer.AddressID}, active = {newCustomer.IsActive}, createDate = \"{newCustomer.DateCreated:yyyy-MM-dd HH:mm:ss}\", " +
                $"createdBy = \"{newCustomer.CreatedBy}\", lastUpdate = \"{newCustomer.DateLastUpdated:yyyy-MM-dd HH:mm:ss}\", lastUpdateBy = \"{newCustomer.LastUpdatedBy}\"";

            int rowsAffected = DBManager.UpdateRecord("customer", insertValues, $"customerId = {newCustomer.CustomerID}");

            // Check Rows Affected to see if the record saved correctly
            if(rowsAffected > 0) {
                // Success! Return to the HomeForm by triggering the FormSaved event (so HomeForm reloads its data from the Database)
                MessageBox.Show($"{rowsAffected} record(s) saved! Retuning to Home Form.");
                OnFormSaved();
            }
            else {
                // Something went wrong, exit with a warning
                MessageBox.Show("Record did not insert into the database. This customer has not been saved.");
            }
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
