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
    public partial class FrmBaoCaoII : Form
    {
        BUS_BaoCaoII bus = new BUS_BaoCaoII();
        public FrmBaoCaoII()
        {
            InitializeComponent();
        }
        int day = DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;
        private void FrmBaoCaoII_Load(object sender, EventArgs e)
        {
            txtNgay.Text = "'"+month + "/" + day + "/" + year+"'";
            bus.truyendl();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
        
          bus.update(txtNgay.Text);
          dataGridView1.DataSource = bus.TaoBang(txtNgay.Text);

        }

        private void FrmBaoCaoII_FormClosed(object sender, FormClosedEventArgs e)
        {
            bus.delete();
        }
    }
}
