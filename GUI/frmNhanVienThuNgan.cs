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
    public partial class frmNhanVienThuNgan : Form
    {
        public frmNhanVienThuNgan()
        {
            InitializeComponent();
        }
        NhanVienThuNgan_BUS nv_BUS = new NhanVienThuNgan_BUS();
        private void frmNhanVienThuNgan_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = nv_BUS.LayDSNhanVienThuNgan();

        }
        string maNV_cu; // Để lưu mã khi sửa
        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvNV.Rows[e.RowIndex];

                    txtMaNV.Text = row.Cells["maNhanVien"].Value.ToString();
                    txtHoTen.Text = row.Cells["hoTen"].Value.ToString();
                    dtNgaySinh.Value = Convert.ToDateTime(row.Cells["ngaySinh"].Value);

                    if (row.Cells["gioiTinh"].Value.ToString().Trim() == "Nam")
                    {
                        rdoNam.Checked = true;
                    }
                    else
                    {
                        rdoNu.Checked = true;
                    }

                    txtEmail.Text = row.Cells["email"].Value.ToString();
                    txtSDT.Text = row.Cells["sdt"].Value.ToString();
                    txtDc.Text = row.Cells["diaChi"].Value.ToString();
                    txtMaAccont.Text = row.Cells["account"].Value.ToString();

                    maNV_cu = txtMaNV.Text.Trim(); // Ghi nhớ mã cũ để sửa
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string accont = txtMaAccont.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtMaNV.Text)|| string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDc.Text) || string.IsNullOrWhiteSpace(txtMaAccont.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) ||
                (!rdoNam.Checked && !rdoNu.Checked))
            {

                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nv_BUS.KiemTraTrungMa(ma))
            {
                MessageBox.Show("Mã nhân viên không được trùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nv_BUS.KiemTraTrungEmail(email))
            {
                MessageBox.Show("Email nhân viên không được trùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nv_BUS.KiemTraTrungSDT(sdt))
            {
                MessageBox.Show("Số điện thoại nhân viên không được trùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!nv_BUS.KiemTraMaAACCount(accont))
            {
                MessageBox.Show("Account nhân viên không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!nv_BUS.KiemTraAccountNhanVien(accont))
            {
                MessageBox.Show("Account đã được dùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhanVienThuNgan_ET nv = new NhanVienThuNgan_ET(
                ma,
                txtHoTen.Text.Trim(),
                dtNgaySinh.Value,
                rdoNam.Checked ? "Nam" : "Nữ",
                txtEmail.Text.Trim(),
                txtSDT.Text.Trim(),
                txtDc.Text.Trim(),
                txtMaAccont.Text.Trim()
            );

            try
            {
                if (nv_BUS.Them(nv))
                {
                    MessageBox.Show($"Thêm thành công", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNV.DataSource = nv_BUS.LayDSNhanVienThuNgan();
                }
                else
                {
                    MessageBox.Show("Lỗi !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên có mã: {ma} không? Nếu xóa sẽ mất toàn bộ học phí nhân viên này đảm nhiệm", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (nv_BUS.Xoa(ma))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNV.DataSource = nv_BUS.LayDSNhanVienThuNgan();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string account = txtMaAccont.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(txtDc.Text) || string.IsNullOrWhiteSpace(account) ||
                (!rdoNam.Checked && !rdoNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem nhân viên đang sửa có tồn tại không
            if (!nv_BUS.KiemTraTrungMa(ma))
            {
                MessageBox.Show("Không tìm thấy nhân viên để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu email thay đổi thì kiểm tra trùng
            if (nv_BUS.KiemTraTrungEmail(email) && email != dgvNV.CurrentRow.Cells["email"].Value.ToString())
            {
                MessageBox.Show("Email đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu sdt thay đổi thì kiểm tra trùng
            if (nv_BUS.KiemTraTrungSDT(sdt) && sdt != dgvNV.CurrentRow.Cells["sdt"].Value.ToString())
            {
                MessageBox.Show("Số điện thoại đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu account thay đổi thì kiểm tra
            string accountCu = dgvNV.CurrentRow.Cells["account"].Value.ToString();
            if (!string.Equals(account, accountCu.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                if (!nv_BUS.KiemTraMaAACCount(account))
                {
                    MessageBox.Show("Account không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!nv_BUS.KiemTraAccountNhanVien(account))
                {
                    MessageBox.Show("Account đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            NhanVienThuNgan_ET nv = new NhanVienThuNgan_ET(
                ma,
                txtHoTen.Text.Trim(),
                dtNgaySinh.Value,
                rdoNam.Checked ? "Nam" : "Nữ",
                email,
                sdt,
                txtDc.Text.Trim(),
                account
            );

            try
            {
                if (nv_BUS.Sua(nv))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNV.DataSource = nv_BUS.LayDSNhanVienThuNgan();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThong_Tin_NV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTin1NhanVienThuNgan f2 = new frmThongTin1NhanVienThuNgan();
            f2.ShowDialog();
            this.Show();
        }
    }
}
