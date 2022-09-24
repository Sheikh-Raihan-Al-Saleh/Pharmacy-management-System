
namespace Pharmacy_Management_System
{
    partial class SalesAccount
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsrch = new System.Windows.Forms.Button();
            this.txtsrch = new System.Windows.Forms.TextBox();
            this.dgvpayment = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleqtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtm_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmba_on = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqtn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtpid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpdate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnsrch);
            this.panel1.Controls.Add(this.txtsrch);
            this.panel1.Controls.Add(this.dgvpayment);
            this.panel1.Controls.Add(this.txtm_name);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmba_on);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtqtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 646);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(851, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 28);
            this.button1.TabIndex = 73;
            this.button1.Text = "Show Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnshow);
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(476, 78);
            this.txtpid.Margin = new System.Windows.Forms.Padding(4);
            this.txtpid.Name = "txtpid";
            this.txtpid.Size = new System.Drawing.Size(160, 22);
            this.txtpid.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Payment Id";
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "yyyy-MM-dd";
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdate.Location = new System.Drawing.Point(476, 108);
            this.dtpdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(160, 22);
            this.dtpdate.TabIndex = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 108);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 69;
            this.label13.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Search by Payment Id";
            // 
            // btnsrch
            // 
            this.btnsrch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrch.Location = new System.Drawing.Point(175, 351);
            this.btnsrch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(100, 28);
            this.btnsrch.TabIndex = 63;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = false;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // txtsrch
            // 
            this.txtsrch.Location = new System.Drawing.Point(7, 353);
            this.txtsrch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsrch.Name = "txtsrch";
            this.txtsrch.Size = new System.Drawing.Size(159, 22);
            this.txtsrch.TabIndex = 62;
            // 
            // dgvpayment
            // 
            this.dgvpayment.AllowUserToAddRows = false;
            this.dgvpayment.AllowUserToDeleteRows = false;
            this.dgvpayment.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgvpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.salesdate,
            this.med_name,
            this.a_on,
            this.saleqtn,
            this.cost});
            this.dgvpayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvpayment.Location = new System.Drawing.Point(0, 387);
            this.dgvpayment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpayment.Name = "dgvpayment";
            this.dgvpayment.ReadOnly = true;
            this.dgvpayment.RowHeadersWidth = 51;
            this.dgvpayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpayment.Size = new System.Drawing.Size(996, 259);
            this.dgvpayment.TabIndex = 61;
            this.dgvpayment.DoubleClick += new System.EventHandler(this.dgvpayment_DoubleClick);
            // 
            // p_id
            // 
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "PaymentID";
            this.p_id.MinimumWidth = 6;
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.ToolTipText = "Payment Id";
            this.p_id.Width = 125;
            // 
            // salesdate
            // 
            this.salesdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salesdate.DataPropertyName = "salesdate";
            this.salesdate.HeaderText = "Date";
            this.salesdate.MinimumWidth = 6;
            this.salesdate.Name = "salesdate";
            this.salesdate.ReadOnly = true;
            this.salesdate.ToolTipText = "Selling Date";
            // 
            // med_name
            // 
            this.med_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.med_name.DataPropertyName = "med_name";
            this.med_name.HeaderText = "Medicine name";
            this.med_name.MinimumWidth = 6;
            this.med_name.Name = "med_name";
            this.med_name.ReadOnly = true;
            this.med_name.ToolTipText = "Name of Medicines";
            // 
            // a_on
            // 
            this.a_on.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.a_on.DataPropertyName = "a_on";
            this.a_on.HeaderText = "Affect On";
            this.a_on.MinimumWidth = 6;
            this.a_on.Name = "a_on";
            this.a_on.ReadOnly = true;
            this.a_on.ToolTipText = "Effect of Medicine";
            // 
            // saleqtn
            // 
            this.saleqtn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleqtn.DataPropertyName = "saleqtn";
            this.saleqtn.HeaderText = "Sales quantity";
            this.saleqtn.MinimumWidth = 6;
            this.saleqtn.Name = "saleqtn";
            this.saleqtn.ReadOnly = true;
            this.saleqtn.ToolTipText = "Quantity of sales medicine";
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Sale amount";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.ToolTipText = "Amount of sales medicine";
            // 
            // txtm_name
            // 
            this.txtm_name.Location = new System.Drawing.Point(476, 134);
            this.txtm_name.Margin = new System.Windows.Forms.Padding(4);
            this.txtm_name.Name = "txtm_name";
            this.txtm_name.Size = new System.Drawing.Size(160, 22);
            this.txtm_name.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.btnhome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 52);
            this.panel2.TabIndex = 45;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Snow;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(856, 5);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(100, 38);
            this.btnhome.TabIndex = 73;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Account";
            // 
            // cmba_on
            // 
            this.cmba_on.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmba_on.FormattingEnabled = true;
            this.cmba_on.Items.AddRange(new object[] {
            "Headache/Fever",
            "High blood pressure",
            "CKD",
            "Calcium",
            "Gastric ulcer",
            "Clean skin spot",
            "Diabetes",
            " "});
            this.cmba_on.Location = new System.Drawing.Point(476, 177);
            this.cmba_on.Margin = new System.Windows.Forms.Padding(4);
            this.cmba_on.Name = "cmba_on";
            this.cmba_on.Size = new System.Drawing.Size(160, 24);
            this.cmba_on.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "AffectOn";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(476, 243);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(160, 22);
            this.txtprice.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Price";
            // 
            // txtqtn
            // 
            this.txtqtn.Location = new System.Drawing.Point(476, 212);
            this.txtqtn.Margin = new System.Windows.Forms.Padding(4);
            this.txtqtn.Name = "txtqtn";
            this.txtqtn.Size = new System.Drawing.Size(160, 22);
            this.txtqtn.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Medicine Name";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(1026, 439);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 28);
            this.btnShow.TabIndex = 28;
            this.btnShow.Text = "Show Info";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(494, 290);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 41);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(385, 290);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 41);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SalesAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 670);
            this.Controls.Add(this.panel1);
            this.Name = "SalesAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsrch;
        private System.Windows.Forms.TextBox txtsrch;
        private System.Windows.Forms.DataGridView dgvpayment;
        private System.Windows.Forms.TextBox txtm_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmba_on;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleqtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnhome;
    }
}