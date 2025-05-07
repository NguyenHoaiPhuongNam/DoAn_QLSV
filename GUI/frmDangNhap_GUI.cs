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
            



            FrmSinhVienChinh_GUI fSV = new FrmSinhVienChinh_GUI();
            fSV.ShowDialog();
        }
    }
}
