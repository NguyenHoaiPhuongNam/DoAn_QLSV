using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class GiangVien_ET
    {
        private string maGV;
        private string hoTen;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string email;
        private string sDT;
        private string diaChi;
        private string maKhoa;

        public GiangVien_ET(string maGV, string hoTen, DateTime ngaySinh, string gioiTinh, string email, string sDT, string diaChi, string maKhoa)
        {
            this.MaGV = maGV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.Email = email;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.MaKhoa = maKhoa;
        }

        public string MaGV { get => maGV; set => maGV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public GiangVien_ET() { }

    }
}
