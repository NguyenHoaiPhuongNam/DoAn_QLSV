using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public  class ChucVuDoan_ET
    {
        private string maChucVu;
        private string tenChucVu;
        private int diemCong;

        public ChucVuDoan_ET(string maChucVu, string tenChucVu, int diemCong)
        {
            this.MaChucVu = maChucVu;
            this.TenChucVu = tenChucVu;
            this.DiemCong = diemCong;
        }

        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public int DiemCong { get => diemCong; set => diemCong = value; }
    }
}
