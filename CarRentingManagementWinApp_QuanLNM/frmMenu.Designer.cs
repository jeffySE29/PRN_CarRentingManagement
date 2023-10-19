namespace CarRentingManagementWinApp_QuanLNM
{
    partial class frmMenu
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
            btnCustomerManagement = new System.Windows.Forms.Button();
            btnCarManagement = new System.Windows.Forms.Button();
            btnRentingManagement = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.Location = new System.Drawing.Point(221, 174);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new System.Drawing.Size(369, 74);
            btnCustomerManagement.TabIndex = 0;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = true;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnCarManagement
            // 
            btnCarManagement.Location = new System.Drawing.Point(221, 57);
            btnCarManagement.Name = "btnCarManagement";
            btnCarManagement.Size = new System.Drawing.Size(369, 76);
            btnCarManagement.TabIndex = 1;
            btnCarManagement.Text = "Car Management";
            btnCarManagement.UseVisualStyleBackColor = true;
            btnCarManagement.Click += btnCarManagement_Click;
            // 
            // btnRentingManagement
            // 
            btnRentingManagement.Location = new System.Drawing.Point(221, 292);
            btnRentingManagement.Name = "btnRentingManagement";
            btnRentingManagement.Size = new System.Drawing.Size(369, 76);
            btnRentingManagement.TabIndex = 2;
            btnRentingManagement.Text = "Renting Management";
            btnRentingManagement.UseVisualStyleBackColor = true;
            btnRentingManagement.Click += btnRentingManagement_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(689, 415);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnRentingManagement);
            Controls.Add(btnCarManagement);
            Controls.Add(btnCustomerManagement);
            Name = "frmMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button btnCarManagement;
        private System.Windows.Forms.Button btnRentingManagement;
        private System.Windows.Forms.Button btnExit;
    }
}