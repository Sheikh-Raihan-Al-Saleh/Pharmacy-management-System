
namespace Pharmacy_Management_System
{
    partial class PaymentStatus
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnsrch = new System.Windows.Forms.Button();
            this.txtsrch = new System.Windows.Forms.TextBox();
            this.dgvpayment = new System.Windows.Forms.DataGridView();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleqtn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paidby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pharmacy_Management_System.Properties.Resources.cashcounter;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 308);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnsrch);
            this.panel2.Controls.Add(this.txtsrch);
            this.panel2.Controls.Add(this.dgvpayment);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Location = new System.Drawing.Point(13, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 361);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Search by PaymentID";
            // 
            // btnsrch
            // 
            this.btnsrch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsrch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrch.Location = new System.Drawing.Point(187, 28);
            this.btnsrch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsrch.Name = "btnsrch";
            this.btnsrch.Size = new System.Drawing.Size(100, 29);
            this.btnsrch.TabIndex = 68;
            this.btnsrch.Text = "Search";
            this.btnsrch.UseVisualStyleBackColor = false;
            this.btnsrch.Click += new System.EventHandler(this.btnsrch_Click);
            // 
            // txtsrch
            // 
            this.txtsrch.Location = new System.Drawing.Point(19, 31);
            this.txtsrch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsrch.Name = "txtsrch";
            this.txtsrch.Size = new System.Drawing.Size(159, 22);
            this.txtsrch.TabIndex = 67;
            // 
            // dgvpayment
            // 
            this.dgvpayment.AllowUserToAddRows = false;
            this.dgvpayment.AllowUserToDeleteRows = false;
            this.dgvpayment.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgvpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_id,
            this.salesdate,
            this.c_name,
            this.mobile,
            this.address,
            this.med_name,
            this.a_on,
            this.saleqtn,
            this.cost,
            this.Paidby});
            this.dgvpayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvpayment.Location = new System.Drawing.Point(0, 66);
            this.dgvpayment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpayment.Name = "dgvpayment";
            this.dgvpayment.ReadOnly = true;
            this.dgvpayment.RowHeadersWidth = 51;
            this.dgvpayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpayment.Size = new System.Drawing.Size(1000, 295);
            this.dgvpayment.TabIndex = 66;
            // 
            // p_id
            // 
            this.p_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_id.DataPropertyName = "p_id";
            this.p_id.HeaderText = "PaymentId";
            this.p_id.MinimumWidth = 6;
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.ToolTipText = "Id of Payment list";
            // 
            // salesdate
            // 
            this.salesdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salesdate.DataPropertyName = "salesdate";
            this.salesdate.HeaderText = "Date";
            this.salesdate.MinimumWidth = 6;
            this.salesdate.Name = "salesdate";
            this.salesdate.ReadOnly = true;
            this.salesdate.ToolTipText = "Date of sales";
            // 
            // c_name
            // 
            this.c_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c_name.DataPropertyName = "c_name";
            this.c_name.HeaderText = "Customer name";
            this.c_name.MinimumWidth = 6;
            this.c_name.Name = "c_name";
            this.c_name.ReadOnly = true;
            this.c_name.ToolTipText = "Name list of customers";
            // 
            // mobile
            // 
            this.mobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "Mobile No.";
            this.mobile.MinimumWidth = 6;
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.ToolTipText = "Customer contact Info";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.ToolTipText = "Customers Address";
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
            this.saleqtn.ToolTipText = "Quantity of sales";
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Price";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.ToolTipText = "Price";
            // 
            // Paidby
            // 
            this.Paidby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Paidby.DataPropertyName = "Paidby";
            this.Paidby.HeaderText = "Payment stautus";
            this.Paidby.MinimumWidth = 6;
            this.Paidby.Name = "Paidby";
            this.Paidby.ReadOnly = true;
            this.Paidby.ToolTipText = "Payment status of customers";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(853, 31);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 29);
            this.btnShow.TabIndex = 65;
            this.btnShow.Text = "Show Info";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Snow;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(869, 4);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(94, 30);
            this.btnhome.TabIndex = 76;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // PaymentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Status";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsrch;
        private System.Windows.Forms.TextBox txtsrch;
        private System.Windows.Forms.DataGridView dgvpayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleqtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paidby;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnhome;
    }
}