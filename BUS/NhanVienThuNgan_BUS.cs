using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienThuNgan_BUS
    {
        NhanVienThuNgan_DAL dal = new NhanVienThuNgan_DAL();

        public IQueryable LayDSNhanVienThuNgan()
        {
            return dal.LayDSNhanVienThuNgan();
        }

        public bool Them(NhanVienThuNgan_ET nv)
        {
            return dal.Them(nv);
        }

        public bool Xoa(string maNV)
        {
            return dal.Xoa(maNV);
        }

        public bool Sua(NhanVienThuNgan_ET nv)
        {
            return dal.Sua(nv);
        }

        public bool KiemTraAccountNhanVien(string maAccount)
        {
            return dal.KiemTraAccountNhanVien(maAccount);
        }

        public bool KiemTraTrungEmail(string email)
        {
            return dal.KiemTraTrungEmailNhanVien(email);
        }

        public bool KiemTraTrungSDT(string sdt)
        {
            return dal.KiemTraTrungSDTNhanVien(sdt);
        }
        public bool KiemTraTrungMa(string ma)
        {
            return dal.KiemTraTrungMaNhanVien(ma);
        }
        public bool KiemTraMaAACCount(string maAccount)
        {
            return dal.KiemTraMaAACCount(maAccount);
        }
        public IQueryable<NhanVienThuNgan_ET> LayThongTin1NhanVien(string manv)
        {
            return dal.LayThongTin1NhanVien(manv);
        }
    }
}
