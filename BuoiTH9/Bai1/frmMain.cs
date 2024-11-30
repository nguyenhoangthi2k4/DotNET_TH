using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }

        public void checkInput(string input,out bool flag)
        {
            flag = true;
            if (int.TryParse(input, out int result) && input != " ")
            {
                if (result < 0)
                {
                    MessageBox.Show("Số nguyên n phải lớn hơn 0");
                    flag = false;
                }
            }   
            else
            {
                MessageBox.Show("Giá trị không hợp lệ");
                flag = false;
            }   
        }

        private void btnKTSHH_Click(object sender, EventArgs e)
        {
            this.checkInput(this.txtSoN.Text, out bool flag);
            if(flag == true)
            {
                frmSoHH frmsoHH = new frmSoHH(int.Parse(this.txtSoN.Text));
                this.Hide();
                frmsoHH.ShowDialog();
                this.Show();
            }
        }

        private void kiểmTraSốHoànHảoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKTSHH_Click(sender, e);
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            this.checkInput(this.txtSoN.Text, out bool flag);
            if (flag == true)
            {
                frmTaoMang frmtaoMang = new frmTaoMang(int.Parse(this.txtSoN.Text));
                this.Hide();
                frmtaoMang.ShowDialog();
                this.Show();                
            }
        }

        private void tạoMảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTaoMang_Click(sender, e);
        }

        private void bntLamLai_Click(object sender, EventArgs e)
        {
            this.txtSoN.Text = string.Empty;
            this.txtSoN.Focus();
        }
    }
}
