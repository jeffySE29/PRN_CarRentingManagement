using Microsoft.Extensions.Configuration;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentingManagementWinApp_QuanLNM
{
    public partial class frmLogin : Form
    {
        ICustomerRepository _customerRepository = new CustomerRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                IConfiguration config = new ConfigurationBuilder()
                                     .SetBasePath(Directory.GetCurrentDirectory())
                                     .AddJsonFile("appsettings.json", true, true)
                                     .Build();

                string email = config["AdminAccount:Email"];
                string password = config["AdminAccount:Password"];

                string inputPassword = txtPassword.Text;
                string inputEmail = txtEmail.Text;


                if (inputPassword == "" || inputEmail == "")
                {
                    MessageBox.Show("Missing field");
                }
                else
                {
                    if (email == inputEmail && password == inputPassword)
                    {
                        this.Hide();
                        frmMenu f = new frmMenu();
                        f.ShowDialog();
                        this.Close();
                    }

                    else if (_customerRepository.CheckLogin(inputEmail, inputPassword) != null)
                    {
                        this.Hide();
                        int cusId = _customerRepository.GetIdOfCustomerByEmail(inputEmail);
                        frmRentingTransaction frm = new frmRentingTransaction(cusId);
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You have no permission to do this function!");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerRegister f = new frmCustomerRegister();
            f.ShowDialog();
            this.Close();
        }
    }
}
