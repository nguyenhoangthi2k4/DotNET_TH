﻿namespace Bai8
{
    partial class frmHinhTron
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
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblTinhCVDT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(136, 149);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(238, 26);
            this.txtDienTich.TabIndex = 12;
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(60, 152);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(71, 20);
            this.lblDienTich.TabIndex = 11;
            this.lblDienTich.Text = "Diện tích";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(170, 201);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 43);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(136, 96);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(238, 26);
            this.txtChuVi.TabIndex = 9;
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(60, 96);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(52, 20);
            this.lblChuVi.TabIndex = 8;
            this.lblChuVi.Text = "Chu vi";
            // 
            // lblTinhCVDT
            // 
            this.lblTinhCVDT.AutoSize = true;
            this.lblTinhCVDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhCVDT.Location = new System.Drawing.Point(30, 44);
            this.lblTinhCVDT.Name = "lblTinhCVDT";
            this.lblTinhCVDT.Size = new System.Drawing.Size(419, 29);
            this.lblTinhCVDT.TabIndex = 7;
            this.lblTinhCVDT.Text = "TÍNH CHU VI DIỆN TÍCH HÌNH TRÒN";
            // 
            // frmHinhTron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 288);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.lblTinhCVDT);
            this.Name = "frmHinhTron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHinhTron";
            this.Load += new System.EventHandler(this.frmHinhTron_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblTinhCVDT;
    }
}