using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_Pro
{
    public partial class EmployeeManagement : UserControl
    {
        public EmployeeManagement()
        {
            InitializeComponent();
        }
        private void LoadEmployeeData()
        {
            try
            {
                string sql = "SELECT * FROM user_info";
                DataTable dt = AdminForm.Da.GetDataTable(sql);
                this.dgvCustomerList.DataSource = dt;
                this.lblTotalPersonnel.Text = dt.Rows.Count.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddUserForm addUser=new AddUserForm();
            if(addUser.ShowDialog()==DialogResult.OK)
            {
                this.LoadEmployeeData();
            }
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            this.LoadEmployeeData();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            RemoveUserForm removeUser=new RemoveUserForm();
            if(removeUser.ShowDialog()==DialogResult.OK)
            {
                this.LoadEmployeeData();
            }
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            EditUserInfo editUserInfo=new EditUserInfo();
            if (editUserInfo.ShowDialog() == DialogResult.OK)
            {
                this.LoadEmployeeData();
            }
        }

        private void btnEmployeeSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtEmployeeSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter an Name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string sql = $"SELECT * FROM user_info WHERE Name LIKE '%{searchText}%'";

                DataTable dt = AdminForm.Da.GetDataTable(sql);
                this.dgvCustomerList.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
