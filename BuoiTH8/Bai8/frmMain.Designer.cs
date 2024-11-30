namespace Bai8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thựcHiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbCanh = new System.Windows.Forms.GroupBox();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.lblBanKinh = new System.Windows.Forms.Label();
            this.lblChieuDai = new System.Windows.Forms.Label();
            this.lblCanh = new System.Windows.Forms.Label();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.grbChon = new System.Windows.Forms.GroupBox();
            this.rdHinhTron = new System.Windows.Forms.RadioButton();
            this.rdHinhCN = new System.Windows.Forms.RadioButton();
            this.rdHinhVuong = new System.Windows.Forms.RadioButton();
            this.lblTinhCVDT = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbCanh.SuspendLayout();
            this.grbChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thựcHiệnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thựcHiệnToolStripMenuItem
            // 
            this.thựcHiệnToolStripMenuItem.Name = "thựcHiệnToolStripMenuItem";
            this.thựcHiệnToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.thựcHiệnToolStripMenuItem.Text = "Thực hiện";
            this.thựcHiệnToolStripMenuItem.Click += new System.EventHandler(this.thựcHiệnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // grbCanh
            // 
            this.grbCanh.Controls.Add(this.txtBanKinh);
            this.grbCanh.Controls.Add(this.txtChieuRong);
            this.grbCanh.Controls.Add(this.txtChieuDai);
            this.grbCanh.Controls.Add(this.txtCanh);
            this.grbCanh.Controls.Add(this.lblBanKinh);
            this.grbCanh.Controls.Add(this.lblChieuDai);
            this.grbCanh.Controls.Add(this.lblCanh);
            this.grbCanh.Controls.Add(this.lblChieuRong);
            this.grbCanh.Location = new System.Drawing.Point(364, 120);
            this.grbCanh.Name = "grbCanh";
            this.grbCanh.Size = new System.Drawing.Size(520, 171);
            this.grbCanh.TabIndex = 2;
            this.grbCanh.TabStop = false;
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(123, 127);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(122, 26);
            this.txtBanKinh.TabIndex = 12;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(363, 81);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(122, 26);
            this.txtChieuRong.TabIndex = 11;
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(123, 81);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(122, 26);
            this.txtChieuDai.TabIndex = 10;
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(123, 39);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(122, 26);
            this.txtCanh.TabIndex = 9;
            // 
            // lblBanKinh
            // 
            this.lblBanKinh.AutoSize = true;
            this.lblBanKinh.Location = new System.Drawing.Point(33, 130);
            this.lblBanKinh.Name = "lblBanKinh";
            this.lblBanKinh.Size = new System.Drawing.Size(71, 20);
            this.lblBanKinh.TabIndex = 8;
            this.lblBanKinh.Text = "Bán kính";
            // 
            // lblChieuDai
            // 
            this.lblChieuDai.AutoSize = true;
            this.lblChieuDai.Location = new System.Drawing.Point(33, 87);
            this.lblChieuDai.Name = "lblChieuDai";
            this.lblChieuDai.Size = new System.Drawing.Size(75, 20);
            this.lblChieuDai.TabIndex = 7;
            this.lblChieuDai.Text = "Chiều dài";
            // 
            // lblCanh
            // 
            this.lblCanh.AutoSize = true;
            this.lblCanh.Location = new System.Drawing.Point(33, 42);
            this.lblCanh.Name = "lblCanh";
            this.lblCanh.Size = new System.Drawing.Size(47, 20);
            this.lblCanh.TabIndex = 6;
            this.lblCanh.Text = "Cạnh";
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Location = new System.Drawing.Point(262, 87);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(86, 20);
            this.lblChieuRong.TabIndex = 5;
            this.lblChieuRong.Text = "Chiều rộng";
            // 
            // grbChon
            // 
            this.grbChon.Controls.Add(this.rdHinhTron);
            this.grbChon.Controls.Add(this.rdHinhCN);
            this.grbChon.Controls.Add(this.rdHinhVuong);
            this.grbChon.Location = new System.Drawing.Point(30, 120);
            this.grbChon.Name = "grbChon";
            this.grbChon.Size = new System.Drawing.Size(292, 171);
            this.grbChon.TabIndex = 3;
            this.grbChon.TabStop = false;
            this.grbChon.Text = "Chọn";
            // 
            // rdHinhTron
            // 
            this.rdHinhTron.AutoSize = true;
            this.rdHinhTron.ForeColor = System.Drawing.Color.Blue;
            this.rdHinhTron.Location = new System.Drawing.Point(6, 128);
            this.rdHinhTron.Name = "rdHinhTron";
            this.rdHinhTron.Size = new System.Drawing.Size(99, 24);
            this.rdHinhTron.TabIndex = 2;
            this.rdHinhTron.TabStop = true;
            this.rdHinhTron.Text = "Hình tròn";
            this.rdHinhTron.UseVisualStyleBackColor = true;
            this.rdHinhTron.CheckedChanged += new System.EventHandler(this.rdHinhTron_CheckedChanged);
            // 
            // rdHinhCN
            // 
            this.rdHinhCN.AutoSize = true;
            this.rdHinhCN.ForeColor = System.Drawing.Color.Blue;
            this.rdHinhCN.Location = new System.Drawing.Point(6, 85);
            this.rdHinhCN.Name = "rdHinhCN";
            this.rdHinhCN.Size = new System.Drawing.Size(133, 24);
            this.rdHinhCN.TabIndex = 1;
            this.rdHinhCN.TabStop = true;
            this.rdHinhCN.Text = "Hình chữ nhật";
            this.rdHinhCN.UseVisualStyleBackColor = true;
            this.rdHinhCN.CheckedChanged += new System.EventHandler(this.rdHinhCN_CheckedChanged);
            // 
            // rdHinhVuong
            // 
            this.rdHinhVuong.AutoSize = true;
            this.rdHinhVuong.ForeColor = System.Drawing.Color.Blue;
            this.rdHinhVuong.Location = new System.Drawing.Point(6, 40);
            this.rdHinhVuong.Name = "rdHinhVuong";
            this.rdHinhVuong.Size = new System.Drawing.Size(114, 24);
            this.rdHinhVuong.TabIndex = 0;
            this.rdHinhVuong.TabStop = true;
            this.rdHinhVuong.Text = "Hình vuông";
            this.rdHinhVuong.UseVisualStyleBackColor = true;
            this.rdHinhVuong.CheckedChanged += new System.EventHandler(this.rdHinhVuong_CheckedChanged);
            // 
            // lblTinhCVDT
            // 
            this.lblTinhCVDT.AutoSize = true;
            this.lblTinhCVDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhCVDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTinhCVDT.Location = new System.Drawing.Point(269, 56);
            this.lblTinhCVDT.Name = "lblTinhCVDT";
            this.lblTinhCVDT.Size = new System.Drawing.Size(377, 37);
            this.lblTinhCVDT.TabIndex = 4;
            this.lblTinhCVDT.Text = "TÍNH DIỆN TÍCH CHU VI";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(316, 327);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(113, 43);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(478, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 43);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 411);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.lblTinhCVDT);
            this.Controls.Add(this.grbChon);
            this.Controls.Add(this.grbCanh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài Tập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbCanh.ResumeLayout(false);
            this.grbCanh.PerformLayout();
            this.grbChon.ResumeLayout(false);
            this.grbChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thựcHiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbCanh;
        private System.Windows.Forms.Label lblBanKinh;
        private System.Windows.Forms.Label lblChieuDai;
        private System.Windows.Forms.Label lblCanh;
        private System.Windows.Forms.Label lblChieuRong;
        private System.Windows.Forms.GroupBox grbChon;
        private System.Windows.Forms.RadioButton rdHinhTron;
        private System.Windows.Forms.RadioButton rdHinhCN;
        private System.Windows.Forms.RadioButton rdHinhVuong;
        private System.Windows.Forms.Label lblTinhCVDT;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtCanh;
    }
}

