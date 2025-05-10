using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Nganh_BUS
    {

        Nganh_DAL dal = new Nganh_DAL();

        public IQueryable LayDSNganh()
        {
            return dal.LayDSNganh();
        }

        public IQueryable LayDSKhoa()
        {
            return dal.LayDSKhoa();
        }

        public bool KiemTraTrungMaNganh(string maNganh)
        {
            return dal.KiemTraTrungMaNganh(maNganh);
        }

        public bool KiemTraTrungTenNganh(string tenNganh)
        {
            return dal.KiemTraTrungTenNganh(tenNganh);
        }

        public bool KiemTraTrungMaNganhVaMaKhoa(string maNganh, string maKhoa)
        {
            return dal.KiemTraTrungMaNganhVaMaKhoa(maNganh, maKhoa);
        }

        public bool ThemNganh(Nganh_ET n)
        {
            return dal.ThemNganh(n);
        }

        public bool XoaNganh(string maNganh)
        {
            return dal.XoaNganh(maNganh);
        }

        public bool SuaNganh(Nganh_ET nganh)
        {
            return dal.SuaNganh(nganh);
        }
    }
}
