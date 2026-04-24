namespace AutoCare_Pro
{
    partial class PartsForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.numQuanitity = new System.Windows.Forms.NumericUpDown();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPartsName = new System.Windows.Forms.Label();
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbParts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numQuanitity)).BeginInit();
            this.pnlTopTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(127, 199);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 30);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // numQuanitity
            // 
            this.numQuanitity.Location = new System.Drawing.Point(149, 146);
            this.numQuanitity.Name = "numQuanitity";
            this.numQuanitity.Size = new System.Drawing.Size(120, 20);
            this.numQuanitity.TabIndex = 35;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(37, 145);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(80, 23);
            this.lblQty.TabIndex = 32;
            this.lblQty.Text = "Quantity";
            // 
            // lblPartsName
            // 
            this.lblPartsName.AutoSize = true;
            this.lblPartsName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartsName.Location = new System.Drawing.Point(37, 105);
            this.lblPartsName.Name = "lblPartsName";
            this.lblPartsName.Size = new System.Drawing.Size(106, 23);
            this.lblPartsName.TabIndex = 31;
            this.lblPartsName.Text = "Parts Name";
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pnlTopTitle.Controls.Add(this.lblDescription);
            this.pnlTopTitle.Controls.Add(this.lblTitle);
            this.pnlTopTitle.Location = new System.Drawing.Point(-1, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(354, 68);
            this.pnlTopTitle.TabIndex = 30;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(15, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(248, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Input details of the parts for invoice";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Parts and Consumables Form";
            // 
            // cmbParts
            // 
            this.cmbParts.FormattingEnabled = true;
            this.cmbParts.Location = new System.Drawing.Point(149, 107);
            this.cmbParts.Name = "cmbParts";
            this.cmbParts.Size = new System.Drawing.Size(121, 21);
            this.cmbParts.TabIndex = 39;
            // 
            // PartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 241);
            this.Controls.Add(this.cmbParts);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.numQuanitity);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblPartsName);
            this.Controls.Add(this.pnlTopTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PartsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numQuanitity)).EndInit();
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown numQuanitity;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPartsName;
        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbParts;
    }
}