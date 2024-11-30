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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.rdLopA.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(this.txtHoTen.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo");
                this.txtHoTen.Focus();
            }    
            else
            {
                if(this.rdLopA.Checked)                
                    this.lbLopA.Items.Add(this.txtHoTen.Text);                   
                
                if(this.rdLopB.Checked)                
                    this.lbLopB.Items.Add(this.txtHoTen.Text);
                    
                this.txtHoTen.Text = " ";
                this.txtHoTen.Focus();
            }    
        }

        private void btnASangB_Click(object sender, EventArgs e)
        {
            while(this.lbLopA.SelectedIndex != -1)
            {
                this.lbLopB.Items.Add(this.lbLopA.SelectedItem);
                this.lbLopA.Items.RemoveAt(this.lbLopA.SelectedIndex);
            }                 
        }

        private void btnBSangA_Click(object sender, EventArgs e)
        {
            while (this.lbLopB.SelectedIndex != -1)
            {
                this.lbLopA.Items.Add(this.lbLopB.SelectedItem);
                this.lbLopB.Items.Remove(this.lbLopB.SelectedItem);
            }
        }

        private void btnChuyenAllASangB_Click(object sender, EventArgs e)
        {
            foreach(string item in this.lbLopA.Items)            
                this.lbLopB.Items.Add(item);
            this.lbLopA.Items.Clear();            
        }

        private void ChuyenAllBSangA_Click(object sender, EventArgs e)
        {
            foreach (string item in this.lbLopB.Items)
                this.lbLopA.Items.Add(item);
            this.lbLopB.Items.Clear();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if(this.rdLopA.Checked)
            {
                int count = this.lbLopA.Items.Count;
                MessageBox.Show(string.Format("Tổng số sinh viên lớp A là {0}", count));
            } 
            if(this.rdLopB.Checked)
            {
                int count = this.lbLopB.Items.Count;
                MessageBox.Show(string.Format("Tổng số sinh viên lớp B là {0}", count));
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show("Bạn có muốn thoát", "Comfirm", MessageBoxButtons.OK, MessageBoxIcon.Question))
                Close();
        }
    }
}
