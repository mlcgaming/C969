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
using C969.Exceptions;

namespace C969 {
    public partial class ModifyAppointmentForm : SaveableForm {
        private Appointment currentAppointment;

        public ModifyAppointmentForm(UserAccount user, Appointment appointment) {
            InitializeComponent();

            formOwner = user;
            currentAppointment = appointment;
        }

        private void ModifyAppointmentForm_Load(object sender, EventArgs e) {
            ResetForm();
        }

        #region Form Functions
        private void ValidateForm() {
            bool isFormValid = true;

            // Make sure Title contains characters
            if(Validator.IsControlEmptyOrWhitespace(tboxAppointmentTitle)) {
                isFormValid = false;
            }

            // Make sure Description contains characters
            if(Validator.IsControlEmptyOrWhitespace(tboxAppointmentDescription)) {
                isFormValid = false;
            }

            // Make sure Location contains characters
            if(Validator.IsControlEmptyOrWhitespace(tboxAppointmentLocation)) {
                isFormValid = false;
            }

            // Make sure Contact contains characters, but not special characters
            if(Validator.IsControlEmptyOrWhitespace(tboxAppointmentContact)) {
                isFormValid = false;
            }
            else {
                if(Validator.IsTextFreeOfSpecialCharacters(tboxAppointmentContact.Text) == false) {
                    isFormValid = false;
                    lblAppointmentContactWarning.Visible = true;
                }
                else {
                    lblAppointmentContactWarning.Visible = false;
                }
            }

            // Make sure URL contains characters
            if(Validator.IsControlEmptyOrWhitespace(tboxAppointmentUrl)) {
                isFormValid = false;
            }

            // Using isFormValid, Enable or Disable the Save button
            if(isFormValid) {
                btnSave.Enabled = true;
            }
            else {
                btnSave.Enabled = false;
            }
        }
        private void ResetForm() {
            // Disable Contact Warning Until Needed
            lblAppointmentContactWarning.Visible = false;

            // Get New Appointment ID
            tboxAppointmentId.Text = currentAppointment.ID.ToString();

            // Populate the ComboBoxes for UserId's, CustomerId's, and AppointmentTypes
            List<UserAccount> users = DBManager.GetAllUserAccounts();
            List<Customer> customers = DBManager.GetAllCustomers();

            foreach(var user in users) {
                cmbUserId.Items.Add(user.ID);
            }

            foreach(var cust in customers) {
                cmbCustomerId.Items.Add(cust.CustomerID);
            }

            foreach(var type in Settings.AppointmentTypes) {
                cmbAppointmentTypes.Items.Add(type);
            }

            // Set Starting Values
            tboxAppointmentTitle.Text = currentAppointment.Title;
            tboxAppointmentDescription.Text = currentAppointment.Description;
            tboxAppointmentLocation.Text = currentAppointment.Location;
            tboxAppointmentContact.Text = currentAppointment.Contact;
            tboxAppointmentUrl.Text = currentAppointment.URL;

            // Disable the Save button until Validation has been completed
            btnSave.Enabled = false;

            // Set Default DateTimes
            dtpAppointmentStart.Value = currentAppointment.StartTime.ToLocalTime();
            dtpAppointmentEnd.Value = currentAppointment.EndTime.ToLocalTime();

            // Subscribe to Control events
            tboxAppointmentTitle.TextChanged += OnFormUpdated;
            tboxAppointmentDescription.TextChanged += OnFormUpdated;
            tboxAppointmentLocation.TextChanged += OnFormUpdated;
            tboxAppointmentContact.TextChanged += OnFormUpdated;
            tboxAppointmentUrl.TextChanged += OnFormUpdated;
            cmbAppointmentTypes.SelectedIndexChanged += OnFormUpdated;
            cmbUserId.SelectedIndexChanged += OnUserChanged;
            cmbUserId.SelectedIndexChanged += OnFormUpdated;
            cmbCustomerId.SelectedIndexChanged += OnCustomerChanged;
            cmbCustomerId.SelectedIndexChanged += OnFormUpdated;
            btnSave.Click += OnSaveButtonClicked;
            btnCancel.Click += OnCancelButtonClicked;

            // Set Default Selections in ComboBoxes
            cmbAppointmentTypes.SelectedItem = currentAppointment.Type;
            cmbCustomerId.SelectedItem = currentAppointment.CustomerID;
            cmbUserId.SelectedItem = currentAppointment.UserID;
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
        private void OnCustomerChanged(object sender, EventArgs e) {
            lblCustomerName.Text = $"Customer: {DBManager.GetCustomerById(int.Parse(cmbCustomerId.SelectedItem.ToString())).Name}";
        }
        private void OnUserChanged(object sender, EventArgs e) {
            lblUserName.Text = $"Username: {DBManager.GetUserById(int.Parse(cmbUserId.SelectedItem.ToString())).Username}";
        }

        private void OnSaveButtonClicked(object sender, EventArgs e) {
            // Validate Appointment Dates before Saving
            try {
                int userId = int.Parse(cmbUserId.SelectedItem.ToString());
                List<Appointment> allAppointments = DBManager.GetAllAppointments();

                DateTime proposedStart = dtpAppointmentStart.Value;
                DateTime proposedEnd = dtpAppointmentEnd.Value;

                if(proposedStart > proposedEnd) {
                    throw new AppointmentTimesInvalidException("EndTime must come after StartTime");
                }

                if(proposedStart.Hour < 8 || proposedStart.Hour > 17) {
                    throw new AppointmentOutsideBusinessHoursException();
                }

                if(proposedEnd.Hour < 8 || proposedEnd.Hour > 17) {
                    throw new AppointmentOutsideBusinessHoursException();
                }

                IEnumerable<Appointment> userAppointments =
                    from appt in allAppointments
                    where appt.StartTime.Date == proposedStart.Date || appt.EndTime.Date == proposedEnd.Date
                    select appt;

                foreach(var appt in userAppointments) {
                    if((appt.StartTime >= proposedStart && appt.StartTime <= proposedEnd)
                        || (appt.EndTime >= proposedStart && appt.EndTime <= proposedEnd)
                        || (proposedStart >= appt.StartTime && proposedStart <= appt.EndTime)
                        || (proposedEnd >= appt.StartTime && proposedEnd <= appt.EndTime)) {

                        if(appt.ID != int.Parse(tboxAppointmentId.Text)) {
                            throw new AppointmentOverlapException($"Appointment overlaps with another appointment [ApptID #{appt.ID}]");
                        }
                    }
                }

                // Created a new appointment using the form data, parse that object into a INSERT INTO .. VALUES string and use DBManager to push it
                int appointmentId = int.Parse(tboxAppointmentId.Text);
                int customerId = int.Parse(cmbCustomerId.SelectedItem.ToString());
                string title = tboxAppointmentTitle.Text;
                string description = tboxAppointmentDescription.Text;
                string location = tboxAppointmentLocation.Text;
                string contact = tboxAppointmentContact.Text;
                string type = cmbAppointmentTypes.SelectedItem.ToString();
                string url = tboxAppointmentUrl.Text;
                DateTime start = dtpAppointmentStart.Value.ToUniversalTime();
                DateTime end = dtpAppointmentEnd.Value.ToUniversalTime();
                DateTime createDate = currentAppointment.CreateDate.ToUniversalTime();
                string createdBy = currentAppointment.CreatedBy;
                DateTime lastUpdate = DateTime.Now.ToUniversalTime();
                string lastUpdatedBy = formOwner.Username;

                Appointment newAppointment = new Appointment(appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdatedBy);
                string insertValues = $"appointmentId = {appointmentId}, customerId = {customerId}, userId = {userId}, title = \"{title}\", description = \"{description}\", location = \"{location}\", contact = \"{contact}\", " +
                    $"type = \"{type}\", url = \"{url}\", start = \"{start:yyyy-MM-dd HH:mm:ss}\", end = \"{end:yyyy-MM-dd HH:mm:ss}\", createDate = \"{createDate:yyyy-MM-dd HH:mm:ss}\", createdBy = \"{createdBy}\", " +
                    $"lastUpdate = \"{lastUpdate:yyyy-MM-dd HH:mm:ss}\", lastUpdateBy\"{lastUpdatedBy}\"";
                int rowsAffected = DBManager.UpdateRecord("appointment", insertValues, $"appointmentId = {int.Parse(tboxAppointmentId.Text)}");

                // Check Rows Affected to see if the record saved correctly
                if(rowsAffected > 0) {
                    // Success! Return to the HomeForm by triggering the FormSaved event (so HomeForm reloads its data from the Database)
                    MessageBox.Show($"{rowsAffected} record(s) saved!");
                    EventLogger.LogUnspecifiedEntry($"{formOwner} updated Appointment with ID {appointmentId}");
                    OnFormSaved();
                }
                else {
                    // Something went wrong, exit with a warning
                    MessageBox.Show("Record could not be updated.");
                }
            }
            catch(AppointmentOverlapException ex) {
                MessageBox.Show(ex.Message);
            }
            catch(AppointmentOutsideBusinessHoursException ex) {
                MessageBox.Show(ex.Message);
            }
            catch(AppointmentTimesInvalidException ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
