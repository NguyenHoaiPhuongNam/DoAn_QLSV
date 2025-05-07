using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienThamGiaSuKien_BUS
    {
        SinhVienThamGiaSuKien_DAL sv_dal = new SinhVienThamGiaSuKien_DAL();
        public IQueryable LayDSSinhVienThamGiaSK()
        {
            return sv_dal.LayDSSinhVienThamGiaSK();
        }
        public bool KiemTraTrungMa(string sv, string sk)
        {
            return sv_dal.KiemTraTrungMa(sv, sk);
        }
        public bool ThemSinhVienThamGia(SinhVienThamGiaSuKien_ET k)
        {
            return sv_dal.ThemSinhVienThamGia(k);
        }
        public bool XoaSinhVienThamGia(string s, string v)
        {
            return sv_dal.XoaSinhVienThamGia(s, v);
        }
        public bool SuaSinhVienThamGiaTheoSK(string k)
        {
            return sv_dal.SuaSinhVienThamGiaTheoSK(k);
        }
        public bool KiemTraTrungMaSK(string sk)
        {
            return sv_dal.KiemTraTrungMaSK(sk);
        }
        public bool SuaSinhVienThamGiaTheoSV(string k)
        {
            return sv_dal.SuaSinhVienThamGiaTheoSV(k);
        }
        public bool KiemTraTrungMaSV(string sv)
        {
            return sv_dal.KiemTraTrungMaSV(sv);
        }
        public IQueryable LayDSSuKien()
        {
            return sv_dal.LayDSSuKien();
        }
        public bool KiemTraTrungMaSVa(string sv)
        {
            return sv_dal.KiemTraTrungMaSVa(sv);
        }
        public IQueryable LayDSSinhVienThamGia1SK(string maSK)
        {
            return sv_dal.LayDSSinhVienThamGia1SK(maSK);
        }
    }
}
