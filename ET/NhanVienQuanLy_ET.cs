using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class NhanVienQuanLy_ET
    {
        private string maNhanVien, hoTen, gioiTinh, email, sdt, diaChi, maKhoa, account;
        private DateTime ngaySinh;

        public NhanVienQuanLy_ET() { }

        public NhanVienQuanLy_ET(string maNhanVien, string hoTen, DateTime ngaySinh,
                               string gioiTinh, string email, string sdt, string diaChi,
                               string maKhoa, string account)
        {
            this.maNhanVien = maNhanVien;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.email = email;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.maKhoa = maKhoa;
            this.account = account;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string Account { get => account; set => account = value; }
    }
}
