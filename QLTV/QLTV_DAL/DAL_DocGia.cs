using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_Entity;

namespace QLTV_DAL
{
    public class DAL_DocGia
    {
        KetNoiDB cn = new KetNoiDB();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_DocGia et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO DocGia (iddocgia, hoten, loaidocgia, ngaysinh, diachi, email, ngaylapthe) VALUES  ('" + et.iddocgia + "',N'" + et.hoten + "',N'" + et.loaidocgia + "',N'" + et.ngaysinh + "',N'" + et.diachi + "',N'" + et.email + "',N'" + et.ngaylapthe + "')");
        }
        //Sửa
        public void SuaDuLieu(E_DocGia et)
        {
            cn.ThucThiCauLenh(@"UPDATE DocGia SET ngaysinh = N'" + et.ngaysinh + "', hoten =N'" + et.hoten + "', loaidocgia ='" + et.loaidocgia + "', diachi ='" + et.diachi + "', email ='" + et.email + "', ngaylapthe ='" + et.ngaylapthe + "' Where iddocgia='" + et.iddocgia + "'");
        }
        //Xoá
        public void XoaDuLieu(E_DocGia et)
        {

            cn.ThucThiCauLenh(@"DELETE FROM DocGia  Where iddocgia='" + et.iddocgia + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from DocGia " + DieuKien);
        }

        public DataTable LayThongtinLDG(string DieuKien)
        {
            return cn.GetDataTable("Select loaidocgia from LoaiDocGia " + DieuKien);
        }
    }
}
