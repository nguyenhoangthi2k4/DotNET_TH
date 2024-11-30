using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmSoHH : Form
    {
        private int soN;
        public int SoN { get => soN; set => soN = value; }
        public frmSoHH(int n)
        {
            InitializeComponent();
            SoN = n;
        }  
        public bool ktSoHH(int n)
        {
            int sum = 1;
            for (int i = 2; i <= n/2; i++)
                if (n % i == 0)
                    sum += i;
            return sum == n ? true : false;
        }
        private void frmSoHH_Load(object sender, EventArgs e)
        {
            if (this.ktSoHH(soN))
                this.lblKetQua.Text = soN + " là số hoàn hảo";
            else
                this.lblKetQua.Text = soN + " không là số hoàn hảo";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
