using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVien_DAL
    {
        QLSVDataContext db = new QLSVDataContext();


        public IQueryable LayDSSV()
        {
            var sinhVien = from sv in db.SinhViens
                           select sv;
            return sinhVien;
        }

    }
}
