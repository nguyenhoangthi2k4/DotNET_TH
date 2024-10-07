namespace Bai3._4
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
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSoC = new System.Windows.Forms.TextBox();
            this.txbSoB = new System.Windows.Forms.TextBox();
            this.txbSoA = new System.Windows.Forms.TextBox();
            this.lblSoC = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txbKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(235, 296);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(88, 38);
            this.btnTinh.TabIndex = 0;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSoC);
            this.groupBox1.Controls.Add(this.txbSoB);
            this.groupBox1.Controls.Add(this.txbSoA);
            this.groupBox1.Controls.Add(this.lblSoC);
            this.groupBox1.Controls.Add(this.lblSoB);
            this.groupBox1.Controls.Add(this.lblSoA);
            this.groupBox1.Location = new System.Drawing.Point(165, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txbSoC
            // 
            this.txbSoC.Location = new System.Drawing.Point(79, 98);
            this.txbSoC.Name = "txbSoC";
            this.txbSoC.Size = new System.Drawing.Size(165, 26);
            this.txbSoC.TabIndex = 5;
            // 
            // txbSoB
            // 
            this.txbSoB.Location = new System.Drawing.Point(79, 65);
            this.txbSoB.Name = "txbSoB";
            this.txbSoB.Size = new System.Drawing.Size(165, 26);
            this.txbSoB.TabIndex = 4;
            // 
            // txbSoA
            // 
            this.txbSoA.Location = new System.Drawing.Point(79, 32);
            this.txbSoA.Name = "txbSoA";
            this.txbSoA.Size = new System.Drawing.Size(165, 26);
            this.txbSoA.TabIndex = 3;
            // 
            // lblSoC
            // 
            this.lblSoC.AutoSize = true;
            this.lblSoC.Location = new System.Drawing.Point(7, 96);
            this.lblSoC.Name = "lblSoC";
            this.lblSoC.Size = new System.Drawing.Size(45, 20);
            this.lblSoC.TabIndex = 2;
            this.lblSoC.Text = "Số c:";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(7, 63);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(46, 20);
            this.lblSoB.TabIndex = 1;
            this.lblSoB.Text = "Số b:";
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(7, 32);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(46, 20);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số a:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(199, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(223, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "TÍNH PHƯƠNG TRÌNH BẬC 2";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(108, 255);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(64, 20);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "Kết quả";
            // 
            // txbKetQua
            // 
            this.txbKetQua.Location = new System.Drawing.Point(174, 251);
            this.txbKetQua.Name = "txbKetQua";
            this.txbKetQua.Size = new System.Drawing.Size(282, 26);
            this.txbKetQua.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 386);
            this.Controls.Add(this.txbKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTinh);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSoC;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txbSoC;
        private System.Windows.Forms.TextBox txbSoB;
        private System.Windows.Forms.TextBox txbSoA;
        private System.Windows.Forms.TextBox txbKetQua;
    }
}

