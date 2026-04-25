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
    public partial class VehicleInfo : Form
    {
        internal string Model { get; set; }
        internal string Year { get; set; }
        internal string PlateNumber { get; set; }
        internal string Color { get; set; }
        public VehicleInfo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(this.txtModel.Text == "") && !(this.txtPlateNum.Text=="")&&!(this.txtYear.Text=="") )
            {
                this.Model = this.txtModel.Text;
                this.Year = this.txtYear.Text;
                this.PlateNumber = this.txtPlateNum.Text;
                this.Color = this.txtColor.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Fields Can't Be Empty.");
            }
        }
    }
}
