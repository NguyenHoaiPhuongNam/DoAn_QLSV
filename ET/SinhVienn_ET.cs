using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class SinhVienn_ET
    {
        private string maSV, hoTen, diaChi, email, sdt, lopHoc, account;
        private DateTime ngaySinh;
        private string gioiTinh;

        public SinhVienn_ET() { }

        public SinhVienn_ET(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh,
                           string email, string sdt, string diaChi, string lopHoc, string account)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.email = email;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.lopHoc = lopHoc;
            this.account = account;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string LopHoc { get => lopHoc; set => lopHoc = value; }
        public string Account { get => account; set => account = value; }
    }
}
