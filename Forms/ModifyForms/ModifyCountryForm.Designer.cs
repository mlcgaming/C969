namespace C969 {
    partial class ModifyCountryForm {
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
            this.grpCountryDetails = new System.Windows.Forms.GroupBox();
            this.tboxCountryName = new System.Windows.Forms.TextBox();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.tboxCountryId = new System.Windows.Forms.TextBox();
            this.lblCountryId = new System.Windows.Forms.Label();
            this.grpCountryDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpCountryDetails
            // 
            this.grpCountryDetails.Controls.Add(this.tboxCountryName);
            this.grpCountryDetails.Controls.Add(this.lblCountryName);
            this.grpCountryDetails.Location = new System.Drawing.Point(15, 36);
            this.grpCountryDetails.Name = "grpCountryDetails";
            this.grpCountryDetails.Size = new System.Drawing.Size(239, 98);
            this.grpCountryDetails.TabIndex = 7;
            this.grpCountryDetails.TabStop = false;
            this.grpCountryDetails.Text = "Details";
            // 
            // tboxCountryName
            // 
            this.tboxCountryName.Location = new System.Drawing.Point(50, 25);
            this.tboxCountryName.Name = "tboxCountryName";
            this.tboxCountryName.Size = new System.Drawing.Size(171, 20);
            this.tboxCountryName.TabIndex = 1;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Location = new System.Drawing.Point(6, 28);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(38, 13);
            this.lblCountryName.TabIndex = 0;
            this.lblCountryName.Text = "Name:";
            // 
            // tboxCountryId
            // 
            this.tboxCountryId.Location = new System.Drawing.Point(39, 6);
            this.tboxCountryId.Name = "tboxCountryId";
            this.tboxCountryId.ReadOnly = true;
            this.tboxCountryId.Size = new System.Drawing.Size(47, 20);
            this.tboxCountryId.TabIndex = 6;
            // 
            // lblCountryId
            // 
            this.lblCountryId.AutoSize = true;
            this.lblCountryId.Location = new System.Drawing.Point(12, 9);
            this.lblCountryId.Name = "lblCountryId";
            this.lblCountryId.Size = new System.Drawing.Size(21, 13);
            this.lblCountryId.TabIndex = 5;
            this.lblCountryId.Text = "ID:";
            // 
            // ModifyCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 176);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpCountryDetails);
            this.Controls.Add(this.tboxCountryId);
            this.Controls.Add(this.lblCountryId);
            this.Name = "ModifyCountryForm";
            this.Text = "Modify Country";
            this.Load += new System.EventHandler(this.ModifyCountryForm_Load);
            this.grpCountryDetails.ResumeLayout(false);
            this.grpCountryDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpCountryDetails;
        private System.Windows.Forms.TextBox tboxCountryName;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox tboxCountryId;
        private System.Windows.Forms.Label lblCountryId;
    }
}