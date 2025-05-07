using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Khoa_BUS
    {
        Khoa_DAL kDaL = new Khoa_DAL();
        //Hàm lấy danh sách kha
        public IQueryable LayDSKhoa()
        {
            return kDaL.LayDSKhoa();
        }
        //Hàm kiểm tra ma khoa
        public bool KiemTraTrungMaKhoa(string maKhoa)
        {
            return kDaL.KiemTraTrungMaKhoa(maKhoa);
        }
        //Hàm kiểm tra trùng tên khoa
        public bool KiemTraTrungTenKhoa(string tenKhoa)
        {
            return kDaL.KiemTraTrungTenKhoa(tenKhoa);
        }
        //Hàm thêm khoa
        public bool ThemKhoa(Khoa_ET k)
        {
            return kDaL.ThemKhoa(k);
        }

        //Hàm xóa khoa
        public bool XoaKhoa(string k)
        {
            return kDaL.XoaKhoa(k);
        }

        //Hàm sửa Khoa
        public bool SuaKhoa(Khoa_ET k)
        {
            return kDaL.SuaKhoa(k);
        }
    }
}
