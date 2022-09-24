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
    public partial class SalesAccount : Form
    {
        private DataAccess Da { get; set; }
        private Pharmacist P3 { get; set; }
        public SalesAccount()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.populateGridView();
            
        }
        public SalesAccount(Pharmacist p3):this()
        {
            this.P3 = p3;
        }

        private void populateGridView(string sql = "select p_id, salesdate, med_name, a_on, saleqtn, cost from paymentInformation ;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvpayment.AutoGenerateColumns = false;
            this.dgvpayment.DataSource = ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = @"update paymentInformation set salesdate='" + dtpdate.Text + "',med_name='" + txtm_name.Text + @"',
                                a_on='" + cmba_on.Text + "', saleqtn='" + txtqtn.Text + @"',
                                cost='" + txtprice.Text + "' where p_id='" + txtpid.Text + "' ";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Updated Successfully");
                else
                    MessageBox.Show("Upgradation Failed");

                this.populateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dgvpayment_DoubleClick(object sender, EventArgs e)
        {
            this.txtpid.Text = this.dgvpayment.CurrentRow.Cells["p_id"].Value.ToString();
            this.dtpdate.Text = this.dgvpayment.CurrentRow.Cells["salesdate"].Value.ToString();
            this.txtm_name.Text = this.dgvpayment.CurrentRow.Cells["med_name"].Value.ToString();
            this.cmba_on.Text = this.dgvpayment.CurrentRow.Cells["a_on"].Value.ToString();
            this.txtqtn.Text = this.dgvpayment.CurrentRow.Cells["saleqtn"].Value.ToString();
            this.txtprice.Text = this.dgvpayment.CurrentRow.Cells["cost"].Value.ToString();
           
        }

     

        private void btnsrch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from paymentInformation where p_id= '" + this.txtsrch.Text + "';";
                this.populateGridView(sql);
                this.RefreshContent();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnshow(object sender, EventArgs e)
        {
            this.populateGridView();
        }

        
        private void RefreshContent()
        {
            this.txtpid.Clear();
            this.dtpdate.Text = "";
            this.txtm_name.Clear();
            this.txtqtn.Clear();
            this.txtprice.Clear();
            this.cmba_on.SelectedIndex = -1;
            this.txtsrch.Clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.P3.Show();
        }
    }
}
