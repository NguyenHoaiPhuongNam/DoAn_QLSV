using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Nganh_ET
    {
        private string maKhoa;
        private string maNganh;
        private string tenNganh;
        private string heDaoTao;
        private int soNamHoc;

        public Nganh_ET(string maKhoa, string maNganh, string tenNganh, string heDaoTao, int soNamHoc)
        {
            this.maKhoa = maKhoa;
            this.maNganh = maNganh;
            this.tenNganh = tenNganh;
            this.heDaoTao = heDaoTao;
            this.soNamHoc = soNamHoc;
        }

        public string MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string TenNganh { get => tenNganh; set => tenNganh = value; }
        public string HeDaoTao { get => heDaoTao; set => heDaoTao = value; }
        public int SoNamHoc { get => soNamHoc; set => soNamHoc = value; }
    }
}
