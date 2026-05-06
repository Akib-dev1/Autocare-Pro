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
        public static DbHelper Da { get; set; }
        public AdminForm()
        {
            InitializeComponent();
            this.LoadPage(new EmployeeManagement());
            this.btnAdminNavlink1.BackColor = Color.RoyalBlue;
            Da = new DbHelper();
        }
        private void LoadPage(UserControl page)
        {
            // Remove old page
            if (CurrentPage != null)
            {
                panelContainer.Controls.Remove(CurrentPage);
                CurrentPage.Dispose(); // optional (depends on reuse)
            }

            CurrentPage = page;

            // Setup new page
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
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
    }
}
