namespace AutoCare_Pro
{
    partial class Full_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Full_Invoice));
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInvoiceId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlVehicleDetails = new System.Windows.Forms.Panel();
            this.lblColorShow = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.pcbLicensePlate = new System.Windows.Forms.PictureBox();
            this.pcbVehicle = new System.Windows.Forms.PictureBox();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblPlateNumberHolder = new System.Windows.Forms.Label();
            this.lblVehicleYear = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblModelHolder = new System.Windows.Forms.Label();
            this.lblVehicleProfile = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.lblService = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblGrand = new System.Windows.Forms.Label();
            this.lblGrandTotalShow = new System.Windows.Forms.Label();
            this.lblTaxShow = new System.Windows.Forms.Label();
            this.lblSubTotalShow = new System.Windows.Forms.Label();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPartData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPartTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlTopTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlVehicleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLicensePlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pnlTopTitle.Controls.Add(this.lblDescription);
            this.pnlTopTitle.Controls.Add(this.lblTitle);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(869, 76);
            this.pnlTopTitle.TabIndex = 21;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(40, 43);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(636, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Invoice Details View for displaying customer billing information, invoice items, " +
    "totals and taxes.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(38, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Invoice Details";
            // 
            // lblInvoiceId
            // 
            this.lblInvoiceId.AutoSize = true;
            this.lblInvoiceId.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceId.Location = new System.Drawing.Point(38, 89);
            this.lblInvoiceId.Name = "lblInvoiceId";
            this.lblInvoiceId.Size = new System.Drawing.Size(167, 25);
            this.lblInvoiceId.TabIndex = 22;
            this.lblInvoiceId.Text = "Invoice ID: #";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblBillTitle);
            this.panel1.Location = new System.Drawing.Point(43, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 144);
            this.panel1.TabIndex = 23;
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTitle.Location = new System.Drawing.Point(13, 10);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(56, 16);
            this.lblBillTitle.TabIndex = 0;
            this.lblBillTitle.Text = "Billed To";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(13, 56);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(117, 18);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 77);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 98);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 18);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // pnlVehicleDetails
            // 
            this.pnlVehicleDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVehicleDetails.BackColor = System.Drawing.Color.White;
            this.pnlVehicleDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVehicleDetails.Controls.Add(this.lblColorShow);
            this.pnlVehicleDetails.Controls.Add(this.lblColor);
            this.pnlVehicleDetails.Controls.Add(this.pcbLicensePlate);
            this.pnlVehicleDetails.Controls.Add(this.pcbVehicle);
            this.pnlVehicleDetails.Controls.Add(this.lblPlateNumber);
            this.pnlVehicleDetails.Controls.Add(this.lblPlateNumberHolder);
            this.pnlVehicleDetails.Controls.Add(this.lblVehicleYear);
            this.pnlVehicleDetails.Controls.Add(this.lblYear);
            this.pnlVehicleDetails.Controls.Add(this.lblModel);
            this.pnlVehicleDetails.Controls.Add(this.lblModelHolder);
            this.pnlVehicleDetails.Controls.Add(this.lblVehicleProfile);
            this.pnlVehicleDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlVehicleDetails.Location = new System.Drawing.Point(285, 126);
            this.pnlVehicleDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVehicleDetails.Name = "pnlVehicleDetails";
            this.pnlVehicleDetails.Size = new System.Drawing.Size(300, 144);
            this.pnlVehicleDetails.TabIndex = 24;
            // 
            // lblColorShow
            // 
            this.lblColorShow.AutoSize = true;
            this.lblColorShow.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorShow.Location = new System.Drawing.Point(185, 124);
            this.lblColorShow.Name = "lblColorShow";
            this.lblColorShow.Size = new System.Drawing.Size(41, 13);
            this.lblColorShow.TabIndex = 13;
            this.lblColorShow.Text = "Color";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.DimGray;
            this.lblColor.Location = new System.Drawing.Point(57, 124);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(42, 14);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "Color";
            // 
            // pcbLicensePlate
            // 
            this.pcbLicensePlate.Image = ((System.Drawing.Image)(resources.GetObject("pcbLicensePlate.Image")));
            this.pcbLicensePlate.Location = new System.Drawing.Point(14, 89);
            this.pcbLicensePlate.Name = "pcbLicensePlate";
            this.pcbLicensePlate.Size = new System.Drawing.Size(38, 33);
            this.pcbLicensePlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLicensePlate.TabIndex = 11;
            this.pcbLicensePlate.TabStop = false;
            // 
            // pcbVehicle
            // 
            this.pcbVehicle.Image = ((System.Drawing.Image)(resources.GetObject("pcbVehicle.Image")));
            this.pcbVehicle.Location = new System.Drawing.Point(13, 41);
            this.pcbVehicle.Name = "pcbVehicle";
            this.pcbVehicle.Size = new System.Drawing.Size(38, 33);
            this.pcbVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVehicle.TabIndex = 10;
            this.pcbVehicle.TabStop = false;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNumber.Location = new System.Drawing.Point(185, 98);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(95, 13);
            this.lblPlateNumber.TabIndex = 9;
            this.lblPlateNumber.Text = "Plate Number";
            // 
            // lblPlateNumberHolder
            // 
            this.lblPlateNumberHolder.AutoSize = true;
            this.lblPlateNumberHolder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNumberHolder.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlateNumberHolder.Location = new System.Drawing.Point(58, 98);
            this.lblPlateNumberHolder.Name = "lblPlateNumberHolder";
            this.lblPlateNumberHolder.Size = new System.Drawing.Size(97, 14);
            this.lblPlateNumberHolder.TabIndex = 8;
            this.lblPlateNumberHolder.Text = "Plate Number";
            // 
            // lblVehicleYear
            // 
            this.lblVehicleYear.AutoSize = true;
            this.lblVehicleYear.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleYear.Location = new System.Drawing.Point(215, 65);
            this.lblVehicleYear.Name = "lblVehicleYear";
            this.lblVehicleYear.Size = new System.Drawing.Size(75, 13);
            this.lblVehicleYear.TabIndex = 7;
            this.lblVehicleYear.Text = "Year  here";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DimGray;
            this.lblYear.Location = new System.Drawing.Point(215, 41);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 17);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(57, 65);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(155, 13);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Model will appear here";
            // 
            // lblModelHolder
            // 
            this.lblModelHolder.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelHolder.ForeColor = System.Drawing.Color.DimGray;
            this.lblModelHolder.Location = new System.Drawing.Point(57, 41);
            this.lblModelHolder.Name = "lblModelHolder";
            this.lblModelHolder.Size = new System.Drawing.Size(76, 24);
            this.lblModelHolder.TabIndex = 4;
            this.lblModelHolder.Text = "Model";
            // 
            // lblVehicleProfile
            // 
            this.lblVehicleProfile.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleProfile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleProfile.Location = new System.Drawing.Point(13, 9);
            this.lblVehicleProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleProfile.Name = "lblVehicleProfile";
            this.lblVehicleProfile.Size = new System.Drawing.Size(153, 22);
            this.lblVehicleProfile.TabIndex = 0;
            this.lblVehicleProfile.Text = "Vehicle Details\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblEmploye);
            this.panel2.Controls.Add(this.lblCreatedAt);
            this.panel2.Controls.Add(this.lblCustomerId);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Location = new System.Drawing.Point(592, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 144);
            this.panel2.TabIndex = 24;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedAt.Location = new System.Drawing.Point(13, 83);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(116, 18);
            this.lblCreatedAt.TabIndex = 3;
            this.lblCreatedAt.Text = "Invoice Date : ";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(13, 59);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(114, 18);
            this.lblCustomerId.TabIndex = 2;
            this.lblCustomerId.Text = "Customer ID : ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(13, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(99, 18);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Invoice ID : ";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(13, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(73, 16);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Invoice Info";
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvService.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDescription,
            this.clmnHours,
            this.clmnRate,
            this.clmnTotal});
            this.dgvService.Location = new System.Drawing.Point(43, 319);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.Size = new System.Drawing.Size(794, 207);
            this.dgvService.TabIndex = 25;
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParts.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnPartData,
            this.clmnQty,
            this.clmnPrice,
            this.clmnPartTotal});
            this.dgvParts.Location = new System.Drawing.Point(43, 575);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.Size = new System.Drawing.Size(794, 181);
            this.dgvParts.TabIndex = 26;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(38, 282);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(186, 25);
            this.lblService.TabIndex = 27;
            this.lblService.Text = "Service Details";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParts.Location = new System.Drawing.Point(38, 538);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(161, 25);
            this.lblParts.TabIndex = 28;
            this.lblParts.Text = "Parts Details";
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmploye.Location = new System.Drawing.Point(13, 107);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(115, 18);
            this.lblEmploye.TabIndex = 4;
            this.lblEmploye.Text = "Employee ID : ";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubTotal.Location = new System.Drawing.Point(591, 771);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(78, 14);
            this.lblSubTotal.TabIndex = 14;
            this.lblSubTotal.Text = "Sub Total :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.DimGray;
            this.lblTax.Location = new System.Drawing.Point(591, 797);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(94, 14);
            this.lblTax.TabIndex = 29;
            this.lblTax.Text = "Tax Amount :";
            // 
            // lblGrand
            // 
            this.lblGrand.AutoSize = true;
            this.lblGrand.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrand.ForeColor = System.Drawing.Color.DimGray;
            this.lblGrand.Location = new System.Drawing.Point(591, 823);
            this.lblGrand.Name = "lblGrand";
            this.lblGrand.Size = new System.Drawing.Size(93, 14);
            this.lblGrand.TabIndex = 30;
            this.lblGrand.Text = "Grand Total :";
            // 
            // lblGrandTotalShow
            // 
            this.lblGrandTotalShow.AutoSize = true;
            this.lblGrandTotalShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalShow.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotalShow.Location = new System.Drawing.Point(732, 823);
            this.lblGrandTotalShow.Name = "lblGrandTotalShow";
            this.lblGrandTotalShow.Size = new System.Drawing.Size(19, 14);
            this.lblGrandTotalShow.TabIndex = 33;
            this.lblGrandTotalShow.Text = "$ ";
            // 
            // lblTaxShow
            // 
            this.lblTaxShow.AutoSize = true;
            this.lblTaxShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxShow.ForeColor = System.Drawing.Color.Black;
            this.lblTaxShow.Location = new System.Drawing.Point(732, 797);
            this.lblTaxShow.Name = "lblTaxShow";
            this.lblTaxShow.Size = new System.Drawing.Size(19, 14);
            this.lblTaxShow.TabIndex = 32;
            this.lblTaxShow.Text = "$ ";
            // 
            // lblSubTotalShow
            // 
            this.lblSubTotalShow.AutoSize = true;
            this.lblSubTotalShow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalShow.ForeColor = System.Drawing.Color.Black;
            this.lblSubTotalShow.Location = new System.Drawing.Point(732, 771);
            this.lblSubTotalShow.Name = "lblSubTotalShow";
            this.lblSubTotalShow.Size = new System.Drawing.Size(19, 14);
            this.lblSubTotalShow.TabIndex = 31;
            this.lblSubTotalShow.Text = "$ ";
            // 
            // clmnDescription
            // 
            this.clmnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDescription.DataPropertyName = "description";
            this.clmnDescription.HeaderText = "Service Description";
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.ReadOnly = true;
            // 
            // clmnHours
            // 
            this.clmnHours.DataPropertyName = "hours";
            this.clmnHours.HeaderText = "Hours";
            this.clmnHours.Name = "clmnHours";
            this.clmnHours.ReadOnly = true;
            // 
            // clmnRate
            // 
            this.clmnRate.DataPropertyName = "rate";
            this.clmnRate.HeaderText = "Rate";
            this.clmnRate.Name = "clmnRate";
            this.clmnRate.ReadOnly = true;
            // 
            // clmnTotal
            // 
            this.clmnTotal.DataPropertyName = "total";
            this.clmnTotal.HeaderText = "Total";
            this.clmnTotal.Name = "clmnTotal";
            this.clmnTotal.ReadOnly = true;
            // 
            // clmnPartData
            // 
            this.clmnPartData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnPartData.DataPropertyName = "part_name";
            this.clmnPartData.HeaderText = "Part Name";
            this.clmnPartData.Name = "clmnPartData";
            this.clmnPartData.ReadOnly = true;
            // 
            // clmnQty
            // 
            this.clmnQty.DataPropertyName = "qty";
            this.clmnQty.HeaderText = "Qty";
            this.clmnQty.Name = "clmnQty";
            this.clmnQty.ReadOnly = true;
            // 
            // clmnPrice
            // 
            this.clmnPrice.DataPropertyName = "unit_price";
            this.clmnPrice.HeaderText = "Unit Price";
            this.clmnPrice.Name = "clmnPrice";
            this.clmnPrice.ReadOnly = true;
            // 
            // clmnPartTotal
            // 
            this.clmnPartTotal.DataPropertyName = "total";
            this.clmnPartTotal.HeaderText = "Total";
            this.clmnPartTotal.Name = "clmnPartTotal";
            this.clmnPartTotal.ReadOnly = true;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(379, 852);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(119, 32);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "Close";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Full_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(869, 896);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblGrandTotalShow);
            this.Controls.Add(this.lblTaxShow);
            this.Controls.Add(this.lblSubTotalShow);
            this.Controls.Add(this.lblGrand);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblParts);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlVehicleDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInvoiceId);
            this.Controls.Add(this.pnlTopTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Full_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Full_Invoice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Full_Invoice_FormClosed);
            this.Load += new System.EventHandler(this.Full_Invoice_Load);
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlVehicleDetails.ResumeLayout(false);
            this.pnlVehicleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLicensePlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVehicle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlVehicleDetails;
        private System.Windows.Forms.Label lblColorShow;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.PictureBox pcbLicensePlate;
        private System.Windows.Forms.PictureBox pcbVehicle;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblPlateNumberHolder;
        private System.Windows.Forms.Label lblVehicleYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblModelHolder;
        private System.Windows.Forms.Label lblVehicleProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblGrand;
        private System.Windows.Forms.Label lblGrandTotalShow;
        private System.Windows.Forms.Label lblTaxShow;
        private System.Windows.Forms.Label lblSubTotalShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPartData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPartTotal;
        private System.Windows.Forms.Button btnOk;
    }
}