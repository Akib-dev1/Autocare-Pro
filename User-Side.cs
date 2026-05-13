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
        loginPage Lp { get; set; }
        internal static string EmpId { get; set; }
        internal static string EmpName { get; set; }
        private UserControl CurrentPage { get; set; }
        public static DbHelper Da {  get; set; }
        public userForm(loginPage lp,string empId,string empName)
        {
            InitializeComponent();
            this.Lp = lp;
            EmpId = empId;
            EmpName = empName;
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

        private void userForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Lp.Show();
            Application.Exit();
        }

        private void btnNavlink1_Click(object sender, EventArgs e)
        {
            
            this.LoadPage(new Jobcard());
            
            this.btnNavlink1.BackColor = Color.FromArgb(22, 27, 42);
            this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink4.BackColor = Color.FromArgb(37, 42, 56);

        }

        private void btnNavlink2_Click(object sender, EventArgs e)
        {
            
            this.LoadPage(new CustomerList());
            this.btnNavlink2.BackColor = Color.FromArgb(22, 27, 42);
            this.btnNavlink1.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink4.BackColor = Color.FromArgb(37, 42, 56);
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            
            this.LoadPage(new Jobcard());
            this.btnNavlink1.BackColor = Color.FromArgb(22, 27, 42);
            this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink4.BackColor = Color.FromArgb(37, 42, 56);
        }

        private void btnNavlink3_Click(object sender, EventArgs e)
        {
            
            this.LoadPage(new InventoryList());
            this.btnNavlink3.BackColor = Color.FromArgb(22, 27, 42);
            this.btnNavlink1.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink4.BackColor = Color.FromArgb(37, 42, 56);
        }

        private void btnNavlink4_Click(object sender, EventArgs e)
        {
            
            this.LoadPage(new InvoiceList());
            this.btnNavlink4.BackColor = Color.FromArgb(22, 27, 42);
            this.btnNavlink2.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink3.BackColor = Color.FromArgb(37, 42, 56);
            this.btnNavlink1.BackColor = Color.FromArgb(37, 42, 56);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Lp.Show();
            this.Hide();
        }
    }
}
