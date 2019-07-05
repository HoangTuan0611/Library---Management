namespace QLTV
{
    partial class FrmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSach));
            this.function = new System.Windows.Forms.ToolStrip();
            this.btnMuonsach = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdanhsachsach = new System.Windows.Forms.DataGridView();
            this.dtnamsx = new System.Windows.Forms.DateTimePicker();
            this.txtnhaxuatban = new System.Windows.Forms.TextBox();
            this.txttacgia = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttrigia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbtls = new System.Windows.Forms.ComboBox();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trigia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.function.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachsach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // function
            // 
            this.function.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.function.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMuonsach,
            this.toolStripButton3});
            this.function.Location = new System.Drawing.Point(0, 0);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(918, 27);
            this.function.TabIndex = 0;
            this.function.Text = "toolStrip1";
            // 
            // btnMuonsach
            // 
            this.btnMuonsach.Image = ((System.Drawing.Image)(resources.GetObject("btnMuonsach.Image")));
            this.btnMuonsach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMuonsach.Name = "btnMuonsach";
            this.btnMuonsach.Size = new System.Drawing.Size(91, 24);
            this.btnMuonsach.Text = "Mượn Sách";
            this.btnMuonsach.Click += new System.EventHandler(this.BtnMuonsach_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(75, 24);
            this.toolStripButton3.Text = "Trả Sách";
            this.toolStripButton3.Click += new System.EventHandler(this.TraSach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdanhsachsach);
            this.groupBox1.Location = new System.Drawing.Point(0, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(918, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "`";
            // 
            // dgvdanhsachsach
            // 
            this.dgvdanhsachsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsachsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.theloai,
            this.namsx,
            this.tacgia,
            this.nhaxuatban,
            this.ngaynhap,
            this.trigia});
            this.dgvdanhsachsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdanhsachsach.Location = new System.Drawing.Point(2, 15);
            this.dgvdanhsachsach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvdanhsachsach.Name = "dgvdanhsachsach";
            this.dgvdanhsachsach.Size = new System.Drawing.Size(914, 222);
            this.dgvdanhsachsach.TabIndex = 0;
            this.dgvdanhsachsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsachsach_CellClick);
            // 
            // dtnamsx
            // 
            this.dtnamsx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnamsx.Location = new System.Drawing.Point(373, 44);
            this.dtnamsx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtnamsx.Name = "dtnamsx";
            this.dtnamsx.Size = new System.Drawing.Size(213, 20);
            this.dtnamsx.TabIndex = 27;
            // 
            // txtnhaxuatban
            // 
            this.txtnhaxuatban.Location = new System.Drawing.Point(373, 102);
            this.txtnhaxuatban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnhaxuatban.Name = "txtnhaxuatban";
            this.txtnhaxuatban.Size = new System.Drawing.Size(213, 20);
            this.txtnhaxuatban.TabIndex = 25;
            // 
            // txttacgia
            // 
            this.txttacgia.Location = new System.Drawing.Point(373, 72);
            this.txttacgia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttacgia.Name = "txttacgia";
            this.txttacgia.Size = new System.Drawing.Size(213, 20);
            this.txttacgia.TabIndex = 24;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(108, 69);
            this.txttensach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(175, 20);
            this.txttensach.TabIndex = 23;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(108, 43);
            this.txtmasach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(175, 20);
            this.txtmasach.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tác Giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Năm sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Sách";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Trị giá";
            // 
            // txttrigia
            // 
            this.txttrigia.Location = new System.Drawing.Point(668, 104);
            this.txttrigia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttrigia.Name = "txttrigia";
            this.txttrigia.Size = new System.Drawing.Size(151, 20);
            this.txttrigia.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnsua);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 36);
            this.panel1.TabIndex = 33;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(320, 10);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(56, 19);
            this.btnthoat.TabIndex = 37;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(226, 9);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(56, 19);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(125, 10);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(56, 19);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(17, 10);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 19);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(830, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 34;
            this.button4.Text = "Tìm kiếm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(607, 10);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(210, 20);
            this.txttimkiem.TabIndex = 35;
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaynhap.Location = new System.Drawing.Point(668, 72);
            this.dtngaynhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(151, 20);
            this.dtngaynhap.TabIndex = 36;
            // 
            // cbtls
            // 
            this.cbtls.FormattingEnabled = true;
            this.cbtls.Location = new System.Drawing.Point(108, 99);
            this.cbtls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbtls.Name = "cbtls";
            this.cbtls.Size = new System.Drawing.Size(175, 21);
            this.cbtls.TabIndex = 37;
            // 
            // masach
            // 
            this.masach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã Sách";
            this.masach.MinimumWidth = 10;
            this.masach.Name = "masach";
            this.masach.Width = 75;
            // 
            // tensach
            // 
            this.tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên Sách";
            this.tensach.Name = "tensach";
            this.tensach.Width = 79;
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "theloai";
            this.theloai.HeaderText = "Thể loại";
            this.theloai.Name = "theloai";
            // 
            // namsx
            // 
            this.namsx.DataPropertyName = "namsx";
            this.namsx.HeaderText = "Năm sản xuất";
            this.namsx.Name = "namsx";
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.Name = "tacgia";
            // 
            // nhaxuatban
            // 
            this.nhaxuatban.DataPropertyName = "nhaxuatban";
            this.nhaxuatban.HeaderText = "Nhà xuất bản";
            this.nhaxuatban.Name = "nhaxuatban";
            // 
            // ngaynhap
            // 
            this.ngaynhap.DataPropertyName = "ngaynhap";
            this.ngaynhap.HeaderText = "Ngày nhập";
            this.ngaynhap.Name = "ngaynhap";
            // 
            // trigia
            // 
            this.trigia.DataPropertyName = "trigia";
            this.trigia.HeaderText = "Trị giá";
            this.trigia.Name = "trigia";
            // 
            // FrmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 430);
            this.Controls.Add(this.cbtls);
            this.Controls.Add(this.dtngaynhap);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttrigia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtnamsx);
            this.Controls.Add(this.txtnhaxuatban);
            this.Controls.Add(this.txttacgia);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.function);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSach";
            this.Text = "Quản lý Sách";
            this.Load += new System.EventHandler(this.FrmSach_Load);
            this.function.ResumeLayout(false);
            this.function.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsachsach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip function;
        private System.Windows.Forms.ToolStripButton btnMuonsach;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtnamsx;
        private System.Windows.Forms.TextBox txtnhaxuatban;
        private System.Windows.Forms.TextBox txttacgia;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttrigia;
        private System.Windows.Forms.DataGridView dgvdanhsachsach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox cbtls;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn trigia;
    }
}