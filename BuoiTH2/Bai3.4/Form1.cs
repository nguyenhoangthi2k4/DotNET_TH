using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txbSoA.Text);
            int b = int.Parse(txbSoB.Text);
            int c = int.Parse(txbSoC.Text);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        txbKetQua.Text = "Phương trình có vô số nghiệm";
                    else
                        txbKetQua.Text = "Phương trình vô nghiệm";
                }
                else
                    txbKetQua.Text = "Nghiệm = " + (-c / b);
            }    
            else
            {
                double dt = b*b-4*a*c;
                if (dt > 0)
                {
                    double x1 = (-b - Math.Sqrt(dt)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(dt)) / (2 * a);
                    txbKetQua.Text = "Nghiệm phương trình: x1 = " + x1 + " và x2 =" + x2;
                }
                else if (dt == 0)
                {
                    double x = -b / (2 * a);
                    txbKetQua.Text = "Nghiệm phương trình x = " + x;
                }
                else
                    txbKetQua.Text = "Phương trình vô nghiệm";
            }    
        }
    }
}
