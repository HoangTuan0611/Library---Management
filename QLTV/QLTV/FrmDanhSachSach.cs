using QLTV_BUS;
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
    public partial class FrmDanhSachSach : Form
    {
        BUS_DanhSachSach busds = new BUS_DanhSachSach();
        public FrmDanhSachSach()
        {
            InitializeComponent();
        }

        private void frmDanhSachSach_Load(object sender, EventArgs e)
        {
            HienThi("");
        }
        void HienThi(string where)
        {

            dgvDSS.DataSource = busds.TaoBang(where);

        }
    }
}
