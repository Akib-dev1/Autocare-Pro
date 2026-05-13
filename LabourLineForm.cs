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
    public partial class LabourLineForm : Form
    {
        internal string LabourDescription { get; set; }
        internal double Hours { get; set; }
        internal double Rate { get; set; }
        public LabourLineForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.rtextDescription.Text.Trim()) || this.numHours.Value == 0 || this.numRate.Value == 0)
            {
                MessageBox.Show("Fields can't be empty.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.LabourDescription = this.rtextDescription.Text.Trim();
            this.Hours = Convert.ToDouble(this.numHours.Value);
            this.Rate = Convert.ToDouble(this.numRate.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
