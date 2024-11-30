using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH11
{
    public partial class Form1 : Form
    {
        private DataSet _dataSet = new DataSet("DSHocSinh");
        private SqlDataAdapter _daQQ;
        private SqlDataAdapter _daHS;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\2022 - 2026\\HOC KI 5\\C#\\TH\\BuoiTH11\\BuoiTH11\\QLHS.mdf\";Integrated Security=True");
            conn.Open();
            // cbQueQuan
            string SQueryQQ = @"SELECT * FROM QUEQUAN";
            this._daQQ = new SqlDataAdapter(SQueryQQ, conn);
            this._daQQ.Fill(_dataSet, "tblQUEQUAN");
            this.cbQueQuan.DataSource = this._dataSet.Tables["tblQUEQUAN"];
            this.cbQueQuan.DisplayMember = "TENQQ";
            this.cbQueQuan.ValueMember = "MAQQ";
            // dgvDanhSach
            string SQueryHS = @"SELECT h.*, q.TENQQ FROM HOCSINH h, QUEQUAN q WHERE h.MAQQ = q.MAQQ";
            this._daHS = new SqlDataAdapter(SQueryHS, conn);
            this._daHS.Fill(_dataSet, "tblHOCSINH");
            this.dgvDanhSach.DataSource = this._dataSet.Tables["tblHOCSINH"];
               
            this.dgvDanhSach.Columns["MAHS"].HeaderText = "MÃ SỐ";
            this.dgvDanhSach.Columns["HOLOT"].HeaderText = "HỌ LÓT";
            this.dgvDanhSach.Columns["TENHS"].HeaderText = "TÊN";
            this.dgvDanhSach.Columns["PHAI"].HeaderText = "PHÁI";
            this.dgvDanhSach.Columns["NGAYSINH"].HeaderText = "NGÀY SINH";
            this.dgvDanhSach.Columns["MAQQ"].Visible = false;
            this.dgvDanhSach.Columns["TENQQ"].HeaderText = "QUÊ QUÁN";

            // INSERT Database
            string IQueryHS = @"INSERT INTO HOCSINH VALUES (@MAHS, @HOLOT, @TENHS, @PHAI, @NGAYSINH,@MAQQ)";
            SqlCommand cmdThem = new SqlCommand(IQueryHS, conn);
            cmdThem.Parameters.Add("@MAHS", SqlDbType.Char, 5, "MAHS");
            cmdThem.Parameters.Add("@HOLOT", SqlDbType.NVarChar, 50, "HOLOT");
            cmdThem.Parameters.Add("@TENHS", SqlDbType.NVarChar, 50, "TENHS");
            cmdThem.Parameters.Add("@PHAI", SqlDbType.NVarChar, 3, "PHAI");
            cmdThem.Parameters.Add("@NGAYSINH", SqlDbType.Date, 10, "NGAYSINH");
            cmdThem.Parameters.Add("@MAQQ", SqlDbType.Char, 5, "MAQQ");
            this._daHS.InsertCommand = cmdThem;

            // UPDATE Database
            string UQueryHS = @"UPDATE HOCSINH SET HOLOT = @HOLOT, TENHS = @TENHS, PHAI = @PHAI, NGAYSINH = @NGAYSINH, MAQQ = @MAQQ 
                                WHERE MAHS = @MAHS";
            SqlCommand cmdSua = new SqlCommand(UQueryHS, conn);
            cmdSua.Parameters.Add("@MAHS", SqlDbType.Char, 5, "MAHS");
            cmdSua.Parameters.Add("@HOLOT", SqlDbType.NVarChar, 50, "HOLOT");
            cmdSua.Parameters.Add("@TENHS", SqlDbType.NVarChar, 50, "TENHS");
            cmdSua.Parameters.Add("@PHAI", SqlDbType.NVarChar, 3, "PHAI");
            cmdSua.Parameters.Add("@NGAYSINH", SqlDbType.Date, 10, "NGAYSINH");
            cmdSua.Parameters.Add("@MAQQ", SqlDbType.Char, 5, "MAQQ");
            this._daHS.UpdateCommand = cmdSua;

            // DELETE Database
            string DQueryHS = @"DELETE HOCSINH WHERE MAHS = @MAHS";
            SqlCommand cmdXoa = new SqlCommand(DQueryHS, conn);
            cmdXoa.Parameters.Add("@MAHS", SqlDbType.Char, 5, "MAHS");
            this._daHS.DeleteCommand = cmdXoa;

            conn.Close();
            this.cbQueQuan.SelectedIndex = -1;
            this.rdNam.Checked = true;           
            if(this.dgvDanhSach.RowCount > 0)
            {
                this.btnHuy.Enabled = true;
                this.btnLuu.Enabled = true;
            }    
            else
            {
                this.btnHuy.Enabled = false;
                this.btnLuu.Enabled = false;
            }             
        }
        public bool CheckMaHS()
        {
            DataRow[] rows = this._dataSet.Tables["tblHOCSINH"].Select($"MAHS = '{this.txtMaSo.Text}'");
            return rows.Length < 1 ? true : false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.CheckMaHS())
            {
                DataRow row = _dataSet.Tables["tblHOCSINH"].NewRow();
                row["MAHS"] = this.txtMaSo.Text;
                row["HOLOT"] = this.txtHoLot.Text;
                row["TENHS"] = this.txtTen.Text;
                row["PHAI"] = this.rdNam.Checked ? "Nam" : "Nữ";
                row["NGAYSINH"] = this.dtpNgaySinh.Value.Date;
                row["MAQQ"] = this.cbQueQuan.SelectedValue.ToString();

                DataRow[] rowQQ = this._dataSet.Tables["tblQUEQUAN"].Select($"MAQQ ='{this.cbQueQuan.SelectedValue.ToString()}'");
                if (rowQQ.Length > 0)
                    row["TENQQ"] = rowQQ[0]["TENQQ"];
                this._dataSet.Tables["tblHOCSINH"].Rows.Add(row);

                this.btnLuu.Enabled = true;
                this.btnSua.Enabled = true;
               
            }
            else
                MessageBox.Show("Mã số đã tồn tại", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.txtMaSo.Text = string.Empty;
            this.txtHoLot.Text = string.Empty;
            this.txtTen.Text = string.Empty;
            this.rdNam.Checked = true;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.cbQueQuan.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(DialogResult.Yes == MessageBox.Show("Bạn có muốn lưu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    this._daHS.Update(this._dataSet, "tblHOCSINH");
                    MessageBox.Show("Lưu thành công");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Lỗi");
            }
        }

        private void dgvDanhSach_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvDanhSach.SelectedRows[0];
                this.txtMaSo.Text = row.Cells["MAHS"].Value.ToString();
                this.txtHoLot.Text = row.Cells["HOLOT"].Value.ToString();
                this.txtTen.Text = row.Cells["TENHS"].Value.ToString();
                if(row.Cells["PHAI"].Value.ToString() == "Nam")
                    this.rdNam.Checked = true;
                else
                    this.rdNu.Checked = true;
                this.dtpNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();

                DataRow[] findMaQQ = this._dataSet.Tables["tblHOCSINH"].Select($"MAQQ = '{row.Cells["MAQQ"].Value.ToString()}'");
                if (findMaQQ.Length > 0)
                {
                    this.cbQueQuan.SelectedValue = findMaQQ[0]["MAQQ"];
                }
            }            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(this.dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRow = this.dgvDanhSach.SelectedRows[0];
                string maHS = dataGridViewRow.Cells["MAHS"].Value.ToString();

                DataRow dataRow = this._dataSet.Tables["tblHOCSINH"].Select($"MAHS ='{maHS}'")[0];
                if (dataRow != null)
                {
                    dataRow["HOLOT"] = this.txtHoLot.Text;
                    dataRow["TENHS"] = this.txtTen.Text;
                    dataRow["PHAI"] = this.rdNam.Checked ? "Nam" : "Nữ";
                    dataRow["NGAYSINH"] = this.dtpNgaySinh.Value.Date.ToString();
                    dataRow["MAQQ"] = this.cbQueQuan.SelectedValue;

                    // Hiển thị tên Quê Quán
                    DataRow[] dataRows = this._dataSet.Tables["tblQUEQUAN"].Select($"MAQQ = '{this.cbQueQuan.SelectedValue.ToString()}'");
                    if (dataRows.Length > 0)
                    {
                        dataRow["TENQQ"] = dataRows[0]["TENQQ"];
                    }
                    
                    dataRow.AcceptChanges();
                    dataRow.SetModified();

                    this.txtMaSo.Text = string.Empty;
                    this.txtHoLot.Text = string.Empty;
                    this.txtTen.Text = string.Empty;
                    this.rdNam.Checked = true;
                    this.dtpNgaySinh.Value = DateTime.Now;
                    this.cbQueQuan.SelectedIndex = -1;
                }
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow dataGridViewRows = this.dgvDanhSach.SelectedRows[0];
                string maHS = dataGridViewRows.Cells["MAHS"].Value.ToString();
                DataRow dataRow = this._dataSet.Tables["tblHOCSINH"].Select($"MAHS = '{maHS}'")[0];
                if(dataRow != null)
                    dataRow.Delete();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this._dataSet.Tables["tblHOCSINH"].RejectChanges();
            this.dgvDanhSach = new DataGridView();
            this.dgvDanhSach.DataSource = this._dataSet.Tables["tblHOCSINH"];
            this.dgvDanhSach.Refresh();

            this.txtMaSo.Text = string.Empty;
            this.txtHoLot.Text = string.Empty;
            this.txtTen.Text = string.Empty;
            this.rdNam.Checked = true;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.cbQueQuan.SelectedIndex = -1;
        }
    }
}
