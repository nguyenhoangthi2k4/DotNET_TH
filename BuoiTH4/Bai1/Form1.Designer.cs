namespace Bai1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSXGiam = new System.Windows.Forms.Button();
            this.btnSXTang = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSHH = new System.Windows.Forms.Button();
            this.btnDemSoLe = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnDemSoChan = new System.Windows.Forms.Button();
            this.btnSoNguyenTo = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTrungBinhMang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(18, 24);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(176, 38);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập 1 Phần Tử";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(223, 28);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 30);
            this.txtNhap.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Location = new System.Drawing.Point(367, 21);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(161, 41);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(534, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(161, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSXGiam
            // 
            this.btnSXGiam.Location = new System.Drawing.Point(701, 87);
            this.btnSXGiam.Name = "btnSXGiam";
            this.btnSXGiam.Size = new System.Drawing.Size(161, 41);
            this.btnSXGiam.TabIndex = 4;
            this.btnSXGiam.Text = "Sắp xếp Giảm";
            this.btnSXGiam.UseVisualStyleBackColor = true;
            this.btnSXGiam.Click += new System.EventHandler(this.btnSXGiam_Click);
            // 
            // btnSXTang
            // 
            this.btnSXTang.Location = new System.Drawing.Point(701, 153);
            this.btnSXTang.Name = "btnSXTang";
            this.btnSXTang.Size = new System.Drawing.Size(161, 41);
            this.btnSXTang.TabIndex = 5;
            this.btnSXTang.Text = "Sắp xếp Tăng";
            this.btnSXTang.UseVisualStyleBackColor = true;
            this.btnSXTang.Click += new System.EventHandler(this.btnSXTang_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(701, 220);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(161, 41);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "Tổng Mảng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(701, 286);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(161, 41);
            this.btnMax.TabIndex = 7;
            this.btnMax.Text = "Số Lớn Nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSHH
            // 
            this.btnSHH.Location = new System.Drawing.Point(534, 220);
            this.btnSHH.Name = "btnSHH";
            this.btnSHH.Size = new System.Drawing.Size(161, 41);
            this.btnSHH.TabIndex = 8;
            this.btnSHH.Text = "Số Hoàn Hảo";
            this.btnSHH.UseVisualStyleBackColor = true;
            this.btnSHH.Click += new System.EventHandler(this.btnSHH_Click);
            // 
            // btnDemSoLe
            // 
            this.btnDemSoLe.Location = new System.Drawing.Point(200, 220);
            this.btnDemSoLe.Name = "btnDemSoLe";
            this.btnDemSoLe.Size = new System.Drawing.Size(161, 41);
            this.btnDemSoLe.TabIndex = 10;
            this.btnDemSoLe.Text = "Đếm Số Lẻ";
            this.btnDemSoLe.UseVisualStyleBackColor = true;
            this.btnDemSoLe.Click += new System.EventHandler(this.btnDemSoLe_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(33, 286);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(318, 41);
            this.button11.TabIndex = 11;
            this.button11.Text = "UCLN 2 Phần Tử Đầu Tiên";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnDemSoChan
            // 
            this.btnDemSoChan.Location = new System.Drawing.Point(33, 220);
            this.btnDemSoChan.Name = "btnDemSoChan";
            this.btnDemSoChan.Size = new System.Drawing.Size(161, 41);
            this.btnDemSoChan.TabIndex = 12;
            this.btnDemSoChan.Text = "Đếm Số Chẵn";
            this.btnDemSoChan.UseVisualStyleBackColor = true;
            this.btnDemSoChan.Click += new System.EventHandler(this.btnDemSoChan_Click);
            // 
            // btnSoNguyenTo
            // 
            this.btnSoNguyenTo.Location = new System.Drawing.Point(367, 220);
            this.btnSoNguyenTo.Name = "btnSoNguyenTo";
            this.btnSoNguyenTo.Size = new System.Drawing.Size(161, 41);
            this.btnSoNguyenTo.TabIndex = 13;
            this.btnSoNguyenTo.Text = "Số Nguyên Tố";
            this.btnSoNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoNguyenTo.Click += new System.EventHandler(this.btnSoNguyenTo_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(534, 286);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(161, 41);
            this.btnMin.TabIndex = 14;
            this.btnMin.Text = "Số Nhỏ Nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.Wheat;
            this.lblKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKetQua.Location = new System.Drawing.Point(28, 87);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(667, 107);
            this.lblKetQua.TabIndex = 15;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(701, 21);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 41);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTrungBinhMang
            // 
            this.btnTrungBinhMang.Location = new System.Drawing.Point(367, 286);
            this.btnTrungBinhMang.Name = "btnTrungBinhMang";
            this.btnTrungBinhMang.Size = new System.Drawing.Size(161, 41);
            this.btnTrungBinhMang.TabIndex = 17;
            this.btnTrungBinhMang.Text = "Trung Bình";
            this.btnTrungBinhMang.UseVisualStyleBackColor = true;
            this.btnTrungBinhMang.Click += new System.EventHandler(this.btnTrungBinhMang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 346);
            this.Controls.Add(this.btnTrungBinhMang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSoNguyenTo);
            this.Controls.Add(this.btnDemSoChan);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnDemSoLe);
            this.Controls.Add(this.btnSHH);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSXTang);
            this.Controls.Add(this.btnSXGiam);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.btnNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mảng số nguyên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSXGiam;
        private System.Windows.Forms.Button btnSXTang;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSHH;
        private System.Windows.Forms.Button btnDemSoLe;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnDemSoChan;
        private System.Windows.Forms.Button btnSoNguyenTo;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTrungBinhMang;
    }
}

