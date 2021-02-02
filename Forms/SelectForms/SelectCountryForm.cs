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
using C969.Events;

namespace C969 {
    public partial class SelectCountryForm : Form {
        private UserAccount formOwner;

        public new event EventHandler<SelectFormEventArgs> FormClosing;

        public SelectCountryForm(UserAccount user) {
            InitializeComponent();

            formOwner = user;
        }

        private void SelectCountryForm_Load(object sender, EventArgs e) {
            ResetForm();
        }

        #region Form Functions
        private void ResetForm() {
            // Unsubscribe from all Control Events
            cmbCountryId.SelectedIndexChanged -= OnNewCountrySelected;
            btnCancel.Click -= OnCancelButtonClicked;
            btnDelete.Click -= OnDeleteButtonClicked;
            btnModify.Click -= OnModifyButtonClicked;

            // Clear existing collections, if needed
            cmbCountryId.Items.Clear();

            // Build new ComboBox list
            List<Country> allCountries = DBManager.GetAllCountries();
            foreach(var country in allCountries) {
                cmbCountryId.Items.Add(country.ID);
            }

            // Subscribe to Control Events
            cmbCountryId.SelectedIndexChanged += OnNewCountrySelected;
            btnCancel.Click += OnCancelButtonClicked;
            btnDelete.Click += OnDeleteButtonClicked;
            btnModify.Click += OnModifyButtonClicked;

            // Set CountryId to first available value
            cmbCountryId.SelectedIndex = 0;
        }
        private void SetDetailsWindow(Country country) {
            // Clear the Details textbox
            tboxDetails.Text = "";

            // Build the string entry
            StringBuilder entryBuilder = new StringBuilder();
            entryBuilder.Append($"Country ID: {country.ID}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Country Name: {country.Name}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Date Created: {country.DateCreated}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Created By: {country.CreatedBy}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Date Last Updated: {country.DateLastUpdated}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Last Updated By: {country.LastUpdatedBy}");

            // Enter the String once ready
            tboxDetails.Text = entryBuilder.ToString();
        }
        #endregion

        #region Event Functions
        private void OnNewCountrySelected(object sender, EventArgs e) {
            Country selectedCountry = DBManager.GetCountryById(int.Parse(cmbCountryId.SelectedItem.ToString()));
            SetDetailsWindow(selectedCountry);
        }

        private void OnModifyButtonClicked(object sender, EventArgs e) {
            int countryId = int.Parse(cmbCountryId.SelectedItem.ToString());
            Country selectedCountry = DBManager.GetCountryById(countryId);

            if(selectedCountry != null) {
                // Create a Modify Form and pass the Country in!
                ModifyCountryForm modifyCountryForm = new ModifyCountryForm(formOwner, selectedCountry);
                FormClosing?.Invoke(null, new SelectFormEventArgs(modifyCountryForm));
                Close();
            }
            else {
                MessageBox.Show("Error loading country from database.");
            }
        }
        private void OnDeleteButtonClicked(object sender, EventArgs e) {
            DialogResult confirmMessage = MessageBox.Show("Are you sure you want to delete this Country?", "This delete is PERMANENT", MessageBoxButtons.YesNo);

            if(confirmMessage == DialogResult.Yes) {
                // Delete the Record and Reset the Form
                int rowsAffected = DBManager.DeleteRecord("country", $"countryId = {int.Parse(cmbCountryId.SelectedItem.ToString())}");

                if(rowsAffected > 0) {
                    MessageBox.Show("Record deleted successfully!");
                    EventLogger.LogUnspecifiedEntry($"{formOwner} deleted Country with ID {int.Parse(cmbCountryId.SelectedItem.ToString())}");
                    ResetForm();
                }
            }
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            FormClosing?.Invoke(null, new SelectFormEventArgs());
            Close();
        }
        #endregion
    }
}
