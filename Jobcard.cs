using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCare_Pro
{
    public partial class Jobcard : UserControl
    {
        public Jobcard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEmailShow_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            int radius = 12; // change this value

            GraphicsPath path = GetRoundedPath(rect, radius);

            // Fill background
            g.FillPath(new SolidBrush(panel.BackColor), path);

            // Draw border
            g.DrawPath(new Pen(Color.LightGray, 1), path);
        }
        private GraphicsPath GetRoundedPath(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);                          // top-left
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);                  // top-right
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);           // bottom-right
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);                  // bottom-left
            path.CloseFigure();
            return path;
        }
        

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
