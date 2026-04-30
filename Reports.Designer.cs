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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlReportTopBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.lblReportName = new System.Windows.Forms.Label();
            this.txtReportSearch = new System.Windows.Forms.TextBox();
            this.btnReportSearchButton = new System.Windows.Forms.Button();
            this.lblReportSalesAnalytics = new System.Windows.Forms.Label();
            this.pnlAvgSales = new System.Windows.Forms.Panel();
            this.lblAvgASales = new System.Windows.Forms.Label();
            this.lblAvgSaleTotal = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.pbAvgSales = new System.Windows.Forms.PictureBox();
            this.pnlNewCustomers = new System.Windows.Forms.Panel();
            this.pbNewCustomerLogo = new System.Windows.Forms.PictureBox();
            this.lblNewCustomerSubscript = new System.Windows.Forms.Label();
            this.lblNewCustomerAmount = new System.Windows.Forms.Label();
            this.lblNewCustomerTitle = new System.Windows.Forms.Label();
            this.pnlProjectedRevenue = new System.Windows.Forms.Panel();
            this.pbProjectedRevenueLogo = new System.Windows.Forms.PictureBox();
            this.lblProRevenueSubscript = new System.Windows.Forms.Label();
            this.lblProRevenueAmount = new System.Windows.Forms.Label();
            this.lblProjectedRevenueTitle = new System.Windows.Forms.Label();
            this.lblRevenueTrendTitle = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlReportTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAvgSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).BeginInit();
            this.pnlNewCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewCustomerLogo)).BeginInit();
            this.pnlProjectedRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectedRevenueLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReportTopBar
            // 
            this.pnlReportTopBar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlReportTopBar.Controls.Add(this.btnReportSearchButton);
            this.pnlReportTopBar.Controls.Add(this.txtReportSearch);
            this.pnlReportTopBar.Controls.Add(this.lblReportName);
            this.pnlReportTopBar.Controls.Add(this.lblReportTitle);
            this.pnlReportTopBar.Controls.Add(this.pictureBox1);
            this.pnlReportTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlReportTopBar.Name = "pnlReportTopBar";
            this.pnlReportTopBar.Size = new System.Drawing.Size(1203, 70);
            this.pnlReportTopBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1136, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // lblReportName
            // 
            this.lblReportName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportName.ForeColor = System.Drawing.Color.Brown;
            this.lblReportName.Location = new System.Drawing.Point(1042, 20);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Size = new System.Drawing.Size(88, 25);
            this.lblReportName.TabIndex = 2;
            this.lblReportName.Text = "ADMIN";
            this.lblReportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReportSearch
            // 
            this.txtReportSearch.Location = new System.Drawing.Point(242, 20);
            this.txtReportSearch.Multiline = true;
            this.txtReportSearch.Name = "txtReportSearch";
            this.txtReportSearch.Size = new System.Drawing.Size(294, 30);
            this.txtReportSearch.TabIndex = 3;
            // 
            // btnReportSearchButton
            // 
            this.btnReportSearchButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("btnReportSearchButton.Image")));
            this.btnReportSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportSearchButton.Location = new System.Drawing.Point(534, 20);
            this.btnReportSearchButton.Name = "btnReportSearchButton";
            this.btnReportSearchButton.Size = new System.Drawing.Size(130, 30);
            this.btnReportSearchButton.TabIndex = 4;
            this.btnReportSearchButton.Text = "Search";
            this.btnReportSearchButton.UseVisualStyleBackColor = true;
            // 
            // lblReportSalesAnalytics
            // 
            this.lblReportSalesAnalytics.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSalesAnalytics.Location = new System.Drawing.Point(16, 107);
            this.lblReportSalesAnalytics.Name = "lblReportSalesAnalytics";
            this.lblReportSalesAnalytics.Size = new System.Drawing.Size(177, 35);
            this.lblReportSalesAnalytics.TabIndex = 1;
            this.lblReportSalesAnalytics.Text = "Sales Analytics";
            this.lblReportSalesAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAvgSales
            // 
            this.pnlAvgSales.AllowDrop = true;
            this.pnlAvgSales.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlAvgSales.Controls.Add(this.pbAvgSales);
            this.pnlAvgSales.Controls.Add(this.lblCurrency);
            this.pnlAvgSales.Controls.Add(this.lblAvgSaleTotal);
            this.pnlAvgSales.Controls.Add(this.lblAvgASales);
            this.pnlAvgSales.Location = new System.Drawing.Point(21, 188);
            this.pnlAvgSales.Name = "pnlAvgSales";
            this.pnlAvgSales.Size = new System.Drawing.Size(289, 151);
            this.pnlAvgSales.TabIndex = 2;
            // 
            // lblAvgASales
            // 
            this.lblAvgASales.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgASales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvgASales.Location = new System.Drawing.Point(84, 28);
            this.lblAvgASales.Name = "lblAvgASales";
            this.lblAvgASales.Size = new System.Drawing.Size(129, 43);
            this.lblAvgASales.TabIndex = 0;
            this.lblAvgASales.Text = "AVG SALES";
            this.lblAvgASales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAvgASales.Click += new System.EventHandler(this.lblAvgASales_Click);
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
            // pnlNewCustomers
            // 
            this.pnlNewCustomers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlNewCustomers.Controls.Add(this.pbNewCustomerLogo);
            this.pnlNewCustomers.Controls.Add(this.lblNewCustomerSubscript);
            this.pnlNewCustomers.Controls.Add(this.lblNewCustomerAmount);
            this.pnlNewCustomers.Controls.Add(this.lblNewCustomerTitle);
            this.pnlNewCustomers.Location = new System.Drawing.Point(431, 188);
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
            // lblNewCustomerAmount
            // 
            this.lblNewCustomerAmount.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCustomerAmount.Location = new System.Drawing.Point(12, 76);
            this.lblNewCustomerAmount.Name = "lblNewCustomerAmount";
            this.lblNewCustomerAmount.Size = new System.Drawing.Size(82, 54);
            this.lblNewCustomerAmount.TabIndex = 1;
            this.lblNewCustomerAmount.Text = "123";
            this.lblNewCustomerAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewCustomerAmount.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNewCustomerTitle
            // 
            this.lblNewCustomerTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewCustomerTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNewCustomerTitle.Location = new System.Drawing.Point(84, 28);
            this.lblNewCustomerTitle.Name = "lblNewCustomerTitle";
            this.lblNewCustomerTitle.Size = new System.Drawing.Size(173, 43);
            this.lblNewCustomerTitle.TabIndex = 0;
            this.lblNewCustomerTitle.Text = "NEW CUSTOMERS";
            this.lblNewCustomerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProjectedRevenue
            // 
            this.pnlProjectedRevenue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnlProjectedRevenue.Controls.Add(this.pbProjectedRevenueLogo);
            this.pnlProjectedRevenue.Controls.Add(this.lblProRevenueSubscript);
            this.pnlProjectedRevenue.Controls.Add(this.lblProRevenueAmount);
            this.pnlProjectedRevenue.Controls.Add(this.lblProjectedRevenueTitle);
            this.pnlProjectedRevenue.Location = new System.Drawing.Point(842, 188);
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
            this.lblRevenueTrendTitle.Location = new System.Drawing.Point(39, 376);
            this.lblRevenueTrendTitle.Name = "lblRevenueTrendTitle";
            this.lblRevenueTrendTitle.Size = new System.Drawing.Size(179, 30);
            this.lblRevenueTrendTitle.TabIndex = 5;
            this.lblRevenueTrendTitle.Text = "REVENUE TRENDS";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(207, 415);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(854, 206);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblRevenueTrendTitle);
            this.Controls.Add(this.pnlProjectedRevenue);
            this.Controls.Add(this.pnlNewCustomers);
            this.Controls.Add(this.pnlAvgSales);
            this.Controls.Add(this.lblReportSalesAnalytics);
            this.Controls.Add(this.pnlReportTopBar);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1204, 649);
            this.pnlReportTopBar.ResumeLayout(false);
            this.pnlReportTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAvgSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).EndInit();
            this.pnlNewCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewCustomerLogo)).EndInit();
            this.pnlProjectedRevenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProjectedRevenueLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReportTopBar;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.TextBox txtReportSearch;
        private System.Windows.Forms.Button btnReportSearchButton;
        private System.Windows.Forms.Label lblReportSalesAnalytics;
        private System.Windows.Forms.Panel pnlAvgSales;
        private System.Windows.Forms.Label lblAvgASales;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblAvgSaleTotal;
        private System.Windows.Forms.PictureBox pbAvgSales;
        private System.Windows.Forms.Panel pnlNewCustomers;
        private System.Windows.Forms.PictureBox pbNewCustomerLogo;
        private System.Windows.Forms.Label lblNewCustomerSubscript;
        private System.Windows.Forms.Label lblNewCustomerAmount;
        private System.Windows.Forms.Label lblNewCustomerTitle;
        private System.Windows.Forms.Panel pnlProjectedRevenue;
        private System.Windows.Forms.PictureBox pbProjectedRevenueLogo;
        private System.Windows.Forms.Label lblProRevenueSubscript;
        private System.Windows.Forms.Label lblProRevenueAmount;
        private System.Windows.Forms.Label lblProjectedRevenueTitle;
        private System.Windows.Forms.Label lblRevenueTrendTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
