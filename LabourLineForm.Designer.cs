namespace AutoCare_Pro
{
    partial class LabourLineForm
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
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblServiceDesc = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.rtextDescription = new System.Windows.Forms.RichTextBox();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.numRate = new System.Windows.Forms.NumericUpDown();
            this.lblDoller = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlTopTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pnlTopTitle.Controls.Add(this.lblDescription);
            this.pnlTopTitle.Controls.Add(this.lblTitle);
            this.pnlTopTitle.Location = new System.Drawing.Point(-1, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(486, 76);
            this.pnlTopTitle.TabIndex = 20;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(40, 43);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(254, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Input details of the labour for invoice";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(38, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Labour Line Form";
            // 
            // lblServiceDesc
            // 
            this.lblServiceDesc.AutoSize = true;
            this.lblServiceDesc.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDesc.Location = new System.Drawing.Point(38, 104);
            this.lblServiceDesc.Name = "lblServiceDesc";
            this.lblServiceDesc.Size = new System.Drawing.Size(169, 23);
            this.lblServiceDesc.TabIndex = 21;
            this.lblServiceDesc.Text = "Service Description";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(38, 168);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(59, 23);
            this.lblHours.TabIndex = 22;
            this.lblHours.Text = "Hours";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(38, 205);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(48, 23);
            this.lblRate.TabIndex = 23;
            this.lblRate.Text = "Rate";
            // 
            // rtextDescription
            // 
            this.rtextDescription.Location = new System.Drawing.Point(213, 104);
            this.rtextDescription.Name = "rtextDescription";
            this.rtextDescription.Size = new System.Drawing.Size(228, 45);
            this.rtextDescription.TabIndex = 24;
            this.rtextDescription.Text = "";
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(213, 168);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(120, 20);
            this.numHours.TabIndex = 25;
            // 
            // numRate
            // 
            this.numRate.Location = new System.Drawing.Point(213, 205);
            this.numRate.Name = "numRate";
            this.numRate.Size = new System.Drawing.Size(120, 20);
            this.numRate.TabIndex = 26;
            // 
            // lblDoller
            // 
            this.lblDoller.AutoSize = true;
            this.lblDoller.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoller.Location = new System.Drawing.Point(339, 205);
            this.lblDoller.Name = "lblDoller";
            this.lblDoller.Size = new System.Drawing.Size(18, 19);
            this.lblDoller.TabIndex = 27;
            this.lblDoller.Text = "$";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(213, 248);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 30);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // LabourLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 301);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDoller);
            this.Controls.Add(this.numRate);
            this.Controls.Add(this.numHours);
            this.Controls.Add(this.rtextDescription);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblServiceDesc);
            this.Controls.Add(this.pnlTopTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabourLineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LabourLineForm";
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblServiceDesc;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.RichTextBox rtextDescription;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.NumericUpDown numRate;
        private System.Windows.Forms.Label lblDoller;
        private System.Windows.Forms.Button btnSubmit;
    }
}