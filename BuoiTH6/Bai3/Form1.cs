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
        public frmMain()
        {
            InitializeComponent();
        }
          
       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(this.txtMaSo.Text == "" || this.txtHoTen.Text == "" || this.txtDiaChi.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtHoTen.Focus();
            }
            else
            {
                ListViewItem listViewItem = new ListViewItem(this.txtMaSo.Text);              
                listViewItem.SubItems.Add(this.txtHoTen.Text);
                listViewItem.SubItems.Add(this.txtDiaChi.Text);
                listViewItem.SubItems.Add(this.dtpNgaySinh.Value.ToShortDateString());
                listViewItem.SubItems.Add(this.cbLop.SelectedItem.ToString());

                this.txtMaSo.Text = string.Empty;
                this.txtHoTen.Text = string.Empty;
                this.txtDiaChi.Text = string.Empty;
                
                lvDanhSach.Items.Add(listViewItem);                
            }        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while(this.lvDanhSach.SelectedItems.Count > 0)            
                this.lvDanhSach.Items.Remove(this.lvDanhSach.SelectedItems[0]);              
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbLop.SelectedIndex = 0;
        }
    }
}
