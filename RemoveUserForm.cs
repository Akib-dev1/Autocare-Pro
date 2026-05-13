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
            try
            {
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

        private void RemoveUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT id FROM user_info;";
                DataSet ds = AdminForm.Da.GetData(sqlQuery);

                cmbUsers.Items.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmbUsers.Items.Add(row["id"].ToString());
                }
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
