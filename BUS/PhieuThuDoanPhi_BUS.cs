using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuThuDoanPhi_BUS
    {
        PhieuThuDoanPhi_DAL phieuThuDoanPhi_DAL = new PhieuThuDoanPhi_DAL();
        public IQueryable LayDSPhieuThuDoanPhi()
        {
            return phieuThuDoanPhi_DAL.LayDSPhieuThuDoanPhi();
        }

        public IQueryable LayDSPhiDoan()
        {
            return phieuThuDoanPhi_DAL.LayDSPhiDoan();
        }
        public bool ThemPhieuThuDoanPhi(PhieuThuDoanPhi_ET phieuThuDoanPhi_ET)
        {
            return phieuThuDoanPhi_DAL.ThemPhieuThuDoanPhi(phieuThuDoanPhi_ET);
        }

        public bool XoaPhieuThuDoanPhi(string maPhieu)
        {
            return phieuThuDoanPhi_DAL.XoaPhieuThuDoanPhi(maPhieu);
        }
        public bool SuaPhieuThuDoanPhi(PhieuThuDoanPhi_ET phieuThuDoanPhi_ET)
        {
            return phieuThuDoanPhi_DAL.SuaPhieuThuDoanPhi(phieuThuDoanPhi_ET);
        }


    }
}
