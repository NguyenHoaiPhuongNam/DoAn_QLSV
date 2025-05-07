using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVienChucVuDoan_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        //lấy danh sách sinh viên chức vụ đoàn
        public IQueryable LayDSSVChucVuDoan()
        {
            var svcv = from svcvd in db.SinhVienChucVuDoans
                       join cv in db.ChucVuDoans on svcvd.maChucVu equals cv.maChucVu
                       join sv in db.SinhViens on svcvd.maSV equals sv.maSv
                       join hk in db.HocKies on svcvd.maHocKy equals hk.maHocKy
                       select new
                       {
                           svcvd.maSV,
                           svcvd.maChucVu,
                           svcvd.maHocKy
                       };
            return svcv;
        }
        //Lấy danh sách chức vụ
        public IQueryable LayDSChucVuDoan()
        {
            var cv = from el in db.ChucVuDoans
                     select el;
            return cv;
        }
        // Lấy danh sách học kỳ
        public IQueryable LayDSHocKy()
        {
            var hk = from hka in db.HocKies
                       select hka;
            return hk;
        }

        // Lấy danh sách sinh viên
        public IQueryable LayDSSinhVien()
        {
            var sv = from sva in db.SinhViens
                     select sva;
            return sv;
        }
        //Hàm kiểm tra mã trùng
        public bool KiemTraTrungMa(string maCV, string maHk, string maSV)
        {
            return db.SinhVienChucVuDoans.Any(n => n.maChucVu == maCV && n.maHocKy == maHk && n.maSV == maSV);
        }

        //Hàm thêm 
        public bool ThemSinhVienChucVu(SinhVienChucVuDoan_ET cv)
        {
            try
            {
                SinhVienChucVuDoan cva = new SinhVienChucVuDoan()
                {
                    maChucVu = cv.MaChucVu,
                    maHocKy = cv.MaHocKy,
                    maSV = cv.MaSV
                };
                db.SinhVienChucVuDoans.InsertOnSubmit(cva);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm xóa 
        public bool XoaSinhVienChucVu(string maCV, string maHk, string maSV)
        {
            try
            {
                var cv = db.SinhVienChucVuDoans.Where(n => n.maChucVu == maCV && n.maHocKy == maHk && n.maSV == maSV).FirstOrDefault();
                if (cv != null)
                {
                    db.SinhVienChucVuDoans.DeleteOnSubmit(cv);
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

        //Hàm sửa 
        public bool SuaSinhVienChucVuTheoHK(string maCV, string maSV)
        {
            try
            {
                var cv = db.SinhVienChucVuDoans.Where(n => n.maChucVu == maCV && n.maSV == maSV).FirstOrDefault();
                if (cv != null)
                {
                    db.SinhVienChucVuDoans.DeleteOnSubmit(cv);
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
        public bool KiemTraTrungMaSuaHK(string maCV, string maSV)
        {
            return db.SinhVienChucVuDoans.Any(n => n.maChucVu == maCV && n.maSV == maSV);
        }
        //Hàm sửa 
        public bool SuaSinhVienChucVuTheoCV(string maHk, string maSV)
        {
            try
            {
                var cv = db.SinhVienChucVuDoans.Where(n => n.maHocKy == maHk && n.maSV == maSV).FirstOrDefault();
                if (cv != null)
                {
                    db.SinhVienChucVuDoans.DeleteOnSubmit(cv);
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
        public bool KiemTraTrungMaSuaCv( string maHk, string maSV)
        {
            return db.SinhVienChucVuDoans.Any(n => n.maHocKy == maHk && n.maSV == maSV);
        }
        public bool KiemTraTrungMaSVa(string sv)
        {
            return db.SinhViens.Any(n => n.maSv == sv);
        }
    }
}
