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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rdHinhVuong.Checked = true;
            this.txtChieuDai.Enabled = false;
            this.txtChieuRong.Enabled = false;
            this.txtBanKinh.Enabled = false;
        }

        private void rdHinhVuong_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCanh.Enabled = true;
            this.txtCanh.Focus();
            this.txtChieuDai.Enabled = false;
            this.txtChieuRong.Enabled = false;
            this.txtBanKinh.Enabled = false;
        }

        private void rdHinhCN_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCanh.Enabled = false;
            this.txtChieuDai.Enabled = true;
            this.txtChieuDai.Focus();
            this.txtChieuRong.Enabled = true;
            this.txtBanKinh.Enabled = false;
        }

        private void rdHinhTron_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCanh.Enabled = false;
            this.txtChieuDai.Enabled = false;
            this.txtChieuRong.Enabled = false;
            this.txtBanKinh.Enabled = true;
            this.txtBanKinh.Focus();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if(this.rdHinhCN.Checked)
            {
                if(float.TryParse(this.txtChieuDai.Text, out float cd) && float.TryParse(this.txtChieuRong.Text, out float cr) && this.txtChieuDai.Text != "" && this.txtChieuRong.Text != "")
                {
                    if (cd > 0 && cr > 0)
                    {
                        this.txtChieuDai.Text = string.Empty;
                        this.txtChieuRong.Text = string.Empty;
                        this.Hide();
                        frmHinhCN frmHinhCN = new frmHinhCN(cd, cr);
                        frmHinhCN.ShowDialog();
                        this.Show();
                    }
                    else
                        MessageBox.Show("Nhập độ dài phải lớn hơn 0");
                }            
                else                
                    MessageBox.Show("Nhập giá trị không hợp lệ");              
            }
            else if (this.rdHinhVuong.Checked)
            {
                if(float.TryParse(this.txtCanh.Text, out float canh) && this.txtCanh.Text !="")
                {
                    if (canh > 0)
                    {
                        this.txtCanh.Text = string.Empty;
                        this.Hide();
                        frmHinhVuong frmHinhVuong = new frmHinhVuong(canh);
                        frmHinhVuong.ShowDialog();
                        this.Show();
                    }
                    else
                        MessageBox.Show("Nhập độ dài phải lớn hơn 0");
                }
                else                
                    MessageBox.Show("Nhập giá trị không hợp lệ");                
            }   
            else
            {
                if (double.TryParse(this.txtBanKinh.Text, out double bankinh) && this.txtBanKinh.Text !="")
                {
                    if(bankinh > 0)
                    {
                        this.txtBanKinh.Text = string.Empty;
                        this.Hide();
                        frmHinhTron frmHinhTron = new frmHinhTron(bankinh);
                        frmHinhTron.ShowDialog();
                        this.Show();
                    }
                    else
                        MessageBox.Show("Nhập giá trị phải lớn hơn 0");
                }
                else
                {
                    MessageBox.Show("Nhập giá trị không hợp lệ");
                }
            }    
        }

        private void thựcHiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThucHien_Click(sender, e);
        }
    }
}
