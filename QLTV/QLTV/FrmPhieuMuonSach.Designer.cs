namespace QLTV
{
    partial class FrmPhieuMuonSach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtngaymuon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuMuonSach = new System.Windows.Forms.DataGridView();
            this.cbHoTen = new System.Windows.Forms.ComboBox();
            this.cbmasach = new System.Windows.Forms.ComboBox();
            this.cbtensach = new System.Windows.Forms.ComboBox();
            this.cbtheloai = new System.Windows.Forms.ComboBox();
            this.cbtacgia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.abcv = new System.Windows.Forms.Label();
            this.xyz = new System.Windows.Forms.Label();
            this.abc = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbHoTen);
            this.panel1.Controls.Add(this.dtngaymuon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 57);
            this.panel1.TabIndex = 0;
            // 
            // dtngaymuon
            // 
            this.dtngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaymuon.Location = new System.Drawing.Point(385, 21);
            this.dtngaymuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtngaymuon.Name = "dtngaymuon";
            this.dtngaymuon.Size = new System.Drawing.Size(183, 20);
            this.dtngaymuon.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên Độc giả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnthem);
            this.panel2.Controls.Add(this.btnthoat);
            this.panel2.Location = new System.Drawing.Point(3, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 33);
            this.panel2.TabIndex = 1;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(18, 7);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(56, 19);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.Them_click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(106, 7);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(56, 19);
            this.btnthoat.TabIndex = 38;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhieuMuonSach);
            this.groupBox1.Location = new System.Drawing.Point(3, 167);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(594, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dgvPhieuMuonSach
            // 
            this.dgvPhieuMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.masach,
            this.tensach,
            this.theloai,
            this.tacgia});
            this.dgvPhieuMuonSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuMuonSach.Location = new System.Drawing.Point(2, 15);
            this.dgvPhieuMuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuMuonSach.Name = "dgvPhieuMuonSach";
            this.dgvPhieuMuonSach.RowTemplate.Height = 24;
            this.dgvPhieuMuonSach.Size = new System.Drawing.Size(590, 172);
            this.dgvPhieuMuonSach.TabIndex = 0;
            // 
            // cbHoTen
            // 
            this.cbHoTen.FormattingEnabled = true;
            this.cbHoTen.Location = new System.Drawing.Point(106, 21);
            this.cbHoTen.Name = "cbHoTen";
            this.cbHoTen.Size = new System.Drawing.Size(169, 21);
            this.cbHoTen.TabIndex = 17;
            // 
            // cbmasach
            // 
            this.cbmasach.FormattingEnabled = true;
            this.cbmasach.Location = new System.Drawing.Point(109, 72);
            this.cbmasach.Name = "cbmasach";
            this.cbmasach.Size = new System.Drawing.Size(121, 21);
            this.cbmasach.TabIndex = 3;
            // 
            // cbtensach
            // 
            this.cbtensach.FormattingEnabled = true;
            this.cbtensach.Location = new System.Drawing.Point(109, 104);
            this.cbtensach.Name = "cbtensach";
            this.cbtensach.Size = new System.Drawing.Size(121, 21);
            this.cbtensach.TabIndex = 4;
            // 
            // cbtheloai
            // 
            this.cbtheloai.FormattingEnabled = true;
            this.cbtheloai.Location = new System.Drawing.Point(388, 72);
            this.cbtheloai.Name = "cbtheloai";
            this.cbtheloai.Size = new System.Drawing.Size(121, 21);
            this.cbtheloai.TabIndex = 5;
            // 
            // cbtacgia
            // 
            this.cbtacgia.FormattingEnabled = true;
            this.cbtacgia.Location = new System.Drawing.Point(388, 104);
            this.cbtacgia.Name = "cbtacgia";
            this.cbtacgia.Size = new System.Drawing.Size(121, 21);
            this.cbtacgia.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Sách";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // abcv
            // 
            this.abcv.AutoSize = true;
            this.abcv.Location = new System.Drawing.Point(333, 75);
            this.abcv.Name = "abcv";
            this.abcv.Size = new System.Drawing.Size(49, 13);
            this.abcv.TabIndex = 8;
            this.abcv.Text = "Thể Loại";
            // 
            // xyz
            // 
            this.xyz.AutoSize = true;
            this.xyz.Location = new System.Drawing.Point(333, 107);
            this.xyz.Name = "xyz";
            this.xyz.Size = new System.Drawing.Size(45, 13);
            this.xyz.TabIndex = 9;
            this.xyz.Text = "Tác Giả";
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.Location = new System.Drawing.Point(49, 107);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(54, 13);
            this.abc.TabIndex = 10;
            this.abc.Text = "Tên Sách";
            // 
            // stt
            // 
            this.stt.DataPropertyName = "stt";
            this.stt.Frozen = true;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.Frozen = true;
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            this.masach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.masach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.Frozen = true;
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            this.tensach.ReadOnly = true;
            this.tensach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tensach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "theloai";
            this.theloai.Frozen = true;
            this.theloai.HeaderText = "Thể loại";
            this.theloai.Name = "theloai";
            this.theloai.ReadOnly = true;
            // 
            // tacgia
            // 
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.Name = "tacgia";
            this.tacgia.ReadOnly = true;
            this.tacgia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tacgia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmPhieuMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.abc);
            this.Controls.Add(this.xyz);
            this.Controls.Add(this.abcv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbtacgia);
            this.Controls.Add(this.cbtheloai);
            this.Controls.Add(this.cbtensach);
            this.Controls.Add(this.cbmasach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPhieuMuonSach";
            this.Text = "Phiếu Mượn sách";
            this.Load += new System.EventHandler(this.frmPhieuMuonSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPhieuMuonSach;
        private System.Windows.Forms.DateTimePicker dtngaymuon;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox cbHoTen;
        private System.Windows.Forms.ComboBox cbmasach;
        private System.Windows.Forms.ComboBox cbtensach;
        private System.Windows.Forms.ComboBox cbtheloai;
        private System.Windows.Forms.ComboBox cbtacgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label abcv;
        private System.Windows.Forms.Label xyz;
        private System.Windows.Forms.Label abc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
    }
}