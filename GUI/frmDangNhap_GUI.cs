using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap_GUI : Form
    {
        public frmDangNhap_GUI()
        {
            InitializeComponent();
        }
        DangNhap_BUS dangNhap_BUS = new DangNhap_BUS();
        private void DangNhap_GUI_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string LoaiTaiKhoan { get; private set; }


        public string MaAccountDangNhap { get; private set; }



        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                return;
            }

            try
            {
                string trangThai = dangNhap_BUS.KT_TaiKhoanSinhVien(username, password);
                string maAccount = dangNhap_BUS.LayMaAccount(username, password);
                MaAccountDangNhap = maAccount;


                if (trangThai == null)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                    return;
                }

                LoaiTaiKhoan = trangThai;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
            }
        }
    }
}
