namespace CarRentingManagementWinApp_QuanLNM
{
    partial class frmRentingTransaction
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
            dgvCarList = new System.Windows.Forms.DataGridView();
            dgvPendingTransaction = new System.Windows.Forms.DataGridView();
            lbCustomerID = new System.Windows.Forms.Label();
            btnRent = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lbCarList = new System.Windows.Forms.Label();
            lbTransactionList = new System.Windows.Forms.Label();
            txtCusID = new System.Windows.Forms.TextBox();
            btnFilter = new System.Windows.Forms.Button();
            lbFilter = new System.Windows.Forms.Label();
            txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPendingTransaction).BeginInit();
            SuspendLayout();
            // 
            // dgvCarList
            // 
            dgvCarList.AllowUserToAddRows = false;
            dgvCarList.AllowUserToDeleteRows = false;
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(22, 76);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(849, 237);
            dgvCarList.TabIndex = 0;
            dgvCarList.CellEnter += dgvCarList_CellEnter;
            dgvCarList.DataBindingComplete += dgvCarList_DataBindingComplete;
            // 
            // dgvPendingTransaction
            // 
            dgvPendingTransaction.AllowUserToAddRows = false;
            dgvPendingTransaction.AllowUserToDeleteRows = false;
            dgvPendingTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendingTransaction.Location = new System.Drawing.Point(22, 362);
            dgvPendingTransaction.Name = "dgvPendingTransaction";
            dgvPendingTransaction.ReadOnly = true;
            dgvPendingTransaction.RowTemplate.Height = 25;
            dgvPendingTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPendingTransaction.Size = new System.Drawing.Size(849, 151);
            dgvPendingTransaction.TabIndex = 1;
            dgvPendingTransaction.DataBindingComplete += dgvPendingTransaction_DataBindingComplete;
            // 
            // lbCustomerID
            // 
            lbCustomerID.AutoSize = true;
            lbCustomerID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCustomerID.Location = new System.Drawing.Point(29, 536);
            lbCustomerID.Name = "lbCustomerID";
            lbCustomerID.Size = new System.Drawing.Size(133, 21);
            lbCustomerID.TabIndex = 2;
            lbCustomerID.Text = "Your Customer ID";
            // 
            // btnRent
            // 
            btnRent.Location = new System.Drawing.Point(912, 76);
            btnRent.Name = "btnRent";
            btnRent.Size = new System.Drawing.Size(75, 23);
            btnRent.TabIndex = 3;
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(912, 137);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 23);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbCarList
            // 
            lbCarList.AutoSize = true;
            lbCarList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCarList.Location = new System.Drawing.Point(22, 45);
            lbCarList.Name = "lbCarList";
            lbCarList.Size = new System.Drawing.Size(75, 28);
            lbCarList.TabIndex = 6;
            lbCarList.Text = "Car List";
            // 
            // lbTransactionList
            // 
            lbTransactionList.AutoSize = true;
            lbTransactionList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbTransactionList.Location = new System.Drawing.Point(22, 331);
            lbTransactionList.Name = "lbTransactionList";
            lbTransactionList.Size = new System.Drawing.Size(178, 28);
            lbTransactionList.TabIndex = 7;
            lbTransactionList.Text = "Transaction History";
            // 
            // txtCusID
            // 
            txtCusID.Enabled = false;
            txtCusID.Location = new System.Drawing.Point(168, 538);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new System.Drawing.Size(100, 23);
            txtCusID.TabIndex = 8;
            // 
            // btnFilter
            // 
            btnFilter.Location = new System.Drawing.Point(782, 40);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(75, 23);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFilter.Location = new System.Drawing.Point(371, 40);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new System.Drawing.Size(219, 21);
            lbFilter.TabIndex = 10;
            lbFilter.Text = "Filter By Renting Price Per Day";
            // 
            // txtFilter
            // 
            txtFilter.Location = new System.Drawing.Point(610, 40);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(166, 23);
            txtFilter.TabIndex = 11;
            // 
            // frmRentingTransaction
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1044, 583);
            Controls.Add(txtFilter);
            Controls.Add(lbFilter);
            Controls.Add(btnFilter);
            Controls.Add(txtCusID);
            Controls.Add(lbTransactionList);
            Controls.Add(lbCarList);
            Controls.Add(btnExit);
            Controls.Add(btnRent);
            Controls.Add(lbCustomerID);
            Controls.Add(dgvPendingTransaction);
            Controls.Add(dgvCarList);
            Name = "frmRentingTransaction";
            Text = "Renting Transaction";
            Load += frmRentingTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPendingTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.DataGridView dgvPendingTransaction;
        private System.Windows.Forms.Label lbCustomerID;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbCarList;
        private System.Windows.Forms.Label lbTransactionList;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.TextBox txtFilter;
    }
}