using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LopHoc_BUS
    {
        LopHoc_DAL lh_Dal = new LopHoc_DAL();

        //Hàm lấy dánh sách lớp học 
        public IQueryable LayDSLopHoc()
        {
            return lh_Dal.LayDSLopHoc();
        }

        //Hàm lấy danh sách giảng viên
        public IQueryable LayDSGiangVien()
        {
            return lh_Dal.LayDSGiangVien();
        }

        //Hàm lấy danh sách ngành
        public IQueryable LayDSNganh()
        {
            return lh_Dal.LayDSNganh();
        }

        //Hàm kiểm tra mã lớp học
        public bool KiemTraTrungMaLopHoc(string maLop)
        {
            return lh_Dal.KiemTraTrungMaLopHoc(maLop);
        }

        public bool KiemTraTrungLopDaTontai(string malop, string maNganh)
        {
            return lh_Dal.KiemTraTrungLopDaTontai(malop, maNganh);
        }
        //Hàm kiểm tra trùng tên lớp học 
        public bool KiemTraTrungTenLopHoc(string tenLop)
        {
            return lh_Dal.KiemTraTrungTenLop(tenLop);
        }
        public bool KiemTraTrungTenLopHoca(string maLop, string tenLop)
        {
            return lh_Dal.KiemTraTrungTenLopHoca(maLop, tenLop);
        }
        //Hàm thêm lớp học
        public bool ThemLop(LopHoc_ET lh)
        {
            return lh_Dal.ThemLop(lh);
        }

        //Hàm xóa lớp học
        public bool XoaLop(string maLopHoc)
        {
            return lh_Dal.XoaLop(maLopHoc);
        }

        //Hàm sửa lớp
        public bool SuaLop(LopHoc_ET lh)
        {
            return lh_Dal.SuaLop(lh);
        }
        //Hàm lấy thông tin sv 1 lớp
        public IQueryable ThongTin1LopHoc(string maLop)
        {
            return lh_Dal.ThongTin1LopHoc(maLop);
        }

        public IQueryable LayDSGiangVienTheoKhoa(string maKhoa)
        {
            return lh_Dal.LayDSGiangVienTheoKhoa(maKhoa);
        }

    }
}