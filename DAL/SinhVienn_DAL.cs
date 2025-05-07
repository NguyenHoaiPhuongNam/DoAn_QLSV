using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVienn_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LDSSV()
        {
            var sinhvien = from sv in db.SinhViens
                           select new
                           {
                               maSv = sv.maSv,
                               hoTen = sv.hoTen,
                               ngaySinh = sv.ngaySinh,
                               gioiTinh = sv.gioiTinh,
                               email = sv.email,
                               sdt = sv.sdt,
                               diaChi = sv.diaChi,
                               lophoc = sv.lophoc,
                               account = sv.account
                           };
            return sinhvien;
        }


        public IQueryable LayDSLopHoc()
        {
            return db.LopHocs.Select(lh => new
            {
                lh.maLop,
                TenLop = lh.tenLop + " (" + lh.maLop + ")"
            });
        }

        public IQueryable LayDSAccount()
        {
            return db.Accounts.Select(acc => new
            {
                acc.maAccount,
                TenAccount = acc.username
            });
        }

        public bool ThemSinhVien(SinhVienn_ET svET)
        {
            try
            {
                var sv = new SinhVien
                {
                    maSv = svET.MaSV,
                    hoTen = svET.HoTen,
                    ngaySinh = svET.NgaySinh,
                    gioiTinh = svET.GioiTinh,
                    email = svET.Email,
                    sdt = svET.Sdt,
                    diaChi = svET.DiaChi,
                    lophoc = svET.LopHoc,
                    account = svET.Account
                };

                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaSinhVien(SinhVienn_ET svET)
        {
            try
            {
                var sv = db.SinhViens.FirstOrDefault(x => x.maSv == svET.MaSV);
                if (sv == null) return false;

                sv.hoTen = svET.HoTen;
                sv.ngaySinh = svET.NgaySinh;
                sv.gioiTinh = svET.GioiTinh;
                sv.email = svET.Email;
                sv.sdt = svET.Sdt;
                sv.diaChi = svET.DiaChi;
                sv.lophoc = svET.LopHoc;
                sv.account = svET.Account;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaSinhVien(string maSv)
        {
            try
            {
                var sv = db.SinhViens.FirstOrDefault(x => x.maSv == maSv);
                if (sv == null) return false;

                db.SinhViens.DeleteOnSubmit(sv);
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
