using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SuKien_BUS
    {
        SuKien_DAL dal = new SuKien_DAL();

        public IQueryable LayDSSuKien()
        {
            return dal.LayDSSuKien();
        }

        public bool ThemSuKien(SuKien_ET skET)
        {
            return dal.ThemSuKien(skET);
        }

        public bool XoaSuKien(string maSK)
        {
            return dal.XoaSuKien(maSK);
        }

        public bool SuaSuKien(SuKien_ET skET)
        {
            return dal.SuaSuKien(skET);
        }
    }
}
