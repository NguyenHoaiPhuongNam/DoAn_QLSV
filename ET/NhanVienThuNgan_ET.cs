using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class NhanVienThuNgan_ET
    {
        private string maNhanVien;
        private string hoTen;
        private DateTime ngaySinh;
        private string gT;
        private string email;
        private string sDT;
        private string diaChi;
        private string accounta;


        public NhanVienThuNgan_ET() { }

        public NhanVienThuNgan_ET(string maNhanVien, string hoTen, DateTime ngaySinh, string gT, string email, string sDT, string diaChi, string accounta)
        {
            this.MaNhanVien = maNhanVien;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GT = gT;
            this.Email = email;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.Accounta = accounta;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GT { get => gT; set => gT = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Accounta { get => accounta; set => accounta = value; }
    }
}
