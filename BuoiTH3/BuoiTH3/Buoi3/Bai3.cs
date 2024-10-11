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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtSoNguyen.Text);
                int sum = 0;
                string result = string.Empty;
                for (int i = 1; i < n; i++)
                {
                    sum += i;
                    result += "" + i + " + ";
                }
                sum += n;
                result += n.ToString();
                txtStrKetQua.Text = result;
                txtKetQua.Text = sum.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Nhập không phải số nguyên! Nhập lại");
            }
        }
    }
}
