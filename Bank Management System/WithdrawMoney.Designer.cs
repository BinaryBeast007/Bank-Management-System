namespace Bank_Management_System
{
    partial class WithdrawMoney
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnConfirmWithdrawMoney = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWMName = new System.Windows.Forms.Label();
            this.lblWMAccNo = new System.Windows.Forms.Label();
            this.lblWMBalance = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(94)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.lblWMBalance);
            this.panel1.Controls.Add(this.lblWMAccNo);
            this.panel1.Controls.Add(this.lblWMName);
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Controls.Add(this.btnConfirmWithdrawMoney);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 720);
            this.panel1.TabIndex = 1;
            // 
            // btnGoBack
            // 
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Image = global::Bank_Management_System.Properties.Resources.go_back_button;
            this.btnGoBack.Location = new System.Drawing.Point(0, 0);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(36, 34);
            this.btnGoBack.TabIndex = 10;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnConfirmWithdrawMoney
            // 
            this.btnConfirmWithdrawMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmWithdrawMoney.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.btnConfirmWithdrawMoney.Location = new System.Drawing.Point(169, 574);
            this.btnConfirmWithdrawMoney.Name = "btnConfirmWithdrawMoney";
            this.btnConfirmWithdrawMoney.Size = new System.Drawing.Size(260, 48);
            this.btnConfirmWithdrawMoney.TabIndex = 9;
            this.btnConfirmWithdrawMoney.Text = "Confirm";
            this.btnConfirmWithdrawMoney.UseVisualStyleBackColor = true;
            this.btnConfirmWithdrawMoney.Click += new System.EventHandler(this.btnConfirmWithdrawMoney_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.txtAmount.Location = new System.Drawing.Point(277, 498);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(284, 31);
            this.txtAmount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(53, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Withdrawal Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(165, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(165, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Account No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(165, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bank_Management_System.Properties.Resources.account;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(227, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 141);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(245, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Withdraw Money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ABC Bank";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BackgroundImage = global::Bank_Management_System.Properties.Resources.Add_Money_3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(640, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 720);
            this.panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = global::Bank_Management_System.Properties.Resources.close_button_1;
            this.btnClose.Location = new System.Drawing.Point(605, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWMName
            // 
            this.lblWMName.AutoSize = true;
            this.lblWMName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblWMName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWMName.Location = new System.Drawing.Point(330, 330);
            this.lblWMName.Name = "lblWMName";
            this.lblWMName.Size = new System.Drawing.Size(99, 23);
            this.lblWMName.TabIndex = 12;
            this.lblWMName.Text = "No Name";
            // 
            // lblWMAccNo
            // 
            this.lblWMAccNo.AutoSize = true;
            this.lblWMAccNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblWMAccNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWMAccNo.Location = new System.Drawing.Point(330, 380);
            this.lblWMAccNo.Name = "lblWMAccNo";
            this.lblWMAccNo.Size = new System.Drawing.Size(58, 23);
            this.lblWMAccNo.TabIndex = 14;
            this.lblWMAccNo.Text = "0000";
            // 
            // lblWMBalance
            // 
            this.lblWMBalance.AutoSize = true;
            this.lblWMBalance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblWMBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWMBalance.Location = new System.Drawing.Point(330, 430);
            this.lblWMBalance.Name = "lblWMBalance";
            this.lblWMBalance.Size = new System.Drawing.Size(58, 23);
            this.lblWMBalance.TabIndex = 15;
            this.lblWMBalance.Text = "0000";
            // 
            // WithdrawMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WithdrawMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawMoney";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirmWithdrawMoney;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGoBack;
        public System.Windows.Forms.Label lblWMName;
        public System.Windows.Forms.Label lblWMAccNo;
        public System.Windows.Forms.Label lblWMBalance;
    }
}