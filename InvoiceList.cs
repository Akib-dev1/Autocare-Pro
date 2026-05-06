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
    public partial class InvoiceList : UserControl
    {
        public InvoiceList()
        {
            InitializeComponent();
        }

        private void InvoiceList_Load(object sender, EventArgs e)
        {
            DataSet ds = userForm.Da.GetData("select * from invoices where employe_id='"+userForm.EmpId+"';");
            this.dgvInvoice.DataSource = ds.Tables[0];
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
            
        }
    }
}
