
namespace C969 {
    partial class NewCityForm {
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
            this.lblCityId = new System.Windows.Forms.Label();
            this.tboxCityId = new System.Windows.Forms.TextBox();
            this.grpCityDetails = new System.Windows.Forms.GroupBox();
            this.lblCityName = new System.Windows.Forms.Label();
            this.tboxCityName = new System.Windows.Forms.TextBox();
            this.lblCityCountryId = new System.Windows.Forms.Label();
            this.cmbCityCountryId = new System.Windows.Forms.ComboBox();
            this.btnAddNewCountry = new System.Windows.Forms.Button();
            this.lblCityCountryName = new System.Windows.Forms.Label();
            this.lblCityCountryNameValue = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCityDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCityId
            // 
            this.lblCityId.AutoSize = true;
            this.lblCityId.Location = new System.Drawing.Point(12, 25);
            this.lblCityId.Name = "lblCityId";
            this.lblCityId.Size = new System.Drawing.Size(21, 13);
            this.lblCityId.TabIndex = 0;
            this.lblCityId.Text = "ID:";
            // 
            // tboxCityId
            // 
            this.tboxCityId.Location = new System.Drawing.Point(39, 22);
            this.tboxCityId.Name = "tboxCityId";
            this.tboxCityId.ReadOnly = true;
            this.tboxCityId.Size = new System.Drawing.Size(49, 20);
            this.tboxCityId.TabIndex = 1;
            // 
            // grpCityDetails
            // 
            this.grpCityDetails.Controls.Add(this.lblCityCountryNameValue);
            this.grpCityDetails.Controls.Add(this.lblCityCountryName);
            this.grpCityDetails.Controls.Add(this.btnAddNewCountry);
            this.grpCityDetails.Controls.Add(this.cmbCityCountryId);
            this.grpCityDetails.Controls.Add(this.lblCityCountryId);
            this.grpCityDetails.Controls.Add(this.tboxCityName);
            this.grpCityDetails.Controls.Add(this.lblCityName);
            this.grpCityDetails.Location = new System.Drawing.Point(15, 52);
            this.grpCityDetails.Name = "grpCityDetails";
            this.grpCityDetails.Size = new System.Drawing.Size(259, 135);
            this.grpCityDetails.TabIndex = 2;
            this.grpCityDetails.TabStop = false;
            this.grpCityDetails.Text = "Details";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(10, 32);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(38, 13);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "Name:";
            // 
            // tboxCityName
            // 
            this.tboxCityName.Location = new System.Drawing.Point(54, 29);
            this.tboxCityName.Name = "tboxCityName";
            this.tboxCityName.Size = new System.Drawing.Size(187, 20);
            this.tboxCityName.TabIndex = 1;
            // 
            // lblCityCountryId
            // 
            this.lblCityCountryId.AutoSize = true;
            this.lblCityCountryId.Location = new System.Drawing.Point(10, 58);
            this.lblCityCountryId.Name = "lblCityCountryId";
            this.lblCityCountryId.Size = new System.Drawing.Size(46, 13);
            this.lblCityCountryId.TabIndex = 2;
            this.lblCityCountryId.Text = "Country:";
            // 
            // cmbCityCountryId
            // 
            this.cmbCityCountryId.FormattingEnabled = true;
            this.cmbCityCountryId.Location = new System.Drawing.Point(62, 55);
            this.cmbCityCountryId.Name = "cmbCityCountryId";
            this.cmbCityCountryId.Size = new System.Drawing.Size(55, 21);
            this.cmbCityCountryId.TabIndex = 3;
            // 
            // btnAddNewCountry
            // 
            this.btnAddNewCountry.Location = new System.Drawing.Point(160, 55);
            this.btnAddNewCountry.Name = "btnAddNewCountry";
            this.btnAddNewCountry.Size = new System.Drawing.Size(81, 23);
            this.btnAddNewCountry.TabIndex = 4;
            this.btnAddNewCountry.Text = "New Country";
            this.btnAddNewCountry.UseVisualStyleBackColor = true;
            // 
            // lblCityCountryName
            // 
            this.lblCityCountryName.AutoSize = true;
            this.lblCityCountryName.Location = new System.Drawing.Point(10, 94);
            this.lblCityCountryName.Name = "lblCityCountryName";
            this.lblCityCountryName.Size = new System.Drawing.Size(43, 26);
            this.lblCityCountryName.TabIndex = 5;
            this.lblCityCountryName.Text = "Country\r\nName:";
            this.lblCityCountryName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCityCountryNameValue
            // 
            this.lblCityCountryNameValue.AutoSize = true;
            this.lblCityCountryNameValue.Location = new System.Drawing.Point(64, 107);
            this.lblCityCountryNameValue.Name = "lblCityCountryNameValue";
            this.lblCityCountryNameValue.Size = new System.Drawing.Size(71, 13);
            this.lblCityCountryNameValue.TabIndex = 6;
            this.lblCityCountryNameValue.Text = "CountryName";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 193);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(199, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 230);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpCityDetails);
            this.Controls.Add(this.tboxCityId);
            this.Controls.Add(this.lblCityId);
            this.Name = "NewCityForm";
            this.Text = "New City";
            this.Load += new System.EventHandler(this.NewCityForm_Load);
            this.grpCityDetails.ResumeLayout(false);
            this.grpCityDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCityId;
        private System.Windows.Forms.TextBox tboxCityId;
        private System.Windows.Forms.GroupBox grpCityDetails;
        private System.Windows.Forms.Label lblCityCountryNameValue;
        private System.Windows.Forms.Label lblCityCountryName;
        private System.Windows.Forms.Button btnAddNewCountry;
        private System.Windows.Forms.ComboBox cmbCityCountryId;
        private System.Windows.Forms.Label lblCityCountryId;
        private System.Windows.Forms.TextBox tboxCityName;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}