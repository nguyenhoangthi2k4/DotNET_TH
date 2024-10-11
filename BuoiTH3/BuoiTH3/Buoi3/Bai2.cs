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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void txtSoNguyen_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    int n = int.Parse(txtSoNguyen.Text);
                    string res;
                    switch (n)
                    {
                        case 0:
                            res = "Không";
                            break;
                        case 1:
                            res = "Một";
                            break;
                        case 2:
                            res = "Hai";
                            break;
                        case 3:
                            res = "Ba";
                            break;
                        case 4:
                            res = "Bốn";
                            break;
                        case 5:
                            res = "Năm";
                            break;
                        case 6:
                            res = "Sáu";
                            break;
                        case 7:
                            res = "Bảy";
                            break;
                        case 8:
                            res = "Tám";
                            break;
                        case 9:
                            res = "Chín";
                            break;
                        default:
                            res = "Nhập không hợp lệ";
                            break;
                    }
                    txtKetQua.Text = res;
                } 
            }
            catch (Exception)
            {
                txtKetQua.Text = "Nhập không phải là số nguyên";
                txtKetQua.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
