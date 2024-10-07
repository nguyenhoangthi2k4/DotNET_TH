using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool KiemTraNamNhuan(int y)
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                return true;
            else 
                return false;
        }
        public bool KiemTraHopLe(int d, int m, int y)
        {
            bool flag = true;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (d >31) 
                        flag = false;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (d >30)
                            flag = false;
                    break;
                case 2:
                    if(KiemTraNamNhuan(y))
                    {
                        if(d>29)
                            flag = false;
                    }    
                    else
                    {
                        if (d > 28)
                            flag = false;
                    }
                    break;
                default:
                    flag = false; 
                    break;     
            } 
            return flag;
        }
 

        private void btnKiemTra_Click_1(object sender, EventArgs e)
        {
            int day = int.Parse(txbNgay.Text);
            int month = int.Parse(txbThang.Text);
            int year = int.Parse(txbNam.Text);
            if (KiemTraHopLe(day, month, year))
                MessageBox.Show("Ngày hợp lệ");
            else
                MessageBox.Show("Ngày không hợp lệ");
        }
    }
}
