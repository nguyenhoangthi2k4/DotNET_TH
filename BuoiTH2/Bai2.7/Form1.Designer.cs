namespace Bai2._7
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
            this.lblPhepToan = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSoB = new System.Windows.Forms.TextBox();
            this.txbSoA = new System.Windows.Forms.TextBox();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblSoA = new System.Windows.Forms.Label();
            this.txbKetQua = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhepToan
            // 
            this.lblPhepToan.AutoSize = true;
            this.lblPhepToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhepToan.Location = new System.Drawing.Point(172, 53);
            this.lblPhepToan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhepToan.Name = "lblPhepToan";
            this.lblPhepToan.Size = new System.Drawing.Size(139, 26);
            this.lblPhepToan.TabIndex = 5;
            this.lblPhepToan.Text = "PHÉP TOÁN";
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(169, 417);
            this.btnTong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(144, 57);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSoB);
            this.groupBox1.Controls.Add(this.txbSoA);
            this.groupBox1.Controls.Add(this.lblSoB);
            this.groupBox1.Controls.Add(this.lblSoA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(61, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(339, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txbSoB
            // 
            this.txbSoB.Location = new System.Drawing.Point(108, 113);
            this.txbSoB.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoB.Name = "txbSoB";
            this.txbSoB.Size = new System.Drawing.Size(143, 32);
            this.txbSoB.TabIndex = 3;
            // 
            // txbSoA
            // 
            this.txbSoA.Location = new System.Drawing.Point(108, 47);
            this.txbSoA.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoA.Name = "txbSoA";
            this.txbSoA.Size = new System.Drawing.Size(143, 32);
            this.txbSoA.TabIndex = 2;
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(9, 121);
            this.lblSoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(63, 26);
            this.lblSoB.TabIndex = 1;
            this.lblSoB.Text = "Số b:";
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(9, 51);
            this.lblSoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(69, 26);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số a: ";
            // 
            // txbKetQua
            // 
            this.txbKetQua.Location = new System.Drawing.Point(148, 344);
            this.txbKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.Size = new System.Drawing.Size(238, 32);
            this.txbKetQua.TabIndex = 6;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(53, 346);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(87, 26);
            this.lblKetQua.TabIndex = 7;
            this.lblKetQua.Text = "Kết quả";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 504);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.lblPhepToan);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAI 2.7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhepToan;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSoB;
        private System.Windows.Forms.TextBox txbSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.TextBox txbKetQua;
        private System.Windows.Forms.Label lblKetQua;
    }
}

