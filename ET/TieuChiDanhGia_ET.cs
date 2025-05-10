using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class TieuChiDanhGia_ET
    {
        private string maTieuChi;
        private string tenTieuChi;
        private int diemToiDa;

        public TieuChiDanhGia_ET() { }

        public TieuChiDanhGia_ET(string maTieuChi, string tenTieuChi, int diemToiDa)
        {
            this.MaTieuChi = maTieuChi;
            this.TenTieuChi = tenTieuChi;
            this.DiemToiDa = diemToiDa;
        }

        public string MaTieuChi { get => maTieuChi; set => maTieuChi = value; }
        public string TenTieuChi { get => tenTieuChi; set => tenTieuChi = value; }
        public int DiemToiDa { get => diemToiDa; set => diemToiDa = value; }
    }
}
