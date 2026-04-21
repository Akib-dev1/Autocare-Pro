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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin.BackColor= Color.FromArgb(232, 115, 10);
            this.btnRegister.BackColor = Color.FromArgb(26, 31, 46);
            this.pnlLoginForm.Visible = true;
            this.pnlRegister.Visible = false;
            this.btnLoginSubmit.Visible = true;
            this.btnRegSubmit.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.btnRegister.BackColor = Color.FromArgb(232, 115, 10);
            this.btnLogin.BackColor = Color.FromArgb(26, 31, 46);
            this.pnlRegister.Visible = true;
            this.pnlLoginForm.Visible = false;
            this.btnLoginSubmit.Visible = false;
            this.btnRegSubmit.Visible = true;
        }
    }
}
