using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoCare_Pro
{
    public partial class loginPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,     // x-coordinate of upper-left corner
                int nTop,      // y-coordinate of upper-left corner
                int nRight,    // x-coordinate of lower-right corner
                int nBottom,   // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );
        public loginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin.BackColor= Color.FromArgb(248, 249, 250);
            this.btnRegister.BackColor = Color.FromArgb(26, 31, 46);
            this.btnLogin.ForeColor = Color.Black;
            this.btnRegister.ForeColor = Color.White;
            this.pnlLoginForm.Visible = true;
            this.pnlRegister.Visible = false;
            this.btnLogSubmit.Visible = true;
            this.btnRegSubmit.Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.btnRegister.BackColor = Color.FromArgb(248, 249, 250);
            this.btnLogin.BackColor = Color.FromArgb(26, 31, 46);
            this.btnLogin.ForeColor = Color.White;
            this.btnRegister.ForeColor = Color.Black;
            this.pnlRegister.Visible = true;
            this.pnlLoginForm.Visible = false;
            this.btnLogSubmit.Visible = false;
            this.btnRegSubmit.Visible = true;
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            this.pnlLogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.pnlLogin.Width, this.pnlLogin.Height, 20, 20));
        }

        private void btnLogSubmit_Click(object sender, EventArgs e)
        {
            userForm us = new userForm();
            us.Visible = true;
        }
    }
}
