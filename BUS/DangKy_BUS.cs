using System;
using System.Linq;
using ET;
using DAL;

namespace BUS
{
    public class DangKy_BUS
    {
        DangKy_DAL dkDAL = new DangKy_DAL();

        public IQueryable LayDSDangKy()
        {
            return dkDAL.LDSDK();
        }

        public IQueryable LayDSSinhVien()
        {
            return dkDAL.LayDSSV();
        }

        public IQueryable LayDSHocPhan()
        {
            return dkDAL.LayDSHP();
        }

        public IQueryable LayDSHocKy()
        {
            return dkDAL.LayDSHK();
        }

        public IQueryable LayDSLopHP()
        {
            return dkDAL.LayDSLopHP();
        }

        public IQueryable LayDSLopHP_TheoHP(string maHP)
        {
            return dkDAL.LayDSLopHP_TheoHP(maHP);
        }

        public bool ThemDangKy(DangKy_ET dkET)
        {
            return dkDAL.ThemDangKy(dkET);
        }

        public bool SuaDangKy(DangKy_ET dkETOld, DangKy_ET dkETNew)
        {
            return dkDAL.SuaDangKy(dkETOld, dkETNew);
        }

        public bool XoaDangKy(DangKy_ET dkET)
        {
            return dkDAL.XoaDangKy(dkET);
        }
    }
}
