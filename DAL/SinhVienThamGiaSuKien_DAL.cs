using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVienThamGiaSuKien_DAL
    {
        QLSVDataContext db = new QLSVDataContext();
        public IQueryable LayDSSinhVienThamGiaSK()
        {
            var svtsk = from el in db.SinhVienThamGiaSuKiens
                        join sv in db.SinhViens on el.maSV equals sv.maSv
                        join sk in db.SuKiens on el.maSK equals sk.maSK
                        select new
                        {
                            el.maSV,
                            sv.hoTen,
                            el.maSK,
                            sk.tenSK,
                            sk.thoiGianBatDau,
                            sk.thoiGianKetThuc
                        };
            return svtsk;
        }
        public IQueryable LayDSSinhVienThamGia1SK(string maSK)
        {
            var svtsk = from el in db.SinhVienThamGiaSuKiens
                        join sv in db.SinhViens on el.maSV equals sv.maSv
                        join sk in db.SuKiens on el.maSK equals sk.maSK
                        where el.maSK == maSK
                        select new
                        {
                            el.maSV,
                            sv.hoTen,
                            el.maSK,
                            sk.tenSK,
                            sk.thoiGianBatDau,
                            sk.thoiGianKetThuc
                        };
            return svtsk;
        }
        public IQueryable LayDSSuKien()
        {
            var ska = from sk in db.SuKiens
                      select sk;
            return ska;
        }
        // hàm kiểm tra trùng tên sinh viên tham gia
        public bool KiemTraTrungMa(string sv, string sk)
        {
            return db.SinhVienThamGiaSuKiens.Any(n => n.maSV == sv && n.maSK == sk);
        }

        //Hàm thêm sinh viên tham gia sự kiện
        public bool ThemSinhVienThamGia(SinhVienThamGiaSuKien_ET k)
        {
            try
            {
                SinhVienThamGiaSuKien s = new SinhVienThamGiaSuKien()
                {
                    maSV = k.MaSV,
                    maSK = k.MaSK
                };
                db.SinhVienThamGiaSuKiens.InsertOnSubmit(s);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm xóa sinh viên tham gia sự kiện
        public bool XoaSinhVienThamGia(string s, string v)
        {
            try
            {
                var k = db.SinhVienThamGiaSuKiens.Where(x => x.maSV == s && x.maSK == v).FirstOrDefault();
                db.SinhVienThamGiaSuKiens.DeleteOnSubmit(k);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm sửa sinh viên tham gia sự kiện
        public bool SuaSinhVienThamGiaTheoSK(string sk)
        {
            try
            {
                var kh = db.SinhVienThamGiaSuKiens.Where(x => x.maSK == sk).FirstOrDefault();
                if (kh != null)
                {
                    db.SinhVienThamGiaSuKiens.DeleteOnSubmit(kh);
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
        // hàm kiểm tra trùng tên sự kiện tham gia
        public bool KiemTraTrungMaSK(string sk)
        {
            return db.SinhVienThamGiaSuKiens.Any(n => n.maSK == sk);
        }
        //Hàm sửa sinh viên tham gia SV
        public bool SuaSinhVienThamGiaTheoSV(string sv)
        {
            try
            {
                var kh = db.SinhVienThamGiaSuKiens.Where(x => x.maSV == sv).FirstOrDefault();
                if (kh != null)
                {
                    db.SinhVienThamGiaSuKiens.DeleteOnSubmit(kh);
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
        // hàm kiểm tra trùng tên sinh viên tham gia
        public bool KiemTraTrungMaSV(string sv)
        {
            return db.SinhVienThamGiaSuKiens.Any(n => n.maSV == sv);
        }
        public bool KiemTraTrungMaSVa(string sv)
        {
            return db.SinhViens.Any(n => n.maSv == sv);
        }
    }
}
