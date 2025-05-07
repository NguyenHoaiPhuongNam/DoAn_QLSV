using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienn_BUS
    {
        SinhVienn_DAL svdal = new SinhVienn_DAL();

        public IQueryable LayDSSV()
        {
            return svdal.LDSSV();
        }

        public IQueryable LayDSLopHoc()
        {
            return svdal.LayDSLopHoc();
        }

        public IQueryable LayDSAccount()
        {
            return svdal.LayDSAccount();
        }

        public bool ThemSV(SinhVienn_ET svET)
        {
            return svdal.ThemSinhVien(svET);
        }

        public bool SuaSV(SinhVienn_ET svET)
        {
            return svdal.SuaSinhVien(svET);
        }

        public bool XoaSV(string maSV)
        {
            return svdal.XoaSinhVien(maSV);
        }
    }
}
