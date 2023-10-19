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

namespace CarRentingManagementWinApp_QuanLNM
{
    public partial class frmRentingTransaction : Form
    {
        ICarInformationRepository carRepo = new CarInformationRepository();
        IRentingTransactionRepository rentRepo = new RentingTransactionRepository();
        private int cusId;
        public frmRentingTransaction(int cusId)
        {
            InitializeComponent();
            this.cusId = cusId;
        }

        private void frmRentingTransaction_Load(object sender, EventArgs e)
        {
            LoadCarList();
            txtCusID.Text = cusId.ToString();
            List<RentingTransaction> transactionHistory = rentRepo.GetRentingListByCusID(cusId);
            dgvPendingTransaction.DataSource = transactionHistory;
        }

        public void LoadCarList()
        {
            try
            {
                var carList = carRepo.GetCarInformations();
                BindingSource source = new BindingSource();
                source.DataSource = carList;

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = carList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of car");
            }
        }
        CarInformation carObject = new CarInformation();
        private void btnRent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRentingDetails frm = new frmRentingDetails
            {
                Text = "Renting car details",
                CarInfo = carObject,
                CarRentingInfo = carRepo,
                customerID = cusId
            };
            List<RentingTransaction> transactionHistory = rentRepo.GetRentingListByCusID(cusId);
            dgvPendingTransaction.DataSource = transactionHistory;
            this.Close();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
            }

        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(txtFilter.Text);
            var data = carRepo.GetCarInformationByCarRentingPricePerDay(price);
            BindingSource src = new BindingSource();
            src.DataSource = data;

            dgvCarList.DataSource = null;
            dgvCarList.DataSource = src;

        }

        private void dgvCarList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCarList.Columns["Manufacturer"].Visible = false;
            dgvCarList.Columns["Supplier"].Visible = false;
            dgvCarList.Columns["RentingDetails"].Visible = false;
        }

        private void dgvPendingTransaction_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPendingTransaction.Columns["Customer"].Visible = false;
            dgvPendingTransaction.Columns["RentingDetails"].Visible = false;
        }

        private void dgvCarList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Đảm bảo rằng người dùng đã click vào một hàng hợp lệ
                {
                    DataGridViewRow row = dgvCarList.Rows[e.RowIndex];

                    CarInformation carInfo = new CarInformation
                    {
                        CarId = int.Parse(row.Cells["CarId"].Value.ToString()),
                        CarName = row.Cells["CarName"].Value.ToString(),
                        CarDescription = row.Cells["CarDescription"].Value.ToString(),
                        NumberOfDoors = int.Parse(row.Cells["NumberOfDoors"].Value.ToString()),
                        SeatingCapacity = int.Parse(row.Cells["SeatingCapacity"].Value.ToString()),
                        FuelType = row.Cells["FuelType"].Value.ToString(),
                        Year = int.Parse(row.Cells["Year"].Value.ToString()),
                        ManufacturerId = int.Parse(row.Cells["ManufacturerId"].Value.ToString()),
                        SupplierId = int.Parse(row.Cells["SupplierId"].Value.ToString()),
                        CarStatus = byte.Parse(row.Cells["CarStatus"].Value.ToString()),
                        CarRentingPricePerDay = decimal.Parse(row.Cells["CarRentingPricePerDay"].Value.ToString())
                    };

                    carObject = carInfo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error when load car info");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f = new frmLogin();
            f.ShowDialog();
            this.Close();
        }
    }
}
