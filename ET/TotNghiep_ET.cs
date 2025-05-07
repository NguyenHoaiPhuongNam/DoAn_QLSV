using System;

namespace ET
{
    public class TotNghiep_ET
    {
        private string maSV, xepLoai;
        private DateTime? ngayTotNghiep;
        private int? tongSoTinChiDatDuoc, tongSoTinChiYeuCau;

        public TotNghiep_ET() { }

        public TotNghiep_ET(string maSV, DateTime? ngayTotNghiep, string xepLoai, 
                          int? tongSoTinChiDatDuoc, int? tongSoTinChiYeuCau)
        {
            this.maSV = maSV;
            this.ngayTotNghiep = ngayTotNghiep;
            this.xepLoai = xepLoai;
            this.tongSoTinChiDatDuoc = tongSoTinChiDatDuoc;
            this.tongSoTinChiYeuCau = tongSoTinChiYeuCau;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public DateTime? NgayTotNghiep { get => ngayTotNghiep; set => ngayTotNghiep = value; }
        public string XepLoai { get => xepLoai; set => xepLoai = value; }
        public int? TongSoTinChiDatDuoc { get => tongSoTinChiDatDuoc; set => tongSoTinChiDatDuoc = value; }
        public int? TongSoTinChiYeuCau { get => tongSoTinChiYeuCau; set => tongSoTinChiYeuCau = value; }
    }
}