using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DiemRenLuyen_DAL
    {
        QLSVDataContext db = new QLSVDataContext();
        public IQueryable LayDSDiemRenLuyen()
        {
            var dsDiem = from diem in db.DiemRenLuyens
                         select new 
                         {
                            diem.maSv,
                            diem.maHocKy,
                            diem.diemToiDa,
                            diem.diemDatDuoc
                         };
            return dsDiem;
        }
        public bool ThemDiemRenLuyen(DiemRenLuyen_ET drlET)
        {
            try
            {
                var tonTai = db.DiemRenLuyens
                               .Any(d => d.maSv == drlET.MaSv && d.maHocKy == drlET.MaHocKy);

                if (tonTai)
                {
                    return false; 
                }

                DiemRenLuyen moi = new DiemRenLuyen()
                {
                    maSv = drlET.MaSv,
                    maHocKy = drlET.MaHocKy,
                    diemToiDa = drlET.DiemToiDa,
                    diemDatDuoc = drlET.DiemDatDuoc
                };

                db.DiemRenLuyens.InsertOnSubmit(moi);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool KT_maSV_maHk_TonTai(string maSV, string maHK)
        {
            bool kt = false;
            var drl = db.DiemRenLuyens.Where(x => x.maSv == maSV && x.maHocKy == maHK).FirstOrDefault();
            if (drl == null)
            {
                return true;
            }
            else
                return kt;
        }
        public IQueryable LayHocKy()
        {
            var hocKy = from hk in db.HocKies
                        select hk;
            return hocKy;
        }
        public IQueryable TimKiemDRLTheoMaSV(string maSV)
        {
            var sinhVien = from sv in db.DiemRenLuyens
                           where sv.maSv == maSV
                           select new
                           {
                               sv.maSv,
                               sv.maHocKy,
                               sv.diemToiDa,
                               sv.diemDatDuoc
                           };
            return sinhVien;

           
        }

        public bool XoaDiemRenLuyen(string maSv, string maHocKy)
        {
            bool kt = false;
            try
            {
                var diemRenLuyen = db.DiemRenLuyens
                             .FirstOrDefault(drl => drl.maSv == maSv && drl.maHocKy == maHocKy);
                if(diemRenLuyen != null)
                {
                    db.DiemRenLuyens.DeleteOnSubmit(diemRenLuyen);
                    return kt = true;
                }
            }
            finally
            {
                db.SubmitChanges();
            }
            return kt;
        }


        public bool SuaDrl(DiemRenLuyen_ET drlET)
        {
            bool kt = false;
            try
            {
                var diemRenLuyen = db.DiemRenLuyens
                             .FirstOrDefault(drl => drl.maSv == drlET.MaSv && drl.maHocKy == drlET.MaHocKy);
                if (diemRenLuyen != null)
                {
                    //diemRenLuyen.maSv = drlET.MaSv;
                    //diemRenLuyen.maHocKy = drlET.MaHocKy;
                   // diemRenLuyen.diem = drlET.Diem; 
                    db.SubmitChanges();
                    return kt = true;

                }
            }
            finally
            {

            }
            return kt;
        }
    }
}
