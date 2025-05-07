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
    public partial class frmLopHocPhan : Form
    {
        public frmLopHocPhan()
        {
            InitializeComponent();
        }
        LopHocPhan_BUS lh_bus = new LopHocPhan_BUS();
        private void frmLopHocPhan_Load(object sender, EventArgs e)
        {
            dgvLopHocPhan.DataSource = lh_bus.LayDSLopHocPhan();
            cbOMaGV.DataSource = lh_bus.LayDSGV();
            cboMaHP.DataSource = lh_bus.LayDSHocPhan();
            cbOMaGV.DisplayMember = "hoTen";
            cbOMaGV.ValueMember = "maGiangVien";
            cboMaHP.DisplayMember = "tenHocPhan";
            cboMaHP.ValueMember = "maHocPhan";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaHP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtThongTin.Text)
                || cboMaHP.SelectedValue == null || cbOMaGV.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soLuong = 0;
            string maLhp = txtMaHP.Text;
            string maHp = cboMaHP.SelectedValue.ToString();
            string maGV = cbOMaGV.SelectedValue.ToString();
            DateTime nBatDau = dtNgayBatDau.Value;
            DateTime nKetThuc = dtNgayKetThuc.Value;

            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên hoặc lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lh_bus.KiemTraTrungMaLopHP(maLhp))
            {
                MessageBox.Show("Vui lòng không nhập trùng mã lớp học phần", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lh_bus.KiemTraTrungMa(maGV, maHp))
            {
                MessageBox.Show($"Giảng viên này đã dạy môn {maHp} rồi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!lh_bus.KiemTraNgay(nBatDau, nKetThuc))
            {
                MessageBox.Show($"Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                LopHocPhan_ET lhp = new LopHocPhan_ET(txtMaHP.Text, cboMaHP.SelectedValue.ToString(), Convert.ToInt32(txtSoLuong.Text)
                    , txtThongTin.Text, cbOMaGV.SelectedValue.ToString(), Convert.ToDateTime(dtNgayBatDau.Value.ToString()), Convert.ToDateTime(dtNgayKetThuc.Value.ToString()));
                if (lh_bus.Them(lhp))
                {
                    dgvLopHocPhan.DataSource = lh_bus.LayDSLopHocPhan();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Giảng viên này chưa được phân công để giảng dạy cho môn học này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHP.Text))
            {
                MessageBox.Show("Không được để trống mã Lớp Học Phần", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo
                   , MessageBoxIcon.Warning);
            string maHP = txtMaHP.Text;
            if(r == DialogResult.Yes)
            {
                if (lh_bus.Xoa(maHP))
                {
                    dgvLopHocPhan.DataSource = lh_bus.LayDSLopHocPhan();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Không có lớp {maHP} để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHP.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtThongTin.Text)
             || cboMaHP.SelectedValue == null || cbOMaGV.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int soLuong = 0;
            string maLhp = txtMaHP.Text;
            string maHp = cboMaHP.SelectedValue.ToString();
            string maGV = cbOMaGV.SelectedValue.ToString();
            DateTime nBatDau = dtNgayBatDau.Value;
            DateTime nKetThuc = dtNgayKetThuc.Value;
            if (!lh_bus.KiemTraNgay(nBatDau, nKetThuc))
            {
                MessageBox.Show($"Ngày bắt đầu phải nhỏ hơn ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên hoặc lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa không", "Cảnh báo", MessageBoxButtons.YesNo
                   , MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                try
                {
                    LopHocPhan_ET lhp = new LopHocPhan_ET(txtMaHP.Text, cboMaHP.SelectedValue.ToString(), Convert.ToInt32(txtSoLuong.Text)
                        , txtThongTin.Text, cbOMaGV.SelectedValue.ToString(), Convert.ToDateTime(dtNgayBatDau.Value.ToString()), Convert.ToDateTime(dtNgayKetThuc.Value.ToString()));
                    if (lh_bus.Sua(lhp))
                    {
                        dgvLopHocPhan.DataSource = lh_bus.LayDSLopHocPhan();
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(lh_bus.Sua(lhp) == null)
                    {
                        MessageBox.Show($"Không có lớp {maHp} để Sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Giảng viên này chưa được phân công để giảng dạy cho môn học này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHP.Clear();
            txtSoLuong.Clear();
            txtThongTin.Clear();
            txtMaHP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLopHocPhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThongTin1LopHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSinhVienTrong1LopHocPhan f2 = new frmSinhVienTrong1LopHocPhan();
            f2.ShowDialog();
            this.Show();
        }

        private void dgvLopHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvLopHocPhan.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtMaHP.Text = row.Cells["maLopHP"].Value?.ToString();
                    txtSoLuong.Text = row.Cells["soLuong"].Value?.ToString();
                    txtThongTin.Text = row.Cells["thongTin"].Value?.ToString();

                    // Kiểm tra null trước khi gán giá trị vào ComboBox
                    cbOMaGV.SelectedValue = row.Cells["magv"].Value != null ? row.Cells["magv"].Value.ToString() : "";
                    cboMaHP.SelectedValue = row.Cells["maHP"].Value != null ? row.Cells["maHP"].Value.ToString() : "";

                    // Kiểm tra null trước khi gán vào DateTimePicker để tránh lỗi chuyển đổi
                    dtNgayBatDau.Value = row.Cells["ngayBatDau"].Value != null ? Convert.ToDateTime(row.Cells["ngayBatDau"].Value) : DateTime.Now;
                    dtNgayKetThuc.Value = row.Cells["ngayKetThuc"].Value != null ? Convert.ToDateTime(row.Cells["ngayKetThuc"].Value) : DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
