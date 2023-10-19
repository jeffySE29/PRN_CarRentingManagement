using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentingManagementWinApp_QuanLNM
{
    public partial class frmCarDetails : Form
    {
        ICarInformationRepository car = new CarInformationRepository();
        public frmCarDetails()
        {
            InitializeComponent();
        }

        public ICarInformationRepository CarInfor { get; set; }
        public bool CreateOrUpdate { get; set; }

        public CarInformation CarInfo { get; set; }




        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (CreateOrUpdate == true)
            {
                txtID.Text = CarInfo.CarId.ToString();
                txtCarName.Text = CarInfo.CarName.ToString();
                rtbCarDescription.Text = CarInfo.CarDescription.ToString();
                txtNumOfDoors.Text = CarInfo.NumberOfDoors.ToString();
                txtSeatingCapacity.Text = CarInfo.SeatingCapacity.ToString();
                txtFuelType.Text = CarInfo.FuelType.ToString();
                txtYear.Text = CarInfo.Year.ToString();
                txtManuID.Text = CarInfo.ManufacturerId.ToString();
                txtSupID.Text = CarInfo.SupplierId.ToString();
                txtCarStatus.Text = CarInfo.CarStatus.ToString();
                txtRentingPricePerDay.Text = CarInfo.CarRentingPricePerDay.ToString();
            }
            LoadManufacturerList();
            LoadSupplierList();
        }

        public void LoadManufacturerList()
        {
            try
            {
                var manuList = car.GetManufacturersList();
                BindingSource source = new BindingSource();
                source.DataSource = manuList;

                dgvManufacturerList.DataSource = null;
                dgvManufacturerList.DataSource = manuList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of manufacturer");
            }
        }

        public void LoadSupplierList()
        {
            try
            {
                var manuList = car.GetSuppliersList();
                BindingSource source = new BindingSource();
                source.DataSource = manuList;

                dgvSupplierList.DataSource = null;
                dgvSupplierList.DataSource = manuList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of supplier");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CreateOrUpdate == false)
            {
                if (txtCarName.Text.Trim() == "" ||
                rtbCarDescription.Text.Trim() == "" || txtNumOfDoors.Text.Trim() == "" ||
                txtSeatingCapacity.Text.Trim() == "" || txtFuelType.Text.Trim() == "" || txtYear.Text.Trim() == "" ||
                txtManuID.Text.Trim() == "" || txtSupID.Text.Trim() == "" || txtCarStatus.Text.Trim() == "" ||
                txtRentingPricePerDay.Text.Trim() == "")
                {
                    MessageBox.Show("All fields are required!", "Car Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var carInformation = new CarInformation
                    {
                        CarName = txtCarName.Text,
                        CarDescription = rtbCarDescription.Text,
                        NumberOfDoors = int.Parse(txtNumOfDoors.Text),
                        SeatingCapacity = int.Parse(txtSeatingCapacity.Text),
                        FuelType = txtFuelType.Text,
                        Year = int.Parse(txtYear.Text),
                        ManufacturerId = int.Parse(txtManuID.Text),
                        SupplierId = int.Parse(txtSupID.Text),
                        CarStatus = byte.Parse(txtCarStatus.Text),
                        CarRentingPricePerDay = decimal.Parse(txtRentingPricePerDay.Text)

                    };
                    CarInfor.CreateCarInfomation(carInformation);

                }
            }
            else
            {
                if (txtID.Text.Trim() == "" || txtCarName.Text.Trim() == "" ||
                rtbCarDescription.Text.Trim() == "" || txtNumOfDoors.Text.Trim() == "" ||
                txtSeatingCapacity.Text.Trim() == "" || txtFuelType.Text.Trim() == "" || txtYear.Text.Trim() == "" ||
                txtManuID.Text.Trim() == "" || txtSupID.Text.Trim() == "" || txtCarStatus.Text.Trim() == "" ||
                txtRentingPricePerDay.Text.Trim() == "")
                {
                    MessageBox.Show("All fields are required!", "Car Management System",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var carInformation = new CarInformation
                    {
                        CarId = int.Parse(txtID.Text),
                        CarName = txtCarName.Text,
                        CarDescription = rtbCarDescription.Text,
                        NumberOfDoors = int.Parse(txtNumOfDoors.Text),
                        SeatingCapacity = int.Parse(txtSeatingCapacity.Text),
                        FuelType = txtFuelType.Text,
                        Year = int.Parse(txtYear.Text),
                        ManufacturerId = int.Parse(txtManuID.Text),
                        SupplierId = int.Parse(txtSupID.Text),
                        CarStatus = byte.Parse(txtCarStatus.Text),
                        CarRentingPricePerDay = decimal.Parse(txtRentingPricePerDay.Text)

                    };
                    CarInfor.UpdateCarInformation(carInformation);

                }
            }
            btnSave.Enabled = false;
            this.Hide();
            frmCarManagement f = new frmCarManagement();
            f.ShowDialog();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
