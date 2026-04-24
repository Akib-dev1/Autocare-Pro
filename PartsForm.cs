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
    public partial class PartsForm : Form
    {
        internal string PartsName { get; set; }
        internal uint Quantity { get; set; }
        internal double UnitPrice { get; set; }
        public PartsForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.PartsName = this.cmbParts.SelectedText;
            this.Quantity = Convert.ToUInt32(this.numQuanitity.Value);
            this.UnitPrice = 25.6;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
