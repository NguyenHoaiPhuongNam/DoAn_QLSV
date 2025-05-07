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
    public partial class frmDangKy_GUI : Form
    {
        DangKy_BUS dkBUS = new DangKy_BUS();
        DangKy_ET dkETCurrent = null;

        public frmDangKy_GUI()
        {
            InitializeComponent();
        }

        private void frmDangKy_GUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Load danh sách đăng ký
            dgvDangKy.DataSource = dkBUS.LayDSDangKy();

            // Load danh sách sinh viên
            cboMaSV.DataSource = dkBUS.LayDSSinhVien();
            cboMaSV.DisplayMember = "TenSV";
            cboMaSV.ValueMember = "maSv";

            // Load danh sách học phần
            cboMaHP.DataSource = dkBUS.LayDSHocPhan();
            cboMaHP.DisplayMember = "TenHP";
            cboMaHP.ValueMember = "maHocPhan";

            // Load danh sách học kỳ
            cboMaHK.DataSource = dkBUS.LayDSHocKy();
            cboMaHK.DisplayMember = "TenHK";
            cboMaHK.ValueMember = "maHocKy";

            // Load danh sách lớp học phần
            cboMaLopHP.DataSource = dkBUS.LayDSLopHP();
            cboMaLopHP.DisplayMember = "TenLopHP";
            cboMaLopHP.ValueMember = "maLopHP";

            // Reset biến lưu trữ đối tượng hiện tại
            dkETCurrent = null;
            ResetInputs();
        }

        private void ResetInputs()
        {
            if (cboMaSV.Items.Count > 0)
                cboMaSV.SelectedIndex = 0;
            
            if (cboMaHP.Items.Count > 0)
                cboMaHP.SelectedIndex = 0;
            
            if (cboMaHK.Items.Count > 0)
                cboMaHK.SelectedIndex = 0;
            
            if (cboMaLopHP.Items.Count > 0)
                cboMaLopHP.SelectedIndex = 0;
            
            cboMaSV.Enabled = true;
            cboMaHP.Enabled = true;
            cboMaHK.Enabled = true;
        }

        private void cboMaHP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cập nhật danh sách lớp học phần theo học phần được chọn
            if (cboMaHP.SelectedValue != null)
            {
                string maHP = cboMaHP.SelectedValue.ToString();
                cboMaLopHP.DataSource = dkBUS.LayDSLopHP_TheoHP(maHP);
                cboMaLopHP.DisplayMember = "TenLopHP";
                cboMaLopHP.ValueMember = "maLopHP";
            }
        }

        private void btnThemDangKy_Click(object sender, EventArgs e)
        {
            if (cboMaSV.SelectedValue == null || cboMaHP.SelectedValue == null || 
                cboMaHK.SelectedValue == null || cboMaLopHP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng DangKy_ET
            DangKy_ET dkET = new DangKy_ET
            {
                MaSV = cboMaSV.SelectedValue.ToString(),
                MaHocPhan = cboMaHP.SelectedValue.ToString(),
                MaHocKy = cboMaHK.SelectedValue.ToString(),
                MaLopHP = cboMaLopHP.SelectedValue.ToString()
            };

            // Thêm đăng ký
            if (dkBUS.ThemDangKy(dkET))
            {
                MessageBox.Show("Thêm đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm đăng ký thất bại. Có thể đăng ký này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaDangKy_Click(object sender, EventArgs e)
        {
            if (dkETCurrent == null)
            {
                MessageBox.Show("Vui lòng chọn đăng ký cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMaSV.SelectedValue == null || cboMaHP.SelectedValue == null || 
                cboMaHK.SelectedValue == null || cboMaLopHP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng DangKy_ET mới
            DangKy_ET dkETNew = new DangKy_ET
            {
                MaSV = cboMaSV.SelectedValue.ToString(),
                MaHocPhan = cboMaHP.SelectedValue.ToString(),
                MaHocKy = cboMaHK.SelectedValue.ToString(),
                MaLopHP = cboMaLopHP.SelectedValue.ToString()
            };

            // Sửa đăng ký
            if (dkBUS.SuaDangKy(dkETCurrent, dkETNew))
            {
                MessageBox.Show("Sửa đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDangKy_Click(object sender, EventArgs e)
        {
            if (dkETCurrent == null)
            {
                MessageBox.Show("Vui lòng chọn đăng ký cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đăng ký này?", "Xác nhận", 
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dkBUS.XoaDangKy(dkETCurrent))
                {
                    MessageBox.Show("Xóa đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa đăng ký thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDangKy.Rows[e.RowIndex];
                
                string maSV = row.Cells["maSV"].Value.ToString();
                string maHP = row.Cells["maHocPhan"].Value.ToString();
                string maHK = row.Cells["maHocKy"].Value.ToString();
                string maLopHP = row.Cells["maLopHP"].Value.ToString();

                // Lưu thông tin đăng ký hiện tại
                dkETCurrent = new DangKy_ET(maSV, maHP, maHK, maLopHP);

                // Chọn các giá trị trong ComboBox
                foreach (var item in cboMaSV.Items)
                {
                    DataRowView drv = item as DataRowView;
                    if (drv != null && drv["maSv"].ToString() == maSV)
                    {
                        cboMaSV.SelectedItem = item;
                        break;
                    }
                }

                foreach (var item in cboMaHP.Items)
                {
                    DataRowView drv = item as DataRowView;
                    if (drv != null && drv["maHocPhan"].ToString() == maHP)
                    {
                        cboMaHP.SelectedItem = item;
                        break;
                    }
                }

                foreach (var item in cboMaHK.Items)
                {
                    DataRowView drv = item as DataRowView;
                    if (drv != null && drv["maHocKy"].ToString() == maHK)
                    {
                        cboMaHK.SelectedItem = item;
                        break;
                    }
                }

                // Chọn lớp học phần sau khi đã cập nhật danh sách theo học phần
                foreach (var item in cboMaLopHP.Items)
                {
                    DataRowView drv = item as DataRowView;
                    if (drv != null && drv["maLopHP"].ToString() == maLopHP)
                    {
                        cboMaLopHP.SelectedItem = item;
                        break;
                    }
                }

                // Disable một số ComboBox vì đây là primary key
                cboMaSV.Enabled = false;
                cboMaHP.Enabled = false;
                cboMaHK.Enabled = false;
            }
        }
    }
}
