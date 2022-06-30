namespace Bank_Management_System
{
    partial class AddMoney
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
            this.btnConfirmAddMoney = new System.Windows.Forms.Button();
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
            this.lblAMName = new System.Windows.Forms.Label();
            this.lblAMBalance = new System.Windows.Forms.Label();
            this.lblAMAccNo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(94)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.lblAMAccNo);
            this.panel1.Controls.Add(this.lblAMBalance);
            this.panel1.Controls.Add(this.lblAMName);
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Controls.Add(this.btnConfirmAddMoney);
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
            this.panel1.TabIndex = 0;
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
            this.btnGoBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConfirmAddMoney
            // 
            this.btnConfirmAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmAddMoney.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.btnConfirmAddMoney.Location = new System.Drawing.Point(169, 574);
            this.btnConfirmAddMoney.Name = "btnConfirmAddMoney";
            this.btnConfirmAddMoney.Size = new System.Drawing.Size(260, 48);
            this.btnConfirmAddMoney.TabIndex = 9;
            this.btnConfirmAddMoney.Text = "Confirm";
            this.btnConfirmAddMoney.UseVisualStyleBackColor = true;
            this.btnConfirmAddMoney.Click += new System.EventHandler(this.btnConfirmAddMoney_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.txtAmount.Location = new System.Drawing.Point(201, 498);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(360, 31);
            this.txtAmount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(53, 501);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Add Amount";
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
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Money";
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
            this.panel2.TabIndex = 1;
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
            // lblAMName
            // 
            this.lblAMName.AutoSize = true;
            this.lblAMName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblAMName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAMName.Location = new System.Drawing.Point(349, 330);
            this.lblAMName.Name = "lblAMName";
            this.lblAMName.Size = new System.Drawing.Size(99, 23);
            this.lblAMName.TabIndex = 11;
            this.lblAMName.Text = "No Name";
            // 
            // lblAMBalance
            // 
            this.lblAMBalance.AutoSize = true;
            this.lblAMBalance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblAMBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAMBalance.Location = new System.Drawing.Point(349, 430);
            this.lblAMBalance.Name = "lblAMBalance";
            this.lblAMBalance.Size = new System.Drawing.Size(99, 23);
            this.lblAMBalance.TabIndex = 12;
            this.lblAMBalance.Text = "No Name";
            // 
            // lblAMAccNo
            // 
            this.lblAMAccNo.AutoSize = true;
            this.lblAMAccNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblAMAccNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAMAccNo.Location = new System.Drawing.Point(349, 380);
            this.lblAMAccNo.Name = "lblAMAccNo";
            this.lblAMAccNo.Size = new System.Drawing.Size(58, 23);
            this.lblAMAccNo.TabIndex = 13;
            this.lblAMAccNo.Text = "0000";
            // 
            // AddMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMoney";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmAddMoney;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGoBack;
        public System.Windows.Forms.Label lblAMAccNo;
        public System.Windows.Forms.Label lblAMBalance;
        public System.Windows.Forms.Label lblAMName;
    }
}