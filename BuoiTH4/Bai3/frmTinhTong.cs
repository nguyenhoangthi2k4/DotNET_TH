using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmTinhTong : Form
    {
        public int soPt;
        public int[] arr;
        
        public frmTinhTong(int soPt, int[] arrCopy)
        {
            InitializeComponent();
            this.arr = (int[])arrCopy.Clone();
            this.soPt = soPt;
        }

        public int sum()
        {
            int sum = 0;
            for(int i = 0; i< this.soPt; i++)
                sum += this.arr[i];
            return sum;
        }
        private void frmTinhTong_Load(object sender, EventArgs e)
        {
            string ketQua = "Tổng các phần tử trong mảng = " + sum();
            lblTinhTong.Text = ketQua;
        }
    }
}
