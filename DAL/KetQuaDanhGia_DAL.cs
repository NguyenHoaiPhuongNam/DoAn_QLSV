using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KetQuaDanhGia_DAL
    {
        QLSVDataContext db = new QLSVDataContext();
        public IQueryable LayDSKetQuaDanhGia()
        {
            var ketQua = from kq in db.KetQuaDanhGias
                         select new 
                         {
                            kq.maSv,
                            kq.maHocKy,
                            kq.maTieuChi,
                            kq.diemDatDuoc
                         };
            return ketQua;
        }
        public IQueryable LayDSHocKy()
        {
            var hocKy = from hk in db.HocKies
                        select hk;
            return hocKy;
        }

        public IQueryable LayDsTieuChiDanhGia()
        {
            var tieuChi = from tc in db.TieuChiDanhGias
                          select tc;
            return tieuChi;
        }
        public bool ThemKetQuaDanhGia(KetQuaDanhGia_ET kqdgET)
        {
            try
            {
                var tonTai = db.KetQuaDanhGias.Any(x => x.maSv == kqdgET.MaSv &&
                                                     x.maHocKy == kqdgET.MaHocKy &&
                                                     x.maTieuChi == kqdgET.MaTieuChi);
                if (tonTai)
                {
                    return false;
                }
                else
                {
                    KetQuaDanhGia kq = new KetQuaDanhGia()
                    {
                        maSv = kqdgET.MaSv,
                        maHocKy = kqdgET.MaHocKy,
                        maTieuChi = kqdgET.MaTieuChi,
                        diemDatDuoc = kqdgET.DiemDatDuoc
                    };
                    db.KetQuaDanhGias.InsertOnSubmit(kq);
                    return true;
                }
                
            }
            finally
            {
                db.SubmitChanges();
            }
            return false;
        }

        public bool KT_TonTaiKetQuaDanhGia(string maSV, string maHocKy, string maTieuuChi)
        {
            var keqQua = db.KetQuaDanhGias.Where(x => x.maSv == maSV &&
                                                x.maHocKy == maHocKy &&
                                                x.maTieuChi == maTieuuChi).FirstOrDefault();
            if(keqQua == null)
            {
                return true;
            }
            return false;
        }
        public IQueryable TimKiemKetQuaDanhGia(string maSV)
        {
            var timKiem = from kq in db.KetQuaDanhGias
                          where (kq.maSv == maSV)
                          select new
                          {
                              kq.maSv,
                              kq.maHocKy,
                              kq.maTieuChi,
                              kq.diemDatDuoc
                          };
            return timKiem;
            
        }

        public bool XoaKetQuaDanhGia(string maSV, string maHocKy, string maTieuuChi)
        {
            try
            {
                var keqQua = db.KetQuaDanhGias.Where(x => x.maSv == maSV &&
                                                x.maHocKy == maHocKy &&
                                                x.maTieuChi == maTieuuChi).FirstOrDefault();
                if (keqQua != null)
                {
                    db.KetQuaDanhGias.DeleteOnSubmit(keqQua);
                    db.SubmitChanges();
                    return true;

                }
            }
            finally
            {
            }
            return false;
        }
        public bool SuaKetQuaDanhGia(KetQuaDanhGia_ET kqdgET)
        {
            bool kt = false;
            try
            {
                var ketQua = db.KetQuaDanhGias.Where(x => x.maSv == kqdgET.MaSv &&
                                                     x.maHocKy == kqdgET.MaHocKy &&
                                                     x.maTieuChi == kqdgET.MaTieuChi).FirstOrDefault();
                if(ketQua != null)
                {
                   
                    ketQua.diemDatDuoc = kqdgET.DiemDatDuoc;
                    db.SubmitChanges();
                    return kt = true;
                }
            }
            finally
            {

            }
            return false;
        }
    }
}
