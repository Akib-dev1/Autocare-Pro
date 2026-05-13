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
    public partial class AllInvoices : UserControl
    {
        public AllInvoices()
        {
            InitializeComponent();
        }
        private void loadAllInvoices()
        {
            try
            {
                string sql = @"SELECT i.Invoice_Id , 
                  i.created_at, 
                  c.Name, 
                  i.Grand_Total
           FROM Invoices i, Customers c
           WHERE i.Customer_Id = c.Customer_Id";

                DataTable dt = AdminForm.Da.GetDataTable(sql);
                this.dgvAllInvoices.AutoGenerateColumns = false;
                this.dgvAllInvoices.DataSource = dt;
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

        private void AllInvoices_Load(object sender, EventArgs e)
        {
            this.loadAllInvoices();
        }

        private void btnAllInvoicesSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = this.txtAllInvoicesSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter an Invoice Number to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string sql = "SELECT i.Invoice_Id, " +
                              "i.created_at, " +
                               "c.Name, " +
                               "i.Grand_Total " +
                               "FROM Invoices i, Customers c " +
                               "WHERE i.Customer_Id = c.Customer_Id " +
                               "AND i.Invoice_Id = " + searchText;
                DataTable dt = AdminForm.Da.GetDataTable(sql);
                this.dgvAllInvoices.DataSource = dt;
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
