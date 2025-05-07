using System;
using System.Linq;
using ET;
using DAL;

namespace BUS
{
    public class TotNghiep_BUS
    {
        TotNghiep_DAL tnDAL = new TotNghiep_DAL();

        public IQueryable LayDSTotNghiep()
        {
            return tnDAL.LDSTN();
        }

        public IQueryable LayDSSinhVien()
        {
            return tnDAL.LayDSSV();
        }

        public bool ThemTotNghiep(TotNghiep_ET tnET)
        {
            return tnDAL.ThemTotNghiep(tnET);
        }

        public bool SuaTotNghiep(TotNghiep_ET tnET)
        {
            return tnDAL.SuaTotNghiep(tnET);
        }

        public bool XoaTotNghiep(string maSV)
        {
            return tnDAL.XoaTotNghiep(maSV);
        }
    }
}