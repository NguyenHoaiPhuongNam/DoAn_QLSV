using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class DiemHocPhan_BUS
    {
        DiemHocPhan_DAL dhpDAL = new DiemHocPhan_DAL();

        public IQueryable LayDSDiemHocPhan()
        {
            return dhpDAL.LayDSDiemHocPhan();
        }

        public IQueryable LayDSSinhVien()
        {
            return dhpDAL.LayDSSinhVien();
        }

        public IQueryable LayDSLopHocPhan()
        {
            return dhpDAL.LayDSLopHocPhan();
        }

        public bool ThemDiemHocPhan(DiemHocPhan_ET dhpET)
        {
            return dhpDAL.ThemDiemHocPhan(dhpET);
        }

        public bool SuaDiemHocPhan(DiemHocPhan_ET dhpET)
        {
            return dhpDAL.SuaDiemHocPhan(dhpET);
        }

        public bool XoaDiemHocPhan(string maSV, string maLopHP)
        {
            return dhpDAL.XoaDiemHocPhan(maSV, maLopHP);
        }

        public DiemHocPhan_ET LayThongTinDiemHocPhan(string maSV, string maLopHP)
        {
            return dhpDAL.LayThongTinDiemHocPhan(maSV, maLopHP);
        }
    }
}
