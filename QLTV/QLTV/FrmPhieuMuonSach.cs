using QLTV_BUS;
using QLTV_DAL;
using QLTV_Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class FrmPhieuMuonSach : Form
    {
        E_PhieuMuonSach ec = new E_PhieuMuonSach();
        string _message;
        
        BUS_PhieuMuonSach bus = new BUS_PhieuMuonSach();
        public FrmPhieuMuonSach()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        private void frmPhieuMuonSach_Load(object sender, EventArgs e)
        {
            cbHoTen.DataSource = bus.LayThongtinHT("where iddocgia ='" + _message + "'");
            cbHoTen.ValueMember = "hoten";
            BUS_Sach buss = new BUS_Sach();
            DataTable dt = buss.LayDanhSachSach();

            //cbmasach.DisplayMember = "masach";
            //cbtacgia.DisplayMember = "tacgia";
            //cbtensach.DisplayMember = "tensach";
            //cbtheloai.DisplayMember = "theloai";
            cbmasach.ValueMember = "masach";
            cbtacgia.ValueMember = "tacgia";
            cbtensach.ValueMember = "tensach";
            cbtheloai.ValueMember = "theloai";
            cbmasach.DataSource = dt;
            cbtacgia.DataSource = dt;
            cbtheloai.DataSource = dt;
            cbtensach.DataSource = dt;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Them_click(object sender, EventArgs e)
        {
            try
            {
                if (bus.check(cbmasach.Text).Rows.Count > 0 )
                {
                    ec.hoten = cbHoTen.Text;
                    ec.iddocgia = _message;
                    ec.masach = cbmasach.Text;
                    ec.ngaymuon = dtngaymuon.Value.ToString();
                    ec.tacgia = cbtacgia.Text;
                    ec.theloai = cbtheloai.Text;
                    ec.tensach = cbtensach.Text;
                    bus.ThemDuLieu(ec);
                    bus.ThemDuLieu2(ec);
                    bus.updatetinhtrang(cbmasach.Text);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                    dgvPhieuMuonSach.DataSource = bus.TaoBang(_message);
                }
                else
                    MessageBox.Show("Sách đã có người mượn");

            }
            catch
            {
                MessageBox.Show("Báo lỗi", "Thông báo");
                return;
            }
        }
    }
}
