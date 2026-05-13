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
    public partial class InvoiceList : UserControl
    {
        public InvoiceList()
        {
            InitializeComponent();
        }

        private void InvoiceList_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = userForm.Da.GetData("select * from invoices where employe_id='" + userForm.EmpId + "';");
                this.dgvInvoice.DataSource = ds.Tables[0];
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.txtSearch.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a phone number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    string sqlQuery = "select * From invoices where customer_id=(Select customer_id from customers where phone='" + this.txtSearch.Text + "');";
                    DataSet ds = userForm.Da.GetData(sqlQuery);
                    this.dgvInvoice.DataSource = ds.Tables[0];
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Customer found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvInvoice.Columns["viewButton"].Index && e.RowIndex >= 0)
            {
                int invoiceId = Convert.ToInt32(dgvInvoice.Rows[e.RowIndex].Cells["InvoiceId"].Value);
                Full_Invoice fullInvoiceForm = new Full_Invoice(invoiceId);
                if(fullInvoiceForm.ShowDialog()==DialogResult.OK)
                {
                    fullInvoiceForm.Dispose();
                }
            }
        }
    }
}
