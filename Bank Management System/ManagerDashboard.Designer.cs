namespace Bank_Management_System
{
    partial class ManagerDashboard
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
            this.pnlDashack = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentPageName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnRegisterAccount = new System.Windows.Forms.Button();
            this.btnSearchAccount = new System.Windows.Forms.Button();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPrivacyPolicy = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDashack.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashack
            // 
            this.pnlDashack.BackColor = System.Drawing.Color.Lavender;
            this.pnlDashack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDashack.Controls.Add(this.panel1);
            this.pnlDashack.Controls.Add(this.panel2);
            this.pnlDashack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashack.Location = new System.Drawing.Point(200, 0);
            this.pnlDashack.Name = "pnlDashack";
            this.pnlDashack.Size = new System.Drawing.Size(1080, 720);
            this.pnlDashack.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnClose1);
            this.panel2.Controls.Add(this.lblCurrentPageName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 100);
            this.panel2.TabIndex = 4;
            // 
            // lblCurrentPageName
            // 
            this.lblCurrentPageName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentPageName.AutoSize = true;
            this.lblCurrentPageName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblCurrentPageName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrentPageName.Location = new System.Drawing.Point(413, 46);
            this.lblCurrentPageName.Name = "lblCurrentPageName";
            this.lblCurrentPageName.Size = new System.Drawing.Size(225, 23);
            this.lblCurrentPageName.TabIndex = 14;
            this.lblCurrentPageName.Text = "• Honours Your Trust •";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(420, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "ABC Bank";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlSidebar.Controls.Add(this.btnAbout);
            this.pnlSidebar.Controls.Add(this.btnPrivacyPolicy);
            this.pnlSidebar.Controls.Add(this.btnLogOut);
            this.pnlSidebar.Controls.Add(this.panel4);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 720);
            this.pnlSidebar.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateBlue;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BackgroundImage = global::Bank_Management_System.Properties.Resources.dashboard_backgroud_1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.btnRemoveAccount);
            this.panel1.Controls.Add(this.btnUpdateAccount);
            this.panel1.Controls.Add(this.btnRegisterAccount);
            this.panel1.Controls.Add(this.btnSearchAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 620);
            this.panel1.TabIndex = 5;
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnRemoveAccount.Image = global::Bank_Management_System.Properties.Resources.remove_acc;
            this.btnRemoveAccount.Location = new System.Drawing.Point(695, 240);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(200, 75);
            this.btnRemoveAccount.TabIndex = 12;
            this.btnRemoveAccount.Text = "Remove Account";
            this.btnRemoveAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveAccount.UseVisualStyleBackColor = false;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnUpdateAccount.Image = global::Bank_Management_System.Properties.Resources.update_account;
            this.btnUpdateAccount.Location = new System.Drawing.Point(175, 240);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(200, 75);
            this.btnUpdateAccount.TabIndex = 4;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnRegisterAccount
            // 
            this.btnRegisterAccount.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegisterAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnRegisterAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegisterAccount.Image = global::Bank_Management_System.Properties.Resources.register;
            this.btnRegisterAccount.Location = new System.Drawing.Point(175, 100);
            this.btnRegisterAccount.Name = "btnRegisterAccount";
            this.btnRegisterAccount.Size = new System.Drawing.Size(200, 75);
            this.btnRegisterAccount.TabIndex = 3;
            this.btnRegisterAccount.Text = "Add Account";
            this.btnRegisterAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterAccount.UseVisualStyleBackColor = false;
            this.btnRegisterAccount.Click += new System.EventHandler(this.btnRegisterAccount_Click);
            // 
            // btnSearchAccount
            // 
            this.btnSearchAccount.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnSearchAccount.Image = global::Bank_Management_System.Properties.Resources.search_account;
            this.btnSearchAccount.Location = new System.Drawing.Point(695, 100);
            this.btnSearchAccount.Name = "btnSearchAccount";
            this.btnSearchAccount.Size = new System.Drawing.Size(200, 75);
            this.btnSearchAccount.TabIndex = 5;
            this.btnSearchAccount.Text = "Search Account";
            this.btnSearchAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchAccount.UseVisualStyleBackColor = false;
            this.btnSearchAccount.Click += new System.EventHandler(this.btnSearchAccount_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose1.Image = global::Bank_Management_System.Properties.Resources.close_button_1;
            this.btnClose1.Location = new System.Drawing.Point(1045, 0);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(35, 27);
            this.btnClose1.TabIndex = 15;
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = global::Bank_Management_System.Properties.Resources.close_button_1;
            this.btnClose.Location = new System.Drawing.Point(1245, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbout.Image = global::Bank_Management_System.Properties.Resources.about;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 150);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(200, 50);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnPrivacyPolicy
            // 
            this.btnPrivacyPolicy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrivacyPolicy.FlatAppearance.BorderSize = 0;
            this.btnPrivacyPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivacyPolicy.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnPrivacyPolicy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrivacyPolicy.Image = global::Bank_Management_System.Properties.Resources.privacy_policy;
            this.btnPrivacyPolicy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivacyPolicy.Location = new System.Drawing.Point(0, 100);
            this.btnPrivacyPolicy.Name = "btnPrivacyPolicy";
            this.btnPrivacyPolicy.Size = new System.Drawing.Size(200, 50);
            this.btnPrivacyPolicy.TabIndex = 12;
            this.btnPrivacyPolicy.Text = "Privacy Policy";
            this.btnPrivacyPolicy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrivacyPolicy.UseVisualStyleBackColor = true;
            this.btnPrivacyPolicy.Click += new System.EventHandler(this.btnPrivacyPolicy_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.btnLogOut.Image = global::Bank_Management_System.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(0, 675);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 45);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label2.Image = global::Bank_Management_System.Properties.Resources.menu;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "       Menu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlDashack);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerDashboard";
            this.pnlDashack.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnRegisterAccount;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnPrivacyPolicy;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchAccount;
        public System.Windows.Forms.Panel pnlDashack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentPageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnRemoveAccount;
    }
}