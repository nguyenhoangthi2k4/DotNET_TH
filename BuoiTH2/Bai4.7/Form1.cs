using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public int GiaThua(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * GiaThua(n-1);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txbN.Text);
            int tich = GiaThua(n);
            txbS.Text = tich.ToString();

        }
    }
}
