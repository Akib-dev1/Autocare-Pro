namespace AutoCare_Pro
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.pnlReportTopBar = new System.Windows.Forms.Panel();
            this.lblReportName = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.pbReportImage = new System.Windows.Forms.PictureBox();
            this.lblReportSalesAnalytics = new System.Windows.Forms.Label();
            this.pnlAvgSales = new System.Windows.Forms.Panel();
            this.pbAvgSales = new System.Windows.Forms.PictureBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblAvgSaleTotal = new System.Windows.Forms.Label();
            this.lblAvgSales = new System.Windows.Forms.Label();
            this.pnlNewCustomers = new System.Windows.Forms.Panel();
            this.pbNewCustomerLogo = new System.Windows.Forms.PictureBox();
            this.lblNewCustomerSubscript = new System.Windows.Forms.Label();
            this.lblTotalCustomerAmount = new System.Windows.Forms.Label();
            this.lblTotalCustomerTitle = new System.Windows.Forms.Label();
            this.pnlProjectedRevenue = new System.Windows.Forms.Panel();
            this.pbProjectedRevenueLogo = new System.Windows.Forms.PictureBox();
            this.lblProRevenueSubscript = new System.Windows.Forms.Label();
            this.lblProRevenueAmount = new System.Windows.Forms.Label();
            this.lblProjectedRevenueTitle = new System.Windows.Forms.Label();
            this.lblLedgerTitle = new System.Windows.Forms.Label();
            this.dgvLedger = new System.Windows.Forms.DataGridView();
            this.VehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReportTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportImage)).BeginInit();
            this.pnlAvgSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).BeginInit();
            this.pnlNewCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewCustomerLogo)).BeginInit();
            this.pnlProjectedRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectedRevenueLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReportTopBar
            // 
            this.pnlReportTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.pnlReportTopBar.Controls.Add(this.lblReportName);
            this.pnlReportTopBar.Controls.Add(this.lblReportTitle);
            this.pnlReportTopBar.Controls.Add(this.pbReportImage);
            this.pnlReportTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlReportTopBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlReportTopBar.Name = "pnlReportTopBar";
            this.pnlReportTopBar.Size = new System.Drawing.Size(903, 57);
            this.pnlReportTopBar.TabIndex = 0;
            // 
            // lblReportName
            // 
            this.lblReportName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.ForeColor = System.Drawing.Color.Brown;
            this.lblReportName.Location = new System.Drawing.Point(782, 16);
            this.lblReportName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(66, 20);
            this.lblReportName.TabIndex = 2;
            this.lblReportName.Text = "ADMIN";
            this.lblReportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(12, 19);
            this.lblReportTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(154, 17);
            this.lblReportTitle.TabIndex = 1;
            this.lblReportTitle.Text = "The Machinist Ledger";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbReportImage
            // 
            this.pbReportImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbReportImage.Image = ((System.Drawing.Image)(resources.GetObject("pbReportImage.Image")));
            this.pbReportImage.Location = new System.Drawing.Point(852, 12);
            this.pbReportImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbReportImage.Name = "pbReportImage";
            this.pbReportImage.Size = new System.Drawing.Size(40, 28);
            this.pbReportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReportImage.TabIndex = 0;
            this.pbReportImage.TabStop = false;
            // 
            // lblReportSalesAnalytics
            // 
            this.lblReportSalesAnalytics.AutoSize = true;
            this.lblReportSalesAnalytics.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSalesAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblReportSalesAnalytics.Location = new System.Drawing.Point(38, 85);
            this.lblReportSalesAnalytics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportSalesAnalytics.Name = "lblReportSalesAnalytics";
            this.lblReportSalesAnalytics.Size = new System.Drawing.Size(177, 27);
            this.lblReportSalesAnalytics.TabIndex = 1;
            this.lblReportSalesAnalytics.Text = "Sales Analytics";
            this.lblReportSalesAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAvgSales
            // 
            this.pnlAvgSales.AllowDrop = true;
            this.pnlAvgSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlAvgSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAvgSales.Controls.Add(this.pbAvgSales);
            this.pnlAvgSales.Controls.Add(this.lblCurrency);
            this.pnlAvgSales.Controls.Add(this.lblAvgSaleTotal);
            this.pnlAvgSales.Controls.Add(this.lblAvgSales);
            this.pnlAvgSales.Location = new System.Drawing.Point(43, 131);
            this.pnlAvgSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAvgSales.Name = "pnlAvgSales";
            this.pnlAvgSales.Size = new System.Drawing.Size(231, 123);
            this.pnlAvgSales.TabIndex = 2;
            // 
            // pbAvgSales
            // 
            this.pbAvgSales.Image = ((System.Drawing.Image)(resources.GetObject("pbAvgSales.Image")));
            this.pbAvgSales.Location = new System.Drawing.Point(14, 23);
            this.pbAvgSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbAvgSales.Name = "pbAvgSales";
            this.pbAvgSales.Size = new System.Drawing.Size(38, 35);
            this.pbAvgSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvgSales.TabIndex = 3;
            this.pbAvgSales.TabStop = false;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrency.Location = new System.Drawing.Point(88, 73);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(95, 13);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "USD/INVOICE";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgSaleTotal
            // 
            this.lblAvgSaleTotal.AutoSize = true;
            this.lblAvgSaleTotal.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSaleTotal.Location = new System.Drawing.Point(9, 68);
            this.lblAvgSaleTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgSaleTotal.Name = "lblAvgSaleTotal";
            this.lblAvgSaleTotal.Size = new System.Drawing.Size(40, 27);
            this.lblAvgSaleTotal.TabIndex = 1;
            this.lblAvgSaleTotal.Text = "$0";
            this.lblAvgSaleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgSales
            // 
            this.lblAvgSales.AutoSize = true;
            this.lblAvgSales.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvgSales.Location = new System.Drawing.Point(101, 33);
            this.lblAvgSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgSales.Name = "lblAvgSales";
            this.lblAvgSales.Size = new System.Drawing.Size(82, 14);
            this.lblAvgSales.TabIndex = 0;
            this.lblAvgSales.Text = "AVG SALES";
            this.lblAvgSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNewCustomers
            // 
            this.pnlNewCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNewCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlNewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNewCustomers.Controls.Add(this.pbNewCustomerLogo);
            this.pnlNewCustomers.Controls.Add(this.lblNewCustomerSubscript);
            this.pnlNewCustomers.Controls.Add(this.lblTotalCustomerAmount);
            this.pnlNewCustomers.Controls.Add(this.lblTotalCustomerTitle);
            this.pnlNewCustomers.Location = new System.Drawing.Point(339, 131);
            this.pnlNewCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNewCustomers.Name = "pnlNewCustomers";
            this.pnlNewCustomers.Size = new System.Drawing.Size(218, 123);
            this.pnlNewCustomers.TabIndex = 4;
            // 
            // pbNewCustomerLogo
            // 
            this.pbNewCustomerLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbNewCustomerLogo.Image")));
            this.pbNewCustomerLogo.Location = new System.Drawing.Point(14, 23);
            this.pbNewCustomerLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbNewCustomerLogo.Name = "pbNewCustomerLogo";
            this.pbNewCustomerLogo.Size = new System.Drawing.Size(38, 35);
            this.pbNewCustomerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewCustomerLogo.TabIndex = 3;
            this.pbNewCustomerLogo.TabStop = false;
            // 
            // lblNewCustomerSubscript
            // 
            this.lblNewCustomerSubscript.AutoSize = true;
            this.lblNewCustomerSubscript.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCustomerSubscript.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNewCustomerSubscript.Location = new System.Drawing.Point(102, 80);
            this.lblNewCustomerSubscript.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewCustomerSubscript.Name = "lblNewCustomerSubscript";
            this.lblNewCustomerSubscript.Size = new System.Drawing.Size(93, 13);
            this.lblNewCustomerSubscript.TabIndex = 2;
            this.lblNewCustomerSubscript.Text = "ACUISITIONS";
            this.lblNewCustomerSubscript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomerAmount
            // 
            this.lblTotalCustomerAmount.AutoSize = true;
            this.lblTotalCustomerAmount.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomerAmount.Location = new System.Drawing.Point(26, 73);
            this.lblTotalCustomerAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCustomerAmount.Name = "lblTotalCustomerAmount";
            this.lblTotalCustomerAmount.Size = new System.Drawing.Size(26, 27);
            this.lblTotalCustomerAmount.TabIndex = 1;
            this.lblTotalCustomerAmount.Text = "0";
            this.lblTotalCustomerAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomerTitle
            // 
            this.lblTotalCustomerTitle.AutoSize = true;
            this.lblTotalCustomerTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomerTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalCustomerTitle.Location = new System.Drawing.Point(56, 33);
            this.lblTotalCustomerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCustomerTitle.Name = "lblTotalCustomerTitle";
            this.lblTotalCustomerTitle.Size = new System.Drawing.Size(139, 14);
            this.lblTotalCustomerTitle.TabIndex = 0;
            this.lblTotalCustomerTitle.Text = "TOTAL CUSTOMERS";
            this.lblTotalCustomerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProjectedRevenue
            // 
            this.pnlProjectedRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProjectedRevenue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnlProjectedRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProjectedRevenue.Controls.Add(this.pbProjectedRevenueLogo);
            this.pnlProjectedRevenue.Controls.Add(this.lblProRevenueSubscript);
            this.pnlProjectedRevenue.Controls.Add(this.lblProRevenueAmount);
            this.pnlProjectedRevenue.Controls.Add(this.lblProjectedRevenueTitle);
            this.pnlProjectedRevenue.Location = new System.Drawing.Point(622, 131);
            this.pnlProjectedRevenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlProjectedRevenue.Name = "pnlProjectedRevenue";
            this.pnlProjectedRevenue.Size = new System.Drawing.Size(243, 123);
            this.pnlProjectedRevenue.TabIndex = 4;
            // 
            // pbProjectedRevenueLogo
            // 
            this.pbProjectedRevenueLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbProjectedRevenueLogo.Image")));
            this.pbProjectedRevenueLogo.Location = new System.Drawing.Point(14, 23);
            this.pbProjectedRevenueLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbProjectedRevenueLogo.Name = "pbProjectedRevenueLogo";
            this.pbProjectedRevenueLogo.Size = new System.Drawing.Size(38, 35);
            this.pbProjectedRevenueLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProjectedRevenueLogo.TabIndex = 3;
            this.pbProjectedRevenueLogo.TabStop = false;
            // 
            // lblProRevenueSubscript
            // 
            this.lblProRevenueSubscript.AutoSize = true;
            this.lblProRevenueSubscript.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProRevenueSubscript.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProRevenueSubscript.Location = new System.Drawing.Point(109, 74);
            this.lblProRevenueSubscript.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProRevenueSubscript.Name = "lblProRevenueSubscript";
            this.lblProRevenueSubscript.Size = new System.Drawing.Size(115, 13);
            this.lblProRevenueSubscript.TabIndex = 2;
            this.lblProRevenueSubscript.Text = "MONTHLY QUOTA\r\n";
            this.lblProRevenueSubscript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProRevenueAmount
            // 
            this.lblProRevenueAmount.AutoSize = true;
            this.lblProRevenueAmount.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProRevenueAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProRevenueAmount.Location = new System.Drawing.Point(9, 68);
            this.lblProRevenueAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProRevenueAmount.Name = "lblProRevenueAmount";
            this.lblProRevenueAmount.Size = new System.Drawing.Size(40, 27);
            this.lblProRevenueAmount.TabIndex = 1;
            this.lblProRevenueAmount.Text = "$0";
            this.lblProRevenueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProjectedRevenueTitle
            // 
            this.lblProjectedRevenueTitle.AutoSize = true;
            this.lblProjectedRevenueTitle.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblProjectedRevenueTitle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectedRevenueTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProjectedRevenueTitle.Location = new System.Drawing.Point(83, 33);
            this.lblProjectedRevenueTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjectedRevenueTitle.Name = "lblProjectedRevenueTitle";
            this.lblProjectedRevenueTitle.Size = new System.Drawing.Size(141, 13);
            this.lblProjectedRevenueTitle.TabIndex = 0;
            this.lblProjectedRevenueTitle.Text = "PROJECTED REVENUE";
            this.lblProjectedRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLedgerTitle
            // 
            this.lblLedgerTitle.AutoSize = true;
            this.lblLedgerTitle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLedgerTitle.Location = new System.Drawing.Point(41, 274);
            this.lblLedgerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLedgerTitle.Name = "lblLedgerTitle";
            this.lblLedgerTitle.Size = new System.Drawing.Size(122, 18);
            this.lblLedgerTitle.TabIndex = 0;
            this.lblLedgerTitle.Text = "Priority Ledger";
            // 
            // dgvLedger
            // 
            this.dgvLedger.AllowUserToAddRows = false;
            this.dgvLedger.AllowUserToDeleteRows = false;
            this.dgvLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLedger.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleModel,
            this.service,
            this.Amount,
            this.status});
            this.dgvLedger.Location = new System.Drawing.Point(43, 308);
            this.dgvLedger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLedger.Name = "dgvLedger";
            this.dgvLedger.ReadOnly = true;
            this.dgvLedger.RowHeadersWidth = 51;
            this.dgvLedger.RowTemplate.Height = 24;
            this.dgvLedger.Size = new System.Drawing.Size(823, 184);
            this.dgvLedger.TabIndex = 7;
            // 
            // VehicleModel
            // 
            this.VehicleModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VehicleModel.DataPropertyName = "Vehicle_Model";
            this.VehicleModel.HeaderText = "Vehicle Model";
            this.VehicleModel.MinimumWidth = 6;
            this.VehicleModel.Name = "VehicleModel";
            this.VehicleModel.ReadOnly = true;
            // 
            // service
            // 
            this.service.DataPropertyName = "Description";
            this.service.HeaderText = "Service";
            this.service.MinimumWidth = 6;
            this.service.Name = "service";
            this.service.ReadOnly = true;
            this.service.Width = 125;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Grand_Total";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // status
            // 
            this.status.DataPropertyName = "Tech_Notes";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.Controls.Add(this.dgvLedger);
            this.Controls.Add(this.lblLedgerTitle);
            this.Controls.Add(this.pnlProjectedRevenue);
            this.Controls.Add(this.pnlNewCustomers);
            this.Controls.Add(this.pnlAvgSales);
            this.Controls.Add(this.lblReportSalesAnalytics);
            this.Controls.Add(this.pnlReportTopBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(903, 527);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.pnlReportTopBar.ResumeLayout(false);
            this.pnlReportTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReportImage)).EndInit();
            this.pnlAvgSales.ResumeLayout(false);
            this.pnlAvgSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).EndInit();
            this.pnlNewCustomers.ResumeLayout(false);
            this.pnlNewCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewCustomerLogo)).EndInit();
            this.pnlProjectedRevenue.ResumeLayout(false);
            this.pnlProjectedRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectedRevenueLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlReportTopBar;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.PictureBox pbReportImage;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.Label lblReportSalesAnalytics;
        private System.Windows.Forms.Panel pnlAvgSales;
        private System.Windows.Forms.Label lblAvgSales;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblAvgSaleTotal;
        private System.Windows.Forms.PictureBox pbAvgSales;
        private System.Windows.Forms.Panel pnlNewCustomers;
        private System.Windows.Forms.PictureBox pbNewCustomerLogo;
        private System.Windows.Forms.Label lblNewCustomerSubscript;
        private System.Windows.Forms.Label lblTotalCustomerAmount;
        private System.Windows.Forms.Label lblTotalCustomerTitle;
        private System.Windows.Forms.Panel pnlProjectedRevenue;
        private System.Windows.Forms.PictureBox pbProjectedRevenueLogo;
        private System.Windows.Forms.Label lblProRevenueSubscript;
        private System.Windows.Forms.Label lblProRevenueAmount;
        private System.Windows.Forms.Label lblProjectedRevenueTitle;
        private System.Windows.Forms.Label lblLedgerTitle;
        private System.Windows.Forms.DataGridView dgvLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
