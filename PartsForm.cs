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
    public partial class PartsForm : Form
    {
        internal string PartsName { get; set; }
        internal uint Quantity { get; set; }
        internal double UnitPrice { get; set; }
        public PartsForm()
        {
            InitializeComponent();
            LoadParts();
        }

        private void LoadParts()
        {
            try
            {
                string sqlQuery = "SELECT part_name FROM Inventory;";
                DataSet ds = userForm.Da.GetData(sqlQuery);

                cmbParts.Items.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmbParts.Items.Add(row["part_name"].ToString());
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbParts.Text) || this.numQuanitity.Value == 0)
            {
                MessageBox.Show("Please select a part and enter a valid quantity.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                this.PartsName = this.cmbParts.Text;
                this.Quantity = Convert.ToUInt32(this.numQuanitity.Value);

                string sqlQuery = "SELECT unit_price FROM Inventory WHERE part_name = '" + this.cmbParts.Text + "';";
                DataSet ds = userForm.Da.GetData(sqlQuery);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.UnitPrice = Convert.ToDouble(ds.Tables[0].Rows[0]["unit_price"]);
                }
                else
                {
                    this.UnitPrice = 0;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
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
