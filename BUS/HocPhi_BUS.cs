using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocPhi_BUS
    {
        HocPhi_DAL hpDAL = new HocPhi_DAL();

        public IQueryable LayDSHocPhi()
        {
            return hpDAL.LayDSHocPhi();
        }
        public bool KT_hocPhi(string maSV , string maHocPhan)
        {
            return hpDAL.KT_hocPhi(maSV, maHocPhan);
        }
        public bool ThemHocPhi(HocPhi_ET hpET)
        {
            return hpDAL.ThemHocPhi(hpET);
        }

        public bool XoaHocPhi(string maHocPhi)
        {
            return hpDAL.XoaHocPhi(maHocPhi);
        }
        public bool SuaHocPhi(HocPhi_ET hpET)
        {
            return hpDAL.SuaHocPhi(hpET);
        }
        public IQueryable TimKiemHocPhiTheoMaSV(string maSV)
        {
            return hpDAL.TimKiemHocPhiTheoMaSV(maSV);
        }
        public int LaySoTinChi(String maHp)
        {
            return hpDAL.LaySoTinChi(maHp);
        }
        public IQueryable LayDSMaHocPhan()
        {
            return hpDAL.LayDSMaHocPhan();
        }


    }
}
