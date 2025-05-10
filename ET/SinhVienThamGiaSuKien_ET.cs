using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class SinhVienThamGiaSuKien_ET
    {
        private string maSV;
        private string maSK;

        public SinhVienThamGiaSuKien_ET(string maSV, string maSK)
        {
            this.MaSV = maSV;
            this.MaSK = maSK;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string MaSK { get => maSK; set => maSK = value; }
    }
}
