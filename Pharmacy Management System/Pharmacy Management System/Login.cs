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
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from UserInfo where name = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";
                
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.ClearContent();
                    this.Hide();
                    
                    MessageBox.Show("Login Valid");
                    string name = ds.Tables[0].Rows[0][1].ToString();

                    if (ds.Tables[0].Rows[0][3].ToString() == "admin")
                    {
                        Admin admin = new Admin(this, name);
                        admin.Show();
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "pharmacist")
                    {
                        Pharmacist pharmacist= new Pharmacist(this, name);
                        pharmacist.Show();
                    }
                   

                }
                else
                {
                    MessageBox.Show("Login Invalid");
                    this.ClearContent();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured" + exc.Message);
            }
        }

       
       

        private void ClearContent()
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closing App");
            Application.Exit();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(this);
            registration.Show();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }
    }
}
