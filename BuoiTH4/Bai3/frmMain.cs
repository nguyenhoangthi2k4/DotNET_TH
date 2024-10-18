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
    public partial class frmMain : Form
    {
        public int soPT;
        public int[] arr = new int[100];

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string inMang()
        {
            string ketQua = "Các phần tử trong mảng: ";
            for (int i = 0; i < this.soPT; i++)
            {
                ketQua += this.arr[i] + "; ";
            }
            return ketQua;
        }
        private void btnTaoMangNN_Click(object sender, EventArgs e)
        {
            if (this.txtInPut.Text != "")
            {
                if (int.TryParse(this.txtInPut.Text, out soPT) == true)
                {
                    if (this.soPT > 0)
                    {
                        Random random = new Random();
                        for (int i = 0; i < this.soPT; i++)
                            this.arr[i] = random.Next(-10, 100);
                        MessageBox.Show(this.inMang());
                        this.btnTinhTong.Enabled = true;
                        this.btnTimMax.Enabled = true;
                    }    
                    else
                    {
                        MessageBox.Show(string.Format("Bạn vừa nhập số phần tử = {0} < 0", this.soPT));
                        txtInPut.Focus();
                    }                       
                }
                else
                {
                    MessageBox.Show("Nhập giá trị không hợp lệ");
                    txtInPut.Focus();
                }    
            }
            else
            { 
                MessageBox.Show("Chưa nhập số phần tử");
                txtInPut.Focus();
            }    
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            string question = this.inMang() + " Bạn có muốn tính tổng?";
            DialogResult result = MessageBox.Show(question,"Thông báo", MessageBoxButtons.YesNo);
            if ( result == DialogResult.Yes)
            { 
                this.Hide();
                frmTinhTong frmTinhTong = new frmTinhTong(soPT,arr);
                frmTinhTong.ShowDialog();
                this.Show();
            }
        }

        private void btnTimMax_Click(object sender, EventArgs e)
        {
            string question = this.inMang() + " Bạn có muốn tìm số lớn nhất?";
            DialogResult result = MessageBox.Show(question, "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmTimMax frmTimMax = new frmTimMax(arr);
                frmTimMax.ShowDialog();
                this.Show();
            }
        }
    }
}
