namespace C969 {
    partial class NewAppointmentForm {
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
            this.lblAppointmentId = new System.Windows.Forms.Label();
            this.tboxAppointmentId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.cmbUserId = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cmbCustomerId = new System.Windows.Forms.ComboBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.grpAppointmentDetails = new System.Windows.Forms.GroupBox();
            this.lblAppointmentEnd = new System.Windows.Forms.Label();
            this.lblAppointmentStart = new System.Windows.Forms.Label();
            this.dtpAppointmentStart = new System.Windows.Forms.DateTimePicker();
            this.dtpAppointmentEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbAppointmentTypes = new System.Windows.Forms.ComboBox();
            this.lblAppointmentUrl = new System.Windows.Forms.Label();
            this.tboxAppointmentUrl = new System.Windows.Forms.TextBox();
            this.lblAppointmentType = new System.Windows.Forms.Label();
            this.lblAppointmentContact = new System.Windows.Forms.Label();
            this.tboxAppointmentContact = new System.Windows.Forms.TextBox();
            this.lblAppointmentLocation = new System.Windows.Forms.Label();
            this.tboxAppointmentLocation = new System.Windows.Forms.TextBox();
            this.lblAppointmentDescription = new System.Windows.Forms.Label();
            this.tboxAppointmentDescription = new System.Windows.Forms.TextBox();
            this.lblAppointmentTitle = new System.Windows.Forms.Label();
            this.tboxAppointmentTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAppointmentContactWarning = new System.Windows.Forms.Label();
            this.grpAppointmentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppointmentId
            // 
            this.lblAppointmentId.AutoSize = true;
            this.lblAppointmentId.Location = new System.Drawing.Point(12, 17);
            this.lblAppointmentId.Name = "lblAppointmentId";
            this.lblAppointmentId.Size = new System.Drawing.Size(21, 13);
            this.lblAppointmentId.TabIndex = 0;
            this.lblAppointmentId.Text = "ID:";
            // 
            // tboxAppointmentId
            // 
            this.tboxAppointmentId.Location = new System.Drawing.Point(39, 14);
            this.tboxAppointmentId.Name = "tboxAppointmentId";
            this.tboxAppointmentId.ReadOnly = true;
            this.tboxAppointmentId.Size = new System.Drawing.Size(44, 20);
            this.tboxAppointmentId.TabIndex = 1;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(100, 17);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(46, 13);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "User ID:";
            // 
            // cmbUserId
            // 
            this.cmbUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserId.FormattingEnabled = true;
            this.cmbUserId.Location = new System.Drawing.Point(150, 14);
            this.cmbUserId.Name = "cmbUserId";
            this.cmbUserId.Size = new System.Drawing.Size(53, 21);
            this.cmbUserId.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(209, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Username:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(209, 44);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(54, 13);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Customer:";
            // 
            // cmbCustomerId
            // 
            this.cmbCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerId.FormattingEnabled = true;
            this.cmbCustomerId.Location = new System.Drawing.Point(150, 41);
            this.cmbCustomerId.Name = "cmbCustomerId";
            this.cmbCustomerId.Size = new System.Drawing.Size(53, 21);
            this.cmbCustomerId.TabIndex = 1;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(98, 44);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(48, 13);
            this.lblCustomerId.TabIndex = 5;
            this.lblCustomerId.Text = "Cust. ID:";
            // 
            // grpAppointmentDetails
            // 
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentContactWarning);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentEnd);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentStart);
            this.grpAppointmentDetails.Controls.Add(this.dtpAppointmentStart);
            this.grpAppointmentDetails.Controls.Add(this.dtpAppointmentEnd);
            this.grpAppointmentDetails.Controls.Add(this.cmbAppointmentTypes);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentUrl);
            this.grpAppointmentDetails.Controls.Add(this.tboxAppointmentUrl);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentType);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentContact);
            this.grpAppointmentDetails.Controls.Add(this.tboxAppointmentContact);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentLocation);
            this.grpAppointmentDetails.Controls.Add(this.tboxAppointmentLocation);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentDescription);
            this.grpAppointmentDetails.Controls.Add(this.tboxAppointmentDescription);
            this.grpAppointmentDetails.Controls.Add(this.lblAppointmentTitle);
            this.grpAppointmentDetails.Controls.Add(this.tboxAppointmentTitle);
            this.grpAppointmentDetails.Location = new System.Drawing.Point(12, 68);
            this.grpAppointmentDetails.Name = "grpAppointmentDetails";
            this.grpAppointmentDetails.Size = new System.Drawing.Size(391, 228);
            this.grpAppointmentDetails.TabIndex = 8;
            this.grpAppointmentDetails.TabStop = false;
            this.grpAppointmentDetails.Text = "Appointment Details";
            // 
            // lblAppointmentEnd
            // 
            this.lblAppointmentEnd.AutoSize = true;
            this.lblAppointmentEnd.Location = new System.Drawing.Point(72, 200);
            this.lblAppointmentEnd.Name = "lblAppointmentEnd";
            this.lblAppointmentEnd.Size = new System.Drawing.Size(55, 13);
            this.lblAppointmentEnd.TabIndex = 17;
            this.lblAppointmentEnd.Text = "End Time:";
            // 
            // lblAppointmentStart
            // 
            this.lblAppointmentStart.AutoSize = true;
            this.lblAppointmentStart.Location = new System.Drawing.Point(72, 173);
            this.lblAppointmentStart.Name = "lblAppointmentStart";
            this.lblAppointmentStart.Size = new System.Drawing.Size(58, 13);
            this.lblAppointmentStart.TabIndex = 16;
            this.lblAppointmentStart.Text = "Start Time:";
            // 
            // dtpAppointmentStart
            // 
            this.dtpAppointmentStart.CustomFormat = "ddd dd MMM yyyy HH:mm:ss tt";
            this.dtpAppointmentStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentStart.Location = new System.Drawing.Point(138, 170);
            this.dtpAppointmentStart.Name = "dtpAppointmentStart";
            this.dtpAppointmentStart.ShowUpDown = true;
            this.dtpAppointmentStart.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentStart.TabIndex = 8;
            this.dtpAppointmentStart.Value = new System.DateTime(2021, 2, 1, 8, 0, 0, 0);
            // 
            // dtpAppointmentEnd
            // 
            this.dtpAppointmentEnd.CustomFormat = "ddd dd MMM yyyy HH:mm:ss tt";
            this.dtpAppointmentEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentEnd.Location = new System.Drawing.Point(138, 196);
            this.dtpAppointmentEnd.Name = "dtpAppointmentEnd";
            this.dtpAppointmentEnd.ShowUpDown = true;
            this.dtpAppointmentEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentEnd.TabIndex = 9;
            this.dtpAppointmentEnd.Value = new System.DateTime(2021, 2, 1, 8, 30, 0, 0);
            // 
            // cmbAppointmentTypes
            // 
            this.cmbAppointmentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentTypes.FormattingEnabled = true;
            this.cmbAppointmentTypes.Location = new System.Drawing.Point(46, 139);
            this.cmbAppointmentTypes.Name = "cmbAppointmentTypes";
            this.cmbAppointmentTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbAppointmentTypes.TabIndex = 6;
            // 
            // lblAppointmentUrl
            // 
            this.lblAppointmentUrl.AutoSize = true;
            this.lblAppointmentUrl.Location = new System.Drawing.Point(173, 142);
            this.lblAppointmentUrl.Name = "lblAppointmentUrl";
            this.lblAppointmentUrl.Size = new System.Drawing.Size(32, 13);
            this.lblAppointmentUrl.TabIndex = 11;
            this.lblAppointmentUrl.Text = "URL:";
            // 
            // tboxAppointmentUrl
            // 
            this.tboxAppointmentUrl.Location = new System.Drawing.Point(211, 139);
            this.tboxAppointmentUrl.Name = "tboxAppointmentUrl";
            this.tboxAppointmentUrl.Size = new System.Drawing.Size(174, 20);
            this.tboxAppointmentUrl.TabIndex = 7;
            // 
            // lblAppointmentType
            // 
            this.lblAppointmentType.AutoSize = true;
            this.lblAppointmentType.Location = new System.Drawing.Point(6, 142);
            this.lblAppointmentType.Name = "lblAppointmentType";
            this.lblAppointmentType.Size = new System.Drawing.Size(34, 13);
            this.lblAppointmentType.TabIndex = 9;
            this.lblAppointmentType.Text = "Type:";
            // 
            // lblAppointmentContact
            // 
            this.lblAppointmentContact.AutoSize = true;
            this.lblAppointmentContact.Location = new System.Drawing.Point(6, 116);
            this.lblAppointmentContact.Name = "lblAppointmentContact";
            this.lblAppointmentContact.Size = new System.Drawing.Size(47, 13);
            this.lblAppointmentContact.TabIndex = 7;
            this.lblAppointmentContact.Text = "Contact:";
            // 
            // tboxAppointmentContact
            // 
            this.tboxAppointmentContact.Location = new System.Drawing.Point(59, 113);
            this.tboxAppointmentContact.Name = "tboxAppointmentContact";
            this.tboxAppointmentContact.Size = new System.Drawing.Size(326, 20);
            this.tboxAppointmentContact.TabIndex = 5;
            // 
            // lblAppointmentLocation
            // 
            this.lblAppointmentLocation.AutoSize = true;
            this.lblAppointmentLocation.Location = new System.Drawing.Point(6, 90);
            this.lblAppointmentLocation.Name = "lblAppointmentLocation";
            this.lblAppointmentLocation.Size = new System.Drawing.Size(51, 13);
            this.lblAppointmentLocation.TabIndex = 5;
            this.lblAppointmentLocation.Text = "Location:";
            // 
            // tboxAppointmentLocation
            // 
            this.tboxAppointmentLocation.Location = new System.Drawing.Point(63, 87);
            this.tboxAppointmentLocation.Name = "tboxAppointmentLocation";
            this.tboxAppointmentLocation.Size = new System.Drawing.Size(322, 20);
            this.tboxAppointmentLocation.TabIndex = 4;
            // 
            // lblAppointmentDescription
            // 
            this.lblAppointmentDescription.AutoSize = true;
            this.lblAppointmentDescription.Location = new System.Drawing.Point(6, 64);
            this.lblAppointmentDescription.Name = "lblAppointmentDescription";
            this.lblAppointmentDescription.Size = new System.Drawing.Size(63, 13);
            this.lblAppointmentDescription.TabIndex = 3;
            this.lblAppointmentDescription.Text = "Description:";
            // 
            // tboxAppointmentDescription
            // 
            this.tboxAppointmentDescription.Location = new System.Drawing.Point(75, 61);
            this.tboxAppointmentDescription.Name = "tboxAppointmentDescription";
            this.tboxAppointmentDescription.Size = new System.Drawing.Size(310, 20);
            this.tboxAppointmentDescription.TabIndex = 3;
            // 
            // lblAppointmentTitle
            // 
            this.lblAppointmentTitle.AutoSize = true;
            this.lblAppointmentTitle.Location = new System.Drawing.Point(6, 38);
            this.lblAppointmentTitle.Name = "lblAppointmentTitle";
            this.lblAppointmentTitle.Size = new System.Drawing.Size(30, 13);
            this.lblAppointmentTitle.TabIndex = 1;
            this.lblAppointmentTitle.Text = "Title:";
            // 
            // tboxAppointmentTitle
            // 
            this.tboxAppointmentTitle.Location = new System.Drawing.Point(42, 35);
            this.tboxAppointmentTitle.Name = "tboxAppointmentTitle";
            this.tboxAppointmentTitle.Size = new System.Drawing.Size(343, 20);
            this.tboxAppointmentTitle.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(329, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAppointmentContactWarning
            // 
            this.lblAppointmentContactWarning.AutoSize = true;
            this.lblAppointmentContactWarning.ForeColor = System.Drawing.Color.Red;
            this.lblAppointmentContactWarning.Location = new System.Drawing.Point(102, 16);
            this.lblAppointmentContactWarning.Name = "lblAppointmentContactWarning";
            this.lblAppointmentContactWarning.Size = new System.Drawing.Size(204, 13);
            this.lblAppointmentContactWarning.TabIndex = 18;
            this.lblAppointmentContactWarning.Text = "Contact cannot contain invalid characters";
            // 
            // NewAppointmentForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(416, 332);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpAppointmentDetails);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cmbCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.tboxAppointmentId);
            this.Controls.Add(this.lblAppointmentId);
            this.Name = "NewAppointmentForm";
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.NewAppointmentForm_Load);
            this.grpAppointmentDetails.ResumeLayout(false);
            this.grpAppointmentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.TextBox tboxAppointmentId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ComboBox cmbUserId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cmbCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.GroupBox grpAppointmentDetails;
        private System.Windows.Forms.Label lblAppointmentEnd;
        private System.Windows.Forms.Label lblAppointmentStart;
        private System.Windows.Forms.DateTimePicker dtpAppointmentStart;
        private System.Windows.Forms.DateTimePicker dtpAppointmentEnd;
        private System.Windows.Forms.ComboBox cmbAppointmentTypes;
        private System.Windows.Forms.Label lblAppointmentUrl;
        private System.Windows.Forms.TextBox tboxAppointmentUrl;
        private System.Windows.Forms.Label lblAppointmentType;
        private System.Windows.Forms.Label lblAppointmentContact;
        private System.Windows.Forms.TextBox tboxAppointmentContact;
        private System.Windows.Forms.Label lblAppointmentLocation;
        private System.Windows.Forms.TextBox tboxAppointmentLocation;
        private System.Windows.Forms.Label lblAppointmentDescription;
        private System.Windows.Forms.TextBox tboxAppointmentDescription;
        private System.Windows.Forms.Label lblAppointmentTitle;
        private System.Windows.Forms.TextBox tboxAppointmentTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAppointmentContactWarning;
    }
}