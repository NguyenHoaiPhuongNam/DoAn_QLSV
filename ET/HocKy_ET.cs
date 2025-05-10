using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class HocKy_ET
    {
        private string maHocKy;
        private string tenHocKy;


        public HocKy_ET() { }
        public HocKy_ET(string maHocKy, string tenHocKy)
        {
            this.maHocKy = maHocKy;
            this.tenHocKy = tenHocKy;
        }

        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string TenHocKy { get => tenHocKy; set => tenHocKy = value; }
    }
}
