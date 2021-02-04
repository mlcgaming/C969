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
    public partial class NewAddressForm : SaveableForm {
        public NewAddressForm(UserAccount user) {
            InitializeComponent();

            formOwner = user;
        }

        private void NewAddressForm_Load(object sender, EventArgs e) {
            ResetForm();
        }

        #region Form Functions
        private void ValidateForm() {
            bool isFormValid = true;

            if(Validator.IsControlEmptyOrWhitespace(tboxAddressAddress1)) {
                isFormValid = false;
            }

            if(PhoneFieldValidation() == false || Validator.IsControlEmptyOrWhitespace(tboxAddressPhone)) {
                isFormValid = false;
            }

            if(PostalCodeFieldValidation() == false || Validator.IsControlEmptyOrWhitespace(tboxAddressPostalCode)) {
                isFormValid = false;
            }

            if(isFormValid == true) {
                btnSave.Enabled = true;
            }
            else {
                btnSave.Enabled = false;
            }
        }
        private bool PhoneFieldValidation() {
            char[] phoneChars = tboxAddressPhone.Text.ToCharArray();

            // Check if field is too long (xxx-xxx-xxxx should be 12 chars)
            if(phoneChars.Length != 12) {
                return false;
            }

            // Check for dashes in correct places
            if(phoneChars[3] != '-' || phoneChars[7] != '-') {
                return false;
            }

            // Check that all other characters are only digits
            IEnumerable<char> phoneNoDashes =
                from c in phoneChars
                where c != '-'
                select c;

            foreach(char c in phoneNoDashes) {
                if(c < '0' || c > '9') {
                    return false;
                }
            }

            // Validation Passed!
            return true;
        }
        private bool PostalCodeFieldValidation() {
            char[] postalChars = tboxAddressPostalCode.Text.ToCharArray();

            // Postal Code is too long
            if(postalChars.Length != 5) {
                return false;
            }

            // Check if PostalCode contains non-numbers
            foreach(char c in postalChars) {
                if(c < '0' || c > '9') {
                    return false;
                }
            }

            return true;
        }
        private void ResetForm() {
            // Temporarily Unsubscribe from Control Events
            tboxAddressAddress1.TextChanged -= OnFormUpdated;
            tboxAddressPhone.TextChanged -= OnFormUpdated;
            tboxAddressPostalCode.TextChanged -= OnFormUpdated;
            cmbAddressCityId.SelectedIndexChanged -= OnCityChanged;
            btnSave.Click -= OnSaveButtonClicked;
            btnCancel.Click -= OnCancelButtonClicked;
            btnAddNewCity.Click -= OnNewCityButtonClicked;

            // Clear Out Collections, as needed
            cmbAddressCityId.Items.Clear();

            // Set Defaults for Form
            tboxAddressId.Text = DBManager.GetNewIdFromTable("address", "addressId").ToString();
            tboxAddressAddress1.Text = "";
            tboxAddressAddress2.Text = "";
            tboxAddressPhone.Text = "";
            tboxAddressPostalCode.Text = "";

            // Fill ComboBoxes
            List<City> allCities = DBManager.GetAllCities();
            foreach(City city in allCities) {
                cmbAddressCityId.Items.Add(city.ID);
            }

            // Disable Default Buttons
            btnSave.Enabled = false;

            // Subscribe to Control Events
            tboxAddressAddress1.TextChanged += OnFormUpdated;
            tboxAddressPhone.TextChanged += OnFormUpdated;
            tboxAddressPostalCode.TextChanged += OnFormUpdated;
            cmbAddressCityId.SelectedIndexChanged += OnCityChanged;
            btnSave.Click += OnSaveButtonClicked;
            btnCancel.Click += OnCancelButtonClicked;
            btnAddNewCity.Click += OnNewCityButtonClicked;

            // Set City to First Index
            cmbAddressCityId.SelectedIndex = 0;
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
        private void OnNewCityFormSaved(object sender, EventArgs e) {
            ResetForm();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e) {
            // Create a New Address and Parse it into an insertValues string to send to DBManager for INSERT INTO SQL statement
            int addressId = int.Parse(tboxAddressId.Text);
            int cityId = int.Parse(cmbAddressCityId.SelectedItem.ToString());

            Address newAddress = new Address(addressId, tboxAddressAddress1.Text, tboxAddressAddress2.Text, cityId, tboxAddressPostalCode.Text, tboxAddressPhone.Text, DateTime.Now, formOwner.Username, DateTime.Now, formOwner.Username);
            string insertValues = $"{newAddress.ID}, \"{newAddress.Address1}\", \"{newAddress.Address2}\", {newAddress.CityID}, \"{newAddress.PostalCode}\", \"{newAddress.Phone}\", \"{newAddress.DateCreated:yyyy-MM-dd HH:mm:ss}\", \"{newAddress.CreatedBy}\", " +
                $"\"{newAddress.DateLastUpdated:yyyy-MM-dd HH:mm:ss}\", \"{newAddress.LastUpdatedBy}\"";

            // Use DBManager to attempt to Insert new record
            int rowsAdded = DBManager.InsertNewRecord("address", insertValues);

            // Check if new rows were successfully added
            if(rowsAdded > 0) {
                // Success!
                MessageBox.Show("New Address Successfully added to database!");
                EventLogger.LogUnspecifiedEntry($"{formOwner} created new Address with ID {newAddress.ID}");
                OnFormSaved();
            }
            else {
                MessageBox.Show("Something went wrong.");
            }
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        private void OnNewCityButtonClicked(object sender, EventArgs e) {
            NewCityForm newCityForm = new NewCityForm(formOwner);
            newCityForm.FormSaved += OnNewCityFormSaved;
            newCityForm.ShowDialog();
        }
        #endregion
    }
}
