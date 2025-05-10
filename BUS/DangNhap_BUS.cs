using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhap_BUS
    {
        DangNhap_DAL dangNhap_DAL = new DangNhap_DAL();
        public string KT_TaiKhoanSinhVien(string username, string password)
        {
            return dangNhap_DAL.KT_TaiKhoanSinhVien(username, password);
        }

        public string LayMaAccount(string username, string password)
        {
            return dangNhap_DAL.LayMaAccount(username, password);
        }

        public string LayMaNguoiDungTheoAccount(string maAccount)
        {
            return dangNhap_DAL.LayMaNguoiDung(maAccount);
        }

    }
}
