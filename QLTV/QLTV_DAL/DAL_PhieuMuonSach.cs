using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_Entity;

namespace QLTV_DAL
{
    public class DAL_PhieuMuonSach
    {
        KetNoiDB cn = new KetNoiDB();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_PhieuMuonSach et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO PhieuMuonSach (idmuonsach, masach, iddocgia, stt, tensach, theloai, tacgia, hoten, ngaymuon) VALUES  ('" + et.idmuonsach + "',N'" + et.masach + "',N'" + et.iddocgia + "',N'" + et.stt + "',N'" + et.tensach + "',N'" + et.theloai + "',N'" + et.tacgia + "',N'" + et.hoten + "',N'" + et.ngaymuon + "')");
        }
        //Sửa
        public void SuaDuLieu(E_PhieuMuonSach et)
        {
            cn.ThucThiCauLenh(@"UPDATE PhieuMuonSach SET iddocgia =N'" + et.iddocgia + "', tensach = N'" + et.tensach + "', theloai =N'" + et.theloai + "', tacgia ='" + et.tacgia + "', masach ='" + et.masach + "', stt ='" + et.stt + "', hoten ='" + et.hoten + "', ngaymuon ='" + et.ngaymuon + "' Where idmuonsach='" + et.idmuonsach + "'");
        }
        //Xoá
        public void XoaDuLieu(E_PhieuMuonSach et)
        {

            cn.ThucThiCauLenh(@"DELETE FROM PhieuMuonSach  Where idmuonsach='" + et.idmuonsach + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from PhieuMuonSach " + DieuKien);
        }
    }
}
