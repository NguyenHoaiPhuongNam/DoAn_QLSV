using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class LopHocPhan_ET
    {
        private string maLopHP;
        private string maHP;
        private int soLuong;
        private string thongTin;
        private string maGV;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;

        public LopHocPhan_ET(string maLopHP, string maHP, int soLuong, string thongTin, string maGV, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.maLopHP = maLopHP;
            this.maHP = maHP;
            this.soLuong = soLuong;
            this.thongTin = thongTin;
            this.maGV = maGV;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }

        public string MaLopHP { get => maLopHP; set => maLopHP = value; }
        public string MaHP { get => maHP; set => maHP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string ThongTin { get => thongTin; set => thongTin = value; }
        public string MaGV { get => maGV; set => maGV = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
