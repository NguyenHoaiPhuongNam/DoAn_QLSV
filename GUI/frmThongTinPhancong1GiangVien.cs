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
    public partial class frmThongTinPhancong1GiangVien : Form
    {
        public frmThongTinPhancong1GiangVien()
        {
            InitializeComponent();
        }
        PhanCongGiangVien_BUS pc_bus = new PhanCongGiangVien_BUS();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (pc_bus.KiemTraMaGv(txtMa.Text))
            {
                dgvMH.DataSource = pc_bus.LayDSPhanCong1GV(txtMa.Text);
                btnInDS.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp học", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
