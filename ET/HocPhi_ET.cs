using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class HocPhi_ET
    {
        private string maHocPhi;
        private string maSv;
        private string maHocPhan;
        private string maNhanVien;
        private int soTinChi;
        private int donGia;
        private int tongTien;
        private DateTime ngayDongHocPhi;
        private string trangThai;

        public HocPhi_ET(string maHocPhi = null, string maSv = null, string maHocPhan = null, string maNhanVien = null, int soTinChi = 0, int donGia = 0, int tongTien = 0, DateTime ngayDongHocPhi = default, string trangThai = null)
        {
            this.maHocPhi = maHocPhi;
            this.maSv = maSv;
            this.maHocPhan = maHocPhan;
            this.maNhanVien = maNhanVien;
            this.soTinChi = soTinChi;
            this.donGia = donGia;
            this.tongTien = tongTien;
            this.ngayDongHocPhi = ngayDongHocPhi;
            this.trangThai = trangThai;
        }

        public string MaHocPhi { get => maHocPhi; set => maHocPhi = value; }
        public string MaSv { get => maSv; set => maSv = value; }
        public string MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public DateTime NgayDongHocPhi { get => ngayDongHocPhi; set => ngayDongHocPhi = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
