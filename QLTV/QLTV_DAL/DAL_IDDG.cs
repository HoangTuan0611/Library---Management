using QLTV_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_DAL
{
    public class DAL_IDDG
    {
        E_IDDG iddg = new E_IDDG();
        KetNoiDB cn = new KetNoiDB();
        public DataTable Check(string a)
        {
           return cn.GetDataTable(@"Select iddocgia from DocGia where iddocgia ='"+a+"'");
        }
    }
}
