namespace Bai2._9
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
            this.btnChuVi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbChieuDai = new System.Windows.Forms.TextBox();
            this.txbChieuRong = new System.Windows.Forms.TextBox();
            this.lblChieuDai = new System.Windows.Forms.Label();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txbKetQua = new System.Windows.Forms.TextBox();
            this.btnDuongCheo = new System.Windows.Forms.Button();
            this.btnDienTich = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblHCH = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChuVi
            // 
            this.btnChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuVi.Location = new System.Drawing.Point(11, 333);
            this.btnChuVi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.Size = new System.Drawing.Size(148, 61);
            this.btnChuVi.TabIndex = 18;
            this.btnChuVi.Text = "Chu vi";
            this.btnChuVi.UseVisualStyleBackColor = true;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbChieuDai);
            this.groupBox1.Controls.Add(this.txbChieuRong);
            this.groupBox1.Controls.Add(this.lblChieuDai);
            this.groupBox1.Controls.Add(this.lblChieuRong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(228, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(339, 197);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txbChieuDai
            // 
            this.txbChieuDai.Location = new System.Drawing.Point(137, 122);
            this.txbChieuDai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbChieuDai.Name = "txbChieuDai";
            this.txbChieuDai.Size = new System.Drawing.Size(146, 32);
            this.txbChieuDai.TabIndex = 3;
            // 
            // txbChieuRong
            // 
            this.txbChieuRong.Location = new System.Drawing.Point(137, 48);
            this.txbChieuRong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbChieuRong.Name = "txbChieuRong";
            this.txbChieuRong.Size = new System.Drawing.Size(146, 32);
            this.txbChieuRong.TabIndex = 2;
            // 
            // lblChieuDai
            // 
            this.lblChieuDai.AutoSize = true;
            this.lblChieuDai.Location = new System.Drawing.Point(9, 128);
            this.lblChieuDai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChieuDai.Name = "lblChieuDai";
            this.lblChieuDai.Size = new System.Drawing.Size(110, 26);
            this.lblChieuDai.TabIndex = 1;
            this.lblChieuDai.Text = "Chiều dài:";
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Location = new System.Drawing.Point(9, 54);
            this.lblChieuRong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(118, 26);
            this.lblChieuRong.TabIndex = 0;
            this.lblChieuRong.Text = "Chiều rộng";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(237, 281);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(87, 26);
            this.lblKetQua.TabIndex = 24;
            this.lblKetQua.Text = "Kết quả";
            // 
            // txbKetQua
            // 
            this.txbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKetQua.Location = new System.Drawing.Point(346, 281);
            this.txbKetQua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.ReadOnly = true;
            this.txbKetQua.Size = new System.Drawing.Size(194, 32);
            this.txbKetQua.TabIndex = 23;
            // 
            // btnDuongCheo
            // 
            this.btnDuongCheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuongCheo.Location = new System.Drawing.Point(419, 333);
            this.btnDuongCheo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDuongCheo.Name = "btnDuongCheo";
            this.btnDuongCheo.Size = new System.Drawing.Size(148, 61);
            this.btnDuongCheo.TabIndex = 22;
            this.btnDuongCheo.Text = "Đường chéo";
            this.btnDuongCheo.UseVisualStyleBackColor = true;
            this.btnDuongCheo.Click += new System.EventHandler(this.btnDuongCheo_Click);
            // 
            // btnDienTich
            // 
            this.btnDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDienTich.Location = new System.Drawing.Point(214, 333);
            this.btnDienTich.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(148, 61);
            this.btnDienTich.TabIndex = 21;
            this.btnDienTich.Text = "Diện tích";
            this.btnDienTich.UseVisualStyleBackColor = true;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(620, 333);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 61);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblHCH
            // 
            this.lblHCH.AutoSize = true;
            this.lblHCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHCH.Location = new System.Drawing.Point(317, 19);
            this.lblHCH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHCH.Name = "lblHCH";
            this.lblHCH.Size = new System.Drawing.Size(185, 26);
            this.lblHCH.TabIndex = 25;
            this.lblHCH.Text = "HÌNH CHỮ NHẬT";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 442);
            this.Controls.Add(this.lblHCH);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.btnDuongCheo);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAI 2.9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChuVi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbChieuDai;
        private System.Windows.Forms.TextBox txbChieuRong;
        private System.Windows.Forms.Label lblChieuDai;
        private System.Windows.Forms.Label lblChieuRong;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txbKetQua;
        private System.Windows.Forms.Button btnDuongCheo;
        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblHCH;
    }
}

