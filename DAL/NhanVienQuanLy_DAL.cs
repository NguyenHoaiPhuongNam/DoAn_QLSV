using System;
using System.Linq;
using ET;

namespace DAL
{
    public class NhanVienQuanLy_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LDSNV()
        {
            var nvql = from nv in db.NhanVienQuanLies
                      select new
                      {
                          maNhanVien = nv.maNhanVien,
                          hoTen = nv.hoTen,
                          ngaySinh = nv.ngaySinh,
                          gioiTinh = nv.gioiTinh,
                          email = nv.email,
                          sdt = nv.sdt,
                          diaChi = nv.diaChi,
                          maKhoa = nv.maKhoa,
                          account = nv.account
                      };
            return nvql;
        }

        public IQueryable LayDSKhoa()
        {
            var dskhoa = from k in db.Khoas
                        select new { k.maKhoa, TenKhoa = k.tenKhoa + " (" + k.maKhoa + ")" };
            return dskhoa;
        }

        public IQueryable LayDSAccount()
        {
            var dsaccount = from acc in db.Accounts
                          select new { acc.maAccount, TenAccount = acc.username + " (" + acc.maAccount + ")" };
            return dsaccount;
        }

        public bool ThemNhanVien(NhanVienQuanLy_ET nvET)
        {
            try
            {
                NhanVienQuanLy nv = new NhanVienQuanLy
                {
                    maNhanVien = nvET.MaNhanVien,
                    hoTen = nvET.HoTen,
                    ngaySinh = nvET.NgaySinh,
                    gioiTinh = nvET.GioiTinh,
                    email = nvET.Email,
                    sdt = nvET.Sdt,
                    diaChi = nvET.DiaChi,
                    maKhoa = nvET.MaKhoa,
                    account = nvET.Account
                };
                db.NhanVienQuanLies.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaNhanVien(NhanVienQuanLy_ET nvET)
        {
            try
            {
                var nv = db.NhanVienQuanLies.FirstOrDefault(x => x.maNhanVien == nvET.MaNhanVien);
                if (nv == null) return false;

                nv.hoTen = nvET.HoTen;
                nv.ngaySinh = nvET.NgaySinh;
                nv.gioiTinh = nvET.GioiTinh;
                nv.email = nvET.Email;
                nv.sdt = nvET.Sdt;
                nv.diaChi = nvET.DiaChi;
                nv.maKhoa = nvET.MaKhoa;
                nv.account = nvET.Account;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaNhanVien(string maNV)
        {
            try
            {
                var nv = db.NhanVienQuanLies.FirstOrDefault(x => x.maNhanVien == maNV);
                if (nv == null) return false;

                db.NhanVienQuanLies.DeleteOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
