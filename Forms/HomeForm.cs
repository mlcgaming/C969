using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C969.DBItems;
using C969.Events;

namespace C969 {
    public partial class HomeForm : Form {
        private UserAccount activeUser;

        private List<UserAccount> allUsers;
        private List<Appointment> allAppointments;
        private List<Customer> allCustomers;
        private List<Address> allAddresses;
        private List<City> allCities;
        private List<Country> allCountries;

        private List<AppointmentListing> userAppointments;

        private DateTime earliestAppointmentViewDate;
        private DateTime latestAppointmentViewDate;

        public HomeForm() {
            InitializeComponent();

            allUsers = new List<UserAccount>();
            allAppointments = new List<Appointment>();
            allCustomers = new List<Customer>();
            allAddresses = new List<Address>();
            allCities = new List<City>();
            allCountries = new List<Country>();

            userAppointments = new List<AppointmentListing>();
        }
        private void HomeForm_Load(object sender, EventArgs e) {
            Settings.Initialize();

            activeUser = null;

            LoginForm loginForm = new LoginForm();
            loginForm.UserLoggedIn += OnUserLoggedIn;
            loginForm.FormClosing += OnLoginFormClosed;
            loginForm.ShowDialog();
        }


        #region Form Functions
        private void CleanupCustomerAndAddressDetailsLabels() {
            lblAddressAddress1Data.Text = "";
            lblAddressAddress2Data.Text = "";
            lblAddressCreatedByData.Text = "";
            lblAddressLastUpdatedData.Text = "";
            lblAddressPhoneData.Text = "";
            lblAddressPostalCodeData.Text = "";
            lblAddressCityData.Text = "";

            lblCustomerActiveData.Text = "";
            lblCustomerNameData.Text = "";
            lblCustomerAddressData.Text = "";
            lblCustomerCreatedData.Text = "";
            lblCustomerLastUpdatedData.Text = "";
        }
        private void ResetHomeForm() {
            // Temporarily Unsubcribe from Control Events
            #region MenuItem Selection Events
            newUserToolStripMenuItem.Click -= OnNewUserMenuItemSelected;
            modifyUserToolStripMenuItem.Click -= OnModifyUserMenuItemSelected;
            deleteUserToolStripMenuItem.Click -= OnDeleteUserMenuItemSelected;

            newAppointmentToolStripMenuItem.Click -= OnNewAppointmentMenuItemSelected;
            modifyAppointmentToolStripMenuItem.Click -= OnModifyAppointmentMenuItemSelected;
            deleteAppointmentToolStripMenuItem.Click -= OnDeleteAppointmentMenuItemSelected;

            newCustomerToolStripMenuItem.Click -= OnNewCustomerMenuItemSelected;
            modifyCustomerToolStripMenuItem.Click -= OnModifyCustomerMenuItemSelected;
            deleteCustomerToolStripMenuItem.Click -= OnDeleteCustomerMenuItemSelected;

            newAddressToolStripMenuItem.Click -= OnNewAddressMenuItemSelected;
            modifyAddressToolStripMenuItem.Click -= OnModifyAddressMenuItemSelected;
            deleteAddressToolStripMenuItem.Click -= OnDeleteAddressMenuItemSelected;
            #endregion
            #region ComboBox Selection Events
            cmbCustomerId.SelectedIndexChanged -= OnCustomerIdSelectionChanged;
            cmbAddressId.SelectedIndexChanged -= OnAddressIdSelectionChanged;
            #endregion
            #region
            radioDateMonthly.CheckedChanged -= OnDateViewMonthlyCheckedChanged;
            radioDateWeekly.CheckedChanged -= OnDateViewWeeklyCheckedChanged;
            radioTimeUTC.CheckedChanged -= OnTimeViewUTCCheckedChanged;
            radioTimeLocal.CheckedChanged -= OnTimeViewLocalCheckedChanged;
            #endregion

            // Disconnect dvgAppointmentList from userAppointments, if needed
            if(dgvAppointmentList.DataSource != null) {
                dgvAppointmentList.DataSource = null;
            }

            // Set Appointment Window to range from beginning to end of current week
            var diff = DateTime.Now.DayOfWeek - CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            if(diff < 0) { diff += 7; }

            earliestAppointmentViewDate = DateTime.Now.AddDays(-diff).Date;
            latestAppointmentViewDate = earliestAppointmentViewDate.AddDays(6);

            // Clear out lists, if needed
            allUsers.Clear();
            allAppointments.Clear();
            allCustomers.Clear();
            allAddresses.Clear();
            allCities.Clear();
            allCountries.Clear();
            userAppointments.Clear();

            // Get Current Data from Database
            allUsers = DBManager.GetAllUserAccounts();
            allAppointments = DBManager.GetAllAppointments();
            allCustomers = DBManager.GetAllCustomers();
            allAddresses = DBManager.GetAllAddresses();
            allCities = DBManager.GetAllCities();
            allCountries = DBManager.GetAllCountries();

            // Perform HomeForm setup using activeUser
            CleanupCustomerAndAddressDetailsLabels();

            // Fill Read-Only HomeForm Controls
            foreach(var customer in allCustomers) {
                cmbCustomerId.Items.Add(customer.CustomerID.ToString());
            }

            foreach(var address in allAddresses) {
                cmbAddressId.Items.Add(address.ID.ToString());
            }

            // Create a filtered view of all user appointments based on Weekly/Monthly view option chosen
            IEnumerable<Appointment> filteredAppointments =
                    from appt in allAppointments
                    where appt.UserID == activeUser.ID
                    select appt;

            foreach(var appt in filteredAppointments) {
                if(appt.StartTime >= earliestAppointmentViewDate &&
                    appt.EndTime <= latestAppointmentViewDate) {
                    // It is cleaner and more straightforward to use these lambdas with LINQ to select the items we need, rather than build a wholly separate function for these
                    string userName = allUsers.Where(name => name.ID == appt.UserID).Select(name => name.Username).ElementAt(0);
                    string customerName = allCustomers.Where(name => name.CustomerID == appt.CustomerID).Select(name => name.Name).ElementAt(0);

                    DateTime apptStart = appt.StartTime;
                    DateTime apptEnd = appt.EndTime;

                    if(radioTimeLocal.Checked == true) {
                        apptStart = apptStart.ToLocalTime();
                        apptEnd = apptEnd.ToLocalTime();
                    }
                    else {
                        apptStart = apptStart.ToUniversalTime();
                        apptEnd = apptEnd.ToUniversalTime();
                    }

                    AppointmentListing listing = new AppointmentListing(appt.ID, userName, customerName, appt.Title, appt.Description, appt.Type, apptStart, apptEnd);
                    userAppointments.Add(listing);
                }
            }

            if(userAppointments.Count > 0) {
                dgvAppointmentList.DataSource = userAppointments;
            }

            // Set Any Additional Labels, as necessary
            lblAppointmentDateRange.Text = $"Viewing User Appointments from\r\n{earliestAppointmentViewDate.ToString("dd MMM yyyy")} to {latestAppointmentViewDate.ToString("dd MMM yyyy")}";

            // Subscribe to Controls
            #region MenuItem Selection Events
            newUserToolStripMenuItem.Click += OnNewUserMenuItemSelected;
            modifyUserToolStripMenuItem.Click += OnModifyUserMenuItemSelected;
            deleteUserToolStripMenuItem.Click += OnDeleteUserMenuItemSelected;

            newAppointmentToolStripMenuItem.Click += OnNewAppointmentMenuItemSelected;
            modifyAppointmentToolStripMenuItem.Click += OnModifyAppointmentMenuItemSelected;
            deleteAppointmentToolStripMenuItem.Click += OnDeleteAppointmentMenuItemSelected;

            newCustomerToolStripMenuItem.Click += OnNewCustomerMenuItemSelected;
            modifyCustomerToolStripMenuItem.Click += OnModifyCustomerMenuItemSelected;
            deleteCustomerToolStripMenuItem.Click += OnDeleteCustomerMenuItemSelected;

            newAddressToolStripMenuItem.Click += OnNewAddressMenuItemSelected;
            modifyAddressToolStripMenuItem.Click += OnModifyAddressMenuItemSelected;
            deleteAddressToolStripMenuItem.Click += OnDeleteAddressMenuItemSelected;
            #endregion
            #region ComboBox Selection Events
            cmbCustomerId.SelectedIndexChanged += OnCustomerIdSelectionChanged;
            cmbAddressId.SelectedIndexChanged += OnAddressIdSelectionChanged;
            #endregion
            #region
            radioDateMonthly.CheckedChanged += OnDateViewMonthlyCheckedChanged;
            radioDateWeekly.CheckedChanged += OnDateViewWeeklyCheckedChanged;
            radioTimeUTC.CheckedChanged += OnTimeViewUTCCheckedChanged;
            radioTimeLocal.CheckedChanged += OnTimeViewLocalCheckedChanged;
            #endregion
        }
        private void ReloadAppointmentCalendar() {
            if(userAppointments.Count > 0) {
                userAppointments = new List<AppointmentListing>();
                dgvAppointmentList.DataSource = null;
                dgvAppointmentList.Rows.Clear();
            }

            if(radioTimeLocal.Checked == true) {
                earliestAppointmentViewDate = earliestAppointmentViewDate.ToLocalTime();
                latestAppointmentViewDate = latestAppointmentViewDate.ToLocalTime();
            }
            else {
                earliestAppointmentViewDate = earliestAppointmentViewDate.ToUniversalTime();
                latestAppointmentViewDate = latestAppointmentViewDate.ToUniversalTime();
            }

            IEnumerable<Appointment> filteredAppointments =
                    from appt in allAppointments
                    where appt.UserID == activeUser.ID
                    select appt;

            foreach(var appt in filteredAppointments) {
                if(appt.StartTime >= earliestAppointmentViewDate &&
                    appt.EndTime <= latestAppointmentViewDate) {
                    // It is cleaner and more straightforward to use these lambdas with LINQ to select the items we need, rather than build a wholly separate function for these
                    string userName = allUsers.Where(name => name.ID == appt.UserID).Select(name => name.Username).ElementAt(0);
                    string customerName = allCustomers.Where(name => name.CustomerID == appt.CustomerID).Select(name => name.Name).ElementAt(0);

                    DateTime apptStart = appt.StartTime;
                    DateTime apptEnd = appt.EndTime;

                    if(radioTimeLocal.Checked == true) {
                        apptStart = apptStart.ToLocalTime();
                        apptEnd = apptEnd.ToLocalTime();
                        lblAppointmentDateRange.Text = $"Viewing User Appointments from\r\n{earliestAppointmentViewDate.ToLocalTime():dd MMM yyyy HH:mm:ss} to {latestAppointmentViewDate.ToLocalTime():dd MMM yyyy HH:mm:ss}";
                    }

                    if(radioTimeUTC.Checked == true) {
                        lblAppointmentDateRange.Text = $"Viewing User Appointments from\r\n{earliestAppointmentViewDate.ToUniversalTime():dd MMM yyyy HH:mm:ss} to {latestAppointmentViewDate.ToUniversalTime():dd MMM yyyy HH:mm:ss}";
                    }

                    AppointmentListing listing = new AppointmentListing(appt.ID, userName, customerName, appt.Title, appt.Description, appt.Type, apptStart, apptEnd);

                    

                    userAppointments.Add(listing);
                }
            }

            if(userAppointments.Count > 0) {
                dgvAppointmentList.DataSource = userAppointments;
            }
        }
        #endregion

