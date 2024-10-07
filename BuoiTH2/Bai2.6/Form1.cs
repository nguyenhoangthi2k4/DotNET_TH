using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = int.Parse(txbSoA.Text) + int.Parse(txbSoB.Text);
            MessageBox.Show(""+tong);
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu = int.Parse(txbSoA.Text) - int.Parse(txbSoB.Text);
            MessageBox.Show("" + hieu);
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int tich = int.Parse(txbSoA.Text) * int.Parse(txbSoB.Text);
            MessageBox.Show("" + tich);
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int thuong = int.Parse(txbSoA.Text) / int.Parse(txbSoB.Text);
            MessageBox.Show("" + thuong);
        }
    }
}
