using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public  class SinhVienChucVuDoan_ET
    {
        private string maSV;
        private string maChucVu;
        private string maHocKy;

        public SinhVienChucVuDoan_ET(string maSV, string maChucVu, string maHocKy)
        {
            this.MaSV = maSV;
            this.MaChucVu = maChucVu;
            this.MaHocKy = maHocKy;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
    }
}
