using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class PhiDoan_ET
    {
        private string maPhi, maHocKy;
        private int soTien;
        private DateTime ngayBatDau, ngayKetThuc;

        public PhiDoan_ET() { }

        public PhiDoan_ET(string maPhi, string maHocKy, int soTien, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.maPhi = maPhi;
            this.maHocKy = maHocKy;
            this.soTien = soTien;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }

        public string MaPhi { get => maPhi; set => maPhi = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public int SoTien { get => soTien; set => soTien = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
