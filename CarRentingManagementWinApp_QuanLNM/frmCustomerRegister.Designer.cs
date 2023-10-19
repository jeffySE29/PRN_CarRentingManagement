namespace CarRentingManagementWinApp_QuanLNM
{
    partial class frmCustomerRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCusName = new System.Windows.Forms.Label();
            lbTelephone = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbBirthday = new System.Windows.Forms.Label();
            lbStatus = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtStatus = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            dtpBirthday = new System.Windows.Forms.DateTimePicker();
            btnSave = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbCusName
            // 
            lbCusName.AutoSize = true;
            lbCusName.Location = new System.Drawing.Point(26, 54);
            lbCusName.Name = "lbCusName";
            lbCusName.Size = new System.Drawing.Size(39, 15);
            lbCusName.TabIndex = 1;
            lbCusName.Text = "Name";
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new System.Drawing.Point(26, 99);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new System.Drawing.Size(61, 15);
            lbTelephone.TabIndex = 2;
            lbTelephone.Text = "Telephone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(26, 141);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new System.Drawing.Point(302, 51);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new System.Drawing.Size(51, 15);
            lbBirthday.TabIndex = 4;
            lbBirthday.Text = "Birthday";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new System.Drawing.Point(302, 96);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new System.Drawing.Size(39, 15);
            lbStatus.TabIndex = 5;
            lbStatus.Text = "Status";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(302, 141);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 6;
            lbPassword.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(93, 51);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(184, 23);
            txtName.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(93, 96);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(184, 23);
            txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(93, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(184, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(368, 93);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(200, 23);
            txtStatus.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(368, 138);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(200, 23);
            txtPassword.TabIndex = 12;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new System.Drawing.Point(368, 48);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new System.Drawing.Size(200, 23);
            dtpBirthday.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(368, 203);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(493, 203);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(75, 23);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmCustomerRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(602, 259);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(dtpBirthday);
            Controls.Add(txtPassword);
            Controls.Add(txtStatus);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lbPassword);
            Controls.Add(lbStatus);
            Controls.Add(lbBirthday);
            Controls.Add(lbEmail);
            Controls.Add(lbTelephone);
            Controls.Add(lbCusName);
            Name = "frmCustomerRegister";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Register";
            Load += frmCustomerRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbCusName;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}