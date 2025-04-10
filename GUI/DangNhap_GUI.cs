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
    public partial class DangNhap_GUI : Form
    {
        public DangNhap_GUI()
        {
            InitializeComponent();
        }

        private void DangNhap_GUI_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            



            FrmSinhVien_GUI fSV = new FrmSinhVien_GUI();
            fSV.ShowDialog();
        }
    }
}
