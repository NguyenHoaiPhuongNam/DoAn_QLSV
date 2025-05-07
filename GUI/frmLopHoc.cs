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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }
        LopHoc_BUS lh_BUS = new LopHoc_BUS();
        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            dgvLopHoc.DataSource = lh_BUS.LayDSLopHoc();
            cboMaGV.DataSource = lh_BUS.LayDSGiangVien();
            cboMaGV.DisplayMember = "hoTen";
            cboMaGV.ValueMember = "maGiangVien";
            cboMaNganh.DataSource = lh_BUS.LayDSNganh();
            cboMaNganh.DisplayMember = "tenNganh";
            cboMaNganh.ValueMember = "maNganh";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) || string.IsNullOrWhiteSpace(txtTenLop.Text) ||
         string.IsNullOrWhiteSpace(txtKhoaHoc.Text) || cboMaGV.SelectedValue == null ||
         cboMaNganh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string khoaHoc = txtKhoaHoc.Text.Trim();
            string maGV = cboMaGV.SelectedValue.ToString();
            string maNganh = cboMaNganh.SelectedValue.ToString();

            LopHoc_ET lh = new LopHoc_ET(maLop, tenLop, maNganh, maGV, khoaHoc);

            if (lh_BUS.KiemTraTrungMaLopHoc(maLop))
            {
                MessageBox.Show("Mã lớp đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lh_BUS.KiemTraTrungTenLopHoc(tenLop))
            {
                MessageBox.Show("Tên lớp đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lh_BUS.ThemLop(lh))
            {
                MessageBox.Show("Thêm lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvLopHoc.DataSource = lh_BUS.LayDSLopHoc();
            }
            else
            {
                MessageBox.Show("Thêm lớp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng chọn mã lớp để xóa", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maLop = txtMaLop.Text.Trim();

                if (lh_BUS.XoaLop(maLop))
                {
                    MessageBox.Show("Xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLopHoc.DataSource = lh_BUS.LayDSLopHoc();
                }
                else
                {
                    MessageBox.Show("Xóa lớp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string maNganh = cboMaNganh.SelectedValue.ToString();
            string maGV = cboMaGV.SelectedValue.ToString();
            string khoaHoc = txtKhoaHoc.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(maLop) || string.IsNullOrWhiteSpace(tenLop) ||
                string.IsNullOrWhiteSpace(maNganh) || string.IsNullOrWhiteSpace(maGV) ||
                string.IsNullOrWhiteSpace(khoaHoc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tồn tại mã lớp học
            if (!lh_BUS.KiemTraTrungMaLopHoc(maLop))
            {
                MessageBox.Show("Không tìm thấy lớp học để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin cũ từ dòng đang chọn
            string tenLopCu = dgvLopHoc.CurrentRow.Cells["tenLop"].Value.ToString();
            string maNganhCu = dgvLopHoc.CurrentRow.Cells["maNganh"].Value.ToString();

            // Kiểm tra trùng tên lớp nếu có thay đổi
            if (!tenLop.Equals(tenLopCu, StringComparison.OrdinalIgnoreCase) && lh_BUS.KiemTraTrungTenLopHoca(maLop, tenLop))
            {
                MessageBox.Show("Tên lớp đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra lớp học đã tồn tại với ngành được chọn nếu có thay đổi
            if (!maNganh.Equals(maNganhCu, StringComparison.OrdinalIgnoreCase) && lh_BUS.KiemTraTrungLopDaTontai(maLop, maNganh))
            {
                MessageBox.Show("Lớp học đã tồn tại trong ngành này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng lớp học để cập nhật
            LopHoc_ET lh = new LopHoc_ET(maLop, tenLop, maNganh, maGV, khoaHoc);

            try
            {
                if (lh_BUS.SuaLop(lh))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvLopHoc.DataSource = lh_BUS.LayDSLopHoc();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnThongTinLopHoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTin1LopHoc f2 = new frmThongTin1LopHoc();
            f2.ShowDialog();
            this.Show();
        }

        private void cboMaNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        
        }

        private void frmLopHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtKhoaHoc.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtMaLop.Focus();
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtMaLop.Text = row.Cells["maLop"].Value?.ToString();
                    txtTenLop.Text = row.Cells["tenLop"].Value?.ToString();
                    txtKhoaHoc.Text = row.Cells["khoaHoc"].Value?.ToString();

                    // Gán giá trị cho ComboBox (chỉ khi giá trị không null)
                    cboMaGV.SelectedValue = row.Cells["maGiangVien"].Value != null ? row.Cells["maGiangVien"].Value.ToString() : "";
                    cboMaNganh.SelectedValue = row.Cells["maNganh"].Value != null ? row.Cells["maNganh"].Value.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
