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
    public partial class EditStock : Form
    {
        public EditStock()
        {
            InitializeComponent();
            this.loadStock();
        }
        void loadStock()
        {
            try
            {
                string sqlQuery = "SELECT part_name FROM Inventory;";
                DataSet ds = AdminForm.Da.GetData(sqlQuery);

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
        private void cmbParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM Inventory WHERE part_name = '{this.cmbParts.Text}';";
                DataTable dt=AdminForm.Da.GetDataTable(query);
                if (dt.Rows.Count > 0)
                {
                    this.numPrice.Value = Convert.ToDecimal(dt.Rows[0]["unit_price"].ToString());
                    this.numQuantity.Value = Convert.ToDecimal(dt.Rows[0]["stock_qty"].ToString());
                    this.numPrice.ReadOnly=false;
                    this.numQuantity.ReadOnly = false;
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
            if(string.IsNullOrEmpty(this.cmbParts.Text))
            {
                MessageBox.Show("Please select a part to edit.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string updateQuery = $"UPDATE Inventory SET unit_price = {this.numPrice.Value}, stock_qty = {this.numQuantity.Value} WHERE part_name = '{this.cmbParts.Text}';";
                int rowsAffected = AdminForm.Da.ExecuteQuery(updateQuery);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Stock information updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
