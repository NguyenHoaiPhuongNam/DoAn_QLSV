using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TieuChiDanhGia_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LayDsTieuChiDanhGia()
        {
            var tieuChi = from tc in db.TieuChiDanhGias
                          select tc;
            return tieuChi;
        }
        public bool ThemTieuChiDanhGia(TieuChiDanhGia_ET tcdgET)
        {
            bool kt = false;
            try
            {
                TieuChiDanhGia tieuChi = new TieuChiDanhGia()
                {
                    maTieuChi = tcdgET.MaTieuChi,
                    tenTieuChi = tcdgET.TenTieuChi,
                    diemToiDa = tcdgET.DiemToiDa
                };
                db.TieuChiDanhGias.InsertOnSubmit(tieuChi);
                return kt = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt;
            
        }
        public bool XoaTieuChiDanhGia(string maTieuChi)
        {
            try
            {
                var tieuChi = db.TieuChiDanhGias.Where(x => x.maTieuChi == maTieuChi).FirstOrDefault();
                if (tieuChi != null)
                {
                    db.TieuChiDanhGias.DeleteOnSubmit(tieuChi);
                    return true;
                }
                else
                    return false;
            }
            finally
            {
                db.SubmitChanges();
            }


        }
        public bool SuaTieuChi(TieuChiDanhGia_ET tcdgET)
        {
            try
            {
                var tieuChi = db.TieuChiDanhGias.Where(x => x.maTieuChi == tcdgET.MaTieuChi).FirstOrDefault();
                if (tieuChi != null)
                {
                    tieuChi.tenTieuChi = tcdgET.TenTieuChi;
                    tieuChi.diemToiDa = tcdgET.DiemToiDa;
                    return true;
                }
                else
                    return false;
            }
            finally
            {
                db.SubmitChanges();
            }

        }
        public IQueryable TimKiemTieuChi(string maTieuChi)
        {
            var tieuChi = from tc in db.TieuChiDanhGias
                          where (tc.maTieuChi == maTieuChi)
                          select tc;
            return tieuChi;
        }
    }
}
