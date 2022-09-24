using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class PaymentStatus : Form
    {
        private DataAccess Da { get; set; }
        private Admin A2 { get; set; }
        public PaymentStatus()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.GridView();

        }
        public PaymentStatus(Admin a2):this()
        {
            this.A2 = a2;
        }
        private void GridView(string sql = "select * from paymentInformation")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvpayment.AutoGenerateColumns = false;
            this.dgvpayment.DataSource = ds.Tables[0];
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from paymentInformation where p_id= '" + this.txtsrch.Text + "';";
                this.GridView(sql);
                this.RefreshContent();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }

        private void RefreshContent()
        {
            this.txtsrch.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.GridView();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.A2.Show();
        }
    }
}
