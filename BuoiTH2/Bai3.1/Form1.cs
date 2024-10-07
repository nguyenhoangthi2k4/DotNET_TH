using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float x = float.Parse(txbX.Text);
            if (x >= 2)
            {
                txbY.Text = "" + ((-8) * x * x * x - 12 * x - 1);
            }
            else if (x > 1 && x < 2)
            {
                txbY.Text = "" + (x * x - 6 * x - 19);
            }
            else
            { txbY.Text = "" + (7 * x); }
        }
    }
}
