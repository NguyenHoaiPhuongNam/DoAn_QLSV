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
    public partial class frmhChucVuDoan : Form
    {
        public frmhChucVuDoan()
        {
            InitializeComponent();
        }

        private void dgvChucVuDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ChucVuDoan_BUS cv_BUS = new ChucVuDoan_BUS();
        private void frmhChucVuDoan_Load(object sender, EventArgs e)
        {
            dgvChucVuDoan.DataSource = cv_BUS.LayDSChucVuDoan();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtDiemCong.Text))
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                ChucVuDoan_ET cv = new ChucVuDoan_ET(txtMa.Text, txtTen.Text,Convert.ToInt32(txtDiemCong.Text));
                string maCV = txtMa.Text;
                string tenCV = txtTen.Text;
                if (cv_BUS.KiemTraTrungMaChucVu(maCV))
                {
                    MessageBox.Show("Không được để trùng mã chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cv_BUS.KiemTraTrungTenChucVu(tenCV))
                {
                    MessageBox.Show("Không được để trùng tên chức vụ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cv_BUS.ThemChucVu(cv);
                dgvChucVuDoan.DataSource = cv_BUS.LayDSChucVuDoan();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Không được để trống mã ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo
                   , MessageBoxIcon.Warning);
            try
            {
                if (r == DialogResult.Yes)
                {
                    string k = txtMa.Text;
                    if(cv_BUS.XoaChucVu(k) != null)
                    {
                        dgvChucVuDoan.DataSource = cv_BUS.LayDSChucVuDoan();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không còn chức vụ để xóa ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtDiemCong.Text))
            {
                MessageBox.Show("Không được để trống mã chức vụ, tên chức vụ hoặc điểm cộng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tồn tại mã chức vụ
            if (!cv_BUS.KiemTraTrungMaChucVu(txtMa.Text))
            {
                MessageBox.Show("Không tìm thấy chức vụ để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy tên chức vụ cũ từ dòng đang chọn
            string tenCu = dgvChucVuDoan.CurrentRow.Cells["tenChucVu"].Value.ToString();

            // Kiểm tra trùng tên chức vụ (ngoại trừ chức vụ đang sửa)
            if (!txtTen.Text.Equals(tenCu, StringComparison.OrdinalIgnoreCase) && cv_BUS.KiemTraTrungTenChucVu(txtTen.Text))
            {
                MessageBox.Show("Tên chức vụ đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận trước khi sửa
            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (r == DialogResult.Yes)
                {
                    ChucVuDoan_ET cv = new ChucVuDoan_ET(txtMa.Text, txtTen.Text, Convert.ToInt32(txtDiemCong.Text));
                    bool ketqua = cv_BUS.SuaChucVu(cv);

                    if (ketqua)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvChucVuDoan.DataSource = cv_BUS.LayDSChucVuDoan();
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa chức vụ. Mã hoặc tên chức vụ đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtDiemCong.Clear();
            txtMa.Focus();
        }

        private void frmhChucVuDoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvChucVuDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvChucVuDoan.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtMa.Text = row.Cells["maChucVu"].Value?.ToString();
                    txtTen.Text = row.Cells["tenChucVu"].Value?.ToString();
                    txtDiemCong.Text = row.Cells["diemCong"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
