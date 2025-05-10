using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongTinSV_BUS
    {
        ThongTinSV_DAL ttSV_DAL = new ThongTinSV_DAL();

        public SinhVienn_ET LaySinhVienTheoAccount(string maAccount)
        {
            return ttSV_DAL.LaySinhVienTheoAccount(maAccount);
        }

    }
}
