using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class KetQuaDanhGia_ET
    {
        private string maSv;
        private string maHocKy;
        private string maTieuChi;
        private int diemDatDuoc;

        public KetQuaDanhGia_ET() { }
        public KetQuaDanhGia_ET(string maSv, string maHocKy, string maTieuChi, int diemDatDuoc)
        {
            this.maSv = maSv;
            this.maHocKy = maHocKy;
            this.maTieuChi = maTieuChi;
            this.diemDatDuoc = diemDatDuoc;
        }

        public string MaSv { get => maSv; set => maSv = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string MaTieuChi { get => maTieuChi; set => maTieuChi = value; }
        public int DiemDatDuoc { get => diemDatDuoc; set => diemDatDuoc = value; }
    }
}
