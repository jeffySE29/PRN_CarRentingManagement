namespace CarRentingManagementWinApp_QuanLNM
{
    partial class frmCarDetails
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
            dgvManufacturerList = new System.Windows.Forms.DataGridView();
            dgvSupplierList = new System.Windows.Forms.DataGridView();
            txtCarID = new System.Windows.Forms.TextBox();
            lbCarRentingPrice = new System.Windows.Forms.Label();
            lbCarStatus = new System.Windows.Forms.Label();
            lbSupplierID = new System.Windows.Forms.Label();
            lbManufacturerID = new System.Windows.Forms.Label();
            lbYear = new System.Windows.Forms.Label();
            lbFuelType = new System.Windows.Forms.Label();
            lbSeatingCapacity = new System.Windows.Forms.Label();
            lbNumberOfDoors = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbCarID = new System.Windows.Forms.Label();
            rtbCarDescription = new System.Windows.Forms.RichTextBox();
            txtRentingPricePerDay = new System.Windows.Forms.TextBox();
            txtCarStatus = new System.Windows.Forms.TextBox();
            txtSupID = new System.Windows.Forms.TextBox();
            txtManuID = new System.Windows.Forms.TextBox();
            txtYear = new System.Windows.Forms.TextBox();
            txtFuelType = new System.Windows.Forms.TextBox();
            txtSeatingCapacity = new System.Windows.Forms.TextBox();
            txtNumOfDoors = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvManufacturerList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).BeginInit();
            SuspendLayout();
            // 
            // dgvManufacturerList
            // 
            dgvManufacturerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManufacturerList.Location = new System.Drawing.Point(554, 264);
            dgvManufacturerList.Name = "dgvManufacturerList";
            dgvManufacturerList.RowTemplate.Height = 25;
            dgvManufacturerList.Size = new System.Drawing.Size(505, 257);
            dgvManufacturerList.TabIndex = 54;
            // 
            // dgvSupplierList
            // 
            dgvSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierList.Location = new System.Drawing.Point(554, 23);
            dgvSupplierList.Name = "dgvSupplierList";
            dgvSupplierList.RowTemplate.Height = 25;
            dgvSupplierList.Size = new System.Drawing.Size(505, 219);
            dgvSupplierList.TabIndex = 53;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(-17, -44);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(269, 23);
            txtCarID.TabIndex = 41;
            // 
            // lbCarRentingPrice
            // 
            lbCarRentingPrice.AutoSize = true;
            lbCarRentingPrice.Location = new System.Drawing.Point(-171, 367);
            lbCarRentingPrice.Name = "lbCarRentingPrice";
            lbCarRentingPrice.Size = new System.Drawing.Size(141, 15);
            lbCarRentingPrice.TabIndex = 40;
            lbCarRentingPrice.Text = "Car Renting Price Per Day";
            // 
            // lbCarStatus
            // 
            lbCarStatus.AutoSize = true;
            lbCarStatus.Location = new System.Drawing.Point(-172, 332);
            lbCarStatus.Name = "lbCarStatus";
            lbCarStatus.Size = new System.Drawing.Size(57, 15);
            lbCarStatus.TabIndex = 39;
            lbCarStatus.Text = "CarStatus";
            // 
            // lbSupplierID
            // 
            lbSupplierID.AutoSize = true;
            lbSupplierID.Location = new System.Drawing.Point(-171, 296);
            lbSupplierID.Name = "lbSupplierID";
            lbSupplierID.Size = new System.Drawing.Size(64, 15);
            lbSupplierID.TabIndex = 38;
            lbSupplierID.Text = "Supplier ID";
            // 
            // lbManufacturerID
            // 
            lbManufacturerID.AutoSize = true;
            lbManufacturerID.Location = new System.Drawing.Point(-171, 258);
            lbManufacturerID.Name = "lbManufacturerID";
            lbManufacturerID.Size = new System.Drawing.Size(93, 15);
            lbManufacturerID.TabIndex = 37;
            lbManufacturerID.Text = "Manufacturer ID";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new System.Drawing.Point(-171, 220);
            lbYear.Name = "lbYear";
            lbYear.Size = new System.Drawing.Size(29, 15);
            lbYear.TabIndex = 36;
            lbYear.Text = "Year";
            // 
            // lbFuelType
            // 
            lbFuelType.AutoSize = true;
            lbFuelType.Location = new System.Drawing.Point(-171, 185);
            lbFuelType.Name = "lbFuelType";
            lbFuelType.Size = new System.Drawing.Size(56, 15);
            lbFuelType.TabIndex = 35;
            lbFuelType.Text = "Fuel Type";
            // 
            // lbSeatingCapacity
            // 
            lbSeatingCapacity.AutoSize = true;
            lbSeatingCapacity.Location = new System.Drawing.Point(-171, 149);
            lbSeatingCapacity.Name = "lbSeatingCapacity";
            lbSeatingCapacity.Size = new System.Drawing.Size(95, 15);
            lbSeatingCapacity.TabIndex = 34;
            lbSeatingCapacity.Text = "Seating Capacity";
            // 
            // lbNumberOfDoors
            // 
            lbNumberOfDoors.AutoSize = true;
            lbNumberOfDoors.Location = new System.Drawing.Point(-171, 113);
            lbNumberOfDoors.Name = "lbNumberOfDoors";
            lbNumberOfDoors.Size = new System.Drawing.Size(101, 15);
            lbNumberOfDoors.TabIndex = 33;
            lbNumberOfDoors.Text = "Number Of Doors";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(-171, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 15);
            label3.TabIndex = 32;
            label3.Text = "Car Description";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(-171, -4);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(60, 15);
            lbCarName.TabIndex = 31;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(-171, -41);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(39, 15);
            lbCarID.TabIndex = 30;
            lbCarID.Text = "Car ID";
            // 
            // rtbCarDescription
            // 
            rtbCarDescription.Location = new System.Drawing.Point(234, 112);
            rtbCarDescription.Name = "rtbCarDescription";
            rtbCarDescription.Size = new System.Drawing.Size(269, 60);
            rtbCarDescription.TabIndex = 76;
            rtbCarDescription.Text = "";
            // 
            // txtRentingPricePerDay
            // 
            txtRentingPricePerDay.Location = new System.Drawing.Point(234, 442);
            txtRentingPricePerDay.Name = "txtRentingPricePerDay";
            txtRentingPricePerDay.Size = new System.Drawing.Size(269, 23);
            txtRentingPricePerDay.TabIndex = 75;
            // 
            // txtCarStatus
            // 
            txtCarStatus.Location = new System.Drawing.Point(234, 407);
            txtCarStatus.Name = "txtCarStatus";
            txtCarStatus.Size = new System.Drawing.Size(269, 23);
            txtCarStatus.TabIndex = 74;
            // 
            // txtSupID
            // 
            txtSupID.Location = new System.Drawing.Point(234, 371);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new System.Drawing.Size(269, 23);
            txtSupID.TabIndex = 73;
            // 
            // txtManuID
            // 
            txtManuID.Location = new System.Drawing.Point(234, 333);
            txtManuID.Name = "txtManuID";
            txtManuID.Size = new System.Drawing.Size(269, 23);
            txtManuID.TabIndex = 72;
            // 
            // txtYear
            // 
            txtYear.Location = new System.Drawing.Point(234, 295);
            txtYear.Name = "txtYear";
            txtYear.Size = new System.Drawing.Size(269, 23);
            txtYear.TabIndex = 71;
            // 
            // txtFuelType
            // 
            txtFuelType.Location = new System.Drawing.Point(234, 260);
            txtFuelType.Name = "txtFuelType";
            txtFuelType.Size = new System.Drawing.Size(269, 23);
            txtFuelType.TabIndex = 70;
            // 
            // txtSeatingCapacity
            // 
            txtSeatingCapacity.Location = new System.Drawing.Point(234, 224);
            txtSeatingCapacity.Name = "txtSeatingCapacity";
            txtSeatingCapacity.Size = new System.Drawing.Size(269, 23);
            txtSeatingCapacity.TabIndex = 69;
            // 
            // txtNumOfDoors
            // 
            txtNumOfDoors.Location = new System.Drawing.Point(234, 188);
            txtNumOfDoors.Name = "txtNumOfDoors";
            txtNumOfDoors.Size = new System.Drawing.Size(269, 23);
            txtNumOfDoors.TabIndex = 68;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(234, 71);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(269, 23);
            txtCarName.TabIndex = 67;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new System.Drawing.Point(234, 34);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(269, 23);
            txtID.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(80, 445);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 15);
            label1.TabIndex = 65;
            label1.Text = "Car Renting Price Per Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(79, 410);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 15);
            label2.TabIndex = 64;
            label2.Text = "CarStatus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(80, 374);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 15);
            label4.TabIndex = 63;
            label4.Text = "Supplier ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(80, 336);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 15);
            label5.TabIndex = 62;
            label5.Text = "Manufacturer ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(80, 298);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(29, 15);
            label6.TabIndex = 61;
            label6.Text = "Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(80, 263);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 15);
            label7.TabIndex = 60;
            label7.Text = "Fuel Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(80, 227);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(95, 15);
            label8.TabIndex = 59;
            label8.Text = "Seating Capacity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(80, 191);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(101, 15);
            label9.TabIndex = 58;
            label9.Text = "Number Of Doors";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(80, 115);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(88, 15);
            label10.TabIndex = 57;
            label10.Text = "Car Description";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(80, 74);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(60, 15);
            label11.TabIndex = 56;
            label11.Text = "Car Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(80, 37);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(39, 15);
            label12.TabIndex = 55;
            label12.Text = "Car ID";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(289, 498);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 77;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(428, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 78;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1090, 549);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(dgvManufacturerList);
            Controls.Add(dgvSupplierList);
            Controls.Add(txtCarID);
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
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManufacturerList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManufacturerList;
        private System.Windows.Forms.DataGridView dgvSupplierList;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lbCarRentingPrice;
        private System.Windows.Forms.Label lbCarStatus;
        private System.Windows.Forms.Label lbSupplierID;
        private System.Windows.Forms.Label lbManufacturerID;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbFuelType;
        private System.Windows.Forms.Label lbSeatingCapacity;
        private System.Windows.Forms.Label lbNumberOfDoors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.RichTextBox rtbCarDescription;
        private System.Windows.Forms.TextBox txtRentingPricePerDay;
        private System.Windows.Forms.TextBox txtCarStatus;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.TextBox txtManuID;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.TextBox txtSeatingCapacity;
        private System.Windows.Forms.TextBox txtNumOfDoors;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}