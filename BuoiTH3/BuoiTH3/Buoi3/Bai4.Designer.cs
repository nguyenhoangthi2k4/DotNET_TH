namespace Buoi3
{
    partial class frmBai4
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
            this.lblSoNguyen = new System.Windows.Forms.Label();
            this.lblSoThuc = new System.Windows.Forms.Label();
            this.txtSoNguyen = new System.Windows.Forms.TextBox();
            this.txtSoThuc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKetQua1 = new System.Windows.Forms.Label();
            this.lblKetQua2 = new System.Windows.Forms.Label();
            this.lblKetQua3 = new System.Windows.Forms.Label();
            this.lblKetQua4 = new System.Windows.Forms.Label();
            this.txtKetQua1 = new System.Windows.Forms.TextBox();
            this.txtKetQua2 = new System.Windows.Forms.TextBox();
            this.txtKetQua3 = new System.Windows.Forms.TextBox();
            this.txtKetQua4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(643, 66);
            this.btnTinhTong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(135, 61);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "Tính tổng S";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // lblSoNguyen
            // 
            this.lblSoNguyen.AutoSize = true;
            this.lblSoNguyen.Location = new System.Drawing.Point(72, 66);
            this.lblSoNguyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoNguyen.Name = "lblSoNguyen";
            this.lblSoNguyen.Size = new System.Drawing.Size(240, 25);
            this.lblSoNguyen.TabIndex = 1;
            this.lblSoNguyen.Text = "Nhập số nguyên dương N:";
            // 
            // lblSoThuc
            // 
            this.lblSoThuc.AutoSize = true;
            this.lblSoThuc.Location = new System.Drawing.Point(72, 124);
            this.lblSoThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoThuc.Name = "lblSoThuc";
            this.lblSoThuc.Size = new System.Drawing.Size(152, 25);
            this.lblSoThuc.TabIndex = 2;
            this.lblSoThuc.Text = "Nhập số thực X:";
            // 
            // txtSoNguyen
            // 
            this.txtSoNguyen.Location = new System.Drawing.Point(348, 66);
            this.txtSoNguyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoNguyen.Name = "txtSoNguyen";
            this.txtSoNguyen.Size = new System.Drawing.Size(224, 30);
            this.txtSoNguyen.TabIndex = 3;
            // 
            // txtSoThuc
            // 
            this.txtSoThuc.Location = new System.Drawing.Point(348, 120);
            this.txtSoThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoThuc.Name = "txtSoThuc";
            this.txtSoThuc.Size = new System.Drawing.Size(224, 30);
            this.txtSoThuc.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKetQua4);
            this.groupBox1.Controls.Add(this.txtKetQua3);
            this.groupBox1.Controls.Add(this.txtKetQua2);
            this.groupBox1.Controls.Add(this.txtKetQua1);
            this.groupBox1.Controls.Add(this.lblKetQua4);
            this.groupBox1.Controls.Add(this.lblKetQua3);
            this.groupBox1.Controls.Add(this.lblKetQua2);
            this.groupBox1.Controls.Add(this.lblKetQua1);
            this.groupBox1.Location = new System.Drawing.Point(59, 201);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(719, 266);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả:";
            // 
            // lblKetQua1
            // 
            this.lblKetQua1.AutoSize = true;
            this.lblKetQua1.Location = new System.Drawing.Point(55, 60);
            this.lblKetQua1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua1.Name = "lblKetQua1";
            this.lblKetQua1.Size = new System.Drawing.Size(43, 25);
            this.lblKetQua1.TabIndex = 0;
            this.lblKetQua1.Text = "S =";
            // 
            // lblKetQua2
            // 
            this.lblKetQua2.AutoSize = true;
            this.lblKetQua2.Location = new System.Drawing.Point(55, 99);
            this.lblKetQua2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua2.Name = "lblKetQua2";
            this.lblKetQua2.Size = new System.Drawing.Size(43, 25);
            this.lblKetQua2.TabIndex = 1;
            this.lblKetQua2.Text = "S =";
            // 
            // lblKetQua3
            // 
            this.lblKetQua3.AutoSize = true;
            this.lblKetQua3.Location = new System.Drawing.Point(55, 144);
            this.lblKetQua3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua3.Name = "lblKetQua3";
            this.lblKetQua3.Size = new System.Drawing.Size(43, 25);
            this.lblKetQua3.TabIndex = 2;
            this.lblKetQua3.Text = "S =";
            // 
            // lblKetQua4
            // 
            this.lblKetQua4.AutoSize = true;
            this.lblKetQua4.Location = new System.Drawing.Point(55, 189);
            this.lblKetQua4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua4.Name = "lblKetQua4";
            this.lblKetQua4.Size = new System.Drawing.Size(43, 25);
            this.lblKetQua4.TabIndex = 3;
            this.lblKetQua4.Text = "S =";
            // 
            // txtKetQua1
            // 
            this.txtKetQua1.ForeColor = System.Drawing.Color.Blue;
            this.txtKetQua1.Location = new System.Drawing.Point(161, 52);
            this.txtKetQua1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua1.Name = "txtKetQua1";
            this.txtKetQua1.Size = new System.Drawing.Size(488, 30);
            this.txtKetQua1.TabIndex = 4;
            // 
            // txtKetQua2
            // 
            this.txtKetQua2.ForeColor = System.Drawing.Color.Blue;
            this.txtKetQua2.Location = new System.Drawing.Point(161, 99);
            this.txtKetQua2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua2.Name = "txtKetQua2";
            this.txtKetQua2.Size = new System.Drawing.Size(488, 30);
            this.txtKetQua2.TabIndex = 5;
            // 
            // txtKetQua3
            // 
            this.txtKetQua3.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua3.Location = new System.Drawing.Point(161, 140);
            this.txtKetQua3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua3.Name = "txtKetQua3";
            this.txtKetQua3.Size = new System.Drawing.Size(488, 30);
            this.txtKetQua3.TabIndex = 6;
            // 
            // txtKetQua4
            // 
            this.txtKetQua4.ForeColor = System.Drawing.Color.Red;
            this.txtKetQua4.Location = new System.Drawing.Point(161, 181);
            this.txtKetQua4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua4.Name = "txtKetQua4";
            this.txtKetQua4.Size = new System.Drawing.Size(124, 30);
            this.txtKetQua4.TabIndex = 7;
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoThuc);
            this.Controls.Add(this.txtSoNguyen);
            this.Controls.Add(this.lblSoThuc);
            this.Controls.Add(this.lblSoNguyen);
            this.Controls.Add(this.btnTinhTong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính tổng S";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label lblSoNguyen;
        private System.Windows.Forms.Label lblSoThuc;
        private System.Windows.Forms.TextBox txtSoNguyen;
        private System.Windows.Forms.TextBox txtSoThuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKetQua4;
        private System.Windows.Forms.TextBox txtKetQua3;
        private System.Windows.Forms.TextBox txtKetQua2;
        private System.Windows.Forms.TextBox txtKetQua1;
        private System.Windows.Forms.Label lblKetQua4;
        private System.Windows.Forms.Label lblKetQua3;
        private System.Windows.Forms.Label lblKetQua2;
        private System.Windows.Forms.Label lblKetQua1;
    }
}