using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class DiemRenLuyen_ET
    {
        private string maSv;
        private string maHocKy;
        private int diemToiDa;
        private int diemDatDuoc;

        public DiemRenLuyen_ET() { }
        public DiemRenLuyen_ET(string maSv, string maHocKy, int diemToiDa, int diemDatDuoc)
        {
            this.MaSv = maSv;
            this.MaHocKy = maHocKy;
            this.DiemToiDa = diemToiDa;
            this.DiemDatDuoc = diemDatDuoc;
        }

        public string MaSv { get => maSv; set => maSv = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public int DiemToiDa { get => diemToiDa; set => diemToiDa = value; }
        public int DiemDatDuoc { get => diemDatDuoc; set => diemDatDuoc = value; }
    }
}
