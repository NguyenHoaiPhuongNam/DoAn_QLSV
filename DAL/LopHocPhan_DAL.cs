using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class LopHocPhan_DAL
    {
        QLSVDataContext db = new QLSVDataContext();
        public IQueryable LayDSLopHocPhan()
        {
            var lhp = from el in db.LopHocPhans
                      join hp in db.HocPhans on el.maHP equals hp.maHocPhan
                      join gv in db.GiangViens on el.magv equals gv.maGiangVien
                      select new
                      {
                          el.maLopHP,
                          el.maHP,
                          hp.tenHocPhan,
                          el.soLuong,
                          el.thongTin,
                          el.magv,
                          el.ngayBatDau,
                          el.ngayKetThuc
                      };
            return lhp;
        }

        public IQueryable LayDSHocPhan()
        {
            var hp = from el in db.HocPhans
                     select el;
            return hp;
        }
        public IQueryable LayDSGV()
        {
            var gv = from el in db.GiangViens
                     select el;
            return gv;
        }
        public bool KiemTraTrungMaLopHP(string maLopHP)
        {
            return db.LopHocPhans.Any(x => x.maLopHP == maLopHP);
        }
        public bool KiemTraTrungMa(string magv, string mahp)
        {
            return db.LopHocPhans.Any(x => x.magv == magv && x.maHP == mahp);
        }

        public bool KiemTraNgay(DateTime nBatDau, DateTime nKetThuc)
        {
            return nBatDau < nKetThuc;
        }
        public bool Them(LopHocPhan_ET lhp)
        {
            // Kiểm tra phân công giảng viên
            bool isValid = db.PhanCongGiangViens.Any(p =>
                p.maHocPhan == lhp.MaHP && p.maGiangVien == lhp.MaGV);

            if (!isValid)
            {
                return false;
            }


            LopHocPhan lop = new LopHocPhan
            {
                maLopHP = lhp.MaLopHP,
                maHP = lhp.MaHP,
                soLuong = lhp.SoLuong,
                thongTin = lhp.ThongTin,
                magv = lhp.MaGV,
                ngayBatDau = lhp.NgayBatDau,
                ngayKetThuc = lhp.NgayKetThuc
            };

            db.LopHocPhans.InsertOnSubmit(lop);
            db.SubmitChanges();
            return true;
        }
        public bool Sua(LopHocPhan_ET lhp)
        {
            var lop = db.LopHocPhans.SingleOrDefault(l => l.maLopHP == lhp.MaLopHP);
            if (lop == null)
            {
                return false;
            }

            bool isValid = db.PhanCongGiangViens.Any(p =>
                p.maHocPhan == lhp.MaHP && p.maGiangVien == lhp.MaGV);
            if (!isValid)
            {
                return false;
            }

            lop.maHP = lhp.MaHP;
            lop.soLuong = lhp.SoLuong;
            lop.thongTin = lhp.ThongTin;
            lop.magv = lhp.MaGV;
            lop.ngayBatDau = lhp.NgayBatDau;
            lop.ngayKetThuc = lhp.NgayKetThuc;

            db.SubmitChanges();
            return true;
        }

        public bool Xoa(string maLopHP)
        {
            var diems = db.DiemHocPhans.Where(d => d.maLopHP == maLopHP).ToList();
            db.DiemHocPhans.DeleteAllOnSubmit(diems);
            var dangKys = db.DangKies.Where(dk => dk.maLopHP == maLopHP).ToList();
            db.DangKies.DeleteAllOnSubmit(dangKys);

            var lop = db.LopHocPhans.SingleOrDefault(l => l.maLopHP == maLopHP);
            if (lop == null)
                return false;

            db.LopHocPhans.DeleteOnSubmit(lop);
            db.SubmitChanges();
            return true;
        }

        public IQueryable LayDSSinhVienTrong1LopHoc(string maLHP)
        {
            var lh = from dk in db.DangKies
                     join lhp in db.LopHocPhans on dk.maLopHP equals lhp.maLopHP
                     join sv in db.SinhViens on dk.maSv equals sv.maSv
                     where lhp.maLopHP == maLHP
                     select new
                     {
                         sv.maSv,
                         sv.hoTen,
                         sv.gioiTinh,
                         sv.lophoc,
                         sv.sdt,
                         sv.email
                     };
            return lh;
        }
    }
}
