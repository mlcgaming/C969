﻿namespace C969 {
    partial class ModifyCityForm {
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCityDetails = new System.Windows.Forms.GroupBox();
            this.lblCityCountryNameValue = new System.Windows.Forms.Label();
            this.lblCityCountryName = new System.Windows.Forms.Label();
            this.cmbCityCountryId = new System.Windows.Forms.ComboBox();
            this.lblCityCountryId = new System.Windows.Forms.Label();
            this.tboxCityName = new System.Windows.Forms.TextBox();
            this.lblCityName = new System.Windows.Forms.Label();
            this.tboxCityId = new System.Windows.Forms.TextBox();
            this.lblCityId = new System.Windows.Forms.Label();
            this.grpCityDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(199, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpCityDetails
            // 
            this.grpCityDetails.Controls.Add(this.lblCityCountryNameValue);
            this.grpCityDetails.Controls.Add(this.lblCityCountryName);
            this.grpCityDetails.Controls.Add(this.cmbCityCountryId);
            this.grpCityDetails.Controls.Add(this.lblCityCountryId);
            this.grpCityDetails.Controls.Add(this.tboxCityName);
            this.grpCityDetails.Controls.Add(this.lblCityName);
            this.grpCityDetails.Location = new System.Drawing.Point(15, 36);
            this.grpCityDetails.Name = "grpCityDetails";
            this.grpCityDetails.Size = new System.Drawing.Size(259, 135);
            this.grpCityDetails.TabIndex = 7;
            this.grpCityDetails.TabStop = false;
            this.grpCityDetails.Text = "Details";
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
            // cmbCityCountryId
            // 
            this.cmbCityCountryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCityCountryId.FormattingEnabled = true;
            this.cmbCityCountryId.Location = new System.Drawing.Point(62, 55);
            this.cmbCityCountryId.Name = "cmbCityCountryId";
            this.cmbCityCountryId.Size = new System.Drawing.Size(55, 21);
            this.cmbCityCountryId.TabIndex = 3;
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
            // tboxCityName
            // 
            this.tboxCityName.Location = new System.Drawing.Point(54, 29);
            this.tboxCityName.Name = "tboxCityName";
            this.tboxCityName.Size = new System.Drawing.Size(187, 20);
            this.tboxCityName.TabIndex = 1;
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
            // tboxCityId
            // 
            this.tboxCityId.Location = new System.Drawing.Point(39, 6);
            this.tboxCityId.Name = "tboxCityId";
            this.tboxCityId.ReadOnly = true;
            this.tboxCityId.Size = new System.Drawing.Size(49, 20);
            this.tboxCityId.TabIndex = 6;
            // 
            // lblCityId
            // 
            this.lblCityId.AutoSize = true;
            this.lblCityId.Location = new System.Drawing.Point(12, 9);
            this.lblCityId.Name = "lblCityId";
            this.lblCityId.Size = new System.Drawing.Size(21, 13);
            this.lblCityId.TabIndex = 5;
            this.lblCityId.Text = "ID:";
            // 
            // ModifyCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 212);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpCityDetails);
            this.Controls.Add(this.tboxCityId);
            this.Controls.Add(this.lblCityId);
            this.Name = "ModifyCityForm";
            this.Text = "Modify City";
            this.Load += new System.EventHandler(this.ModifyCityForm_Load);
            this.grpCityDetails.ResumeLayout(false);
            this.grpCityDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpCityDetails;
        private System.Windows.Forms.Label lblCityCountryNameValue;
        private System.Windows.Forms.Label lblCityCountryName;
        private System.Windows.Forms.ComboBox cmbCityCountryId;
        private System.Windows.Forms.Label lblCityCountryId;
        private System.Windows.Forms.TextBox tboxCityName;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.TextBox tboxCityId;
        private System.Windows.Forms.Label lblCityId;
    }
}