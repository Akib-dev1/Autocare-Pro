namespace AutoCare_Pro
{
    partial class AllCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCustomers));
            this.pnlAllCustomers = new System.Windows.Forms.Panel();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFleetCount = new System.Windows.Forms.Panel();
            this.pbFleetpic = new System.Windows.Forms.PictureBox();
            this.lblVehicleSubscript = new System.Windows.Forms.Label();
            this.lblFleetCountValue = new System.Windows.Forms.Label();
            this.lblFleetCountTitle = new System.Windows.Forms.Label();
            this.pnlAveragePurchase = new System.Windows.Forms.Panel();
            this.pbAvgPurchaseIcon = new System.Windows.Forms.PictureBox();
            this.lblAvgPurchaseValue = new System.Windows.Forms.Label();
            this.lblAvgPurchaseText = new System.Windows.Forms.Label();
            this.pnlTotalClient = new System.Windows.Forms.Panel();
            this.pbTotalClient = new System.Windows.Forms.PictureBox();
            this.lblTotalClientValue = new System.Windows.Forms.Label();
            this.lblTotalClientTitle = new System.Windows.Forms.Label();
            this.lblAllCustomerSubtitle = new System.Windows.Forms.Label();
            this.lblAllCustomerTitlehero = new System.Windows.Forms.Label();
            this.pnlAllCustomersNav = new System.Windows.Forms.Panel();
            this.btnAllCustomerSearchButton = new System.Windows.Forms.Button();
            this.txtAllCustomerSearch = new System.Windows.Forms.TextBox();
            this.lblAllCustomerName = new System.Windows.Forms.Label();
            this.lblAllCustomersTitle = new System.Windows.Forms.Label();
            this.pbEmployeeMimageAllCustomer = new System.Windows.Forms.PictureBox();
            this.lblSearchByPhoneNumber = new System.Windows.Forms.Label();
            this.pnlAllCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.pnlFleetCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFleetpic)).BeginInit();
            this.pnlAveragePurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgPurchaseIcon)).BeginInit();
            this.pnlTotalClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalClient)).BeginInit();
            this.pnlAllCustomersNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimageAllCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAllCustomers
            // 
            this.pnlAllCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.pnlAllCustomers.Controls.Add(this.dgvCustomerList);
            this.pnlAllCustomers.Controls.Add(this.pnlFleetCount);
            this.pnlAllCustomers.Controls.Add(this.pnlAveragePurchase);
            this.pnlAllCustomers.Controls.Add(this.pnlTotalClient);
            this.pnlAllCustomers.Controls.Add(this.lblAllCustomerSubtitle);
            this.pnlAllCustomers.Controls.Add(this.lblAllCustomerTitlehero);
            this.pnlAllCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAllCustomers.Location = new System.Drawing.Point(0, 0);
            this.pnlAllCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAllCustomers.Name = "pnlAllCustomers";
            this.pnlAllCustomers.Size = new System.Drawing.Size(1255, 870);
            this.pnlAllCustomers.TabIndex = 4;
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(115)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCustomerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerList.ColumnHeadersHeight = 40;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.userName,
            this.Phone,
            this.Email,
            this.Address,
            this.VehicleModel,
            this.VehicleYear,
            this.Plate,
            this.Color});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(115)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerList.EnableHeadersVisualStyles = false;
            this.dgvCustomerList.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvCustomerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvCustomerList.Location = new System.Drawing.Point(99, 336);
            this.dgvCustomerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowHeadersWidth = 51;
            this.dgvCustomerList.RowTemplate.Height = 35;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(1069, 485);
            this.dgvCustomerList.TabIndex = 13;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customer_id";
            this.customerId.HeaderText = "ID";
            this.customerId.MinimumWidth = 6;
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "name";
            this.userName.HeaderText = "Name";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // VehicleModel
            // 
            this.VehicleModel.DataPropertyName = "vehicle_model";
            this.VehicleModel.HeaderText = "Vehicle Model";
            this.VehicleModel.MinimumWidth = 6;
            this.VehicleModel.Name = "VehicleModel";
            this.VehicleModel.ReadOnly = true;
            // 
            // VehicleYear
            // 
            this.VehicleYear.DataPropertyName = "vehicle_year";
            this.VehicleYear.HeaderText = "Vehicle Year";
            this.VehicleYear.MinimumWidth = 6;
            this.VehicleYear.Name = "VehicleYear";
            this.VehicleYear.ReadOnly = true;
            // 
            // Plate
            // 
            this.Plate.DataPropertyName = "vehicle_plate";
            this.Plate.HeaderText = "Plate";
            this.Plate.MinimumWidth = 6;
            this.Plate.Name = "Plate";
            this.Plate.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "vehicle_color";
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // pnlFleetCount
            // 
            this.pnlFleetCount.AllowDrop = true;
            this.pnlFleetCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFleetCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlFleetCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFleetCount.Controls.Add(this.pbFleetpic);
            this.pnlFleetCount.Controls.Add(this.lblVehicleSubscript);
            this.pnlFleetCount.Controls.Add(this.lblFleetCountValue);
            this.pnlFleetCount.Controls.Add(this.lblFleetCountTitle);
            this.pnlFleetCount.Location = new System.Drawing.Point(487, 146);
            this.pnlFleetCount.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlFleetCount.Name = "pnlFleetCount";
            this.pnlFleetCount.Size = new System.Drawing.Size(289, 150);
            this.pnlFleetCount.TabIndex = 4;
            // 
            // pbFleetpic
            // 
            this.pbFleetpic.Image = ((System.Drawing.Image)(resources.GetObject("pbFleetpic.Image")));
            this.pbFleetpic.Location = new System.Drawing.Point(19, 18);
            this.pbFleetpic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFleetpic.Name = "pbFleetpic";
            this.pbFleetpic.Size = new System.Drawing.Size(51, 43);
            this.pbFleetpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFleetpic.TabIndex = 3;
            this.pbFleetpic.TabStop = false;
            // 
            // lblVehicleSubscript
            // 
            this.lblVehicleSubscript.AutoSize = true;
            this.lblVehicleSubscript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleSubscript.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleSubscript.Location = new System.Drawing.Point(179, 102);
            this.lblVehicleSubscript.Name = "lblVehicleSubscript";
            this.lblVehicleSubscript.Size = new System.Drawing.Size(74, 18);
            this.lblVehicleSubscript.TabIndex = 2;
            this.lblVehicleSubscript.Text = "Vehicles";
            this.lblVehicleSubscript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFleetCountValue
            // 
            this.lblFleetCountValue.AutoSize = true;
            this.lblFleetCountValue.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFleetCountValue.Location = new System.Drawing.Point(73, 87);
            this.lblFleetCountValue.Name = "lblFleetCountValue";
            this.lblFleetCountValue.Size = new System.Drawing.Size(34, 36);
            this.lblFleetCountValue.TabIndex = 1;
            this.lblFleetCountValue.Text = "0";
            this.lblFleetCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFleetCountTitle
            // 
            this.lblFleetCountTitle.AutoSize = true;
            this.lblFleetCountTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFleetCountTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFleetCountTitle.Location = new System.Drawing.Point(81, 28);
            this.lblFleetCountTitle.Name = "lblFleetCountTitle";
            this.lblFleetCountTitle.Size = new System.Drawing.Size(158, 28);
            this.lblFleetCountTitle.TabIndex = 0;
            this.lblFleetCountTitle.Text = "Fleet Count";
            this.lblFleetCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAveragePurchase
            // 
            this.pnlAveragePurchase.AllowDrop = true;
            this.pnlAveragePurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAveragePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlAveragePurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAveragePurchase.Controls.Add(this.pbAvgPurchaseIcon);
            this.pnlAveragePurchase.Controls.Add(this.lblAvgPurchaseValue);
            this.pnlAveragePurchase.Controls.Add(this.lblAvgPurchaseText);
            this.pnlAveragePurchase.Location = new System.Drawing.Point(877, 146);
            this.pnlAveragePurchase.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlAveragePurchase.Name = "pnlAveragePurchase";
            this.pnlAveragePurchase.Size = new System.Drawing.Size(289, 150);
            this.pnlAveragePurchase.TabIndex = 4;
            // 
            // pbAvgPurchaseIcon
            // 
            this.pbAvgPurchaseIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbAvgPurchaseIcon.Image")));
            this.pbAvgPurchaseIcon.Location = new System.Drawing.Point(19, 18);
            this.pbAvgPurchaseIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvgPurchaseIcon.Name = "pbAvgPurchaseIcon";
            this.pbAvgPurchaseIcon.Size = new System.Drawing.Size(51, 43);
            this.pbAvgPurchaseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvgPurchaseIcon.TabIndex = 3;
            this.pbAvgPurchaseIcon.TabStop = false;
            // 
            // lblAvgPurchaseValue
            // 
            this.lblAvgPurchaseValue.AutoSize = true;
            this.lblAvgPurchaseValue.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPurchaseValue.Location = new System.Drawing.Point(89, 84);
            this.lblAvgPurchaseValue.Name = "lblAvgPurchaseValue";
            this.lblAvgPurchaseValue.Size = new System.Drawing.Size(53, 36);
            this.lblAvgPurchaseValue.TabIndex = 1;
            this.lblAvgPurchaseValue.Text = "$0";
            this.lblAvgPurchaseValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgPurchaseText
            // 
            this.lblAvgPurchaseText.AutoSize = true;
            this.lblAvgPurchaseText.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPurchaseText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvgPurchaseText.Location = new System.Drawing.Point(75, 26);
            this.lblAvgPurchaseText.Name = "lblAvgPurchaseText";
            this.lblAvgPurchaseText.Size = new System.Drawing.Size(187, 28);
            this.lblAvgPurchaseText.TabIndex = 0;
            this.lblAvgPurchaseText.Text = "Avg Purchase";
            this.lblAvgPurchaseText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalClient
            // 
            this.pnlTotalClient.AllowDrop = true;
            this.pnlTotalClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlTotalClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotalClient.Controls.Add(this.pbTotalClient);
            this.pnlTotalClient.Controls.Add(this.lblTotalClientValue);
            this.pnlTotalClient.Controls.Add(this.lblTotalClientTitle);
            this.pnlTotalClient.Location = new System.Drawing.Point(99, 146);
            this.pnlTotalClient.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlTotalClient.Name = "pnlTotalClient";
            this.pnlTotalClient.Size = new System.Drawing.Size(289, 150);
            this.pnlTotalClient.TabIndex = 3;
            // 
            // pbTotalClient
            // 
            this.pbTotalClient.Image = ((System.Drawing.Image)(resources.GetObject("pbTotalClient.Image")));
            this.pbTotalClient.Location = new System.Drawing.Point(19, 18);
            this.pbTotalClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTotalClient.Name = "pbTotalClient";
            this.pbTotalClient.Size = new System.Drawing.Size(51, 43);
            this.pbTotalClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTotalClient.TabIndex = 3;
            this.pbTotalClient.TabStop = false;
            // 
            // lblTotalClientValue
            // 
            this.lblTotalClientValue.AutoSize = true;
            this.lblTotalClientValue.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientValue.Location = new System.Drawing.Point(87, 87);
            this.lblTotalClientValue.Name = "lblTotalClientValue";
            this.lblTotalClientValue.Size = new System.Drawing.Size(34, 36);
            this.lblTotalClientValue.TabIndex = 1;
            this.lblTotalClientValue.Text = "0";
            this.lblTotalClientValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalClientTitle
            // 
            this.lblTotalClientTitle.AutoSize = true;
            this.lblTotalClientTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalClientTitle.Location = new System.Drawing.Point(75, 26);
            this.lblTotalClientTitle.Name = "lblTotalClientTitle";
            this.lblTotalClientTitle.Size = new System.Drawing.Size(173, 28);
            this.lblTotalClientTitle.TabIndex = 0;
            this.lblTotalClientTitle.Text = "Total Clients";
            this.lblTotalClientTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllCustomerSubtitle
            // 
            this.lblAllCustomerSubtitle.AutoSize = true;
            this.lblAllCustomerSubtitle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCustomerSubtitle.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblAllCustomerSubtitle.Location = new System.Drawing.Point(17, 53);
            this.lblAllCustomerSubtitle.Name = "lblAllCustomerSubtitle";
            this.lblAllCustomerSubtitle.Size = new System.Drawing.Size(247, 16);
            this.lblAllCustomerSubtitle.TabIndex = 1;
            this.lblAllCustomerSubtitle.Text = "Directory of calibrated client relationships.";
            // 
            // lblAllCustomerTitlehero
            // 
            this.lblAllCustomerTitlehero.AutoSize = true;
            this.lblAllCustomerTitlehero.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCustomerTitlehero.Location = new System.Drawing.Point(15, 18);
            this.lblAllCustomerTitlehero.Name = "lblAllCustomerTitlehero";
            this.lblAllCustomerTitlehero.Size = new System.Drawing.Size(190, 34);
            this.lblAllCustomerTitlehero.TabIndex = 0;
            this.lblAllCustomerTitlehero.Text = "Total Clients";
            // 
            // pnlAllCustomersNav
            // 
            this.pnlAllCustomersNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.pnlAllCustomersNav.Controls.Add(this.lblSearchByPhoneNumber);
            this.pnlAllCustomersNav.Controls.Add(this.btnAllCustomerSearchButton);
            this.pnlAllCustomersNav.Controls.Add(this.txtAllCustomerSearch);
            this.pnlAllCustomersNav.Controls.Add(this.lblAllCustomerName);
            this.pnlAllCustomersNav.Controls.Add(this.lblAllCustomersTitle);
            this.pnlAllCustomersNav.Controls.Add(this.pbEmployeeMimageAllCustomer);
            this.pnlAllCustomersNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAllCustomersNav.Location = new System.Drawing.Point(0, 0);
            this.pnlAllCustomersNav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAllCustomersNav.Name = "pnlAllCustomersNav";
            this.pnlAllCustomersNav.Size = new System.Drawing.Size(1255, 74);
            this.pnlAllCustomersNav.TabIndex = 5;
            // 
            // btnAllCustomerSearchButton
            // 
            this.btnAllCustomerSearchButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCustomerSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("btnAllCustomerSearchButton.Image")));
            this.btnAllCustomerSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCustomerSearchButton.Location = new System.Drawing.Point(552, 17);
            this.btnAllCustomerSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllCustomerSearchButton.Name = "btnAllCustomerSearchButton";
            this.btnAllCustomerSearchButton.Size = new System.Drawing.Size(131, 34);
            this.btnAllCustomerSearchButton.TabIndex = 4;
            this.btnAllCustomerSearchButton.Text = "Search";
            this.btnAllCustomerSearchButton.UseVisualStyleBackColor = true;
            this.btnAllCustomerSearchButton.Click += new System.EventHandler(this.btnAllCustomerSearchButton_Click);
            // 
            // txtAllCustomerSearch
            // 
            this.txtAllCustomerSearch.Location = new System.Drawing.Point(264, 20);
            this.txtAllCustomerSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAllCustomerSearch.Multiline = true;
            this.txtAllCustomerSearch.Name = "txtAllCustomerSearch";
            this.txtAllCustomerSearch.Size = new System.Drawing.Size(295, 29);
            this.txtAllCustomerSearch.TabIndex = 3;
            // 
            // lblAllCustomerName
            // 
            this.lblAllCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllCustomerName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCustomerName.ForeColor = System.Drawing.Color.Brown;
            this.lblAllCustomerName.Location = new System.Drawing.Point(1043, 22);
            this.lblAllCustomerName.Name = "lblAllCustomerName";
            this.lblAllCustomerName.Size = new System.Drawing.Size(88, 25);
            this.lblAllCustomerName.TabIndex = 2;
            this.lblAllCustomerName.Text = "ADMIN";
            this.lblAllCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllCustomersTitle
            // 
            this.lblAllCustomersTitle.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCustomersTitle.Location = new System.Drawing.Point(16, 17);
            this.lblAllCustomersTitle.Name = "lblAllCustomersTitle";
            this.lblAllCustomersTitle.Size = new System.Drawing.Size(225, 34);
            this.lblAllCustomersTitle.TabIndex = 1;
            this.lblAllCustomersTitle.Text = "ALL CUSTOMERS";
            this.lblAllCustomersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmployeeMimageAllCustomer
            // 
            this.pbEmployeeMimageAllCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbEmployeeMimageAllCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployeeMimageAllCustomer.Image")));
            this.pbEmployeeMimageAllCustomer.Location = new System.Drawing.Point(1136, 17);
            this.pbEmployeeMimageAllCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEmployeeMimageAllCustomer.Name = "pbEmployeeMimageAllCustomer";
            this.pbEmployeeMimageAllCustomer.Size = new System.Drawing.Size(53, 34);
            this.pbEmployeeMimageAllCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployeeMimageAllCustomer.TabIndex = 0;
            this.pbEmployeeMimageAllCustomer.TabStop = false;
            // 
            // lblSearchByPhoneNumber
            // 
            this.lblSearchByPhoneNumber.AutoSize = true;
            this.lblSearchByPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSearchByPhoneNumber.Location = new System.Drawing.Point(270, 0);
            this.lblSearchByPhoneNumber.Name = "lblSearchByPhoneNumber";
            this.lblSearchByPhoneNumber.Size = new System.Drawing.Size(200, 18);
            this.lblSearchByPhoneNumber.TabIndex = 6;
            this.lblSearchByPhoneNumber.Text = "Search by Phone Number";
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAllCustomersNav);
            this.Controls.Add(this.pnlAllCustomers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllCustomers";
            this.Size = new System.Drawing.Size(1255, 870);
            this.Load += new System.EventHandler(this.AllCustomers_Load);
            this.pnlAllCustomers.ResumeLayout(false);
            this.pnlAllCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.pnlFleetCount.ResumeLayout(false);
            this.pnlFleetCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFleetpic)).EndInit();
            this.pnlAveragePurchase.ResumeLayout(false);
            this.pnlAveragePurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgPurchaseIcon)).EndInit();
            this.pnlTotalClient.ResumeLayout(false);
            this.pnlTotalClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalClient)).EndInit();
            this.pnlAllCustomersNav.ResumeLayout(false);
            this.pnlAllCustomersNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimageAllCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAllCustomers;
        private System.Windows.Forms.Panel pnlAveragePurchase;
        private System.Windows.Forms.PictureBox pbAvgPurchaseIcon;
        private System.Windows.Forms.Label lblAvgPurchaseValue;
        private System.Windows.Forms.Label lblAvgPurchaseText;
        private System.Windows.Forms.Panel pnlTotalClient;
        private System.Windows.Forms.PictureBox pbTotalClient;
        private System.Windows.Forms.Label lblTotalClientValue;
        private System.Windows.Forms.Label lblTotalClientTitle;
        private System.Windows.Forms.Label lblAllCustomerSubtitle;
        private System.Windows.Forms.Label lblAllCustomerTitlehero;
        private System.Windows.Forms.Panel pnlAllCustomersNav;
        private System.Windows.Forms.Button btnAllCustomerSearchButton;
        private System.Windows.Forms.TextBox txtAllCustomerSearch;
        private System.Windows.Forms.Label lblAllCustomerName;
        private System.Windows.Forms.Label lblAllCustomersTitle;
        private System.Windows.Forms.PictureBox pbEmployeeMimageAllCustomer;
        private System.Windows.Forms.Panel pnlFleetCount;
        private System.Windows.Forms.PictureBox pbFleetpic;
        private System.Windows.Forms.Label lblVehicleSubscript;
        private System.Windows.Forms.Label lblFleetCountValue;
        private System.Windows.Forms.Label lblFleetCountTitle;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.Label lblSearchByPhoneNumber;
    }
}
