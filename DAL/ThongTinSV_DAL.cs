using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongTinSV_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        public SinhVien_ET LaySinhVienTheoAccount(string maAccount)
        {
            var sv = db.SinhViens.FirstOrDefault(s => s.account == maAccount);
            if (sv != null)
            {
                return new SinhVien_ET
                {
                    MaSv = sv.maSv,
                    HoTen = sv.hoTen,
                    NgaySinh = sv.ngaySinh,
                    GioiTinh = sv.gioiTinh,
                    Email = sv.email,
                    Sdt = sv.sdt,
                    DiaChi = sv.diaChi,
                    Lophoc = sv.lophoc,
                    Account = sv.account
                };
            }
            return null;
        }

    }
}
