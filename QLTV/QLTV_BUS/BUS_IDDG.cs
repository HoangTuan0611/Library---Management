using QLTV_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_BUS
{
    public class BUS_IDDG
    {
        DAL_IDDG sql = new DAL_IDDG();
        public DataTable check(string a)
        {
            return sql.Check(a);
        }
    }
}
