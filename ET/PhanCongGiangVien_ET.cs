using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class PhanCongGiangVien_ET
    {
        private string maHocPhan;
        private string maGV;

        public PhanCongGiangVien_ET(string maHocPhan, string maGV)
        {
            this.MaHocPhan = maHocPhan;
            this.MaGV = maGV;
        }

        public string MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
        public string MaGV { get => maGV; set => maGV = value; }
    }
}
