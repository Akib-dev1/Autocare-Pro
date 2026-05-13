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
    public partial class AllCustomers : UserControl
    {
        public AllCustomers()
        {
            InitializeComponent();
        }
        private void LoadCustomerData()
        {
            string sql = "SELECT * FROM customers";
            string sql2= "select grand_total from invoices;";
            DataTable dt = AdminForm.Da.GetDataTable(sql);
            DataTable dt2 = AdminForm.Da.GetDataTable(sql2);
            this.dgvCustomerList.DataSource = dt;
            this.lblTotalClientValue.Text = dt.Rows.Count.ToString();
            this.lblFleetCountValue.Text = dt.Rows.Count.ToString();
            double total = 0;
            foreach (DataRow dr in dt2.Rows) {
                total += Convert.ToDouble(dr["grand_total"].ToString());
            }
            if (dt2.Rows.Count > 0)//validation added:rafi
            {
                total = total / dt2.Rows.Count;
                this.lblAvgPurchaseValue.Text = "$" + total.ToString("F2");
            }
            else
            {
                this.lblAvgPurchaseValue.Text = "$0";
            }
        }

        private void AllCustomers_Load(object sender, EventArgs e)
        {
            this.LoadCustomerData();
        }

        private void btnAllCustomerSearchButton_Click(object sender, EventArgs e)
        {
            string searchData = txtAllCustomerSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchData))
            {
                MessageBox.Show("Please Input Phone Number To Search", "Input Required",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string sql = $"SELECT * FROM Customers Where phone LIKE '%{searchData}%';";
                DataTable dt = AdminForm.Da.GetDataTable(sql);
                this.dgvCustomerList.DataSource=dt;
            }
        }
    }
}
