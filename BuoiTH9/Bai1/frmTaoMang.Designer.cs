namespace Bai1
{
    partial class frmTaoMang
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
            this.txtMangSoChan = new System.Windows.Forms.TextBox();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.lblCacPT = new System.Windows.Forms.Label();
            this.lblSoChan = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMangSoChan
            // 
            this.txtMangSoChan.Location = new System.Drawing.Point(115, 178);
            this.txtMangSoChan.Name = "txtMangSoChan";
            this.txtMangSoChan.Size = new System.Drawing.Size(339, 26);
            this.txtMangSoChan.TabIndex = 2;
            this.txtMangSoChan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(40, 73);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(489, 26);
            this.txtMang.TabIndex = 4;
            this.txtMang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCacPT
            // 
            this.lblCacPT.AutoSize = true;
            this.lblCacPT.Location = new System.Drawing.Point(190, 38);
            this.lblCacPT.Name = "lblCacPT";
            this.lblCacPT.Size = new System.Drawing.Size(180, 20);
            this.lblCacPT.TabIndex = 0;
            this.lblCacPT.Text = "Các phần tử trong mảng";
            // 
            // lblSoChan
            // 
            this.lblSoChan.AutoSize = true;
            this.lblSoChan.Location = new System.Drawing.Point(217, 144);
            this.lblSoChan.Name = "lblSoChan";
            this.lblSoChan.Size = new System.Drawing.Size(134, 20);
            this.lblSoChan.TabIndex = 3;
            this.lblSoChan.Text = "Các phần tử chẵn";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(224, 243);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 33);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTaoMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 328);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblSoChan);
            this.Controls.Add(this.lblCacPT);
            this.Controls.Add(this.txtMang);
            this.Controls.Add(this.txtMangSoChan);
            this.Name = "frmTaoMang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mảng các số nguyên";
            this.Load += new System.EventHandler(this.frmTaoMang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMangSoChan;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.Label lblCacPT;
        private System.Windows.Forms.Label lblSoChan;
        private System.Windows.Forms.Button btnThoat;
    }
}