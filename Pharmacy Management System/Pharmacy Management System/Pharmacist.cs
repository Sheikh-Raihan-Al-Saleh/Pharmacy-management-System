using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{

    public partial class Pharmacist : Form
    {
        private Login L { get; set; }

        public Pharmacist()
        {
            InitializeComponent();
        }
        public Pharmacist(Login l1, string info):this()
        {

            this.L = l1;
            this.lblInfo.Text += info;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logout Complete");
            this.L.Show();
        }

        private void Pharmacist_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closing App");
            Application.Exit();
        }

        private void btnMedicineInfo_Click_1(object sender, EventArgs e)
        {
            Medicinestatus medicinestatus = new Medicinestatus(this);
            medicinestatus.Show();
            this.Hide();
        }

        private void btnSalesAccount_Click_1(object sender, EventArgs e)
        {
            SalesAccount salesAccount = new SalesAccount(this);
            salesAccount.Show();
            this.Hide();
        }
        private void btnPaymentstatus_Click_1(object sender, EventArgs e)
        {
            Payment payment = new Payment(this);
            payment.Show();
            this.Hide();
        }
    }
}
