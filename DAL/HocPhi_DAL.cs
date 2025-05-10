using ET;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocPhi_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LayDSHocPhi()
        {
            var hocPhi = from hp in db.HocPhis
                         select new
                         {
                             hp.maHocPhi,
                             hp.maSv,
                             hp.maHocPhan,
                             hp.maNv,
                             hp.soTinChi,
                             hp.donGia,
                             hp.tongTien,
                             hp.ngayDongHocPhi,
                             hp.trangThai
                         };
            return hocPhi;
        }

        public bool KT_hocPhi(string maSV,string maHocPhan)
        {
            bool kt = false;
            var hocPhi = db.HocPhis.Where(x => x.maSv == maSV && x.maHocPhan == maHocPhan).FirstOrDefault();
            if (hocPhi != null)
            {
                return kt = true;
            }
            else
                return kt;

        }
        public bool ThemHocPhi(HocPhi_ET hpET)
        {
            bool kt = false;
            try
            {
                var tonTai = db.HocPhis
                               .Any(x=>x.maHocPhi == hpET.MaHocPhi);

                if (tonTai)
                {
                    return false;
                }
                HocPhi hocPhi = new HocPhi()
                {
                    maHocPhi = hpET.MaHocPhi,
                    maSv = hpET.MaSv,
                    maHocPhan = hpET.MaHocPhan,
                    maNv = hpET.MaNhanVien,
                    soTinChi = hpET.SoTinChi,
                    donGia = hpET.DonGia,
                    ngayDongHocPhi = hpET.NgayDongHocPhi,
                    trangThai = hpET.TrangThai
                };
                db.HocPhis.InsertOnSubmit(hocPhi);
                return kt = true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt;
        }
        public bool XoaHocPhi(string maHocPhi)
        {
            bool kt = false;
            try
            {
                var hocPhi = db.HocPhis.FirstOrDefault(x => x.maHocPhi == maHocPhi);
                foreach(var i in db.HocPhis)
                {
                    db.HocPhis.DeleteOnSubmit(hocPhi);
                    return kt = true;
                }
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt;
        }
        public bool SuaHocPhi(HocPhi_ET hpET)
        {
            bool kt = false;
            try
            {
                var hocPhi = db.HocPhis.FirstOrDefault(x => x.maHocPhi == hpET.MaHocPhi);
                if(hocPhi != null)
                {
                    hocPhi.maSv = hpET.MaSv;
                    hocPhi.maHocPhan = hpET.MaHocPhan;
                    hocPhi.maNv = hpET.MaNhanVien;
                    hocPhi.soTinChi = hpET.SoTinChi;
                    // hocPhi.donGia = hpET.DonGia;
                    // hocPhi.tongTien = hpET.TongTien;
                    hocPhi.ngayDongHocPhi = hpET.NgayDongHocPhi;
                    hocPhi.trangThai = hpET.TrangThai;
                    db.SubmitChanges();
                    return kt = true;
                }

                
            }
            finally
            {
                
            }
            return kt;
        }
        public IQueryable TimKiemHocPhiTheoMaSV(string maSV)
        {
            var ma = from hocPhi in db.HocPhis
                     where (hocPhi.maSv == maSV)
                     select new 
                     {
                         hocPhi.maHocPhi,
                         hocPhi.maSv,
                         hocPhi.maHocPhan,
                         hocPhi.soTinChi,
                         hocPhi.donGia,
                         hocPhi.tongTien,
                         hocPhi.trangThai
                     };
            return ma;
            
        }


        public int LaySoTinChi(string maHp)
        {
            var soTinChi = (from tc in db.HocPhans
                            where tc.maHocPhan == maHp
                            select tc.soTinChi).FirstOrDefault(); 

            return soTinChi;
        }
        public IQueryable LayDSMaHocPhan()
        {
            var hocPhan = from hp in db.HocPhans
                          select hp;
            return hocPhan;
        }

    }
}
