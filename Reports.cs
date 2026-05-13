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
    public partial class Reports : UserControl
    {
        
        public Reports()
        {
            InitializeComponent();
        }


        private void LoadReport()
        {
            //Grand total load
            string sql = "SELECT Grand_Total FROM Invoices ";
            DataTable dt = AdminForm.Da.GetDataTable(sql);
            double total = 0;
            foreach(DataRow dr in dt.Rows)
            {
                total += Convert.ToDouble(dr["Grand_Total"].ToString());
            }
            if (dt.Rows.Count > 0)
            {
                double avg = total / dt.Rows.Count;
                this.lblAvgSaleTotal.Text = "$" + avg.ToString("F2");
            }
            else
            {
                this.lblAvgSaleTotal.Text = "$0";
            }
            //total customer count
            string sql2 = "SELECT COUNT(*) FROM Customers";
            string totalCustomers = AdminForm.Da.ExecuteScalar(sql2);
            this.lblTotalCustomerAmount.Text = totalCustomers;

            //revenue prediction
            this.lblProRevenueAmount.Text = "$"+total.ToString("F2");

            //Filling the ledger
            string sql3 = @"SELECT c.Vehicle_Model, js.Description, 
                           i.Grand_Total, i.Tech_Notes
                    FROM Customers c, Invoices i, Job_Services js
                    WHERE c.Customer_Id = i.Customer_Id
                    AND i.Invoice_Id = js.Invoice_Id";

            DataTable dt2 = AdminForm.Da.GetDataTable(sql3);
            this.dgvLedger.DataSource = dt2;

        }
        private void Reports_Load(object sender, EventArgs e)
        {
            this.LoadReport();
        }
    }
}
