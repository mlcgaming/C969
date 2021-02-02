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
    public partial class ReportByTypeMonthForm : Form {
        public ReportByTypeMonthForm() {
            InitializeComponent();
        }

        private void ReportByTypeMonthForm_Load(object sender, EventArgs e) {
            ResetForm();
        }


        #region Form Functions
        private void ResetForm() {
            // Unsubscribe from all Control Events, if needed
            btnCancel.Click -= OnCancelButtonClicked;
            btnGenerate.Click -= OnGenerateButtonClicked;

            // Fill ComboBoxes with pertinent options
            foreach(var type in Settings.AppointmentTypes) {
                cmbAppointmentType.Items.Add(type);
            }

            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 1, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 2, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 3, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 4, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 5, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 6, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 7, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 8, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 9, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 10, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 11, 1).ToString("MMMM"));
            cmbMonth.Items.Add(new DateTime(DateTime.Now.Year, 12, 1).ToString("MMMM"));

            // Select First Option for both Comboboxes
            cmbMonth.SelectedIndex = 0;
            cmbAppointmentType.SelectedIndex = 0;

            // Subscribe to Control Events
            btnCancel.Click += OnCancelButtonClicked;
            btnGenerate.Click += OnGenerateButtonClicked;
        }
        #endregion

        #region Event Functions
        private void OnGenerateButtonClicked(object sender, EventArgs e) {
            string type = cmbAppointmentType.SelectedItem.ToString();
            string month = cmbMonth.SelectedItem.ToString();

            List<Appointment> allAppointments = DBManager.GetAllAppointments();
            List<Appointment> filteredAppointments = new List<Appointment>();

            foreach(var appt in allAppointments) {
                if(appt.StartTime.ToString("MMMM") == month &&
                    appt.Type == cmbAppointmentType.SelectedItem.ToString()) {
                    filteredAppointments.Add(appt);
                }
            }

            if(filteredAppointments.Count > 0) {
                // Display the report
                StringBuilder reportBuilder = new StringBuilder();
                reportBuilder.Append($"Found {filteredAppointments.Count} appointments that match.\r\n\r\n");
                reportBuilder.Append("Appointments Found:\r\n");

                foreach(var appt in filteredAppointments) {
                    reportBuilder.Append($"[{appt.ID}] {appt.Title} Contact: {appt.Contact} Start: {appt.StartTime.ToString("MMM dd yyyy HH:mm tt")}");
                    reportBuilder.Append("\r\n");
                }

                MessageBox.Show(reportBuilder.ToString());
            }
            else {
                MessageBox.Show("No Appointments match TYPE and MONTH selected.");
            }
        }
        private void OnCancelButtonClicked(object sender, EventArgs e) {
            Close();
        }
        #endregion
    }
}
