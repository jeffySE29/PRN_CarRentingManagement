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
    public partial class frmRentingManagement : Form
    {
        IRentingTransactionRepository repo = new RentingTransactionRepository();
        public frmRentingManagement()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value;
            DateTime to = dtpTo.Value;
            var data = repo.GetRentingDetailsFromTo(from, to);
            BindingSource source = new BindingSource();
            source.DataSource = data;

            dgvRentingDetails.DataSource = null;
            dgvRentingDetails.DataSource = source;




            List<int> ids = data.Select(d => d.RentingTransactionId).ToList();
            List<RentingTransaction> tmp = new List<RentingTransaction>();
            foreach (int id in ids)
            {
                var item = repo.GetRentingTransactionById(id);
                tmp.Add(item);
            }
            tmp = tmp.OrderByDescending(item => item.TotalPrice).ToList();
            dgvRentingTransaction.DataSource = null;
            dgvRentingTransaction.DataSource = tmp;



            decimal? income = 0;
            foreach (var item in tmp)
            {
                income += item.TotalPrice;
            }
            txtIncome.Text = income.ToString();
        }

        private void frmRentingManagement_Load(object sender, EventArgs e)
        {
            txtIncome.Clear();
            LoadRentingDetails();
            LoadRentingTransactions();
        }

        public void LoadRentingDetails()
        {
            try
            {
                var rentDetails = repo.GetRentingDetailsList();
                BindingSource source = new BindingSource();
                source.DataSource = rentDetails;

                dgvRentingDetails.DataSource = null;
                dgvRentingDetails.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of renting details");
            }
        }

        public void LoadRentingTransactions()
        {
            try
            {
                var rentTrans = repo.GetRentingTransactionsList();
                BindingSource source = new BindingSource();
                source.DataSource = rentTrans;

                dgvRentingTransaction.DataSource = null;
                dgvRentingTransaction.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of renting transaction");
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f = new frmMenu();
            f.ShowDialog();
            this.Close();
        }

        private void dgvRentingDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRentingDetails.Columns["Car"].Visible = false;
            dgvRentingDetails.Columns["RentingTransaction"].Visible = false;

        }

        private void dgvRentingTransaction_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRentingTransaction.Columns["Customer"].Visible = false;
            dgvRentingTransaction.Columns["RentingDetails"].Visible = false;
        }
    }
}
