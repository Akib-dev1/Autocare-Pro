namespace AutoCare_Pro
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEmployeeNav = new System.Windows.Forms.Panel();
            this.btnEmployeeSearchButton = new System.Windows.Forms.Button();
            this.txtEmployeeSearch = new System.Windows.Forms.TextBox();
            this.lblReportName = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.pbEmployeeMimage = new System.Windows.Forms.PictureBox();
            this.pnlTotalPersonnel = new System.Windows.Forms.Panel();
            this.pbPersonnel = new System.Windows.Forms.PictureBox();
            this.lblTotalPersonnel = new System.Windows.Forms.Label();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblReportSalesAnalytics = new System.Windows.Forms.Label();
            this.pnlShopEfficiency = new System.Windows.Forms.Panel();
            this.pbEfficiencyIcon = new System.Windows.Forms.PictureBox();
            this.lblEfficiencyText = new System.Windows.Forms.Label();
            this.lblEfficiencyTitle = new System.Windows.Forms.Label();
            this.pnlActivejobs = new System.Windows.Forms.Panel();
            this.pbActiveJobIcon = new System.Windows.Forms.PictureBox();
            this.lblActiveJobs = new System.Windows.Forms.Label();
            this.lblActiveJobTitle = new System.Windows.Forms.Label();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.pnlEmployeeNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimage)).BeginInit();
            this.pnlTotalPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnel)).BeginInit();
            this.pnlShopEfficiency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEfficiencyIcon)).BeginInit();
            this.pnlActivejobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActiveJobIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEmployeeNav
            // 
            this.pnlEmployeeNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.pnlEmployeeNav.Controls.Add(this.btnEmployeeSearchButton);
            this.pnlEmployeeNav.Controls.Add(this.txtEmployeeSearch);
            this.pnlEmployeeNav.Controls.Add(this.lblReportName);
            this.pnlEmployeeNav.Controls.Add(this.lblReportTitle);
            this.pnlEmployeeNav.Controls.Add(this.pbEmployeeMimage);
            this.pnlEmployeeNav.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeNav.Name = "pnlEmployeeNav";
            this.pnlEmployeeNav.Size = new System.Drawing.Size(1213, 70);
            this.pnlEmployeeNav.TabIndex = 1;
            // 
            // btnEmployeeSearchButton
            // 
            this.btnEmployeeSearchButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeSearchButton.Image")));
            this.btnEmployeeSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployeeSearchButton.Location = new System.Drawing.Point(534, 20);
            this.btnEmployeeSearchButton.Name = "btnEmployeeSearchButton";
            this.btnEmployeeSearchButton.Size = new System.Drawing.Size(130, 30);
            this.btnEmployeeSearchButton.TabIndex = 4;
            this.btnEmployeeSearchButton.Text = "Search";
            this.btnEmployeeSearchButton.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeSearch
            // 
            this.txtEmployeeSearch.Location = new System.Drawing.Point(242, 20);
            this.txtEmployeeSearch.Multiline = true;
            this.txtEmployeeSearch.Name = "txtEmployeeSearch";
            this.txtEmployeeSearch.Size = new System.Drawing.Size(294, 30);
            this.txtEmployeeSearch.TabIndex = 3;
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
            this.lblReportName.Click += new System.EventHandler(this.lblReportName_Click);
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(16, 15);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(220, 35);
            this.lblReportTitle.TabIndex = 1;
            this.lblReportTitle.Text = "Employee Management";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pnlTotalPersonnel
            // 
            this.pnlTotalPersonnel.AllowDrop = true;
            this.pnlTotalPersonnel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlTotalPersonnel.Controls.Add(this.pbPersonnel);
            this.pnlTotalPersonnel.Controls.Add(this.lblTotalPersonnel);
            this.pnlTotalPersonnel.Controls.Add(this.lblPersonnel);
            this.pnlTotalPersonnel.Location = new System.Drawing.Point(81, 172);
            this.pnlTotalPersonnel.Name = "pnlTotalPersonnel";
            this.pnlTotalPersonnel.Size = new System.Drawing.Size(252, 151);
            this.pnlTotalPersonnel.TabIndex = 3;
            this.pnlTotalPersonnel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAvgSales_Paint);
            // 
            // pbPersonnel
            // 
            this.pbPersonnel.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonnel.Image")));
            this.pbPersonnel.Location = new System.Drawing.Point(22, 76);
            this.pbPersonnel.Name = "pbPersonnel";
            this.pbPersonnel.Size = new System.Drawing.Size(47, 44);
            this.pbPersonnel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonnel.TabIndex = 2;
            this.pbPersonnel.TabStop = false;
            // 
            // lblTotalPersonnel
            // 
            this.lblTotalPersonnel.AutoSize = true;
            this.lblTotalPersonnel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPersonnel.Location = new System.Drawing.Point(109, 84);
            this.lblTotalPersonnel.Name = "lblTotalPersonnel";
            this.lblTotalPersonnel.Size = new System.Drawing.Size(53, 36);
            this.lblTotalPersonnel.TabIndex = 1;
            this.lblTotalPersonnel.Text = "12";
            this.lblTotalPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonnel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPersonnel.Location = new System.Drawing.Point(17, 28);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(213, 28);
            this.lblPersonnel.TabIndex = 0;
            this.lblPersonnel.Text = "Total Personnel";
            this.lblPersonnel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReportSalesAnalytics
            // 
            this.lblReportSalesAnalytics.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSalesAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblReportSalesAnalytics.Location = new System.Drawing.Point(75, 102);
            this.lblReportSalesAnalytics.Name = "lblReportSalesAnalytics";
            this.lblReportSalesAnalytics.Size = new System.Drawing.Size(236, 42);
            this.lblReportSalesAnalytics.TabIndex = 4;
            this.lblReportSalesAnalytics.Text = "Staff Roster";
            this.lblReportSalesAnalytics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlShopEfficiency
            // 
            this.pnlShopEfficiency.AllowDrop = true;
            this.pnlShopEfficiency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlShopEfficiency.Controls.Add(this.pbEfficiencyIcon);
            this.pnlShopEfficiency.Controls.Add(this.lblEfficiencyText);
            this.pnlShopEfficiency.Controls.Add(this.lblEfficiencyTitle);
            this.pnlShopEfficiency.Location = new System.Drawing.Point(467, 172);
            this.pnlShopEfficiency.Name = "pnlShopEfficiency";
            this.pnlShopEfficiency.Size = new System.Drawing.Size(273, 151);
            this.pnlShopEfficiency.TabIndex = 4;
            this.pnlShopEfficiency.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbEfficiencyIcon
            // 
            this.pbEfficiencyIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbEfficiencyIcon.Image")));
            this.pbEfficiencyIcon.Location = new System.Drawing.Point(21, 83);
            this.pbEfficiencyIcon.Name = "pbEfficiencyIcon";
            this.pbEfficiencyIcon.Size = new System.Drawing.Size(50, 43);
            this.pbEfficiencyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEfficiencyIcon.TabIndex = 3;
            this.pbEfficiencyIcon.TabStop = false;
            // 
            // lblEfficiencyText
            // 
            this.lblEfficiencyText.AutoSize = true;
            this.lblEfficiencyText.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfficiencyText.Location = new System.Drawing.Point(87, 86);
            this.lblEfficiencyText.Name = "lblEfficiencyText";
            this.lblEfficiencyText.Size = new System.Drawing.Size(112, 34);
            this.lblEfficiencyText.TabIndex = 1;
            this.lblEfficiencyText.Text = "94.2%";
            this.lblEfficiencyText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEfficiencyTitle
            // 
            this.lblEfficiencyTitle.AutoSize = true;
            this.lblEfficiencyTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfficiencyTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEfficiencyTitle.Location = new System.Drawing.Point(16, 32);
            this.lblEfficiencyTitle.Name = "lblEfficiencyTitle";
            this.lblEfficiencyTitle.Size = new System.Drawing.Size(210, 28);
            this.lblEfficiencyTitle.TabIndex = 0;
            this.lblEfficiencyTitle.Text = "Shop Efficiency";
            this.lblEfficiencyTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEfficiencyTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlActivejobs
            // 
            this.pnlActivejobs.AllowDrop = true;
            this.pnlActivejobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.pnlActivejobs.Controls.Add(this.pbActiveJobIcon);
            this.pnlActivejobs.Controls.Add(this.lblActiveJobs);
            this.pnlActivejobs.Controls.Add(this.lblActiveJobTitle);
            this.pnlActivejobs.Location = new System.Drawing.Point(874, 172);
            this.pnlActivejobs.Name = "pnlActivejobs";
            this.pnlActivejobs.Size = new System.Drawing.Size(276, 151);
            this.pnlActivejobs.TabIndex = 4;
            this.pnlActivejobs.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pbActiveJobIcon
            // 
            this.pbActiveJobIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbActiveJobIcon.Image")));
            this.pbActiveJobIcon.Location = new System.Drawing.Point(23, 76);
            this.pbActiveJobIcon.Name = "pbActiveJobIcon";
            this.pbActiveJobIcon.Size = new System.Drawing.Size(50, 43);
            this.pbActiveJobIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActiveJobIcon.TabIndex = 3;
            this.pbActiveJobIcon.TabStop = false;
            // 
            // lblActiveJobs
            // 
            this.lblActiveJobs.AutoSize = true;
            this.lblActiveJobs.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveJobs.Location = new System.Drawing.Point(126, 83);
            this.lblActiveJobs.Name = "lblActiveJobs";
            this.lblActiveJobs.Size = new System.Drawing.Size(51, 34);
            this.lblActiveJobs.TabIndex = 1;
            this.lblActiveJobs.Text = "04\r\n";
            this.lblActiveJobs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveJobTitle
            // 
            this.lblActiveJobTitle.AutoSize = true;
            this.lblActiveJobTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveJobTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblActiveJobTitle.Location = new System.Drawing.Point(18, 28);
            this.lblActiveJobTitle.Name = "lblActiveJobTitle";
            this.lblActiveJobTitle.Size = new System.Drawing.Size(249, 28);
            this.lblActiveJobTitle.TabIndex = 0;
            this.lblActiveJobTitle.Text = "Current Active Job";
            this.lblActiveJobTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.AllowUserToResizeColumns = false;
            this.dgvEmployeeList.AllowUserToResizeRows = false;
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.member,
            this.role,
            this.Contact,
            this.jobdone});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEmployeeList.Location = new System.Drawing.Point(81, 362);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.Size = new System.Drawing.Size(1069, 243);
            this.dgvEmployeeList.TabIndex = 5;
            // 
            // member
            // 
            this.member.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.member.HeaderText = "Member";
            this.member.MinimumWidth = 6;
            this.member.Name = "member";
            this.member.ReadOnly = true;
            this.member.ToolTipText = "Member Names";
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.MinimumWidth = 6;
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // jobdone
            // 
            this.jobdone.HeaderText = "Job Done";
            this.jobdone.MinimumWidth = 6;
            this.jobdone.Name = "jobdone";
            this.jobdone.ReadOnly = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(978, 104);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(172, 51);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.pnlShopEfficiency);
            this.Controls.Add(this.pnlActivejobs);
            this.Controls.Add(this.lblReportSalesAnalytics);
            this.Controls.Add(this.pnlTotalPersonnel);
            this.Controls.Add(this.pnlEmployeeNav);
            this.Name = "EmployeeManagement";
            this.Size = new System.Drawing.Size(1213, 638);
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.pnlEmployeeNav.ResumeLayout(false);
            this.pnlEmployeeNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimage)).EndInit();
            this.pnlTotalPersonnel.ResumeLayout(false);
            this.pnlTotalPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnel)).EndInit();
            this.pnlShopEfficiency.ResumeLayout(false);
            this.pnlShopEfficiency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEfficiencyIcon)).EndInit();
            this.pnlActivejobs.ResumeLayout(false);
            this.pnlActivejobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActiveJobIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeeNav;
        private System.Windows.Forms.Button btnEmployeeSearchButton;
        private System.Windows.Forms.TextBox txtEmployeeSearch;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.PictureBox pbEmployeeMimage;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Panel pnlTotalPersonnel;
        private System.Windows.Forms.Label lblTotalPersonnel;
        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.Label lblReportSalesAnalytics;
        private System.Windows.Forms.Panel pnlShopEfficiency;
        private System.Windows.Forms.PictureBox pbEfficiencyIcon;
        private System.Windows.Forms.Label lblEfficiencyText;
        private System.Windows.Forms.Label lblEfficiencyTitle;
        private System.Windows.Forms.Panel pnlActivejobs;
        private System.Windows.Forms.PictureBox pbActiveJobIcon;
        private System.Windows.Forms.Label lblActiveJobs;
        private System.Windows.Forms.Label lblActiveJobTitle;
        private System.Windows.Forms.PictureBox pbPersonnel;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn member;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobdone;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}
