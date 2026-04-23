using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_Pro
{
    public partial class Jobcard : UserControl
    {
        public Jobcard()
        {
            InitializeComponent();
        }

        private void btnEditCusDetails_Click(object sender, EventArgs e)
        {
            CustomerDetails cs = new CustomerDetails();
            if (cs.ShowDialog() == DialogResult.OK)
            {
                this.lblCustomerName.Text = cs.CustomerName;
                this.lblPhoneNumber.Text = cs.PhoneNumber;
                this.lblLocationShow.Text = cs.CustomerLocation;
                this.lblEmailShow.Text = cs.Email;
            }
        }

        private void btnEditVehicleDetails_Click(object sender, EventArgs e)
        {
            VehicleInfo vi = new VehicleInfo();
            if (vi.ShowDialog() == DialogResult.OK)
            {
                this.lblModel.Text = vi.Model;
                this.lblVehicleYear.Text = vi.Year;
                this.lblPlateNumber.Text = vi.PlateNumber;
            }
        }
    }
}
