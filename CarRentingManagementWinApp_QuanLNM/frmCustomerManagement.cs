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
    public partial class frmCustomerManagement : Form
    {
        ICustomerRepository repo = new CustomerRepository();
        public frmCustomerManagement()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu f = new frmMenu();
            f.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Customer Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                var cusInfo = new Customer
                {
                    CustomerId = int.Parse(txtID.Text),
                };
                repo.DeleteCustomer(cusInfo);
                LoadCustomerList();
            }
        }

        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
            EnableText(false);
        }

        public void LoadCustomerList()
        {
            try
            {
                var cusList = repo.GetCustomersList();
                BindingSource source = new BindingSource();
                source.DataSource = cusList;

                txtID.DataBindings.Clear();
                txtCusName.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                dtpCusBirthday.DataBindings.Clear();
                txtCusStatus.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "CustomerId");
                txtCusName.DataBindings.Add("Text", source, "CustomerName");
                txtPhone.DataBindings.Add("Text", source, "Telephone");
                txtEmail.DataBindings.Add("Text", source, "Email");
                dtpCusBirthday.DataBindings.Add("Value", source, "CustomerBirthday");
                txtCusStatus.DataBindings.Add("Text", source, "CustomerStatus");
                dgvCusList.DataSource = null;
                dgvCusList.DataSource = source;

                if (dgvCusList.Columns.Contains("Password"))
                {
                    dgvCusList.Columns["Password"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of customer");
            }
        }

        private void EnableText(bool status)
        {
            txtID.Enabled = status;
            txtCusName.Enabled = status;
            txtPhone.Enabled = status;
            txtEmail.Enabled = status;
            dtpCusBirthday.Enabled = status;
            txtCusStatus.Enabled = status;
        }

        private void dgvCusList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCusList.Columns["RentingTransactions"].Visible = false;
        }
    }
}
