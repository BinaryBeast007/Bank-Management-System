namespace Bank_Management_System
{
    partial class RemoveAccount
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
            this.btnConfirmRemove = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.lblAccOrId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRemAccName = new System.Windows.Forms.Label();
            this.lblRemAccNo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(94)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.lblRemAccNo);
            this.panel1.Controls.Add(this.lblRemAccName);
            this.panel1.Controls.Add(this.btnConfirmRemove);
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Controls.Add(this.lblAccOrId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 720);
            this.panel1.TabIndex = 3;
            // 
            // btnConfirmRemove
            // 
            this.btnConfirmRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmRemove.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.btnConfirmRemove.Location = new System.Drawing.Point(160, 533);
            this.btnConfirmRemove.Name = "btnConfirmRemove";
            this.btnConfirmRemove.Size = new System.Drawing.Size(260, 48);
            this.btnConfirmRemove.TabIndex = 10;
            this.btnConfirmRemove.Text = "Confirm";
            this.btnConfirmRemove.UseVisualStyleBackColor = true;
            this.btnConfirmRemove.Click += new System.EventHandler(this.btnConfirmRemove_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Image = global::Bank_Management_System.Properties.Resources.go_back_button;
            this.btnGoBack.Location = new System.Drawing.Point(0, 0);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(36, 34);
            this.btnGoBack.TabIndex = 8;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // lblAccOrId
            // 
            this.lblAccOrId.AutoSize = true;
            this.lblAccOrId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblAccOrId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccOrId.Location = new System.Drawing.Point(165, 380);
            this.lblAccOrId.Name = "lblAccOrId";
            this.lblAccOrId.Size = new System.Drawing.Size(129, 23);
            this.lblAccOrId.TabIndex = 5;
            this.lblAccOrId.Text = "Account No.";
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
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remove Account";
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
            this.panel2.TabIndex = 4;
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
            // lblRemAccName
            // 
            this.lblRemAccName.AutoSize = true;
            this.lblRemAccName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblRemAccName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRemAccName.Location = new System.Drawing.Point(315, 330);
            this.lblRemAccName.Name = "lblRemAccName";
            this.lblRemAccName.Size = new System.Drawing.Size(99, 23);
            this.lblRemAccName.TabIndex = 11;
            this.lblRemAccName.Text = "No Name";
            // 
            // lblRemAccNo
            // 
            this.lblRemAccNo.AutoSize = true;
            this.lblRemAccNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblRemAccNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRemAccNo.Location = new System.Drawing.Point(315, 380);
            this.lblRemAccNo.Name = "lblRemAccNo";
            this.lblRemAccNo.Size = new System.Drawing.Size(58, 23);
            this.lblRemAccNo.TabIndex = 12;
            this.lblRemAccNo.Text = "0000";
            // 
            // RemoveAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirmRemove;
        public System.Windows.Forms.Label lblRemAccNo;
        public System.Windows.Forms.Label lblRemAccName;
        public System.Windows.Forms.Label lblAccOrId;
    }
}