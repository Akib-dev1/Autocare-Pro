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

        private void btnAddLabour_Click(object sender, EventArgs e)
        {
            LabourLineForm lf = new LabourLineForm();
            if (lf.ShowDialog() == DialogResult.OK)
            {
                this.dgvService.Rows.Add(lf.LabourDescription, lf.Hours.ToString(), lf.Rate.ToString(), (lf.Hours*lf.Rate).ToString());
            }
            //dgvService.Rows.Add("asdda", "ssdaada", "sdawadasd", "sdwadsada");
            //this.lblCustomerName.Text=dgvService.Rows[0].Cells[1].Value.ToString();
        }

        private void btnAddinventory_Click(object sender, EventArgs e)
        {
            PartsForm pf = new PartsForm();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                this.dgvParts.Rows.Add(pf.PartsName, pf.Quantity, pf.UnitPrice, (pf.UnitPrice * pf.Quantity).ToString());
            }
        }
    }
}
