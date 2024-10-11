namespace Buoi3
{
    partial class frmBai3
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
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.lblSoNguyen = new System.Windows.Forms.Label();
            this.lblStrKetQua = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtStrKetQua = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(436, 54);
            this.btnTinhTong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(149, 38);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Location = new System.Drawing.Point(280, 58);
            this.txtSoNguyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNguyen.Name = "txtSoNguyen";
            this.txtSoNguyen.Size = new System.Drawing.Size(148, 30);
            this.txtSoNguyen.TabIndex = 1;
            // 
            // lblSoNguyen
            // 
            this.lblSoNguyen.AutoSize = true;
            this.lblSoNguyen.Location = new System.Drawing.Point(92, 58);
            this.lblSoNguyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNguyen.Name = "lblSoNguyen";
            this.lblSoNguyen.Size = new System.Drawing.Size(180, 25);
            this.lblSoNguyen.TabIndex = 2;
            this.lblSoNguyen.Text = "Nhập số nguyên N:";
            // 
            // lblStrKetQua
            // 
            this.lblStrKetQua.AutoSize = true;
            this.lblStrKetQua.Location = new System.Drawing.Point(12, 64);
            this.lblStrKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStrKetQua.Name = "lblStrKetQua";
            this.lblStrKetQua.Size = new System.Drawing.Size(43, 25);
            this.lblStrKetQua.TabIndex = 3;
            this.lblStrKetQua.Text = "S =";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(8, 130);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(48, 25);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "S = ";
            // 
            // txtStrKetQua
            // 
            this.txtStrKetQua.ForeColor = System.Drawing.Color.Blue;
            this.txtStrKetQua.Location = new System.Drawing.Point(63, 64);
            this.txtStrKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.txtStrKetQua.Name = "txtStrKetQua";
            this.txtStrKetQua.Size = new System.Drawing.Size(404, 30);
            this.txtStrKetQua.TabIndex = 5;
            // 
            // txtKetQua
            // 
            this.txtKetQua.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua.Location = new System.Drawing.Point(63, 130);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(75, 30);
            this.txtKetQua.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStrKetQua);
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(this.lblKetQua);
            this.groupBox1.Controls.Add(this.txtStrKetQua);
            this.groupBox1.Location = new System.Drawing.Point(97, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(489, 204);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSoNguyen);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.btnTinhTong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBai3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tổng N số tự nhiên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.Label lblSoNguyen;
        private System.Windows.Forms.Label lblStrKetQua;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtStrKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}