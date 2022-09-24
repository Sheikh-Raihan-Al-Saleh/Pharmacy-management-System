
namespace Pharmacy_Management_System
{
    partial class PharmacistInfo
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsrch = new System.Windows.Forms.Button();
            this.txtsrch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 632);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.dgvInfo);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(7, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 565);
            this.panel2.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pharmacy_Management_System.Properties.Resources.pro1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 556);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.password,
            this.role});
            this.dgvInfo.Location = new System.Drawing.Point(453, 300);
            this.dgvInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowHeadersWidth = 51;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(518, 259);
            this.dgvInfo.TabIndex = 2;
            this.dgvInfo.DoubleClick += new System.EventHandler(this.dgvInfo_DoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "ID of Pharmacist";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "Pharmacist Name";
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.ToolTipText = "password";
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.ToolTipText = "Role";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnsrch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtsrch);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.txtrole);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.txtpass);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnShow);
            this.panel4.Controls.Add(this.txtid);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtname);
            this.panel4.Location = new System.Drawing.Point(453, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 296);
            this.panel4.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Snow;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(102, 168);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 41);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(235, 118);
            this.txtrole.Margin = new System.Windows.Forms.Padding(4);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(160, 22);
            this.txtrole.TabIndex = 54;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(324, 168);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 41);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(235, 83);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(160, 22);
            this.txtpass.TabIndex = 53;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(210, 168);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 41);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Role";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(375, 264);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 28);
            this.btnShow.TabIndex = 29;
            this.btnShow.Text = "Show Info";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(235, 17);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 22);
            this.txtid.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(235, 49);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(160, 22);
            this.txtname.TabIndex = 46;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FloralWhite;
            this.panel3.Controls.Add(this.btnhome);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 55);
            this.panel3.TabIndex = 55;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Snow;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(844, 5);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(100, 38);
            this.btnhome.TabIndex = 76;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 32;
            this.label1.Text = "Pharmacist Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Search by Pharmacist Name";
            // 
            // btnsrch
            // 
            this.btnsrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrch.Location = new System.Drawing.Point(196, 261);
            this.btnsrch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(100, 28);
            this.btnsrch.TabIndex = 66;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = false;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // txtsrch
            // 
            this.txtsrch.Location = new System.Drawing.Point(7, 268);
            this.txtsrch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsrch.Name = "txtsrch";
            this.txtsrch.Size = new System.Drawing.Size(178, 22);
            this.txtsrch.TabIndex = 65;
            // 
            // PharmacistInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 715);
            this.Controls.Add(this.panel1);
            this.Name = "PharmacistInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacistInfo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsrch;
        private System.Windows.Forms.TextBox txtsrch;
    }
}