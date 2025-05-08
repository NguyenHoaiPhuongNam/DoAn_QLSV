using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class HocKy_DAL
    {
        QLSVDataContext db = new QLSVDataContext();
        

        public IQueryable LayDSHocKy()
        {
            var hocKy = from hk in db.HocKies
                        select hk;
            return hocKy;
        }

        public bool ThemHocKy(HocKy_ET hkET)
        {
            bool kt = false;
            try
            {
                var tonTai = db.HocKies
                              .Any(x => x.maHocKy == hkET.MaHocKy);

                if (tonTai)
                {
                    return kt;
                }
                HocKy hocKy = new HocKy()
                {
                    maHocKy = hkET.MaHocKy,
                    tenHocKy = hkET.TenHocKy
                };
                db.HocKies.InsertOnSubmit(hocKy);
                return kt = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt;
        }
        public bool KT_MaKH(string maHK)
        {
            var hk = db.HocKies.Where(x => x.maHocKy == maHK).FirstOrDefault();
            if (hk == null)
            {
                return true;
            }
            else
                return false;
        }
        public bool XoaHocKy(string maHocKy)
        {
            bool kt = false;
            try
            {
                var ma = db.HocKies.Where(x => x.maHocKy == maHocKy).FirstOrDefault();
                foreach(var i in db.HocKies)
                {
                    db.HocKies.DeleteOnSubmit(ma);

                    return kt = true;
                }
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt; 
        }

        public bool SuaHocKy(HocKy_ET hkET)
        {
            bool kt = false;
            try
            {
                var maHocKy = db.HocKies.Where(x => x.maHocKy == hkET.MaHocKy).FirstOrDefault();
                if (maHocKy != null)
                {
                    maHocKy.tenHocKy = hkET.TenHocKy;
                    db.SubmitChanges();
                    return kt = true;
                }
            }
            finally
            {

            }
            return kt;
            
        }
        public IQueryable TimKiemHocKyTheoMa(string maHocKy)
        {
            var ma = from hocKy in db.HocKies
                     where (hocKy.maHocKy == maHocKy)
                     select hocKy;
            return ma;
        }
    }


}
