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
    
    public partial class FrmBaoCaoI : Form
    {
        BUS_BaoCaoI bus = new BUS_BaoCaoI();
        E_BaoCaoI et = new E_BaoCaoI();
        string loaiA = "A";
        string loaiB = "B";
        string loaiC = "C";
        string a, b, c, tong;
        float sum=0;

        private void FrmBaoCaoI_Load(object sender, EventArgs e)
        {
            cbThang.DataSource = bus.LayThang();
            cbThang.DisplayMember = "id";
        }

        float A, B, C, Tong;

        private void Button1_Click(object sender, EventArgs e)
        {
            a = bus.getvalue(cbThang.Text, loaiA);
            b = bus.getvalue(cbThang.Text, loaiB);
            c= bus.getvalue(cbThang.Text, loaiC);
            tong = bus.getvalue2(cbThang.Text);
            A= Int32.Parse(a);
            B= Int32.Parse(b);
            C= Int32.Parse(c);
            Tong= Int32.Parse(tong);
            if (Tong == 0) Tong = 1;
            
            
            if (bus.Check(cbThang.Text).Rows.Count > 0)
            {
                    et.soluotmuon = a;
                    et.thang = cbThang.Text;
                    et.theloai = "A";
                    sum = A/Tong;
                    et.tile = sum.ToString();
                    bus.SuaDuLieu(et,cbThang.Text);
                    et.soluotmuon = b;
                    et.thang = cbThang.Text;
                    et.theloai = "B";
                    sum = B / Tong;
                    et.tile = sum.ToString();
                    bus.SuaDuLieu(et, cbThang.Text);
                    et.soluotmuon = c;
                    et.thang = cbThang.Text;
                    et.theloai = "C";
                    sum = C / Tong;
                    et.tile = sum.ToString();
                    bus.SuaDuLieu(et, cbThang.Text);
              
            }
            
            else
            {
                
                
                et.soluotmuon = a;
                et.thang = cbThang.Text;
                et.theloai = "A";
                sum = A / Tong;
                et.tile = sum.ToString();
                bus.ThemDuLieu(et);
                et.soluotmuon = b;
                et.thang = cbThang.Text;
                et.theloai = "B";
                sum = B / Tong;
                et.tile = sum.ToString();
                bus.ThemDuLieu(et);
                et.soluotmuon = c;
                et.thang = cbThang.Text;
                et.theloai = "C";
                sum = C / Tong;
                et.tile = sum.ToString();
                bus.ThemDuLieu(et);
            }
            dgvBaoCaoI.DataSource = bus.TaoBang(cbThang.Text);
        }

        public FrmBaoCaoI()
        {
            InitializeComponent();
        }
    }
}
