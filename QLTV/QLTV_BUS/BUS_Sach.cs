using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_Entity;
using QLTV_DAL;
using System.Data;

namespace QLTV_BUS
{
    public class BUS_Sach
    {
        DAL_Sach sql = new DAL_Sach();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_Sach et)
        {
            sql.ThemDuLieu(et);
        }
        //Sửa
        public void SuaDuLieu(E_Sach et)
        {
            sql.SuaDuLieu(et);
        }
        //Xoá
        public void XoaDuLieu(E_Sach et)
        {
            sql.XoaDuLieu(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
