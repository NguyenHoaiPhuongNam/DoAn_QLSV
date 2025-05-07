using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class DiemHocPhan_ET
    {
        private string maSV;
        private string maLopHP;
        private double? diemQuaTrinh;
        private double? diemThi;

        public DiemHocPhan_ET() { }

        public DiemHocPhan_ET(string maSV, string maLopHP, double? diemQuaTrinh, double? diemThi)
        {
            this.maSV = maSV;
            this.maLopHP = maLopHP;
            this.diemQuaTrinh = diemQuaTrinh;
            this.diemThi = diemThi;           
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaLopHP { get => maLopHP; set => maLopHP = value; }
        public double? DiemQuaTrinh { get => diemQuaTrinh; set => diemQuaTrinh = value; }
        public double? DiemThi { get => diemThi; set => diemThi = value; }    
    }
}
