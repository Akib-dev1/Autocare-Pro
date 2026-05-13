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
    public partial class AllInvoices : UserControl
    {
        public AllInvoices()
        {
            InitializeComponent();
        }
        private void loadAllInvoices()
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
    }
}
