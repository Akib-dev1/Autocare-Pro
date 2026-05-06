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
    public partial class RemoveUserForm : Form
    {
        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cmbUsers.Text== "")
            {
                MessageBox.Show("Please select a user to remove.");
                return;
            }
            string query = $"DELETE FROM user_info WHERE id='{cmbUsers.Text}'";
            int result = AdminForm.Da.ExecuteQuery(query);
            if (result == 0)
            {
                MessageBox.Show("Failed to remove user. Please try again.");
            }
            else
            {
                MessageBox.Show("User removed successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void RemoveUserForm_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT id FROM user_info;";
            DataSet ds = AdminForm.Da.GetData(sqlQuery);

            cmbUsers.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cmbUsers.Items.Add(row["id"].ToString());
            }
        }
    }
}
