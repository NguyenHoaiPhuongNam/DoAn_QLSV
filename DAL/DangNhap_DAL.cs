using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhap_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public string KT_TaiKhoanSinhVien(string username, string password)
        {
            var acc = db.Accounts
                        .Where(a => a.username == username && a.pword == password)
                        .FirstOrDefault();

            if (acc != null)
            {
                return acc.trangthai;
            }

            return null;
        }
        public string LayMaAccount(string username, string password)
        {
            var acc = db.Accounts.FirstOrDefault(a => a.username == username && a.pword == password);
            if (acc != null)
                return acc.maAccount;
            return null;
        }

        public string LayMaNguoiDung(string maAccount)
        {
            var sv = db.SinhViens.FirstOrDefault(s => s.account == maAccount);
            if (sv != null)
                return sv.maSv;

            var nvql = db.NhanVienQuanLies.FirstOrDefault(nv => nv.account == maAccount);
            if (nvql != null)
                return nvql.maNhanVien;

            var nvtn = db.NhanVienThuNgans.FirstOrDefault(nv => nv.account == maAccount);
            if (nvtn != null)
                return nvtn.maNhanVien;

            return null; 
        }

    }
}
