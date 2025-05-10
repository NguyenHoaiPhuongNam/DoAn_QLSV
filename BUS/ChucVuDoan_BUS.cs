using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVuDoan_BUS
    {
        ChucVuDoan_DAL cv_dal = new ChucVuDoan_DAL();
        public IQueryable LayDSChucVuDoan()
        {
            return cv_dal.LayDSChucVuDoan();
        }
        //Hàm kiểm tra ma chức vụ
        public bool KiemTraTrungMaChucVu(string maCV)
        {
            return cv_dal.KiemTraTrungMaChucVu(maCV);
        }
        //Hàm kiểm tra trùng tên chức vụ
        public bool KiemTraTrungTenChucVu(string tenChucVu)
        {
            return cv_dal.KiemTraTrungTenChucVu(tenChucVu);
        }
        //Hàm thêm ChucVu
        public bool ThemChucVu(ChucVuDoan_ET cv)
        {
            return cv_dal.ThemChucVu(cv);
        }

        //Hàm xóa Chức vụ
        public bool XoaChucVu(string k)
        {
            return cv_dal.XoaChucVu(k);
        }

        //Hàm sửa Chức Vụ
        public bool SuaChucVu(ChucVuDoan_ET cv)
        {
            return cv_dal.SuaChucVu(cv);
        }
    }
}
