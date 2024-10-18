using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmMain : Form
    {
        // Các biến toàn cục 
        int[] arr = new int[100];
        int SoPT = 0;

        public frmMain()
        {
            InitializeComponent();
            this.btnIn.Enabled = false;
        }

        // Phương thức thêm 1 phần tử vào mảng
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(this.SoPT == this.arr.Length)
            {
                txtNhap.Text = "";
                MessageBox.Show("Mảng đã đầy!");
            }    
            else
            {
                int pt;
                if (int.TryParse(txtNhap.Text, out pt) == true)
                { 
                    arr[this.SoPT++] = int.Parse(this.txtNhap.Text);
                    this.txtNhap.Clear();
                    this.txtNhap.Focus();
                    if (this.SoPT > 0)
                    {
                        this.btnIn.Enabled = true;
                        this.btnXoa.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập không hợp lệ!");
                    this.txtNhap.Clear();
                    this.txtNhap.Focus();
                }
            }    

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string ketQua = "Các phần tử trong mảng\n";
            for (int i = 0; i < SoPT; i++)
            {
                ketQua += arr[i].ToString() + "; ";
            }
            this.lblKetQua.Text = ketQua;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.SoPT = 0;
            this.arr = new int[100];
            lblKetQua.Text = "";
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SoPT; i++)
            {
                for (int j = 0; j < SoPT; j++)
                {
                    if (this.arr[i] > this.arr[j])
                    {
                        int tmp = this.arr[i];
                        this.arr[i] = this.arr[j];
                        this.arr[j] = tmp;
                    }
                }
            }
            this.btnIn_Click(sender, e);
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SoPT; i++)
            {
                for (int j = 0; j < SoPT; j++)
                {
                    if (this.arr[i] < this.arr[j])
                    {
                        int tmp = this.arr[i];
                        this.arr[i] = this.arr[j];
                        this.arr[j] = tmp;
                    }
                }
            }
            this.btnIn_Click(sender, e);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0;i < SoPT;i++)
                sum += this.arr[i];
            MessageBox.Show(string.Format("Tổng là " +  sum ) );
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Số lớn nhất là: " + this.arr.Max()));
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = this.arr[0];
            for(int i = 0;i< this.SoPT;i++)
                if (this.arr[i] < min)
                    { min = this.arr[i]; }
            MessageBox.Show(string.Format("Số nhỏ nhất là: " + min.ToString()));
        }

        private void btnTrungBinhMang_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < SoPT; i++)
                sum += this.arr[i];
            MessageBox.Show(string.Format("Trung bình là: {0:F3}" ,1.0*sum/SoPT));
        }

        public bool isPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            string ketQua = "Các số nguyên tố: ";
            for (int i = 0; i < SoPT; i++)
                if (isPrime(this.arr[i]))
                    ketQua += this.arr[i].ToString() + "; ";
            MessageBox.Show(ketQua);
        }

        public bool isPerfect(int n)
        {
            int sum = 0;
            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    sum += i;
            if (sum == n)
                return true;
            else return false;
        }
        private void btnSHH_Click(object sender, EventArgs e)
        {
            string ketQua = "Các số nguyên tố: ";
            for (int i = 0; i < SoPT; i++)
                if (isPerfect(this.arr[i]))
                    ketQua += this.arr[i].ToString() + "; ";
            MessageBox.Show(ketQua);
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < SoPT; i++)
                if (this.arr[i]%2==0) 
                    dem++;
            MessageBox.Show(string.Format("Có {0} số chẵn",dem));
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < SoPT; i++)
                if (this.arr[i] % 2 == 1)
                    dem++;
            MessageBox.Show(string.Format("Có {0} số lẻ", dem));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int so1 = this.arr[0];
            int so2 = this.arr[1];
            while(so2!=0)
            {
                int tmp = so1 % so2;
                so1 = so2;
                so2 = tmp;
            }
            MessageBox.Show(string.Format("UCLN của 2 số đầu là: {0}", so1));
        }
    }
}
