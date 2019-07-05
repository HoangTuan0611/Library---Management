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
    public class BUS_PhieuMuonSach
    {
        DAL_PhieuMuonSach sql = new DAL_PhieuMuonSach();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_PhieuMuonSach et)
        {
            sql.ThemDuLieu(et);
        }
        public void ThemDuLieu2(E_PhieuMuonSach et)
        {
            sql.ThemDuLieu2(et);
        }
        //Sửa
        //public void SuaDuLieu(E_PhieuMuonSach et)
        //{
        //    sql.SuaDuLieu(et);
        //}
        //Xoá
        public void XoaDuLieu(string a)
        {
            sql.XoaDuLieu(a);
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string a)
        {
            return sql.TaoBang(a);
        }
        public DataTable LayThongtinHT(string DieuKien)
        {
            return sql.LayThongtinHT(DieuKien);
        }
        public DataTable check(string a)
        {
            return sql.Check(a);
        }
        public string getvalue(string a)
        {
            return sql.getvalue(a);
        }
        public void updatetinhtrang(string DK)
        {
            sql.updatetinhtrang(DK);
        }
        public void updatetinhtrang2(string DK)
        {
            sql.updatetinhtrang2(DK);
        }
    }
}
