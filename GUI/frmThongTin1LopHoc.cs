using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTin1LopHoc : Form
    {
        public frmThongTin1LopHoc()
        {
            InitializeComponent();
        }

        private void frmThongTin1LopHoc_Load(object sender, EventArgs e)
        {

        }
        LopHoc_BUS lh_BUS = new LopHoc_BUS();
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (lh_BUS.KiemTraTrungMaLopHoc(txtMaLop.Text))
            {
                dgvSV.DataSource = lh_BUS.ThongTin1LopHoc(txtMaLop.Text);
                btnDS.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp học", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
