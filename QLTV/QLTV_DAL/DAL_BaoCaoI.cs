using QLTV_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAL
{
    public class DAL_BaoCaoI
    {
        KetNoiDB cn = new KetNoiDB();
        public string GetValue(string DKthang, string DKtheloai)
        {
            return cn.GetValue("select count(*) from PhieuMuon where month(PhieuMuon.ngaymuon)='" + DKthang + "' and theloai = '" + DKtheloai + "'");
        }
        public string GetValue2(string DKthang)
        {
            return cn.GetValue("select count(*) from PhieuMuon where month(PhieuMuon.ngaymuon)='" + DKthang +  "'");
        }
        public DataTable Check(string DKthang)
        {
            return cn.GetDataTable(@"Select * from BaoCaoI where thang='" + DKthang + "'");
        }

        public void ThemDuLieu(E_BaoCaoI et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO BaoCaoI ( theloai, soluotmuon, thang, tile) VALUES  ('" + et.theloai + "','" + et.soluotmuon + "','" + et.thang+"','" + et.tile+ "')");
        }

        public void SuaDuLieu(E_BaoCaoI et, string DK)
        {
            cn.ThucThiCauLenh(@"UPDATE BaoCaoI SET soluotmuon =N'" + et.soluotmuon + "', thang ='" + et.thang + "', tile ='" + et.tile + "' Where theloai='" + et.theloai + "' and thang='" + DK +"'") ;
        }
        public DataTable LayThang()
        {
           return cn.GetDataTable("select id from Thang");
        }
        public DataTable TaoBang(string DK)
        {
            return cn.GetDataTableBaoCaoI(DK,"Select * from #TableTemp");
        }
    }
}
