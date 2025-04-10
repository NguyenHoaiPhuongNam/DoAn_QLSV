using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVien_BUS
    {
        SinhVien_DAL svDAL = new SinhVien_DAL();

        public IQueryable LayDSSV()
        {
            return svDAL.LayDSSV();
        }
    }
}
