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
using QLTV_Entity;
using QLTV_BUS;

namespace QLTV
{
    public partial class FrmDocGia : Form
    {
        public FrmDocGia()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        BUS_DocGia bus = new BUS_DocGia();
        E_DocGia ec = new E_DocGia();
        //bool themmoi;

        void KhoaDieuKien()
        {
            txtdiachi.Enabled = false;
            txtemail.Enabled = false;
            txthoten.Enabled = false;
            txtiddocgia.Enabled = false;

            dtngaylapthe.Enabled = false;
            dtngaysinh.Enabled = false;
            cbldg.Enabled = false;

        }

        void MoDieuKien()
        {
            txtdiachi.Enabled = true;
            txtemail.Enabled = true;
            txthoten.Enabled = true;
            txtiddocgia.Enabled = false;

            dtngaylapthe.Enabled = true;
            dtngaysinh.Enabled = true;
            cbldg.Enabled = true;
        }

        void setnull()
        {
            txtdiachi.Text = "";
            txtemail.Text = "";
            txthoten.Text = "";
            txtiddocgia.Text = "";
            cbldg.Text = "";
            dtngaylapthe.Text = "";
            dtngaysinh.Text = "";
        }

        void HienThi(string where)
        {
            dgvDocgia.DataSource = bus.TaoBang(where);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtiddocgia.Text = dgvDocgia.Rows[dong].Cells[0].Value.ToString();
                txthoten.Text = dgvDocgia.Rows[dong].Cells[1].Value.ToString();
                cbldg.Text = dgvDocgia.Rows[dong].Cells[2].Value.ToString();
                dtngaysinh.Text = dgvDocgia.Rows[dong].Cells[3].Value.ToString();
                txtdiachi.Text = dgvDocgia.Rows[dong].Cells[1].Value.ToString();
                dtngaylapthe.Text = dgvDocgia.Rows[dong].Cells[2].Value.ToString();
                txtemail.Text = dgvDocgia.Rows[dong].Cells[3].Value.ToString();

            }
            catch
            {

            }
        }

 

        private void FrmDocGia_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            HienThi("");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
         
            if (btnthem.Text == "Thêm")
            {
                
                MoDieuKien();
                setnull();
                txtiddocgia.Focus();
                btnthem.Text = "Lưu";
                MaTuTang();
            }
            else if(btnthem.Text=="Lưu")
            { 
                if (txtiddocgia.Text == "" || txthoten.Text == "" || cbldg.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.diachi = txtdiachi.Text;
                        ec.email = txtemail.Text;
                        ec.hoten = txthoten.Text;
                        ec.iddocgia = txtiddocgia.Text;
                        ec.loaidocgia = cbldg.Text;
                        ec.ngaylapthe = dtngaylapthe.Value.ToString();
                        ec.ngaysinh = dtngaysinh.Value.ToString();
                        bus.ThemDuLieu(ec);
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "Sửa")
            {
                MoDieuKien();
                txtiddocgia.Focus();
                btnsua.Text = "Lưu";
            }
            else if (btnsua.Text == "Lưu")
            {
                if (txtiddocgia.Text == "" || txthoten.Text == "" || cbldg.Text == "")
                {
                    MessageBox.Show("Xin mời nhập đầy đủ thông tin", "Thông Báo");
                    return;
                }
                else
                {
                    try
                    {
                        ec.diachi = txtdiachi.Text;
                        ec.email = txtemail.Text;
                        ec.hoten = txthoten.Text;
                        ec.iddocgia = txtiddocgia.Text;
                        ec.loaidocgia = cbldg.Text;
                        ec.ngaylapthe = dtngaylapthe.Value.ToString();
                        ec.ngaysinh = dtngaysinh.Value.ToString();
                        bus.SuaDuLieu(ec);
                        MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo");

                    }
                    catch
                    {
                        MessageBox.Show("Báo lỗi", "Thông báo");
                        return;
                    }
                }
                KhoaDieuKien();
                HienThi("");
                btnsua.Text = "Sửa";
            }
          
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.iddocgia = txtiddocgia.Text;
                bus.XoaDuLieu(ec);
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

        private void MaTuTang()
        {
            DataTable dt = db.GetDataTable("Select * from DocGia");
            string h = "";

            if (dt.Rows.Count <= 0) 
            {
                h = "DG00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã nhân viên đã có
                h = "DG";//ký tự mặc định của mã nhân viên
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
            txtiddocgia.Text = h;
        }
    }
}
