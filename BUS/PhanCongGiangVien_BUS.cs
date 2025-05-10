using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanCongGiangVien_BUS
    {
        PhanCongGiangVien_DAL pc_dal = new PhanCongGiangVien_DAL();
        public IQueryable LayDSPhanCong()
        {
            return pc_dal.LayDSPhanCong();
        }
        public IQueryable LayDSMonHoc()
        {
            return pc_dal.LayDSMonHoc();
        }
        public bool ThemPCGV(PhanCongGiangVien_ET pca)
        {
            return pc_dal.ThemPCGV(pca);
        }
        public bool XoaPCGV(string maHocPhan, string maGiangVien)
        {
            return pc_dal.XoaPCGV(maHocPhan, maGiangVien);
        }
        public bool KiemTraTrungMa(string maHP, string maGV)
        {
            return pc_dal.KiemTraTrungMa(maHP, maGV);
        }
        public IQueryable LayDSPhanCong1GV(string maGv)
        {
            return pc_dal.LayDSPhanCong1GV(maGv);
        }
        public bool KiemTraMaGv(string maGv)
        {
            return pc_dal.KiemTraMaGv(maGv);
        }
        public bool KiemTraMaHP(string maHP)
        {
            return pc_dal.KiemTraMaHP(maHP);
        }
    }
}
