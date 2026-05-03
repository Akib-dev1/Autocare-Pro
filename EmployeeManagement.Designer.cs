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
            this.pbEmployeeMimage = new System.Windows.Forms.PictureBox();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.pnlTotalPersonnel = new System.Windows.Forms.Panel();
            this.lblTotalPersonnel = new System.Windows.Forms.Label();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblReportSalesAnalytics = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbEfficiencyIcon = new System.Windows.Forms.PictureBox();
            this.lblEfficiencyText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbPersonnel = new System.Windows.Forms.PictureBox();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.pnlEmployeeNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployeeMimage)).BeginInit();
            this.pnlTotalPersonnel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEfficiencyIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnel)).BeginInit();
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
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.pbEfficiencyIcon);
            this.panel1.Controls.Add(this.lblEfficiencyText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(467, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 151);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(16, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shop Efficiency";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(874, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 151);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "04\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current Active Job";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(172)))));
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEfficiencyIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnel)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbEfficiencyIcon;
        private System.Windows.Forms.Label lblEfficiencyText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbPersonnel;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn member;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobdone;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}
