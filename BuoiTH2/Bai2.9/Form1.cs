using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._9
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            int cv = (int.Parse(txbChieuDai.Text) + int.Parse(txbChieuRong.Text))*2;
            txbKetQua.Text = ""+ cv;
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            int dt = int.Parse(txbChieuDai.Text) * int.Parse(txbChieuRong.Text);
            txbKetQua.Text = "" + dt;
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            double dc = Math.Pow(int.Parse(txbChieuDai.Text), 2) + Math.Pow(int.Parse(txbChieuRong.Text), 2);
            txbKetQua.Text = "" + Math.Sqrt(dc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
