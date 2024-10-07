namespace Bai3._2
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
            this.btnThongBao = new System.Windows.Forms.Button();
            this.lblThang = new System.Windows.Forms.Label();
            this.txbThang = new System.Windows.Forms.TextBox();
            this.lblMuaTrongNam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThongBao
            // 
            this.btnThongBao.Location = new System.Drawing.Point(118, 186);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(94, 38);
            this.btnThongBao.TabIndex = 0;
            this.btnThongBao.Text = "Thông báo";
            this.btnThongBao.UseVisualStyleBackColor = true;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(40, 126);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(58, 20);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng:";
            // 
            // txbThang
            // 
            this.txbThang.Location = new System.Drawing.Point(118, 122);
            this.txbThang.Name = "txbThang";
            this.txbThang.Size = new System.Drawing.Size(134, 26);
            this.txbThang.TabIndex = 2;
            // 
            // lblMuaTrongNam
            // 
            this.lblMuaTrongNam.AutoSize = true;
            this.lblMuaTrongNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuaTrongNam.Location = new System.Drawing.Point(97, 48);
            this.lblMuaTrongNam.Name = "lblMuaTrongNam";
            this.lblMuaTrongNam.Size = new System.Drawing.Size(203, 32);
            this.lblMuaTrongNam.TabIndex = 3;
            this.lblMuaTrongNam.Text = "Mùa trong năm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 274);
            this.Controls.Add(this.lblMuaTrongNam);
            this.Controls.Add(this.txbThang);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.btnThongBao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAI 3.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.TextBox txbThang;
        private System.Windows.Forms.Label lblMuaTrongNam;
    }
}

