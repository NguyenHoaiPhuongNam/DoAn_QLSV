using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Khoa_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        //Hàm lấy danh sách khoa
        public IQueryable LayDSKhoa()
        {
            var khoa = from k in db.Khoas
                       select k;
            return khoa;
        }

        //Hàm kiểm tra mã khoa 
        public bool KiemTraTrungMaKhoa(string maKhoa)
        {
            return db.Khoas.Any(n => n.maKhoa == maKhoa);
        }

        //Hàm kiểm tra tên Khoa
        public bool KiemTraTrungTenKhoa(string tenKhoa)
        {
            return db.Khoas.Any(n => n.tenKhoa == tenKhoa);
        }

        //Hàm thêm Khoa
        public bool ThemKhoa(Khoa_ET k)
        {
            try
            {
                Khoa khoa = new Khoa()
                {
                    maKhoa = k.MaKhoa,
                    tenKhoa = k.TenKhoa
                };
                db.Khoas.InsertOnSubmit(khoa);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm xóa khoa
        public bool XoaKhoa(string makhoa)
        {
            try
            {
                // Gán null cho các giảng viên thuộc khoa
                var giangViens = db.GiangViens.Where(gv => gv.maKhoa == makhoa).ToList();
                foreach (var gv in giangViens)
                {
                    gv.maKhoa = null;
                }

                // Gán null cho các ngành thuộc khoa
                var nganhs = db.Nganhs.Where(ng => ng.maKhoa == makhoa).ToList();
                foreach (var ng in nganhs)
                {
                    ng.maKhoa = null;
                }

                // Xóa khoa
                var k = db.Khoas.FirstOrDefault(x => x.maKhoa == makhoa);
                if (k != null)
                {
                    db.Khoas.DeleteOnSubmit(k);
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

        //Hàm sửa khoa
        // Hàm sửa khoa – kiểm tra trùng tên với khoa khác
        public bool SuaKhoa(Khoa_ET k)
        {
            try
            {
                var kh = db.Khoas.FirstOrDefault(x => x.maKhoa == k.MaKhoa);
                if (kh != null)
                {
                    // Kiểm tra xem tên khoa mới có bị trùng với khoa khác không
                    bool tenTrung = db.Khoas.Any(x => x.tenKhoa == k.TenKhoa && x.maKhoa != k.MaKhoa);
                    if (tenTrung)
                    {
                        return false;
                    }

                    // Cho phép cập nhật nếu không bị trùng tên
                    kh.tenKhoa = k.TenKhoa;
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
