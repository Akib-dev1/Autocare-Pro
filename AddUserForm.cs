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
    public partial class AddUserForm : Form
    {
        internal string UserName { get; set; }
        internal string Email { get; set; }
        internal string Password { get; set; }
        internal string Role { get; set; }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.UserName = this.txtName.Text.Trim();
            this.Email = this.txtEmail.Text.Trim();
            this.Password = this.txtPass.Text.Trim();
            this.Role = this.cmbRole.Text.Trim();

            if (this.Role == "" || this.UserName == "" || this.Email == "" || this.Password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string id = AutoIdGenerate();

            try
            {
                string query = $"INSERT INTO user_info (Id, Name, Email, Password, Role) VALUES ('{id}', '{this.UserName}', '{this.Email}', '{this.Password}', '{this.Role}')";
                int result = AdminForm.Da.ExecuteQuery(query);
                if (result == 0)
                {
                    MessageBox.Show("Failed to add user. Please try again.");
                }
                else
                {
                    MessageBox.Show("User added successfully.");
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
        private string AutoIdGenerate()
        {
            try
            {
                var sql = "select max(Id) from user_info;";
                DataTable dt = AdminForm.Da.GetDataTable(sql);
                var oldId = dt.Rows[0][0].ToString();
                var temp = oldId.Split('-');
                var num = Convert.ToInt32(temp[1]);
                var currentId = "u-" + (++num).ToString("d3");
                return currentId;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
}
