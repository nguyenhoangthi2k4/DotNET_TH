using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class frmHinhCN : Form
    {
        private float cd, cr;
       
        public float Cd { get => cd; set => cd = value; }
        public float Cr { get => cr; set => cr = value; }

        private void frmHinhCN_Load(object sender, EventArgs e)
        {
            float cv = (Cd + Cr) * 2;
            float dt = Cd * Cr;
            this.txtChuVi.Text = cv.ToString();
            this.txtDienTich.Text = dt.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmHinhCN(float cd, float cr)
        {
            InitializeComponent();
            Cd = cd;
            Cr = cr;
        }

    }
}
