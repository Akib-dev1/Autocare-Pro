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
            this.btnNavlink4 = new System.Windows.Forms.Button();
            this.btnNavlink3 = new System.Windows.Forms.Button();
            this.btnNavlink2 = new System.Windows.Forms.Button();
            this.btnNavlink1 = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.ucInvoiceList = new AutoCare_Pro.InvoiceList();
            this.ucInventoryList = new AutoCare_Pro.InventoryList();
            this.ucCusList = new AutoCare_Pro.CustomerList();
            this.ucJobcard = new AutoCare_Pro.Jobcard();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pnlSidebar.Controls.Add(this.btnNavlink4);
            this.pnlSidebar.Controls.Add(this.btnNavlink3);
            this.pnlSidebar.Controls.Add(this.btnNavlink2);
            this.pnlSidebar.Controls.Add(this.btnNavlink1);
            this.pnlSidebar.Controls.Add(this.lblDescription);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 746);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnNavlink4
            // 
            this.btnNavlink4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btnNavlink4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btnNavlink4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavlink4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavlink4.ForeColor = System.Drawing.Color.White;
            this.btnNavlink4.Image = ((System.Drawing.Image)(resources.GetObject("btnNavlink4.Image")));
            this.btnNavlink4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavlink4.Location = new System.Drawing.Point(0, 304);
            this.btnNavlink4.Name = "btnNavlink4";
            this.btnNavlink4.Size = new System.Drawing.Size(200, 48);
            this.btnNavlink4.TabIndex = 5;
            this.btnNavlink4.Text = "Invoice";
            this.btnNavlink4.UseVisualStyleBackColor = false;
            this.btnNavlink4.Click += new System.EventHandler(this.btnNavlink4_Click);
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
            this.btnNavlink3.Location = new System.Drawing.Point(0, 242);
            this.btnNavlink3.Name = "btnNavlink3";
            this.btnNavlink3.Size = new System.Drawing.Size(200, 48);
            this.btnNavlink3.TabIndex = 4;
            this.btnNavlink3.Text = "Inventory";
            this.btnNavlink3.UseVisualStyleBackColor = false;
            this.btnNavlink3.Click += new System.EventHandler(this.btnNavlink3_Click);
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
            this.btnNavlink2.Location = new System.Drawing.Point(0, 180);
            this.btnNavlink2.Name = "btnNavlink2";
            this.btnNavlink2.Size = new System.Drawing.Size(200, 48);
            this.btnNavlink2.TabIndex = 3;
            this.btnNavlink2.Text = "Customers";
            this.btnNavlink2.UseVisualStyleBackColor = false;
            this.btnNavlink2.Click += new System.EventHandler(this.btnNavlink2_Click);
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
            this.btnNavlink1.Click += new System.EventHandler(this.btnNavlink1_Click);
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
            // ucInvoiceList
            // 
            this.ucInvoiceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ucInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInvoiceList.Location = new System.Drawing.Point(200, 0);
            this.ucInvoiceList.Name = "ucInvoiceList";
            this.ucInvoiceList.Size = new System.Drawing.Size(1157, 746);
            this.ucInvoiceList.TabIndex = 4;
            // 
            // ucInventoryList
            // 
            this.ucInventoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ucInventoryList.Location = new System.Drawing.Point(198, 0);
            this.ucInventoryList.Name = "ucInventoryList";
            this.ucInventoryList.Size = new System.Drawing.Size(1160, 745);
            this.ucInventoryList.TabIndex = 3;
            // 
            // ucCusList
            // 
            this.ucCusList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ucCusList.Location = new System.Drawing.Point(198, 0);
            this.ucCusList.Name = "ucCusList";
            this.ucCusList.Size = new System.Drawing.Size(1160, 745);
            this.ucCusList.TabIndex = 2;
            this.ucCusList.Visible = false;
            // 
            // ucJobcard
            // 
            this.ucJobcard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucJobcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(247)))));
            this.ucJobcard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ucJobcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucJobcard.ForeColor = System.Drawing.Color.Black;
            this.ucJobcard.Location = new System.Drawing.Point(198, 0);
            this.ucJobcard.Margin = new System.Windows.Forms.Padding(4);
            this.ucJobcard.Name = "ucJobcard";
            this.ucJobcard.Size = new System.Drawing.Size(1161, 746);
            this.ucJobcard.TabIndex = 1;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.ucInvoiceList);
            this.Controls.Add(this.ucInventoryList);
            this.Controls.Add(this.ucCusList);
            this.Controls.Add(this.ucJobcard);
            this.Controls.Add(this.pnlSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "userForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employe | Employe Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userForm_FormClosed);
            this.Load += new System.EventHandler(this.userForm_Load);
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
        private Jobcard ucJobcard;
        private CustomerList ucCusList;
        private InventoryList ucInventoryList;
        private System.Windows.Forms.Button btnNavlink4;
        private InvoiceList ucInvoiceList;
    }
}