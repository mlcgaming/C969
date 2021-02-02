namespace C969 {
    partial class SelectAppointmentForm {
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.tboxDetails = new System.Windows.Forms.RichTextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.cmbAppointmentId = new System.Windows.Forms.ComboBox();
            this.lblAppointmentId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(93, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(177, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 200);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(59, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // tboxDetails
            // 
            this.tboxDetails.Location = new System.Drawing.Point(60, 43);
            this.tboxDetails.Name = "tboxDetails";
            this.tboxDetails.ReadOnly = true;
            this.tboxDetails.Size = new System.Drawing.Size(170, 151);
            this.tboxDetails.TabIndex = 10;
            this.tboxDetails.Text = "";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(12, 46);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(42, 13);
            this.lblDetails.TabIndex = 9;
            this.lblDetails.Text = "Details:";
            // 
            // cmbAppointmentId
            // 
            this.cmbAppointmentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentId.FormattingEnabled = true;
            this.cmbAppointmentId.Location = new System.Drawing.Point(39, 6);
            this.cmbAppointmentId.Name = "cmbAppointmentId";
            this.cmbAppointmentId.Size = new System.Drawing.Size(61, 21);
            this.cmbAppointmentId.TabIndex = 8;
            // 
            // lblAppointmentId
            // 
            this.lblAppointmentId.AutoSize = true;
            this.lblAppointmentId.Location = new System.Drawing.Point(12, 9);
            this.lblAppointmentId.Name = "lblAppointmentId";
            this.lblAppointmentId.Size = new System.Drawing.Size(21, 13);
            this.lblAppointmentId.TabIndex = 7;
            this.lblAppointmentId.Text = "ID:";
            // 
            // SelectAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 238);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tboxDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.cmbAppointmentId);
            this.Controls.Add(this.lblAppointmentId);
            this.Name = "SelectAppointmentForm";
            this.Text = "Select Appointment";
            this.Load += new System.EventHandler(this.SelectAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.RichTextBox tboxDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox cmbAppointmentId;
        private System.Windows.Forms.Label lblAppointmentId;
    }
}