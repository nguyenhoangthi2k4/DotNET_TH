using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Bai10
{
    public partial class Form1 : Form
    {
        DataSet dataSet = new DataSet("QLNV");
        SqlDataAdapter daChucVu, daNhanVien;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2022 - 2026\\HOC KI 5\\C#\\TH\\BuoiTH10\\Bai10\\QLNV.mdf\";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();         
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Kết nối database
            conn.Open();

            // Dữ liệu cbChucVu
            string sQueryCV = @"Select * from CHUCVU";
            this.daChucVu = new SqlDataAdapter(sQueryCV, conn);
            this.daChucVu.Fill(this.dataSet, "tblCHUCVU");
            this.cbChucVu.DataSource = this.dataSet.Tables["tblCHUCVU"];
            
            this.cbChucVu.DisplayMember = "TenCV";
            this.cbChucVu.ValueMember = "MaCV";

            // Dữ liệu dgvDS
            string sQueryNV = @"Select n.*, c.TENCV from NHANVIEN n, CHUCVU c WHERE n.MACV = c.MACV";
            this.daNhanVien = new SqlDataAdapter(sQueryNV, conn);
            this.daNhanVien.Fill(this.dataSet, "tblNHANVIEN");

            this.dgvDS.DataSource = this.dataSet.Tables["tblNHANVIEN"];
            this.dgvDS.Columns["MANV"].HeaderText = "Mã số";  
            this.dgvDS.Columns["HOLOT"].HeaderText = "Họ lót";
            this.dgvDS.Columns["TENNV"].HeaderText = "Tên";
            this.dgvDS.Columns["PHAI"].HeaderText = "Phái";
            this.dgvDS.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            this.dgvDS.Columns["TENCV"].HeaderText = "Chức vụ";
            this.dgvDS.Columns["MACV"].Visible = false;

            // Thêm nhân viên vào database
            // SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(this.daNhanVien);
            string QueryThemNV = @"INSERT INTO NHANVIEN VALUES(@MANV, @HOLOT, @TENNV, @PHAI, @NGAYSINH, @MACV)";
            SqlCommand cmdThemNV = new SqlCommand(QueryThemNV, conn);
            cmdThemNV.Parameters.Add("@MANV", SqlDbType.VarChar, 10, "MANV");
            cmdThemNV.Parameters.Add("@HOLOT", SqlDbType.NVarChar, 50, "HOLOT");
            cmdThemNV.Parameters.Add("@TENNV", SqlDbType.NVarChar, 20, "TENNV");
            cmdThemNV.Parameters.Add("@PHAI", SqlDbType.NVarChar, 3, "PHAI");
            cmdThemNV.Parameters.Add("@NGAYSINH", SqlDbType.Date, 10, "NGAYSINH");
            cmdThemNV.Parameters.Add("@MACV", SqlDbType.VarChar, 10, "MACV");
            this.daNhanVien.InsertCommand = cmdThemNV;

            // Sửa nhân viên -> database
            string QuerySuaNV = @"UPDATE NHANVIEN SET HOLOT = @HOLOT, TENNV = @TENNV, PHAI = @PHAI, NGAYSINH = @NGAYSINH, MACV = @MACV WHERE MANV = @MANV";
            SqlCommand cmdSuaNV = new SqlCommand(QuerySuaNV, conn);          
            cmdSuaNV.Parameters.Add("@HOLOT", SqlDbType.NVarChar, 50, "HOLOT");
            cmdSuaNV.Parameters.Add("@TENNV", SqlDbType.NVarChar, 20, "TENNV");
            cmdSuaNV.Parameters.Add("@PHAI", SqlDbType.NVarChar, 3, "PHAI");
            cmdSuaNV.Parameters.Add("@NGAYSINH", SqlDbType.Date, 10, "NGAYSINH");
            cmdSuaNV.Parameters.Add("@MACV", SqlDbType.VarChar, 10, "MACV");
            cmdSuaNV.Parameters.Add("@MANV", SqlDbType.VarChar, 10, "MANV");
            this.daNhanVien.UpdateCommand = cmdSuaNV;

            // Xóa nhân viên -> database
            string QueryXoaNV = @"DELETE NHANVIEN WHERE MANV = @MANV";
            SqlCommand cmdXoaNV = new SqlCommand(QueryXoaNV, conn);
            cmdXoaNV.Parameters.Add("@MANV", SqlDbType.VarChar, 10, "MANV");
            this.daNhanVien.DeleteCommand = cmdXoaNV;

            conn.Close();
            this.cbChucVu.SelectedIndex = -1;
            this.rdNam.Checked = true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDS.SelectedRows.Count > 0)
            {
                // this.txtMaSo.ReadOnly = true;
                DataGridViewRow dataGridViewRow = dgvDS.SelectedRows[0];
                this.txtMaSo.Text = dataGridViewRow.Cells["MANV"].Value.ToString();
                this.txtHoLot.Text = dataGridViewRow.Cells["HOLOT"].Value.ToString();
                this.txtTen.Text = dataGridViewRow.Cells["TENNV"].Value.ToString();
                if (dataGridViewRow.Cells["PHAI"].Value.ToString() == "Nam")
                    this.rdNam.Checked = true;
                else
                    this.rdNu.Checked = true;
                this.dtpNgaySinh.Text = dataGridViewRow.Cells["NGAYSINH"].Value.ToString();

                string tencv = dataGridViewRow.Cells["TENCV"].Value.ToString();
                DataRow[] drCHUCVU = this.dataSet.Tables["tblCHUCVU"].Select($"TenCV = '{tencv}'");
                if (drCHUCVU.Length > 0)
                    this.cbChucVu.SelectedValue = drCHUCVU[0]["MaCV"];
            }           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(this.dgvDS.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = this.dgvDS.SelectedRows[0];
                string maNV = dataGridViewRow.Cells["MANV"].Value.ToString();               
              
                DataRow row = this.dataSet.Tables["tblNHANVIEN"].Select($"MANV = '{maNV}'")[0];
                if (row != null)
                {
                    row["HOLOT"] = this.txtHoLot.Text;
                    row["TENNV"] = this.txtTen.Text;
                    row["PHAI"] = this.rdNam.Checked ? "Nam" : "Nữ";
                    row["NGAYSINH"] = this.dtpNgaySinh.Value.Date;
                    row["MACV"] = this.cbChucVu.SelectedValue.ToString();
                    // Đánh dấu thay đổi
                    row.AcceptChanges();
                    row.SetModified();
                }
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.dgvDS.SelectedRows.Count > 0)
            {
                string maNV = this.dgvDS.SelectedRows[0].Cells["MANV"].Value.ToString();
                DataRow[] deleterow = this.dataSet.Tables["tblNHANVIEN"].Select($"MANV ='{maNV}'");
                if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa nhân viên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    deleterow[0].Delete();
            }    
        }
        private bool checkMaSo()
        {
            string maso = this.txtMaSo.Text;
            DataRow[] rows = this.dataSet.Tables["tblNHANVIEN"].Select($"MANV = '{maso}'");
            return rows.Length < 1 ? true : false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = this.dataSet.Tables["tblNHANVIEN"].NewRow();
            if (this.checkMaSo())
            {
                row["MANV"] = this.txtMaSo.Text;
                row["HOLOT"] = this.txtHoLot.Text;
                row["TENNV"] = this.txtTen.Text;
                row["PHAI"] = this.rdNam.Checked ? "Nam" : @"Nữ";
                row["NGAYSINH"] = this.dtpNgaySinh.Value.Date.ToString();
                row["MACV"] = this.cbChucVu.SelectedValue.ToString();

                string macv = this.cbChucVu.SelectedValue.ToString();
                DataRow[] chucVuRows = this.dataSet.Tables["tblCHUCVU"].Select($"MaCV = '{macv}'");
                if (chucVuRows.Length > 0)
                {
                    row["TENCV"] = chucVuRows[0]["TENCV"].ToString();
                }
                this.dataSet.Tables["tblNHANVIEN"].Rows.Add(row);
            }
            else
                MessageBox.Show("Mã số đã tồn tại");

            this.txtMaSo.Text = string.Empty;
            this.txtHoLot.Text = string.Empty;
            this.txtTen.Text = string.Empty;
            this.rdNam.Checked = true;
            this.dtpNgaySinh.Text = string.Empty;
            this.cbChucVu.SelectedIndex = -1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.dataSet.Tables["tblNHANVIEN"].RejectChanges();

            // Cập nhật lại DataGridView với dữ liệu ban đầu
            this.dgvDS.DataSource = this.dataSet.Tables["tblNHANVIEN"];
            this.dgvDS.Columns["MANV"].HeaderText = "Mã số";
            this.dgvDS.Columns["HOLOT"].HeaderText = "Họ lót";
            this.dgvDS.Columns["TENNV"].HeaderText = "Tên";
            this.dgvDS.Columns["PHAI"].HeaderText = "Phái";
            this.dgvDS.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            this.dgvDS.Columns["TENCV"].HeaderText = "Chức vụ";
            
            this.txtMaSo.Text = string.Empty;
            this.txtHoLot.Text = string.Empty;
            this.txtTen.Text = string.Empty;
            this.rdNam.Checked = true;
            this.dtpNgaySinh.Text = string.Empty;
            this.cbChucVu.SelectedIndex = -1;
            this.dgvDS.Refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    this.daNhanVien.Update(this.dataSet, "tblNHANVIEN");
                    MessageBox.Show("Lưu thay đổi thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu thất bai, Lỗi :" + ex.Message, "Lỗi");
                }
            }

        }
    }
}
