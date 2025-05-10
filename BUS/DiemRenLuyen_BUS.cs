using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DiemRenLuyen_BUS
    {
        DiemRenLuyen_DAL drlDAL = new DiemRenLuyen_DAL();

        public IQueryable LayDSDiemRenLuyen()
        {
            return drlDAL.LayDSDiemRenLuyen();
        }
        public bool ThemDiemRenLuyen(DiemRenLuyen_ET drlET)
        {
            return drlDAL.ThemDiemRenLuyen(drlET);
        }
        public IQueryable LayHocKy()
        {
            return drlDAL.LayHocKy();
        }
        public IQueryable TimKiemDRLTheoMaSV(string maSV)
        {
            return drlDAL.TimKiemDRLTheoMaSV(maSV);
        }
        public bool KT_maSV_maHk_TonTai(string maSV, string maHK)
        {
            return drlDAL.KT_maSV_maHk_TonTai(maSV, maHK);
        }
        public bool XoaDiemRenLuyen(string maSv, string maHocKy)
        {
            return drlDAL.XoaDiemRenLuyen(maSv, maHocKy);
        }
        public bool SuaDrl(DiemRenLuyen_ET drlET)
        {
            return drlDAL.SuaDrl(drlET);
        }
    }
}
