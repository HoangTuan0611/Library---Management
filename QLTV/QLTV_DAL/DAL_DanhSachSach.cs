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
        public DataTable Check(string a)
        {
            return cn.GetDataTable(@"Select masach from Sach where masach ='" + a + "'");
        }

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_DanhSachSach et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO DanhSachSach (masach, tensach, theloai, tacgia) VALUES  ('" + et.masach + "',N'" + et.tensach + "',N'" + et.theloai + "',N'" + et.tacgia + "')");
        }
        //Sửa
        public void SuaDuLieu(E_DanhSachSach et)
        {
            cn.ThucThiCauLenh(@"UPDATE DanhSachSach SET tensach = N'" + et.tensach + "', theloai =N'" + et.theloai + "', tacgia ='" + et.tacgia + "' Where masach='" + et.masach + "'");
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
            return cn.GetDataTableDSS("Select * from #TableTemp " + DieuKien);
        }
    }
}
