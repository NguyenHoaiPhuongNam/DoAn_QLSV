using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class HocBong_ET
    {
        private string maHB, maSV, xepLoaiHB, ghiChu;

        public HocBong_ET() { }

        public HocBong_ET(string maHB, string maSV, string xepLoaiHB, string ghiChu)
        {
            this.maHB = maHB;
            this.maSV = maSV;
            this.xepLoaiHB = xepLoaiHB;
            this.ghiChu = ghiChu;
        }

        public string MaHB { get => maHB; set => maHB = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public string XepLoaiHB { get => xepLoaiHB; set => xepLoaiHB = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
