using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhiDoan_BUS
    {
        PhiDoan_DAL phiDoan = new PhiDoan_DAL();

        public IQueryable LayDSPhiDoan()
        {
            return phiDoan.LayDSPhiDoan();
        }

        public IQueryable LayDSHocKy()
        {
            return phiDoan.LayDSHocKy();
        }

        public bool ThemPhiDoan(PhiDoan_ET pdET)
        {
            return phiDoan.ThemPhiDoan(pdET);
        }

        public bool XoaPhiDoan(string maPhi)
        {
            return phiDoan.XoaPhiDoan(maPhi);
        }
        public bool SuaPhiDoan(PhiDoan_ET phiDoan_ET)
        {
            return phiDoan.SuaPhiDoan(phiDoan_ET);
        }
        public bool kT_TonTai_MaPhi_BenBangKhac(string maPhi)
        {
            return phiDoan.kT_TonTai_MaPhi_BenBangKhac(maPhi);
        }



    }
}
