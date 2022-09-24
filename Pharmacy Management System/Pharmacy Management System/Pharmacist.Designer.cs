
namespace Pharmacy_Management_System
{
    partial class Pharmacist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPaymentstatus = new System.Windows.Forms.Button();
            this.btnSalesAccount = new System.Windows.Forms.Button();
            this.btnMedicineInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 646);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.btnPaymentstatus);
            this.panel3.Controls.Add(this.btnSalesAccount);
            this.panel3.Controls.Add(this.btnMedicineInfo);
            this.panel3.Location = new System.Drawing.Point(3, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 587);
            this.panel3.TabIndex = 12;
            // 
            // btnPaymentstatus
            // 
            this.btnPaymentstatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPaymentstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentstatus.Location = new System.Drawing.Point(41, 334);
            this.btnPaymentstatus.Name = "btnPaymentstatus";
            this.btnPaymentstatus.Size = new System.Drawing.Size(256, 44);
            this.btnPaymentstatus.TabIndex = 9;
            this.btnPaymentstatus.Text = "Payment status";
            this.btnPaymentstatus.UseVisualStyleBackColor = false;
            this.btnPaymentstatus.Click += new System.EventHandler(this.btnPaymentstatus_Click_1);
            // 
            // btnSalesAccount
            // 
            this.btnSalesAccount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalesAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesAccount.Location = new System.Drawing.Point(41, 245);
            this.btnSalesAccount.Name = "btnSalesAccount";
            this.btnSalesAccount.Size = new System.Drawing.Size(256, 44);
            this.btnSalesAccount.TabIndex = 9;
            this.btnSalesAccount.Text = "Sales Account";
            this.btnSalesAccount.UseVisualStyleBackColor = false;
            this.btnSalesAccount.Click += new System.EventHandler(this.btnSalesAccount_Click_1);
            // 
            // btnMedicineInfo
            // 
            this.btnMedicineInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMedicineInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineInfo.Location = new System.Drawing.Point(41, 160);
            this.btnMedicineInfo.Name = "btnMedicineInfo";
            this.btnMedicineInfo.Size = new System.Drawing.Size(256, 44);
            this.btnMedicineInfo.TabIndex = 0;
            this.btnMedicineInfo.Text = "Medicine Status";
            this.btnMedicineInfo.UseVisualStyleBackColor = false;
            this.btnMedicineInfo.Click += new System.EventHandler(this.btnMedicineInfo_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pharmacy_Management_System.Properties.Resources.cartoon_pharmacist_pack_medicine_illustration_40314695;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(342, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 590);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 53);
            this.panel2.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Location = new System.Drawing.Point(865, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 34);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacist Panel";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(397, 15);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 25);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Welcome ";
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 670);
            this.Controls.Add(this.panel1);
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pharmacist_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPaymentstatus;
        private System.Windows.Forms.Button btnSalesAccount;
        private System.Windows.Forms.Button btnMedicineInfo;
    }
}