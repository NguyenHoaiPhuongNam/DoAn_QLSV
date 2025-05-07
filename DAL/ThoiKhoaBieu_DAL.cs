using System;
using System.Linq;
using ET;

namespace DAL
{
    public class ThoiKhoaBieu_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LDSTKB()
        {
            var tkb = from t in db.ThoiKhoaBieus
                      select new
                      {
                          maTKB = t.maTKB,
                          maHocPhan = t.maHocPhan,
                          ngayHoc = t.ngayHoc,
                          gioBatDau = t.gioBatDau,
                          gioKetThuc = t.gioKetThuc,
                          tietBatDau = t.tietBatDau,
                          tietKetThuc = t.tietKetThuc,
                          phong = t.phong
                      };
            return tkb;
        }

        public IQueryable LayDSHocPhan()
        {
            var dshp = from hp in db.HocPhans
                       select new { hp.maHocPhan, TenHP = hp.tenHocPhan + " (" + hp.maHocPhan + ")" };
            return dshp;
        }

        public bool ThemTKB(ThoiKhoaBieu_ET tkbET)
        {
            try
            {
                ThoiKhoaBieu tkb = new ThoiKhoaBieu
                {
                    maTKB = tkbET.MaTKB,
                    maHocPhan = tkbET.MaHocPhan,
                    ngayHoc = tkbET.NgayHoc,
                    gioBatDau = tkbET.GioBatDau,
                    gioKetThuc = tkbET.GioKetThuc,
                    tietBatDau = tkbET.TietBatDau,
                    tietKetThuc = tkbET.TietKetThuc,
                    phong = tkbET.Phong
                };
                db.ThoiKhoaBieus.InsertOnSubmit(tkb);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaTKB(ThoiKhoaBieu_ET tkbET)
        {
            try
            {
                var tkb = db.ThoiKhoaBieus.FirstOrDefault(x => x.maTKB == tkbET.MaTKB);
                if (tkb == null) return false;

                tkb.maHocPhan = tkbET.MaHocPhan;
                tkb.ngayHoc = tkbET.NgayHoc;
                tkb.gioBatDau = tkbET.GioBatDau;
                tkb.gioKetThuc = tkbET.GioKetThuc;
                tkb.tietBatDau = tkbET.TietBatDau;
                tkb.tietKetThuc = tkbET.TietKetThuc;
                tkb.phong = tkbET.Phong;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaTKB(string maTKB)
        {
            try
            {
                var tkb = db.ThoiKhoaBieus.FirstOrDefault(x => x.maTKB == maTKB);
                if (tkb == null) return false;

                db.ThoiKhoaBieus.DeleteOnSubmit(tkb);
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
