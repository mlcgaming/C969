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
    public partial class ModifyCountryForm : SaveableForm {
        private Country currentCountry;

        public ModifyCountryForm(UserAccount user, Country country) {
            InitializeComponent();

            formOwner = user;
            currentCountry = country;
        }

        private void ModifyCountryForm_Load(object sender, EventArgs e) {
            ResetForm();
        }

        #region Form Functions
        private void ValidateForm() {
            bool formIsValid = true;

            // Check if Country Name field is empty or contains invalid characters
            if(Validator.IsControlEmptyOrWhitespace(tboxCountryName) || Validator.IsTextFreeOfSpecialCharacters(tboxCountryName.Text) == false) {
                formIsValid = false;
            }

            // Enable or Disable the Save Button, depending on if the form's fields are all valid
            if(formIsValid) {
                btnSave.Enabled = true;
            }
            else {
                btnSave.Enabled = false;
            }
        }
        private void ResetForm() {
            // Unsubscribe from all Control Events, if needed
            btnCancel.Click -= OnCancelButtonClicked;
            btnSave.Click -= OnSaveButtonClicked;
            tboxCountryName.TextChanged -= OnFormUpdated;

            // Set Default Values of all fields
            tboxCountryId.Text = currentCountry.ID.ToString();
            tboxCountryName.Text = currentCountry.Name;

            // Subsribe to Control Events
            btnCancel.Click += OnCancelButtonClicked;
            btnSave.Click += OnSaveButtonClicked;
            tboxCountryName.TextChanged += OnFormUpdated;
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

        private void OnSaveButtonClicked(object sender, EventArgs e) {
            // Attempt to perform a Save to DB, if successful, fire off OnFormSaved so HomeForm knows to refresh its data, then Close
            Country newCountry = new Country(int.Parse(tboxCountryId.Text), tboxCountryName.Text, currentCountry.DateCreated, currentCountry.CreatedBy, DateTime.Now, formOwner.Username);

            // Created a string to apply an INSERT INTO SQL command
            string insertValues = $"countryId = {newCountry.ID}, country = \"{newCountry.Name}\", createDate = \"{newCountry.DateCreated:yyyy-MM-dd HH:mm:ss}\", " +
                $"createdBy = \"{newCountry.CreatedBy}\", lastUpdate = \"{newCountry.DateLastUpdated:yyyy-MM-dd HH:mm:ss}\", lastUpdateBy = \"{newCountry.LastUpdatedBy}\"";

            int rowsAffected = DBManager.UpdateRecord("country", insertValues, $"countryId = {newCountry.ID}");

            // Check Rows Affected to see if the record saved correctly
            if(rowsAffected > 0) {
                // Success! Return to the HomeForm by triggering the FormSaved event (so HomeForm reloads its data from the Database)
                MessageBox.Show($"{rowsAffected} record(s) saved! Retuning to Home Form.");
                OnFormSaved();
            }
            else {
                // Something went wrong, exit with a warning
                MessageBox.Show("Record did not insert into the database. This country has not been saved.");
            }
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
