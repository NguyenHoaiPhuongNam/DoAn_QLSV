using System;
using System.Linq;
using ET;

namespace DAL
{
    public class TotNghiep_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LDSTN()
        {
            var totnghiep = from tn in db.TotNghieps
                           select new
                           {
                               maSV = tn.maSV,
                               ngayTotNghiep = tn.ngayTotNghiep,
                               xepLoai = tn.xepLoai,
                               tongSoTinChiDatDuoc = tn.tongSoTinChiDatDuoc,
                               tongSoTinChiYeuCau = tn.tongSoTinChiYeuCau
                           };
            return totnghiep;
        }

        public IQueryable LayDSSV()
        {
            var dssv = from sv in db.SinhViens
                      where !(from tn in db.TotNghieps
                             select tn.maSV).Contains(sv.maSv)
                      select new { sv.maSv, TenSV = sv.hoTen + " (" + sv.maSv + ")" };
            return dssv;
        }

        public bool ThemTotNghiep(TotNghiep_ET tnET)
        {
            try
            {
                TotNghiep tn = new TotNghiep
                {
                    maSV = tnET.MaSV,
                    ngayTotNghiep = tnET.NgayTotNghiep,
                    xepLoai = tnET.XepLoai,
                    tongSoTinChiDatDuoc = tnET.TongSoTinChiDatDuoc,
                    tongSoTinChiYeuCau = tnET.TongSoTinChiYeuCau
                };
                db.TotNghieps.InsertOnSubmit(tn);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaTotNghiep(TotNghiep_ET tnET)
        {
            try
            {
                var tn = db.TotNghieps.FirstOrDefault(x => x.maSV == tnET.MaSV);
                if (tn == null) return false;

                tn.ngayTotNghiep = tnET.NgayTotNghiep;
                tn.xepLoai = tnET.XepLoai;
                tn.tongSoTinChiDatDuoc = tnET.TongSoTinChiDatDuoc;
                tn.tongSoTinChiYeuCau = tnET.TongSoTinChiYeuCau;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaTotNghiep(string maSV)
        {
            try
            {
                var tn = db.TotNghieps.FirstOrDefault(x => x.maSV == maSV);
                if (tn == null) return false;

                db.TotNghieps.DeleteOnSubmit(tn);
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