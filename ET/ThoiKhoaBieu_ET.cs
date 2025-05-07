using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ThoiKhoaBieu_ET
    {
        private string maTKB, maHocPhan, phong;
        private DateTime ngayHoc;
        private TimeSpan gioBatDau, gioKetThuc;
        private int tietBatDau, tietKetThuc;

        public ThoiKhoaBieu_ET() { }

        public ThoiKhoaBieu_ET(string maTKB, string maHocPhan, DateTime ngayHoc, 
                             TimeSpan gioBatDau, TimeSpan gioKetThuc,
                             int tietBatDau, int tietKetThuc, string phong)
        {
            this.maTKB = maTKB;
            this.maHocPhan = maHocPhan;
            this.ngayHoc = ngayHoc;
            this.gioBatDau = gioBatDau;
            this.gioKetThuc = gioKetThuc;
            this.tietBatDau = tietBatDau;
            this.tietKetThuc = tietKetThuc;
            this.phong = phong;
        }

        public string MaTKB { get => maTKB; set => maTKB = value; }
        public string MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
        public DateTime NgayHoc { get => ngayHoc; set => ngayHoc = value; }
        public TimeSpan GioBatDau { get => gioBatDau; set => gioBatDau = value; }
        public TimeSpan GioKetThuc { get => gioKetThuc; set => gioKetThuc = value; }
        public int TietBatDau { get => tietBatDau; set => tietBatDau = value; }
        public int TietKetThuc { get => tietKetThuc; set => tietKetThuc = value; }
        public string Phong { get => phong; set => phong = value; }
    }
}
