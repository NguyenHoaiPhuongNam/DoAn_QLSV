using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;
using ET;

namespace GUI
{
    public partial class frmThoiKhoaBieu_GUI : Form
    {
        ThoiKhoaBieu_BUS tkbBus = new ThoiKhoaBieu_BUS();

        public frmThoiKhoaBieu_GUI()
        {
            InitializeComponent();
        }

        private void frmThoiKhoaBieu_GUI_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDanhSachTKB();
        }

        private void LoadDanhSachTKB()
        {
            dgvTKB.DataSource = tkbBus.LayDSTKB();

            dgvTKB.Columns["maTKB"].HeaderText = "Mã TKB";
            dgvTKB.Columns["maHocPhan"].HeaderText = "Mã Học Phần";
            dgvTKB.Columns["ngayHoc"].HeaderText = "Ngày Học";
            dgvTKB.Columns["gioBatDau"].HeaderText = "Giờ Bắt Đầu";
            dgvTKB.Columns["gioKetThuc"].HeaderText = "Giờ Kết Thúc";
            dgvTKB.Columns["tietBatDau"].HeaderText = "Tiết Bắt Đầu";
            dgvTKB.Columns["tietKetThuc"].HeaderText = "Tiết Kết Thúc";
            dgvTKB.Columns["phong"].HeaderText = "Phòng";

            dgvTKB.AutoResizeColumns();
        }

        private void LoadComboBoxes()
        {
            cboMaHocPhan.DataSource = tkbBus.LayDSHocPhan();
            cboMaHocPhan.DisplayMember = "TenHP";
            cboMaHocPhan.ValueMember = "maHocPhan";
            cboMaHocPhan.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTKB.Text) || 
                cboMaHocPhan.SelectedValue == null || 
                string.IsNullOrWhiteSpace(txtPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numTBD.Value >= numTKT.Value)
            {
                MessageBox.Show("Tiết bắt đầu phải nhỏ hơn tiết kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpGBD.Value >= dtpGKT.Value)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn thêm thời khóa biểu này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var tkbET = new ThoiKhoaBieu_ET(
                    txtTKB.Text,
                    cboMaHocPhan.SelectedValue.ToString(),
                    dtpNgayHoc.Value,
                    dtpGBD.Value.TimeOfDay,
                    dtpGKT.Value.TimeOfDay,
                    (int)numTBD.Value,
                    (int)numTKT.Value,
                    txtPhong.Text
                );

                if (tkbBus.ThemTKB(tkbET))
                {
                    MessageBox.Show("Thêm thời khóa biểu thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachTKB();
                }
                else
                {
                    MessageBox.Show("Thêm thời khóa biểu thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTKB.Text))
            {
                MessageBox.Show("Vui lòng chọn thời khóa biểu cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá trị tiết học
            if (numTBD.Value >= numTKT.Value)
            {
                MessageBox.Show("Tiết bắt đầu phải nhỏ hơn tiết kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá trị giờ học
            if (dtpGBD.Value >= dtpGKT.Value)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin thời khóa biểu này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var tkbET = new ThoiKhoaBieu_ET(
                    txtTKB.Text,
                    cboMaHocPhan.SelectedValue.ToString(),
                    dtpNgayHoc.Value,
                    dtpGBD.Value.TimeOfDay,
                    dtpGKT.Value.TimeOfDay,
                    (int)numTBD.Value,
                    (int)numTKT.Value,
                    txtPhong.Text
                );

                if (tkbBus.SuaTKB(tkbET))
                {
                    MessageBox.Show("Cập nhật thời khóa biểu thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachTKB();
                }
                else
                {
                    MessageBox.Show("Cập nhật thời khóa biểu thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTKB.Text))
            {
                MessageBox.Show("Vui lòng chọn thời khóa biểu cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa thời khóa biểu này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool result = tkbBus.XoaTKB(txtTKB.Text);
                if (result)
                {
                    MessageBox.Show("Xóa thời khóa biểu thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachTKB();
                }
                else
                {
                    MessageBox.Show("Xóa thời khóa biểu thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTKB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTKB.Rows[e.RowIndex];
            txtTKB.Text = row.Cells["maTKB"].Value?.ToString();
            
            string maHP = row.Cells["maHocPhan"].Value?.ToString();
            if (!string.IsNullOrEmpty(maHP))
            {
                cboMaHocPhan.SelectedValue = maHP;
            }
            else
            {
                cboMaHocPhan.SelectedIndex = -1;
            }

            dtpNgayHoc.Value = Convert.ToDateTime(row.Cells["ngayHoc"].Value);
            
            if (row.Cells["gioBatDau"].Value != null)
            {
                TimeSpan gioBD = (TimeSpan)row.Cells["gioBatDau"].Value;
                dtpGBD.Value = DateTime.Today.Add(gioBD);
            }
            
            if (row.Cells["gioKetThuc"].Value != null)
            {
                TimeSpan gioKT = (TimeSpan)row.Cells["gioKetThuc"].Value;
                dtpGKT.Value = DateTime.Today.Add(gioKT);
            }
            
            if (row.Cells["tietBatDau"].Value != null)
            {
                numTBD.Value = Convert.ToDecimal(row.Cells["tietBatDau"].Value);
            }
            
            if (row.Cells["tietKetThuc"].Value != null)
            {
                numTKT.Value = Convert.ToDecimal(row.Cells["tietKetThuc"].Value);
            }
            
            txtPhong.Text = row.Cells["phong"].Value?.ToString();
        }

        private void ResetForm()
        {
            txtTKB.Clear();
            cboMaHocPhan.SelectedIndex = -1;
            dtpNgayHoc.Value = DateTime.Today;
            dtpGBD.Value = DateTime.Today.AddHours(7);
            dtpGKT.Value = DateTime.Today.AddHours(8);
            numTBD.Value = 1;
            numTKT.Value = 2;
            txtPhong.Clear();
            txtTKB.Focus();
        }
    }
}
