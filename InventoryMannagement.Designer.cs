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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInventoryNav = new System.Windows.Forms.Panel();
            this.txtInventorySearch = new System.Windows.Forms.TextBox();
            this.lblInventoryManagementName = new System.Windows.Forms.Label();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.pbEmployeeMimageInventory = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.InventoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.pnlStockValue = new System.Windows.Forms.Panel();
            this.pbValueIcon = new System.Windows.Forms.PictureBox();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.lblStockValueText = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.pbWarningIcon = new System.Windows.Forms.PictureBox();
            this.lblLowStockSubscript = new System.Windows.Forms.Label();
            this.lblLowStockValue = new System.Windows.Forms.Label();
            this.lblLowStockText = new System.Windows.Forms.Label();
            this.pnlTotalAsset = new System.Windows.Forms.Panel();
            this.pbAvgSales = new System.Windows.Forms.PictureBox();
            this.lblActiveSubscript = new System.Windows.Forms.Label();
            this.lblTotalAsset = new System.Windows.Forms.Label();
            this.lblTotalAssetTitle = new System.Windows.Forms.Label();
            this.lblInventorySubtitle = new System.Windows.Forms.Label();
            this.lblInventoryManagementTitle = new System.Windows.Forms.Label();
            this.lblDescriptionOfSearch = new System.Windows.Forms.Label();
            this.pnlInventoryNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimageInventory)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlStockValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValueIcon)).BeginInit();
            this.pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningIcon)).BeginInit();
            this.pnlTotalAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInventoryNav
            // 
            this.pnlInventoryNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.pnlInventoryNav.Controls.Add(this.lblDescriptionOfSearch);
            this.pnlInventoryNav.Controls.Add(this.txtInventorySearch);
            this.pnlInventoryNav.Controls.Add(this.lblInventoryManagementName);
            this.pnlInventoryNav.Controls.Add(this.lblInventoryTitle);
            this.pnlInventoryNav.Controls.Add(this.pbEmployeeMimageInventory);
            this.pnlInventoryNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventoryNav.Location = new System.Drawing.Point(0, 0);
            this.pnlInventoryNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInventoryNav.Name = "pnlInventoryNav";
            this.pnlInventoryNav.Size = new System.Drawing.Size(1255, 85);
            this.pnlInventoryNav.TabIndex = 2;
            // 
            // txtInventorySearch
            // 
            this.txtInventorySearch.Location = new System.Drawing.Point(299, 32);
            this.txtInventorySearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInventorySearch.Multiline = true;
            this.txtInventorySearch.Name = "txtInventorySearch";
            this.txtInventorySearch.Size = new System.Drawing.Size(295, 30);
            this.txtInventorySearch.TabIndex = 3;
            this.txtInventorySearch.TextChanged += new System.EventHandler(this.txtInventorySearch_TextChanged);
            // 
            // lblInventoryManagementName
            // 
            this.lblInventoryManagementName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManagementName.ForeColor = System.Drawing.Color.Brown;
            this.lblInventoryManagementName.Location = new System.Drawing.Point(1059, 37);
            this.lblInventoryManagementName.Name = "lblInventoryManagementName";
            this.lblInventoryManagementName.Size = new System.Drawing.Size(88, 25);
            this.lblInventoryManagementName.TabIndex = 2;
            this.lblInventoryManagementName.Text = "ADMIN";
            this.lblInventoryManagementName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryTitle.Location = new System.Drawing.Point(3, 30);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(287, 28);
            this.lblInventoryTitle.TabIndex = 1;
            this.lblInventoryTitle.Text = "Inventory Management";
            this.lblInventoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmployeeMimageInventory
            // 
            this.pbEmployeeMimageInventory.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployeeMimageInventory.Image")));
            this.pbEmployeeMimageInventory.Location = new System.Drawing.Point(1152, 32);
            this.pbEmployeeMimageInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEmployeeMimageInventory.Name = "pbEmployeeMimageInventory";
            this.pbEmployeeMimageInventory.Size = new System.Drawing.Size(53, 34);
            this.pbEmployeeMimageInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployeeMimageInventory.TabIndex = 0;
            this.pbEmployeeMimageInventory.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.pnlMain.Controls.Add(this.btnEditStock);
            this.pnlMain.Controls.Add(this.dgvInventory);
            this.pnlMain.Controls.Add(this.btnAddStock);
            this.pnlMain.Controls.Add(this.pnlStockValue);
            this.pnlMain.Controls.Add(this.pnlLowStock);
            this.pnlMain.Controls.Add(this.pnlTotalAsset);
            this.pnlMain.Controls.Add(this.lblInventorySubtitle);
            this.pnlMain.Controls.Add(this.lblInventoryManagementTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 85);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1255, 785);
            this.pnlMain.TabIndex = 3;
            // 
            // btnEditStock
            // 
            this.btnEditStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.btnEditStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditStock.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStock.Image = ((System.Drawing.Image)(resources.GetObject("btnEditStock.Image")));
            this.btnEditStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditStock.Location = new System.Drawing.Point(665, 39);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnEditStock.Size = new System.Drawing.Size(216, 50);
            this.btnEditStock.TabIndex = 11;
            this.btnEditStock.Text = "Edit Stock";
            this.btnEditStock.UseVisualStyleBackColor = false;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(115)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInventory.ColumnHeadersHeight = 40;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryId,
            this.PartName,
            this.UnitPrice,
            this.StockQTY});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(115)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvInventory.Location = new System.Drawing.Point(87, 297);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 35;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(1069, 447);
            this.dgvInventory.TabIndex = 10;
            // 
            // InventoryId
            // 
            this.InventoryId.DataPropertyName = "inventory_id";
            this.InventoryId.HeaderText = "Inventory Id";
            this.InventoryId.MinimumWidth = 6;
            this.InventoryId.Name = "InventoryId";
            this.InventoryId.ReadOnly = true;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "part_name";
            this.PartName.HeaderText = "Part Name";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "unit_price";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // StockQTY
            // 
            this.StockQTY.DataPropertyName = "stock_qty";
            this.StockQTY.HeaderText = "Stock Quantity";
            this.StockQTY.MinimumWidth = 6;
            this.StockQTY.Name = "StockQTY";
            this.StockQTY.ReadOnly = true;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.btnAddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddStock.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStock.Image")));
            this.btnAddStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.Location = new System.Drawing.Point(887, 39);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Padding = new System.Windows.Forms.Padding(0, 6, 7, 6);
            this.btnAddStock.Size = new System.Drawing.Size(269, 50);
            this.btnAddStock.TabIndex = 9;
            this.btnAddStock.Text = " Add Stock\r\n\r\n";
            this.btnAddStock.UseVisualStyleBackColor = false;
            // 
            // pnlStockValue
            // 
            this.pnlStockValue.AllowDrop = true;
            this.pnlStockValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlStockValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStockValue.Controls.Add(this.pbValueIcon);
            this.pnlStockValue.Controls.Add(this.lblStockValue);
            this.pnlStockValue.Controls.Add(this.lblStockValueText);
            this.pnlStockValue.Location = new System.Drawing.Point(865, 111);
            this.pnlStockValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlStockValue.Name = "pnlStockValue";
            this.pnlStockValue.Size = new System.Drawing.Size(289, 150);
            this.pnlStockValue.TabIndex = 4;
            // 
            // pbValueIcon
            // 
            this.pbValueIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbValueIcon.Image")));
            this.pbValueIcon.Location = new System.Drawing.Point(19, 18);
            this.pbValueIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbValueIcon.Name = "pbValueIcon";
            this.pbValueIcon.Size = new System.Drawing.Size(51, 43);
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
            this.lblStockValueText.Location = new System.Drawing.Point(75, 26);
            this.lblStockValueText.Name = "lblStockValueText";
            this.lblStockValueText.Size = new System.Drawing.Size(163, 28);
            this.lblStockValueText.TabIndex = 0;
            this.lblStockValueText.Text = "Stock Value";
            this.lblStockValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlLowStock.Location = new System.Drawing.Point(476, 111);
            this.pnlLowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(289, 150);
            this.pnlLowStock.TabIndex = 4;
            // 
            // pbWarningIcon
            // 
            this.pbWarningIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbWarningIcon.Image")));
            this.pbWarningIcon.Location = new System.Drawing.Point(19, 18);
            this.pbWarningIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbWarningIcon.Name = "pbWarningIcon";
            this.pbWarningIcon.Size = new System.Drawing.Size(51, 43);
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
            this.lblLowStockValue.Location = new System.Drawing.Point(73, 87);
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
            this.lblLowStockText.Location = new System.Drawing.Point(75, 26);
            this.lblLowStockText.Name = "lblLowStockText";
            this.lblLowStockText.Size = new System.Drawing.Size(145, 28);
            this.lblLowStockText.TabIndex = 0;
            this.lblLowStockText.Text = "Low Stock";
            this.lblLowStockText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalAsset
            // 
            this.pnlTotalAsset.AllowDrop = true;
            this.pnlTotalAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlTotalAsset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotalAsset.Controls.Add(this.pbAvgSales);
            this.pnlTotalAsset.Controls.Add(this.lblActiveSubscript);
            this.pnlTotalAsset.Controls.Add(this.lblTotalAsset);
            this.pnlTotalAsset.Controls.Add(this.lblTotalAssetTitle);
            this.pnlTotalAsset.Location = new System.Drawing.Point(87, 111);
            this.pnlTotalAsset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTotalAsset.Name = "pnlTotalAsset";
            this.pnlTotalAsset.Size = new System.Drawing.Size(289, 150);
            this.pnlTotalAsset.TabIndex = 3;
            // 
            // pbAvgSales
            // 
            this.pbAvgSales.Image = ((System.Drawing.Image)(resources.GetObject("pbAvgSales.Image")));
            this.pbAvgSales.Location = new System.Drawing.Point(19, 18);
            this.pbAvgSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvgSales.Name = "pbAvgSales";
            this.pbAvgSales.Size = new System.Drawing.Size(51, 43);
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
            // lblTotalAsset
            // 
            this.lblTotalAsset.AutoSize = true;
            this.lblTotalAsset.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAsset.Location = new System.Drawing.Point(73, 94);
            this.lblTotalAsset.Name = "lblTotalAsset";
            this.lblTotalAsset.Size = new System.Drawing.Size(100, 36);
            this.lblTotalAsset.TabIndex = 1;
            this.lblTotalAsset.Text = "1,288";
            this.lblTotalAsset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAssetTitle
            // 
            this.lblTotalAssetTitle.AutoSize = true;
            this.lblTotalAssetTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAssetTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalAssetTitle.Location = new System.Drawing.Point(75, 26);
            this.lblTotalAssetTitle.Name = "lblTotalAssetTitle";
            this.lblTotalAssetTitle.Size = new System.Drawing.Size(156, 28);
            this.lblTotalAssetTitle.TabIndex = 0;
            this.lblTotalAssetTitle.Text = "Total Asset";
            this.lblTotalAssetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInventorySubtitle
            // 
            this.lblInventorySubtitle.AutoSize = true;
            this.lblInventorySubtitle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventorySubtitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblInventorySubtitle.Location = new System.Drawing.Point(83, 59);
            this.lblInventorySubtitle.Name = "lblInventorySubtitle";
            this.lblInventorySubtitle.Size = new System.Drawing.Size(288, 16);
            this.lblInventorySubtitle.TabIndex = 1;
            this.lblInventorySubtitle.Text = "Real-time telemetry of AutoCare Pro stock levels.";
            // 
            // lblInventoryManagementTitle
            // 
            this.lblInventoryManagementTitle.AutoSize = true;
            this.lblInventoryManagementTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryManagementTitle.Location = new System.Drawing.Point(80, 25);
            this.lblInventoryManagementTitle.Name = "lblInventoryManagementTitle";
            this.lblInventoryManagementTitle.Size = new System.Drawing.Size(349, 34);
            this.lblInventoryManagementTitle.TabIndex = 0;
            this.lblInventoryManagementTitle.Text = "Inventory Management";
            // 
            // lblDescriptionOfSearch
            // 
            this.lblDescriptionOfSearch.AutoSize = true;
            this.lblDescriptionOfSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionOfSearch.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDescriptionOfSearch.Location = new System.Drawing.Point(296, 14);
            this.lblDescriptionOfSearch.Name = "lblDescriptionOfSearch";
            this.lblDescriptionOfSearch.Size = new System.Drawing.Size(143, 18);
            this.lblDescriptionOfSearch.TabIndex = 4;
            this.lblDescriptionOfSearch.Text = "Search By Name";
            // 
            // InventoryMannagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlInventoryNav);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryMannagement";
            this.Size = new System.Drawing.Size(1255, 870);
            this.Load += new System.EventHandler(this.InventoryMannagement_Load);
            this.pnlInventoryNav.ResumeLayout(false);
            this.pnlInventoryNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimageInventory)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlStockValue.ResumeLayout(false);
            this.pnlStockValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValueIcon)).EndInit();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningIcon)).EndInit();
            this.pnlTotalAsset.ResumeLayout(false);
            this.pnlTotalAsset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInventoryNav;
        private System.Windows.Forms.TextBox txtInventorySearch;
        private System.Windows.Forms.Label lblInventoryManagementName;
        private System.Windows.Forms.Label lblInventoryTitle;
        private System.Windows.Forms.PictureBox pbEmployeeMimageInventory;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblInventoryManagementTitle;
        private System.Windows.Forms.Label lblInventorySubtitle;
        private System.Windows.Forms.Panel pnlTotalAsset;
        private System.Windows.Forms.PictureBox pbAvgSales;
        private System.Windows.Forms.Label lblActiveSubscript;
        private System.Windows.Forms.Label lblTotalAsset;
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
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQTY;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Label lblDescriptionOfSearch;
    }
}
