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
    public partial class frmNganh : Form
    {
        public frmNganh()
        {
            InitializeComponent();
        }
        Nganh_BUS nBUS = new Nganh_BUS();
        private void frmNganh_Load(object sender, EventArgs e)
        {
            dgvNganh.DataSource = nBUS.LayDSNganh();
            cboMaKhoa.DataSource = nBUS.LayDSKhoa();
            cboMaKhoa.DisplayMember = "tenKhoa";
            cboMaKhoa.ValueMember = "maKhoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNganh.Text) || string.IsNullOrWhiteSpace(txtTenNganh.Text) ||
               string.IsNullOrWhiteSpace(txtHDT.Text) || string.IsNullOrWhiteSpace(txtSNH.Text) ||
               cboMaKhoa.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSNH.Text, out int snh))
            {
                MessageBox.Show("Số năm học phải là số nguyên", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maNganh = txtMaNganh.Text;
            string tenNganh = txtTenNganh.Text;
            string maKhoa = cboMaKhoa.SelectedValue.ToString();

            if (nBUS.KiemTraTrungMaNganh(maNganh))
            {
                MessageBox.Show("Mã ngành đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nBUS.KiemTraTrungTenNganh(tenNganh))
            {
                MessageBox.Show("Tên ngành đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var na = new Nganh_ET(maKhoa, maNganh, tenNganh, txtHDT.Text, snh);

            if (nBUS.ThemNganh(na))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvNganh.DataSource = nBUS.LayDSNganh();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNganh.Text) || cboMaKhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn ngành cần xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNganh = txtMaNganh.Text;
            string maKhoa = cboMaKhoa.SelectedValue.ToString();

            if (!nBUS.KiemTraTrungMaNganhVaMaKhoa(maNganh, maKhoa))
            {
                MessageBox.Show("Không tìm thấy ngành để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (nBUS.XoaNganh(maNganh))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNganh.DataSource = nBUS.LayDSNganh();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNganh.Text) || string.IsNullOrWhiteSpace(txtTenNganh.Text) ||
                string.IsNullOrWhiteSpace(txtHDT.Text) || string.IsNullOrWhiteSpace(txtSNH.Text) ||
                cboMaKhoa.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSNH.Text, out int snh))
            {
                MessageBox.Show("Số năm học phải là số nguyên", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maNganh = txtMaNganh.Text;
            string maKhoa = cboMaKhoa.SelectedValue.ToString();

            if (!nBUS.KiemTraTrungMaNganh(maNganh))
            {
                MessageBox.Show("Không tìm thấy ngành để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                var na = new Nganh_ET(maKhoa, maNganh, txtTenNganh.Text, txtHDT.Text, snh);
                if (nBUS.SuaNganh(na))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNganh.DataSource = nBUS.LayDSNganh();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNganh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHDT.Clear();
            txtMaNganh.Clear();
            txtSNH.Clear();
            txtTenNganh.Clear();
            txtMaNganh.Focus();
        }

        private void dgvNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvNganh.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtMaNganh.Text = row.Cells["maNganh"].Value?.ToString();
                    txtHDT.Text = row.Cells["heDaoTao"].Value?.ToString();
                    txtTenNganh.Text = row.Cells["tenNganh"].Value?.ToString();
                    txtSNH.Text = row.Cells["soNamHoc"].Value?.ToString();

                    // Kiểm tra giá trị trước khi gán vào ComboBox để tránh lỗi null
                    cboMaKhoa.SelectedValue = row.Cells["maKhoa"].Value != null ? row.Cells["maKhoa"].Value.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
