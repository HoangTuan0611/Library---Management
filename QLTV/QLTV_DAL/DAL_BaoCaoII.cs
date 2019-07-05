using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAL
{
    public class DAL_BaoCaoII
    {
        KetNoiDB cn = new KetNoiDB();
        public void truyendl()
        {
            cn.ThucThiCauLenh("insert into  BaoCaoII(masach,tensach,ngaymuon) select masach,tensach,ngaymuon from PhieuMuonSach");
        }
        public void update(string DK)
        {           
            cn.ThucThiCauLenh("update BaoCaoII Set ngay=" + DK + ",songaytratre= DATEDIFF ( day , BaoCaoII.ngaymuon ," + DK + ")-4");
        }
        public void delete()
        {
            cn.ThucThiCauLenh("delete from BaoCaoII");
        }
        public DataTable TaoBang(string a)
        {
            return cn.GetDataTableBaoCaoII( a,"Select * from #TableTemp");
        }
    }
}
