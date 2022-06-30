namespace Bank_Management_System
{
    partial class SignIn
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
            this.pnlSignInRight = new System.Windows.Forms.Panel();
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.linkSignInToSignUp = new System.Windows.Forms.LinkLabel();
            this.lblSignInNoAcc = new System.Windows.Forms.Label();
            this.txtSignInPassword = new System.Windows.Forms.TextBox();
            this.lblSignInPassword = new System.Windows.Forms.Label();
            this.txtSignInEmail = new System.Windows.Forms.TextBox();
            this.lblSignInID = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblSignInTagLine = new System.Windows.Forms.Label();
            this.lblSignInBankName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSignInleft = new System.Windows.Forms.Panel();
            this.pnlSignInRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSignInRight
            // 
            this.pnlSignInRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(94)))), ((int)(((byte)(196)))));
            this.pnlSignInRight.Controls.Add(this.linkForgotPassword);
            this.pnlSignInRight.Controls.Add(this.btnSignIn);
            this.pnlSignInRight.Controls.Add(this.btnClose);
            this.pnlSignInRight.Controls.Add(this.linkSignInToSignUp);
            this.pnlSignInRight.Controls.Add(this.lblSignInNoAcc);
            this.pnlSignInRight.Controls.Add(this.txtSignInPassword);
            this.pnlSignInRight.Controls.Add(this.lblSignInPassword);
            this.pnlSignInRight.Controls.Add(this.txtSignInEmail);
            this.pnlSignInRight.Controls.Add(this.lblSignInID);
            this.pnlSignInRight.Controls.Add(this.lblSignIn);
            this.pnlSignInRight.Controls.Add(this.lblSignInTagLine);
            this.pnlSignInRight.Controls.Add(this.lblSignInBankName);
            this.pnlSignInRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSignInRight.Location = new System.Drawing.Point(640, 0);
            this.pnlSignInRight.Name = "pnlSignInRight";
            this.pnlSignInRight.Size = new System.Drawing.Size(640, 720);
            this.pnlSignInRight.TabIndex = 2;
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.linkForgotPassword.LinkColor = System.Drawing.Color.White;
            this.linkForgotPassword.Location = new System.Drawing.Point(254, 623);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(130, 16);
            this.linkForgotPassword.TabIndex = 11;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Forgot password?";
            this.linkForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPassword_LinkClicked);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.btnSignIn.Location = new System.Drawing.Point(175, 535);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(307, 47);
            this.btnSignIn.TabIndex = 10;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // linkSignInToSignUp
            // 
            this.linkSignInToSignUp.AutoSize = true;
            this.linkSignInToSignUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.linkSignInToSignUp.ForeColor = System.Drawing.SystemColors.Control;
            this.linkSignInToSignUp.LinkColor = System.Drawing.Color.Transparent;
            this.linkSignInToSignUp.Location = new System.Drawing.Point(372, 598);
            this.linkSignInToSignUp.Name = "linkSignInToSignUp";
            this.linkSignInToSignUp.Size = new System.Drawing.Size(65, 16);
            this.linkSignInToSignUp.TabIndex = 8;
            this.linkSignInToSignUp.TabStop = true;
            this.linkSignInToSignUp.Text = "Register";
            this.linkSignInToSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignInToSignUp_LinkClicked);
            // 
            // lblSignInNoAcc
            // 
            this.lblSignInNoAcc.AutoSize = true;
            this.lblSignInNoAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblSignInNoAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignInNoAcc.Location = new System.Drawing.Point(211, 598);
            this.lblSignInNoAcc.Name = "lblSignInNoAcc";
            this.lblSignInNoAcc.Size = new System.Drawing.Size(162, 16);
            this.lblSignInNoAcc.TabIndex = 7;
            this.lblSignInNoAcc.Text = "Don\'t have an account?";
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(94)))), ((int)(((byte)(196)))));
            this.txtSignInPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtSignInPassword.Location = new System.Drawing.Point(103, 489);
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.PasswordChar = '*';
            this.txtSignInPassword.Size = new System.Drawing.Size(459, 29);
            this.txtSignInPassword.TabIndex = 6;
            this.txtSignInPassword.UseSystemPasswordChar = true;
            // 
            // lblSignInPassword
            // 
            this.lblSignInPassword.AutoSize = true;
            this.lblSignInPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblSignInPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignInPassword.Location = new System.Drawing.Point(99, 463);
            this.lblSignInPassword.Name = "lblSignInPassword";
            this.lblSignInPassword.Size = new System.Drawing.Size(107, 23);
            this.lblSignInPassword.TabIndex = 5;
            this.lblSignInPassword.Text = "Password";
            // 
            // txtSignInEmail
            // 
            this.txtSignInEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(94)))), ((int)(((byte)(196)))));
            this.txtSignInEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtSignInEmail.Location = new System.Drawing.Point(103, 431);
            this.txtSignInEmail.Name = "txtSignInEmail";
            this.txtSignInEmail.Size = new System.Drawing.Size(459, 29);
            this.txtSignInEmail.TabIndex = 4;
            // 
            // lblSignInID
            // 
            this.lblSignInID.AutoSize = true;
            this.lblSignInID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblSignInID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignInID.Location = new System.Drawing.Point(99, 404);
            this.lblSignInID.Name = "lblSignInID";
            this.lblSignInID.Size = new System.Drawing.Size(83, 23);
            this.lblSignInID.TabIndex = 3;
            this.lblSignInID.Text = "User ID";
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Underline);
            this.lblSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignIn.Location = new System.Drawing.Point(250, 296);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(123, 37);
            this.lblSignIn.TabIndex = 2;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblSignInTagLine
            // 
            this.lblSignInTagLine.AutoSize = true;
            this.lblSignInTagLine.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblSignInTagLine.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignInTagLine.Location = new System.Drawing.Point(212, 214);
            this.lblSignInTagLine.Name = "lblSignInTagLine";
            this.lblSignInTagLine.Size = new System.Drawing.Size(225, 23);
            this.lblSignInTagLine.TabIndex = 1;
            this.lblSignInTagLine.Text = "• Honours Your Trust •";
            // 
            // lblSignInBankName
            // 
            this.lblSignInBankName.AutoSize = true;
            this.lblSignInBankName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F);
            this.lblSignInBankName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSignInBankName.Location = new System.Drawing.Point(95, 155);
            this.lblSignInBankName.Name = "lblSignInBankName";
            this.lblSignInBankName.Size = new System.Drawing.Size(467, 46);
            this.lblSignInBankName.TabIndex = 0;
            this.lblSignInBankName.Text = "Welcome To ABC Bank";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Image = global::Bank_Management_System.Properties.Resources.close_button_11;
            this.btnClose.Location = new System.Drawing.Point(605, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSignInleft
            // 
            this.pnlSignInleft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSignInleft.BackgroundImage = global::Bank_Management_System.Properties.Resources.Sign_up_background_1;
            this.pnlSignInleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSignInleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSignInleft.Location = new System.Drawing.Point(0, 0);
            this.pnlSignInleft.Name = "pnlSignInleft";
            this.pnlSignInleft.Size = new System.Drawing.Size(640, 720);
            this.pnlSignInleft.TabIndex = 1;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlSignInRight);
            this.Controls.Add(this.pnlSignInleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.pnlSignInRight.ResumeLayout(false);
            this.pnlSignInRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSignInleft;
        private System.Windows.Forms.Panel pnlSignInRight;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkSignInToSignUp;
        private System.Windows.Forms.Label lblSignInNoAcc;
        private System.Windows.Forms.TextBox txtSignInPassword;
        private System.Windows.Forms.Label lblSignInPassword;
        private System.Windows.Forms.TextBox txtSignInEmail;
        private System.Windows.Forms.Label lblSignInID;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblSignInTagLine;
        private System.Windows.Forms.Label lblSignInBankName;
    }
}