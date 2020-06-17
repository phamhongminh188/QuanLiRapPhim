namespace Quanlirapphim
{
    partial class Form1
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
            this.dANHMỤCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHÒNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tÌMKIẾMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHIMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lỊCHCHIẾUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÁOCÁOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dANHMỤCToolStripMenuItem
            // 
            this.dANHMỤCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pHIMToolStripMenuItem,
            this.pHÒNGToolStripMenuItem});
            this.dANHMỤCToolStripMenuItem.Name = "dANHMỤCToolStripMenuItem";
            this.dANHMỤCToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.dANHMỤCToolStripMenuItem.Text = "DANH MỤC";
            // 
            // pHIMToolStripMenuItem
            // 
            this.pHIMToolStripMenuItem.Name = "pHIMToolStripMenuItem";
            this.pHIMToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pHIMToolStripMenuItem.Text = "PHIM";
            // 
            // pHÒNGToolStripMenuItem
            // 
            this.pHÒNGToolStripMenuItem.Name = "pHÒNGToolStripMenuItem";
            this.pHÒNGToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pHÒNGToolStripMenuItem.Text = "PHÒNG";
            // 
            // tÌMKIẾMToolStripMenuItem
            // 
            this.tÌMKIẾMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pHIMToolStripMenuItem1,
            this.lỊCHCHIẾUToolStripMenuItem});
            this.tÌMKIẾMToolStripMenuItem.Name = "tÌMKIẾMToolStripMenuItem";
            this.tÌMKIẾMToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tÌMKIẾMToolStripMenuItem.Text = "TÌM KIẾM";
            // 
            // pHIMToolStripMenuItem1
            // 
            this.pHIMToolStripMenuItem1.Name = "pHIMToolStripMenuItem1";
            this.pHIMToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pHIMToolStripMenuItem1.Text = "PHIM";
            this.pHIMToolStripMenuItem1.Click += new System.EventHandler(this.pHIMToolStripMenuItem1_Click);
            // 
            // lỊCHCHIẾUToolStripMenuItem
            // 
            this.lỊCHCHIẾUToolStripMenuItem.Name = "lỊCHCHIẾUToolStripMenuItem";
            this.lỊCHCHIẾUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lỊCHCHIẾUToolStripMenuItem.Text = "LỊCH CHIẾU";
            this.lỊCHCHIẾUToolStripMenuItem.Click += new System.EventHandler(this.lỊCHCHIẾUToolStripMenuItem_Click);
            // 
            // bÁOCÁOToolStripMenuItem
            // 
            this.bÁOCÁOToolStripMenuItem.Name = "bÁOCÁOToolStripMenuItem";
            this.bÁOCÁOToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bÁOCÁOToolStripMenuItem.Text = "BÁO CÁO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dANHMỤCToolStripMenuItem,
            this.tÌMKIẾMToolStripMenuItem,
            this.bÁOCÁOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quanlirapphim.Properties.Resources._12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 388);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ RẠP PHIM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem dANHMỤCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHÒNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tÌMKIẾMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHIMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lỊCHCHIẾUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÁOCÁOToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

