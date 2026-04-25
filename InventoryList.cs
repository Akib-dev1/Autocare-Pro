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
    public partial class InventoryList : UserControl
    {
        public InventoryList()
        {
            InitializeComponent();
        }

        private void InventoryList_Load(object sender, EventArgs e)
        {
            DataSet ds=DbHelper.GetData("SELECT * FROM Inventory;");
            dgvInventory.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM Inventory WHERE part_name LIKE '%" + this.txtSearch.Text + "%';";
            DataSet ds = DbHelper.GetData(sqlQuery);
            dgvInventory.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No inventory item found with the given part name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Inventory item found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
