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
    public partial class frmCustomerRegister : Form
    {
        ICustomerRepository repo = new CustomerRepository();
        public frmCustomerRegister()
        {
            InitializeComponent();
        }

        public ICustomerRepository CusInfor { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" ||
                txtPhone.Text.Trim() == "" || txtEmail.Text.Trim() == "" ||
                dtpBirthday.Text.Trim() == "" || txtStatus.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("All fields are required!", "Customer Register System",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var cusInfo = new Customer
                {
                    CustomerName = txtName.Text,
                    Telephone = txtPhone.Text,
                    Email = txtEmail.Text,
                    CustomerBirthday = DateTime.Parse(dtpBirthday.Text),
                    CustomerStatus = byte.Parse(txtStatus.Text),
                    Password = txtPassword.Text,
                };


                repo.CreateCustomer(cusInfo);
                this.Hide();
                int id = CusInfor.GetIdOfCustomerByEmail(cusInfo.Email);
                frmRentingTransaction f = new frmRentingTransaction(id);
                this.Close();
            }
        }

        private void frmCustomerRegister_Load(object sender, EventArgs e)
        {
            txtName.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            dtpBirthday.DataBindings.Clear();
            txtStatus.Enabled = false;
            txtPassword.DataBindings.Clear();
            txtStatus.Text = "1";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f = new frmLogin();
            f.ShowDialog();
            this.Close();
        }
    }
}
