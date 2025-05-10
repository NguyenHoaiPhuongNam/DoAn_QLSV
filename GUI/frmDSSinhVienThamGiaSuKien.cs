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
    public partial class frmDSSinhVienThamGiaSuKien : Form
    {
        public frmDSSinhVienThamGiaSuKien()
        {
            InitializeComponent();
        }
        SinhVienThamGiaSuKien_BUS sv_bus = new SinhVienThamGiaSuKien_BUS();
        private void frmDSSinhVienThamGiaSuKien_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (sv_bus.KiemTraTrungMaSK(txtSK.Text))
            {
                dgvThamGia.DataSource = sv_bus.LayDSSinhVienThamGia1SK(txtSK.Text);
                btnDS.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy lớp học", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
