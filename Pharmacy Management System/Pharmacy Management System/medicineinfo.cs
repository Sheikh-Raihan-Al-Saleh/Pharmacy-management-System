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
    public partial class medicineinfo : Form
    {
        private DataAccess Da { get; set; }
        private Admin A4{ get; set; }
        public medicineinfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        public medicineinfo(Admin a4):this()
        {
            this.A4 = a4;
        }
       

        private void PopulateGridView(string sql = "select * from MedicineInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvMedicine.AutoGenerateColumns = false;
            this.dgvMedicine.DataSource = ds.Tables[0];
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from MedicineInfo where m_name = '" + this.txtSearch.Text + "';";
                this.PopulateGridView(sql);
                //this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }
                var query = "select * from MedicineInfo where m_id='"+txtm_id.Text+"'";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update MedicineInfo set 
                                m_name='"+txtm_name.Text+"',affect_on='"+cmba_on.Text+@"',
                                mfg='"+dtpmfg.Text+"', exp='"+dtpexp.Text+@"', 
                                quantity='"+txtqtn.Text+"', price='"+txtprice.Text+ @"'
                                where m_id='"+txtm_id.Text+"'";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }

                else {
                    


                    var sql = @"insert into MedicineInfo values ('" + txtm_id.Text + "','" + txtm_name.Text + @"',
                              '" + cmba_on.Text + "','" + dtpmfg.Text + "','" + dtpexp.Text + @"',
                               '" + txtqtn.Text + "','" + txtprice.Text + "')";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion successfull");
                    else
                        MessageBox.Show("Data insertion failed");

                }
                this.PopulateGridView();
                this.RefreshContent();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtm_id.Text) || String.IsNullOrEmpty(this.txtm_name.Text) ||
                String.IsNullOrEmpty(this.cmba_on.Text) || String.IsNullOrEmpty(this.dtpmfg.Text) ||
                String.IsNullOrEmpty(this.dtpexp.Text) || String.IsNullOrEmpty(this.txtqtn.Text) || 
                String.IsNullOrEmpty(this.txtprice.Text) ||String.IsNullOrWhiteSpace(this.txtm_id.Text))
            {
                return false;
            }
            else
                return true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvMedicine.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvMedicine.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from MedicineInfo where m_id='"+ id +"'";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void dgvMedicine_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtm_id.Text = this.dgvMedicine.CurrentRow.Cells["m_id"].Value.ToString();
            this.txtm_name.Text = this.dgvMedicine.CurrentRow.Cells["m_name"].Value.ToString();
            this.cmba_on.Text = this.dgvMedicine.CurrentRow.Cells["affect_on"].Value.ToString();
            this.dtpmfg.Text = this.dgvMedicine.CurrentRow.Cells["mfg"].Value.ToString();
            this.dtpexp.Text = this.dgvMedicine.CurrentRow.Cells["exp"].Value.ToString();
            this.txtqtn.Text = this.dgvMedicine.CurrentRow.Cells["quantity"].Value.ToString();
            this.txtprice.Text = this.dgvMedicine.CurrentRow.Cells["price"].Value.ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }
        private void RefreshContent()
        {
            this.txtm_id.Clear();
            this.txtm_name.Clear();
            this.txtqtn.Clear();
            this.txtprice.Clear();
            this.dtpmfg.Text = "";
            this.dtpexp.Text = "";
            this.cmba_on.SelectedIndex = -1;

            this.txtSearch.Clear();
            //this.txtAutoSearch.Clear();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.A4.Show();
        }
    }

      
}

