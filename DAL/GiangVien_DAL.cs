using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiangVien_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        //Hàm lấy danh sách giảng viên
        public IQueryable LayDSGiangVien()
        {
            var gv = from el in db.GiangViens
                     join k in db.Khoas on el.maKhoa equals k.maKhoa
                     select new
                     {
                         el.maGiangVien,
                         el.hoTen,
                         el.ngaySinh,
                         el.gioiTinh,
                         el.email,
                         el.sdt,
                         el.diaChi,
                         el.maKhoa
                     };
            return gv;
        }
        //Hàm kiểm tra mã giảng viên
        public bool KiemTraTrungMaGiangVien(string maGV)
        {
            return db.GiangViens.Any(x => x.maGiangVien == maGV);
        }
        //Hàm kiểm tra email giảng viên
        public bool KiemTraTrungEmailGiangVien(string email)
        {
            return db.GiangViens.Any(x => x.email == email);
        }
        //Hàm kiểm tra số điện thoại giảng viên
        public bool KiemTraTrungSDTGiangVien(string soDT)
        {
            return db.GiangViens.Any(x => x.sdt == soDT);
        }
        //Hàm lấy danh sách Khoa
        public IQueryable LayDSKhoa()
        {
            var gv = from k in db.Khoas
                     select k;
            return gv;
        }

        //Hàm thêm giảng viên
        public bool ThemGiangVien(GiangVien_ET gvEt)
        {
            try
            {
                GiangVien gv = new GiangVien()
                {
                    maGiangVien = gvEt.MaGV,
                    hoTen = gvEt.HoTen,
                    ngaySinh = gvEt.NgaySinh,
                    gioiTinh = gvEt.GioiTinh,
                    email = gvEt.Email,
                    sdt = gvEt.SDT,
                    diaChi = gvEt.DiaChi,
                    maKhoa = gvEt.MaKhoa
                };
                db.GiangViens.InsertOnSubmit(gv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Hàm xóa Giảng Viên
        public bool XoaGiangVien(string maGv)
        {
            try
            {
                // Xóa các phân công giảng viên
                var phanCongs = db.PhanCongGiangViens.Where(x => x.maGiangVien == maGv).ToList();
                db.PhanCongGiangViens.DeleteAllOnSubmit(phanCongs);

                // Gán null trong bảng LopHocPhan
                var lopHps = db.LopHocPhans.Where(x => x.magv == maGv).ToList();
                foreach (var lhp in lopHps)
                {
                    lhp.magv = null;
                }

                // Gán null trong bảng LopHoc
                var lopHocs = db.LopHocs.Where(x => x.maGiangVien == maGv).ToList();
                foreach (var lop in lopHocs)
                {
                    lop.maGiangVien = null;
                }

                // Xóa giảng viên
                var gv = db.GiangViens.FirstOrDefault(x => x.maGiangVien == maGv);
                if (gv != null)
                {
                    db.GiangViens.DeleteOnSubmit(gv);
                }

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm chỉnh sửa Giảng Viên
        public bool SuaGiangVien(GiangVien_ET gv)
        {
            try
            {
                var gv1 = db.GiangViens.FirstOrDefault(x => x.maGiangVien == gv.MaGV );
                if(gv1 != null)
                {
                    gv1.hoTen = gv.HoTen;
                    gv1.ngaySinh = gv.NgaySinh;
                    gv1.gioiTinh = gv.GioiTinh;
                    gv1.email = gv.Email;
                    gv1.sdt = gv.SDT;
                    gv1.diaChi = gv.DiaChi;
                    gv1.maKhoa = gv.MaKhoa;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Hàm lấy thông tin 1 giảng viên
        public IQueryable<GiangVien_ET> LayThongTin1GiangVien(string maGv)
        
        {
            var gv1 = from gv in db.GiangViens
                     where gv.maGiangVien == maGv
                     select new GiangVien_ET
                     {
                         MaGV = gv.maGiangVien,
                         HoTen = gv.hoTen,
                         NgaySinh = gv.ngaySinh,
                         GioiTinh = gv.gioiTinh,
                         Email = gv.email,
                         SDT = gv.sdt,
                         DiaChi = gv.diaChi,
                         MaKhoa = gv.maKhoa
                     };
            return gv1;
        }
        
    }
}
