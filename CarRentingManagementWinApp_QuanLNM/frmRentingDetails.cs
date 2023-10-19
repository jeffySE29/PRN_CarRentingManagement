using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRentingManagementWinApp_QuanLNM
{
    public partial class frmRentingDetails : Form
    {
        ICarInformationRepository car = new CarInformationRepository();
        IRentingTransactionRepository transaction = new RentingTransactionRepository();
        public frmRentingDetails()
        {
            InitializeComponent();

        }

        public CarInformation CarInfo { get; set; }
        public ICarInformationRepository CarRentingInfo { get; set; }

        public int customerID { get; set; }

        private void frmRentingDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtCarName.Enabled = false;
            rtbCarDescription.Enabled = false;
            txtNumOfDoors.Enabled = false;
            txtSeatingCapacity.Enabled = false;
            txtFuelType.Enabled = false;
            txtYear.Enabled = false;
            txtManuID.Enabled = false;
            txtSupID.Enabled = false;
            txtCarStatus.Enabled = false;
            txtRentingPricePerDay.Enabled = false;
            txtCusID.Enabled = false;

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
            txtCusID.Text = customerID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpStartDate.Value > dtpEndDate.Value)
                {
                    MessageBox.Show("Start date can't greater than end date!");
                }
                else
                {
                    TimeSpan timeDifference = dtpEndDate.Value - dtpStartDate.Value;
                    decimal numberOfDays = timeDifference.Days + 1;

                    int newTransactionID = transaction.GetRentingTransactionsMaxId() + 1;
                    var rentingTransaction = new RentingTransaction
                    {
                        RentingTransationId = newTransactionID,
                        RentingDate = DateTime.Now,
                        TotalPrice = decimal.Parse(txtRentingPricePerDay.Text) * numberOfDays,
                        CustomerId = int.Parse(txtCusID.Text),
                        RentingStatus = 1,
                    };
                    transaction.CreateRentingTransaction(rentingTransaction);

                    var rentingDetail = new RentingDetail
                    {
                        RentingTransactionId = newTransactionID,
                        CarId = int.Parse(txtID.Text),
                        StartDate = dtpStartDate.Value,
                        EndDate = dtpEndDate.Value,
                        Price = decimal.Parse(txtRentingPricePerDay.Text),
                    };
                    transaction.CreateRentingDetail(rentingDetail);
                    this.Hide();
                    frmRentingTransaction f = new frmRentingTransaction(customerID);
                    f.ShowDialog();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

    }
}
