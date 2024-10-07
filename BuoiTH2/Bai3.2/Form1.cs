using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int month = int.Parse(txbThang.Text);
            if (month <= 3)
                MessageBox.Show("Mùa Xuân");
            else if (month <= 6)
                MessageBox.Show("Mùa Hạ");
            else if (month <= 9)
                MessageBox.Show("Mùa Thu");
            else if (month <= 12)
                MessageBox.Show("Mùa Đông");
            else
                MessageBox.Show("Nhập không hợp lệ");
        }
    }
}
