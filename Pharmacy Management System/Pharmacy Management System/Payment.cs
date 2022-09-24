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
    public partial class Payment : Form
    {
        private DataAccess Da { get; set; }
        private  Pharmacist P1 { get; set; }
        public Payment()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.GridView();
        }
        public Payment(Pharmacist p1):this()
        {
            this.P1 = p1;
        }

        private void PopulateGridView(string sql = "select m_name,affect_on,quantity,price from MedicineInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvMedicine.AutoGenerateColumns = false;
            this.dgvMedicine.DataSource = ds.Tables[0];
        }
        private void GridView(string sql = "select * from paymentInformation")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvpayment.AutoGenerateColumns = false;
            this.dgvpayment.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from MedicineInfo where m_name= '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
                this.RefreshContent();
               
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from paymentInformation where c_name= '" + this.txtsrch.Text + "';";
                this.GridView(sql);
                this.RefreshContent();
              
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Please fill up all the Field");
                    return;
                }
                var query = "select * from paymentInformation where p_id='" + txtpid.Text + "'";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update paymentInformation set c_name='" + txtCname.Text+"', salesdate='"+dtpdate.Text+"', mobile='"+txtmobile.Text+@"',
                                address='"+txtaddress.Text+"',med_name='"+txtm_name.Text+@"',
                                a_on='"+cmba_on.Text+"', saleqtn='"+txtqtn.Text+@"',
                                cost='"+txtprice.Text+"',Paidby='"+cmbpayment.Text+"' where p_id='"+txtpid.Text+"' ";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Updated Successfully");
                    else
                        MessageBox.Show("Upgradation Failed");
                }
                else
                {
                    var sql = @"insert into paymentInformation values ('" + txtpid.Text + "','" + dtpdate.Text+ @"',
                              '" + txtCname.Text + @"','" + txtmobile.Text + "','" + txtaddress.Text + "','" + txtm_name.Text + @"',
                               '" + cmba_on.Text + "','" + txtqtn.Text + "', '" + txtprice.Text + "','" + cmbpayment.Text + "')";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Insertion Successfull");
                    else
                        MessageBox.Show("Insertion Failed");
                }
                this.GridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtpid.Text) || String.IsNullOrEmpty(this.dtpdate.Text) || String.IsNullOrEmpty(this.txtCname.Text) ||
                String.IsNullOrEmpty(this.cmba_on.Text) || String.IsNullOrEmpty(this.cmbpayment.Text) ||
                String.IsNullOrEmpty(this.txtmobile.Text) || String.IsNullOrEmpty(this.txtqtn.Text) ||
                String.IsNullOrEmpty(this.txtm_name.Text) || String.IsNullOrEmpty(this.txtaddress.Text) ||
                String.IsNullOrEmpty(this.txtprice.Text) || String.IsNullOrWhiteSpace(this.txtpid.Text))
            {
                return false;
            }
            else
                return true;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvpayment.CurrentRow.Cells[0].Value.ToString();
               // var name = this.dgvpayment.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from paymentInformation where p_id='" + id + "'";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(id + " has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.GridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dgvMedicine_DoubleClick(object sender, EventArgs e)
        {

           
            this.txtm_name.Text = this.dgvMedicine.CurrentRow.Cells["m_name"].Value.ToString();
            this.cmba_on.Text = this.dgvMedicine.CurrentRow.Cells["affect_on"].Value.ToString();
            this.txtprice.Text = this.dgvMedicine.CurrentRow.Cells["price"].Value.ToString();
        }

        private void dgvpayment_DoubleClick(object sender, EventArgs e)
        {
            this.txtpid.Text = this.dgvpayment.CurrentRow.Cells["p_id"].Value.ToString();
            this.dtpdate.Text = this.dgvpayment.CurrentRow.Cells["salesdate"].Value.ToString();
            this.txtCname.Text = this.dgvpayment.CurrentRow.Cells["c_name"].Value.ToString();
            this.txtmobile.Text = this.dgvpayment.CurrentRow.Cells["mobile"].Value.ToString();
            this.txtaddress.Text = this.dgvpayment.CurrentRow.Cells["address"].Value.ToString();
            this.txtm_name.Text = this.dgvpayment.CurrentRow.Cells["med_name"].Value.ToString();
            this.cmba_on.Text = this.dgvpayment.CurrentRow.Cells["a_on"].Value.ToString();
            this.txtqtn.Text = this.dgvpayment.CurrentRow.Cells["saleqtn"].Value.ToString();
            this.txtprice.Text = this.dgvpayment.CurrentRow.Cells["cost"].Value.ToString();
            this.cmbpayment.Text = this.dgvpayment.CurrentRow.Cells["Paidby"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }
        private void RefreshContent()
        {
            this.txtpid.Clear();
            this.dtpdate.Text = "";
            this.txtCname.Clear();
            this.txtmobile.Clear();
            this.txtaddress.Clear();
            this.txtm_name.Clear();
            this.txtqtn.Clear();
            this.txtprice.Clear();
            this.cmba_on.SelectedIndex = -1;
            this.cmbpayment.SelectedIndex = -1;
            this.txtSearch.Clear();
            this.txtsrch.Clear();
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.GridView();
        }

        private void btnshowInfo_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.P1.Show();
        }
    }
}
