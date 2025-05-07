using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET;

namespace GUI
{
    public partial class frmDiemHocPhan_GUI : Form
    {
        DiemHocPhan_BUS dhpBUS = new DiemHocPhan_BUS();
        
        public frmDiemHocPhan_GUI()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Load dữ liệu cho DataGridView
            dgvĐiemHocPhan.DataSource = dhpBUS.LayDSDiemHocPhan();

            // Load dữ liệu cho ComboBox SinhVien
            cboMaSV.DataSource = dhpBUS.LayDSSinhVien();
            cboMaSV.DisplayMember = "TenSinhVien";
            cboMaSV.ValueMember = "maSv";

            // Load dữ liệu cho ComboBox LopHocPhan
            cboMaLopHP.DataSource = dhpBUS.LayDSLopHocPhan();
            cboMaLopHP.DisplayMember = "TenLopHP";
            cboMaLopHP.ValueMember = "maLopHP";

            // Xóa trắng các TextBox
            ResetFields();
        }

        private void ResetFields()
        {
            txtDiemQuaTrinh.Text = "";
            txtDiemThi.Text = "";
            cboMaSV.SelectedIndex = -1;
            cboMaLopHP.SelectedIndex = -1;
        }

        private bool ValidateInputs()
        {
            // Kiểm tra mã sinh viên
            if (cboMaSV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra mã lớp học phần
            if (cboMaLopHP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học phần!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra điểm quá trình
            if (!string.IsNullOrEmpty(txtDiemQuaTrinh.Text))
            {
                double diemQT;
                if (!double.TryParse(txtDiemQuaTrinh.Text, out diemQT) || diemQT < 0 || diemQT > 10)
                {
                    MessageBox.Show("Điểm quá trình phải là số từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiemQuaTrinh.Focus();
                    return false;
                }
            }

            // Kiểm tra điểm thi
            if (!string.IsNullOrEmpty(txtDiemThi.Text))
            {
                double diemThi;
                if (!double.TryParse(txtDiemThi.Text, out diemThi) || diemThi < 0 || diemThi > 10)
                {
                    MessageBox.Show("Điểm thi phải là số từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiemThi.Focus();
                    return false;
                }
            }

            return true;
        }

        private void dgvĐiemHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvĐiemHocPhan.Rows[e.RowIndex];

                string maSV = row.Cells["MaSV"].Value.ToString();
                string maLopHP = row.Cells["MaLopHP"].Value.ToString();

                // Lấy thông tin điểm học phần từ BUS
                DiemHocPhan_ET dhpET = dhpBUS.LayThongTinDiemHocPhan(maSV, maLopHP);

                if (dhpET != null)
                {
                    cboMaSV.SelectedValue = dhpET.MaSV;
                    cboMaLopHP.SelectedValue = dhpET.MaLopHP;
                    txtDiemQuaTrinh.Text = dhpET.DiemQuaTrinh?.ToString() ?? "";
                    txtDiemThi.Text = dhpET.DiemThi?.ToString() ?? "";
                }
            }
        }

        private void btnThemDiemHP_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            // Tạo đối tượng DiemHocPhan_ET từ dữ liệu nhập
            DiemHocPhan_ET dhpET = new DiemHocPhan_ET();
            dhpET.MaSV = cboMaSV.SelectedValue.ToString();
            dhpET.MaLopHP = cboMaLopHP.SelectedValue.ToString();

            // Xử lý trường hợp textbox trống
            double diemQT, diemThi;
            dhpET.DiemQuaTrinh = double.TryParse(txtDiemQuaTrinh.Text, out diemQT) ? diemQT : (double?)null;
            dhpET.DiemThi = double.TryParse(txtDiemThi.Text, out diemThi) ? diemThi : (double?)null;

            // Gọi BUS để thêm điểm học phần
            if (dhpBUS.ThemDiemHocPhan(dhpET))
            {
                MessageBox.Show("Thêm điểm học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm điểm học phần thất bại! Có thể điểm học phần đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaDiemHP_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            // Tạo đối tượng DiemHocPhan_ET từ dữ liệu nhập
            DiemHocPhan_ET dhpET = new DiemHocPhan_ET();
            dhpET.MaSV = cboMaSV.SelectedValue.ToString();
            dhpET.MaLopHP = cboMaLopHP.SelectedValue.ToString();

            // Xử lý trường hợp textbox trống
            double diemQT, diemThi;
            dhpET.DiemQuaTrinh = double.TryParse(txtDiemQuaTrinh.Text, out diemQT) ? diemQT : (double?)null;
            dhpET.DiemThi = double.TryParse(txtDiemThi.Text, out diemThi) ? diemThi : (double?)null;

            // Gọi BUS để sửa điểm học phần
            if (dhpBUS.SuaDiemHocPhan(dhpET))
            {
                MessageBox.Show("Sửa điểm học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa điểm học phần thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDiemHP_Click(object sender, EventArgs e)
        {
            if (cboMaSV.SelectedValue == null || cboMaLopHP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn điểm học phần cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = cboMaSV.SelectedValue.ToString();
            string maLopHP = cboMaLopHP.SelectedValue.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa điểm học phần này không?", 
                                                 "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dhpBUS.XoaDiemHocPhan(maSV, maLopHP))
                {
                    MessageBox.Show("Xóa điểm học phần thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa điểm học phần thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
