using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class LopHoc_ET
    {
        private string maLop;
        private string tenLop;
        private string maNganh;
        private string maGiangVien;
        private string khoaHoc;

        public LopHoc_ET(string maLop, string tenLop, string maNganh, string maGiangVien, string khoaHoc)
        {
            this.MaLop = maLop;
            this.TenLop = tenLop;
            this.MaNganh = maNganh;
            this.MaGiangVien = maGiangVien;
            this.KhoaHoc = khoaHoc;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string MaGiangVien { get => maGiangVien; set => maGiangVien = value; }
        public string KhoaHoc { get => khoaHoc; set => khoaHoc = value; }
        public LopHoc_ET() { }
    }
}
