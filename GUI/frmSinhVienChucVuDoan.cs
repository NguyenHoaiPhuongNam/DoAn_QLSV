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
    public partial class frmSinhVienChucVuDoan : Form
    {
        public frmSinhVienChucVuDoan()
        {
            InitializeComponent();
        }
        SinhVienChucVuDoan_BUS cv_BUS = new SinhVienChucVuDoan_BUS();
        private void frmSinhVienChucVuDoan_Load(object sender, EventArgs e)
        {
            dgvSVCVD.DataSource = cv_BUS.LayDSSVChucVuDoan();
            cboCV.DataSource = cv_BUS.LayDSChucVuDoan();
            cboHK.DataSource = cv_BUS.LayDSHocKy();
            cboHK.DisplayMember = "tenHocKy";
            cboCV.DisplayMember = "tenChucVu";
            cboHK.ValueMember = "maHocKy";
            cboCV.ValueMember = "maChucVu";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || cboCV.SelectedValue == null || cboHK.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SinhVienChucVuDoan_ET cv = new SinhVienChucVuDoan_ET(txtMa.Text, cboCV.SelectedValue.ToString(),cboHK.SelectedValue.ToString());
                string maSV = txtMa.Text.Trim();
                string maCV = cboCV.SelectedValue.ToString();
                string maHK = cboHK.SelectedValue.ToString();
                if (cv_BUS.KiemTraTrungMa(maCV,maHK,maSV))
                {
                    MessageBox.Show($"Sinh viên có mã {maSV} đã làm chức vụ {maCV} trong học kỳ {maHK} rồi!! Vui lòng thêm lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!cv_BUS.KiemTraTrungMaSuaSv(maSV))
                {
                    MessageBox.Show("Sinh viên không có ở trong hệ thống !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cv_BUS.ThemSinhVienChucVu(cv);
                dgvSVCVD.DataSource = cv_BUS.LayDSSVChucVuDoan();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMa.Text) || cboCV.SelectedValue == null || cboHK.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo
                   , MessageBoxIcon.Warning);
            try
            {
                if (r == DialogResult.Yes)
                {
                    string maSV = txtMa.Text;
                    string maCV = cboCV.SelectedValue.ToString();
                    string maHK = cboHK.SelectedValue.ToString();
                    if (cv_BUS.XoaSinhVienChucVu(maCV, maHK, maSV) != null)
                    {
                        dgvSVCVD.DataSource = cv_BUS.LayDSSVChucVuDoan();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không còn sinh viên chức vụ để xóa ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || cboCV.SelectedValue == null || cboHK.SelectedValue == null)
            {
                MessageBox.Show("Không được để trống các ô", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có chắc muốn sưa không", "Cảnh báo", MessageBoxButtons.YesNo
                  , MessageBoxIcon.Warning);
            string maSV = txtMa.Text;
            string maCV = cboCV.SelectedValue.ToString();
            string maHK = cboHK.SelectedValue.ToString();
            if (!cv_BUS.KiemTraTrungMaSuaSv(maSV))
            {
                MessageBox.Show("Sinh viên không có ở trong hệ thông !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (r == DialogResult.Yes)
                {
                    SinhVienChucVuDoan_ET cv = new SinhVienChucVuDoan_ET(txtMa.Text, cboCV.SelectedValue.ToString(), 
                        cboHK.SelectedValue.ToString());

                    if (cv_BUS.KiemTraTrungMaSuaHK(maCV, maSV))
                    {
                        if (cv_BUS.KiemTraTrungMa(maCV, maHK, maSV))
                        {
                            MessageBox.Show($"Sinh viên có mã {maSV} đã làm chức vụ {maCV} trong học kỳ {maHK} rồi!! Vui lòng thêm lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (cv_BUS.SuaSinhVienChucVuTheoHK(maCV,maSV) != null)
                        {
                            cv_BUS.ThemSinhVienChucVu(cv);
                            dgvSVCVD.DataSource = cv_BUS.LayDSSVChucVuDoan();
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không còn sinh viên chức vụ để sửa ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (cv_BUS.KiemTraTrungMaSuaCv(maHK, maSV))
                    {
                        if (cv_BUS.KiemTraTrungMa(maCV, maHK, maSV))
                        {
                            MessageBox.Show($"Sinh viên có mã {maSV} đã làm chức vụ {maCV} trong học kỳ {maHK} rồi!! Vui lòng thêm lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (cv_BUS.SuaSinhVienChucVuTheoCV(maHK,maSV) != null)
                        {
                            cv_BUS.ThemSinhVienChucVu(cv);
                            dgvSVCVD.DataSource = cv_BUS.LayDSSVChucVuDoan();
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không còn sinh viên chức vụ để sửa ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void frmSinhVienChucVuDoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtMa.Focus();
        }

        private void dgvSVCVD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvSVCVD.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtMa.Text = row.Cells["maSV"].Value?.ToString();

                    // Kiểm tra giá trị trước khi gán vào ComboBox để tránh lỗi null
                    cboCV.SelectedValue = row.Cells["maChucVu"].Value != null ? row.Cells["maChucVu"].Value.ToString() : "";
                    cboHK.SelectedValue = row.Cells["maHocKy"].Value != null ? row.Cells["maHocKy"].Value.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
