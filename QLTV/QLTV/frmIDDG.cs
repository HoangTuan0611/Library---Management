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
    public partial class frmIDDG : Form
    {
        string _flag;
        BUS_IDDG bus = new BUS_IDDG();
        public frmIDDG()
        {
            InitializeComponent();
        }
        public string FLag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (bus.check(txtID.Text).Rows.Count >0)
            {
                if (_flag == "Muon")
                {
                    FrmPhieuMuonSach frmpms = new FrmPhieuMuonSach();
                    frmpms.Message = txtID.Text;
                    frmpms.ShowDialog();
                }
                else
                {
                    FrmTraSach frmTra = new FrmTraSach();
                    frmTra.Message = txtID.Text;
                    frmTra.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy ID");
            }

        }
    }
}
