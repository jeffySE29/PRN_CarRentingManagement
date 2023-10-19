namespace CarRentingManagementWinApp_QuanLNM
{
    partial class frmRentingManagement
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
            dgvRentingDetails = new System.Windows.Forms.DataGridView();
            dgvRentingTransaction = new System.Windows.Forms.DataGridView();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            lbFrom = new System.Windows.Forms.Label();
            lbTo = new System.Windows.Forms.Label();
            btnFilter = new System.Windows.Forms.Button();
            btnMenu = new System.Windows.Forms.Button();
            lbTotalIncome = new System.Windows.Forms.Label();
            txtIncome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRentingDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentingTransaction).BeginInit();
            SuspendLayout();
            // 
            // dgvRentingDetails
            // 
            dgvRentingDetails.AllowUserToAddRows = false;
            dgvRentingDetails.AllowUserToDeleteRows = false;
            dgvRentingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentingDetails.Location = new System.Drawing.Point(22, 69);
            dgvRentingDetails.Name = "dgvRentingDetails";
            dgvRentingDetails.ReadOnly = true;
            dgvRentingDetails.RowTemplate.Height = 25;
            dgvRentingDetails.Size = new System.Drawing.Size(991, 251);
            dgvRentingDetails.TabIndex = 0;
            dgvRentingDetails.DataBindingComplete += dgvRentingDetails_DataBindingComplete;
            // 
            // dgvRentingTransaction
            // 
            dgvRentingTransaction.AllowUserToAddRows = false;
            dgvRentingTransaction.AllowUserToDeleteRows = false;
            dgvRentingTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentingTransaction.Location = new System.Drawing.Point(22, 342);
            dgvRentingTransaction.Name = "dgvRentingTransaction";
            dgvRentingTransaction.ReadOnly = true;
            dgvRentingTransaction.RowTemplate.Height = 25;
            dgvRentingTransaction.Size = new System.Drawing.Size(991, 248);
            dgvRentingTransaction.TabIndex = 1;
            dgvRentingTransaction.DataBindingComplete += dgvRentingTransaction_DataBindingComplete;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new System.Drawing.Point(71, 31);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(200, 23);
            dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            dtpTo.Location = new System.Drawing.Point(319, 30);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(200, 23);
            dtpTo.TabIndex = 3;
            // 
            // lbFrom
            // 
            lbFrom.AutoSize = true;
            lbFrom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFrom.Location = new System.Drawing.Point(22, 33);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new System.Drawing.Size(43, 20);
            lbFrom.TabIndex = 4;
            lbFrom.Text = "From";
            // 
            // lbTo
            // 
            lbTo.AutoSize = true;
            lbTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTo.Location = new System.Drawing.Point(288, 33);
            lbTo.Name = "lbTo";
            lbTo.Size = new System.Drawing.Size(25, 20);
            lbTo.TabIndex = 5;
            lbTo.Text = "To";
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(546, 30);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(75, 23);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new System.Drawing.Point(659, 30);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(75, 23);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // lbTotalIncome
            // 
            lbTotalIncome.AutoSize = true;
            lbTotalIncome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTotalIncome.Location = new System.Drawing.Point(756, 32);
            lbTotalIncome.Name = "lbTotalIncome";
            lbTotalIncome.Size = new System.Drawing.Size(95, 20);
            lbTotalIncome.TabIndex = 8;
            lbTotalIncome.Text = "Total Income";
            // 
            // txtIncome
            // 
            txtIncome.Location = new System.Drawing.Point(857, 31);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new System.Drawing.Size(156, 23);
            txtIncome.TabIndex = 9;
            // 
            // frmRentingManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1025, 611);
            Controls.Add(txtIncome);
            Controls.Add(lbTotalIncome);
            Controls.Add(btnMenu);
            Controls.Add(btnFilter);
            Controls.Add(lbTo);
            Controls.Add(lbFrom);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(dgvRentingTransaction);
            Controls.Add(dgvRentingDetails);
            Name = "frmRentingManagement";
            Text = "Renting Management";
            Load += frmRentingManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentingDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentingTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRentingDetails;
        private System.Windows.Forms.DataGridView dgvRentingTransaction;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lbTotalIncome;
        private System.Windows.Forms.TextBox txtIncome;
    }
}