using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3
{
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtSoNguyen.Text);
                double x = double.Parse(txtSoThuc.Text);
                string kq1 = "x";
                string kq2 = x.ToString();
                string kq3 = x.ToString();
                double sum = x;
                for (int i = 2; i <= n; i++)
                {
                    kq1 += string.Format(" + x^{0} ", i);
                    kq2 += string.Format(" + {0}^{1}", x, i);
                    kq3 += string.Format(" + {0}", Math.Pow(x, i));
                    sum += Math.Pow(x, i);
                }
                txtKetQua1.Text = kq1;
                txtKetQua2.Text = kq2;
                txtKetQua3.Text = kq3;
                txtKetQua4.Text = sum.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Nhập không hợp lệ! Nhập lại");
            }
        }
    }
}
