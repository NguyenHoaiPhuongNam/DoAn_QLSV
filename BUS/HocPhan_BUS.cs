using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocPhan_BUS
    {
        HocPhan_DAL hpDAL = new HocPhan_DAL();
        public IQueryable LayDSHocPhan()
        {
            return hpDAL.LayDSHocPhan();
        }
        public IQueryable LayDSHocKy()
        {
            return hpDAL.LayDSHocKy();
        }
        public bool ThemHocPhan(HocPhan_ET hpET)
        {
            return hpDAL.ThemHocPhan(hpET);
        }
        public bool XoaHocPhan(string maHP)
        {
            return hpDAL.XoaHocPhan(maHP);
        }
        public bool SuaHocPhan(HocPhan_ET hpET)
        {
            return hpDAL.SuaHocPhan(hpET);
        }
        public IQueryable TimKiemHocPhan(string maHocPhan)
        {
            return hpDAL.TimKiemHocPhan(maHocPhan);
        }
    }
}
