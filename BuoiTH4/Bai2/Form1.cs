using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmMain : Form
    {
        int n;
        int[] arr = new int[100];
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (this.txtInput.Text == "")
                MessageBox.Show("Chưa nhập số phần tử");
            else if (int.TryParse(this.txtInput.Text, out n) == true)
            {
                if (int.Parse(this.txtInput.Text) <= 0)
                    MessageBox.Show(string.Format("Bạn vừa nhập số phần tử = {0} không họp lệ", this.txtInput.Text));
                else
                {
                    Random random = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        this.arr[i] = random.Next(-10, 100);
                    }
                    this.btnInMang.Enabled = true;
                    this.btnTimMax.Enabled = true;
                }
            }
            else
                MessageBox.Show("Nhập không hợp lệ");
        }

        private void btnInMang_Click(object sender, EventArgs e)
        {
            string outPut = "Các phần tử trong mảng: \n";
            for (int i = 0; i < n; i++)
            {
                outPut += this.arr[i].ToString() + "; ";
                this.lblKetQua.Text = outPut;
            }
        }

        private void btnTimMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Số lớn nhất trong mảng là: " + this.arr.Max()));
        }
    }
}
