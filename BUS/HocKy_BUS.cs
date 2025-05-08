using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocKy_BUS
    {
        HocKy_DAL hkDAL = new HocKy_DAL();

        public IQueryable LayDSHocKy()
        {
            return hkDAL.LayDSHocKy();
        }
        

        public bool ThemHocKy(HocKy_ET hkET)
        {
            return hkDAL.ThemHocKy(hkET);
        }
        public bool KT_MaKH(string maHK)
        {
            return hkDAL.KT_MaKH(maHK);
        }

        public bool XoaHocKy(string maHocKy)
        {
            return hkDAL.XoaHocKy(maHocKy);
        }
        public bool SuaHocKy(HocKy_ET hkET)
        {
            return hkDAL.SuaHocKy(hkET);
        }
        public IQueryable TimKiemHocKyTheoMa(string maHocKy)
        {
            return hkDAL.TimKiemHocKyTheoMa(maHocKy);
        }


    }
}
