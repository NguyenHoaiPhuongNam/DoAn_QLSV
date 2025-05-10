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
    public partial class frmGiangVien : Form
    {
        GiangVien_BUS gv_BUS = new GiangVien_BUS();
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            dgvGiangVien.DataSource = gv_BUS.LayDSGiangVien();
            cboMaKhoa.DataSource = gv_BUS.LayDSKhoa();
            cboMaKhoa.DisplayMember = "tenKhoa";
            cboMaKhoa.ValueMember = "maKhoa";
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaGV.Text)|| string.IsNullOrWhiteSpace(txtHoTen.Text)||
                string.IsNullOrWhiteSpace(txtEmail.Text)|| string.IsNullOrWhiteSpace(txtDc.Text)||
                string.IsNullOrWhiteSpace(txtSDT.Text)||cboMaKhoa.SelectedValue == null ||(!rdoNam.Checked && !rdoNu.Checked))
            {
                MessageBox.Show("Vui lòng nhập thông tin dầy đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                    string maGv = txtMaGV.Text;
                    string email = txtEmail.Text;
                    string soDT = txtSDT.Text;
                    if (gv_BUS.KiemTraTrungMaGV(maGv))
                    {
                        MessageBox.Show("Vui lòng không nhập trùng mã Giảng Viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (gv_BUS.KiemTraTrungEmailGV(email))
                    {
                        MessageBox.Show("Vui lòng không nhập trùng email Giảng Viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (gv_BUS.KiemTraTrungSDTGV(soDT))
                    {
                        MessageBox.Show("Vui lòng không nhập trùng số điển thoại Giảng Viên", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    GiangVien_ET gv = new GiangVien_ET(txtMaGV.Text, txtHoTen.Text, Convert.ToDateTime(dtNgaySinh.Value.ToString()),
                       gioiTinh, txtEmail.Text, txtSDT.Text, txtDc.Text, cboMaKhoa.SelectedValue.ToString());
                    gv_BUS.ThemGiangVien(gv);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGiangVien.DataSource = gv_BUS.LayDSGiangVien();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaGV.Text) || cboMaKhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên và mã khoa", "Thông báo", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
                return;
            }
            else
            {
                string maGv = txtMaGV.Text;
                string maKhoa = cboMaKhoa.SelectedValue.ToString();
                DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Warning);
                if(r == DialogResult.Yes)
                {
                    if (gv_BUS.XoaGiangVien(maGv))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvGiangVien.DataSource = gv_BUS.LayDSGiangVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Lỗi!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDc.Text.Trim();
            string maKhoa = cboMaKhoa.SelectedValue?.ToString();
            string gioiTinh = rdoNam.Checked ? "Nam" : rdoNu.Checked ? "Nữ" : "";

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(maGV) || string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(maKhoa) ||
                string.IsNullOrWhiteSpace(gioiTinh))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra tồn tại mã
            if (!gv_BUS.KiemTraTrungMaGV(maGV))
            {
                MessageBox.Show("Không tìm thấy giảng viên để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy email, sdt, khoa cũ từ dòng đang chọn
            string emailCu = dgvGiangVien.CurrentRow.Cells["email"].Value.ToString();
            string sdtCu = dgvGiangVien.CurrentRow.Cells["sdt"].Value.ToString();

            // Kiểm tra trùng email nếu có thay đổi
            if (!email.Equals(emailCu, StringComparison.OrdinalIgnoreCase) && gv_BUS.KiemTraTrungEmailGV(email))
            {
                MessageBox.Show("Email đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng SĐT nếu có thay đổi
            if (!sdt.Equals(sdtCu, StringComparison.OrdinalIgnoreCase) && gv_BUS.KiemTraTrungSDTGV(sdt))
            {
                MessageBox.Show("Số điện thoại đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GiangVien_ET gv = new GiangVien_ET(maGV, hoTen, dtNgaySinh.Value, gioiTinh, email, sdt, diaChi, maKhoa);

            try
            {
                if (gv_BUS.SuaGiangVien(gv))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGiangVien.DataSource = gv_BUS.LayDSGiangVien();
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

        //Chuyển sang from Thông tin một giảng viên
        private void btnThong_Tin_GV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongTin1GiangVien f2 = new frmThongTin1GiangVien();
            f2.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDc.Clear();
            txtSDT.Clear();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng hiện tại
                    DataGridViewRow row = dgvGiangVien.Rows[e.RowIndex];

                    // Gán giá trị vào các TextBox
                    txtMaGV.Text = row.Cells["maGiangVien"].Value?.ToString();
                    txtHoTen.Text = row.Cells["hoTen"].Value?.ToString();
                    dtNgaySinh.Value = row.Cells["ngaySinh"].Value != null ? Convert.ToDateTime(row.Cells["ngaySinh"].Value) : DateTime.Now;

                    // Kiểm tra giới tính và chọn RadioButton phù hợp
                    string gioiTinh = row.Cells["gioiTinh"].Value?.ToString().Trim();
                    rdoNam.Checked = gioiTinh == "Nam";
                    rdoNu.Checked = gioiTinh == "Nữ";

                    txtEmail.Text = row.Cells["email"].Value?.ToString();
                    txtSDT.Text = row.Cells["sdt"].Value?.ToString();
                    txtDc.Text = row.Cells["diaChi"].Value?.ToString();

                    // Đặt giá trị cho ComboBox
                    cboMaKhoa.SelectedValue = row.Cells["maKhoa"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
