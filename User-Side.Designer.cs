namespace AutoCare_Pro
{
    partial class userForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userForm));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnNavlink1 = new System.Windows.Forms.Button();
            this.btnNavlink2 = new System.Windows.Forms.Button();
            this.btnNavlink3 = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pnlSidebar.Controls.Add(this.btnNavlink3);
            this.pnlSidebar.Controls.Add(this.btnNavlink2);
            this.pnlSidebar.Controls.Add(this.btnNavlink1);
            this.pnlSidebar.Controls.Add(this.lblDescription);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 746);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDescription.Location = new System.Drawing.Point(12, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Service Ledger";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(11, 18);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(141, 19);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "AUTOCARE PRO";
            // 
            // btnNavlink1
            // 
            this.btnNavlink1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnNavlink1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btnNavlink1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavlink1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavlink1.ForeColor = System.Drawing.Color.White;
            this.btnNavlink1.Image = ((System.Drawing.Image)(resources.GetObject("btnNavlink1.Image")));
            this.btnNavlink1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavlink1.Location = new System.Drawing.Point(0, 118);
            this.btnNavlink1.Name = "btnNavlink1";
            this.btnNavlink1.Size = new System.Drawing.Size(200, 48);
            this.btnNavlink1.TabIndex = 2;
            this.btnNavlink1.Text = "Job Cards";
            this.btnNavlink1.UseVisualStyleBackColor = false;
            // 
            // btnNavlink2
            // 
            this.btnNavlink2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnNavlink2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btnNavlink2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavlink2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavlink2.ForeColor = System.Drawing.Color.White;
            this.btnNavlink2.Image = ((System.Drawing.Image)(resources.GetObject("btnNavlink2.Image")));
            this.btnNavlink2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavlink2.Location = new System.Drawing.Point(0, 186);
            this.btnNavlink2.Name = "btnNavlink2";
            this.btnNavlink2.Size = new System.Drawing.Size(200, 48);
            this.btnNavlink2.TabIndex = 3;
            this.btnNavlink2.Text = "Customers";
            this.btnNavlink2.UseVisualStyleBackColor = false;
            // 
            // btnNavlink3
            // 
            this.btnNavlink3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnNavlink3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btnNavlink3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavlink3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavlink3.ForeColor = System.Drawing.Color.White;
            this.btnNavlink3.Image = ((System.Drawing.Image)(resources.GetObject("btnNavlink3.Image")));
            this.btnNavlink3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavlink3.Location = new System.Drawing.Point(0, 251);
            this.btnNavlink3.Name = "btnNavlink3";
            this.btnNavlink3.Size = new System.Drawing.Size(200, 48);
            this.btnNavlink3.TabIndex = 4;
            this.btnNavlink3.Text = "Inventory";
            this.btnNavlink3.UseVisualStyleBackColor = false;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "userForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employe | Manager Dashboard";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnNavlink1;
        private System.Windows.Forms.Button btnNavlink3;
        private System.Windows.Forms.Button btnNavlink2;
    }
}