using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._8
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(txbSoA.Text) + int.Parse(txbSoB.Text);
            txbKetQua.Text = "" + sum;
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int tich = int.Parse(txbSoA.Text) * int.Parse(txbSoB.Text);
            txbKetQua.Text = "" + tich;
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu = int.Parse(txbSoA.Text) - int.Parse(txbSoB.Text);
            txbKetQua.Text = "" + hieu;
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int thuong = int.Parse(txbSoA.Text) / int.Parse(txbSoB.Text);
            txbKetQua.Text = "" + thuong;
        }
    }
}
