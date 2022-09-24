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
    public partial class PharmacistInfo : Form
    {
        private DataAccess Da { get; set; }
        private Admin A3 { get; set; }
        public PharmacistInfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }
        public PharmacistInfo(Admin a3):this()
        {
            this.A3 = a3;
        }
        private void PopulateGridView(string sql = "select * from UserInfo where role='pharmacist' ;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvInfo.AutoGenerateColumns = false;
            this.dgvInfo.DataSource = ds.Tables[0];
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try

            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Field required");
                    return;
                }
                var sql = @"update UserInfo set name='"+txtname.Text+@"',
                            password='"+txtpass.Text+"',role='"+txtrole.Text+@"' 
                            where id='"+txtid.Text+"'";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                   MessageBox.Show("updated successfully");
                else
                   MessageBox.Show("upgradation failed");
               
                this.PopulateGridView();
            }

            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtid.Text) || String.IsNullOrEmpty(this.txtname.Text) ||
                 String.IsNullOrEmpty(this.txtpass.Text) || String.IsNullOrEmpty(this.txtrole.Text) 
                 || String.IsNullOrWhiteSpace(this.txtid.Text))
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
                var id = this.dgvInfo.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvInfo.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from UserInfo where id='" + id + "'";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " has been deleted successfully");
                else
                    MessageBox.Show("Infromation deletion failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void dgvInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtid.Text = this.dgvInfo.CurrentRow.Cells["id"].Value.ToString();
            this.txtname.Text = this.dgvInfo.CurrentRow.Cells["name"].Value.ToString();
            this.txtpass.Text = this.dgvInfo.CurrentRow.Cells["password"].Value.ToString();
            this.txtrole.Text = this.dgvInfo.CurrentRow.Cells["role"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }
        private void RefreshContent()
        {
            this.txtid.Clear();
            this.txtname.Clear();
            this.txtpass.Clear();
            this.txtrole.Clear();


            this.txtsrch.Clear();
            //this.txtAutoSearch.Clear();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.A3.Show();
        }

        private void btnsrch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from UserInfo where name = '" + this.txtsrch.Text + "';";
                this.PopulateGridView(sql);
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
