using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienThuNgan_DAL
    {
        QLSVDataContext db = new QLSVDataContext();
        public IQueryable LayDSNhanVienThuNgan()
        {
            var nv = from el in db.NhanVienThuNgans
                     join a in db.Accounts on el.account equals a.maAccount
                     select new
                     {
                         el.maNhanVien,
                         el.hoTen,
                         el.ngaySinh,
                         el.gioiTinh,
                         el.email,
                         el.sdt,
                         el.diaChi,
                         el.account
                     };
            return nv;           
        }

        //Hàm kiểm tra mã nhân viên 
        public bool KiemTraTrungMaNhanVien(string maNV)
        {
            return db.NhanVienThuNgans.Any(x => x.maNhanVien == maNV);
        }
        //Hàm kiểm tra email nhân viên
        public bool KiemTraTrungEmailNhanVien(string email)
        {
            return db.NhanVienThuNgans.Any(x => x.email == email);
        }
        //Hàm kiểm tra số điện thoại nhân viên
        public bool KiemTraTrungSDTNhanVien(string soDT)
        {
            return db.NhanVienThuNgans.Any(x => x.sdt == soDT);
        }
        public bool KiemTraMaAACCount(string maAccount)
        {
            return db.Accounts.Any(x => x.maAccount == maAccount);
        }
        public bool KiemTraAccountNhanVien(string maaccount)
        {
            using (QLSVDataContext context = new QLSVDataContext())
            {
                // true nếu maAccount tồn tại trong bảng Account và chưa được dùng trong NhanVienThuNgan
                return context.Accounts.Any(a => a.maAccount == maaccount)
                    && !context.NhanVienThuNgans.Any(nv => nv.account == maaccount);
            }
        }
        public bool Them(NhanVienThuNgan_ET nv)
        {
            try
            {
                NhanVienThuNgan moi = new NhanVienThuNgan
                {
                    maNhanVien = nv.MaNhanVien,
                    hoTen = nv.HoTen,
                    ngaySinh = nv.NgaySinh,
                    gioiTinh = nv.GT,
                    email = nv.Email,
                    sdt = nv.SDT,
                    diaChi = nv.DiaChi,
                    account = nv.Accounta
                };

                db.NhanVienThuNgans.InsertOnSubmit(moi);
                db.SubmitChanges();
                return true;
            }
            catch
            { 
                return false;
            }
        }
        public bool Xoa(string maNhanVien)
        {
            try
            {
                // Xóa học phí liên quan trước
                var hocPhis = db.HocPhis.Where(hp => hp.maNv == maNhanVien);
                db.HocPhis.DeleteAllOnSubmit(hocPhis);

                // Sau đó mới xóa nhân viên
                var nv = db.NhanVienThuNgans.SingleOrDefault(x => x.maNhanVien == maNhanVien);
                if (nv == null)
                {
                    return false;
                }

                db.NhanVienThuNgans.DeleteOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Sua(NhanVienThuNgan_ET nv)
        {
            try
            {
                var sua = db.NhanVienThuNgans.SingleOrDefault(x => x.maNhanVien == nv.MaNhanVien);
                if (sua == null) return false;

                sua.hoTen = nv.HoTen;
                sua.ngaySinh = nv.NgaySinh;
                sua.gioiTinh = nv.GT;
                sua.email = nv.Email;
                sua.sdt = nv.SDT;
                sua.diaChi = nv.DiaChi;
                sua.account = nv.Accounta;

                db.SubmitChanges();
                return true;
            }
            catch 
            {
                return false; 
            }
        }

        public IQueryable<NhanVienThuNgan_ET> LayThongTin1NhanVien(string manv)

        {
            var gv1 = from nv in db.NhanVienThuNgans
                      where nv.maNhanVien == manv
                      select new NhanVienThuNgan_ET
                      {
                          MaNhanVien = nv.maNhanVien,
                          HoTen = nv.hoTen,
                          NgaySinh = (DateTime)nv.ngaySinh,
                          GT = nv.gioiTinh,
                          Email = nv.email,
                          SDT = nv.sdt,
                          DiaChi = nv.diaChi,
                          Accounta = nv.account
                      };
            return gv1;
        }
    }
}
