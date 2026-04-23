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
            pnlCustomer.Resize += (s, e) =>
            {
                pnlCustomer.Region = new Region(GetRoundedRect(pnlCustomer.ClientRectangle, 15));
            };
        }
        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void pnlCustomer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = pnlCustomer.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            // Shadow (draw slightly offset)
            using (GraphicsPath shadowPath = GetRoundedRect(
                new Rectangle(rect.X + 3, rect.Y + 3, rect.Width, rect.Height), 15))
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, Color.Black)))
            {
                e.Graphics.FillPath(shadowBrush, shadowPath);
            }

            // Main border
            using (GraphicsPath path = GetRoundedRect(rect, 15))
            using (Pen pen = new Pen(Color.LightGray, 2))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblModelHolder_Click(object sender, EventArgs e)
        {

        }

        private void lblVehicleYear_Click(object sender, EventArgs e)
        {

        }

        private void lblPlateNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblPlateNumberHolder_Click(object sender, EventArgs e)
        {

        }

        private void lblModel_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Jobcard_Load(object sender, EventArgs e)
        {

        }

        private void lblHourRow3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblStatusTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
