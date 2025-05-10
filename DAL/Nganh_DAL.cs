using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Nganh_DAL
    {
        QLSVDataContext db = new QLSVDataContext();

        //Hàm lấy danh sách các ngành
        public IQueryable LayDSNganh()
        {
            return from el in db.Nganhs
                   join k in db.Khoas on el.maKhoa equals k.maKhoa
                   select new
                   {
                       el.maKhoa,
                       k.tenKhoa,
                       el.maNganh,
                       el.tenNganh,
                       el.heDaoTao,
                       el.soNamHoc
                   };
        }

        public IQueryable LayDSKhoa()
        {
            return db.Khoas.Select(k => k);
        }

        public bool KiemTraTrungMaNganh(string maNganh)
        {
            return db.Nganhs.Any(n => n.maNganh == maNganh);
        }

        public bool KiemTraTrungTenNganh(string tenNganh)
        {
            return db.Nganhs.Any(n => n.tenNganh == tenNganh);
        }

        public bool KiemTraTrungMaNganhVaMaKhoa(string maNganh, string maKhoa)
        {
            return db.Nganhs.Any(n => n.maNganh == maNganh && n.maKhoa == maKhoa);
        }

        public bool ThemNganh(Nganh_ET n)
        {
            try
            {
                Nganh na = new Nganh()
                {
                    maKhoa = n.MaKhoa,
                    maNganh = n.MaNganh,
                    tenNganh = n.TenNganh,
                    heDaoTao = n.HeDaoTao,
                    soNamHoc = n.SoNamHoc
                };
                db.Nganhs.InsertOnSubmit(na);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false; 
            }
        }

        public bool XoaNganh(string maNganh)
        {
            try
            {
                var lopHocs = db.LopHocs.Where(lh => lh.maNganh == maNganh).ToList();
                foreach (var lh in lopHocs)
                {
                    lh.maNganh = null;
                }

                var na = db.Nganhs.FirstOrDefault(x => x.maNganh == maNganh);
                if (na != null)
                {
                    db.Nganhs.DeleteOnSubmit(na);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            { 
                return false; 
            }
        }

        public bool SuaNganh(Nganh_ET nganh)
        {
            try
            {
                var na = db.Nganhs.FirstOrDefault(x => x.maNganh == nganh.MaNganh );
                if (na != null)
                {
                    na.maKhoa = nganh.MaKhoa;
                    na.tenNganh = nganh.TenNganh;
                    na.heDaoTao = nganh.HeDaoTao;
                    na.soNamHoc = nganh.SoNamHoc;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false; 
            }
        }
    }
}
