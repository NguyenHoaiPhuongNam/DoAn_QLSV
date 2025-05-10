using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuThuDoanPhi_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LayDSPhieuThuDoanPhi()
        {
            var phieuThuDoanPhi = from ptdp in db.PhieuThuDoanPhis
                                  select new 
                                  {
                                    ptdp.maPhieu,
                                    ptdp.maSVThuPhi,
                                    ptdp.maSVNopPhi,
                                    ptdp.maPhi,
                                    ptdp.ngayThu
                                  
                                  };
            return phieuThuDoanPhi;
        }


        public IQueryable LayDSPhiDoan()
        {
            var phiDoan = from pd in db.PhiDoans
                          select pd;
            return phiDoan;
        }
        public bool ThemPhieuThuDoanPhi(PhieuThuDoanPhi_ET phieuThuDoanPhi_ET)
        {
            try
            {
                var tonTai = db.PhieuThuDoanPhis.Any(p => p.maPhieu == phieuThuDoanPhi_ET.MaPhieu);
                if (tonTai)
                {
                    return false;
                }

                PhieuThuDoanPhi phieuThuDoanPhi = new PhieuThuDoanPhi()
                {
                    maPhieu = phieuThuDoanPhi_ET.MaPhieu,
                    maSVThuPhi = phieuThuDoanPhi_ET.MaSVThuPhi,
                    maSVNopPhi = phieuThuDoanPhi_ET.MaSVNopPhi,
                    maPhi = phieuThuDoanPhi_ET.MaPhi,
                    ngayThu = phieuThuDoanPhi_ET.NgayThu
                };

                db.PhieuThuDoanPhis.InsertOnSubmit(phieuThuDoanPhi);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
            
                return false;
            }
        }

        public bool XoaPhieuThuDoanPhi(string maPhieu)
        {
            try
            {
                var phieuThuDoanPhi = db.PhieuThuDoanPhis.Where(x => x.maPhieu == maPhieu).FirstOrDefault();
                if(phieuThuDoanPhi != null)
                {
                    db.PhieuThuDoanPhis.DeleteOnSubmit(phieuThuDoanPhi);
                    db.SubmitChanges();
                    return true;
                }
            }
            finally
            {

            }
            return false;
        }
        public bool SuaPhieuThuDoanPhi(PhieuThuDoanPhi_ET phieuThuDoanPhi_ET)
        {
            try
            {
                var phieu = db.PhieuThuDoanPhis.SingleOrDefault(p => p.maPhieu == phieuThuDoanPhi_ET.MaPhieu);
                if (phieu != null)
                {
                    phieu.maSVThuPhi = phieuThuDoanPhi_ET.MaSVThuPhi;
                    phieu.maSVNopPhi = phieuThuDoanPhi_ET.MaSVNopPhi;
                    phieu.maPhi = phieuThuDoanPhi_ET.MaPhi;
                    phieu.ngayThu = phieuThuDoanPhi_ET.NgayThu;

                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
            }

            return false;
        }

    }
}
