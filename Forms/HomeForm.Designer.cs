namespace C969 {
    partial class HomeForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAppointmentList = new System.Windows.Forms.DataGridView();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerLastUpdated = new System.Windows.Forms.Label();
            this.lblCustomerLastUpdatedData = new System.Windows.Forms.Label();
            this.lblCustomerCreatedData = new System.Windows.Forms.Label();
            this.lblCustomerCreated = new System.Windows.Forms.Label();
            this.lblCustomerActiveData = new System.Windows.Forms.Label();
            this.lblCustomerActive = new System.Windows.Forms.Label();
            this.lblCustomerNameData = new System.Windows.Forms.Label();
            this.lblCustomerAddressData = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cmbCustomerId = new System.Windows.Forms.ComboBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.grpAddresses = new System.Windows.Forms.GroupBox();
            this.grpAddressDetails = new System.Windows.Forms.GroupBox();
            this.lblAddressCityData = new System.Windows.Forms.Label();
            this.lblAddressPhoneData = new System.Windows.Forms.Label();
            this.lblAddressPhone = new System.Windows.Forms.Label();
            this.lblAddressAddress2Data = new System.Windows.Forms.Label();
            this.lblAddressCity = new System.Windows.Forms.Label();
            this.lblAddressLastUpdated = new System.Windows.Forms.Label();
            this.lblAddressLastUpdatedData = new System.Windows.Forms.Label();
            this.lblAddressCreatedByData = new System.Windows.Forms.Label();
            this.lblAddressCreatedBy = new System.Windows.Forms.Label();
            this.lblAddressPostalCodeData = new System.Windows.Forms.Label();
            this.lblAddressPostalCode = new System.Windows.Forms.Label();
            this.lblAddressAddress1Data = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAddressAddress2 = new System.Windows.Forms.Label();
            this.lblAddressAddress1 = new System.Windows.Forms.Label();
            this.cmbAddressId = new System.Windows.Forms.ComboBox();
            this.lblAddressId = new System.Windows.Forms.Label();
            this.grpViewOptions = new System.Windows.Forms.GroupBox();
            this.panelTimeView = new System.Windows.Forms.Panel();
            this.radioTimeLocal = new System.Windows.Forms.RadioButton();
            this.radioTimeUTC = new System.Windows.Forms.RadioButton();
            this.lblTimeView = new System.Windows.Forms.Label();
            this.panelDateRange = new System.Windows.Forms.Panel();
            this.radioDateMonthly = new System.Windows.Forms.RadioButton();
            this.lblDateRangeView = new System.Windows.Forms.Label();
            this.radioDateWeekly = new System.Windows.Forms.RadioButton();
            this.lblAppointmentDateRange = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).BeginInit();
            this.grpCustomers.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            this.grpAddresses.SuspendLayout();
            this.grpAddressDetails.SuspendLayout();
            this.grpViewOptions.SuspendLayout();
            this.panelTimeView.SuspendLayout();
            this.panelDateRange.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.addressesToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.modifyUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newUserToolStripMenuItem.Text = "New";
            // 
            // modifyUserToolStripMenuItem
            // 
            this.modifyUserToolStripMenuItem.Name = "modifyUserToolStripMenuItem";
            this.modifyUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyUserToolStripMenuItem.Text = "Modify / Delete";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAppointmentToolStripMenuItem,
            this.modifyAppointmentToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // newAppointmentToolStripMenuItem
            // 
            this.newAppointmentToolStripMenuItem.Name = "newAppointmentToolStripMenuItem";
            this.newAppointmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newAppointmentToolStripMenuItem.Text = "New";
            // 
            // modifyAppointmentToolStripMenuItem
            // 
            this.modifyAppointmentToolStripMenuItem.Name = "modifyAppointmentToolStripMenuItem";
            this.modifyAppointmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyAppointmentToolStripMenuItem.Text = "Modify / Delete";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.modifyCustomerToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newCustomerToolStripMenuItem.Text = "New";
            // 
            // modifyCustomerToolStripMenuItem
            // 
            this.modifyCustomerToolStripMenuItem.Name = "modifyCustomerToolStripMenuItem";
            this.modifyCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyCustomerToolStripMenuItem.Text = "Modify / Delete";
            // 
            // dgvAppointmentList
            // 
            this.dgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentList.Location = new System.Drawing.Point(12, 27);
            this.dgvAppointmentList.Name = "dgvAppointmentList";
            this.dgvAppointmentList.Size = new System.Drawing.Size(776, 164);
            this.dgvAppointmentList.TabIndex = 1;
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.grpCustomerDetails);
            this.grpCustomers.Controls.Add(this.cmbCustomerId);
            this.grpCustomers.Controls.Add(this.lblCustomerId);
            this.grpCustomers.Location = new System.Drawing.Point(12, 197);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(250, 273);
            this.grpCustomers.TabIndex = 2;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Customers";
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.lblCustomerLastUpdated);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerLastUpdatedData);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerCreatedData);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerCreated);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerActiveData);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerActive);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerNameData);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerAddressData);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerAddress);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(9, 56);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(235, 211);
            this.grpCustomerDetails.TabIndex = 3;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Details";
            // 
            // lblCustomerLastUpdated
            // 
            this.lblCustomerLastUpdated.AutoSize = true;
            this.lblCustomerLastUpdated.Location = new System.Drawing.Point(16, 181);
            this.lblCustomerLastUpdated.Name = "lblCustomerLastUpdated";
            this.lblCustomerLastUpdated.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerLastUpdated.TabIndex = 9;
            this.lblCustomerLastUpdated.Text = "Last Updated:";
            // 
            // lblCustomerLastUpdatedData
            // 
            this.lblCustomerLastUpdatedData.AutoSize = true;
            this.lblCustomerLastUpdatedData.Location = new System.Drawing.Point(96, 181);
            this.lblCustomerLastUpdatedData.Name = "lblCustomerLastUpdatedData";
            this.lblCustomerLastUpdatedData.Size = new System.Drawing.Size(105, 26);
            this.lblCustomerLastUpdatedData.TabIndex = 8;
            this.lblCustomerLastUpdatedData.Text = "1 Jan 2021 23:45:00\r\nBy User: test";
            // 
            // lblCustomerCreatedData
            // 
            this.lblCustomerCreatedData.AutoSize = true;
            this.lblCustomerCreatedData.Location = new System.Drawing.Point(96, 147);
            this.lblCustomerCreatedData.Name = "lblCustomerCreatedData";
            this.lblCustomerCreatedData.Size = new System.Drawing.Size(105, 26);
            this.lblCustomerCreatedData.TabIndex = 7;
            this.lblCustomerCreatedData.Text = "1 Jan 2021 23:45:00\r\nBy User: test";
            // 
            // lblCustomerCreated
            // 
            this.lblCustomerCreated.AutoSize = true;
            this.lblCustomerCreated.Location = new System.Drawing.Point(16, 147);
            this.lblCustomerCreated.Name = "lblCustomerCreated";
            this.lblCustomerCreated.Size = new System.Drawing.Size(47, 13);
            this.lblCustomerCreated.TabIndex = 6;
            this.lblCustomerCreated.Text = "Created:";
            // 
            // lblCustomerActiveData
            // 
            this.lblCustomerActiveData.AutoSize = true;
            this.lblCustomerActiveData.Location = new System.Drawing.Point(96, 92);
            this.lblCustomerActiveData.Name = "lblCustomerActiveData";
            this.lblCustomerActiveData.Size = new System.Drawing.Size(29, 13);
            this.lblCustomerActiveData.TabIndex = 5;
            this.lblCustomerActiveData.Text = "True";
            // 
            // lblCustomerActive
            // 
            this.lblCustomerActive.AutoSize = true;
            this.lblCustomerActive.Location = new System.Drawing.Point(16, 92);
            this.lblCustomerActive.Name = "lblCustomerActive";
            this.lblCustomerActive.Size = new System.Drawing.Size(40, 13);
            this.lblCustomerActive.TabIndex = 4;
            this.lblCustomerActive.Text = "Active:";
            // 
            // lblCustomerNameData
            // 
            this.lblCustomerNameData.AutoSize = true;
            this.lblCustomerNameData.Location = new System.Drawing.Point(96, 24);
            this.lblCustomerNameData.Name = "lblCustomerNameData";
            this.lblCustomerNameData.Size = new System.Drawing.Size(75, 13);
            this.lblCustomerNameData.TabIndex = 3;
            this.lblCustomerNameData.Text = "Test Customer";
            // 
            // lblCustomerAddressData
            // 
            this.lblCustomerAddressData.AutoSize = true;
            this.lblCustomerAddressData.Location = new System.Drawing.Point(96, 45);
            this.lblCustomerAddressData.Name = "lblCustomerAddressData";
            this.lblCustomerAddressData.Size = new System.Drawing.Size(113, 39);
            this.lblCustomerAddressData.TabIndex = 2;
            this.lblCustomerAddressData.Text = "123 Main St, Suite 1\r\nNew York, NY XXXXX\r\nUnited States";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(16, 45);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(48, 13);
            this.lblCustomerAddress.TabIndex = 1;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(16, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // cmbCustomerId
            // 
            this.cmbCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerId.FormattingEnabled = true;
            this.cmbCustomerId.Location = new System.Drawing.Point(33, 29);
            this.cmbCustomerId.Name = "cmbCustomerId";
            this.cmbCustomerId.Size = new System.Drawing.Size(66, 21);
            this.cmbCustomerId.TabIndex = 2;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(6, 32);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(21, 13);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Text = "ID:";
            // 
            // grpAddresses
            // 
            this.grpAddresses.Controls.Add(this.grpAddressDetails);
            this.grpAddresses.Controls.Add(this.cmbAddressId);
            this.grpAddresses.Controls.Add(this.lblAddressId);
            this.grpAddresses.Location = new System.Drawing.Point(268, 197);
            this.grpAddresses.Name = "grpAddresses";
            this.grpAddresses.Size = new System.Drawing.Size(250, 273);
            this.grpAddresses.TabIndex = 3;
            this.grpAddresses.TabStop = false;
            this.grpAddresses.Text = "Addresses";
            // 
            // grpAddressDetails
            // 
            this.grpAddressDetails.Controls.Add(this.lblAddressCityData);
            this.grpAddressDetails.Controls.Add(this.lblAddressPhoneData);
            this.grpAddressDetails.Controls.Add(this.lblAddressPhone);
            this.grpAddressDetails.Controls.Add(this.lblAddressAddress2Data);
            this.grpAddressDetails.Controls.Add(this.lblAddressCity);
            this.grpAddressDetails.Controls.Add(this.lblAddressLastUpdated);
            this.grpAddressDetails.Controls.Add(this.lblAddressLastUpdatedData);
            this.grpAddressDetails.Controls.Add(this.lblAddressCreatedByData);
            this.grpAddressDetails.Controls.Add(this.lblAddressCreatedBy);
            this.grpAddressDetails.Controls.Add(this.lblAddressPostalCodeData);
            this.grpAddressDetails.Controls.Add(this.lblAddressPostalCode);
            this.grpAddressDetails.Controls.Add(this.lblAddressAddress1Data);
            this.grpAddressDetails.Controls.Add(this.label8);
            this.grpAddressDetails.Controls.Add(this.lblAddressAddress2);
            this.grpAddressDetails.Controls.Add(this.lblAddressAddress1);
            this.grpAddressDetails.Location = new System.Drawing.Point(9, 56);
            this.grpAddressDetails.Name = "grpAddressDetails";
            this.grpAddressDetails.Size = new System.Drawing.Size(235, 211);
            this.grpAddressDetails.TabIndex = 10;
            this.grpAddressDetails.TabStop = false;
            this.grpAddressDetails.Text = "Details";
            // 
            // lblAddressCityData
            // 
            this.lblAddressCityData.AutoSize = true;
            this.lblAddressCityData.Location = new System.Drawing.Point(96, 66);
            this.lblAddressCityData.Name = "lblAddressCityData";
            this.lblAddressCityData.Size = new System.Drawing.Size(75, 13);
            this.lblAddressCityData.TabIndex = 14;
            this.lblAddressCityData.Text = "New York, NY";
            // 
            // lblAddressPhoneData
            // 
            this.lblAddressPhoneData.AutoSize = true;
            this.lblAddressPhoneData.Location = new System.Drawing.Point(96, 108);
            this.lblAddressPhoneData.Name = "lblAddressPhoneData";
            this.lblAddressPhoneData.Size = new System.Drawing.Size(73, 13);
            this.lblAddressPhoneData.TabIndex = 13;
            this.lblAddressPhoneData.Text = "111-222-3333";
            // 
            // lblAddressPhone
            // 
            this.lblAddressPhone.AutoSize = true;
            this.lblAddressPhone.Location = new System.Drawing.Point(16, 108);
            this.lblAddressPhone.Name = "lblAddressPhone";
            this.lblAddressPhone.Size = new System.Drawing.Size(41, 13);
            this.lblAddressPhone.TabIndex = 12;
            this.lblAddressPhone.Text = "Phone:";
            // 
            // lblAddressAddress2Data
            // 
            this.lblAddressAddress2Data.AutoSize = true;
            this.lblAddressAddress2Data.Location = new System.Drawing.Point(96, 45);
            this.lblAddressAddress2Data.Name = "lblAddressAddress2Data";
            this.lblAddressAddress2Data.Size = new System.Drawing.Size(64, 13);
            this.lblAddressAddress2Data.TabIndex = 11;
            this.lblAddressAddress2Data.Text = "123 Main St";
            // 
            // lblAddressCity
            // 
            this.lblAddressCity.AutoSize = true;
            this.lblAddressCity.Location = new System.Drawing.Point(16, 66);
            this.lblAddressCity.Name = "lblAddressCity";
            this.lblAddressCity.Size = new System.Drawing.Size(27, 13);
            this.lblAddressCity.TabIndex = 10;
            this.lblAddressCity.Text = "City:";
            // 
            // lblAddressLastUpdated
            // 
            this.lblAddressLastUpdated.AutoSize = true;
            this.lblAddressLastUpdated.Location = new System.Drawing.Point(16, 181);
            this.lblAddressLastUpdated.Name = "lblAddressLastUpdated";
            this.lblAddressLastUpdated.Size = new System.Drawing.Size(74, 13);
            this.lblAddressLastUpdated.TabIndex = 9;
            this.lblAddressLastUpdated.Text = "Last Updated:";
            // 
            // lblAddressLastUpdatedData
            // 
            this.lblAddressLastUpdatedData.AutoSize = true;
            this.lblAddressLastUpdatedData.Location = new System.Drawing.Point(96, 181);
            this.lblAddressLastUpdatedData.Name = "lblAddressLastUpdatedData";
            this.lblAddressLastUpdatedData.Size = new System.Drawing.Size(105, 26);
            this.lblAddressLastUpdatedData.TabIndex = 8;
            this.lblAddressLastUpdatedData.Text = "1 Jan 2021 23:45:00\r\nBy User: test";
            // 
            // lblAddressCreatedByData
            // 
            this.lblAddressCreatedByData.AutoSize = true;
            this.lblAddressCreatedByData.Location = new System.Drawing.Point(96, 147);
            this.lblAddressCreatedByData.Name = "lblAddressCreatedByData";
            this.lblAddressCreatedByData.Size = new System.Drawing.Size(105, 26);
            this.lblAddressCreatedByData.TabIndex = 7;
            this.lblAddressCreatedByData.Text = "1 Jan 2021 23:45:00\r\nBy User: test";
            // 
            // lblAddressCreatedBy
            // 
            this.lblAddressCreatedBy.AutoSize = true;
            this.lblAddressCreatedBy.Location = new System.Drawing.Point(16, 147);
            this.lblAddressCreatedBy.Name = "lblAddressCreatedBy";
            this.lblAddressCreatedBy.Size = new System.Drawing.Size(47, 13);
            this.lblAddressCreatedBy.TabIndex = 6;
            this.lblAddressCreatedBy.Text = "Created:";
            // 
            // lblAddressPostalCodeData
            // 
            this.lblAddressPostalCodeData.AutoSize = true;
            this.lblAddressPostalCodeData.Location = new System.Drawing.Point(96, 87);
            this.lblAddressPostalCodeData.Name = "lblAddressPostalCodeData";
            this.lblAddressPostalCodeData.Size = new System.Drawing.Size(37, 13);
            this.lblAddressPostalCodeData.TabIndex = 5;
            this.lblAddressPostalCodeData.Text = "55555";
            // 
            // lblAddressPostalCode
            // 
            this.lblAddressPostalCode.AutoSize = true;
            this.lblAddressPostalCode.Location = new System.Drawing.Point(16, 87);
            this.lblAddressPostalCode.Name = "lblAddressPostalCode";
            this.lblAddressPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblAddressPostalCode.TabIndex = 4;
            this.lblAddressPostalCode.Text = "Postal Code:";
            // 
            // lblAddressAddress1Data
            // 
            this.lblAddressAddress1Data.AutoSize = true;
            this.lblAddressAddress1Data.Location = new System.Drawing.Point(96, 24);
            this.lblAddressAddress1Data.Name = "lblAddressAddress1Data";
            this.lblAddressAddress1Data.Size = new System.Drawing.Size(64, 13);
            this.lblAddressAddress1Data.TabIndex = 3;
            this.lblAddressAddress1Data.Text = "123 Main St";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // lblAddressAddress2
            // 
            this.lblAddressAddress2.AutoSize = true;
            this.lblAddressAddress2.Location = new System.Drawing.Point(16, 45);
            this.lblAddressAddress2.Name = "lblAddressAddress2";
            this.lblAddressAddress2.Size = new System.Drawing.Size(65, 13);
            this.lblAddressAddress2.TabIndex = 1;
            this.lblAddressAddress2.Text = "Apt/St/Unit:";
            // 
            // lblAddressAddress1
            // 
            this.lblAddressAddress1.AutoSize = true;
            this.lblAddressAddress1.Location = new System.Drawing.Point(16, 24);
            this.lblAddressAddress1.Name = "lblAddressAddress1";
            this.lblAddressAddress1.Size = new System.Drawing.Size(48, 13);
            this.lblAddressAddress1.TabIndex = 0;
            this.lblAddressAddress1.Text = "Address:";
            // 
            // cmbAddressId
            // 
            this.cmbAddressId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddressId.FormattingEnabled = true;
            this.cmbAddressId.Location = new System.Drawing.Point(33, 29);
            this.cmbAddressId.Name = "cmbAddressId";
            this.cmbAddressId.Size = new System.Drawing.Size(66, 21);
            this.cmbAddressId.TabIndex = 3;
            // 
            // lblAddressId
            // 
            this.lblAddressId.AutoSize = true;
            this.lblAddressId.Location = new System.Drawing.Point(6, 32);
            this.lblAddressId.Name = "lblAddressId";
            this.lblAddressId.Size = new System.Drawing.Size(21, 13);
            this.lblAddressId.TabIndex = 0;
            this.lblAddressId.Text = "ID:";
            // 
            // grpViewOptions
            // 
            this.grpViewOptions.Controls.Add(this.panelTimeView);
            this.grpViewOptions.Controls.Add(this.panelDateRange);
            this.grpViewOptions.Location = new System.Drawing.Point(524, 202);
            this.grpViewOptions.Name = "grpViewOptions";
            this.grpViewOptions.Size = new System.Drawing.Size(264, 135);
            this.grpViewOptions.TabIndex = 4;
            this.grpViewOptions.TabStop = false;
            this.grpViewOptions.Text = "View Options";
            // 
            // panelTimeView
            // 
            this.panelTimeView.Controls.Add(this.radioTimeLocal);
            this.panelTimeView.Controls.Add(this.radioTimeUTC);
            this.panelTimeView.Controls.Add(this.lblTimeView);
            this.panelTimeView.Location = new System.Drawing.Point(139, 24);
            this.panelTimeView.Name = "panelTimeView";
            this.panelTimeView.Size = new System.Drawing.Size(119, 100);
            this.panelTimeView.TabIndex = 1;
            // 
            // radioTimeLocal
            // 
            this.radioTimeLocal.AutoSize = true;
            this.radioTimeLocal.Location = new System.Drawing.Point(17, 61);
            this.radioTimeLocal.Name = "radioTimeLocal";
            this.radioTimeLocal.Size = new System.Drawing.Size(77, 17);
            this.radioTimeLocal.TabIndex = 2;
            this.radioTimeLocal.TabStop = true;
            this.radioTimeLocal.Text = "Local Time";
            this.radioTimeLocal.UseVisualStyleBackColor = true;
            // 
            // radioTimeUTC
            // 
            this.radioTimeUTC.AutoSize = true;
            this.radioTimeUTC.Location = new System.Drawing.Point(17, 38);
            this.radioTimeUTC.Name = "radioTimeUTC";
            this.radioTimeUTC.Size = new System.Drawing.Size(47, 17);
            this.radioTimeUTC.TabIndex = 1;
            this.radioTimeUTC.TabStop = true;
            this.radioTimeUTC.Text = "UTC";
            this.radioTimeUTC.UseVisualStyleBackColor = true;
            // 
            // lblTimeView
            // 
            this.lblTimeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTimeView.Location = new System.Drawing.Point(0, 0);
            this.lblTimeView.Name = "lblTimeView";
            this.lblTimeView.Size = new System.Drawing.Size(119, 16);
            this.lblTimeView.TabIndex = 0;
            this.lblTimeView.Text = "Time View:";
            this.lblTimeView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDateRange
            // 
            this.panelDateRange.Controls.Add(this.radioDateMonthly);
            this.panelDateRange.Controls.Add(this.lblDateRangeView);
            this.panelDateRange.Controls.Add(this.radioDateWeekly);
            this.panelDateRange.Location = new System.Drawing.Point(6, 24);
            this.panelDateRange.Name = "panelDateRange";
            this.panelDateRange.Size = new System.Drawing.Size(119, 100);
            this.panelDateRange.TabIndex = 0;
            // 
            // radioDateMonthly
            // 
            this.radioDateMonthly.AutoSize = true;
            this.radioDateMonthly.Location = new System.Drawing.Point(25, 61);
            this.radioDateMonthly.Name = "radioDateMonthly";
            this.radioDateMonthly.Size = new System.Drawing.Size(62, 17);
            this.radioDateMonthly.TabIndex = 4;
            this.radioDateMonthly.TabStop = true;
            this.radioDateMonthly.Text = "Monthly";
            this.radioDateMonthly.UseVisualStyleBackColor = true;
            // 
            // lblDateRangeView
            // 
            this.lblDateRangeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDateRangeView.Location = new System.Drawing.Point(0, 0);
            this.lblDateRangeView.Name = "lblDateRangeView";
            this.lblDateRangeView.Size = new System.Drawing.Size(119, 13);
            this.lblDateRangeView.TabIndex = 0;
            this.lblDateRangeView.Text = "Appt Date Range:";
            this.lblDateRangeView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radioDateWeekly
            // 
            this.radioDateWeekly.AutoSize = true;
            this.radioDateWeekly.Location = new System.Drawing.Point(25, 38);
            this.radioDateWeekly.Name = "radioDateWeekly";
            this.radioDateWeekly.Size = new System.Drawing.Size(61, 17);
            this.radioDateWeekly.TabIndex = 3;
            this.radioDateWeekly.TabStop = true;
            this.radioDateWeekly.Text = "Weekly";
            this.radioDateWeekly.UseVisualStyleBackColor = true;
            // 
            // lblAppointmentDateRange
            // 
            this.lblAppointmentDateRange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAppointmentDateRange.Location = new System.Drawing.Point(0, 65);
            this.lblAppointmentDateRange.Name = "lblAppointmentDateRange";
            this.lblAppointmentDateRange.Size = new System.Drawing.Size(264, 35);
            this.lblAppointmentDateRange.TabIndex = 5;
            this.lblAppointmentDateRange.Text = "Viewing User Appointments:\r\n31 Jan 2021 to 6 Feb 2021";
            this.lblAppointmentDateRange.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAppointmentDateRange);
            this.panel1.Location = new System.Drawing.Point(524, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 100);
            this.panel1.TabIndex = 6;
            // 
            // newAddressToolStripMenuItem
            // 
            this.newAddressToolStripMenuItem.Name = "newAddressToolStripMenuItem";
            this.newAddressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newAddressToolStripMenuItem.Text = "New";
            // 
            // modifyAddressToolStripMenuItem
            // 
            this.modifyAddressToolStripMenuItem.Name = "modifyAddressToolStripMenuItem";
            this.modifyAddressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyAddressToolStripMenuItem.Text = "Modify / Delete";
            // 
            // addressesToolStripMenuItem
            // 
            this.addressesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAddressToolStripMenuItem,
            this.modifyAddressToolStripMenuItem});
            this.addressesToolStripMenuItem.Name = "addressesToolStripMenuItem";
            this.addressesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addressesToolStripMenuItem.Text = "Addresses";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpViewOptions);
            this.Controls.Add(this.grpAddresses);
            this.Controls.Add(this.grpCustomers);
            this.Controls.Add(this.dgvAppointmentList);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).EndInit();
            this.grpCustomers.ResumeLayout(false);
            this.grpCustomers.PerformLayout();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpAddresses.ResumeLayout(false);
            this.grpAddresses.PerformLayout();
            this.grpAddressDetails.ResumeLayout(false);
            this.grpAddressDetails.PerformLayout();
            this.grpViewOptions.ResumeLayout(false);
            this.panelTimeView.ResumeLayout(false);
            this.panelTimeView.PerformLayout();
            this.panelDateRange.ResumeLayout(false);
            this.panelDateRange.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCustomerToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAppointmentList;
        private System.Windows.Forms.GroupBox grpCustomers;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.Label lblCustomerLastUpdated;
        private System.Windows.Forms.Label lblCustomerLastUpdatedData;
        private System.Windows.Forms.Label lblCustomerCreatedData;
        private System.Windows.Forms.Label lblCustomerCreated;
        private System.Windows.Forms.Label lblCustomerActiveData;
        private System.Windows.Forms.Label lblCustomerActive;
        private System.Windows.Forms.Label lblCustomerNameData;
        private System.Windows.Forms.Label lblCustomerAddressData;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cmbCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.GroupBox grpAddresses;
        private System.Windows.Forms.GroupBox grpAddressDetails;
        private System.Windows.Forms.Label lblAddressPhoneData;
        private System.Windows.Forms.Label lblAddressPhone;
        private System.Windows.Forms.Label lblAddressAddress2Data;
        private System.Windows.Forms.Label lblAddressCity;
        private System.Windows.Forms.Label lblAddressLastUpdated;
        private System.Windows.Forms.Label lblAddressLastUpdatedData;
        private System.Windows.Forms.Label lblAddressCreatedByData;
        private System.Windows.Forms.Label lblAddressCreatedBy;
        private System.Windows.Forms.Label lblAddressPostalCodeData;
        private System.Windows.Forms.Label lblAddressPostalCode;
        private System.Windows.Forms.Label lblAddressAddress1Data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAddressAddress2;
        private System.Windows.Forms.Label lblAddressAddress1;
        private System.Windows.Forms.ComboBox cmbAddressId;
        private System.Windows.Forms.Label lblAddressId;
        private System.Windows.Forms.Label lblAddressCityData;
        private System.Windows.Forms.GroupBox grpViewOptions;
        private System.Windows.Forms.Panel panelTimeView;
        private System.Windows.Forms.RadioButton radioTimeLocal;
        private System.Windows.Forms.RadioButton radioTimeUTC;
        private System.Windows.Forms.Label lblTimeView;
        private System.Windows.Forms.Panel panelDateRange;
        private System.Windows.Forms.RadioButton radioDateMonthly;
        private System.Windows.Forms.Label lblDateRangeView;
        private System.Windows.Forms.RadioButton radioDateWeekly;
        private System.Windows.Forms.Label lblAppointmentDateRange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem addressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAddressToolStripMenuItem;
    }
}

