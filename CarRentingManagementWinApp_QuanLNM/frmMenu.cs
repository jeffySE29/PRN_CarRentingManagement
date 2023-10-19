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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCarManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCarManagement f = new frmCarManagement();
            f.ShowDialog();
            this.Close();
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerManagement f = new frmCustomerManagement();
            f.ShowDialog();
            this.Close();
        }

        private void btnRentingManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRentingManagement f = new frmRentingManagement();
            f.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
