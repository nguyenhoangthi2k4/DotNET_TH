using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int n = int.Parse(txbN.Text);
            for (int i = 0; i <= n; i++)
            {
                sum += i * i;
            }
            txbS.Text = sum.ToString();
        }
    }
}
