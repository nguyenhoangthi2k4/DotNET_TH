namespace Bai3._1
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblTinhGiaTri = new System.Windows.Forms.Label();
            this.txbX = new System.Windows.Forms.TextBox();
            this.txbY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(224, 295);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(146, 60);
            this.btnTinh.TabIndex = 0;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(79, 131);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(48, 26);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "x = ";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(85, 204);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(42, 26);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "y =";
            // 
            // lblTinhGiaTri
            // 
            this.lblTinhGiaTri.AutoSize = true;
            this.lblTinhGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhGiaTri.Location = new System.Drawing.Point(206, 49);
            this.lblTinhGiaTri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinhGiaTri.Name = "lblTinhGiaTri";
            this.lblTinhGiaTri.Size = new System.Drawing.Size(210, 29);
            this.lblTinhGiaTri.TabIndex = 3;
            this.lblTinhGiaTri.Text = "Tính giá trị hàm số";
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(211, 131);
            this.txbX.Margin = new System.Windows.Forms.Padding(4);
            this.txbX.Name = "txbX";
            this.txbX.Size = new System.Drawing.Size(216, 32);
            this.txbX.TabIndex = 4;
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(211, 204);
            this.txbY.Margin = new System.Windows.Forms.Padding(4);
            this.txbY.Name = "txbY";
            this.txbY.Size = new System.Drawing.Size(216, 32);
            this.txbY.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 441);
            this.Controls.Add(this.txbY);
            this.Controls.Add(this.txbX);
            this.Controls.Add(this.lblTinhGiaTri);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnTinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAI 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblTinhGiaTri;
        private System.Windows.Forms.TextBox txbX;
        private System.Windows.Forms.TextBox txbY;
    }
}

