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
    public partial class frmThongTin1GiangVien : Form
    {
        public frmThongTin1GiangVien()
        {
            InitializeComponent();
        }
        GiangVien_BUS gvBus = new GiangVien_BUS();

        private void frmThongTin1GiangVien_Load(object sender, EventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            GiangVien_ET gv = gvBus.ThongTin1GiangVien(txtMaGv.Text).FirstOrDefault();
            if(gv == null)
            {
                MessageBox.Show("Không tìm thấy mã", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                lbTen.Text = gv.HoTen;
                lbNS.Text = gv.NgaySinh.ToString("dd/MM/yyyy");
                lbGT.Text = gv.GioiTinh;
                lbEmail.Text = gv.Email;
                lbSDT.Text = gv.SDT;
                lbDC.Text = gv.DiaChi;
                lbMaKhoa.Text = gv.MaKhoa;
                btnInTT.Enabled = true;
            }
        }

        private void frmThongTin1GiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
