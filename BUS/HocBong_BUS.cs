using System;
using System.Linq;
using ET;
using DAL;

namespace BUS
{
    public class HocBong_BUS
    {
        HocBong_DAL hbDAL = new HocBong_DAL();

        public IQueryable LayDSHocBong()
        {
            return hbDAL.LDSHB();
        }

        public IQueryable LayDSSinhVien()
        {
            return hbDAL.LayDSSV();
        }

        public string TaoMaHB()
        {
            return hbDAL.TaoMaHB();
        }

        public bool ThemHocBong(HocBong_ET hbET)
        {
            return hbDAL.ThemHocBong(hbET);
        }

        public bool SuaHocBong(HocBong_ET hbET)
        {
            return hbDAL.SuaHocBong(hbET);
        }

        public bool XoaHocBong(string maHB)
        {
            return hbDAL.XoaHocBong(maHB);
        }
    }
}
