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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string partName = this.txtPartName.Text.Trim();
            uint quantity = Convert.ToUInt32(this.numQuantity.Value);
            double unitPrice = Convert.ToDouble(this.numPrice.Value);
            if (string.IsNullOrEmpty(partName))
            {
                MessageBox.Show("Please enter a valid part name.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(quantity <= 0)
            {
                                MessageBox.Show("Please enter a valid quantity.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(unitPrice <= 0)
            {
                MessageBox.Show("Please enter a valid unit price.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = $"INSERT INTO Inventory (part_name, unit_price, stock_qty) VALUES ('{partName}', {unitPrice}, {quantity});";
                int rowsAffected = AdminForm.Da.ExecuteQuery(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Stock added successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add stock. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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
