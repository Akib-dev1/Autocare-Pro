namespace AutoCare_Pro
{
    partial class InventoryMannagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMannagement));
            this.pnlInventoryNav = new System.Windows.Forms.Panel();
            this.btnInventorySearchButton = new System.Windows.Forms.Button();
            this.txtInventorySearch = new System.Windows.Forms.TextBox();
            this.lblReportName = new System.Windows.Forms.Label();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.pbEmployeeMimage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInventorySubtitle = new System.Windows.Forms.Label();
            this.lblInventoryManagementTitle = new System.Windows.Forms.Label();
            this.pnlTotalAsset = new System.Windows.Forms.Panel();
            this.pbAvgSales = new System.Windows.Forms.PictureBox();
            this.lblActiveSubscript = new System.Windows.Forms.Label();
            this.lblAvgSaleTotal = new System.Windows.Forms.Label();
            this.lblTotalAssetTitle = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.pbWarningIcon = new System.Windows.Forms.PictureBox();
            this.lblLowStockSubscript = new System.Windows.Forms.Label();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.lblLowStockText = new System.Windows.Forms.Label();
            this.pnlStockValue = new System.Windows.Forms.Panel();
            this.pbValueIcon = new System.Windows.Forms.PictureBox();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.lblStockValueText = new System.Windows.Forms.Label();
            this.dgvIntevtoryParts = new System.Windows.Forms.DataGridView();
            this.partIdentification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.pnlInventoryNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimage)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTotalAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).BeginInit();
            this.pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningIcon)).BeginInit();
            this.pnlStockValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValueIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntevtoryParts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInventoryNav
            // 
            this.pnlInventoryNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.pnlInventoryNav.Controls.Add(this.btnInventorySearchButton);
            this.pnlInventoryNav.Controls.Add(this.txtInventorySearch);
            this.pnlInventoryNav.Controls.Add(this.lblReportName);
            this.pnlInventoryNav.Controls.Add(this.lblInventoryTitle);
            this.pnlInventoryNav.Controls.Add(this.pbEmployeeMimage);
            this.pnlInventoryNav.Location = new System.Drawing.Point(0, 0);
            this.pnlInventoryNav.Name = "pnlInventoryNav";
            this.pnlInventoryNav.Size = new System.Drawing.Size(1225, 72);
            this.pnlInventoryNav.TabIndex = 2;
            // 
            // btnInventorySearchButton
            // 
            this.btnInventorySearchButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventorySearchButton.Image = ((System.Drawing.Image)(resources.GetObject("btnInventorySearchButton.Image")));
            this.btnInventorySearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventorySearchButton.Location = new System.Drawing.Point(553, 20);
            this.btnInventorySearchButton.Name = "btnInventorySearchButton";
            this.btnInventorySearchButton.Size = new System.Drawing.Size(130, 30);
            this.btnInventorySearchButton.TabIndex = 4;
            this.btnInventorySearchButton.Text = "Search";
            this.btnInventorySearchButton.UseVisualStyleBackColor = true;
            // 
            // txtInventorySearch
            // 
            this.txtInventorySearch.Location = new System.Drawing.Point(264, 20);
            this.txtInventorySearch.Multiline = true;
            this.txtInventorySearch.Name = "txtInventorySearch";
            this.txtInventorySearch.Size = new System.Drawing.Size(294, 30);
            this.txtInventorySearch.TabIndex = 3;
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
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitle.Location = new System.Drawing.Point(16, 15);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(225, 35);
            this.lblInventoryTitle.TabIndex = 1;
            this.lblInventoryTitle.Text = "Inventory Management";
            this.lblInventoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmployeeMimage
            // 
            this.pbEmployeeMimage.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployeeMimage.Image")));
            this.pbEmployeeMimage.Location = new System.Drawing.Point(1136, 15);
            this.pbEmployeeMimage.Name = "pbEmployeeMimage";
            this.pbEmployeeMimage.Size = new System.Drawing.Size(54, 35);
            this.pbEmployeeMimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployeeMimage.TabIndex = 0;
            this.pbEmployeeMimage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnAddStock);
            this.panel1.Controls.Add(this.dgvIntevtoryParts);
            this.panel1.Controls.Add(this.pnlStockValue);
            this.panel1.Controls.Add(this.pnlLowStock);
            this.panel1.Controls.Add(this.pnlTotalAsset);
            this.panel1.Controls.Add(this.lblInventorySubtitle);
            this.panel1.Controls.Add(this.lblInventoryManagementTitle);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 552);
            this.panel1.TabIndex = 3;
            // 
            // lblInventorySubtitle
            // 
            this.lblInventorySubtitle.AutoSize = true;
            this.lblInventorySubtitle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventorySubtitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblInventorySubtitle.Location = new System.Drawing.Point(17, 53);
            this.lblInventorySubtitle.Name = "lblInventorySubtitle";
            this.lblInventorySubtitle.Size = new System.Drawing.Size(288, 16);
            this.lblInventorySubtitle.TabIndex = 1;
            this.lblInventorySubtitle.Text = "Real-time telemetry of AutoCare Pro stock levels.";
            // 
            // lblInventoryManagementTitle
            // 
            this.lblInventoryManagementTitle.AutoSize = true;
            this.lblInventoryManagementTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManagementTitle.Location = new System.Drawing.Point(15, 19);
            this.lblInventoryManagementTitle.Name = "lblInventoryManagementTitle";
            this.lblInventoryManagementTitle.Size = new System.Drawing.Size(349, 34);
            this.lblInventoryManagementTitle.TabIndex = 0;
            this.lblInventoryManagementTitle.Text = "Inventory Management";
            // 
            // pnlTotalAsset
            // 
            this.pnlTotalAsset.AllowDrop = true;
            this.pnlTotalAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlTotalAsset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotalAsset.Controls.Add(this.pbAvgSales);
            this.pnlTotalAsset.Controls.Add(this.lblActiveSubscript);
            this.pnlTotalAsset.Controls.Add(this.lblAvgSaleTotal);
            this.pnlTotalAsset.Controls.Add(this.lblTotalAssetTitle);
            this.pnlTotalAsset.Location = new System.Drawing.Point(75, 85);
            this.pnlTotalAsset.Name = "pnlTotalAsset";
            this.pnlTotalAsset.Size = new System.Drawing.Size(289, 151);
            this.pnlTotalAsset.TabIndex = 3;
            // 
            // pbAvgSales
            // 
            this.pbAvgSales.Image = ((System.Drawing.Image)(resources.GetObject("pbAvgSales.Image")));
            this.pbAvgSales.Location = new System.Drawing.Point(18, 18);
            this.pbAvgSales.Name = "pbAvgSales";
            this.pbAvgSales.Size = new System.Drawing.Size(50, 43);
            this.pbAvgSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvgSales.TabIndex = 3;
            this.pbAvgSales.TabStop = false;
            // 
            // lblActiveSubscript
            // 
            this.lblActiveSubscript.AutoSize = true;
            this.lblActiveSubscript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveSubscript.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblActiveSubscript.Location = new System.Drawing.Point(179, 102);
            this.lblActiveSubscript.Name = "lblActiveSubscript";
            this.lblActiveSubscript.Size = new System.Drawing.Size(59, 18);
            this.lblActiveSubscript.TabIndex = 2;
            this.lblActiveSubscript.Text = "Active";
            this.lblActiveSubscript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgSaleTotal
            // 
            this.lblAvgSaleTotal.AutoSize = true;
            this.lblAvgSaleTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSaleTotal.Location = new System.Drawing.Point(73, 87);
            this.lblAvgSaleTotal.Name = "lblAvgSaleTotal";
            this.lblAvgSaleTotal.Size = new System.Drawing.Size(100, 36);
            this.lblAvgSaleTotal.TabIndex = 1;
            this.lblAvgSaleTotal.Text = "1,288";
            this.lblAvgSaleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAssetTitle
            // 
            this.lblTotalAssetTitle.AutoSize = true;
            this.lblTotalAssetTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssetTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalAssetTitle.Location = new System.Drawing.Point(74, 28);
            this.lblTotalAssetTitle.Name = "lblTotalAssetTitle";
            this.lblTotalAssetTitle.Size = new System.Drawing.Size(156, 28);
            this.lblTotalAssetTitle.TabIndex = 0;
            this.lblTotalAssetTitle.Text = "Total Asset";
            this.lblTotalAssetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.AllowDrop = true;
            this.pnlLowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(214)))));
            this.pnlLowStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLowStock.Controls.Add(this.pbWarningIcon);
            this.pnlLowStock.Controls.Add(this.lblLowStockSubscript);
            this.pnlLowStock.Controls.Add(this.lblLowStockValue);
            this.pnlLowStock.Controls.Add(this.lblLowStockText);
            this.pnlLowStock.Location = new System.Drawing.Point(464, 85);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(289, 151);
            this.pnlLowStock.TabIndex = 4;
            // 
            // pbWarningIcon
            // 
            this.pbWarningIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbWarningIcon.Image")));
            this.pbWarningIcon.Location = new System.Drawing.Point(18, 18);
            this.pbWarningIcon.Name = "pbWarningIcon";
            this.pbWarningIcon.Size = new System.Drawing.Size(50, 43);
            this.pbWarningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningIcon.TabIndex = 3;
            this.pbWarningIcon.TabStop = false;
            // 
            // lblLowStockSubscript
            // 
            this.lblLowStockSubscript.AutoSize = true;
            this.lblLowStockSubscript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockSubscript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblLowStockSubscript.Location = new System.Drawing.Point(132, 96);
            this.lblLowStockSubscript.Name = "lblLowStockSubscript";
            this.lblLowStockSubscript.Size = new System.Drawing.Size(59, 18);
            this.lblLowStockSubscript.TabIndex = 2;
            this.lblLowStockSubscript.Text = "Active";
            this.lblLowStockSubscript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowStockValue
            // 
            this.lblLowStockValue.AutoSize = true;
            this.lblLowStockValue.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockValue.ForeColor = System.Drawing.Color.Red;
            this.lblLowStockValue.Location = new System.Drawing.Point(73, 84);
            this.lblLowStockValue.Name = "lblLowStockValue";
            this.lblLowStockValue.Size = new System.Drawing.Size(53, 36);
            this.lblLowStockValue.TabIndex = 1;
            this.lblLowStockValue.Text = "12";
            this.lblLowStockValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLowStockText
            // 
            this.lblLowStockText.AutoSize = true;
            this.lblLowStockText.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockText.ForeColor = System.Drawing.Color.Red;
            this.lblLowStockText.Location = new System.Drawing.Point(74, 28);
            this.lblLowStockText.Name = "lblLowStockText";
            this.lblLowStockText.Size = new System.Drawing.Size(145, 28);
            this.lblLowStockText.TabIndex = 0;
            this.lblLowStockText.Text = "Low Stock";
            this.lblLowStockText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStockValue
            // 
            this.pnlStockValue.AllowDrop = true;
            this.pnlStockValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlStockValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStockValue.Controls.Add(this.pbValueIcon);
            this.pnlStockValue.Controls.Add(this.lblStockValue);
            this.pnlStockValue.Controls.Add(this.lblStockValueText);
            this.pnlStockValue.Location = new System.Drawing.Point(853, 85);
            this.pnlStockValue.Name = "pnlStockValue";
            this.pnlStockValue.Size = new System.Drawing.Size(289, 151);
            this.pnlStockValue.TabIndex = 4;
            // 
            // pbValueIcon
            // 
            this.pbValueIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbValueIcon.Image")));
            this.pbValueIcon.Location = new System.Drawing.Point(18, 18);
            this.pbValueIcon.Name = "pbValueIcon";
            this.pbValueIcon.Size = new System.Drawing.Size(50, 43);
            this.pbValueIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbValueIcon.TabIndex = 3;
            this.pbValueIcon.TabStop = false;
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockValue.Location = new System.Drawing.Point(73, 81);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(121, 36);
            this.lblStockValue.TabIndex = 1;
            this.lblStockValue.Text = "$30.5K";
            this.lblStockValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStockValueText
            // 
            this.lblStockValueText.AutoSize = true;
            this.lblStockValueText.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockValueText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStockValueText.Location = new System.Drawing.Point(74, 28);
            this.lblStockValueText.Name = "lblStockValueText";
            this.lblStockValueText.Size = new System.Drawing.Size(163, 28);
            this.lblStockValueText.TabIndex = 0;
            this.lblStockValueText.Text = "Stock Value";
            this.lblStockValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvIntevtoryParts
            // 
            this.dgvIntevtoryParts.AllowUserToAddRows = false;
            this.dgvIntevtoryParts.AllowUserToDeleteRows = false;
            this.dgvIntevtoryParts.AllowUserToResizeRows = false;
            this.dgvIntevtoryParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntevtoryParts.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvIntevtoryParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntevtoryParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIdentification,
            this.catagory,
            this.quantity,
            this.unitcost,
            this.supplier});
            this.dgvIntevtoryParts.Location = new System.Drawing.Point(75, 279);
            this.dgvIntevtoryParts.Name = "dgvIntevtoryParts";
            this.dgvIntevtoryParts.ReadOnly = true;
            this.dgvIntevtoryParts.RowHeadersWidth = 51;
            this.dgvIntevtoryParts.RowTemplate.Height = 24;
            this.dgvIntevtoryParts.Size = new System.Drawing.Size(1067, 270);
            this.dgvIntevtoryParts.TabIndex = 8;
            // 
            // partIdentification
            // 
            this.partIdentification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partIdentification.HeaderText = "Part Identification";
            this.partIdentification.MinimumWidth = 6;
            this.partIdentification.Name = "partIdentification";
            this.partIdentification.ReadOnly = true;
            // 
            // catagory
            // 
            this.catagory.HeaderText = "Catagory";
            this.catagory.MinimumWidth = 6;
            this.catagory.Name = "catagory";
            this.catagory.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // unitcost
            // 
            this.unitcost.HeaderText = "Unit Cost";
            this.unitcost.MinimumWidth = 6;
            this.unitcost.Name = "unitcost";
            this.unitcost.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.MinimumWidth = 6;
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.btnAddStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStock.BackgroundImage")));
            this.btnAddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddStock.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Location = new System.Drawing.Point(970, 28);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(172, 51);
            this.btnAddStock.TabIndex = 9;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            // 
            // InventoryMannagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInventoryNav);
            this.Name = "InventoryMannagement";
            this.Size = new System.Drawing.Size(1224, 622);
            this.pnlInventoryNav.ResumeLayout(false);
            this.pnlInventoryNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTotalAsset.ResumeLayout(false);
            this.pnlTotalAsset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).EndInit();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningIcon)).EndInit();
            this.pnlStockValue.ResumeLayout(false);
            this.pnlStockValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValueIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntevtoryParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInventoryNav;
        private System.Windows.Forms.Button btnInventorySearchButton;
        private System.Windows.Forms.TextBox txtInventorySearch;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.PictureBox pbEmployeeMimage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInventoryManagementTitle;
        private System.Windows.Forms.Label lblInventorySubtitle;
        private System.Windows.Forms.Panel pnlTotalAsset;
        private System.Windows.Forms.PictureBox pbAvgSales;
        private System.Windows.Forms.Label lblActiveSubscript;
        private System.Windows.Forms.Label lblAvgSaleTotal;
        private System.Windows.Forms.Label lblTotalAssetTitle;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.PictureBox pbWarningIcon;
        private System.Windows.Forms.Label lblLowStockSubscript;
        private System.Windows.Forms.Label lblLowStockValue;
        private System.Windows.Forms.Label lblLowStockText;
        private System.Windows.Forms.Panel pnlStockValue;
        private System.Windows.Forms.PictureBox pbValueIcon;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label lblStockValueText;
        private System.Windows.Forms.DataGridView dgvIntevtoryParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIdentification;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.Button btnAddStock;
    }
}
