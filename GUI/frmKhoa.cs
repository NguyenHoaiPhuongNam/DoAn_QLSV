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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }
        Khoa_BUS kBus = new Khoa_BUS();
        
        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dgvKhoa.DataSource = kBus.LayDSKhoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Không được để trống mã khoa hoặc tên khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Khoa_ET k = new Khoa_ET(txtMa.Text, txtTen.Text);
                string maKhoa = txtMa.Text;
                string tenKhoa = txtTen.Text;
                if (kBus.KiemTraTrungMaKhoa(maKhoa))
                {
                    MessageBox.Show("Không được để trùng mã khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (kBus.KiemTraTrungTenKhoa(tenKhoa))
                {
                    MessageBox.Show("Không được để trùng tên khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                kBus.ThemKhoa(k);
                dgvKhoa.DataSource = kBus.LayDSKhoa();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text.Trim();

            if (ma == "")
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (kBus.XoaKhoa(ma))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvKhoa.DataSource = kBus.LayDSKhoa();
                }
                else
                {
                    MessageBox.Show("Không thể xóa khoa. Có thể khoa đang được sử dụng ở bảng khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Không được để trống mã khoa hoặc tên khoa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa không", "Cảnh báo", MessageBoxButtons.YesNo
                                             , MessageBoxIcon.Warning);
            try
            {
                if (r == DialogResult.Yes)
                {
                    Khoa_ET k = new Khoa_ET(txtMa.Text, txtTen.Text);
                    bool ketqua= kBus.SuaKhoa(k);
                    if (ketqua)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvKhoa.DataSource = kBus.LayDSKhoa();
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa khoa. Tên khoa đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void frmKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtMa.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvKhoa.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtMa.Text = row.Cells["maKhoa"].Value?.ToString();
                    txtTen.Text = row.Cells["tenKhoa"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
