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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bar = Convert.ToInt32(textBox1.Text);
            int deg = Convert.ToInt32(textBox2.Text);
            double rad = deg * Math.PI / 180;
            int xo = rectangleShape1.Location.X + rectangleShape1.Width / 2;
            int yo = rectangleShape1.Location.Y + rectangleShape1.Height;

            lineShape1.StartPoint = new Point(xo, yo);
            xo += (int)((double)bar * Math.Sin(rad));
            yo += (int)((double)bar * Math.Cos(rad));
            lineShape1.EndPoint = new Point(xo, yo);

            xo -= ovalShape1.Width / 2;
            yo -= ovalShape1.Height / 2;
            ovalShape1.Location = new Point(xo, yo);
        }
    }
}
