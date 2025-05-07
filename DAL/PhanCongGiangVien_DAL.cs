using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DAL
{
    public class PhanCongGiangVien_DAL
    {
        QLSVDataContext db = new QLSVDataContext();
        public IQueryable LayDSPhanCong()
        {
            var pc = from el in db.PhanCongGiangViens
                     join gv in db.GiangViens on el.maGiangVien equals gv.maGiangVien
                     join hp in db.HocPhans on el.maHocPhan equals hp.maHocPhan
                     select new
                     {
                         el.maHocPhan,
                         hp.tenHocPhan,
                         gv.maGiangVien,
                         gv.hoTen
                     };
            return pc;
        }
        public IQueryable LayDSMonHoc()
        {
            var mh = from el in db.HocPhans
                     select el;
            return mh;
        }
        public bool KiemTraMaGv(string maGv)
        {
            return db.GiangViens.Any(pc => pc.maGiangVien == maGv);
        }
        public bool KiemTraMaHP(string maHP)
        {
            return db.HocPhans.Any(pc => pc.maHocPhan == maHP);
        }
        public bool ThemPCGV(PhanCongGiangVien_ET pca)
        {
            try
            {
                var tonTai = db.PhanCongGiangViens.Any(pc => pc.maHocPhan == pca.MaHocPhan && pc.maGiangVien == pca.MaGV);
                if (tonTai)
                {
                    return false;
                }

                PhanCongGiangVien pcgv = new PhanCongGiangVien
                {
                    maGiangVien = pca.MaGV,
                    maHocPhan = pca.MaHocPhan
                };
                db.PhanCongGiangViens.InsertOnSubmit(pcgv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaPCGV(string maHocPhan, string maGiangVien)
        {
            try
            {
                var pcgv = db.PhanCongGiangViens.SingleOrDefault(pc => pc.maHocPhan == maHocPhan && pc.maGiangVien == maGiangVien);
                if (pcgv == null)
                {
                    return false;
                }

                db.PhanCongGiangViens.DeleteOnSubmit(pcgv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KiemTraTrungMa(string maHP, string maGV)
        {
            return db.PhanCongGiangViens.Any(p => p.maHocPhan == maHP && p.maGiangVien == maGV);
        }

        public IQueryable LayDSPhanCong1GV(string maGv)
        {
            var pc = from el in db.PhanCongGiangViens
                     join gv in db.GiangViens on el.maGiangVien equals gv.maGiangVien
                     join mh in db.HocPhans on el.maHocPhan equals mh.maHocPhan
                     where el.maGiangVien == maGv
                     select new
                     {
                         el.maHocPhan,
                         mh.tenHocPhan
                     };
            return pc;
        }
    }
}
