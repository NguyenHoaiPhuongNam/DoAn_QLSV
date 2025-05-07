using System;
using System.Linq;
using ET;

namespace DAL
{
    public class HocBong_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LDSHB()
        {
            var hocbong = from hb in db.HocBongs
                           join sv in db.SinhViens on hb.maSV equals sv.maSv
                           select new
                           {
                               maHB = hb.maHB,
                               maSV = hb.maSV,
                               hoTenSV = sv.hoTen,
                               xepLoaiHB = hb.xepLoaiHB,
                               ghiChu = hb.ghiChu
                           };
            return hocbong;
        }

        public IQueryable LayDSSV()
        {
            var dssv = from sv in db.SinhViens
                      select new { sv.maSv, TenSV = sv.hoTen + " (" + sv.maSv + ")" };
            return dssv;
        }

        public string TaoMaHB()
        {
            string maHB;
            Random rd = new Random();
            do
            {
                maHB = "HB" + rd.Next(10000, 99999);
            } while (db.HocBongs.Count(x => x.maHB == maHB) > 0);
            
            return maHB;
        }

        public bool ThemHocBong(HocBong_ET hbET)
        {
            try
            {
                HocBong hb = new HocBong
                {
                    maHB = hbET.MaHB,
                    maSV = hbET.MaSV,
                    xepLoaiHB = hbET.XepLoaiHB,
                    ghiChu = hbET.GhiChu
                };
                db.HocBongs.InsertOnSubmit(hb);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaHocBong(HocBong_ET hbET)
        {
            try
            {
                var hb = db.HocBongs.FirstOrDefault(x => x.maHB == hbET.MaHB);
                if (hb == null) return false;

                hb.maSV = hbET.MaSV;
                hb.xepLoaiHB = hbET.XepLoaiHB;
                hb.ghiChu = hbET.GhiChu;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaHocBong(string maHB)
        {
            try
            {
                var hb = db.HocBongs.FirstOrDefault(x => x.maHB == maHB);
                if (hb == null) return false;

                db.HocBongs.DeleteOnSubmit(hb);
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
