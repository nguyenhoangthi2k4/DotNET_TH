using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] quequan = { "An Giang", "Đồng Tháp", "Kiên Giang", "Tp Hồ Chí Minh", "Khác" };
            this.cbQueQuan.Items.AddRange(quequan);             
            this.cbQueQuan.SelectedIndex = 0;

            this.rdNam.Checked = true;
            this.txtMaSV.Focus();

            this.lvDanhSach.Columns.Add("Mã số SV", 100);
            this.lvDanhSach.Columns.Add("Họ tên", 200);
            this.lvDanhSach.Columns.Add("Phái", 100);
            this.lvDanhSach.Columns.Add("Điện thoại", 100);
            this.lvDanhSach.Columns.Add("Ngày sinh", 110);
            this.lvDanhSach.Columns.Add("Quê quán", 120);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(this.txtMaSV.Text == "" || this.txtHoTen.Text == "" || this.txtDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá trị !", "Thông báo");
                this.txtMaSV.Focus();
            }
            else
            {
                ListViewItem listViewItem = new ListViewItem(this.txtMaSV.Text);                
                listViewItem.SubItems.Add(this.txtHoTen.Text);
                if(this.rdNam.Checked )
                    listViewItem.SubItems.Add(this.rdNam.Text);
                else
                    listViewItem.SubItems.Add(this.rdNu.Text);
                listViewItem.SubItems.Add(this.txtDienThoai.Text);
                listViewItem.SubItems.Add(this.dtpNgaySinh.Value.ToShortDateString());
                listViewItem.SubItems.Add(this.cbQueQuan.SelectedItem.ToString());

                this.txtMaSV.Text = string.Empty;
                this.txtHoTen.Text = string.Empty;
                this.txtDienThoai.Text = string.Empty;
                this.cbQueQuan.SelectedIndex = 0;

                lvDanhSach.Items.Add(listViewItem);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                while (this.lvDanhSach.SelectedItems.Count > 0)            
                    this.lvDanhSach.Items.RemoveAt(this.lvDanhSach.SelectedItems[0].Index);            
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
                           
            if(this.lvDanhSach.SelectedItems.Count >0)
            {
                this.txtMaSV.ReadOnly = true;
                ListViewItem item = this.lvDanhSach.SelectedItems[0];
                this.txtMaSV.Text = item.SubItems[0].Text;
                this.txtHoTen.Text = item.SubItems[1].Text;
                if (item.SubItems[2].Text == "Nam")
                    this.rdNam.Checked = true;
                else
                    this.rdNu.Checked = true;
                this.txtDienThoai.Text = item.SubItems[3].Text;
                this.dtpNgaySinh.Text = item.SubItems[4].Text;
                this.cbQueQuan.Text = item.SubItems[5].Text;
            } 
            else
            {
                this.txtMaSV.ReadOnly= false;
                this.txtMaSV.Text = string.Empty;
                this.txtHoTen.Text = string.Empty;
                this.txtDienThoai.Text = string.Empty;
                this.cbQueQuan.SelectedIndex = 0;
            }                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                if(this.lvDanhSach.SelectedItems.Count > 0)
                {
                    this.lvDanhSach.SelectedItems[0].SubItems[0].Text = this.txtMaSV.Text;
                    this.lvDanhSach.SelectedItems[0].SubItems[1].Text = this.txtHoTen.Text;
                    if(this.rdNam.Checked)
                        this.lvDanhSach.SelectedItems[0].SubItems[2].Text = this.rdNam.Text;
                    else
                        this.lvDanhSach.SelectedItems[0].SubItems[2].Text = this.rdNu.Text;
                    this.lvDanhSach.SelectedItems[0].SubItems[3].Text = this.txtDienThoai.Text;
                    this.lvDanhSach.SelectedItems[0].SubItems[4].Text = this.dtpNgaySinh.Value.ToShortDateString();
                    this.lvDanhSach.SelectedItems[0].SubItems[5].Text = this.cbQueQuan.SelectedItem.ToString();
                }
        }
    }
}
