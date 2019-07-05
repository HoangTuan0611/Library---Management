using QLTV_DAL;
using QLTV_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class BUS_BaoCaoI
    {
        DAL_BaoCaoI sql = new DAL_BaoCaoI();
        public string getvalue(string DKthang, string DKtheloai)
        {
            return sql.GetValue(DKthang, DKtheloai);
        }
        public string getvalue2(string DKthang)
        {
            return sql.GetValue2(DKthang);
        }
        public DataTable Check(string Dkthang)
        {
            return sql.Check(Dkthang);
        }
        public void ThemDuLieu(E_BaoCaoI et)
        {
            sql.ThemDuLieu(et);
        }
        public void SuaDuLieu(E_BaoCaoI et,string DK)
        {
            sql.SuaDuLieu(et,DK);
        }
        public DataTable LayThang()
        {
            return sql.LayThang();
        }
        public DataTable TaoBang(string DK)
        {
            return sql.TaoBang(DK);
        }
    }
}
