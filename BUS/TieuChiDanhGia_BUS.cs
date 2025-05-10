using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TieuChiDanhGia_BUS
    {
        TieuChiDanhGia_DAL tcdgDAL = new TieuChiDanhGia_DAL();

        public IQueryable LayDsTieuChiDanhGia()
        {
            return tcdgDAL.LayDsTieuChiDanhGia();
        }
        public bool ThemTieuChiDanhGia(TieuChiDanhGia_ET tcdgET)
        {
            return tcdgDAL.ThemTieuChiDanhGia(tcdgET);
        }
        public bool XoaTieuChiDanhGia(string maTieuChi)
        {
            return tcdgDAL.XoaTieuChiDanhGia(maTieuChi);
        }
        public bool SuaTieuChi(TieuChiDanhGia_ET tcdgET)
        {
            return tcdgDAL.SuaTieuChi(tcdgET);
        }
        public IQueryable TimKiemTieuChi(string maTieuChi)
        {
            return tcdgDAL.TimKiemTieuChi(maTieuChi);
        }


    }
}
