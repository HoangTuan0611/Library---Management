using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV_Entity;

namespace QLTV_DAL
{
    public class DAL_Sach
    {
        KetNoiDB cn = new KetNoiDB();

        // Thêm Dữ Liệu
        public void ThemDuLieu(E_Sach et)
        {
            cn.ThucThiCauLenh(@"INSERT INTO Sach (masach, tensach, theloai, tacgia, namsx, nhaxuatban, ngaynhap, trigia) VALUES  ('" + et.masach + "',N'" + et.tensach + "',N'" + et.theloai + "',N'" + et.tacgia + "',N'" + et.namsx + "',N'" + et.nhaxuatban + "',N'" + et.ngaynhap + "',N'" + et.trigia + "')");
        }
        //Sửa
        public void SuaDuLieu(E_Sach et)
        {
            cn.ThucThiCauLenh(@"UPDATE Sach SET tensach = N'" + et.tensach + "', theloai =N'" + et.theloai + "', tacgia ='" + et.tacgia + "', namsx ='" + et.namsx + "', nhaxuatban ='" + et.nhaxuatban + "', ngaynhap ='" + et.ngaynhap + "', trigia ='" + et.trigia + "' Where masach='" + et.masach + "'");
        }
        //Xoá
        public void XoaDuLieu(E_Sach et)
        {

            cn.ThucThiCauLenh(@"DELETE FROM Sach  Where masach='" + et.masach + "'");
        }
        //Lấy Dữ Liệu
        //TaoBang("") select * from tblKhachHang where MaKH ='1'( ví dụ)
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from Sach " + DieuKien);
        }
        public DataTable LayDanhSachSach()
        {
            //string strSQL = "select makhachhang as 'Mã Khách Hàng', tenkhachhang as 'Tên Khách Hàng', diachi as 'Địa Chỉ', ngaysinh as 'Ngày Sinh', gioitinh as 'Giới Tính',sdt as 'Số Điện Thoại' , maphieumuon as 'Mã Phiếu Mượn' from KhachHang";
            string strSQL = "select * from Sach";
            return KetNoiDB.GetDanhSach(strSQL);
        }
        public DataTable LayThongtinLS(string DieuKien)
        {
            return cn.GetDataTable("Select theloai from TheLoai " + DieuKien);
        }
    }
}
