namespace AutoCare_Pro
{
    partial class AllInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllInvoices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAllInvoicesNav = new System.Windows.Forms.Panel();
            this.btnAllInvoicesSearchButton = new System.Windows.Forms.Button();
            this.txtAllInvoicesSearch = new System.Windows.Forms.TextBox();
            this.lblAllInvoicesName = new System.Windows.Forms.Label();
            this.lblAllInvoicesTitle = new System.Windows.Forms.Label();
            this.pbEmployeeMimageAllInvoices = new System.Windows.Forms.PictureBox();
            this.dgvAllInvoices = new System.Windows.Forms.DataGridView();
            this.lblAllInvoiceTitleHero = new System.Windows.Forms.Label();
            this.lblAllInvoicesSubtitle = new System.Windows.Forms.Label();
            this.invoiceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAllInvoicesNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimageAllInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAllInvoicesNav
            // 
            this.pnlAllInvoicesNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.pnlAllInvoicesNav.Controls.Add(this.btnAllInvoicesSearchButton);
            this.pnlAllInvoicesNav.Controls.Add(this.txtAllInvoicesSearch);
            this.pnlAllInvoicesNav.Controls.Add(this.lblAllInvoicesName);
            this.pnlAllInvoicesNav.Controls.Add(this.lblAllInvoicesTitle);
            this.pnlAllInvoicesNav.Controls.Add(this.pbEmployeeMimageAllInvoices);
            this.pnlAllInvoicesNav.Location = new System.Drawing.Point(0, 0);
            this.pnlAllInvoicesNav.Name = "pnlAllInvoicesNav";
            this.pnlAllInvoicesNav.Size = new System.Drawing.Size(1241, 77);
            this.pnlAllInvoicesNav.TabIndex = 6;
            // 
            // btnAllInvoicesSearchButton
            // 
            this.btnAllInvoicesSearchButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllInvoicesSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("btnAllInvoicesSearchButton.Image")));
            this.btnAllInvoicesSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllInvoicesSearchButton.Location = new System.Drawing.Point(553, 20);
            this.btnAllInvoicesSearchButton.Name = "btnAllInvoicesSearchButton";
            this.btnAllInvoicesSearchButton.Size = new System.Drawing.Size(130, 30);
            this.btnAllInvoicesSearchButton.TabIndex = 4;
            this.btnAllInvoicesSearchButton.Text = "Search";
            this.btnAllInvoicesSearchButton.UseVisualStyleBackColor = true;
            // 
            // txtAllInvoicesSearch
            // 
            this.txtAllInvoicesSearch.Location = new System.Drawing.Point(264, 20);
            this.txtAllInvoicesSearch.Multiline = true;
            this.txtAllInvoicesSearch.Name = "txtAllInvoicesSearch";
            this.txtAllInvoicesSearch.Size = new System.Drawing.Size(294, 30);
            this.txtAllInvoicesSearch.TabIndex = 3;
            // 
            // lblAllInvoicesName
            // 
            this.lblAllInvoicesName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllInvoicesName.ForeColor = System.Drawing.Color.Brown;
            this.lblAllInvoicesName.Location = new System.Drawing.Point(1042, 20);
            this.lblAllInvoicesName.Name = "lblAllInvoicesName";
            this.lblAllInvoicesName.Size = new System.Drawing.Size(88, 25);
            this.lblAllInvoicesName.TabIndex = 2;
            this.lblAllInvoicesName.Text = "ADMIN";
            this.lblAllInvoicesName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllInvoicesTitle
            // 
            this.lblAllInvoicesTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllInvoicesTitle.Location = new System.Drawing.Point(16, 20);
            this.lblAllInvoicesTitle.Name = "lblAllInvoicesTitle";
            this.lblAllInvoicesTitle.Size = new System.Drawing.Size(225, 35);
            this.lblAllInvoicesTitle.TabIndex = 1;
            this.lblAllInvoicesTitle.Text = "ALL INVOICES";
            this.lblAllInvoicesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmployeeMimageAllInvoices
            // 
            this.pbEmployeeMimageAllInvoices.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployeeMimageAllInvoices.Image")));
            this.pbEmployeeMimageAllInvoices.Location = new System.Drawing.Point(1136, 15);
            this.pbEmployeeMimageAllInvoices.Name = "pbEmployeeMimageAllInvoices";
            this.pbEmployeeMimageAllInvoices.Size = new System.Drawing.Size(54, 35);
            this.pbEmployeeMimageAllInvoices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployeeMimageAllInvoices.TabIndex = 0;
            this.pbEmployeeMimageAllInvoices.TabStop = false;
            // 
            // dgvAllInvoices
            // 
            this.dgvAllInvoices.AllowUserToAddRows = false;
            this.dgvAllInvoices.AllowUserToDeleteRows = false;
            this.dgvAllInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllInvoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceno,
            this.date,
            this.customer,
            this.amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllInvoices.Location = new System.Drawing.Point(48, 155);
            this.dgvAllInvoices.Name = "dgvAllInvoices";
            this.dgvAllInvoices.ReadOnly = true;
            this.dgvAllInvoices.RowHeadersWidth = 51;
            this.dgvAllInvoices.RowTemplate.Height = 24;
            this.dgvAllInvoices.Size = new System.Drawing.Size(1142, 507);
            this.dgvAllInvoices.TabIndex = 7;
            // 
            // lblAllInvoiceTitleHero
            // 
            this.lblAllInvoiceTitleHero.AutoSize = true;
            this.lblAllInvoiceTitleHero.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllInvoiceTitleHero.Location = new System.Drawing.Point(45, 88);
            this.lblAllInvoiceTitleHero.Name = "lblAllInvoiceTitleHero";
            this.lblAllInvoiceTitleHero.Size = new System.Drawing.Size(210, 34);
            this.lblAllInvoiceTitleHero.TabIndex = 8;
            this.lblAllInvoiceTitleHero.Text = "Sales Records";
            // 
            // lblAllInvoicesSubtitle
            // 
            this.lblAllInvoicesSubtitle.AutoSize = true;
            this.lblAllInvoicesSubtitle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllInvoicesSubtitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAllInvoicesSubtitle.Location = new System.Drawing.Point(48, 122);
            this.lblAllInvoicesSubtitle.Name = "lblAllInvoicesSubtitle";
            this.lblAllInvoicesSubtitle.Size = new System.Drawing.Size(252, 16);
            this.lblAllInvoicesSubtitle.TabIndex = 9;
            this.lblAllInvoicesSubtitle.Text = "AutoCare Pro High-Performance Telemetry";
            // 
            // invoiceno
            // 
            this.invoiceno.HeaderText = "Invoice No.";
            this.invoiceno.MinimumWidth = 6;
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.MinimumWidth = 6;
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // AllInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAllInvoicesSubtitle);
            this.Controls.Add(this.lblAllInvoiceTitleHero);
            this.Controls.Add(this.dgvAllInvoices);
            this.Controls.Add(this.pnlAllInvoicesNav);
            this.Name = "AllInvoices";
            this.Size = new System.Drawing.Size(1241, 662);
            this.pnlAllInvoicesNav.ResumeLayout(false);
            this.pnlAllInvoicesNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimageAllInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAllInvoicesNav;
        private System.Windows.Forms.Button btnAllInvoicesSearchButton;
        private System.Windows.Forms.TextBox txtAllInvoicesSearch;
        private System.Windows.Forms.Label lblAllInvoicesName;
        private System.Windows.Forms.Label lblAllInvoicesTitle;
        private System.Windows.Forms.PictureBox pbEmployeeMimageAllInvoices;
        private System.Windows.Forms.DataGridView dgvAllInvoices;
        private System.Windows.Forms.Label lblAllInvoiceTitleHero;
        private System.Windows.Forms.Label lblAllInvoicesSubtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}
