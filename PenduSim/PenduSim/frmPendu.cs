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
        frmData dWin;
        double pBar, pDeg, pVel, pVC, pMass, pTime;
        long mTime;
        public frmPendu()
        {
            InitializeComponent();
        }
        private void frmPendu_Load(object sender, EventArgs e)
        {
            dWin = new frmData();
            dWin.Show();
            dWin.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            btnReset.PerformClick();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                btnStart.Text = "Stop";
                timer1.Enabled = true;
                if (mTime == 0)
                    mTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            }
            else
            {
                btnStart.Text = "Start";
                timer1.Enabled = false;
            }
        }
        private void drawPendu(double bar, double deg)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            pBar = trkBar.Value;
            pDeg = trkDeg.Value;
            pVC = (double)trkVC.Value / 1000;
            drawPendu(pBar, pDeg);
            pVel = 0;
            pMass = 0.5;
            pTime = 0;
            mTime = 0;
        }

        private void trkVC_Scroll(object sender, EventArgs e)
        {
            txtVC.Text = ((double)trkVC.Value / 1000).ToString("0.###");
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

        //int PendInc = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            double ddf, df = pVel;
            double rad = pDeg * Math.PI / 180;
            double pl = pBar / 100;
            double dt = 0.00011;
            long msec = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            dWin.txtData.AppendText(pTime.ToString("0.00") + ", " +
                pDeg.ToString("0.0") + ", " + pVel.ToString("0.00") +
                Environment.NewLine);
            label1.Text = ((double)(msec - mTime) / 1000).ToString("0.000");
            for (int i = 0; i < 1000; i++)
            {
                ddf = -9.8 / pl * Math.Sin(rad) - pVC / (pMass * pl) * df;
                rad = rad + df * dt;
                df = df + ddf * dt;
                pTime += dt;
            }
            pDeg = rad * 180 / Math.PI;
            pVel = df;
            drawPendu(pBar, pDeg);
        }
    }
}
