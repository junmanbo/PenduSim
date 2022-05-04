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
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }

        private void txtData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtData.Text = "";
        }
    }
}
