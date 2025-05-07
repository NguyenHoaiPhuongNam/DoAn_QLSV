using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;
using ET;

namespace GUI
{
    public partial class frmNhanVienQuanLy_GUI : Form
    {
        NhanVienQuanLy_BUS nvBus = new NhanVienQuanLy_BUS();

        public frmNhanVienQuanLy_GUI()
        {
            InitializeComponent();
        }

        private void frmNhanVienQuanLy_GUI_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDanhSachNV();
        }

        private void LoadDanhSachNV()
        {
            dgvNVQuanLy.DataSource = nvBus.LayDSNV();

            dgvNVQuanLy.Columns["maNhanVien"].HeaderText = "Mã NV";
            dgvNVQuanLy.Columns["hoTen"].HeaderText = "Họ Tên";
            dgvNVQuanLy.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dgvNVQuanLy.Columns["gioiTinh"].HeaderText = "Giới Tính";
            dgvNVQuanLy.Columns["email"].HeaderText = "Email";
            dgvNVQuanLy.Columns["sdt"].HeaderText = "Số ĐT";
            dgvNVQuanLy.Columns["diaChi"].HeaderText = "Địa Chỉ";
            dgvNVQuanLy.Columns["maKhoa"].HeaderText = "Mã Khoa";
            dgvNVQuanLy.Columns["account"].HeaderText = "Account";

            dgvNVQuanLy.AutoResizeColumns();
        }

        private void LoadComboBoxes()
        {
            cboMaKhoa.DataSource = nvBus.LayDSKhoa();
            cboMaKhoa.DisplayMember = "TenKhoa";
            cboMaKhoa.ValueMember = "maKhoa";
            cboMaKhoa.SelectedIndex = -1;

            cboAccountNVQL.DataSource = nvBus.LayDSAccount();
            cboAccountNVQL.DisplayMember = "TenAccount";
            cboAccountNVQL.ValueMember = "maAccount";
            cboAccountNVQL.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNVQL.Text) || 
                string.IsNullOrWhiteSpace(txtHoTen.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || 
                string.IsNullOrWhiteSpace(txtSdt.Text) || 
                cboMaKhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn thêm nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var nvET = new NhanVienQuanLy_ET(
                    txtMaNVQL.Text,
                    txtHoTen.Text,
                    dtpNgaySinh.Value,
                    rdoNam.Checked ? "Nam" : "Nữ",
                    txtEmail.Text,
                    txtSdt.Text,
                    txtDiaChi.Text,
                    cboMaKhoa.SelectedValue.ToString(),
                    cboAccountNVQL.SelectedValue?.ToString()
                );

                if (nvBus.ThemNV(nvET))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNV();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNVQL.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var nvET = new NhanVienQuanLy_ET(
                    txtMaNVQL.Text,
                    txtHoTen.Text,
                    dtpNgaySinh.Value,
                    rdoNam.Checked ? "Nam" : "Nữ",
                    txtEmail.Text,
                    txtSdt.Text,
                    txtDiaChi.Text,
                    cboMaKhoa.SelectedValue.ToString(),
                    cboAccountNVQL.SelectedValue?.ToString()
                );

                if (nvBus.SuaNV(nvET))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNV();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNVQL.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool result = nvBus.XoaNV(txtMaNVQL.Text);
                if (result)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNV();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNVQuanLy.Rows[e.RowIndex];
            txtMaNVQL.Text = row.Cells["maNhanVien"].Value?.ToString();
            txtHoTen.Text = row.Cells["hoTen"].Value?.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngaySinh"].Value);
            
            string gioiTinh = row.Cells["gioiTinh"].Value?.ToString();
            rdoNam.Checked = gioiTinh == "Nam";
            rdoNu.Checked = gioiTinh == "Nữ";
            
            txtEmail.Text = row.Cells["email"].Value?.ToString();
            txtSdt.Text = row.Cells["sdt"].Value?.ToString();
            txtDiaChi.Text = row.Cells["diaChi"].Value?.ToString();
            
            string maKhoa = row.Cells["maKhoa"].Value?.ToString();
            if (!string.IsNullOrEmpty(maKhoa))
            {
                cboMaKhoa.SelectedValue = maKhoa;
            }
            else
            {
                cboMaKhoa.SelectedIndex = -1;
            }

            string maAcc = row.Cells["account"].Value?.ToString();
            if (!string.IsNullOrEmpty(maAcc))
            {
                cboMaKhoa.SelectedValue = maAcc;
            }
            else
            {
                cboMaKhoa.SelectedIndex = -1;
            }
        }

        private void ResetForm()
        {
            txtMaNVQL.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
            txtEmail.Clear();
            txtSdt.Clear();
            txtDiaChi.Clear();
            cboMaKhoa.SelectedIndex = -1;
            cboAccountNVQL.SelectedIndex = -1;
            txtMaNVQL.Focus();
        }
    }
}
