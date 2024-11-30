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
    
    public partial class frmHinhTron : Form
    {
        private double banKinh;

        public double BanKinh { get => banKinh; set => banKinh = value; }

        public frmHinhTron(double bankinh)
        {
            InitializeComponent();
            BanKinh = bankinh;
        }

        private void frmHinhTron_Load(object sender, EventArgs e)
        {
            double cv = 2 * 3.14 * BanKinh;
            double dt = 3.14 * BanKinh * BanKinh;
            this.txtChuVi.Text = cv.ToString(); 
            this.txtDienTich.Text = dt.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
