using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;
using ET;

namespace GUI
{
    public partial class frmSinhVienVPHocVu_GUI : Form
    {
        SinhVienVPHocVu_BUS vpBus = new SinhVienVPHocVu_BUS();

        public frmSinhVienVPHocVu_GUI()
        {
            InitializeComponent();
        }

        private void frmSinhVienVPHocVu_GUI_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadDanhSachViPham();
        }

        private void LoadDanhSachViPham()
        {
            dgvSVVPHocVu.DataSource = vpBus.LayDSVP();

            dgvSVVPHocVu.Columns["maViPham"].HeaderText = "Mã Vi Phạm";
            dgvSVVPHocVu.Columns["maSv"].HeaderText = "Mã SV";
            dgvSVVPHocVu.Columns["maHocKy"].HeaderText = "Mã Học Kỳ";
            dgvSVVPHocVu.Columns["ngayViPham"].HeaderText = "Ngày Vi Phạm";
            dgvSVVPHocVu.Columns["loaiViPham"].HeaderText = "Loại Vi Phạm";
            dgvSVVPHocVu.Columns["moTa"].HeaderText = "Mô Tả";
            dgvSVVPHocVu.Columns["hinhThucXuLy"].HeaderText = "Hình Thức Xử Lý";
            dgvSVVPHocVu.Columns["diemTru"].HeaderText = "Điểm Trừ";

            dgvSVVPHocVu.AutoResizeColumns();
        }

        private void LoadComboBoxes()
        {
            cboMaSV.DataSource = vpBus.LayDSSV();
            cboMaSV.DisplayMember = "TenSV";
            cboMaSV.ValueMember = "maSv";
            cboMaSV.SelectedIndex = -1;

            cboHocKy.DataSource = vpBus.LayDSHocKy();
            cboHocKy.DisplayMember = "TenHK";
            cboHocKy.ValueMember = "maHocKy";
            cboHocKy.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaViPham.Text) || 
                cboMaSV.SelectedValue == null || 
                cboHocKy.SelectedValue == null || 
                string.IsNullOrWhiteSpace(txtLoaiViPham.Text) || 
                string.IsNullOrWhiteSpace(txtHinhThucXuLy.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn thêm vi phạm này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var vpET = new SinhVienVPHocVu_ET(
                    txtMaViPham.Text,
                    cboMaSV.SelectedValue.ToString(),
                    cboHocKy.SelectedValue.ToString(),
                    dtpNgayViPham.Value,
                    txtLoaiViPham.Text,
                    txtMoTa.Text,
                    txtHinhThucXuLy.Text,
                    (int)numDiemTru.Value
                );

                if (vpBus.ThemVP(vpET))
                {
                    MessageBox.Show("Thêm vi phạm thành công!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachViPham();
                }
                else
                {
                    MessageBox.Show("Thêm vi phạm thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaViPham.Text))
            {
                MessageBox.Show("Vui lòng chọn vi phạm cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn cập nhật thông tin vi phạm này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                var vpET = new SinhVienVPHocVu_ET(
                    txtMaViPham.Text,
                    cboMaSV.SelectedValue.ToString(),
                    cboHocKy.SelectedValue.ToString(),
                    dtpNgayViPham.Value,
                    txtLoaiViPham.Text,
                    txtMoTa.Text,
                    txtHinhThucXuLy.Text,
                    (int)numDiemTru.Value
                );

                if (vpBus.SuaVP(vpET))
                {
                    MessageBox.Show("Cập nhật vi phạm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachViPham();
                }
                else
                {
                    MessageBox.Show("Cập nhật vi phạm thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaViPham.Text))
            {
                MessageBox.Show("Vui lòng chọn vi phạm cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa vi phạm này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool result = vpBus.XoaVP(txtMaViPham.Text);
                if (result)
                {
                    MessageBox.Show("Xóa vi phạm thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachViPham();
                }
                else
                {
                    MessageBox.Show("Xóa vi phạm thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvSVVPHocVu.Rows[e.RowIndex];
            txtMaViPham.Text = row.Cells["maViPham"].Value?.ToString();
            
            string maSV = row.Cells["maSv"].Value?.ToString();
            if (!string.IsNullOrEmpty(maSV))
            {
                cboMaSV.SelectedValue = maSV;
            }
            else
            {
                cboMaSV.SelectedIndex = -1;
            }

            string maHK = row.Cells["maHocKy"].Value?.ToString();
            if (!string.IsNullOrEmpty(maHK))
            {
                cboHocKy.SelectedValue = maHK;
            }
            else
            {
                cboHocKy.SelectedIndex = -1;
            }

            dtpNgayViPham.Value = Convert.ToDateTime(row.Cells["ngayViPham"].Value);
            txtLoaiViPham.Text = row.Cells["loaiViPham"].Value?.ToString();
            txtMoTa.Text = row.Cells["moTa"].Value?.ToString();
            txtHinhThucXuLy.Text = row.Cells["hinhThucXuLy"].Value?.ToString();
            
            int diemTru = 0;
            int.TryParse(row.Cells["diemTru"].Value?.ToString(), out diemTru);
            numDiemTru.Value = diemTru;
        }

        private void ResetForm()
        {
            txtMaViPham.Clear();
            cboMaSV.SelectedIndex = -1;
            cboHocKy.SelectedIndex = -1;
            dtpNgayViPham.Value = DateTime.Now;
            txtLoaiViPham.Clear();
            txtMoTa.Clear();
            txtHinhThucXuLy.Clear();
            numDiemTru.Value = 0;
            txtMaViPham.Focus();
        }
    }
}
