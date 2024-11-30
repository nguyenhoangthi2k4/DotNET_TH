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
    public partial class frmHinhVuong : Form
    {
        private float canh;
        public float Canh { get => canh; set => canh = value; }
        public frmHinhVuong(float canh)
        {
            InitializeComponent();
            Canh = canh;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHinhVuong_Load(object sender, EventArgs e)
        {
            float cv = Canh * 4;
            float dt = Canh * Canh;
            this.txtChuVi.Text = cv.ToString();
            this.txtDienTich.Text = dt.ToString();
        }
    }
}
