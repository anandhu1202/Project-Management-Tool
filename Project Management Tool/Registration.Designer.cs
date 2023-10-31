using System;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.registrationPannel1 = new System.Windows.Forms.Panel();
            this.regGeneralInfo = new System.Windows.Forms.Label();
            this.regOrg = new System.Windows.Forms.Label();
            this.regLName = new System.Windows.Forms.Label();
            this.txtOrgID = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhno = new System.Windows.Forms.TextBox();
            this.regPhno = new System.Windows.Forms.Label();
            this.txtOrg = new System.Windows.Forms.TextBox();
            this.regFName = new System.Windows.Forms.Label();
            this.regOrgID = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.regEmailID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.regConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.regUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.regLoginRedirect = new System.Windows.Forms.Label();
            this.regPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btbregister = new System.Windows.Forms.Button();
            this.regClose = new System.Windows.Forms.PictureBox();
            this.registrationPannel2 = new System.Windows.Forms.Panel();
            this.regCredentials = new System.Windows.Forms.Label();
            this.registrationPannel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regClose)).BeginInit();
            this.registrationPannel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationPannel1
            // 
            this.registrationPannel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.registrationPannel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationPannel1.Controls.Add(this.regGeneralInfo);
            this.registrationPannel1.Controls.Add(this.regOrg);
            this.registrationPannel1.Controls.Add(this.regLName);
            this.registrationPannel1.Controls.Add(this.txtOrgID);
            this.registrationPannel1.Controls.Add(this.txtLName);
            this.registrationPannel1.Controls.Add(this.txtPhno);
            this.registrationPannel1.Controls.Add(this.regPhno);
            this.registrationPannel1.Controls.Add(this.txtOrg);
            this.registrationPannel1.Controls.Add(this.regFName);
            this.registrationPannel1.Controls.Add(this.regOrgID);
            this.registrationPannel1.Controls.Add(this.txtFName);
            this.registrationPannel1.Controls.Add(this.regEmailID);
            this.registrationPannel1.Controls.Add(this.txtEmail);
            this.registrationPannel1.Location = new System.Drawing.Point(93, 87);
            this.registrationPannel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationPannel1.Name = "registrationPannel1";
            this.registrationPannel1.Size = new System.Drawing.Size(551, 541);
            this.registrationPannel1.TabIndex = 29;
            // 
            // regGeneralInfo
            // 
            this.regGeneralInfo.AutoSize = true;
            this.regGeneralInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regGeneralInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regGeneralInfo.Location = new System.Drawing.Point(16, 14);
            this.regGeneralInfo.Name = "regGeneralInfo";
            this.regGeneralInfo.Size = new System.Drawing.Size(187, 28);
            this.regGeneralInfo.TabIndex = 7;
            this.regGeneralInfo.Text = "General Information";
            // 
            // regOrg
            // 
            this.regOrg.AutoSize = true;
            this.regOrg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regOrg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regOrg.Location = new System.Drawing.Point(32, 326);
            this.regOrg.Name = "regOrg";
            this.regOrg.Size = new System.Drawing.Size(130, 28);
            this.regOrg.TabIndex = 24;
            this.regOrg.Text = "Organization:";
            // 
            // regLName
            // 
            this.regLName.AutoSize = true;
            this.regLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regLName.Location = new System.Drawing.Point(33, 218);
            this.regLName.Name = "regLName";
            this.regLName.Size = new System.Drawing.Size(107, 28);
            this.regLName.TabIndex = 20;
            this.regLName.Text = "Last Name:";
            // 
            // txtOrgID
            // 
            this.txtOrgID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgID.Location = new System.Drawing.Point(229, 377);
            this.txtOrgID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrgID.Name = "txtOrgID";
            this.txtOrgID.Size = new System.Drawing.Size(220, 26);
            this.txtOrgID.TabIndex = 21;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(229, 217);
            this.txtLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(220, 26);
            this.txtLName.TabIndex = 19;
            // 
            // txtPhno
            // 
            this.txtPhno.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhno.Location = new System.Drawing.Point(229, 273);
            this.txtPhno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhno.Name = "txtPhno";
            this.txtPhno.Size = new System.Drawing.Size(223, 26);
            this.txtPhno.TabIndex = 16;
            // 
            // regPhno
            // 
            this.regPhno.AutoSize = true;
            this.regPhno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPhno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regPhno.Location = new System.Drawing.Point(32, 270);
            this.regPhno.Name = "regPhno";
            this.regPhno.Size = new System.Drawing.Size(148, 28);
            this.regPhno.TabIndex = 18;
            this.regPhno.Text = "Phone Number:";
            // 
            // txtOrg
            // 
            this.txtOrg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrg.Location = new System.Drawing.Point(229, 325);
            this.txtOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrg.Name = "txtOrg";
            this.txtOrg.Size = new System.Drawing.Size(220, 26);
            this.txtOrg.TabIndex = 23;
            // 
            // regFName
            // 
            this.regFName.AutoSize = true;
            this.regFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regFName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regFName.Location = new System.Drawing.Point(33, 165);
            this.regFName.Name = "regFName";
            this.regFName.Size = new System.Drawing.Size(115, 28);
            this.regFName.TabIndex = 17;
            this.regFName.Text = "First Name :";
            // 
            // regOrgID
            // 
            this.regOrgID.AutoSize = true;
            this.regOrgID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regOrgID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regOrgID.Location = new System.Drawing.Point(32, 377);
            this.regOrgID.Name = "regOrgID";
            this.regOrgID.Size = new System.Drawing.Size(154, 28);
            this.regOrgID.TabIndex = 22;
            this.regOrgID.Text = "Organization ID:";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(232, 160);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(220, 26);
            this.txtFName.TabIndex = 15;
            // 
            // regEmailID
            // 
            this.regEmailID.AutoSize = true;
            this.regEmailID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmailID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regEmailID.Location = new System.Drawing.Point(35, 110);
            this.regEmailID.Name = "regEmailID";
            this.regEmailID.Size = new System.Drawing.Size(92, 28);
            this.regEmailID.TabIndex = 6;
            this.regEmailID.Text = "Email ID :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(232, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // regConfirmPassword
            // 
            this.regConfirmPassword.AutoSize = true;
            this.regConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.regConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regConfirmPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regConfirmPassword.Location = new System.Drawing.Point(32, 226);
            this.regConfirmPassword.Name = "regConfirmPassword";
            this.regConfirmPassword.Size = new System.Drawing.Size(172, 28);
            this.regConfirmPassword.TabIndex = 14;
            this.regConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(237, 225);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(220, 26);
            this.txtConfirmPass.TabIndex = 13;
            // 
            // regUsername
            // 
            this.regUsername.AutoSize = true;
            this.regUsername.BackColor = System.Drawing.Color.Transparent;
            this.regUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regUsername.Location = new System.Drawing.Point(33, 107);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(103, 28);
            this.regUsername.TabIndex = 10;
            this.regUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(233, 106);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 26);
            this.txtUsername.TabIndex = 9;
            // 
            // regLoginRedirect
            // 
            this.regLoginRedirect.AutoSize = true;
            this.regLoginRedirect.BackColor = System.Drawing.Color.Transparent;
            this.regLoginRedirect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLoginRedirect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regLoginRedirect.Location = new System.Drawing.Point(164, 496);
            this.regLoginRedirect.Name = "regLoginRedirect";
            this.regLoginRedirect.Size = new System.Drawing.Size(243, 28);
            this.regLoginRedirect.TabIndex = 8;
            this.regLoginRedirect.Text = "Already Registered? Login.";
            this.regLoginRedirect.Click += new System.EventHandler(this.regLoginRedirect_Click);
            // 
            // regPassword
            // 
            this.regPassword.AutoSize = true;
            this.regPassword.BackColor = System.Drawing.Color.Transparent;
            this.regPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regPassword.Location = new System.Drawing.Point(37, 165);
            this.regPassword.Name = "regPassword";
            this.regPassword.Size = new System.Drawing.Size(102, 28);
            this.regPassword.TabIndex = 7;
            this.regPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(235, 169);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // btbregister
            // 
            this.btbregister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbregister.Location = new System.Drawing.Point(233, 452);
            this.btbregister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbregister.Name = "btbregister";
            this.btbregister.Size = new System.Drawing.Size(127, 37);
            this.btbregister.TabIndex = 0;
            this.btbregister.Text = "Register";
            this.btbregister.UseVisualStyleBackColor = false;
            this.btbregister.Click += new System.EventHandler(this.btbregister_Click);
            // 
            // regClose
            // 
            this.regClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.regClose.Image = ((System.Drawing.Image)(resources.GetObject("regClose.Image")));
            this.regClose.Location = new System.Drawing.Point(1256, 20);
            this.regClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regClose.Name = "regClose";
            this.regClose.Size = new System.Drawing.Size(21, 18);
            this.regClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regClose.TabIndex = 30;
            this.regClose.TabStop = false;
            this.regClose.Click += new System.EventHandler(this.regClose_Click);
            // 
            // registrationPannel2
            // 
            this.registrationPannel2.BackColor = System.Drawing.Color.Transparent;
            this.registrationPannel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationPannel2.Controls.Add(this.regCredentials);
            this.registrationPannel2.Controls.Add(this.regLoginRedirect);
            this.registrationPannel2.Controls.Add(this.btbregister);
            this.registrationPannel2.Controls.Add(this.txtPassword);
            this.registrationPannel2.Controls.Add(this.txtConfirmPass);
            this.registrationPannel2.Controls.Add(this.regConfirmPassword);
            this.registrationPannel2.Controls.Add(this.regPassword);
            this.registrationPannel2.Controls.Add(this.txtUsername);
            this.registrationPannel2.Controls.Add(this.regUsername);
            this.registrationPannel2.Location = new System.Drawing.Point(645, 87);
            this.registrationPannel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registrationPannel2.Name = "registrationPannel2";
            this.registrationPannel2.Size = new System.Drawing.Size(551, 541);
            this.registrationPannel2.TabIndex = 32;
            // 
            // regCredentials
            // 
            this.regCredentials.AutoSize = true;
            this.regCredentials.BackColor = System.Drawing.Color.Transparent;
            this.regCredentials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCredentials.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regCredentials.Location = new System.Drawing.Point(16, 14);
            this.regCredentials.Name = "regCredentials";
            this.regCredentials.Size = new System.Drawing.Size(109, 28);
            this.regCredentials.TabIndex = 7;
            this.regCredentials.Text = "Credentials";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.registrationPannel2);
            this.Controls.Add(this.regClose);
            this.Controls.Add(this.registrationPannel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registration";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.registrationPannel1.ResumeLayout(false);
            this.registrationPannel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regClose)).EndInit();
            this.registrationPannel2.ResumeLayout(false);
            this.registrationPannel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel registrationPannel1;
        private Label regGeneralInfo;
        private Label regOrg;
        private TextBox txtOrg;
        private Label regOrgID;
        private TextBox txtOrgID;
        private Label regLName;
        private TextBox txtLName;
        private Label regPhno;
        private Label regFName;
        private TextBox txtPhno;
        private TextBox txtFName;
        private Label regConfirmPassword;
        private TextBox txtConfirmPass;
        private Label regUsername;
        private TextBox txtUsername;
        private Label regLoginRedirect;
        private Label regPassword;
        private Label regEmailID;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btbregister;
        private PictureBox regClose;
        private Panel registrationPannel2;
        private Label regCredentials;

        public EventHandler Form2_Load { get; private set; }
    }
}