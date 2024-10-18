namespace Bai3
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
            this.btnTaoMangNN = new System.Windows.Forms.Button();
            this.lblInPut = new System.Windows.Forms.Label();
            this.txtInPut = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.btnTimMax = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaoMangNN
            // 
            this.btnTaoMangNN.Location = new System.Drawing.Point(354, 34);
            this.btnTaoMangNN.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMangNN.Name = "btnTaoMangNN";
            this.btnTaoMangNN.Size = new System.Drawing.Size(225, 46);
            this.btnTaoMangNN.TabIndex = 1;
            this.btnTaoMangNN.Text = "Tạo mảng ngẫu nhiên";
            this.btnTaoMangNN.UseVisualStyleBackColor = true;
            this.btnTaoMangNN.Click += new System.EventHandler(this.btnTaoMangNN_Click);
            // 
            // lblInPut
            // 
            this.lblInPut.AutoSize = true;
            this.lblInPut.Location = new System.Drawing.Point(27, 45);
            this.lblInPut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInPut.Name = "lblInPut";
            this.lblInPut.Size = new System.Drawing.Size(166, 25);
            this.lblInPut.TabIndex = 1;
            this.lblInPut.Text = "Nhập số phần tử: ";
            // 
            // txtInPut
            // 
            this.txtInPut.ForeColor = System.Drawing.Color.Red;
            this.txtInPut.Location = new System.Drawing.Point(226, 42);
            this.txtInPut.Margin = new System.Windows.Forms.Padding(4);
            this.txtInPut.Name = "txtInPut";
            this.txtInPut.Size = new System.Drawing.Size(82, 30);
            this.txtInPut.TabIndex = 0;
            this.txtInPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Enabled = false;
            this.btnTinhTong.Location = new System.Drawing.Point(32, 124);
            this.btnTinhTong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(161, 46);
            this.btnTinhTong.TabIndex = 2;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // btnTimMax
            // 
            this.btnTimMax.Enabled = false;
            this.btnTimMax.Location = new System.Drawing.Point(226, 124);
            this.btnTimMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimMax.Name = "btnTimMax";
            this.btnTimMax.Size = new System.Drawing.Size(161, 46);
            this.btnTimMax.TabIndex = 3;
            this.btnTimMax.Text = "Số lớn nhất";
            this.btnTimMax.UseVisualStyleBackColor = true;
            this.btnTimMax.Click += new System.EventHandler(this.btnTimMax_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(418, 124);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 46);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 217);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimMax);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtInPut);
            this.Controls.Add(this.lblInPut);
            this.Controls.Add(this.btnTaoMangNN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoMangNN;
        private System.Windows.Forms.Label lblInPut;
        private System.Windows.Forms.TextBox txtInPut;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button btnTimMax;
        private System.Windows.Forms.Button btnThoat;
    }
}

