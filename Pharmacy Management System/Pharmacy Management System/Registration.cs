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
    public partial class Registration : Form
    {
        private DataAccess Da { get; set; }
        private Login L1 { get; set; }
        public Registration()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        public Registration(Login l1) : this()
        {
            this.L1 = l1;
        }
        private void PopulateGridView(string sql = "select * from UserInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            // this.dgvMovie.AutoGenerateColumns = false;
            //this.dgvMovie.DataSource = ds.Tables[0];
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }
                var sql = @"insert into UserInfo values('" + txtid.Text + "','" + txtname.Text + "','" + txtpassword.Text + "','" + txtrole.Text + "')";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data insertion successfull");
                else
                    MessageBox.Show("Data insertion failed");


                this.PopulateGridView();
                this.Hide();
                MessageBox.Show("Registartion Complete !");
                this.L1.Show();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured" + exc.Message);
            }

        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtid.Text) || String.IsNullOrEmpty(this.txtname.Text) ||
                String.IsNullOrEmpty(this.txtpassword.Text) || String.IsNullOrEmpty(this.txtrole.Text) ||
                String.IsNullOrWhiteSpace(this.txtid.Text))
            {
                return false;
            }
            else
                return true;
        }

    }
}
