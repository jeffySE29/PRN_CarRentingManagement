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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRentingManagementWinApp_QuanLNM
{
    public partial class frmCarManagement : Form
    {
        ICarInformationRepository repo = new CarInformationRepository();
        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            LoadCarList();
            LoadManufacturerList();
            LoadSupplierList();
            EnableText(false);
        }

        public void LoadCarList()
        {
            try
            {
                var carList = repo.GetCarInformations();
                BindingSource source = new BindingSource();
                source.DataSource = carList;

                txtCarID.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                rtbCarDescription.DataBindings.Clear();
                txtNumOfDoors.DataBindings.Clear();
                txtSeatingCapacity.DataBindings.Clear();
                txtFuelType.DataBindings.Clear();
                txtYear.DataBindings.Clear();
                txtManuID.DataBindings.Clear();
                txtSupID.DataBindings.Clear();
                txtCarStatus.DataBindings.Clear();
                txtRentingPricePerDay.DataBindings.Clear();

                txtCarID.DataBindings.Add("Text", source, "CarID");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                rtbCarDescription.DataBindings.Add("Text", source, "CarDescription");
                txtNumOfDoors.DataBindings.Add("Text", source, "NumberOfDoors");
                txtSeatingCapacity.DataBindings.Add("Text", source, "SeatingCapacity");
                txtFuelType.DataBindings.Add("Text", source, "FuelType");
                txtYear.DataBindings.Add("Text", source, "Year");
                txtManuID.DataBindings.Add("Text", source, "ManufacturerID");
                txtSupID.DataBindings.Add("Text", source, "SupplierID");
                txtCarStatus.DataBindings.Add("Text", source, "CarStatus");
                txtRentingPricePerDay.DataBindings.Add("Text", source, "CarRentingPricePerDay");

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = source;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of car");
            }
        }

        public void LoadManufacturerList()
        {
            try
            {
                var manuList = repo.GetManufacturersList();
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
                var manuList = repo.GetSuppliersList();
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

        private CarInformation GetCarObject()
        {
            CarInformation car = null;
            try
            {
                car = new CarInformation
                {
                    CarId = int.Parse(txtCarID.Text),
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return car;
        }
        private void EnableText(bool status)
        {
            txtCarID.Enabled = status;
            txtCarName.Enabled = status;
            rtbCarDescription.Enabled = status;
            txtNumOfDoors.Enabled = status;
            txtSeatingCapacity.Enabled = status;
            txtFuelType.Enabled = status;
            txtYear.Enabled = status;
            txtManuID.Enabled = status;
            txtSupID.Enabled = status;
            txtCarStatus.Enabled = status;
            txtRentingPricePerDay.Enabled = status;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCarDetails f = new frmCarDetails
            {
                Text = "Create car",
                CreateOrUpdate = false,
                CarInfor = repo,
                CarInfo = GetCarObject()
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCarDetails f = new frmCarDetails
            {
                Text = "Update car",
                CreateOrUpdate = true,
                CarInfor = repo,
                CarInfo = GetCarObject()
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Car Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var carInfo = new CarInformation
                {
                    CarId = int.Parse(txtCarID.Text),
                };
                repo.DeleteCarInformation(carInfo);
                LoadCarList();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f = new frmMenu();
            f.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            if (searchTerm.Length == 0)
            {
                LoadCarList();
            }
            else if (radID.Checked)
            {
                var data = repo.GetCarInformationById(int.Parse(searchTerm));
                BindingSource src = new BindingSource();
                src.DataSource = data;

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = src;
            }
            else if (radName.Checked)
            {
                var data = repo.GetCarInformationByName(searchTerm.ToLower());
                BindingSource src = new BindingSource();
                src.DataSource = data;

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = src;
            }
            else if (radRentingPrice.Checked)
            {
                var data = repo.GetCarInformationByCarRentingPricePerDay(decimal.Parse(searchTerm));
                BindingSource src = new BindingSource();
                src.DataSource = data;

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = src;
            }
        }

        private void dgvSupplierList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSupplierList.Columns["CarInformations"].Visible = false;
        }

        private void dgvManufacturerList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvManufacturerList.Columns["CarInformations"].Visible = false;
        }

        private void dgvCarList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCarList.Columns["Manufacturer"].Visible = false;
            dgvCarList.Columns["Supplier"].Visible = false;
            dgvCarList.Columns["RentingDetails"].Visible = false;

        }
    }
}
