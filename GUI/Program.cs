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

            //frmDangNhap_GUI frmLogin = new frmDangNhap_GUI();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //    string loaiTK = frmLogin.LoaiTaiKhoan;
            //    string maAccount = frmLogin.MaAccountDangNhap;

            //    switch (loaiTK)
            //    {
            //        case "Sinh viên":
            //            Application.Run(new FrmSinhVienChinh_GUI(maAccount));
            //            break;

            //        case "Nhân viên quản lý":
            //            Application.Run(new FormNhanVienQL(maAccount));
            //            break;

            //        case "Admin":
            //            Application.Run(new FormAdmin(maAccount)); ----Đăng nhập phân quyền
            //             break;

            //        default:
            //            MessageBox.Show("Loại tài khoản không xác định.");
            //            break;
            //    }
            //}
             Application.Run(new FrmEditSuKien()); // ---Đăng nhập 1 form bất kỳ

        }
    }
}
