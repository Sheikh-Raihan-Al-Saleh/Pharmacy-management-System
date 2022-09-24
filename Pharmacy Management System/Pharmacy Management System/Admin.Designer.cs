
namespace Pharmacy_Management_System
{
    partial class Admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPaymentstatus = new System.Windows.Forms.Button();
            this.btnSalesStatus = new System.Windows.Forms.Button();
            this.btnPharmacistInfo = new System.Windows.Forms.Button();
            this.btnMedicineInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 646);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pharmacy_Management_System.Properties.Resources.page;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(309, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 577);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPaymentstatus);
            this.panel3.Controls.Add(this.btnSalesStatus);
            this.panel3.Controls.Add(this.btnPharmacistInfo);
            this.panel3.Controls.Add(this.btnMedicineInfo);
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 577);
            this.panel3.TabIndex = 8;
            // 
            // btnPaymentstatus
            // 
            this.btnPaymentstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPaymentstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentstatus.Location = new System.Drawing.Point(16, 369);
            this.btnPaymentstatus.Name = "btnPaymentstatus";
            this.btnPaymentstatus.Size = new System.Drawing.Size(256, 44);
            this.btnPaymentstatus.TabIndex = 9;
            this.btnPaymentstatus.Text = "Payment status";
            this.btnPaymentstatus.UseVisualStyleBackColor = false;
            this.btnPaymentstatus.Click += new System.EventHandler(this.btnPaymentstatus_Click);
            // 
            // btnSalesStatus
            // 
            this.btnSalesStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalesStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesStatus.Location = new System.Drawing.Point(16, 292);
            this.btnSalesStatus.Name = "btnSalesStatus";
            this.btnSalesStatus.Size = new System.Drawing.Size(256, 44);
            this.btnSalesStatus.TabIndex = 9;
            this.btnSalesStatus.Text = "Sales Status";
            this.btnSalesStatus.UseVisualStyleBackColor = false;
            this.btnSalesStatus.Click += new System.EventHandler(this.btnSalesStatus_Click);
            // 
            // btnPharmacistInfo
            // 
            this.btnPharmacistInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPharmacistInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacistInfo.Location = new System.Drawing.Point(16, 215);
            this.btnPharmacistInfo.Name = "btnPharmacistInfo";
            this.btnPharmacistInfo.Size = new System.Drawing.Size(256, 44);
            this.btnPharmacistInfo.TabIndex = 9;
            this.btnPharmacistInfo.Text = "Pharmacist Info";
            this.btnPharmacistInfo.UseVisualStyleBackColor = false;
            this.btnPharmacistInfo.Click += new System.EventHandler(this.btnPharmacistInfo_Click);
            // 
            // btnMedicineInfo
            // 
            this.btnMedicineInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMedicineInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMedicineInfo.Location = new System.Drawing.Point(16, 133);
            this.btnMedicineInfo.Name = "btnMedicineInfo";
            this.btnMedicineInfo.Size = new System.Drawing.Size(256, 44);
            this.btnMedicineInfo.TabIndex = 0;
            this.btnMedicineInfo.Text = "Medicine Information";
            this.btnMedicineInfo.UseVisualStyleBackColor = false;
            this.btnMedicineInfo.Click += new System.EventHandler(this.btnMedicineInfo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 63);
            this.panel2.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(819, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 34);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(356, 13);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(100, 25);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Welcome ";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 670);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPaymentstatus;
        private System.Windows.Forms.Button btnSalesStatus;
        private System.Windows.Forms.Button btnPharmacistInfo;
        private System.Windows.Forms.Button btnMedicineInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}