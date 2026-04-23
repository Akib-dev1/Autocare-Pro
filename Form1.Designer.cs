using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoCare_Pro
{
    partial class loginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogSubmit = new System.Windows.Forms.Button();
            this.pnlLoginForm = new System.Windows.Forms.Panel();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.txtLoginEmail = new System.Windows.Forms.TextBox();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.pnlCar = new System.Windows.Forms.Panel();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.checkShowPass = new System.Windows.Forms.CheckBox();
            this.pnlLogin.SuspendLayout();
            this.pnlLoginForm.SuspendLayout();
            this.pnlCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblDescription.Location = new System.Drawing.Point(529, 234);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(229, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Smart Billing For Mordern Garages";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(546, 205);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "AUTOCARE PRO";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.btnLogSubmit);
            this.pnlLogin.Controls.Add(this.pnlLoginForm);
            this.pnlLogin.Location = new System.Drawing.Point(418, 266);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(453, 275);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnLogSubmit
            // 
            this.btnLogSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(64)))));
            this.btnLogSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogSubmit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogSubmit.Location = new System.Drawing.Point(36, 206);
            this.btnLogSubmit.Name = "btnLogSubmit";
            this.btnLogSubmit.Size = new System.Drawing.Size(381, 49);
            this.btnLogSubmit.TabIndex = 7;
            this.btnLogSubmit.Text = "Login";
            this.btnLogSubmit.UseVisualStyleBackColor = false;
            this.btnLogSubmit.Click += new System.EventHandler(this.btnLogSubmit_Click);
            // 
            // pnlLoginForm
            // 
            this.pnlLoginForm.Controls.Add(this.checkShowPass);
            this.pnlLoginForm.Controls.Add(this.txtLoginPass);
            this.pnlLoginForm.Controls.Add(this.lblLoginPass);
            this.pnlLoginForm.Controls.Add(this.txtLoginEmail);
            this.pnlLoginForm.Controls.Add(this.lblLoginEmail);
            this.pnlLoginForm.Location = new System.Drawing.Point(21, 32);
            this.pnlLoginForm.Name = "pnlLoginForm";
            this.pnlLoginForm.Size = new System.Drawing.Size(413, 168);
            this.pnlLoginForm.TabIndex = 6;
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtLoginPass.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPass.Location = new System.Drawing.Point(15, 127);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.PasswordChar = '*';
            this.txtLoginPass.Size = new System.Drawing.Size(381, 26);
            this.txtLoginPass.TabIndex = 5;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.lblLoginPass.Location = new System.Drawing.Point(12, 98);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(95, 18);
            this.lblLoginPass.TabIndex = 4;
            this.lblLoginPass.Text = "Password";
            // 
            // txtLoginEmail
            // 
            this.txtLoginEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtLoginEmail.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginEmail.Location = new System.Drawing.Point(15, 41);
            this.txtLoginEmail.Name = "txtLoginEmail";
            this.txtLoginEmail.Size = new System.Drawing.Size(381, 26);
            this.txtLoginEmail.TabIndex = 3;
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.lblLoginEmail.Location = new System.Drawing.Point(12, 13);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(54, 18);
            this.lblLoginEmail.TabIndex = 2;
            this.lblLoginEmail.Text = "Email";
            // 
            // pnlCar
            // 
            this.pnlCar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.pnlCar.Controls.Add(this.picCar);
            this.pnlCar.Location = new System.Drawing.Point(623, 146);
            this.pnlCar.Name = "pnlCar";
            this.pnlCar.Size = new System.Drawing.Size(49, 47);
            this.pnlCar.TabIndex = 0;
            // 
            // picCar
            // 
            this.picCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.picCar.Image = ((System.Drawing.Image)(resources.GetObject("picCar.Image")));
            this.picCar.Location = new System.Drawing.Point(3, 3);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(43, 41);
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            // 
            // checkShowPass
            // 
            this.checkShowPass.AutoSize = true;
            this.checkShowPass.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkShowPass.Location = new System.Drawing.Point(250, 94);
            this.checkShowPass.Name = "checkShowPass";
            this.checkShowPass.Size = new System.Drawing.Size(146, 22);
            this.checkShowPass.TabIndex = 6;
            this.checkShowPass.Text = "Show Password";
            this.checkShowPass.UseVisualStyleBackColor = true;
            this.checkShowPass.CheckedChanged += new System.EventHandler(this.checkShowPass_CheckedChanged);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1264, 831);
            this.Controls.Add(this.pnlCar);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCare Pro | Login Portal";
            this.Load += new System.EventHandler(this.loginPage_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLoginForm.ResumeLayout(false);
            this.pnlLoginForm.PerformLayout();
            this.pnlCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDescription;
        private Label lblTitle;
        private Panel pnlLogin;
        private Button btnLogSubmit;
        private Panel pnlLoginForm;
        private TextBox txtLoginPass;
        private Label lblLoginPass;
        private TextBox txtLoginEmail;
        private Label lblLoginEmail;
        private Panel pnlCar;
        private PictureBox picCar;
        private CheckBox checkShowPass;
    }
}