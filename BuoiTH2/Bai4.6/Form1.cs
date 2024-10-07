using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int n = int.Parse(txbN.Text);
            for (int i = 1; i <= (2 * n - 1); i += 2)
                sum += 1.0 / i;
            txbS.Text = sum.ToString();
        }
    }
}
