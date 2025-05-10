using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class HocPhan_ET
    {
        private string maHocPhan;
        private string tenHocPhan;
        private string maHocKy;
        private int soTinChi;
        private string loaiHP;

        public HocPhan_ET()
        {

        }
        public HocPhan_ET(string maHocPhan, string tenHocPhan, string maHocKy, int soTinChi, string loaiHP)
        {
            this.maHocPhan = maHocPhan;
            this.tenHocPhan = tenHocPhan;
            this.maHocKy = maHocKy;
            this.soTinChi = soTinChi;
            this.loaiHP = loaiHP;
        }



        public string MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
        public string TenHocPhan { get => tenHocPhan; set => tenHocPhan = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public string LoaiHP { get => loaiHP; set => loaiHP = value; }
    }
}
