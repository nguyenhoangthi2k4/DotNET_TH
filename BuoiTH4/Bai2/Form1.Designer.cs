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
            this.lblInput = new System.Windows.Forms.Label();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnInMang = new System.Windows.Forms.Button();
            this.btnTimMax = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(58, 46);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(215, 25);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Nhập số phần tử mảng:";
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(646, 31);
            this.btnTaoMang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(218, 54);
            this.btnTaoMang.TabIndex = 1;
            this.btnTaoMang.Text = "Tạo mảng ngẫu nhiên";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // txtInput
            // 
            this.txtInput.ForeColor = System.Drawing.Color.Red;
            this.txtInput.Location = new System.Drawing.Point(308, 43);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(297, 30);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKetQua.Location = new System.Drawing.Point(58, 114);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(797, 107);
            this.lblKetQua.TabIndex = 3;
            // 
            // btnInMang
            // 
            this.btnInMang.Enabled = false;
            this.btnInMang.Location = new System.Drawing.Point(292, 249);
            this.btnInMang.Margin = new System.Windows.Forms.Padding(4);
            this.btnInMang.Name = "btnInMang";
            this.btnInMang.Size = new System.Drawing.Size(152, 54);
            this.btnInMang.TabIndex = 2;
            this.btnInMang.Text = "In mảng";
            this.btnInMang.UseVisualStyleBackColor = true;
            this.btnInMang.Click += new System.EventHandler(this.btnInMang_Click);
            // 
            // btnTimMax
            // 
            this.btnTimMax.Enabled = false;
            this.btnTimMax.Location = new System.Drawing.Point(499, 249);
            this.btnTimMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimMax.Name = "btnTimMax";
            this.btnTimMax.Size = new System.Drawing.Size(152, 54);
            this.btnTimMax.TabIndex = 3;
            this.btnTimMax.Text = "Tìm Max";
            this.btnTimMax.UseVisualStyleBackColor = true;
            this.btnTimMax.Click += new System.EventHandler(this.btnTimMax_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(703, 249);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 54);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 350);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimMax);
            this.Controls.Add(this.btnInMang);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnInMang;
        private System.Windows.Forms.Button btnTimMax;
        private System.Windows.Forms.Button btnThoat;
    }
}

