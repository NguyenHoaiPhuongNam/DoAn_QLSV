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
    public partial class frmSinhVienTrong1LopHocPhan : Form
    {
        public frmSinhVienTrong1LopHocPhan()
        {
            InitializeComponent();
        }
        LopHocPhan_BUS lh_BUs = new LopHocPhan_BUS();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (lh_BUs.KiemTraTrungMaLopHP(txtMa.Text))
            {
                dgvLopHoc.DataSource = lh_BUs.LayDSSinhVienTrong1LopHoc(txtMa.Text);
                btnInDS.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp học", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
