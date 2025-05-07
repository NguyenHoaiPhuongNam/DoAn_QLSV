using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;
using ET;

namespace GUI
{
    public partial class frmSinhVienn_GUI : Form
    {
        SinhVienn_BUS svBus = new SinhVienn_BUS();

        public frmSinhVienn_GUI()
        {
            InitializeComponent();
        }

        private void frmSinhVien_GUI_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDanhSachSinhVien();
        }

        private void LoadDanhSachSinhVien()
        {
            dgvSinhVien.DataSource = svBus.LayDSSV();

            // Đặt lại tên cột hiển thị
            dgvSinhVien.Columns["maSv"].HeaderText = "Mã SV";
            dgvSinhVien.Columns["hoTen"].HeaderText = "Họ Tên";
            dgvSinhVien.Columns["ngaySinh"].HeaderText = "Ngày Sinh";
            dgvSinhVien.Columns["gioiTinh"].HeaderText = "Giới Tính";
            dgvSinhVien.Columns["email"].HeaderText = "Email";
            dgvSinhVien.Columns["sdt"].HeaderText = "Số ĐT";
            dgvSinhVien.Columns["diaChi"].HeaderText = "Địa Chỉ";
            dgvSinhVien.Columns["lophoc"].HeaderText = "Lớp";
            dgvSinhVien.Columns["account"].HeaderText = "Account";      
         
        }

        private void LoadComboBoxes()
        {
            cboLopHoc.DataSource = svBus.LayDSLopHoc();
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "maLop";
            cboLopHoc.SelectedIndex = -1;

            cboAccountSV.DataSource = svBus.LayDSAccount();
            cboAccountSV.DisplayMember = "TenAccount";
            cboAccountSV.ValueMember = "maAccount";
            cboAccountSV.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSdt.Text) ||
                cboLopHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn thêm sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var svET = new SinhVienn_ET(
                    txtMaSV.Text,
                    txtHoTen.Text,
                    dtpNgaySinh.Value,
                    rdoNam.Checked ? "Nam" : "Nữ",
                    txtEmail.Text,
                    txtSdt.Text,
                    txtDiaChi.Text,
                    cboLopHoc.SelectedValue.ToString(),
                    cboAccountSV.SelectedValue?.ToString()
                );

                if (svBus.ThemSV(svET))
                {
                    MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSinhVien();
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var svET = new SinhVienn_ET(
                    txtMaSV.Text,
                    txtHoTen.Text,
                    dtpNgaySinh.Value,
                    rdoNam.Checked ? "Nam" : "Nữ",
                    txtEmail.Text,
                    txtSdt.Text,
                    txtDiaChi.Text,
                    cboLopHoc.SelectedValue?.ToString(),
                    cboAccountSV.SelectedValue?.ToString()
                );

                if (svBus.SuaSV(svET))
                {
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSinhVien();
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool result = svBus.XoaSV(txtMaSV.Text);
                if (result)
                {
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachSinhVien();
                }
                else
                {
                    MessageBox.Show("Xóa sinh viên thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
            txtMaSV.Text = row.Cells["maSv"].Value?.ToString();
            txtHoTen.Text = row.Cells["hoTen"].Value?.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngaySinh"].Value);
            
            string gioiTinh = row.Cells["gioiTinh"].Value?.ToString();
            rdoNam.Checked = gioiTinh == "Nam";
            rdoNu.Checked = gioiTinh == "Nữ";
            
            txtEmail.Text = row.Cells["email"].Value?.ToString();
            txtSdt.Text = row.Cells["sdt"].Value?.ToString();
            txtDiaChi.Text = row.Cells["diaChi"].Value?.ToString();
            
            string maLop = row.Cells["lophoc"].Value?.ToString();
            if (!string.IsNullOrEmpty(maLop))
            {
                cboLopHoc.SelectedValue = maLop;
            }
            else
            {
                cboLopHoc.SelectedIndex = -1;
            }

            string maAcc = row.Cells["account"].Value?.ToString();
            if (!string.IsNullOrEmpty(maAcc))
            {
                cboAccountSV.SelectedValue = maAcc;
            }
            else
            {
                cboAccountSV.SelectedIndex = -1;
            }
        }

        private void ResetForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
            txtEmail.Clear();
            txtSdt.Clear();
            txtDiaChi.Clear();
            cboLopHoc.SelectedIndex = -1;
            cboAccountSV.SelectedIndex = -1;
            txtMaSV.Focus();
        }

        private void btnThongTin1SV_Click(object sender, EventArgs e)
        {
            frmThongTin1SV frm = new frmThongTin1SV();
            frm.Show();
        }
    }
}
