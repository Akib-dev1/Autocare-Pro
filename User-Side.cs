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
    public partial class userForm : Form
    {
        internal loginPage Lp { get; set; }
        public userForm(loginPage lp)
        {
            InitializeComponent();
            this.Lp = lp;
        }

        private void userForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Lp.Show();
            Application.Exit();
        }
    }
}
