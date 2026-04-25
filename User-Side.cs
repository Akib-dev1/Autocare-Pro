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
        internal static string EmpId { get; set; }
        internal static string EmpName { get; set; }
        public userForm(loginPage lp,string empId,string empName)
        {
            InitializeComponent();
            this.Lp = lp;
            EmpId = empId;
            EmpName = empName;
        }

        private void userForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Lp.Show();
            Application.Exit();
        }

        private void btnNavlink1_Click(object sender, EventArgs e)
        {
            this.ucJobcard.Visible = true;
            this.ucCusList.Visible = false;
            this.ucInventoryList.Visible = false;
            if (this.ucJobcard.Visible)
            {
                this.btnNavlink1.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);

            }
            else if (this.ucCusList.Visible)
            {
                this.btnNavlink2.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink1.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);
            }
        }

        private void btnNavlink2_Click(object sender, EventArgs e)
        {
            this.ucJobcard.Visible = false;
            this.ucCusList.Visible = true;
            this.ucInventoryList.Visible = false;
            if (this.ucJobcard.Visible)
            {
                this.btnNavlink1.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);

            }
            else if (this.ucCusList.Visible)
            {
                this.btnNavlink2.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink1.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);
            }
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            this.ucJobcard.Visible = true;
            this.ucInventoryList.Visible = false;
            this.ucCusList.Visible = false;
            if (this.ucJobcard.Visible)
            {
                this.btnNavlink1.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);

            }
            else if (this.ucCusList.Visible)
            {
                this.btnNavlink2.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink1.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);
            }
        }

        private void btnNavlink3_Click(object sender, EventArgs e)
        {
            this.ucCusList.Visible = false;
            this.ucJobcard.Visible = false;
            this.ucInventoryList.Visible = true;
            if (this.ucJobcard.Visible)
            {
                this.btnNavlink1.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);

            }
            else if (this.ucCusList.Visible)
            {
                this.btnNavlink2.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink1.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);
            }
            else if (this.ucInventoryList.Visible)
            {
                this.btnNavlink3.BackColor = Color.FromArgb(22, 27, 42);
                this.btnNavlink1.BackColor = Color.FromArgb(37, 42, 56);
                this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
            }

        }
    }
}
