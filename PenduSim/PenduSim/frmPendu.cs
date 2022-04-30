using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenduSim
{
    public partial class frmPendu : Form
    {
        public frmPendu()
        {
            InitializeComponent();
        }
        private void frmPendu_Load(object sender, EventArgs e)
        {
            int bar = Convert.ToInt32(txtBar.Text);
            int deg = Convert.ToInt32(txtDeg.Text);

            drawPendu(bar, deg);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int bar = Convert.ToInt32(txtBar.Text);
            int deg = Convert.ToInt32(txtDeg.Text);
            int inc = 1;

            if (btnStart.Text == "Start")
            {
                btnStart.Text = "Stop";
                while (btnStart.Text == "Stop")
                {
                    drawPendu(bar, deg);
                    Application.DoEvents();
                    Thread.Sleep(30);
                    deg += inc;
                    if (deg > 60 || deg < -60)
                    {
                        inc = -inc;
                    }
                }
            }
            else
            {
                btnStart.Text = "Start";
            }
        }
        private void drawPendu(int bar, int deg)
        {
            double rad = deg * Math.PI / 180;
            int xo = pendCeiling.Location.X + pendCeiling.Width / 2;
            int yo = pendCeiling.Location.Y + pendCeiling.Height;

            pendBar.StartPoint = new Point(xo, yo);
            xo += (int)((double)bar * Math.Sin(rad));
            yo += (int)((double)bar * Math.Cos(rad));
            pendBar.EndPoint = new Point(xo, yo);

            xo -= pendBall.Width / 2;
            yo -= pendBall.Height / 2;
            pendBall.Location = new Point(xo, yo);
        }

        private void trkBar_Scroll(object sender, EventArgs e)
        {
            int bar = trkBar.Value;
            int deg = Convert.ToInt32(txtDeg.Text);

            txtBar.Text = trkBar.Value.ToString();
            drawPendu(bar, deg);
        }

        private void trkDeg_Scroll(object sender, EventArgs e)
        {
            int bar = Convert.ToInt32(txtBar.Text);
            int deg = trkDeg.Value;

            txtDeg.Text = trkDeg.Value.ToString();
            drawPendu(bar, deg);
        }
        private bool mPress = false;

        private void frmPendu_MouseDown(object sender, MouseEventArgs e)
        {
            mPress = true;
        }

        private void frmPendu_MouseUp(object sender, MouseEventArgs e)
        {
            mPress = false;
        }

        private void frmPendu_MouseMove(object sender, MouseEventArgs e)
        {
            int xo = pendCeiling.Location.X + pendCeiling.Width / 2;
            int yo = pendCeiling.Location.Y + pendCeiling.Height;
            int bar = Convert.ToInt32(txtBar.Text);
            int deg;
            double x = e.Location.X - xo;
            double y = e.Location.Y - yo;

            if (mPress)
            {
                // 각도 계산
                deg = (int)(Math.Atan2(x, y) * 180 / Math.PI);
                trkDeg.Value = deg;
                txtDeg.Text = deg.ToString();
                drawPendu(bar, deg);
                //pendBall.Location = e.Location;
            }

        }

    }
}
