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
    public partial class Admin : Form
    {
        private Login L { get; set; }

        public Admin()
        {
            InitializeComponent();
        }
        public Admin(Login l1, string info):this()
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

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closing App");
            Application.Exit();
        }

        private void btnMedicineInfo_Click(object sender, EventArgs e)
        {
           
            medicineinfo medicineinfo = new medicineinfo(this);
            medicineinfo.Show();
            this.Hide();
        }

        private void btnPharmacistInfo_Click(object sender, EventArgs e)
        {
            PharmacistInfo pharmacistInfo = new PharmacistInfo(this);
            pharmacistInfo.Show();
            this.Hide();
        }

        private void btnPaymentstatus_Click(object sender, EventArgs e)
        {
            PaymentStatus paymentStatus = new PaymentStatus(this);
            paymentStatus.Show();
            this.Hide();
        }

        private void btnSalesStatus_Click(object sender, EventArgs e)
        {
            SalesStatus salesStatus = new SalesStatus(this);
            salesStatus.Show();
            this.Hide();
        }
    }
}
