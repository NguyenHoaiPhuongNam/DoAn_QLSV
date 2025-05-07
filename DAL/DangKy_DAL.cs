using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DangKy_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LDSDK()
        {
            var dangky = from dk in db.DangKies
                         join sv in db.SinhViens on dk.maSv equals sv.maSv
                         join hp in db.HocPhans on dk.maHocPhan equals hp.maHocPhan
                         join hk in db.HocKies on dk.maHocKy equals hk.maHocKy
                         join lhp in db.LopHocPhans on dk.maLopHP equals lhp.maLopHP
                         select new
                         {
                             maSV = dk.maSv,
                             hoTenSV = sv.hoTen,
                             maHocPhan = dk.maHocPhan,
                             tenHocPhan = hp.tenHocPhan,
                             maHocKy = dk.maHocKy,
                             tenHocKy = hk.tenHocKy,
                             maLopHP = dk.maLopHP
                         };
            return dangky;
        }

        public IQueryable LayDSSV()
        {
            var dssv = from sv in db.SinhViens
                       select new { sv.maSv, TenSV = sv.hoTen + " (" + sv.maSv + ")" };
            return dssv;
        }

        public IQueryable LayDSHP()
        {
            var dshp = from hp in db.HocPhans
                       select new { hp.maHocPhan, TenHP = hp.tenHocPhan + " (" + hp.maHocPhan + ")" };
            return dshp;
        }

        public IQueryable LayDSHK()
        {
            var dshk = from hk in db.HocKies
                       select new { hk.maHocKy, TenHK = hk.tenHocKy + " (" + hk.maHocKy + ")" };
            return dshk;
        }

        public IQueryable LayDSLopHP()
        {
            var dslhp = from lhp in db.LopHocPhans
                        join hp in db.HocPhans on lhp.maHP equals hp.maHocPhan
                        select new { lhp.maLopHP, TenLopHP = hp.tenHocPhan + " - " + lhp.maLopHP };
            return dslhp;
        }

        // Lọc danh sách lớp học phần theo mã học phần
        public IQueryable LayDSLopHP_TheoHP(string maHP)
        {
            var dslhp = from lhp in db.LopHocPhans
                        join hp in db.HocPhans on lhp.maHP equals hp.maHocPhan
                        where lhp.maHP == maHP
                        select new { lhp.maLopHP, TenLopHP = hp.tenHocPhan + " - " + lhp.maLopHP };
            return dslhp;
        }

        public bool ThemDangKy(DangKy_ET dkET)
        {
            try
            {
                // Kiểm tra xem đã tồn tại đăng ký này chưa
                var checkExist = db.DangKies.FirstOrDefault(x => 
                    x.maSv == dkET.MaSV && 
                    x.maHocPhan == dkET.MaHocPhan && 
                    x.maHocKy == dkET.MaHocKy && 
                    x.maLopHP == dkET.MaLopHP);
                
                if (checkExist != null)
                    return false;

                DangKy dk = new DangKy
                {
                    maSv = dkET.MaSV,
                    maHocPhan = dkET.MaHocPhan,
                    maHocKy = dkET.MaHocKy,
                    maLopHP = dkET.MaLopHP
                };
                db.DangKies.InsertOnSubmit(dk);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaDangKy(DangKy_ET dkETOld, DangKy_ET dkETNew)
        {
            try
            {
                // Xóa bản ghi cũ
                var dkOld = db.DangKies.FirstOrDefault(x => 
                    x.maSv == dkETOld.MaSV && 
                    x.maHocPhan == dkETOld.MaHocPhan && 
                    x.maHocKy == dkETOld.MaHocKy && 
                    x.maLopHP == dkETOld.MaLopHP);
                
                if (dkOld == null)
                    return false;

                db.DangKies.DeleteOnSubmit(dkOld);
                db.SubmitChanges();

                // Thêm bản ghi mới
                DangKy dkNew = new DangKy
                {
                    maSv = dkETNew.MaSV,
                    maHocPhan = dkETNew.MaHocPhan,
                    maHocKy = dkETNew.MaHocKy,
                    maLopHP = dkETNew.MaLopHP
                };
                db.DangKies.InsertOnSubmit(dkNew);
                db.SubmitChanges();
                
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaDangKy(DangKy_ET dkET)
        {
            try
            {
                var dk = db.DangKies.FirstOrDefault(x => 
                    x.maSv == dkET.MaSV && 
                    x.maHocPhan == dkET.MaHocPhan && 
                    x.maHocKy == dkET.MaHocKy && 
                    x.maLopHP == dkET.MaLopHP);
                
                if (dk == null)
                    return false;

                db.DangKies.DeleteOnSubmit(dk);
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
