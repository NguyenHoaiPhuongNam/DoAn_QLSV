using BUS;
using ET;
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
    public partial class frmThongTin1NhanVienThuNgan : Form
    {
        public frmThongTin1NhanVienThuNgan()
        {
            InitializeComponent();
        }
        NhanVienThuNgan_BUS nv_bus = new NhanVienThuNgan_BUS();
        private void frmThongTin1NhanVienThuNgan_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            NhanVienThuNgan_ET gv = nv_bus.LayThongTin1NhanVien(txtMaGv.Text).FirstOrDefault();
            if (gv == null)
            {
                MessageBox.Show("Không tìm thấy mã", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                lbTen.Text = gv.HoTen;
                lbNS.Text = gv.NgaySinh.ToString("dd/MM/yyyy");
                lbGT.Text = gv.GT;
                lbEmail.Text = gv.Email;
                lbSDT.Text = gv.SDT;
                lbDC.Text = gv.DiaChi;
                btnInTT.Enabled = true;
            }
        }
    }
}
