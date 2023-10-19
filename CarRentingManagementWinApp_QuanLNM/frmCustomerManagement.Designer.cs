namespace CarRentingManagementWinApp_QuanLNM
{
    partial class frmCustomerManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCusID = new System.Windows.Forms.Label();
            lbCustomerName = new System.Windows.Forms.Label();
            lbTelephone = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbCusBirthday = new System.Windows.Forms.Label();
            lbCusStatus = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtCusName = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtCusStatus = new System.Windows.Forms.TextBox();
            btnMenu = new System.Windows.Forms.Button();
            dgvCusList = new System.Windows.Forms.DataGridView();
            dtpCusBirthday = new System.Windows.Forms.DateTimePicker();
            btnDelete = new System.Windows.Forms.Button();
            lbPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvCusList).BeginInit();
            SuspendLayout();
            // 
            // lbCusID
            // 
            lbCusID.AutoSize = true;
            lbCusID.Location = new System.Drawing.Point(43, 35);
            lbCusID.Name = "lbCusID";
            lbCusID.Size = new System.Drawing.Size(73, 15);
            lbCusID.TabIndex = 0;
            lbCusID.Text = "Customer ID";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new System.Drawing.Point(43, 69);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new System.Drawing.Size(94, 15);
            lbCustomerName.TabIndex = 1;
            lbCustomerName.Text = "Customer Name";
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new System.Drawing.Point(43, 106);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new System.Drawing.Size(61, 15);
            lbTelephone.TabIndex = 2;
            lbTelephone.Text = "Telephone";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(404, 35);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbCusBirthday
            // 
            lbCusBirthday.AutoSize = true;
            lbCusBirthday.Location = new System.Drawing.Point(404, 69);
            lbCusBirthday.Name = "lbCusBirthday";
            lbCusBirthday.Size = new System.Drawing.Size(106, 15);
            lbCusBirthday.TabIndex = 4;
            lbCusBirthday.Text = "Customer Birthday";
            // 
            // lbCusStatus
            // 
            lbCusStatus.AutoSize = true;
            lbCusStatus.Location = new System.Drawing.Point(404, 106);
            lbCusStatus.Name = "lbCusStatus";
            lbCusStatus.Size = new System.Drawing.Size(94, 15);
            lbCusStatus.TabIndex = 5;
            lbCusStatus.Text = "Customer Status";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(155, 32);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(224, 23);
            txtID.TabIndex = 6;
            // 
            // txtCusName
            // 
            txtCusName.Location = new System.Drawing.Point(155, 66);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new System.Drawing.Size(224, 23);
            txtCusName.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(155, 103);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(224, 23);
            txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(527, 32);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(266, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtCusStatus
            // 
            txtCusStatus.Location = new System.Drawing.Point(527, 103);
            txtCusStatus.Name = "txtCusStatus";
            txtCusStatus.Size = new System.Drawing.Size(266, 23);
            txtCusStatus.TabIndex = 11;
            // 
            // btnMenu
            // 
            btnMenu.Location = new System.Drawing.Point(877, 32);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(75, 23);
            btnMenu.TabIndex = 15;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // dgvCusList
            // 
            dgvCusList.AllowUserToAddRows = false;
            dgvCusList.AllowUserToDeleteRows = false;
            dgvCusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCusList.Location = new System.Drawing.Point(23, 143);
            dgvCusList.Name = "dgvCusList";
            dgvCusList.ReadOnly = true;
            dgvCusList.RowTemplate.Height = 25;
            dgvCusList.Size = new System.Drawing.Size(998, 429);
            dgvCusList.TabIndex = 16;
            dgvCusList.DataBindingComplete += dgvCusList_DataBindingComplete;
            // 
            // dtpCusBirthday
            // 
            dtpCusBirthday.Location = new System.Drawing.Point(527, 66);
            dtpCusBirthday.Name = "dtpCusBirthday";
            dtpCusBirthday.Size = new System.Drawing.Size(266, 23);
            dtpCusBirthday.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(877, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(43, 143);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(0, 15);
            lbPassword.TabIndex = 20;
            // 
            // frmCustomerManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1043, 594);
            Controls.Add(lbPassword);
            Controls.Add(btnDelete);
            Controls.Add(dtpCusBirthday);
            Controls.Add(dgvCusList);
            Controls.Add(btnMenu);
            Controls.Add(txtCusStatus);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtCusName);
            Controls.Add(txtID);
            Controls.Add(lbCusStatus);
            Controls.Add(lbCusBirthday);
            Controls.Add(lbEmail);
            Controls.Add(lbTelephone);
            Controls.Add(lbCustomerName);
            Controls.Add(lbCusID);
            Name = "frmCustomerManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Customer Management";
            Load += frmCustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCusList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCusID;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCusBirthday;
        private System.Windows.Forms.Label lbCusStatus;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCusStatus;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dgvCusList;
        private System.Windows.Forms.DateTimePicker dtpCusBirthday;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbPassword;
    }
}
