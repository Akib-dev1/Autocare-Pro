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
            DataSet ds=userForm.Da.GetData("SELECT * FROM Inventory;");
            dgvInventory.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM Inventory WHERE part_name LIKE '%" + this.txtSearch.Text + "%';";
            DataSet ds = userForm.Da.GetData(sqlQuery);
            dgvInventory.DataSource = ds.Tables[0];
        }
    }
}
