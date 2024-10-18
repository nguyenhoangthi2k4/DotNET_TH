namespace Bai3
{
    partial class frmTinhTong
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
            this.lblTinhTong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTinhTong
            // 
            this.lblTinhTong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTinhTong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTinhTong.Location = new System.Drawing.Point(44, 63);
            this.lblTinhTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinhTong.Name = "lblTinhTong";
            this.lblTinhTong.Size = new System.Drawing.Size(367, 40);
            this.lblTinhTong.TabIndex = 0;
            // 
            // frmTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 183);
            this.Controls.Add(this.lblTinhTong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTinhTong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTinhTong";
            this.Load += new System.EventHandler(this.frmTinhTong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTinhTong;
    }
}