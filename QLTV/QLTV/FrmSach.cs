using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV_DAL;
using QLTV_BUS;
using QLTV_Entity;

namespace QLTV
{
    public partial class FrmSach : Form
    {
        public FrmSach()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_Sach bus = new BUS_Sach();
        E_Sach ec = new E_Sach();
        E_DanhSachSach ecds = new E_DanhSachSach();
        BUS_DanhSachSach busds = new BUS_DanhSachSach();
        void KhoaDieuKien()
        {
            txtmasach.Enabled = false;
            txtnhaxuatban.Enabled = false;
            txttacgia.Enabled = false;
            txttensach.Enabled = false;
            txttrigia.Enabled = false;
            txttensach.Enabled = false;
            dtnamsx.Enabled = false;
            dtngaynhap.Enabled = false;
            cbtls.Enabled = false;

        }

        void MoDieuKien()
        {
            txtmasach.Enabled = false;
            txtnhaxuatban.Enabled = true;
            txttacgia.Enabled = true;
            txttensach.Enabled = true;
            txttrigia.Enabled = true;
            txttensach.Enabled = true;
            dtnamsx.Enabled = true;
            dtngaynhap.Enabled = true;
            cbtls.Enabled = true;

        }

        void setnull()
        {
            txttrigia.Text = "";
            txttimkiem.Text = "";
            txttensach.Text = "";
            txttacgia.Text = "";
            txtnhaxuatban.Text = "";
            txtmasach.Text = "";

            dtnamsx.Text = "";
            dtngaynhap.Text = "";
            cbtls.Text = "";
        }


        void HienThi(string where)
        {
           
            dgvdanhsachsach.DataSource = bus.TaoBang(where);

        }

        private void dgvdanhsachsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtmasach.Text = dgvdanhsachsach.Rows[dong].Cells[0].Value.ToString();
                txttensach.Text = dgvdanhsachsach.Rows[dong].Cells[1].Value.ToString();
                cbtls.Text = dgvdanhsachsach.Rows[dong].Cells[2].Value.ToString();
                dtnamsx.Text = dgvdanhsachsach.Rows[dong].Cells[4].Value.ToString();
                txttacgia.Text = dgvdanhsachsach.Rows[dong].Cells[3].Value.ToString();
                txtnhaxuatban.Text = dgvdanhsachsach.Rows[dong].Cells[5].Value.ToString();
                dtngaynhap.Text = dgvdanhsachsach.Rows[dong].Cells[6].Value.ToString();
                txttrigia.Text = dgvdanhsachsach.Rows[dong].Cells[7].Value.ToString();                



            }
            catch
            {

            }
        }

        //private void MaTuTangSTT()
        //{
        //    DataTable dt = db.GetDataTable("Select * from Sach");
        //    string h = "";

        //    int i = dt.Rows.Count;

        //    if (i <= 0)
        //    {
        //        h = "001";
        //    }

        //    else if (  1 <= i && i <10)
        //    {
        //        int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
        //        h = "";//ký tự mặc định của mã nhân viên
        //        k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(0, 1));
        //        k = k + 1;
        //        h = h + k.ToString();
        //    }
        //    else if(10<=i&&i<100)
        //    {
        //        int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
        //        h = "";//ký tự mặc định của mã nhân viên
        //        k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(0, 2));
        //        k = k + 1;
        //        h = h + k.ToString();
        //    }


        //    txtstt.Text = h;
        //}

        private void FrmSach_Load(object sender, EventArgs e)
        {
            cbtls.DataSource = bus.LayThongtinLS("");
            cbtls.ValueMember = "theloai";
            cbtls.DisplayMember = "theloai";
            KhoaDieuKien();
            HienThi("");
        }

   

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (btnthem.Text == "Thêm")
            {

                MoDieuKien();
                setnull();
                txtmasach.Focus();
                btnthem.Text = "Lưu";
                MaTuTang();
            }
            else if (btnthem.Text == "Lưu")
            {
                if (txtmasach.Text == "" || txttensach.Text == "" || cbtls.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {                       
                        ec.masach = txtmasach.Text;
                        ec.namsx = dtnamsx.Value.ToString();
                        ec.ngaynhap = dtngaynhap.Value.ToString();
                        ec.nhaxuatban = txtnhaxuatban.Text;
                        ec.tacgia = txttacgia.Text;
                        ec.tensach = txttensach.Text;
                        ec.theloai = cbtls.Text;
                        ec.trigia = txttrigia.Text;
                        bus.ThemDuLieu(ec);
                        ecds.masach = txtmasach.Text;
                        ecds.tensach = txttensach.Text;
                        ecds.theloai = cbtls.Text;
                        ecds.tacgia = txttacgia.Text;
                        busds.ThemDuLieu(ecds);


                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Báo lỗi", "Thông báo");
                        return;
                    }
                }
                btnthem.Text = "Thêm";
                KhoaDieuKien();
                HienThi("");
            }
        }
        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from Sach");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "BK00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "BK";//ký tự mặc định của mã nhân viên
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 5));
                k = k + 1;
                if (k < 10)

                    h = h + "0000";
                else if (k < 100)
                    h = h + "000";
                else if (k < 1000)
                    h = h + "00";
                else if (k < 10000)
                    h = h + "0";
                h = h + k.ToString();

            }
            txtmasach.Text = h;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "Sửa")
            {

                MoDieuKien();
                txtmasach.Focus();
                btnsua.Text = "Lưu";
            }
            else if (btnsua.Text == "Lưu")
            {
                if (txtmasach.Text == "" || txttensach.Text == "" || cbtls.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {                        
                        ec.masach = txtmasach.Text;
                        ec.namsx = dtnamsx.Value.ToString();
                        ec.ngaynhap = dtngaynhap.Value.ToString();
                        ec.nhaxuatban = txtnhaxuatban.Text;
                        ec.tacgia = txttacgia.Text;
                        ec.tensach = txttensach.Text;
                        ec.theloai = cbtls.Text;
                        ec.trigia = txttrigia.Text;                        
                        bus.SuaDuLieu(ec);
                        ecds.masach = txtmasach.Text;
                        ecds.tensach = txttensach.Text;
                        ecds.tacgia = txttacgia.Text;
                        ecds.theloai = cbtls.Text;
                        busds.SuaDuLieu(ecds);

                        MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Báo lỗi", "Thông báo");
                        return;
                    }
                }
                btnsua.Text = "Sửa";
                KhoaDieuKien();
                HienThi("");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.masach = txtmasach.Text;
                ecds.masach = txtmasach.Text;
                bus.XoaDuLieu(ec);
                
                if(busds.check(txtmasach.Text).Rows.Count>0)
                {
                    MessageBox.Show("Không Thể Xóa");
                    return;
                }
                busds.XoaDuLieu(ecds);
                MessageBox.Show("Xóa thành công");
                KhoaDieuKien();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Không thể xóa!");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMuonsach_Click(object sender, EventArgs e)
        {
            frmIDDG DG = new frmIDDG();
            DG.FLag = "Muon";
            DG.ShowDialog();
        }

        private void TraSach_Click(object sender, EventArgs e)
        {
            frmIDDG DG = new frmIDDG();
            DG.FLag = "Tra";
            DG.ShowDialog();
        }
    }



}
