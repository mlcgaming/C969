namespace C969 {
    partial class ModifyCustomerForm {
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
            this.checkCustomerActive = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerNameWarning = new System.Windows.Forms.Label();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.lblCustomerPhoneValue = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerAddressValue = new System.Windows.Forms.Label();
            this.cmbAddressId = new System.Windows.Forms.ComboBox();
            this.lblAddressId = new System.Windows.Forms.Label();
            this.tboxCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tboxCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.grpCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkCustomerActive
            // 
            this.checkCustomerActive.AutoSize = true;
            this.checkCustomerActive.Location = new System.Drawing.Point(217, 8);
            this.checkCustomerActive.Name = "checkCustomerActive";
            this.checkCustomerActive.Size = new System.Drawing.Size(99, 17);
            this.checkCustomerActive.TabIndex = 13;
            this.checkCustomerActive.Text = "Active Account";
            this.checkCustomerActive.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.lblCustomerNameWarning);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerPhone);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerPhoneValue);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerAddress);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerAddressValue);
            this.grpCustomerDetails.Controls.Add(this.cmbAddressId);
            this.grpCustomerDetails.Controls.Add(this.lblAddressId);
            this.grpCustomerDetails.Controls.Add(this.tboxCustomerName);
            this.grpCustomerDetails.Controls.Add(this.lblCustomerName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(15, 34);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(301, 171);
            this.grpCustomerDetails.TabIndex = 10;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Details";
            // 
            // lblCustomerNameWarning
            // 
            this.lblCustomerNameWarning.AutoSize = true;
            this.lblCustomerNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerNameWarning.Location = new System.Drawing.Point(24, 16);
            this.lblCustomerNameWarning.Name = "lblCustomerNameWarning";
            this.lblCustomerNameWarning.Size = new System.Drawing.Size(245, 13);
            this.lblCustomerNameWarning.TabIndex = 9;
            this.lblCustomerNameWarning.Text = "Customer Name cannot contain special characters";
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Location = new System.Drawing.Point(21, 141);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lblCustomerPhone.TabIndex = 8;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // lblCustomerPhoneValue
            // 
            this.lblCustomerPhoneValue.AutoSize = true;
            this.lblCustomerPhoneValue.Location = new System.Drawing.Point(86, 141);
            this.lblCustomerPhoneValue.Name = "lblCustomerPhoneValue";
            this.lblCustomerPhoneValue.Size = new System.Drawing.Size(73, 13);
            this.lblCustomerPhoneValue.TabIndex = 7;
            this.lblCustomerPhoneValue.Text = "111-222-3333";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(21, 94);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(48, 13);
            this.lblCustomerAddress.TabIndex = 5;
            this.lblCustomerAddress.Text = "Address:";
            // 
            // lblCustomerAddressValue
            // 
            this.lblCustomerAddressValue.AutoSize = true;
            this.lblCustomerAddressValue.Location = new System.Drawing.Point(86, 94);
            this.lblCustomerAddressValue.Name = "lblCustomerAddressValue";
            this.lblCustomerAddressValue.Size = new System.Drawing.Size(106, 39);
            this.lblCustomerAddressValue.TabIndex = 4;
            this.lblCustomerAddressValue.Text = "XXX Main St, Suite 1\r\nNew York, 11111\r\nUnited States";
            // 
            // cmbAddressId
            // 
            this.cmbAddressId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddressId.FormattingEnabled = true;
            this.cmbAddressId.Location = new System.Drawing.Point(89, 62);
            this.cmbAddressId.Name = "cmbAddressId";
            this.cmbAddressId.Size = new System.Drawing.Size(61, 21);
            this.cmbAddressId.TabIndex = 3;
            // 
            // lblAddressId
            // 
            this.lblAddressId.AutoSize = true;
            this.lblAddressId.Location = new System.Drawing.Point(21, 65);
            this.lblAddressId.Name = "lblAddressId";
            this.lblAddressId.Size = new System.Drawing.Size(62, 13);
            this.lblAddressId.TabIndex = 2;
            this.lblAddressId.Text = "Address ID:";
            // 
            // tboxCustomerName
            // 
            this.tboxCustomerName.Location = new System.Drawing.Point(65, 36);
            this.tboxCustomerName.Name = "tboxCustomerName";
            this.tboxCustomerName.Size = new System.Drawing.Size(204, 20);
            this.tboxCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(21, 39);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name:";
            // 
            // tboxCustomerId
            // 
            this.tboxCustomerId.Location = new System.Drawing.Point(39, 6);
            this.tboxCustomerId.Name = "tboxCustomerId";
            this.tboxCustomerId.ReadOnly = true;
            this.tboxCustomerId.Size = new System.Drawing.Size(42, 20);
            this.tboxCustomerId.TabIndex = 9;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(12, 9);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(21, 13);
            this.lblCustomerId.TabIndex = 8;
            this.lblCustomerId.Text = "ID:";
            // 
            // ModifyCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 245);
            this.Controls.Add(this.checkCustomerActive);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.tboxCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.Name = "ModifyCustomerForm";
            this.Text = "Modify Customer";
            this.Load += new System.EventHandler(this.ModifyCustomerForm_Load);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkCustomerActive;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.Label lblCustomerNameWarning;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.Label lblCustomerPhoneValue;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerAddressValue;
        private System.Windows.Forms.ComboBox cmbAddressId;
        private System.Windows.Forms.Label lblAddressId;
        private System.Windows.Forms.TextBox tboxCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox tboxCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
    }
}