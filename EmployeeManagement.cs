using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string sql = "SELECT * FROM user_info";
            DataTable dt = AdminForm.Da.GetDataTable(sql);
            this.dgvCustomerList.DataSource = dt;
            this.lblTotalPersonnel.Text = dt.Rows.Count.ToString();
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
    }
}
