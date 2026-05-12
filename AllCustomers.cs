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
            total=total / dt.Rows.Count;
            this.lblAvgPurchaseValue.Text = "$"+total.ToString("F2");
        }

        private void AllCustomers_Load(object sender, EventArgs e)
        {
            this.LoadCustomerData();
        }
    }
}
