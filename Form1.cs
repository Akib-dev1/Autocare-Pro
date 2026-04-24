using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void loginPage_Load(object sender, EventArgs e)
        {
            this.pnlLogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.pnlLogin.Width, this.pnlLogin.Height, 20, 20));
        }

        private void btnLogSubmit_Click(object sender, EventArgs e)
        {
            string sqlQuery = "select * from user_info where email='" + this.txtLoginEmail.Text + "' and password='" + this.txtLoginPass.Text+"';";
            SqlConnection sqlCon = new SqlConnection("Data Source=AKIB\\SQLMAIN;Initial Catalog=AutoCarePro;Persist Security Info=True;User ID=sa;Password=password@Ak;Encrypt=False");
            sqlCon.Open();
            SqlCommand sql = new SqlCommand(sqlQuery, sqlCon);
            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataSet ds = new DataSet();
            sqlData.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Valid User");
                userForm us = new userForm(this);
                us.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            sqlCon.Close();
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkShowPass.Checked)
            {
                this.txtLoginPass.PasswordChar = '\0';
            }
            else
            {
                this.txtLoginPass.PasswordChar = '*';
            }
        }
    }
}
