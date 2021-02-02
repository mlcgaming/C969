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
    public partial class NewCityForm : SaveableForm {
        public NewCityForm(UserAccount user) {
            InitializeComponent();

            formOwner = user;
        }

        private void NewCityForm_Load(object sender, EventArgs e) {
            ResetForm();
        }

        #region Form Functions
        private void ValidateForm() {
            bool formIsValid = true;

            // Check City Name for empty/whitespace or invalid characters
            if(Validator.IsControlEmptyOrWhitespace(tboxCityName) || Validator.IsTextFreeOfSpecialCharacters(tboxCityName.Text) == false) {
                formIsValid = false;
            }

            // Enable/Disable Saving based on Validation
            if(formIsValid) {
                btnSave.Enabled = true;
            }
            else {
                btnSave.Enabled = false;
            }
        }
        private void ResetForm() {
            // Temporarily Unsubsribe to Control Events
            btnSave.Click -= OnSaveButtonClicked;
            btnCancel.Click -= OnCancelButtonClicked;
            btnAddNewCountry.Click -= OnNewCountryButtonClicked;
            tboxCityName.TextChanged -= OnFormUpdated;
            cmbCityCountryId.SelectedIndexChanged -= OnNewCountrySelected;

            // Clear any existing collections
            cmbCityCountryId.Items.Clear();

            // Set Default Values on TextBoxes and Labels
            tboxCityId.Text = DBManager.GetNewIdFromTable("city", "cityId").ToString();
            tboxCityName.Text = "";

            // Fill CountryID ComboBox with most current data
            List<Country> allCountries = DBManager.GetAllCountries();
            foreach(var country in allCountries) {
                cmbCityCountryId.Items.Add(country.ID);
            }

            // Enable / Disable Controls as needed
            btnSave.Enabled = false;

            // Subscribe to Control Events
            btnSave.Click += OnSaveButtonClicked;
            btnCancel.Click += OnCancelButtonClicked;
            btnAddNewCountry.Click += OnNewCountryButtonClicked;
            tboxCityName.TextChanged += OnFormUpdated;
            cmbCityCountryId.SelectedIndexChanged += OnNewCountrySelected;

            // Set CountryID dropdown to first item in list
            cmbCityCountryId.SelectedIndex = 0;
        }
        #endregion

        #region Event Functions
        protected override void OnFormSaved() {
            base.OnFormSaved();
            Close();
        }
        private void OnNewCountryFormSaved(object sender, EventArgs e) {
            ResetForm();
        }
        private void OnFormUpdated(object sender, EventArgs e) {
            ValidateForm();
        }

        private void OnNewCountrySelected(object sender, EventArgs e) {
            Country selectedCountry = DBManager.GetCountryById(int.Parse(cmbCityCountryId.SelectedItem.ToString()));
            lblCityCountryNameValue.Text = selectedCountry?.Name ?? "COUNTRY NOT FOUND";
        }
        private void OnNewCountryButtonClicked(object sender, EventArgs e) {
            NewCountryForm newCountryForm = new NewCountryForm(formOwner);
            newCountryForm.FormSaved += OnNewCountryFormSaved;
            newCountryForm.ShowDialog();
        }
        private void OnSaveButtonClicked(object sender, EventArgs e) {
            // Create a New City object then parse it into an insertValues string to feed DBManager and attempt to add to the CITY table
            City newCity = new City(int.Parse(tboxCityId.Text), tboxCityName.Text, int.Parse(cmbCityCountryId.SelectedItem.ToString()), DateTime.Now, formOwner.Username, DateTime.Now, formOwner.Username);
            string insertValues = $"{newCity.ID}, \"{newCity.Name}\", {newCity.CountryID}, \"{newCity.DateCreated:yyyy-MM-dd HH:mm:ss}\", \"{newCity.CreatedBy}\", \"{newCity.DateLastUpdated:yyyy-MM-dd HH:mm:ss}\", \"{newCity.LastUpdatedBy}\"";

            // Use DBManager to Attempt to Insert the new record
            int rowsAdded = DBManager.InsertNewRecord("city", insertValues);

            // Check if any new rows were added
            if(rowsAdded > 0) {
                // Success! Fire off the OnFormSaved event to close the form properly
                MessageBox.Show("New City Saved Successfully!");
                OnFormSaved();
            }
            else {
                MessageBox.Show("Something went wrong. New City not saved.");
            }
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
