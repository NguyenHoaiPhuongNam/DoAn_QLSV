using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class PhieuThuDoanPhi_ET
    {
        private string maPhieu;
        private string maSVThuPhi;
        private string maSVNopPhi;
        private string maPhi;
        private DateTime ngayThu;

        public PhieuThuDoanPhi_ET() { }
        public PhieuThuDoanPhi_ET(string maPhieu, string maSVThuPhi, string maSVNopPhi, string maPhi, DateTime ngayThu)
        {
            this.maPhieu = maPhieu;
            this.maSVThuPhi = maSVThuPhi;
            this.maSVNopPhi = maSVNopPhi;
            this.maPhi = maPhi;
            this.ngayThu = ngayThu;
        }

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaSVThuPhi { get => maSVThuPhi; set => maSVThuPhi = value; }
        public string MaSVNopPhi { get => maSVNopPhi; set => maSVNopPhi = value; }
        public string MaPhi { get => maPhi; set => maPhi = value; }
        public DateTime NgayThu { get => ngayThu; set => ngayThu = value; }
    }
}
