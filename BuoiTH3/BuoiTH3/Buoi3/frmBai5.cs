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
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
;        }

        private void frmBai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                e.Cancel = false;
            else 
                e.Cancel = true;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHoLot.Text == "" || txtTen.Text == "")
                {
                    MessageBox.Show("Chưa nhập họ tên");
                    txtHoLot.Focus();
                } 
                double toan = double.Parse(txtToan.Text);
                double hoa = double.Parse(txtHoa.Text);
                double ly = double.Parse(txtLy.Text);
                double van = double.Parse(txtVan.Text);
                double su = double.Parse(txtSu.Text);
                double dia = double.Parse(txtDia.Text);

                if (toan > 0 && toan <= 10 && hoa > 0 && hoa <= 10 &&
                    ly > 0 && ly <= 10 && van > 0 && van <= 10 &&
                    su > 0 && su <= 10 && dia > 0 && dia <= 10)
                {
                    double dtb = (toan * 2 + van * 2 + su + dia + hoa + ly) / 8;
                    txtDtb.Text = dtb.ToString();
                }
                else
                {
                    MessageBox.Show("Nhập điểm phải từ 0-10!");
                }    

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập số điểm");
            }
        }
    }
}
