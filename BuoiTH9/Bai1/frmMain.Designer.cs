namespace Bai1
{
    partial class Bai9
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
            this.btnKTSHH = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.lblSoN = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mởFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraSốHoànHảoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new System.Windows.Forms.Button();
            this.bntLamLai = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKTSHH
            // 
            this.btnKTSHH.Location = new System.Drawing.Point(26, 155);
            this.btnKTSHH.Name = "btnKTSHH";
            this.btnKTSHH.Size = new System.Drawing.Size(174, 56);
            this.btnKTSHH.TabIndex = 1;
            this.btnKTSHH.Text = "Kiểm tra số hoàn hảo";
            this.btnKTSHH.UseVisualStyleBackColor = true;
            this.btnKTSHH.Click += new System.EventHandler(this.btnKTSHH_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(263, 155);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(174, 56);
            this.btnTaoMang.TabIndex = 2;
            this.btnTaoMang.Text = "Tạo mảng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // lblSoN
            // 
            this.lblSoN.AutoSize = true;
            this.lblSoN.Location = new System.Drawing.Point(87, 84);
            this.lblSoN.Name = "lblSoN";
            this.lblSoN.Size = new System.Drawing.Size(100, 20);
            this.lblSoN.TabIndex = 0;
            this.lblSoN.Text = "Số nguyên N";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(194, 81);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(100, 26);
            this.txtSoN.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFormToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(464, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mởFormToolStripMenuItem
            // 
            this.mởFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmTraSốHoànHảoToolStripMenuItem,
            this.tạoMảngToolStripMenuItem});
            this.mởFormToolStripMenuItem.Name = "mởFormToolStripMenuItem";
            this.mởFormToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.mởFormToolStripMenuItem.Text = "Mở form";
            // 
            // kiểmTraSốHoànHảoToolStripMenuItem
            // 
            this.kiểmTraSốHoànHảoToolStripMenuItem.Name = "kiểmTraSốHoànHảoToolStripMenuItem";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.kiểmTraSốHoànHảoToolStripMenuItem.Text = "Kiểm tra số hoàn hảo";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraSốHoànHảoToolStripMenuItem_Click);
            // 
            // tạoMảngToolStripMenuItem
            // 
            this.tạoMảngToolStripMenuItem.Name = "tạoMảngToolStripMenuItem";
            this.tạoMảngToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.tạoMảngToolStripMenuItem.Text = "Tạo mảng";
            this.tạoMảngToolStripMenuItem.Click += new System.EventHandler(this.tạoMảngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(263, 252);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(174, 56);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // bntLamLai
            // 
            this.bntLamLai.Location = new System.Drawing.Point(26, 252);
            this.bntLamLai.Name = "bntLamLai";
            this.bntLamLai.Size = new System.Drawing.Size(174, 56);
            this.bntLamLai.TabIndex = 3;
            this.bntLamLai.Text = "Làm lại";
            this.bntLamLai.UseVisualStyleBackColor = true;
            this.bntLamLai.Click += new System.EventHandler(this.bntLamLai_Click);
            // 
            // Bai9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 328);
            this.Controls.Add(this.bntLamLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.lblSoN);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.btnKTSHH);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bai9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKTSHH;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Label lblSoN;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mởFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraSốHoànHảoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button bntLamLai;
    }
}

