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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string TaiKhoan = string.Empty;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            tbtnDangNhap_Click(sender, e);
        }
        void KhoaDieuKien()
        {
            tbtnDangNhap.Enabled = true;
            tbtnDanhSachSach.Enabled = false;
            tbtnDocGia.Enabled = false;
            tbtnSach.Enabled = false;
            tbtnBaocaoII.Enabled = false;
            tbtnBaocao.Enabled = false;
        }

        void MoDieuKien()
        {
            tbtnDangNhap.Enabled = true;
            tbtnDanhSachSach.Enabled = true;
            tbtnDocGia.Enabled = true;
            tbtnSach.Enabled = true;
            tbtnBaocaoII.Enabled = true;
            tbtnBaocao.Enabled = true;
        }
        private void tbtnDangNhap_Click(object sender, EventArgs e)
        {
            if (tbtnDangNhap.Text == "Đăng nhập" && this.lbltaikhoan.Text == "")
            {
                FrmDangNhap dn = new FrmDangNhap();
                // chỉ 1 cửa sổ được mở ra!
                dn.ShowDialog();
                
                // nếu chuỗi có giá trị!
                if (!string.IsNullOrEmpty(TaiKhoan))
                {
                    this.lbltaikhoan.Text = TaiKhoan;
                    MoDieuKien();
                    tbtnDangNhap.Text = "Đăng xuất";
                }
            }
            else
            {

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    KhoaDieuKien();
                    this.lbltaikhoan.Text = "";
                    tbtnDangNhap.Text = "Đăng nhập";
                }

                if (this.lbltaikhoan.Text == "")
                {
                    KhoaDieuKien();
                    tbtnDangNhap.Text = "Đăng nhập";
                }

            }
        }

        private void tbtnDocGia_Click(object sender, EventArgs e)
        {
            FrmDocGia dg = new FrmDocGia();
            dg.ShowDialog();
        }

        private void tbtnSach_Click(object sender, EventArgs e)
        {
            FrmSach sc = new FrmSach();
            sc.ShowDialog();
        }

        private void DSS_Click(object sender, EventArgs e)
        {
            FrmDanhSachSach frmdss = new FrmDanhSachSach();
            frmdss.ShowDialog();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FrmBaoCaoI frmbci = new FrmBaoCaoI();
            frmbci.ShowDialog();
        }

        private void BaoCaoII_Click(object sender, EventArgs e)
        {
            FrmBaoCaoII frmbaocao = new FrmBaoCaoII();
            frmbaocao.ShowDialog();
        }
    }
}
