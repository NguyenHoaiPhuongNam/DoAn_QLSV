using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuKien_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LayDSSuKien()
        {
            var suKien = from sk in db.SuKiens
                         select new
                         {
                             sk.maSK,
                             sk.tenSK,
                             sk.diemcong,
                             sk.thoiGianBatDau,
                             sk.thoiGianKetThuc
                         };
            return suKien;
        }

        public bool ThemSuKien(SuKien_ET skET)
        {
            try
            {
                var tonTai = db.SuKiens.Any(x => x.maSK == skET.MaSK);
                if (tonTai) return false;

                SuKien sk = new SuKien()
                {
                    maSK = skET.MaSK,
                    tenSK = skET.TenSK,
                    diemcong = skET.DiemCong,
                    thoiGianBatDau = skET.ThoiGianBatDau,
                    thoiGianKetThuc = skET.ThoiGianKetThuc
                };

                db.SuKiens.InsertOnSubmit(sk);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaSuKien(string maSK)
        {
            try
            {
                var sk = db.SuKiens.FirstOrDefault(s => s.maSK == maSK);
                if (sk != null)
                {
                    db.SuKiens.DeleteOnSubmit(sk);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }

        public bool SuaSuKien(SuKien_ET skET)
        {
            try
            {
                var sk = db.SuKiens.FirstOrDefault(s => s.maSK == skET.MaSK);
                if (sk != null)
                {
                    sk.tenSK = skET.TenSK;
                    sk.diemcong = skET.DiemCong;
                    sk.thoiGianBatDau = skET.ThoiGianBatDau;
                    sk.thoiGianKetThuc = skET.ThoiGianKetThuc;

                    db.SubmitChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }

    }
}
