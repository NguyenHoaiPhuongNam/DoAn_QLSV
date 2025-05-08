using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DangNhap_GUI frmLogin = new DangNhap_GUI();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    string loaiTK = frmLogin.LoaiTaiKhoan;
            //    string maAccount = frmLogin.MaAccountDangNhap;

            //    switch (loaiTK)
            //    {
            //        case "Sinh viên":
            //            Application.Run(new FrmSinhVien_GUI(maAccount));
            //            break;

            //        // case "Nhân viên quản lý":
            //        //     Application.Run(new FormNhanVienQL(maAccount));
            //        //     break;

            //        // case "Admin":
            //        //     Application.Run(new FormAdmin(maAccount));
            //        //     break;

            //        default:
            //            MessageBox.Show("Loại tài khoản không xác định.");
            //            break;
            //    }
            //}
            Application.Run(new FrmEditHocKy_GUI());
            
        }
    }
}
