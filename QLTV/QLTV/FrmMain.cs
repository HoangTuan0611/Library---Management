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

        private void FrmMain_Load(object sender, EventArgs e)
        {

            //tbtnDangNhap_Click(sender, e);
        }

        private void tbtnDangNhap_Click(object sender, EventArgs e)
        {
            if (tbtnDangNhap.Text == "Đăng nhập")
            {
                FrmDangNhap dn = new FrmDangNhap();
                // chỉ 1 cửa sổ được mở ra!
                dn.ShowDialog();

             
                //MoDieuKien();
                tbtnDangNhap.Text = "Đăng xuất";
                
            }
            else
            {

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có thật sự muốn đăng xuất?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    //KhoaDieuKien();
                    //this.lbltaikhoan.Text = "";
                    tbtnDangNhap.Text = "Đăng nhập";
                }

                
                //KhoaDieuKien();
                //tbtnDangNhap.Text = "Đăng nhập";
                

            }
        }

        private void tbtnDocGia_Click(object sender, EventArgs e)
        {
            FrmDocGia dg = new FrmDocGia();
            dg.ShowDialog();
        }
    }
}
