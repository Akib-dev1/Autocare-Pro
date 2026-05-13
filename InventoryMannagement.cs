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
    public partial class InventoryMannagement : UserControl
    {
        public InventoryMannagement()
        {
            InitializeComponent();
        }
        private void LoadInventoryData()
        {
            string sql = "SELECT * FROM inventory";
            DataTable dt = AdminForm.Da.GetDataTable(sql);
            this.dgvInventory.DataSource = dt;
            uint total = 0;
            uint count = 0;
            double stockValue = 0;
            foreach (DataRow dr in dt.Rows )
            {
                total += Convert.ToUInt32(dr["stock_qty"].ToString());
                if(Convert.ToUInt32(dr["stock_qty"].ToString()) < 10)
                {
                    count++;
                }
                stockValue+= Convert.ToUInt32(dr["stock_qty"].ToString()) * Convert.ToDouble(dr["unit_price"].ToString());
            }
            this.lblTotalAsset.Text = total.ToString();
            this.lblLowStockValue.Text=count.ToString();
            this.lblStockValue.Text = "$"+stockValue.ToString("F2");
        }

        private void InventoryMannagement_Load(object sender, EventArgs e)
        {
            
            this.LoadInventoryData();
        }

        private void txtInventorySearch_TextChanged(object sender, EventArgs e)
        {
             string sqlQuery = "SELECT * FROM Inventory WHERE part_name LIKE '%" + this.txtInventorySearch.Text + "%';";
            DataSet ds = AdminForm.Da.GetData(sqlQuery);
            this.dgvInventory.DataSource=ds.Tables[0];
        }
    }
}
