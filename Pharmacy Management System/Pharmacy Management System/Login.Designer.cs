
namespace Pharmacy_Management_System
{
    partial class Login
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(50, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 602);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 607);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnRegistration);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnclear);
            this.panel3.Controls.Add(this.txtUserId);
            this.panel3.Controls.Add(this.btnlogin);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(267, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 333);
            this.panel3.TabIndex = 27;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Snow;
            this.btnRegistration.Location = new System.Drawing.Point(92, 275);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(181, 43);
            this.btnRegistration.TabIndex = 27;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "User Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Snow;
            this.btnclear.Location = new System.Drawing.Point(198, 215);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 43);
            this.btnclear.TabIndex = 26;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(184, 84);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 22);
            this.txtUserId.TabIndex = 20;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Ivory;
            this.btnlogin.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnlogin.Location = new System.Drawing.Point(92, 215);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 43);
            this.btnlogin.TabIndex = 24;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(184, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Pharmacy_Management_System.Properties.Resources.images;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 249);
            this.panel4.TabIndex = 27;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnReg.Location = new System.Drawing.Point(934, 773);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(118, 34);
            this.btnReg.TabIndex = 13;
            this.btnReg.Text = "Register Now";
            this.btnReg.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 668);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegistration;
    }
}