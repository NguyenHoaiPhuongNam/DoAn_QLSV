using System;
using System.Linq;
using DAL;
using ET;

namespace BUS
{
    public class NhanVienQuanLy_BUS
    {
        NhanVienQuanLy_DAL nvdal = new NhanVienQuanLy_DAL();

        public IQueryable LayDSNV()
        {
            return nvdal.LDSNV();
        }

        public IQueryable LayDSKhoa()
        {
            return nvdal.LayDSKhoa();
        }

        public IQueryable LayDSAccount()
        {
            return nvdal.LayDSAccount();
        }

        public bool ThemNV(NhanVienQuanLy_ET nvET)
        {
            return nvdal.ThemNhanVien(nvET);
        }

        public bool SuaNV(NhanVienQuanLy_ET nvET)
        {
            return nvdal.SuaNhanVien(nvET);
        }

        public bool XoaNV(string maNV)
        {
            return nvdal.XoaNhanVien(maNV);
        }
    }
}
