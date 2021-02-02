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
    public partial class ScheduleByUserForm : Form {
        public ScheduleByUserForm() {
            InitializeComponent();
        }

        private void ScheduleByUserForm_Load(object sender, EventArgs e) {
            ResetForm();
        }

        #region Form Functions
        private void ResetForm() {
            // Unsubscribe from Control Events, if needed
            btnCancel.Click -= OnCancelButtonClicked;
            btnGenerate.Click -= OnGenerateButtonClicked;
            cmbUserId.SelectedIndexChanged -= OnNewUserSelected;

            // Get Data for User DropDown
            List<UserAccount> allUsers = DBManager.GetAllUserAccounts();
            foreach(var user in allUsers) {
                cmbUserId.Items.Add(user.ID);
            }

            // Subsribe to Control Events
            btnCancel.Click += OnCancelButtonClicked;
            btnGenerate.Click += OnGenerateButtonClicked;
            cmbUserId.SelectedIndexChanged += OnNewUserSelected;

            // Select first option for UserId
            cmbUserId.SelectedIndex = 0;
        }
        private void OrderAppointments(List<Appointment> appointments) {

        }
        #endregion

        #region Event Functions
        private void OnNewUserSelected(object sender, EventArgs e) {
            int id = int.Parse(cmbUserId.SelectedItem.ToString());
            UserAccount user = DBManager.GetUserById(id);
            lblUsername.Text = $"User: {user.Username}";
        }

        private void OnGenerateButtonClicked(object sender, EventArgs e) {
            // First, get a list of all appointments
            List<Appointment> allAppointments = DBManager.GetAllAppointments();

            // Filter through all Appointments and grab only those for specified user, sorting by StartTime in ascending order
            IEnumerable<Appointment> sortedAppointments =
                from appt in allAppointments
                orderby appt.StartTime ascending
                where appt.UserID == int.Parse(cmbUserId.SelectedItem.ToString())
                select appt;

            // Display the list!
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.Append($"Ordered Appointments for User {DBManager.GetUserById(int.Parse(cmbUserId.SelectedItem.ToString())).Username}\r\n\r\n");
            foreach(var appt in sortedAppointments) {
                reportBuilder.Append($"[{appt.ID}] {appt.Title} Contact: {appt.Contact} Start: {appt.StartTime.ToString("MMM dd yyyy HH:mm tt")}\r\n");
            }

            MessageBox.Show(reportBuilder.ToString());
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
