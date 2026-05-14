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
    public partial class AdminForm : Form
    {
        UserControl CurrentPage { get; set; }
        loginPage LoginPage { get; set; }
        public static DbHelper Da { get; set; }
        public AdminForm()
        {
            InitializeComponent();
            this.LoadPage(new EmployeeManagement());
            this.btnAdminNavlink1.BackColor = Color.RoyalBlue;
            Da = new DbHelper();
        }
        public AdminForm(loginPage lp) : this() 
        {
            this.LoginPage = lp;
        }
        private void LoadPage(UserControl page)
        {
            if (CurrentPage != null)
            {
                this.pnlContainer.Controls.Remove(CurrentPage);
                CurrentPage.Dispose();
            }

            CurrentPage = page;

            page.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(page);
            page.BringToFront();
        }

        private void btnAdminNavlink1_Click(object sender, EventArgs e)
        {
            this.LoadPage(new EmployeeManagement());
            this.btnAdminNavlink1.BackColor = Color.RoyalBlue;
            this.btnAdminNavlink2.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink3.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink4.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink5.BackColor = Color.MidnightBlue;
        }

        private void btnAdminNavlink3_Click(object sender, EventArgs e)
        {
            this.LoadPage(new InventoryMannagement());
            this.btnAdminNavlink3.BackColor = Color.RoyalBlue;
            this.btnAdminNavlink4.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink1.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink2.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink5.BackColor = Color.MidnightBlue;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminNavlink2_Click(object sender, EventArgs e)
        {
            this.LoadPage(new AllCustomers());
            this.btnAdminNavlink2.BackColor = Color.RoyalBlue;
            this.btnAdminNavlink4.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink1.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink3.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink5.BackColor = Color.MidnightBlue;
        }

        private void btnAdminNavlink4_Click(object sender, EventArgs e)
        {
            this.LoadPage(new Reports());
            this.btnAdminNavlink4.BackColor = Color.RoyalBlue;
            this.btnAdminNavlink3.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink1.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink2.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink5.BackColor = Color.MidnightBlue;
        }

        private void btnAdminNavlink5_Click(object sender, EventArgs e)
        {
            this.LoadPage(new AllInvoices());
            this.btnAdminNavlink5.BackColor = Color.RoyalBlue;
            this.btnAdminNavlink4.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink1.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink2.BackColor = Color.MidnightBlue;
            this.btnAdminNavlink3.BackColor = Color.MidnightBlue;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                this.LoginPage.Show();
                this.Hide();
            }
        }
    }
}
