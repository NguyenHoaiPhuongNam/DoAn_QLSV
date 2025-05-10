using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiangVien_BUS
    {
        //Giọi class GiangVien_DAL
        GiangVien_DAL gv_DAL = new GiangVien_DAL();

        //Hàm lấy danh sách giảng viên
        public IQueryable LayDSGiangVien()
        {
            return gv_DAL.LayDSGiangVien();
        }

        //Hàm kiểm tra trùng mã giảng viên
        public bool KiemTraTrungMaGV(string maGV)
        {
            return gv_DAL.KiemTraTrungMaGiangVien(maGV);
        }
        //Hàm kiểm tra trùng mã giảng viên
        public bool KiemTraTrungEmailGV(string email)
        {
            return gv_DAL.KiemTraTrungEmailGiangVien(email);
        }
        //Hàm kiểm tra trùng mã giảng viên
        public bool KiemTraTrungSDTGV(string soDT)
        {
            return gv_DAL.KiemTraTrungSDTGiangVien(soDT);
        }
        //Hàm lấy danh sách Khoa
        public IQueryable LayDSKhoa()
        {
            return gv_DAL.LayDSKhoa();
        }

        //Hàm thêm giảng viên
        public bool ThemGiangVien(GiangVien_ET gv)
        {
            return gv_DAL.ThemGiangVien(gv);
        }

        // Hàm Xóa giảng viên
        public bool XoaGiangVien(string maGv)
        {
            return gv_DAL.XoaGiangVien(maGv);
        }

        //Hàm sửa giảng viên
        public bool SuaGiangVien(GiangVien_ET gv)
        {
            return gv_DAL.SuaGiangVien(gv);
        }

        // Hàm lấy thông tin 1 giảng viên
        public IQueryable<GiangVien_ET> ThongTin1GiangVien(string gv)
        {
            return gv_DAL.LayThongTin1GiangVien(gv);
        }
    }
}