        #region Event Functions
        private void OnLoginFormClosed(object sender, EventArgs e) {
            if(activeUser == null) {
                Close();
            }
            else {
                // Set Default View Options
                radioDateWeekly.Checked = true;
                radioDateMonthly.Checked = false;
                radioTimeLocal.Checked = true;
                radioTimeUTC.Checked = false;

                // Reset Home Form
                ResetHomeForm();
            }
        }
        private void OnUserLoggedIn(object sender, UserLoggedInEventArgs e) {
            activeUser = e.User;
        }
        private void OnFormSaved(object sender, EventArgs e) {
            ResetHomeForm();
        }

        private void OnNewUserMenuItemSelected(object sender, EventArgs e) {
            
        }
        private void OnModifyUserMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnDeleteUserMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnNewAppointmentMenuItemSelected(object sender, EventArgs e) {
            NewAppointmentForm newApptForm = new NewAppointmentForm();
            newApptForm.FormSaved += OnFormSaved;
            newApptForm.ShowDialog();
        }
        private void OnModifyAppointmentMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnDeleteAppointmentMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnNewCustomerMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnModifyCustomerMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnDeleteCustomerMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnNewAddressMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnModifyAddressMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnDeleteAddressMenuItemSelected(object sender, EventArgs e) {

        }
        private void OnCustomerIdSelectionChanged(object sender, EventArgs e) {
            int id = int.Parse(cmbCustomerId.SelectedItem.ToString());
            Customer currentCustomer = null;

            foreach(var customer in allCustomers) {
                if(customer.CustomerID == id) {
                    currentCustomer = customer;
                    break;
                }
            }

            if(currentCustomer == null) {
                MessageBox.Show("Could not load data.");
            }
            else {
                lblCustomerActiveData.Text = currentCustomer.IsActive.ToString();
                lblCustomerNameData.Text = currentCustomer.Name;
                lblCustomerAddressData.Text = DBManager.GetFullAddressById(currentCustomer.AddressID);
                lblCustomerCreatedData.Text = $"{currentCustomer.DateCreated.ToString("d MMM yy HH:mm")}" +
                    "\r\n" +
                    $"By User: {currentCustomer.CreatedBy}";
                lblCustomerLastUpdatedData.Text = $"{currentCustomer.DateLastUpdated.ToString("d MMM yy HH:mm")}" +
                    "\r\n" +
                    $"By User: {currentCustomer.LastUpdatedBy}";
            }
        }
        private void OnAddressIdSelectionChanged(object sender, EventArgs e) {
            int id = int.Parse(cmbAddressId.SelectedItem.ToString());
            Address currentAddress = null;

            foreach(var addr in allAddresses) {
                if(addr.ID == id) {
                    currentAddress = addr;
                    break;
                }
            }

            if(currentAddress == null) {
                MessageBox.Show("Could not load address data");
            }
            else {
                lblAddressAddress1Data.Text = currentAddress.Address1;
                lblAddressAddress2Data.Text = currentAddress.Address2;
                lblAddressCityData.Text = DBManager.GetCityById(currentAddress.CityID).Name ?? "CITY NOT FOUND";
                lblAddressPhoneData.Text = currentAddress.Phone;
                lblAddressPostalCodeData.Text = currentAddress.PostalCode;
                lblAddressCreatedByData.Text = $"{currentAddress.DateCreated.ToString("d MMM yy HH:mm")}" +
                    $"\r\n" +
                    $"By User: {currentAddress.CreatedBy}";
                lblAddressLastUpdatedData.Text = $"{currentAddress.DateLastUpdated.ToString("d MMM yy HH:mm")}" +
                    $"\r\n" +
                    $"By User: {currentAddress.LastUpdatedBy}";
            }
        }
        private void OnDateViewWeeklyCheckedChanged(object sender, EventArgs e) {
            if(radioDateWeekly.Checked == true) {
                radioDateMonthly.Checked = false;

                // Set Appointment Window to range from beginning to end of current week
                var diff = DateTime.Now.DayOfWeek - CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
                if(diff < 0) { diff += 7; }

                earliestAppointmentViewDate = DateTime.Now.AddDays(-diff).Date;
                latestAppointmentViewDate = earliestAppointmentViewDate.AddDays(6);

                ReloadAppointmentCalendar();
            }
        }
        private void OnDateViewMonthlyCheckedChanged(object sender, EventArgs e) {
            if(radioDateMonthly.Checked == true) {
                radioDateWeekly.Checked = false;

                // Set Appointment Window to range from 1st of current month to end of current month
                earliestAppointmentViewDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                latestAppointmentViewDate = earliestAppointmentViewDate.AddMonths(1).AddTicks(-1);

                ReloadAppointmentCalendar();
            }
        }
        private void OnTimeViewUTCCheckedChanged(object sender, EventArgs e) {
            if(radioTimeUTC.Checked == true) {
                radioTimeLocal.Checked = false;
                ReloadAppointmentCalendar();
            }
        }
        private void OnTimeViewLocalCheckedChanged(object sender, EventArgs e) {
            if(radioTimeLocal.Checked == true) {
                radioTimeUTC.Checked = false;
                ReloadAppointmentCalendar();
            }
        }
        #endregion
    }
}
