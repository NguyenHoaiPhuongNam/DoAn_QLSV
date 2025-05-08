using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class HocPhan_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LayDSHocPhan()
        {
            var hocPhan = from hp in db.HocPhans
                          select new
                          {
                              hp.maHocPhan,
                              hp.tenHocPhan,
                              hp.maHocKy,
                              hp.loaiHP,
                              hp.soTinChi
                          };
            return hocPhan;
        }
        public IQueryable LayDSHocKy()
        {
            var hocKy = from hk in db.HocKies
                        select hk;
            return hocKy;
        }
        public bool ThemHocPhan(HocPhan_ET hpET)
        {
            bool kt = false;
            try
            {
                HocPhan hocPhan = new HocPhan()
                {
                    maHocPhan = hpET.MaHocPhan,
                    tenHocPhan = hpET.TenHocPhan,
                    maHocKy = hpET.MaHocKy,
                    loaiHP = hpET.LoaiHP,
                    soTinChi = hpET.SoTinChi
                };
                db.HocPhans.InsertOnSubmit(hocPhan);
                return kt = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt;
        }

        public bool XoaHocPhan(string maHP)
        {
            bool kt = false;
            try
            {
                var hp = db.HocPhans.Where(x => x.maHocPhan == maHP).FirstOrDefault();
                
                    db.HocPhans.DeleteOnSubmit(hp);
                    return kt = true;
                
                
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt;
        }
        public bool SuaHocPhan(HocPhan_ET hpET)
        {
            bool kt = false;
            try
            {
                var hocPhan = db.HocPhans.Where(x => x.maHocPhan == hpET.MaHocPhan).FirstOrDefault();
                if(hocPhan != null)
                {
                    hocPhan.tenHocPhan = hpET.TenHocPhan;
                    hocPhan.maHocKy = hpET.MaHocKy;
                    hocPhan.loaiHP = hpET.LoaiHP;
                    hocPhan.soTinChi = hpET.SoTinChi;
                    db.SubmitChanges();
                    return kt = true;
                }
            }
            finally
            {

            }
            return kt;
        }

        public IQueryable TimKiemHocPhan(string maHocPhan)
        {
            var hocPhan = from hp in db.HocPhans
                          where (hp.maHocPhan == maHocPhan)
                          select new
                          {
                              hp.maHocPhan,
                              hp.tenHocPhan,
                              hp.maHocKy,
                              hp.loaiHP,
                              hp.soTinChi
                          }; 
            return hocPhan;
        }
    }
}
