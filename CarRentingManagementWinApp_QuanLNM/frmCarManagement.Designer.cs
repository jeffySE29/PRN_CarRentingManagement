namespace CarRentingManagementWinApp_QuanLNM
{
    partial class frmCarManagement
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
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lbNumberOfDoors = new System.Windows.Forms.Label();
            lbSeatingCapacity = new System.Windows.Forms.Label();
            lbFuelType = new System.Windows.Forms.Label();
            lbYear = new System.Windows.Forms.Label();
            lbManufacturerID = new System.Windows.Forms.Label();
            lbSupplierID = new System.Windows.Forms.Label();
            lbCarStatus = new System.Windows.Forms.Label();
            lbCarRentingPrice = new System.Windows.Forms.Label();
            btnCreate = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnMenu = new System.Windows.Forms.Button();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtNumOfDoors = new System.Windows.Forms.TextBox();
            txtSeatingCapacity = new System.Windows.Forms.TextBox();
            txtFuelType = new System.Windows.Forms.TextBox();
            txtYear = new System.Windows.Forms.TextBox();
            txtManuID = new System.Windows.Forms.TextBox();
            txtSupID = new System.Windows.Forms.TextBox();
            txtCarStatus = new System.Windows.Forms.TextBox();
            txtRentingPricePerDay = new System.Windows.Forms.TextBox();
            rtbCarDescription = new System.Windows.Forms.RichTextBox();
            dgvCarList = new System.Windows.Forms.DataGridView();
            dgvSupplierList = new System.Windows.Forms.DataGridView();
            dgvManufacturerList = new System.Windows.Forms.DataGridView();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            radID = new System.Windows.Forms.RadioButton();
            radName = new System.Windows.Forms.RadioButton();
            radRentingPrice = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturerList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(32, 42);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(39, 15);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(32, 79);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(60, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(32, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Car Description";
            // 
            // lbNumberOfDoors
            // 
            lbNumberOfDoors.AutoSize = true;
            lbNumberOfDoors.Location = new System.Drawing.Point(32, 196);
            lbNumberOfDoors.Name = "lbNumberOfDoors";
            lbNumberOfDoors.Size = new System.Drawing.Size(101, 15);
            lbNumberOfDoors.TabIndex = 3;
            lbNumberOfDoors.Text = "Number Of Doors";
            // 
            // lbSeatingCapacity
            // 
            lbSeatingCapacity.AutoSize = true;
            lbSeatingCapacity.Location = new System.Drawing.Point(32, 232);
            lbSeatingCapacity.Name = "lbSeatingCapacity";
            lbSeatingCapacity.Size = new System.Drawing.Size(95, 15);
            lbSeatingCapacity.TabIndex = 4;
            lbSeatingCapacity.Text = "Seating Capacity";
            // 
            // lbFuelType
            // 
            lbFuelType.AutoSize = true;
            lbFuelType.Location = new System.Drawing.Point(32, 268);
            lbFuelType.Name = "lbFuelType";
            lbFuelType.Size = new System.Drawing.Size(56, 15);
            lbFuelType.TabIndex = 5;
            lbFuelType.Text = "Fuel Type";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new System.Drawing.Point(32, 303);
            lbYear.Name = "lbYear";
            lbYear.Size = new System.Drawing.Size(29, 15);
            lbYear.TabIndex = 6;
            lbYear.Text = "Year";
            // 
            // lbManufacturerID
            // 
            lbManufacturerID.AutoSize = true;
            lbManufacturerID.Location = new System.Drawing.Point(32, 341);
            lbManufacturerID.Name = "lbManufacturerID";
            lbManufacturerID.Size = new System.Drawing.Size(93, 15);
            lbManufacturerID.TabIndex = 7;
            lbManufacturerID.Text = "Manufacturer ID";
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.Location = new System.Drawing.Point(32, 379);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new System.Drawing.Size(64, 15);
            lbSupplierID.TabIndex = 8;
            lbSupplierID.Text = "Supplier ID";
            // 
            // lbCarStatus
            // 
            lbCarStatus.AutoSize = true;
            lbCarStatus.Location = new System.Drawing.Point(31, 415);
            lbCarStatus.Name = "lbCarStatus";
            lbCarStatus.Size = new System.Drawing.Size(57, 15);
            lbCarStatus.TabIndex = 9;
            lbCarStatus.Text = "CarStatus";
            // 
            // lbCarRentingPrice
            // 
            lbCarRentingPrice.AutoSize = true;
            lbCarRentingPrice.Location = new System.Drawing.Point(32, 450);
            lbCarRentingPrice.Name = "lbCarRentingPrice";
            lbCarRentingPrice.Size = new System.Drawing.Size(141, 15);
            lbCarRentingPrice.TabIndex = 10;
            lbCarRentingPrice.Text = "Car Renting Price Per Day";
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(45, 564);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(75, 23);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(151, 564);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(253, 564);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new System.Drawing.Point(359, 564);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(75, 23);
            btnMenu.TabIndex = 15;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(186, 39);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(269, 23);
            txtCarID.TabIndex = 16;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(186, 76);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(269, 23);
            txtCarName.TabIndex = 17;
            // 
            // txtNumOfDoors
            // 
            txtNumOfDoors.Location = new System.Drawing.Point(186, 193);
            txtNumOfDoors.Name = "txtNumOfDoors";
            txtNumOfDoors.Size = new System.Drawing.Size(269, 23);
            txtNumOfDoors.TabIndex = 18;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.Location = new System.Drawing.Point(186, 229);
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.Size = new System.Drawing.Size(269, 23);
            txtSeatingCapacity.TabIndex = 19;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new System.Drawing.Point(186, 265);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new System.Drawing.Size(269, 23);
            txtFuelType.TabIndex = 20;
            // 
            // txtYear
            // 
            txtYear.Location = new System.Drawing.Point(186, 300);
            txtYear.Name = "txtYear";
            txtYear.Size = new System.Drawing.Size(269, 23);
            txtYear.TabIndex = 21;
            // 
            // txtManuID
            // 
            txtManuID.Location = new System.Drawing.Point(186, 338);
            txtManuID.Name = "txtManuID";
            txtManuID.Size = new System.Drawing.Size(269, 23);
            txtManuID.TabIndex = 22;
            // 
            // txtSupID
            // 
            txtSupID.Location = new System.Drawing.Point(186, 376);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new System.Drawing.Size(269, 23);
            txtSupID.TabIndex = 23;
            // 
            // txtCarStatus
            // 
            txtCarStatus.Location = new System.Drawing.Point(186, 412);
            txtCarStatus.Name = "txtCarStatus";
            txtCarStatus.Size = new System.Drawing.Size(269, 23);
            txtCarStatus.TabIndex = 24;
            // 
            // txtRentingPricePerDay
            // 
            txtRentingPricePerDay.Location = new System.Drawing.Point(186, 447);
            txtRentingPricePerDay.Name = "txtRentingPricePerDay";
            txtRentingPricePerDay.Size = new System.Drawing.Size(269, 23);
            txtRentingPricePerDay.TabIndex = 25;
            // 
            // rtbCarDescription
            // 
            rtbCarDescription.Location = new System.Drawing.Point(186, 117);
            rtbCarDescription.Name = "rtbCarDescription";
            rtbCarDescription.Size = new System.Drawing.Size(269, 60);
            rtbCarDescription.TabIndex = 26;
            rtbCarDescription.Text = "";
            // 
            // dgvCarList
            // 
            dgvCarList.AllowUserToAddRows = false;
            dgvCarList.AllowUserToDeleteRows = false;
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(487, 245);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.Size = new System.Drawing.Size(688, 342);
            dgvCarList.TabIndex = 27;
            dgvCarList.DataBindingComplete += dgvCarList_DataBindingComplete;
            // 
            // dgvSupplierList
            // 
            dgvSupplierList.AllowUserToAddRows = false;
            dgvSupplierList.AllowUserToDeleteRows = false;
            dgvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierList.Location = new System.Drawing.Point(487, 29);
            dgvSupplierList.Name = "dgvSupplierList";
            dgvSupplierList.ReadOnly = true;
            dgvSupplierList.RowTemplate.Height = 25;
            dgvSupplierList.Size = new System.Drawing.Size(346, 201);
            dgvSupplierList.TabIndex = 28;
            dgvSupplierList.DataBindingComplete += dgvSupplierList_DataBindingComplete;
            // 
            // dgvManufacturerList
            // 
            dgvManufacturerList.AllowUserToAddRows = false;
            dgvManufacturerList.AllowUserToDeleteRows = false;
            dgvManufacturerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManufacturerList.Location = new System.Drawing.Point(853, 29);
            dgvManufacturerList.Name = "dgvManufacturerList";
            dgvManufacturerList.ReadOnly = true;
            dgvManufacturerList.RowTemplate.Height = 25;
            dgvManufacturerList.Size = new System.Drawing.Size(322, 201);
            dgvManufacturerList.TabIndex = 29;
            dgvManufacturerList.DataBindingComplete += dgvManufacturerList_DataBindingComplete;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(12, 502);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(219, 23);
            txtSearch.TabIndex = 30;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(237, 502);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // radID
            // 
            radID.AutoSize = true;
            radID.Checked = true;
            radID.Location = new System.Drawing.Point(328, 481);
            radID.Name = "radID";
            radID.Size = new System.Drawing.Size(57, 19);
            radID.TabIndex = 32;
            radID.TabStop = true;
            radID.Text = "Car ID";
            radID.UseVisualStyleBackColor = true;
            // 
            // radName
            // 
            radName.AutoSize = true;
            radName.Location = new System.Drawing.Point(328, 506);
            radName.Name = "radName";
            radName.Size = new System.Drawing.Size(78, 19);
            radName.TabIndex = 33;
            radName.Text = "Car Name";
            radName.UseVisualStyleBackColor = true;
            // 
            // radRentingPrice
            // 
            radRentingPrice.AutoSize = true;
            radRentingPrice.Location = new System.Drawing.Point(328, 531);
            radRentingPrice.Name = "radRentingPrice";
            radRentingPrice.Size = new System.Drawing.Size(95, 19);
            radRentingPrice.TabIndex = 34;
            radRentingPrice.Text = "Renting Price";
            radRentingPrice.UseVisualStyleBackColor = true;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1187, 599);
            Controls.Add(radRentingPrice);
            Controls.Add(radName);
            Controls.Add(radID);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvManufacturerList);
            Controls.Add(dgvSupplierList);
            Controls.Add(dgvCarList);
            Controls.Add(rtbCarDescription);
            Controls.Add(txtRentingPricePerDay);
            Controls.Add(txtCarStatus);
            Controls.Add(txtSupID);
            Controls.Add(txtManuID);
            Controls.Add(txtYear);
            Controls.Add(txtFuelType);
            Controls.Add(txtSeatingCapacity);
            Controls.Add(txtNumOfDoors);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(btnMenu);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lbCarRentingPrice);
            Controls.Add(lbCarStatus);
            Controls.Add(lbSupplierID);
            Controls.Add(lbManufacturerID);
            Controls.Add(lbYear);
            Controls.Add(lbFuelType);
            Controls.Add(lbSeatingCapacity);
            Controls.Add(lbNumberOfDoors);
            Controls.Add(label3);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNumberOfDoors;
        private System.Windows.Forms.Label lbSeatingCapacity;
        private System.Windows.Forms.Label lbFuelType;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbManufacturerID;
        private System.Windows.Forms.Label lbSupplierID;
        private System.Windows.Forms.Label lbCarStatus;
        private System.Windows.Forms.Label lbCarRentingPrice;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtNumOfDoors;
        private System.Windows.Forms.TextBox txtSeatingCapacity;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtManuID;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.TextBox txtCarStatus;
        private System.Windows.Forms.TextBox txtRentingPricePerDay;
        private System.Windows.Forms.RichTextBox rtbCarDescription;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.DataGridView dgvSupplierList;
        private System.Windows.Forms.DataGridView dgvManufacturerList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radID;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radRentingPrice;
    }
}