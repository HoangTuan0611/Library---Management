namespace QLTV
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnDangNhap = new System.Windows.Forms.ToolStripButton();
            this.tbtnDocGia = new System.Windows.Forms.ToolStripButton();
            this.tbtnSach = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbtnHotro = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnDangNhap,
            this.tbtnDocGia,
            this.tbtnSach,
            this.toolStripButton1,
            this.tbtnHotro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnDangNhap
            // 
            this.tbtnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDangNhap.Image")));
            this.tbtnDangNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDangNhap.Name = "tbtnDangNhap";
            this.tbtnDangNhap.Size = new System.Drawing.Size(106, 24);
            this.tbtnDangNhap.Text = "Đăng nhập";
            this.tbtnDangNhap.Click += new System.EventHandler(this.tbtnDangNhap_Click);
            // 
            // tbtnDocGia
            // 
            this.tbtnDocGia.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDocGia.Image")));
            this.tbtnDocGia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDocGia.Name = "tbtnDocGia";
            this.tbtnDocGia.Size = new System.Drawing.Size(86, 24);
            this.tbtnDocGia.Text = "Độc Giả";
            this.tbtnDocGia.Click += new System.EventHandler(this.tbtnDocGia_Click);
            // 
            // tbtnSach
            // 
            this.tbtnSach.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSach.Image")));
            this.tbtnSach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSach.Name = "tbtnSach";
            this.tbtnSach.Size = new System.Drawing.Size(64, 24);
            this.tbtnSach.Text = "Sách";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 24);
            this.toolStripButton1.Text = "Báo Cáo";
            // 
            // tbtnHotro
            // 
            this.tbtnHotro.Image = ((System.Drawing.Image)(resources.GetObject("tbtnHotro.Image")));
            this.tbtnHotro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnHotro.Name = "tbtnHotro";
            this.tbtnHotro.Size = new System.Drawing.Size(76, 24);
            this.tbtnHotro.Text = "Hỗ trợ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 528);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMain";
            this.Text = "Quản lí thư viện";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnDangNhap;
        private System.Windows.Forms.ToolStripButton tbtnDocGia;
        private System.Windows.Forms.ToolStripButton tbtnSach;
        private System.Windows.Forms.ToolStripButton tbtnHotro;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

