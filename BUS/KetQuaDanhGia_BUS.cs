using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KetQuaDanhGia_BUS
    {
        KetQuaDanhGia_DAL kqdgDAL = new KetQuaDanhGia_DAL();
        public IQueryable LayDSKetQuaDanhGia()
        {
            return kqdgDAL.LayDSKetQuaDanhGia();
        }
        public bool ThemKetQuaDanhGia(KetQuaDanhGia_ET kqdgET)
        {
            return kqdgDAL.ThemKetQuaDanhGia(kqdgET);
        }
        public IQueryable LayDSHocKy()
        {
            return kqdgDAL.LayDSHocKy();
        }
        public IQueryable LayDsTieuChiDanhGia()
        {
            return kqdgDAL.LayDsTieuChiDanhGia();
        }
        public bool KT_TonTaiKetQuaDanhGia(string maSV, string maHocKy, string maTieuuChi)
        {
            return kqdgDAL.KT_TonTaiKetQuaDanhGia(maSV, maHocKy, maTieuuChi);
        }
        public IQueryable TimKiemKetQuaDanhGia(string maSV)
        {
            return kqdgDAL.TimKiemKetQuaDanhGia(maSV);
        }

        public bool XoaKetQuaDanhGia(string maSV, string maHocKy, string maTieuuChi)
        {
            return kqdgDAL.XoaKetQuaDanhGia(maSV, maHocKy, maTieuuChi);
        }

        public bool SuaKetQuaDanhGia(KetQuaDanhGia_ET kqdgET)
        {
            return kqdgDAL.SuaKetQuaDanhGia(kqdgET);
        }


    }
}
