namespace AutoCare_Pro
{
    partial class VehicleInfo
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPlateNum = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblPlateNum = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.pnlTopTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pnlTopTitle.Controls.Add(this.lblDescription);
            this.pnlTopTitle.Controls.Add(this.lblTitle);
            this.pnlTopTitle.Location = new System.Drawing.Point(-1, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(505, 76);
            this.pnlTopTitle.TabIndex = 19;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(40, 43);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(260, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Input details of the vehicle for invoice";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(38, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vehicle Details Form";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(209, 263);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 30);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPlateNum
            // 
            this.txtPlateNum.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateNum.Location = new System.Drawing.Point(209, 169);
            this.txtPlateNum.Name = "txtPlateNum";
            this.txtPlateNum.Size = new System.Drawing.Size(266, 23);
            this.txtPlateNum.TabIndex = 16;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(209, 134);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(266, 23);
            this.txtYear.TabIndex = 15;
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(209, 94);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(266, 23);
            this.txtModel.TabIndex = 14;
            // 
            // lblPlateNum
            // 
            this.lblPlateNum.AutoSize = true;
            this.lblPlateNum.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.lblPlateNum.Location = new System.Drawing.Point(52, 164);
            this.lblPlateNum.Name = "lblPlateNum";
            this.lblPlateNum.Size = new System.Drawing.Size(147, 25);
            this.lblPlateNum.TabIndex = 12;
            this.lblPlateNum.Text = "Plate Number:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.lblYear.Location = new System.Drawing.Point(52, 129);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(61, 25);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Year:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.lblModel.Location = new System.Drawing.Point(52, 94);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(74, 25);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model:";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(209, 211);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(266, 23);
            this.txtColor.TabIndex = 21;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.lblColor.Location = new System.Drawing.Point(52, 206);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(67, 25);
            this.lblColor.TabIndex = 20;
            this.lblColor.Text = "Color:";
            // 
            // VehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 305);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.pnlTopTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPlateNum);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblPlateNum);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VehicleInfo";
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPlateNum;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblPlateNum;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
    }
}