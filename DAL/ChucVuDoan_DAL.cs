using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDoan_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        //Hàm lấy danh sách chức vụ đoàn
        public IQueryable LayDSChucVuDoan()
        {
            var cv = from el in db.ChucVuDoans
                     select el;
            return cv;
        }


        //Hàm kiểm tra mã chức vụ 
        public bool KiemTraTrungMaChucVu(string maCV)
        {
            return db.ChucVuDoans.Any(n => n.maChucVu == maCV);
        }

        //Hàm kiểm tra tên Khoa
        public bool KiemTraTrungTenChucVu(string tenCV)
        {
            return db.ChucVuDoans.Any(n => n.tenChucVu == tenCV);
        }

        //Hàm thêm Khoa
        public bool ThemChucVu(ChucVuDoan_ET cv)
        {
            try
            {
                ChucVuDoan cva = new ChucVuDoan()
                {
                    maChucVu = cv.MaChucVu,
                    tenChucVu = cv.TenChucVu,
                    diemCong = cv.DiemCong
                };
                db.ChucVuDoans.InsertOnSubmit(cva);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm xóa chucVu
        public bool XoaChucVu(string maCV)
        {
            try
            {
                var sv = db.SinhVienChucVuDoans.Where(x => x.maChucVu == maCV).FirstOrDefault();
                db.SinhVienChucVuDoans.DeleteOnSubmit(sv);
                var cv = db.ChucVuDoans.Where(x => x.maChucVu == maCV ).FirstOrDefault();
                db.ChucVuDoans.DeleteOnSubmit(cv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm sửa chức vụ
        public bool SuaChucVu(ChucVuDoan_ET c)
        {
            try
            {
                var cv = db.ChucVuDoans.Where(x => x.maChucVu == c.MaChucVu).FirstOrDefault();
                if (cv != null)
                {
                    cv.tenChucVu = c.TenChucVu;
                    cv.diemCong = c.DiemCong;
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
    }
}
