namespace CarRentingManagementWinApp_QuanLNM
{
    partial class frmLogin
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
            btnLogin = new System.Windows.Forms.Button();
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnRegister = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(425, 257);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbEmail.Location = new System.Drawing.Point(79, 134);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(48, 21);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPassword.Location = new System.Drawing.Point(79, 194);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(76, 21);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(152, 64);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(294, 37);
            lbTitle.TabIndex = 4;
            lbTitle.Text = "CAR RENTING WEBSITE";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(191, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(309, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(191, 196);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(309, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(287, 257);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(75, 23);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(628, 349);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbTitle);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(btnLogin);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
    }
}