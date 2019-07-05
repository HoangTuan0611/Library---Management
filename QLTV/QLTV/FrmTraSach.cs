using QLTV_BUS;
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
    public partial class FrmTraSach : Form
    {
        BUS_PhieuMuonSach bus = new BUS_PhieuMuonSach();
        string _message;
        string cell;
        E_PhieuMuonSach ec = new E_PhieuMuonSach();
        public FrmTraSach()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private void FrmTraSach_Load(object sender, EventArgs e)
        {
            dgvTraSach.DataSource = bus.TaoBang(_message);
        }

        private void BtnTra_Click(object sender, EventArgs e)
        {          
            bus.XoaDuLieu(cell);
            bus.updatetinhtrang2(cell);
            dgvTraSach.DataSource = bus.TaoBang(_message);
        }

        private void DgvTraSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            cell = dgvTraSach.Rows[dong].Cells[1].Value.ToString();
        }
    }
}
