using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LopHoc_DAL
    {
        QLSVDataContext db = new QLSVDataContext();
        
        //Hàm lấy danh sách lớp học
        public IQueryable LayDSLopHoc()
        {
            var lh = from l in db.LopHocs
                     join n in db.Nganhs on l.maNganh equals n.maNganh
                     join gv in db.GiangViens on l.maGiangVien equals gv.maGiangVien
                     select new
                     {
                         l.maLop,
                         l.tenLop,
                         l.khoaHoc,
                         l.maNganh,
                         l.maGiangVien
                     };
            return lh;
        }

        //Hàm lấy danh sách ngành
        public IQueryable LayDSNganh()
        {
            var n = from el in db.Nganhs
                    join k in db.Khoas on el.maKhoa equals k.maKhoa
                    select new
                    {
                        el.maKhoa,
                        el.maNganh,
                        el.tenNganh,
                        el.heDaoTao,
                        el.soNamHoc
                    };
            return n;
        }

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

        //Hàm kiểm tra mã lớp học
        public bool KiemTraTrungMaLopHoc(string maLop)
        {
            return db.LopHocs.Any(x => x.maLop == maLop);
        }
        //Hàm kiểm tra tên lớp học
        public bool KiemTraTrungTenLop(string tenLop)
        {
            return db.LopHocs.Any(x => x.tenLop == tenLop);
        }
        public bool KiemTraTrungLopDaTontai(string malop,string maNganh)
        {
            return db.LopHocs.Any(x => x.maLop == malop && x.maNganh == maNganh);
        }
        //Hàm thêm lớp học 
        public bool ThemLop(LopHoc_ET lh)
        {
            try
            {
                LopHoc lha = new LopHoc()
                {
                    maLop = lh.MaLop,
                    tenLop = lh.TenLop,
                    maGiangVien = lh.MaGiangVien,
                    maNganh = lh.MaNganh,
                    khoaHoc = lh.KhoaHoc
                };
                db.LopHocs.InsertOnSubmit(lha);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm xóa lớp học
        public bool XoaLop(string maLopHoc)
        {
            try
            {
                // Bước 1: Tìm tất cả sinh viên thuộc lớp này và set lophoc = null
                var dsSinhVien = db.SinhViens.Where(sv => sv.lophoc == maLopHoc).ToList();
                foreach (var sv in dsSinhVien)
                {
                    sv.lophoc = null;
                }

                // Bước 2: Xóa lớp học
                var lh = db.LopHocs.FirstOrDefault(x => x.maLop == maLopHoc);
                if (lh != null)
                {
                    db.LopHocs.DeleteOnSubmit(lh);
                }

                // Bước 3: Submit tất cả thay đổi
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public LopHoc LayLopHocTheoMa(string maLop)
        {
            return db.LopHocs.SingleOrDefault(lh => lh.maLop == maLop);
        }

        // Hàm kiểm tra tên lớp trùng lặp (ngoại trừ lớp đang sửa)
        public bool KiemTraTrungTenLopHoca(string maLop, string tenLop)
        {
            return db.LopHocs.Any(lh => lh.tenLop == tenLop && lh.maLop != maLop);
        }

        // Hàm cập nhật thông tin lớp học
        public bool SuaLop(LopHoc_ET lh)
        {
            try
            {
                var lop = db.LopHocs.FirstOrDefault(x => x.maLop == lh.MaLop);
                if (lop != null)
                {
                    lop.tenLop = lh.TenLop;
                    lop.khoaHoc = lh.KhoaHoc;
                    lop.maGiangVien = lh.MaGiangVien;
                    lop.maNganh = lh.MaNganh;

                    db.SubmitChanges(); // Lưu thay đổi vào database
                    return true;
                }
                
                return false;
            }
            catch 
            {
                return false;
            }
        }


        //Hàm lấy thông tin 1 lớp học 
        public IQueryable ThongTin1LopHoc(string maLop)
        {
            var lh = from sv in db.SinhViens
                     join l in db.LopHocs on sv.lophoc equals l.maLop
                     join a in db.Accounts on sv.account equals a.maAccount
                     where l.maLop == maLop
                     select new 
                     {
                         sv.maSv,
                         sv.hoTen,
                         sv.ngaySinh,
                         sv.gioiTinh,
                         sv.email,
                         sv.sdt,
                         sv.diaChi,
                         sv.account
                     };
            return lh;
        }

        public IQueryable LayDSGiangVienTheoKhoa(string maKhoa)
        {
            var gv = from el in db.GiangViens
                     where el.maKhoa == maKhoa // Chỉ lấy giảng viên thuộc khoa đó
                     select new
                     {
                         el.maGiangVien,
                         el.hoTen
                     };
            return gv;
        }
    }
}
 