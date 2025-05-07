using System;
using System.Linq;
using ET;

namespace DAL
{
    public class SinhVienVPHocVu_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public IQueryable LDSVP()
        {
            var vphocvu = from vp in db.SinhVienViPhamHocVus
                         select new
                         {
                             maViPham = vp.maViPham,
                             maSv = vp.maSv,
                             maHocKy = vp.maHocKy,
                             ngayViPham = vp.ngayViPham,
                             loaiViPham = vp.loaiViPham,
                             moTa = vp.moTa,
                             hinhThucXuLy = vp.hinhThucXuLy,
                             diemTru = vp.diemTru
                         };
            return vphocvu;
        }

        public IQueryable LayDSSV()
        {
            var dssv = from sv in db.SinhViens
                      select new { sv.maSv, TenSV = sv.hoTen + " (" + sv.maSv + ")" };
            return dssv;
        }

        public IQueryable LayDSHocKy()
        {
            var dshk = from hk in db.HocKies
                      select new { hk.maHocKy, TenHK = hk.tenHocKy + " (" + hk.maHocKy + ")" };
            return dshk;
        }

        public bool ThemViPham(SinhVienVPHocVu_ET vpET)
        {
            try
            {
                SinhVienViPhamHocVu vp = new SinhVienViPhamHocVu
                {
                    maViPham = vpET.MaViPham,
                    maSv = vpET.MaSV,
                    maHocKy = vpET.MaHocKy,
                    ngayViPham = vpET.NgayViPham,
                    loaiViPham = vpET.LoaiViPham,
                    moTa = vpET.MoTa,
                    hinhThucXuLy = vpET.HinhThucXuLy,
                    diemTru = vpET.DiemTru
                };
                db.SinhVienViPhamHocVus.InsertOnSubmit(vp);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaViPham(SinhVienVPHocVu_ET vpET)
        {
            try
            {
                var vp = db.SinhVienViPhamHocVus.FirstOrDefault(x => x.maViPham == vpET.MaViPham);
                if (vp == null) return false;

                vp.maSv = vpET.MaSV;
                vp.maHocKy = vpET.MaHocKy;
                vp.ngayViPham = vpET.NgayViPham;
                vp.loaiViPham = vpET.LoaiViPham;
                vp.moTa = vpET.MoTa;
                vp.hinhThucXuLy = vpET.HinhThucXuLy;
                vp.diemTru = vpET.DiemTru;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaViPham(string maViPham)
        {
            try
            {
                var vp = db.SinhVienViPhamHocVus.FirstOrDefault(x => x.maViPham == maViPham);
                if (vp == null) return false;

                db.SinhVienViPhamHocVus.DeleteOnSubmit(vp);
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
