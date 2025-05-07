using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DiemHocPhan_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LayDSDiemHocPhan()
        {
            var diemHocPhan = from d in db.DiemHocPhans
                              join sv in db.SinhViens on d.maSV equals sv.maSv
                              join lhp in db.LopHocPhans on d.maLopHP equals lhp.maLopHP
                              join hp in db.HocPhans on lhp.maHP equals hp.maHocPhan
                              select new
                              {
                                  MaSV = d.maSV,
                                  MaLopHP = d.maLopHP,
                                  DiemQuaTrinh = d.diemQuaTrinh,
                                  DiemThi = d.diemThi, 
                              };
            return diemHocPhan;
        }

        public IQueryable LayDSSinhVien()
        {
            return db.SinhViens.Select(sv => new
            {
                sv.maSv,
                TenSinhVien = sv.hoTen + " (" + sv.maSv + ")"
            });
        }

        public IQueryable LayDSLopHocPhan()
        {
            return from lhp in db.LopHocPhans
                   join hp in db.HocPhans on lhp.maHP equals hp.maHocPhan
                   select new
                   {
                       lhp.maLopHP,
                       TenLopHP = hp.tenHocPhan + " (" + lhp.maLopHP + ")"
                   };
        }

        public bool ThemDiemHocPhan(DiemHocPhan_ET dhpET)
        {
            try
            {
                var existingRecord = db.DiemHocPhans.FirstOrDefault(d => 
                    d.maSV == dhpET.MaSV && d.maLopHP == dhpET.MaLopHP);
                
                if (existingRecord != null)
                    return false;

                var dhp = new DiemHocPhan
                {
                    maSV = dhpET.MaSV,
                    maLopHP = dhpET.MaLopHP,
                    diemQuaTrinh = dhpET.DiemQuaTrinh,
                    diemThi = dhpET.DiemThi,
                };

                db.DiemHocPhans.InsertOnSubmit(dhp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDiemHocPhan(DiemHocPhan_ET dhpET)
        {
            try
            {
                var dhp = db.DiemHocPhans.FirstOrDefault(d => 
                    d.maSV == dhpET.MaSV && d.maLopHP == dhpET.MaLopHP);
                
                if (dhp == null)
                    return false;

                dhp.diemQuaTrinh = dhpET.DiemQuaTrinh;
                dhp.diemThi = dhpET.DiemThi;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaDiemHocPhan(string maSV, string maLopHP)
        {
            try
            {
                var dhp = db.DiemHocPhans.FirstOrDefault(d => 
                    d.maSV == maSV && d.maLopHP == maLopHP);
                
                if (dhp == null)
                    return false;

                db.DiemHocPhans.DeleteOnSubmit(dhp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DiemHocPhan_ET LayThongTinDiemHocPhan(string maSV, string maLopHP)
        {
            var dhp = db.DiemHocPhans.FirstOrDefault(d => 
                d.maSV == maSV && d.maLopHP == maLopHP);
            
            if (dhp == null)
                return null;

            return new DiemHocPhan_ET
            {
                MaSV = dhp.maSV,
                MaLopHP = dhp.maLopHP,
                DiemQuaTrinh = dhp.diemQuaTrinh,
                DiemThi = dhp.diemThi,
            };
        }
    }
}
