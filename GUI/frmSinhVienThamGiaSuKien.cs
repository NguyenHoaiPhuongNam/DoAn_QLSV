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
    public partial class frmSinhVienThamGiaSuKien : Form
    {
        public frmSinhVienThamGiaSuKien()
        {
            InitializeComponent();
        }
        SinhVienThamGiaSuKien_BUS sv = new SinhVienThamGiaSuKien_BUS();
        private void frmSinhVienThamGiaSuKien_Load(object sender, EventArgs e)
        {
            dgvThamGia.DataSource = sv.LayDSSinhVienThamGiaSK();
            cboMaSK.DataSource = sv.LayDSSuKien();
            cboMaSK.DisplayMember = "tenSK";
            cboMaSK.ValueMember = "maSK";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || cboMaSK.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SinhVienThamGiaSuKien_ET k = new SinhVienThamGiaSuKien_ET(txtMaSV.Text, cboMaSK.SelectedValue.ToString());
                string maSV = txtMaSV.Text;
                string maSK = cboMaSK.SelectedValue.ToString();
                if (sv.KiemTraTrungMa(maSV,maSK))
                {
                    MessageBox.Show($"Sinh viên {maSV} đã tham gia {maSK} rồi!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!sv.KiemTraTrungMaSVa(maSV))
                {
                    MessageBox.Show($"Sinh viên {maSV} không có ở trong hệ thống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                sv.ThemSinhVienThamGia(k);
                dgvThamGia.DataSource = sv.LayDSSinhVienThamGiaSK();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || cboMaSK.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning);
            try
            {
                if (r == DialogResult.Yes)
                {
                    string k = txtMaSV.Text;
                    string sk = cboMaSK.SelectedValue.ToString();
                    sv.XoaSinhVienThamGia(k,sk);
                    dgvThamGia.DataSource = sv.LayDSSinhVienThamGiaSK();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtMaSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || cboMaSK.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV_moi = txtMaSV.Text.Trim();
            string maSK_moi = cboMaSK.SelectedValue.ToString();

            // Kiểm tra sinh viên mới có tồn tại trong hệ thống không
            if (!sv.KiemTraTrungMaSVa(maSV_moi))
            {
                MessageBox.Show($"Sinh viên {maSV_moi} không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra bản ghi mới có bị trùng không (nếu khác khóa cũ)
            if ((maSV_moi != maSV_cu || maSK_moi != maSK_cu) && sv.KiemTraTrungMa(maSV_moi, maSK_moi))
            {
                MessageBox.Show("Bản ghi mới đã tồn tại. Không thể sửa thành trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            try
            {
                // Xóa bản ghi cũ
                if (!sv.XoaSinhVienThamGia(maSV_cu, maSK_cu))
                {
                    MessageBox.Show("Không tìm thấy bản ghi cũ để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm bản ghi mới
                SinhVienThamGiaSuKien_ET k = new SinhVienThamGiaSuKien_ET(maSV_moi, maSK_moi);
                sv.ThemSinhVienThamGia(k);
                dgvThamGia.DataSource = sv.LayDSSinhVienThamGiaSK();

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThoata_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSinhVienThamGiaSuKien_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDSSinhVienThamGiaSuKien f2 = new frmDSSinhVienThamGiaSuKien();
            f2.ShowDialog();
            this.Show();
        }

        private string maSV_cu;
        private string maSK_cu;

        private void dgvThamGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThamGia.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["maSV"].Value.ToString();
                cboMaSK.SelectedValue = row.Cells["maSK"].Value.ToString();

                // Ghi nhớ khóa cũ
                maSV_cu = txtMaSV.Text;
                maSK_cu = cboMaSK.SelectedValue.ToString();
            }
        }
    }
}
