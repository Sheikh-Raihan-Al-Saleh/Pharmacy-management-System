
namespace Pharmacy_Management_System
{
    partial class medicineinfo
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtpmfg = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtm_id = new System.Windows.Forms.TextBox();
            this.cmba_on = new System.Windows.Forms.ComboBox();
            this.dtpexp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqtn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtm_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.m_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affect_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dtpmfg);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtm_id);
            this.panel1.Controls.Add(this.cmba_on);
            this.panel1.Controls.Add(this.dtpexp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtqtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtm_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgvMedicine);
            this.panel1.Location = new System.Drawing.Point(21, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 653);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Search by Medicine Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(27, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 47);
            this.panel2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine Information";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(185, 322);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 324);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // dtpmfg
            // 
            this.dtpmfg.CustomFormat = "yyyy-MM-dd";
            this.dtpmfg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmfg.Location = new System.Drawing.Point(341, 195);
            this.dtpmfg.Margin = new System.Windows.Forms.Padding(4);
            this.dtpmfg.Name = "dtpmfg";
            this.dtpmfg.Size = new System.Drawing.Size(160, 22);
            this.dtpmfg.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(222, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "mfg Date";
            // 
            // txtm_id
            // 
            this.txtm_id.Location = new System.Drawing.Point(341, 98);
            this.txtm_id.Margin = new System.Windows.Forms.Padding(4);
            this.txtm_id.Name = "txtm_id";
            this.txtm_id.Size = new System.Drawing.Size(160, 22);
            this.txtm_id.TabIndex = 42;
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
            this.cmba_on.Location = new System.Drawing.Point(341, 163);
            this.cmba_on.Margin = new System.Windows.Forms.Padding(4);
            this.cmba_on.Name = "cmba_on";
            this.cmba_on.Size = new System.Drawing.Size(160, 24);
            this.cmba_on.TabIndex = 37;
            // 
            // dtpexp
            // 
            this.dtpexp.CustomFormat = "yyyy-MM-dd";
            this.dtpexp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpexp.Location = new System.Drawing.Point(662, 96);
            this.dtpexp.Margin = new System.Windows.Forms.Padding(4);
            this.dtpexp.Name = "dtpexp";
            this.dtpexp.Size = new System.Drawing.Size(160, 22);
            this.dtpexp.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "AffectOn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Exp Date";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(662, 156);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(160, 22);
            this.txtprice.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Price";
            // 
            // txtqtn
            // 
            this.txtqtn.Location = new System.Drawing.Point(662, 126);
            this.txtqtn.Margin = new System.Windows.Forms.Padding(4);
            this.txtqtn.Name = "txtqtn";
            this.txtqtn.Size = new System.Drawing.Size(160, 22);
            this.txtqtn.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Quantity";
            // 
            // txtm_name
            // 
            this.txtm_name.Location = new System.Drawing.Point(341, 130);
            this.txtm_name.Margin = new System.Windows.Forms.Padding(4);
            this.txtm_name.Name = "txtm_name";
            this.txtm_name.Size = new System.Drawing.Size(160, 22);
            this.txtm_name.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Medicine Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Medicine ID";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(823, 322);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 28);
            this.btnShow.TabIndex = 28;
            this.btnShow.Text = "Show Info";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(570, 265);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 39);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(460, 265);
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
            this.btnSave.BackColor = System.Drawing.Color.Snow;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(352, 265);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 41);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Insert Information";
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_id,
            this.m_name,
            this.affect_on,
            this.mfg,
            this.exp,
            this.quantity,
            this.price});
            this.dgvMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMedicine.Location = new System.Drawing.Point(0, 358);
            this.dgvMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.RowHeadersWidth = 51;
            this.dgvMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicine.Size = new System.Drawing.Size(968, 295);
            this.dgvMedicine.TabIndex = 1;
            this.dgvMedicine.DoubleClick += new System.EventHandler(this.dgvMedicine_DoubleClick_1);
            // 
            // m_id
            // 
            this.m_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_id.DataPropertyName = "m_id";
            this.m_id.HeaderText = "Medicine ID";
            this.m_id.MinimumWidth = 6;
            this.m_id.Name = "m_id";
            this.m_id.ReadOnly = true;
            this.m_id.ToolTipText = "Id of Medicine";
            // 
            // m_name
            // 
            this.m_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.m_name.DataPropertyName = "m_name";
            this.m_name.HeaderText = "Medicine Name";
            this.m_name.MinimumWidth = 6;
            this.m_name.Name = "m_name";
            this.m_name.ReadOnly = true;
            this.m_name.ToolTipText = "Name of Medicines";
            // 
            // affect_on
            // 
            this.affect_on.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.affect_on.DataPropertyName = "affect_on";
            this.affect_on.HeaderText = "Affect on";
            this.affect_on.MinimumWidth = 6;
            this.affect_on.Name = "affect_on";
            this.affect_on.ReadOnly = true;
            this.affect_on.ToolTipText = "Affect On Medicine";
            // 
            // mfg
            // 
            this.mfg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mfg.DataPropertyName = "mfg";
            this.mfg.HeaderText = "mfg Date";
            this.mfg.MinimumWidth = 6;
            this.mfg.Name = "mfg";
            this.mfg.ReadOnly = true;
            this.mfg.ToolTipText = "Date of mfg";
            // 
            // exp
            // 
            this.exp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exp.DataPropertyName = "exp";
            this.exp.HeaderText = "Expire Date";
            this.exp.MinimumWidth = 6;
            this.exp.Name = "exp";
            this.exp.ReadOnly = true;
            this.exp.ToolTipText = "Expire date of Medicines";
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.ToolTipText = "Quanity of medicines";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.ToolTipText = "Cost of Medicine";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Snow;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(807, 9);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 29);
            this.btnHome.TabIndex = 73;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // medicineinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 670);
            this.Controls.Add(this.panel1);
            this.Name = "medicineinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn affect_on;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfg;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpmfg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtm_id;
        private System.Windows.Forms.ComboBox cmba_on;
        private System.Windows.Forms.DateTimePicker dtpexp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtm_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnHome;
    }
}