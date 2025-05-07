using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienChucVuDoan_BUS
    {
        SinhVienChucVuDoan_DAL cv_DAL = new SinhVienChucVuDoan_DAL();
        public IQueryable LayDSSVChucVuDoan()
        {
            return cv_DAL.LayDSSVChucVuDoan();
        }

        public IQueryable LayDSHocKy()
        {
            return cv_DAL.LayDSHocKy();
        }

        public IQueryable LayDSSinhVien()
        {
            return cv_DAL.LayDSSinhVien();
        }

        public IQueryable LayDSChucVuDoan()
        {
            return cv_DAL.LayDSChucVuDoan();
        }

        public bool KiemTraTrungMa(string maCV, string maHk, string maSV)
        {
            return cv_DAL.KiemTraTrungMa(maCV,maHk,maSV);
        }

        public bool ThemSinhVienChucVu(SinhVienChucVuDoan_ET cv)
        {
            return cv_DAL.ThemSinhVienChucVu(cv);
        }

        public bool XoaSinhVienChucVu(string maCV, string maHk, string maSV)
        {
            return cv_DAL.XoaSinhVienChucVu(maCV, maHk, maSV);
        }
        public bool SuaSinhVienChucVuTheoHK(string maCV, string maSV)
        {
            return cv_DAL.SuaSinhVienChucVuTheoHK(maCV, maSV);
        }
        public bool KiemTraTrungMaSuaHK(string maCV, string maSV)
        {
            return cv_DAL.KiemTraTrungMaSuaHK(maCV, maSV);
        }
        public bool SuaSinhVienChucVuTheoCV(string maHk, string maSV)
        {
            return cv_DAL.SuaSinhVienChucVuTheoCV(maHk, maSV);
        }

        public bool KiemTraTrungMaSuaCv(string maHk, string maSV)
        {
            return cv_DAL.KiemTraTrungMaSuaCv(maHk, maSV);
        }
        public bool KiemTraTrungMaSuaSv(string maSV)
        {
            return cv_DAL.KiemTraTrungMaSVa(maSV);
        }
    }
}
