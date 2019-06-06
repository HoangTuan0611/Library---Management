using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_Entity;
namespace QLTV_DAL
{
    public class DAL_DanhSachSach
    {
        KetNoiDB cn = new KetNoiDB();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_DanhSachSach et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO DanhSachSach (stt, masach, tensach, theloai, tacgia, tinhtrang) VALUES  ('" + et.stt + "',N'" + et.masach + "',N'" + et.tensach + "',N'" + et.theloai + "',N'" + et.tacgia + "',N'" + et.tinhtrang + "')");
        }
        //Sửa
        public void SuaDuLieu(E_DanhSachSach et)
        {
            cn.ThucThiCauLenh(@"UPDATE DanhSachSach SET tensach = N'" + et.tensach + "', theloai =N'" + et.theloai + "', tacgia ='" + et.tacgia + "', stt ='" + et.stt + "', tinhtrang ='" + et.tinhtrang + "' Where masach='" + et.masach + "'");
        }
        //Xoá
        public void XoaDuLieu(E_DanhSachSach et)
        {

            cn.ThucThiCauLenh(@"DELETE FROM DanhSachSach  Where masach='" + et.masach + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from DanhSachSach " + DieuKien);
        }
    }
}
