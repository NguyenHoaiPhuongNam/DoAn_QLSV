using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhiDoan_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LayDSPhiDoan()
        {
            var phiDoan = from pd in db.PhiDoans
                          select new 
                          {
                            pd.maPhi,
                            pd.soTien,
                            pd.maHocKy,
                            pd.ngayBatDau,
                            pd.ngayKetThuc
                          };
            return phiDoan;
        }

        public IQueryable LayDSHocKy()
        {
            var hocKy = from hk in db.HocKies
                        select hk;
            return hocKy;
        }


        public bool ThemPhiDoan(PhiDoan_ET pdET)
        {
            bool kt = false;
            try
            {
                PhiDoan phiDoan = new PhiDoan()
                {
                    maPhi = pdET.MaPhi,
                    soTien = pdET.SoTien,
                    maHocKy = pdET.MaHocKy,
                    ngayBatDau = pdET.NgayBatDau,
                    ngayKetThuc = pdET.NgayKetThuc
                };

                db.PhiDoans.InsertOnSubmit(phiDoan);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt;
        }

        public bool kT_TonTai_MaPhi_BenBangKhac(string maPhi)
        {
            var tonTai = db.PhieuThuDoanPhis.Where(x => x.maPhi == maPhi).FirstOrDefault();
            if(tonTai != null)
            {
                return true;
            }
            return false;
        }


        public bool XoaPhiDoan(string maPhi)
        {
            var phiDoan = db.PhiDoans.Where(x => x.maPhi == maPhi).FirstOrDefault();
            if(phiDoan != null)
            {
                db.PhiDoans.DeleteOnSubmit(phiDoan);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool SuaPhiDoan(PhiDoan_ET phiDoan_ET)
        {
            var phiDoan = db.PhiDoans.Where(x => x.maPhi == phiDoan_ET.MaPhi).FirstOrDefault();
            if (phiDoan != null)
            {
                phiDoan.soTien = phiDoan_ET.SoTien;
                phiDoan.maHocKy = phiDoan_ET.MaHocKy;
                phiDoan.ngayBatDau = phiDoan_ET.NgayBatDau;
                phiDoan.ngayKetThuc = phiDoan_ET.NgayKetThuc;

                db.SubmitChanges();
                return true;
            }
            return false;
        }


    }
}
