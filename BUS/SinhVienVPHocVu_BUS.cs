using System;
using System.Linq;
using DAL;
using ET;

namespace BUS
{
    public class SinhVienVPHocVu_BUS
    {
        SinhVienVPHocVu_DAL vpdal = new SinhVienVPHocVu_DAL();

        public IQueryable LayDSVP()
        {
            return vpdal.LDSVP();
        }

        public IQueryable LayDSSV()
        {
            return vpdal.LayDSSV();
        }

        public IQueryable LayDSHocKy()
        {
            return vpdal.LayDSHocKy();
        }

        public bool ThemVP(SinhVienVPHocVu_ET vpET)
        {
            return vpdal.ThemViPham(vpET);
        }

        public bool SuaVP(SinhVienVPHocVu_ET vpET)
        {
            return vpdal.SuaViPham(vpET);
        }

        public bool XoaVP(string maViPham)
        {
            return vpdal.XoaViPham(maViPham);
        }
    }
}
