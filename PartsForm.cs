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
    public partial class PartsForm : Form
    {
        internal string PartsName { get; set; }
        internal uint Quantity { get; set; }
        internal double UnitPrice { get; set; }
        public PartsForm()
        {
            InitializeComponent();
            LoadParts();
        }

        private void LoadParts()
        {
            string sqlQuery = "SELECT part_name FROM Inventory;";
            DataSet ds = DbHelper.GetData(sqlQuery);

            cmbParts.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                cmbParts.Items.Add(row["part_name"].ToString());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.PartsName = this.cmbParts.Text;
            this.Quantity = Convert.ToUInt32(this.numQuanitity.Value);

            string sqlQuery = "SELECT unit_price FROM Inventory WHERE part_name = '" + this.cmbParts.Text + "';";
            DataSet ds = DbHelper.GetData(sqlQuery);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.UnitPrice = Convert.ToDouble(ds.Tables[0].Rows[0]["unit_price"]);
            }
            else
            {
                this.UnitPrice = 0;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
