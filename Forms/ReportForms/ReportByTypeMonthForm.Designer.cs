namespace C969 {
    partial class ReportByTypeMonthForm {
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblAppointmentType = new System.Windows.Forms.Label();
            this.cmbAppointmentType = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(271, 33);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Generate Report by selecting Appointment\r\nTYPE and MONTH.";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAppointmentType
            // 
            this.lblAppointmentType.AutoSize = true;
            this.lblAppointmentType.Location = new System.Drawing.Point(12, 73);
            this.lblAppointmentType.Name = "lblAppointmentType";
            this.lblAppointmentType.Size = new System.Drawing.Size(34, 13);
            this.lblAppointmentType.TabIndex = 1;
            this.lblAppointmentType.Text = "Type:";
            // 
            // cmbAppointmentType
            // 
            this.cmbAppointmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentType.FormattingEnabled = true;
            this.cmbAppointmentType.Location = new System.Drawing.Point(52, 70);
            this.cmbAppointmentType.Name = "cmbAppointmentType";
            this.cmbAppointmentType.Size = new System.Drawing.Size(194, 21);
            this.cmbAppointmentType.TabIndex = 2;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(58, 97);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(188, 21);
            this.cmbMonth.TabIndex = 4;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(12, 100);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Month:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 157);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ReportByTypeMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 188);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbAppointmentType);
            this.Controls.Add(this.lblAppointmentType);
            this.Controls.Add(this.lblFormTitle);
            this.Name = "ReportByTypeMonthForm";
            this.Text = "Generate Report";
            this.Load += new System.EventHandler(this.ReportByTypeMonthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblAppointmentType;
        private System.Windows.Forms.ComboBox cmbAppointmentType;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
    }
}