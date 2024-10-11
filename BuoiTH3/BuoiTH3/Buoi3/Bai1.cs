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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                int max = (a>b && a>c) ? a : (b>c ? b : c);
                int min = (a<b && a<c) ? a : (b<c ? b : c);
                txtMax.Text = max.ToString();
                txtMin.Text = min.ToString();
            }
            catch
            {
                MessageBox.Show("Nhập không hợp lệ!");
            }
        }
    }
}
