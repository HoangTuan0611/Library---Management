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

namespace QLTV
{
    public partial class FrmSach : Form
    {
        public FrmSach()
        {
            InitializeComponent();
        }
        KetNoiDB db = new KetNoiDB();
        
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
            txtmasach.Enabled = true;
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

        //void HienThi(string where)
        //{
        //    dgvDocgia.DataSource = bus.TaoBang(where);
        //}


    }
}
