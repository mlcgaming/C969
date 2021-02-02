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
    public partial class SelectAddressForm : Form {
        private UserAccount formOwner;

        public new event EventHandler<SelectFormEventArgs> FormClosing;

        public SelectAddressForm(UserAccount user) {
            InitializeComponent();

            formOwner = user;
        }

        private void SelectAddressForm_Load(object sender, EventArgs e) {
            ResetForm();
        }

        #region Form Functions
        private void ResetForm() {
            // Unsubscribe from all Control Events
            cmbAddressId.SelectedIndexChanged -= OnNewAddressSelected;
            btnCancel.Click -= OnCancelButtonClicked;
            btnDelete.Click -= OnDeleteButtonClicked;
            btnModify.Click -= OnModifyButtonClicked;

            // Clear existing collections, if needed
            cmbAddressId.Items.Clear();

            // Build new ComboBox list
            List<Address> allAddresss = DBManager.GetAllAddresses();
            foreach(var addr in allAddresss) {
                cmbAddressId.Items.Add(addr.ID);
            }

            // Subscribe to Control Events
            cmbAddressId.SelectedIndexChanged += OnNewAddressSelected;
            btnCancel.Click += OnCancelButtonClicked;
            btnDelete.Click += OnDeleteButtonClicked;
            btnModify.Click += OnModifyButtonClicked;

            // Set AddressId to first available value
            cmbAddressId.SelectedIndex = 0;
        }
        private void SetDetailsWindow(Address address) {
            // Clear the Details textbox
            tboxDetails.Text = "";

            // Build the string entry
            StringBuilder entryBuilder = new StringBuilder();
            entryBuilder.Append($"Address ID: {address.ID}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Address: {address.Address1}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Apt/Suite/Unit: {address.Address2}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"City ID: {address.CityID}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Postal Code: {address.PostalCode}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Phone: {address.Phone}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Date Created: {address.DateCreated}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Created By: {address.CreatedBy}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Date Last Updated: {address.DateLastUpdated}");
            entryBuilder.Append($"\r\n");
            entryBuilder.Append($"Last Updated By: {address.LastUpdatedBy}");

            // Enter the String once ready
            tboxDetails.Text = entryBuilder.ToString();
        }
        #endregion

        #region Event Functions
        private void OnNewAddressSelected(object sender, EventArgs e) {
            Address selectedAddress = DBManager.GetAddressById(int.Parse(cmbAddressId.SelectedItem.ToString()));
            SetDetailsWindow(selectedAddress);
        }

        private void OnModifyButtonClicked(object sender, EventArgs e) {
            int addressId = int.Parse(cmbAddressId.SelectedItem.ToString());
            Address selectedAddress = DBManager.GetAddressById(addressId);

            if(selectedAddress != null) {
                // Create a Modify Form and pass the Address in!
                ModifyAddressForm modifyAddressForm = new ModifyAddressForm(formOwner, selectedAddress);
                FormClosing?.Invoke(null, new SelectFormEventArgs(modifyAddressForm));
                Close();
            }
            else {
                MessageBox.Show("Error loading address from database.");
            }
        }
        private void OnDeleteButtonClicked(object sender, EventArgs e) {
            DialogResult confirmMessage = MessageBox.Show("Are you sure you want to delete this Address?", "This delete is PERMANENT", MessageBoxButtons.YesNo);

            if(confirmMessage == DialogResult.Yes) {
                // Delete the Record and Reset the Form
                int rowsAffected = DBManager.DeleteRecord("address", $"addressId = {int.Parse(cmbAddressId.SelectedItem.ToString())}");

                if(rowsAffected > 0) {
                    MessageBox.Show("Record deleted successfully!");
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
