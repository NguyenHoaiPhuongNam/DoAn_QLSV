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
    public partial class frmPhanCongGiangVien : Form
    {
        public frmPhanCongGiangVien()
        {
            InitializeComponent();
        }
        PhanCongGiangVien_BUS pc_bus = new PhanCongGiangVien_BUS();
        private void frmPhanCongGiangVien_Load(object sender, EventArgs e)
        {
            dgvDanhSachPC.DataSource = pc_bus.LayDSPhanCong();
            cboMaHP.DataSource = pc_bus.LayDSMonHoc();
            cboMaHP.ValueMember = "maHocPhan";
            cboMaHP.DisplayMember = "tenHocPhan";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maHP = cboMaHP.SelectedValue.ToString();
                string maGV = txtMa.Text.Trim();
                PhanCongGiangVien_ET pc = new PhanCongGiangVien_ET(maHP, maGV);
                if (string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    MessageBox.Show("Không được để trống mã giảng viên", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!pc_bus.KiemTraMaGv(maGV))
                {
                    MessageBox.Show("Không tìm thấy mã giảng viên", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!pc_bus.KiemTraMaHP(maHP))
                {
                    MessageBox.Show("Không tìm thấy mã giảng viên", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (pc_bus.ThemPCGV(pc))
                {
                    dgvDanhSachPC.DataSource = pc_bus.LayDSPhanCong();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Phân công đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtMa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHP = cboMaHP.SelectedValue.ToString();
            string maGV = txtMa.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Không được để trống mã giảng viên", "Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo
                 , MessageBoxIcon.Warning);
            if(r == DialogResult.Yes)
            {
                try
                {
                    if (pc_bus.XoaPCGV(maHP, maGV))
                    {
                        dgvDanhSachPC.DataSource = pc_bus.LayDSPhanCong();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phân công để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message);
                }
            }
        }

        private void dgvDanhSachPC_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachPC.CurrentCell != null)
                {
                    int dong = dgvDanhSachPC.CurrentCell.RowIndex;
                    txtMa.Text = dgvDanhSachPC.Rows[dong].Cells["maGiangVien"].Value.ToString();
                    cboMaHP.SelectedValue = dgvDanhSachPC.Rows[dong].Cells["maHocPhan"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || cboMaHP.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maGVMoi = txtMa.Text.Trim();
            string maHPMoi = cboMaHP.SelectedValue.ToString();

            // Kiểm tra nếu mã mới không khác gì mã cũ => không cần sửa
            if (maGVMoi == maGV_cu && maHPMoi == maHP_cu)
            {
                MessageBox.Show("Không có thay đổi để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra nếu bản ghi mới đã tồn tại
            if ((maGVMoi != maGV_cu || maHPMoi != maHP_cu) && pc_bus.KiemTraTrungMa(maHPMoi, maGVMoi))
            {
                MessageBox.Show("Phân công mới đã tồn tại. Không thể sửa thành trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có chắc muốn sửa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            try
            {
                // Xóa bản ghi cũ
                if (!pc_bus.XoaPCGV(maHP_cu, maGV_cu))
                {
                    MessageBox.Show("Không tìm thấy bản ghi cũ để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm bản ghi mới
                PhanCongGiangVien_ET pc = new PhanCongGiangVien_ET(maHPMoi, maGVMoi);
                pc_bus.ThemPCGV(pc);

                dgvDanhSachPC.DataSource = pc_bus.LayDSPhanCong();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string maGV_cu;
        private string maHP_cu;
        private void dgvDanhSachPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachPC.Rows[e.RowIndex];
                txtMa.Text = row.Cells["maGiangVien"].Value.ToString();
                cboMaHP.SelectedValue = row.Cells["maHocPhan"].Value.ToString();

                // Ghi nhớ khóa cũ
                maGV_cu = txtMa.Text;
                maHP_cu = cboMaHP.SelectedValue.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhanCongGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnPC1GV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTinPhancong1GiangVien f2 = new frmThongTinPhancong1GiangVien();
            f2.ShowDialog();
            this.Show();
        }
    }
}
