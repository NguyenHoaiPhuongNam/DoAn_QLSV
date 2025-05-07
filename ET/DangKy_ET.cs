using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class DangKy_ET
    {
        private string maSV, maHocPhan, maHocKy, maLopHP;

        public DangKy_ET() { }

        public DangKy_ET(string maSV, string maHocPhan, string maHocKy, string maLopHP)
        {
            this.maSV = maSV;
            this.maHocPhan = maHocPhan;
            this.maHocKy = maHocKy;
            this.maLopHP = maLopHP;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string MaLopHP { get => maLopHP; set => maLopHP = value; }
    }
}
