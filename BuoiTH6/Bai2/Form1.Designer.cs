namespace Bai2
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbChonLop = new System.Windows.Forms.GroupBox();
            this.rdLopB = new System.Windows.Forms.RadioButton();
            this.rdLopA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLopA = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbLopB = new System.Windows.Forms.ListBox();
            this.btnASangB = new System.Windows.Forms.Button();
            this.btnBSangA = new System.Windows.Forms.Button();
            this.btnChuyenAllASangB = new System.Windows.Forms.Button();
            this.ChuyenAllBSangA = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.grbChonLop.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(17, 18);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(126, 20);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên sinh viên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(163, 15);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(315, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(509, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbChonLop
            // 
            this.grbChonLop.Controls.Add(this.rdLopB);
            this.grbChonLop.Controls.Add(this.rdLopA);
            this.grbChonLop.Location = new System.Drawing.Point(211, 62);
            this.grbChonLop.Name = "grbChonLop";
            this.grbChonLop.Size = new System.Drawing.Size(264, 70);
            this.grbChonLop.TabIndex = 3;
            this.grbChonLop.TabStop = false;
            this.grbChonLop.Text = "Lớp";
            // 
            // rdLopB
            // 
            this.rdLopB.AutoSize = true;
            this.rdLopB.Location = new System.Drawing.Point(171, 35);
            this.rdLopB.Name = "rdLopB";
            this.rdLopB.Size = new System.Drawing.Size(76, 24);
            this.rdLopB.TabIndex = 1;
            this.rdLopB.TabStop = true;
            this.rdLopB.Text = "Lớp B";
            this.rdLopB.UseVisualStyleBackColor = true;
            // 
            // rdLopA
            // 
            this.rdLopA.AutoSize = true;
            this.rdLopA.Location = new System.Drawing.Point(6, 35);
            this.rdLopA.Name = "rdLopA";
            this.rdLopA.Size = new System.Drawing.Size(76, 24);
            this.rdLopA.TabIndex = 0;
            this.rdLopA.TabStop = true;
            this.rdLopA.Text = "Lớp A";
            this.rdLopA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLopA);
            this.groupBox2.Location = new System.Drawing.Point(15, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 241);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // lbLopA
            // 
            this.lbLopA.FormattingEnabled = true;
            this.lbLopA.ItemHeight = 20;
            this.lbLopA.Location = new System.Drawing.Point(6, 25);
            this.lbLopA.Name = "lbLopA";
            this.lbLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLopA.Size = new System.Drawing.Size(259, 204);
            this.lbLopA.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLopB);
            this.groupBox3.Location = new System.Drawing.Point(398, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 241);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // lbLopB
            // 
            this.lbLopB.FormattingEnabled = true;
            this.lbLopB.ItemHeight = 20;
            this.lbLopB.Location = new System.Drawing.Point(6, 25);
            this.lbLopB.Name = "lbLopB";
            this.lbLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLopB.Size = new System.Drawing.Size(259, 204);
            this.lbLopB.TabIndex = 1;
            // 
            // btnASangB
            // 
            this.btnASangB.Location = new System.Drawing.Point(303, 168);
            this.btnASangB.Name = "btnASangB";
            this.btnASangB.Size = new System.Drawing.Size(75, 36);
            this.btnASangB.TabIndex = 5;
            this.btnASangB.Text = ">";
            this.btnASangB.UseVisualStyleBackColor = true;
            this.btnASangB.Click += new System.EventHandler(this.btnASangB_Click);
            // 
            // btnBSangA
            // 
            this.btnBSangA.Location = new System.Drawing.Point(303, 226);
            this.btnBSangA.Name = "btnBSangA";
            this.btnBSangA.Size = new System.Drawing.Size(75, 36);
            this.btnBSangA.TabIndex = 6;
            this.btnBSangA.Text = "<";
            this.btnBSangA.UseVisualStyleBackColor = true;
            this.btnBSangA.Click += new System.EventHandler(this.btnBSangA_Click);
            // 
            // btnChuyenAllASangB
            // 
            this.btnChuyenAllASangB.Location = new System.Drawing.Point(303, 283);
            this.btnChuyenAllASangB.Name = "btnChuyenAllASangB";
            this.btnChuyenAllASangB.Size = new System.Drawing.Size(75, 36);
            this.btnChuyenAllASangB.TabIndex = 8;
            this.btnChuyenAllASangB.Text = ">>";
            this.btnChuyenAllASangB.UseVisualStyleBackColor = true;
            this.btnChuyenAllASangB.Click += new System.EventHandler(this.btnChuyenAllASangB_Click);
            // 
            // ChuyenAllBSangA
            // 
            this.ChuyenAllBSangA.Location = new System.Drawing.Point(303, 336);
            this.ChuyenAllBSangA.Name = "ChuyenAllBSangA";
            this.ChuyenAllBSangA.Size = new System.Drawing.Size(75, 36);
            this.ChuyenAllBSangA.TabIndex = 9;
            this.ChuyenAllBSangA.Text = "<<";
            this.ChuyenAllBSangA.UseVisualStyleBackColor = true;
            this.ChuyenAllBSangA.Click += new System.EventHandler(this.ChuyenAllBSangA_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(398, 399);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 49);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(146, 399);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(140, 49);
            this.btnTinhTong.TabIndex = 11;
            this.btnTinhTong.Text = "Tổng sinh viên";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 478);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.ChuyenAllBSangA);
            this.Controls.Add(this.btnChuyenAllASangB);
            this.Controls.Add(this.btnBSangA);
            this.Controls.Add(this.btnASangB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbChonLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblHoTen);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbChonLop.ResumeLayout(false);
            this.grbChonLop.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbChonLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbLopA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbLopB;
        private System.Windows.Forms.Button btnASangB;
        private System.Windows.Forms.Button btnBSangA;
        private System.Windows.Forms.Button btnChuyenAllASangB;
        private System.Windows.Forms.Button ChuyenAllBSangA;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.RadioButton rdLopB;
        private System.Windows.Forms.RadioButton rdLopA;
    }
}

