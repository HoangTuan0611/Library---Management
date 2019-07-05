using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_DAL;
using QLTV_Entity;

namespace QLTV_BUS
{
    public class BUS_DanhSachSach
    {
        DAL_DanhSachSach sql = new DAL_DanhSachSach();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_DanhSachSach et)
        {
            sql.ThemDuLieu(et);
        }
        public DataTable check(string a)
        {
            return sql.Check(a);
        }
        //Sửa
        public void SuaDuLieu(E_DanhSachSach et)
        {
            sql.SuaDuLieu(et);
        }
        //Xoá
        public void XoaDuLieu(E_DanhSachSach et)
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
