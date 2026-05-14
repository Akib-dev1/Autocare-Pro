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
        DbHelper Da {  get; set; }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,     
                int nTop,      
                int nRight,    
                int nBottom,   
                int nWidthEllipse, 
                int nHeightEllipse 
            );
        public loginPage()
        {
            InitializeComponent();
            this.Da = new DbHelper();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            this.pnlLogin.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.pnlLogin.Width, this.pnlLogin.Height, 20, 20));
        }

        private void btnLogSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "select * from user_info where id='" + this.txtLoginID.Text + "' and password='" + this.txtLoginPass.Text + "';";
                DataSet ds = this.Da.GetData(sqlQuery);

                if (ds.Tables[0].Rows.Count == 1 && (ds.Tables[0].Rows[0][4].ToString() == "manager"))
                {
                    MessageBox.Show("User Authenticated Successfully! Name: " + ds.Tables[0].Rows[0][1].ToString(), "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userForm us = new userForm(this, ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString());
                    this.txtLoginID.Text= "";
                    this.txtLoginPass.Text = "";
                    us.Show();
                    this.Hide();
                }
                else if (ds.Tables[0].Rows.Count == 1 && (ds.Tables[0].Rows[0][4].ToString() == "admin"))
                {
                    MessageBox.Show("Admin Authenticated Successfully! Name: " + ds.Tables[0].Rows[0][1].ToString(), "Login Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminForm admin = new AdminForm(this);
                    this.txtLoginID.Text = "";
                    this.txtLoginPass.Text = "";
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
