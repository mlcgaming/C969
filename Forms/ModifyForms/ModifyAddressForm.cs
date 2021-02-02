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
    public partial class ModifyAddressForm : SaveableForm {
        private Address currentAddress;

        public ModifyAddressForm(UserAccount user, Address address) {
            InitializeComponent();

            formOwner = user;
            currentAddress = address;
        }

        private void ModifyAddressForm_Load(object sender, EventArgs e) {
            ResetForm();
        }

        #region Form Functions
        private void ValidateForm() {
            bool isFormValid = true;

            if(Validator.IsControlEmptyOrWhitespace(tboxAddressAddress1)) {
                isFormValid = false;
            }

            if(Validator.IsControlEmptyOrWhitespace(tboxAddressPhone)) {
                isFormValid = false;
            }

            if(Validator.IsControlEmptyOrWhitespace(tboxAddressPostalCode)) {
                isFormValid = false;
            }

            if(isFormValid == true) {
                btnSave.Enabled = true;
            }
            else {
                btnSave.Enabled = false;
            }
        }
        private void ResetForm() {
            // Temporarily Unsubscribe from Control Events
            tboxAddressAddress1.TextChanged -= OnFormUpdated;
            tboxAddressPhone.TextChanged -= OnFormUpdated;
            tboxAddressPostalCode.TextChanged -= OnFormUpdated;
            cmbAddressCityId.SelectedIndexChanged -= OnCityChanged;
            btnSave.Click -= OnSaveButtonClicked;
            btnCancel.Click -= OnCancelButtonClicked;

            // Clear Out Collections, as needed
            cmbAddressCityId.Items.Clear();

            // Set Defaults for Form
            tboxAddressId.Text = currentAddress.ID.ToString();
            tboxAddressAddress1.Text = currentAddress.Address1;
            tboxAddressAddress2.Text = currentAddress.Address2;
            tboxAddressPhone.Text = currentAddress.Phone;
            tboxAddressPostalCode.Text = currentAddress.PostalCode;

            // Fill ComboBoxes
            List<City> allCities = DBManager.GetAllCities();
            foreach(City city in allCities) {
                cmbAddressCityId.Items.Add(city.ID);
            }

            // Subscribe to Control Events
            tboxAddressAddress1.TextChanged += OnFormUpdated;
            tboxAddressPhone.TextChanged += OnFormUpdated;
            tboxAddressPostalCode.TextChanged += OnFormUpdated;
            cmbAddressCityId.SelectedIndexChanged += OnCityChanged;
            btnSave.Click += OnSaveButtonClicked;
            btnCancel.Click += OnCancelButtonClicked;

            // Set City to First Index
            cmbAddressCityId.SelectedItem = currentAddress.CityID;
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
        private void OnCityChanged(object sender, EventArgs e) {
            int cityId = int.Parse(cmbAddressCityId.SelectedItem.ToString());
            City selectedCity = DBManager.GetCityById(cityId);
            lblAddressCityName.Text = selectedCity.Name;
        }

        private void OnSaveButtonClicked(object sender, EventArgs e) {
            // Create a New Address and Parse it into an insertValues string to send to DBManager for INSERT INTO SQL statement
            int addressId = int.Parse(tboxAddressId.Text);
            int cityId = int.Parse(cmbAddressCityId.SelectedItem.ToString());

            Address newAddress = new Address(addressId, tboxAddressAddress1.Text, tboxAddressAddress2.Text, cityId, tboxAddressPostalCode.Text, tboxAddressPhone.Text, DateTime.Now, formOwner.Username, DateTime.Now, formOwner.Username);
            string insertValues = $"addressId = {newAddress.ID}, address = \"{newAddress.Address1}\", address2 = \"{newAddress.Address2}\", cityId = {newAddress.CityID}, postalCode = \"{newAddress.PostalCode}\", " +
                $"phone = \"{newAddress.Phone}\", createDate = \"{newAddress.DateCreated:yyyy-MM-dd HH:mm:ss}\", createdBy = \"{newAddress.CreatedBy}\", " +
                $"lastUpdate = \"{newAddress.DateLastUpdated:yyyy-MM-dd HH:mm:ss}\", lastUpdateBy = \"{newAddress.LastUpdatedBy}\"";

            // Use DBManager to attempt to Insert new record
            int rowsAdded = DBManager.UpdateRecord("address", insertValues, $"addressId = {int.Parse(tboxAddressId.Text)}");

            // Check if new rows were successfully added
            if(rowsAdded > 0) {
                // Success!
                MessageBox.Show("Address Successfully Updated!");
                OnFormSaved();
            }
            else {
                MessageBox.Show("Something went wrong.");
            }
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
