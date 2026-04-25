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
    public partial class CustomerDetails : Form
    {
        string customerName;
        string phoneNumber;
        string email;
        string customerLocation;

        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string CustomerLocation { get; set; }

        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(this.txtName.Text=="")&& !(this.txtEmail.Text == "")&& !(this.txtPhone.Text == "")&& !(this.txtLocation.Text == ""))
            {
                this.CustomerName = this.txtName.Text.Trim();
                this.Email = this.txtEmail.Text.Trim();
                this.PhoneNumber = this.txtPhone.Text.Trim();
                this.CustomerLocation = this.txtLocation.Text.Trim();
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
