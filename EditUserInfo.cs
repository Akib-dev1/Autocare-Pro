using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_Pro
{
    public partial class EditUserInfo : Form
    {
        public EditUserInfo()
        {
            InitializeComponent();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql= "select * from user_info where id='" + cmbUsers.Text+"';";
            DataSet ds = AdminForm.Da.GetData(sql);
            this.txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.txtEmail.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtPass.Text = ds.Tables[0].Rows[0][3].ToString();
            this.cmbRole.SelectedIndex = this.cmbRole.FindString(ds.Tables[0].Rows[0][4].ToString());
            this.txtName.ReadOnly = false;
            this.txtEmail.ReadOnly = false;
            this.txtPass.ReadOnly = false;
        }

        private void EditUserInfo_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT id FROM user_info;";
            DataSet ds = AdminForm.Da.GetData(sqlQuery);

            cmbUsers.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cmbUsers.Items.Add(row["id"].ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(cmbUsers.Text == "")
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }
            string sql = "update user_info set name='" + this.txtName.Text + "', email='" + this.txtEmail.Text + "', password='" + this.txtPass.Text + "', role='" + this.cmbRole.Text + "' where id='" + cmbUsers.Text + "';";
            int count = AdminForm.Da.ExecuteQuery(sql);
            if (count == 0)
            {
                MessageBox.Show("Failed to update user information.");
            }
            else
            {
                MessageBox.Show("User information updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
