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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCustomers));
            this.pnlAllCustomers = new System.Windows.Forms.Panel();
            this.dgvAllCustomers = new System.Windows.Forms.DataGridView();
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
            this.pnlFleetCount = new System.Windows.Forms.Panel();
            this.pbFleetpic = new System.Windows.Forms.PictureBox();
            this.lblVehicleSubscript = new System.Windows.Forms.Label();
            this.lblFleetCountValue = new System.Windows.Forms.Label();
            this.lblFleetCountTitle = new System.Windows.Forms.Label();
            this.clientIdentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fleetsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalbilling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAllCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).BeginInit();
            this.pnlAveragePurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgPurchaseIcon)).BeginInit();
            this.pnlTotalClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalClient)).BeginInit();
            this.pnlAllCustomersNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimageAllCustomer)).BeginInit();
            this.pnlFleetCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFleetpic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAllCustomers
            // 
            this.pnlAllCustomers.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlAllCustomers.Controls.Add(this.pnlFleetCount);
            this.pnlAllCustomers.Controls.Add(this.dgvAllCustomers);
            this.pnlAllCustomers.Controls.Add(this.pnlAveragePurchase);
            this.pnlAllCustomers.Controls.Add(this.pnlTotalClient);
            this.pnlAllCustomers.Controls.Add(this.lblAllCustomerSubtitle);
            this.pnlAllCustomers.Controls.Add(this.lblAllCustomerTitlehero);
            this.pnlAllCustomers.Location = new System.Drawing.Point(0, 72);
            this.pnlAllCustomers.Name = "pnlAllCustomers";
            this.pnlAllCustomers.Size = new System.Drawing.Size(1214, 592);
            this.pnlAllCustomers.TabIndex = 4;
            // 
            // dgvAllCustomers
            // 
            this.dgvAllCustomers.AllowUserToAddRows = false;
            this.dgvAllCustomers.AllowUserToDeleteRows = false;
            this.dgvAllCustomers.AllowUserToResizeRows = false;
            this.dgvAllCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCustomers.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdentity,
            this.status,
            this.fleetsize,
            this.totalbilling});
            this.dgvAllCustomers.Location = new System.Drawing.Point(75, 279);
            this.dgvAllCustomers.Name = "dgvAllCustomers";
            this.dgvAllCustomers.ReadOnly = true;
            this.dgvAllCustomers.RowHeadersWidth = 51;
            this.dgvAllCustomers.RowTemplate.Height = 24;
            this.dgvAllCustomers.Size = new System.Drawing.Size(1067, 310);
            this.dgvAllCustomers.TabIndex = 8;
            // 
            // pnlAveragePurchase
            // 
            this.pnlAveragePurchase.AllowDrop = true;
            this.pnlAveragePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlAveragePurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAveragePurchase.Controls.Add(this.pbAvgPurchaseIcon);
            this.pnlAveragePurchase.Controls.Add(this.lblAvgPurchaseValue);
            this.pnlAveragePurchase.Controls.Add(this.lblAvgPurchaseText);
            this.pnlAveragePurchase.Location = new System.Drawing.Point(853, 85);
            this.pnlAveragePurchase.Name = "pnlAveragePurchase";
            this.pnlAveragePurchase.Size = new System.Drawing.Size(289, 151);
            this.pnlAveragePurchase.TabIndex = 4;
            // 
            // pbAvgPurchaseIcon
            // 
            this.pbAvgPurchaseIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbAvgPurchaseIcon.Image")));
            this.pbAvgPurchaseIcon.Location = new System.Drawing.Point(18, 18);
            this.pbAvgPurchaseIcon.Name = "pbAvgPurchaseIcon";
            this.pbAvgPurchaseIcon.Size = new System.Drawing.Size(50, 43);
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
            this.lblAvgPurchaseValue.Size = new System.Drawing.Size(121, 36);
            this.lblAvgPurchaseValue.TabIndex = 1;
            this.lblAvgPurchaseValue.Text = "$30.5K";
            this.lblAvgPurchaseValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgPurchaseText
            // 
            this.lblAvgPurchaseText.AutoSize = true;
            this.lblAvgPurchaseText.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPurchaseText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAvgPurchaseText.Location = new System.Drawing.Point(74, 28);
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
            this.pnlTotalClient.Location = new System.Drawing.Point(75, 85);
            this.pnlTotalClient.Name = "pnlTotalClient";
            this.pnlTotalClient.Size = new System.Drawing.Size(289, 151);
            this.pnlTotalClient.TabIndex = 3;
            // 
            // pbTotalClient
            // 
            this.pbTotalClient.Image = ((System.Drawing.Image)(resources.GetObject("pbTotalClient.Image")));
            this.pbTotalClient.Location = new System.Drawing.Point(18, 18);
            this.pbTotalClient.Name = "pbTotalClient";
            this.pbTotalClient.Size = new System.Drawing.Size(50, 43);
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
            this.lblTotalClientValue.Size = new System.Drawing.Size(100, 36);
            this.lblTotalClientValue.TabIndex = 1;
            this.lblTotalClientValue.Text = "1,288";
            this.lblTotalClientValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalClientTitle
            // 
            this.lblTotalClientTitle.AutoSize = true;
            this.lblTotalClientTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTotalClientTitle.Location = new System.Drawing.Point(74, 28);
            this.lblTotalClientTitle.Name = "lblTotalClientTitle";
            this.lblTotalClientTitle.Size = new System.Drawing.Size(159, 28);
            this.lblTotalClientTitle.TabIndex = 0;
            this.lblTotalClientTitle.Text = "Total Client";
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
            this.lblAllCustomerTitlehero.Location = new System.Drawing.Point(15, 19);
            this.lblAllCustomerTitlehero.Name = "lblAllCustomerTitlehero";
            this.lblAllCustomerTitlehero.Size = new System.Drawing.Size(190, 34);
            this.lblAllCustomerTitlehero.TabIndex = 0;
            this.lblAllCustomerTitlehero.Text = "Total Clients";
            // 
            // pnlAllCustomersNav
            // 
            this.pnlAllCustomersNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.pnlAllCustomersNav.Controls.Add(this.btnAllCustomerSearchButton);
            this.pnlAllCustomersNav.Controls.Add(this.txtAllCustomerSearch);
            this.pnlAllCustomersNav.Controls.Add(this.lblAllCustomerName);
            this.pnlAllCustomersNav.Controls.Add(this.lblAllCustomersTitle);
            this.pnlAllCustomersNav.Controls.Add(this.pbEmployeeMimageAllCustomer);
            this.pnlAllCustomersNav.Location = new System.Drawing.Point(0, 0);
            this.pnlAllCustomersNav.Name = "pnlAllCustomersNav";
            this.pnlAllCustomersNav.Size = new System.Drawing.Size(1214, 74);
            this.pnlAllCustomersNav.TabIndex = 5;
            // 
            // btnAllCustomerSearchButton
            // 
            this.btnAllCustomerSearchButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCustomerSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("btnAllCustomerSearchButton.Image")));
            this.btnAllCustomerSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllCustomerSearchButton.Location = new System.Drawing.Point(553, 20);
            this.btnAllCustomerSearchButton.Name = "btnAllCustomerSearchButton";
            this.btnAllCustomerSearchButton.Size = new System.Drawing.Size(130, 30);
            this.btnAllCustomerSearchButton.TabIndex = 4;
            this.btnAllCustomerSearchButton.Text = "Search";
            this.btnAllCustomerSearchButton.UseVisualStyleBackColor = true;
            // 
            // txtAllCustomerSearch
            // 
            this.txtAllCustomerSearch.Location = new System.Drawing.Point(264, 20);
            this.txtAllCustomerSearch.Multiline = true;
            this.txtAllCustomerSearch.Name = "txtAllCustomerSearch";
            this.txtAllCustomerSearch.Size = new System.Drawing.Size(294, 30);
            this.txtAllCustomerSearch.TabIndex = 3;
            // 
            // lblAllCustomerName
            // 
            this.lblAllCustomerName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCustomerName.ForeColor = System.Drawing.Color.Brown;
            this.lblAllCustomerName.Location = new System.Drawing.Point(1042, 20);
            this.lblAllCustomerName.Name = "lblAllCustomerName";
            this.lblAllCustomerName.Size = new System.Drawing.Size(88, 25);
            this.lblAllCustomerName.TabIndex = 2;
            this.lblAllCustomerName.Text = "ADMIN";
            this.lblAllCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllCustomersTitle
            // 
            this.lblAllCustomersTitle.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllCustomersTitle.Location = new System.Drawing.Point(16, 20);
            this.lblAllCustomersTitle.Name = "lblAllCustomersTitle";
            this.lblAllCustomersTitle.Size = new System.Drawing.Size(225, 35);
            this.lblAllCustomersTitle.TabIndex = 1;
            this.lblAllCustomersTitle.Text = "ALL CUSTOMERS";
            this.lblAllCustomersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbEmployeeMimageAllCustomer
            // 
            this.pbEmployeeMimageAllCustomer.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployeeMimageAllCustomer.Image")));
            this.pbEmployeeMimageAllCustomer.Location = new System.Drawing.Point(1136, 15);
            this.pbEmployeeMimageAllCustomer.Name = "pbEmployeeMimageAllCustomer";
            this.pbEmployeeMimageAllCustomer.Size = new System.Drawing.Size(54, 35);
            this.pbEmployeeMimageAllCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployeeMimageAllCustomer.TabIndex = 0;
            this.pbEmployeeMimageAllCustomer.TabStop = false;
            // 
            // pnlFleetCount
            // 
            this.pnlFleetCount.AllowDrop = true;
            this.pnlFleetCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlFleetCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFleetCount.Controls.Add(this.pbFleetpic);
            this.pnlFleetCount.Controls.Add(this.lblVehicleSubscript);
            this.pnlFleetCount.Controls.Add(this.lblFleetCountValue);
            this.pnlFleetCount.Controls.Add(this.lblFleetCountTitle);
            this.pnlFleetCount.Location = new System.Drawing.Point(463, 85);
            this.pnlFleetCount.Name = "pnlFleetCount";
            this.pnlFleetCount.Size = new System.Drawing.Size(289, 151);
            this.pnlFleetCount.TabIndex = 4;
            // 
            // pbFleetpic
            // 
            this.pbFleetpic.Image = ((System.Drawing.Image)(resources.GetObject("pbFleetpic.Image")));
            this.pbFleetpic.Location = new System.Drawing.Point(18, 18);
            this.pbFleetpic.Name = "pbFleetpic";
            this.pbFleetpic.Size = new System.Drawing.Size(50, 43);
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
            this.lblFleetCountValue.Size = new System.Drawing.Size(100, 36);
            this.lblFleetCountValue.TabIndex = 1;
            this.lblFleetCountValue.Text = "1,288";
            this.lblFleetCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFleetCountTitle
            // 
            this.lblFleetCountTitle.AutoSize = true;
            this.lblFleetCountTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFleetCountTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFleetCountTitle.Location = new System.Drawing.Point(74, 28);
            this.lblFleetCountTitle.Name = "lblFleetCountTitle";
            this.lblFleetCountTitle.Size = new System.Drawing.Size(158, 28);
            this.lblFleetCountTitle.TabIndex = 0;
            this.lblFleetCountTitle.Text = "Fleet Count";
            this.lblFleetCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientIdentity
            // 
            this.clientIdentity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clientIdentity.HeaderText = "Client Identity";
            this.clientIdentity.MinimumWidth = 6;
            this.clientIdentity.Name = "clientIdentity";
            this.clientIdentity.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // fleetsize
            // 
            this.fleetsize.HeaderText = "Fleet Size";
            this.fleetsize.MinimumWidth = 6;
            this.fleetsize.Name = "fleetsize";
            this.fleetsize.ReadOnly = true;
            this.fleetsize.ToolTipText = "Number of Vehicles";
            // 
            // totalbilling
            // 
            this.totalbilling.HeaderText = "Total Billing";
            this.totalbilling.MinimumWidth = 6;
            this.totalbilling.Name = "totalbilling";
            this.totalbilling.ReadOnly = true;
            // 
            // AllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAllCustomersNav);
            this.Controls.Add(this.pnlAllCustomers);
            this.Name = "AllCustomers";
            this.Size = new System.Drawing.Size(1214, 664);
            this.pnlAllCustomers.ResumeLayout(false);
            this.pnlAllCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomers)).EndInit();
            this.pnlAveragePurchase.ResumeLayout(false);
            this.pnlAveragePurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvgPurchaseIcon)).EndInit();
            this.pnlTotalClient.ResumeLayout(false);
            this.pnlTotalClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalClient)).EndInit();
            this.pnlAllCustomersNav.ResumeLayout(false);
            this.pnlAllCustomersNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimageAllCustomer)).EndInit();
            this.pnlFleetCount.ResumeLayout(false);
            this.pnlFleetCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFleetpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAllCustomers;
        private System.Windows.Forms.DataGridView dgvAllCustomers;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn fleetsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalbilling;
    }
}
