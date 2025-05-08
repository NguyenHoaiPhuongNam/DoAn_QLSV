using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class SinhVien_ET
    {
        private string maSv;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string email;
        private string sdt;
        private string diaChi;
        private string lophoc;
        private string account;

        public SinhVien_ET() { }
        public SinhVien_ET(string maSv, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string sdt, string diaChi, string lophoc, string account)
        {
            this.maSv = maSv;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.email = email;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.lophoc = lophoc;
            this.account = account;
        }

        public string MaSv { get => maSv; set => maSv = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Lophoc { get => lophoc; set => lophoc = value; }
        public string Account { get => account; set => account = value; }
    }
}
