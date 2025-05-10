using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LopHocPhan_BUS
    {
        LopHocPhan_DAL lh_dal = new LopHocPhan_DAL();
        public IQueryable LayDSLopHocPhan()
        {
            return lh_dal.LayDSLopHocPhan();
        }
        public IQueryable LayDSHocPhan()
        {
            return lh_dal.LayDSHocPhan();
        }
        public IQueryable LayDSGV()
        {
            return lh_dal.LayDSGV();
        }

        public bool KiemTraTrungMaLopHP(string maLopHP)
        {
            return lh_dal.KiemTraTrungMaLopHP(maLopHP);
        }
        public bool KiemTraTrungMa(string magv, string mahp)
        {
            return lh_dal.KiemTraTrungMa(magv, mahp);
        }
        public bool KiemTraNgay(DateTime nBatDau, DateTime nKetThuc)
        {
            return lh_dal.KiemTraNgay(nBatDau, nKetThuc);
        }
        public bool Them(LopHocPhan_ET lhp)
        {
            return lh_dal.Them(lhp);
        }
        public bool Sua(LopHocPhan_ET lhp)
        {
            return lh_dal.Sua(lhp);
        }
        public bool Xoa(string maLhp)
        {
            return lh_dal.Xoa(maLhp);
        }
        public IQueryable LayDSSinhVienTrong1LopHoc(string maLHP)
        {
            return lh_dal.LayDSSinhVienTrong1LopHoc(maLHP);
        }
    }
}
