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
    public partial class InventoryMannagement : UserControl
    {
        public InventoryMannagement()
        {
            InitializeComponent();
        }
        private void LoadInventoryData()
        {
            try
            {
                string sql = "SELECT * FROM inventory";
                DataTable dt = AdminForm.Da.GetDataTable(sql);
                this.dgvInventory.DataSource = dt;
                uint total = 0;
                uint count = 0;
                double stockValue = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    total += Convert.ToUInt32(dr["stock_qty"].ToString());
                    if (Convert.ToUInt32(dr["stock_qty"].ToString()) < 10)
                    {
                        count++;
                    }
                    stockValue += Convert.ToUInt32(dr["stock_qty"].ToString()) * Convert.ToDouble(dr["unit_price"].ToString());
                }
                this.lblTotalAsset.Text = total.ToString();
                this.lblLowStockValue.Text = count.ToString();
                this.lblStockValue.Text = "$" + stockValue.ToString("F2");
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

        private void InventoryMannagement_Load(object sender, EventArgs e)
        {
            
            this.LoadInventoryData();
        }

        private void txtInventorySearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT * FROM Inventory WHERE part_name LIKE '%" + this.txtInventorySearch.Text + "%';";
                DataSet ds = AdminForm.Da.GetData(sqlQuery);
                this.dgvInventory.DataSource = ds.Tables[0];
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

        private void btnEditStock_Click(object sender, EventArgs e)
        {
            EditStock editStock=new EditStock();
            if (editStock.ShowDialog() == DialogResult.OK)
            {
                this.LoadInventoryData();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            AddStock addStock=new AddStock();
            if(addStock.ShowDialog() == DialogResult.OK)
            {
                this.LoadInventoryData();
            }
        }
    }
}
