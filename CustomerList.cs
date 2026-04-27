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
    public partial class CustomerList : UserControl
    {
        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            DataSet ds=DbHelper.GetData("SELECT * FROM Customers;");
            dgvCustomers.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM Customers WHERE phone='" + this.txtSearch.Text + "';";
            DataSet ds = DbHelper.GetData(sqlQuery);
            dgvCustomers.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No customer found with the given phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Customer found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataSet ds = DbHelper.GetData("select * From customers;");
            dgvCustomers.DataSource = ds.Tables[0];
            MessageBox.Show("Customer data refresh successfull!", "Refresh Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
