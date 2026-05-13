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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.lblRevenueTrendTitle = new System.Windows.Forms.Label();
            this.ctTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.ctTrend)).BeginInit();
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
            this.pnlReportTopBar.Name = "pnlReportTopBar";
            this.pnlReportTopBar.Size = new System.Drawing.Size(1204, 70);
            this.pnlReportTopBar.TabIndex = 0;
            // 
            // lblReportName
            // 
            this.lblReportName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.ForeColor = System.Drawing.Color.Brown;
            this.lblReportName.Location = new System.Drawing.Point(1042, 20);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(88, 25);
            this.lblReportName.TabIndex = 2;
            this.lblReportName.Text = "ADMIN";
            this.lblReportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(16, 15);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(201, 35);
            this.lblReportTitle.TabIndex = 1;
            this.lblReportTitle.Text = "The Machinist Ledger";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbReportImage
            // 
            this.pbReportImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbReportImage.Image = ((System.Drawing.Image)(resources.GetObject("pbReportImage.Image")));
            this.pbReportImage.Location = new System.Drawing.Point(1136, 15);
            this.pbReportImage.Name = "pbReportImage";
            this.pbReportImage.Size = new System.Drawing.Size(54, 35);
            this.pbReportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReportImage.TabIndex = 0;
            this.pbReportImage.TabStop = false;
            // 
            // lblReportSalesAnalytics
            // 
            this.lblReportSalesAnalytics.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSalesAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblReportSalesAnalytics.Location = new System.Drawing.Point(16, 107);
            this.lblReportSalesAnalytics.Name = "lblReportSalesAnalytics";
            this.lblReportSalesAnalytics.Size = new System.Drawing.Size(232, 35);
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
            this.pnlAvgSales.Location = new System.Drawing.Point(20, 163);
            this.pnlAvgSales.Name = "pnlAvgSales";
            this.pnlAvgSales.Size = new System.Drawing.Size(289, 151);
            this.pnlAvgSales.TabIndex = 2;
            // 
            // pbAvgSales
            // 
            this.pbAvgSales.Image = ((System.Drawing.Image)(resources.GetObject("pbAvgSales.Image")));
            this.pbAvgSales.Location = new System.Drawing.Point(18, 28);
            this.pbAvgSales.Name = "pbAvgSales";
            this.pbAvgSales.Size = new System.Drawing.Size(50, 43);
            this.pbAvgSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvgSales.TabIndex = 3;
            this.pbAvgSales.TabStop = false;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrency.Location = new System.Drawing.Point(154, 92);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(116, 34);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "USD/INVOICE";
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgSaleTotal
            // 
            this.lblAvgSaleTotal.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSaleTotal.Location = new System.Drawing.Point(12, 76);
            this.lblAvgSaleTotal.Name = "lblAvgSaleTotal";
            this.lblAvgSaleTotal.Size = new System.Drawing.Size(148, 54);
            this.lblAvgSaleTotal.TabIndex = 1;
            this.lblAvgSaleTotal.Text = "$284.50";
            this.lblAvgSaleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgSales
            // 
            this.lblAvgSales.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvgSales.Location = new System.Drawing.Point(84, 28);
            this.lblAvgSales.Name = "lblAvgSales";
            this.lblAvgSales.Size = new System.Drawing.Size(129, 43);
            this.lblAvgSales.TabIndex = 0;
            this.lblAvgSales.Text = "AVG SALES";
            this.lblAvgSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNewCustomers
            // 
            this.pnlNewCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlNewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNewCustomers.Controls.Add(this.pbNewCustomerLogo);
            this.pnlNewCustomers.Controls.Add(this.lblNewCustomerSubscript);
            this.pnlNewCustomers.Controls.Add(this.lblTotalCustomerAmount);
            this.pnlNewCustomers.Controls.Add(this.lblTotalCustomerTitle);
            this.pnlNewCustomers.Location = new System.Drawing.Point(430, 163);
            this.pnlNewCustomers.Name = "pnlNewCustomers";
            this.pnlNewCustomers.Size = new System.Drawing.Size(289, 151);
            this.pnlNewCustomers.TabIndex = 4;
            // 
            // pbNewCustomerLogo
            // 
            this.pbNewCustomerLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbNewCustomerLogo.Image")));
            this.pbNewCustomerLogo.Location = new System.Drawing.Point(18, 28);
            this.pbNewCustomerLogo.Name = "pbNewCustomerLogo";
            this.pbNewCustomerLogo.Size = new System.Drawing.Size(50, 43);
            this.pbNewCustomerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewCustomerLogo.TabIndex = 3;
            this.pbNewCustomerLogo.TabStop = false;
            // 
            // lblNewCustomerSubscript
            // 
            this.lblNewCustomerSubscript.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCustomerSubscript.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNewCustomerSubscript.Location = new System.Drawing.Point(84, 92);
            this.lblNewCustomerSubscript.Name = "lblNewCustomerSubscript";
            this.lblNewCustomerSubscript.Size = new System.Drawing.Size(116, 34);
            this.lblNewCustomerSubscript.TabIndex = 2;
            this.lblNewCustomerSubscript.Text = "ACUISITIONS";
            this.lblNewCustomerSubscript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomerAmount
            // 
            this.lblTotalCustomerAmount.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomerAmount.Location = new System.Drawing.Point(12, 76);
            this.lblTotalCustomerAmount.Name = "lblTotalCustomerAmount";
            this.lblTotalCustomerAmount.Size = new System.Drawing.Size(82, 54);
            this.lblTotalCustomerAmount.TabIndex = 1;
            this.lblTotalCustomerAmount.Text = "123";
            this.lblTotalCustomerAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCustomerTitle
            // 
            this.lblTotalCustomerTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomerTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalCustomerTitle.Location = new System.Drawing.Point(84, 28);
            this.lblTotalCustomerTitle.Name = "lblTotalCustomerTitle";
            this.lblTotalCustomerTitle.Size = new System.Drawing.Size(173, 43);
            this.lblTotalCustomerTitle.TabIndex = 0;
            this.lblTotalCustomerTitle.Text = "TOTAL CUSTOMERS";
            this.lblTotalCustomerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProjectedRevenue
            // 
            this.pnlProjectedRevenue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnlProjectedRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProjectedRevenue.Controls.Add(this.pbProjectedRevenueLogo);
            this.pnlProjectedRevenue.Controls.Add(this.lblProRevenueSubscript);
            this.pnlProjectedRevenue.Controls.Add(this.lblProRevenueAmount);
            this.pnlProjectedRevenue.Controls.Add(this.lblProjectedRevenueTitle);
            this.pnlProjectedRevenue.Location = new System.Drawing.Point(842, 163);
            this.pnlProjectedRevenue.Name = "pnlProjectedRevenue";
            this.pnlProjectedRevenue.Size = new System.Drawing.Size(289, 151);
            this.pnlProjectedRevenue.TabIndex = 4;
            // 
            // pbProjectedRevenueLogo
            // 
            this.pbProjectedRevenueLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbProjectedRevenueLogo.Image")));
            this.pbProjectedRevenueLogo.Location = new System.Drawing.Point(18, 28);
            this.pbProjectedRevenueLogo.Name = "pbProjectedRevenueLogo";
            this.pbProjectedRevenueLogo.Size = new System.Drawing.Size(50, 43);
            this.pbProjectedRevenueLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProjectedRevenueLogo.TabIndex = 3;
            this.pbProjectedRevenueLogo.TabStop = false;
            // 
            // lblProRevenueSubscript
            // 
            this.lblProRevenueSubscript.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProRevenueSubscript.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProRevenueSubscript.Location = new System.Drawing.Point(154, 92);
            this.lblProRevenueSubscript.Name = "lblProRevenueSubscript";
            this.lblProRevenueSubscript.Size = new System.Drawing.Size(132, 34);
            this.lblProRevenueSubscript.TabIndex = 2;
            this.lblProRevenueSubscript.Text = "MONTHLY QUOTA\r\n";
            this.lblProRevenueSubscript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProRevenueAmount
            // 
            this.lblProRevenueAmount.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProRevenueAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProRevenueAmount.Location = new System.Drawing.Point(12, 76);
            this.lblProRevenueAmount.Name = "lblProRevenueAmount";
            this.lblProRevenueAmount.Size = new System.Drawing.Size(148, 54);
            this.lblProRevenueAmount.TabIndex = 1;
            this.lblProRevenueAmount.Text = "$284.50";
            this.lblProRevenueAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProjectedRevenueTitle
            // 
            this.lblProjectedRevenueTitle.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblProjectedRevenueTitle.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectedRevenueTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblProjectedRevenueTitle.Location = new System.Drawing.Point(84, 28);
            this.lblProjectedRevenueTitle.Name = "lblProjectedRevenueTitle";
            this.lblProjectedRevenueTitle.Size = new System.Drawing.Size(162, 43);
            this.lblProjectedRevenueTitle.TabIndex = 0;
            this.lblProjectedRevenueTitle.Text = "PROJECTED REVENUE";
            this.lblProjectedRevenueTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRevenueTrendTitle
            // 
            this.lblRevenueTrendTitle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueTrendTitle.Location = new System.Drawing.Point(34, 333);
            this.lblRevenueTrendTitle.Name = "lblRevenueTrendTitle";
            this.lblRevenueTrendTitle.Size = new System.Drawing.Size(179, 30);
            this.lblRevenueTrendTitle.TabIndex = 5;
            this.lblRevenueTrendTitle.Text = "REVENUE TRENDS";
            // 
            // ctTrend
            // 
            chartArea3.Name = "ChartArea1";
            this.ctTrend.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ctTrend.Legends.Add(legend3);
            this.ctTrend.Location = new System.Drawing.Point(20, 375);
            this.ctTrend.Name = "ctTrend";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ctTrend.Series.Add(series3);
            this.ctTrend.Size = new System.Drawing.Size(588, 226);
            this.ctTrend.TabIndex = 6;
            this.ctTrend.Text = "chart1";
            // 
            // lblLedgerTitle
            // 
            this.lblLedgerTitle.AutoSize = true;
            this.lblLedgerTitle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLedgerTitle.Location = new System.Drawing.Point(650, 333);
            this.lblLedgerTitle.Name = "lblLedgerTitle";
            this.lblLedgerTitle.Size = new System.Drawing.Size(143, 22);
            this.lblLedgerTitle.TabIndex = 0;
            this.lblLedgerTitle.Text = "Priority Ledger";
            // 
            // dgvLedger
            // 
            this.dgvLedger.AllowUserToAddRows = false;
            this.dgvLedger.AllowUserToDeleteRows = false;
            this.dgvLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvLedger.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleModel,
            this.service,
            this.Amount,
            this.status});
            this.dgvLedger.Location = new System.Drawing.Point(654, 375);
            this.dgvLedger.Name = "dgvLedger";
            this.dgvLedger.ReadOnly = true;
            this.dgvLedger.RowHeadersWidth = 51;
            this.dgvLedger.RowTemplate.Height = 24;
            this.dgvLedger.Size = new System.Drawing.Size(482, 226);
            this.dgvLedger.TabIndex = 7;
            // 
            // VehicleModel
            // 
            this.VehicleModel.DataPropertyName = "Vehicle_Model";
            this.VehicleModel.HeaderText = "Vehicle Model";
            this.VehicleModel.MinimumWidth = 6;
            this.VehicleModel.Name = "VehicleModel";
            this.VehicleModel.ReadOnly = true;
            this.VehicleModel.Width = 125;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.Controls.Add(this.dgvLedger);
            this.Controls.Add(this.lblLedgerTitle);
            this.Controls.Add(this.ctTrend);
            this.Controls.Add(this.lblRevenueTrendTitle);
            this.Controls.Add(this.pnlProjectedRevenue);
            this.Controls.Add(this.pnlNewCustomers);
            this.Controls.Add(this.pnlAvgSales);
            this.Controls.Add(this.lblReportSalesAnalytics);
            this.Controls.Add(this.pnlReportTopBar);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1204, 649);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.pnlReportTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReportImage)).EndInit();
            this.pnlAvgSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).EndInit();
            this.pnlNewCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewCustomerLogo)).EndInit();
            this.pnlProjectedRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectedRevenueLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctTrend)).EndInit();
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
        private System.Windows.Forms.Label lblRevenueTrendTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart ctTrend;
        private System.Windows.Forms.Label lblLedgerTitle;
        private System.Windows.Forms.DataGridView dgvLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}
