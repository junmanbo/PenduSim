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
    public partial class frPen : Form
    {
    
        long msecStart, msecCur;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(tbDeg.Text) || String.IsNullOrWhiteSpace(tbBar.Text) ||String.IsNullOrWhiteSpace(tbM.Text))
            {
                MessageBox.Show("텍스트 박스를 모두 입력해 주세요");
            }
            else
            {
                double a = Convert.ToDouble(tbBar.Text);
                double b = Convert.ToDouble(tbM.Text);
                double c = Convert.ToDouble(tbDeg.Text);
                if (a == 0)
                { MessageBox.Show("줄의 길이를 0 이상으로 입력해 주십시오."); }
                else if (b == 0)
                { MessageBox.Show("질량을 0 이상으로 입력해 주십시오."); }
                else if (c == 0)
                { MessageBox.Show("각도를 0 이상으로 입력해 주십시오."); }
                else
                {
                    double deg = Convert.ToDouble(tbDeg.Text);
                    double Pend_Len = Convert.ToDouble(tbBar.Text);
                    double Mass = Convert.ToDouble(tbM.Text);
                    //double Velocity = Convert.ToDouble(lblV.Text);
                    double G = selectPlanet();
                    CoefB = selectAR();
                    CoefA = G / Pend_Len;
                    pTime = Convert.ToSingle(lblSec.Text);
                    T = 2 * Math.PI / Math.Sqrt(Math.Abs(CoefA - (V * CoefB / (Mass * Pend_Len * Math.Sin(deg)))));//주기

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
            }
        }
        private void frPen_Load(object sender, EventArgs e)
        {
            cb_G.SelectedIndex = 0;
            cb_AR.SelectedIndex = 0;
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
        public void drawPendu(double bar, double deg)
        {
            if (bar == 0)
            { }
            else
            {
                double x, y;

                x = lineShape1.X1 + bar * Math.Sin(deg);
                y = lineShape1.Y1 + bar * Math.Cos(deg);

                lineShape1.X2 = (int)x;
                lineShape1.Y2 = (int)y;

                x = x - (ovalShape1.Width / 2);
                y = y - (ovalShape1.Height / 2);
                ovalShape1.Location = new Point((int)x, (int)y);


                double VV = Convert.ToSingle(lblV.Text);
                if (VV > 0)
                {
                    VRArrow.Location = new Point(((int)x + ovalShape1.Width / 2) + 5 + 10, ((int)y - ovalShape1.Width / 4 - 20));
                    VLArrow.Location = new Point(10000, 10000);
                }
                else if (VV < 0)
                {
                    VLArrow.Location = new Point(((int)x - 2 * ovalShape1.Width) - 10, (int)y - ovalShape1.Width / 4 - 20);
                    VRArrow.Location = new Point(10000, 10000);
                }
                else
                {
                    VRArrow.Location = new Point(10000, 10000);
                    VLArrow.Location = new Point(10000, 10000);
                }
                double a = Convert.ToSingle(lblA.Text);
                if (a < 0)
                {
                    ALArrow.Location = new Point(((int)x - 2 * ovalShape1.Width) - 10, ((int)y - ovalShape1.Width / 4));
                    ARArrow.Location = new Point(10000, 10000);
                }
                else if (a > 0)
                {
                    ARArrow.Location = new Point(((int)x + ovalShape1.Width / 2) + 5 + 10, ((int)y - ovalShape1.Width / 4));
                    ALArrow.Location = new Point(10000, 10000);
                }
                else
                {
                    ARArrow.Location = new Point(10000, 10000);
                    ALArrow.Location = new Point(10000, 10000);
                }

                int ang = Math.Abs((int)(VV * 15));
                int fang = Math.Abs((int)(a * 15));
                //int a = (int)keep; // 진공이외의 매질의경우

                VRArrow.Size = new Size(ang, ang);
                VLArrow.Size = new Size(ang, ang);
                ARArrow.Size = new Size(fang, fang);
                ALArrow.Size = new Size(fang, fang);
            }
        }
        public frPen()
        {
            InitializeComponent();
        }


    
        private void frPen_MouseDown(object sender, MouseEventArgs e)
        {
            mPressed = true;
            this.Cursor = Cursors.Hand;
        }

        private void frPen_MouseUp(object sender, MouseEventArgs e)
        {
            mPressed = false;
            this.Cursor = Cursors.Default;
        }



        private void button1_Click(object sender, EventArgs e)//리셋버튼
        {
            Application.Restart();
        }

        public bool mPressed = false;
    
        private void tbBar_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnPlay.Text = "Play";
            if (String.IsNullOrWhiteSpace(tbBar.Text))
            {

            }
            else
            {
                double Pend_Len = Convert.ToDouble(tbBar.Text);
            }

        }
        private void tbDeg_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnPlay.Text = "Play";
            double deg;
            if (String.IsNullOrWhiteSpace(tbDeg.Text))
            {

            }
            else
            {
                deg = Convert.ToDouble(tbDeg.Text) / 180 * Math.PI;
                drawPendu(180, deg);
                Pend_Th = deg;
                Pend_dTh = 0;
            }
        }

        private void tbM_TextChanged(object sender, EventArgs e)//추의 질량
        {
            timer1.Enabled = false;
            btnPlay.Text = "Play";
            if (String.IsNullOrWhiteSpace(tbM.Text))
            {

            }
            else
            {
                double Mass = Convert.ToDouble(tbM.Text);
            }
        }

        private void frPen_MouseMove(object sender, MouseEventArgs e)
        {

            Point pos = PointToClient(new Point(MousePosition.X, MousePosition.Y));
            double deg;

            if (mPressed == true)
            {
                deg = pos.X - this.Width / 2;
                deg = Math.Atan(deg / (pos.Y - lineShape1.Y1)) / Math.PI * 180;
                tbDeg.Text = deg.ToString();
            }
        }

        private void cb_G_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnPlay.Text = "Play";
            double G = selectPlanet();
           // lbl_G.Text = G.ToString("0.000");
            int a=cb_G.SelectedIndex;
            if (a == 2)
            {
            }
            else  
            {
                cb_AR.SelectedIndex = 0;
            }
        }
        private void cb_AR_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnPlay.Text = "Play";
        }

        public double selectAR()
        {
            int a = cb_AR.SelectedIndex;
            double B = 0;
            switch (a)
            {
                case 0:
                    B = 0;
                    break;
                case 1:
                    B = 0.0323;
                    break;
                case 2:
                    B = 2.0894;
                    break;
            }
            return B;
        }

        public double selectPlanet()
        {
            int a = cb_G.SelectedIndex;
            double G = 0;
            switch (a)
            {
                case 0:
                    G = 9.806;
                    //this.BackgroundImage = new Bitmap(PenduSim.Properties.Resources.지구);
                    break;
                case 1:
                    G = 1.63;
                    //this.BackgroundImage = new Bitmap(PenduSim.Properties.Resources.달);
                    break;
            }
            return (G);
        }

        double CoefA, CoefB, T, V, a, Ek, Ep;

        private void tbM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == 46))

            {   //숫자와 백스페이스, 마침표를 제외한 나머지를 바로 처리

                e.Handled = true;

            }
        }

        private void lbA_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void VLArrow_Click(object sender, EventArgs e)
        {

        }

        private void tbDeg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == 46))

            {   //숫자와 백스페이스, 마침표를 제외한 나머지를 바로 처리

                e.Handled = true;

            }
        }

        private void tbBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == 46))

            {   //숫자와 백스페이스, 마침표를 제외한 나머지를 바로 처리

                e.Handled = true;

            }
        }

        double dT = 0.0001;
        double Pend_Th = Math.PI / 4, Pend_dTh = 0;//각도,각속도 선언
        double df;   
        double pTime;

        private void timer1_Tick(object sender, EventArgs e)
        {

            int i, n;
            double deg, rad, time;
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
            // lblDegCh에 각도 띄어주기위해서 하는 연산, 위에서 rad선언 해줘야함
            double Pend_Len = Convert.ToDouble(tbBar.Text);
            double ESum;
            
            V = Pend_dTh * Pend_Len;
            double G = selectPlanet();
            double Mass = Convert.ToDouble(tbM.Text);
            a = df * Pend_Len;
            Ek = Mass * V * V / 2;
            Ep = Mass * G * Pend_Len * 2 * Math.Sin(deg / 2) * Math.Sin(deg / 2);
            ESum = Ek + Ep;
            time = pTime + (double)(msecCur - msecStart) / 1000;
            drawPendu(Pend_Len * 100, deg);
            lblDegCh.Text = rad.ToString("0.00");//각도
            lblV.Text = V.ToString("0.00");//속력
            lblA.Text = a.ToString("0.00");//가속도
            lblEk.Text = Ek.ToString("0.00");//운동에너지
            lblEp.Text = Ep.ToString("0.00");//위치에너지
            lblSum.Text = ESum.ToString("0.00");//위치,운동 에너지의 합
            lblSec.Text = time.ToString("0.000");//경과시간
            msecCur = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            if (CoefB == 0)
            { lblCy.Text = T.ToString("0.00"); }
            else
            { lblCy.Text = "-"; }


            chart2.Series[0].Points.Add(Ek);//운동에너지 그래프
            chart2.Series[1].Points.Add(Ep);//위치에너지 그래프
            chart1.Series[0].Points.Add(rad);//각도 그래프
            chart3.Series[0].Points.Add(V);//속도 그래프
            chart3.Series[1].Points.Add(a);//가속도 그래프

        }

    }
}