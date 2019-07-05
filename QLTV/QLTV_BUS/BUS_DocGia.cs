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
    public class BUS_DocGia
    {
        DAL_DocGia sql = new DAL_DocGia();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_DocGia et)
        {
            sql.ThemDuLieu(et);
        }
        //Sửa
        public void SuaDuLieu(E_DocGia et)
        {
            sql.SuaDuLieu(et);
        }
        //Xoá
        public void XoaDuLieu(E_DocGia et)
        {
            sql.XoaDuLieu(et);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }

        public DataTable LayThongtinLDG(string DieuKien)
        {
            return sql.LayThongtinLDG(DieuKien);
        }
    }
}
