using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class SinhVienVPHocVu_ET
    {
        private string maViPham, maSV, maHocKy, loaiViPham, moTa, hinhThucXuLy;
        private DateTime ngayViPham;
        private int diemTru;

        public SinhVienVPHocVu_ET() { }

        public SinhVienVPHocVu_ET(string maViPham, string maSV, string maHocKy, DateTime ngayViPham, 
                                string loaiViPham, string moTa, string hinhThucXuLy, int diemTru)
        {
            this.maViPham = maViPham;
            this.maSV = maSV;
            this.maHocKy = maHocKy;
            this.ngayViPham = ngayViPham;
            this.loaiViPham = loaiViPham;
            this.moTa = moTa;
            this.hinhThucXuLy = hinhThucXuLy;
            this.diemTru = diemTru;
        }

        public string MaViPham { get => maViPham; set => maViPham = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public DateTime NgayViPham { get => ngayViPham; set => ngayViPham = value; }
        public string LoaiViPham { get => loaiViPham; set => loaiViPham = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string HinhThucXuLy { get => hinhThucXuLy; set => hinhThucXuLy = value; }
        public int DiemTru { get => diemTru; set => diemTru = value; }
    }
}
