namespace Bai3._3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbNam = new System.Windows.Forms.TextBox();
            this.txbThang = new System.Windows.Forms.TextBox();
            this.txbNgay = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblKiemTraNgay = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbNam);
            this.groupBox1.Controls.Add(this.txbThang);
            this.groupBox1.Controls.Add(this.txbNgay);
            this.groupBox1.Controls.Add(this.lblNam);
            this.groupBox1.Controls.Add(this.lblThang);
            this.groupBox1.Controls.Add(this.lblNgay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(136, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txbNam
            // 
            this.txbNam.Location = new System.Drawing.Point(82, 125);
            this.txbNam.Name = "txbNam";
            this.txbNam.Size = new System.Drawing.Size(156, 30);
            this.txbNam.TabIndex = 5;
            // 
            // txbThang
            // 
            this.txbThang.Location = new System.Drawing.Point(82, 81);
            this.txbThang.Name = "txbThang";
            this.txbThang.Size = new System.Drawing.Size(156, 30);
            this.txbThang.TabIndex = 4;
            // 
            // txbNgay
            // 
            this.txbNgay.Location = new System.Drawing.Point(82, 37);
            this.txbNgay.Name = "txbNgay";
            this.txbNgay.Size = new System.Drawing.Size(156, 30);
            this.txbNgay.TabIndex = 3;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(6, 128);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(64, 25);
            this.lblNam.TabIndex = 2;
            this.lblNam.Text = "Năm: ";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(6, 81);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(80, 25);
            this.lblThang.TabIndex = 2;
            this.lblThang.Text = "Tháng: ";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(7, 37);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(69, 25);
            this.lblNgay.TabIndex = 0;
            this.lblNgay.Text = "Ngày: ";
            // 
            // lblKiemTraNgay
            // 
            this.lblKiemTraNgay.AutoSize = true;
            this.lblKiemTraNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiemTraNgay.Location = new System.Drawing.Point(194, 65);
            this.lblKiemTraNgay.Name = "lblKiemTraNgay";
            this.lblKiemTraNgay.Size = new System.Drawing.Size(190, 25);
            this.lblKiemTraNgay.TabIndex = 1;
            this.lblKiemTraNgay.Text = "Kiểm tra ngày hợp lệ";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.Location = new System.Drawing.Point(225, 309);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(130, 50);
            this.btnKiemTra.TabIndex = 2;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 418);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.lblKiemTraNgay);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAI 3.3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbNam;
        private System.Windows.Forms.TextBox txbThang;
        private System.Windows.Forms.TextBox txbNgay;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblKiemTraNgay;
        private System.Windows.Forms.Button btnKiemTra;
    }
}

