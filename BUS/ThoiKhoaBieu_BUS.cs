using System;
using System.Linq;
using DAL;
using ET;

namespace BUS
{
    public class ThoiKhoaBieu_BUS
    {
        ThoiKhoaBieu_DAL tkbdal = new ThoiKhoaBieu_DAL();

        public IQueryable LayDSTKB()
        {
            return tkbdal.LDSTKB();
        }

        public IQueryable LayDSHocPhan()
        {
            return tkbdal.LayDSHocPhan();
        }

        public bool ThemTKB(ThoiKhoaBieu_ET tkbET)
        {
            return tkbdal.ThemTKB(tkbET);
        }

        public bool SuaTKB(ThoiKhoaBieu_ET tkbET)
        {
            return tkbdal.SuaTKB(tkbET);
        }

        public bool XoaTKB(string maTKB)
        {
            return tkbdal.XoaTKB(maTKB);
        }
    }
}
