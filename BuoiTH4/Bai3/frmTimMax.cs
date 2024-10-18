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
    public partial class frmTimMax : Form
    {
        public int[] arr;
        public frmTimMax(int[] arr)
        {
            InitializeComponent();
            this.arr = arr;
        }

        private void frmTimMax_Load(object sender, EventArgs e)
        {
            string ketQua = "Số lớn nhất = " + this.arr.Max();
            lblTimMax.Text = ketQua;
        }
    }
}
