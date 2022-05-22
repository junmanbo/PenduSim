using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            int x0 = rectangleShape1.Location.X + rectangleShape1.Width / 2;
            int y0 = rectangleShape1.Location.Y + rectangleShape1.Height;
            int bar_len = 200; 
            int x, y;

            lineShape1.X1 = x0;
            lineShape1.Y1 = y0;
            lineShape1.X2 = x0;
            lineShape1.Y2 = y0 + bar_len;

            x = x0 - ovalShape1.Width / 2;
            y = y0 + bar_len - ovalShape1.Height / 2;
            ovalShape1.Location = new Point(x, y);

        }

        long msecStart, msecCur;
        private void btnPlay_Click(object sender, EventArgs e)
        {

            
                double deg = Convert.ToDouble(tboxDeg.Text);
                double Pend_Len = Convert.ToDouble(tboxBar.Text);
                double G = Convert.ToDouble(textBox1.Text);
                double B = Convert.ToDouble(textBox3.Text);
                CoefA = G / Pend_Len;
                CoefB = B;
                T = 2 * Math.PI * Math.Sqrt(Pend_Len / G);//주기
                pTime = Convert.ToSingle(lblTick.Text);

            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                btnPlay.Text = "Play";
               

            }
            else
            {
                timer1.Enabled = true;
                btnPlay.Text = "Pause";
                msecStart = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            }

        }
        public void drawPendu(int bar, double deg)
        {

            double x, y;

            x = lineShape1.X1 + bar * Math.Sin(deg);
            y = lineShape1.Y1 + bar * Math.Cos(deg);

            lineShape1.X2 = (int)x;
            lineShape1.Y2 = (int)y;

            x = x - (ovalShape1.Width / 2);
            y = y - (ovalShape1.Height / 2);
            ovalShape1.Location = new Point((int)x, (int)y);
        }
        public bool mPressed = false;
        private void frmPendu_MouseMove(object sender, MouseEventArgs e)
        {

            Point pos = PointToClient(new Point(MousePosition.X, MousePosition.Y));
            double deg;

            //label1.Text = pos.X.ToString();
            if (mPressed == true)
            {
                deg = pos.X - this.Width / 2;
                deg = Math.Atan(deg / (pos.Y - lineShape1.Y1)) / Math.PI * 180;
                tboxDeg.Text = deg.ToString();
            }
        }

        private void frmPendu_MouseDown(object sender, MouseEventArgs e)
        {
            mPressed = true;
            this.Cursor = Cursors.Hand;
        }

        private void frmPendu_MouseUp(object sender, MouseEventArgs e)
        {
            mPressed = false;
            this.Cursor = Cursors.Default;
        }



        private void button1_Click(object sender, EventArgs e)//리셋버튼
        {
            Application.Restart();
        }

        //double pRad, pVel, pAcc;

        private void tboxDeg_TextChanged(object sender, EventArgs e)
        {
            double deg;

            deg = Convert.ToDouble(tboxDeg.Text) / 180 * Math.PI;
            drawPendu(180, deg);
            Pend_Th = deg;
            Pend_dTh = 0;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)//추의 질량
        {
            double Mass = Convert.ToDouble(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//중력 가속도
        {
            double G = Convert.ToDouble(textBox1.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//공기저항
        {
            double B = Convert.ToDouble(textBox3.Text);

        }

        private void tboxBar_TextChanged(object sender, EventArgs e)
        {
            double Pend_Len = Convert.ToDouble(tboxBar.Text) ;
        }

        double CoefA, CoefB, T, V, a, Ek, Ep;

        private void lblTick_Click(object sender, EventArgs e)
        {

        }

        double dT = 0.0001;
        double Pend_Th = Math.PI / 4, Pend_dTh = 0;

        double pTime;

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int i, n;
            double df, deg, rad, time;
            n = (int)(timer1.Interval / (1000 * dT));
            for (i = 0; i < n; i++)
            {
                df = -CoefA * Math.Sin(Pend_Th) - CoefB * Pend_dTh;
                Pend_Th += Pend_dTh * dT;
                Pend_dTh += df * dT;
            }
            deg = Pend_Th;
            //Pend_Th는 애초에 라디안이라 변환필요X
            rad = deg * 180 / Math.PI;
            //얘는 lblDeg에 각도 띄어주기위해서 하는 연산, 위에서 rad선언 해줘야함
            double Pend_Len = Convert.ToDouble(tboxBar.Text);
            double ESum;
            V = Math.Abs(Pend_dTh * Pend_Len);
            double G = Convert.ToDouble(textBox1.Text);
            double Mass = Convert.ToDouble(textBox2.Text);
            a = Math.Abs(G * Math.Sin(deg));
            Ek = Mass * V * V / 2;
            ///Ep = G * Mass * Pend_Len * Math.Sin(deg) * Math.Tan(deg);
            Ep = Mass * G * Pend_Len * 2 * Math.Sin(deg / 2) * Math.Sin(deg / 2);

            ESum = Ek + Ep;
            time = pTime + (double)(msecCur - msecStart) / 1000;
            drawPendu((int)Pend_Len * 100, deg);
            lblDeg.Text = rad.ToString("0.00");
            lblV.Text = V.ToString("0.00");//속력
            lbla.Text = a.ToString("0.00");//가속도
            lblEk.Text = Ek.ToString("0.00");//운동에너지
            lblEp.Text = Ep.ToString("0.00");
            lblSum.Text = ESum.ToString("0.00");
            lblTick.Text = time.ToString("0.000");
            msecCur = DateTimeOffset.Now.ToUnixTimeMilliseconds();

        }
    }
}