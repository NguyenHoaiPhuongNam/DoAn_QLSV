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
    public partial class frmHocBong_GUI : Form
    {
        HocBong_BUS hbBUS = new HocBong_BUS();
        string maHB;

        public frmHocBong_GUI()
        {
            InitializeComponent();
            LoadData();
            SetupXepLoai();
        }

        private void LoadData()
        {
            dgvHocBong.DataSource = hbBUS.LayDSHocBong();
            cboMaSV.DataSource = hbBUS.LayDSSinhVien();
            cboMaSV.DisplayMember = "TenSV";
            cboMaSV.ValueMember = "maSv";
            ResetInputs();
        }

        private void SetupXepLoai()
        {
            cboXepLoaiHB.Items.Add("Xuất sắc");
            cboXepLoaiHB.Items.Add("Giỏi");
            cboXepLoaiHB.Items.Add("Khá");
            cboXepLoaiHB.SelectedIndex = 0;
        }

        private void ResetInputs()
        {
            if (cboMaSV.Items.Count > 0)
                cboMaSV.SelectedIndex = 0;
            
            cboMaSV.Enabled = true;
            cboXepLoaiHB.SelectedIndex = 0;
            txtGhiChu.Text = "";
            txtMaHB.Text = hbBUS.TaoMaHB();
            maHB = "";
        }

        private void btnThemHocBong_Click(object sender, EventArgs e)
        {
            if (cboMaSV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HocBong_ET hbET = new HocBong_ET
            {
                MaHB = txtMaHB.Text,
                MaSV = cboMaSV.SelectedValue.ToString(),
                XepLoaiHB = cboXepLoaiHB.Text,
                GhiChu = txtGhiChu.Text
            };

            if (hbBUS.ThemHocBong(hbET))
            {
                MessageBox.Show("Thêm học bổng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm học bổng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaHocBong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maHB))
            {
                MessageBox.Show("Vui lòng chọn học bổng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HocBong_ET hbET = new HocBong_ET
            {
                MaHB = maHB,
                MaSV = cboMaSV.SelectedValue.ToString(),
                XepLoaiHB = cboXepLoaiHB.Text,
                GhiChu = txtGhiChu.Text
            };

            if (hbBUS.SuaHocBong(hbET))
            {
                MessageBox.Show("Sửa học bổng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa học bổng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaHocBong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maHB))
            {
                MessageBox.Show("Vui lòng chọn học bổng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (hbBUS.XoaHocBong(maHB))
                {
                    MessageBox.Show("Xóa học bổng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa học bổng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvHocBong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocBong.Rows[e.RowIndex];
                maHB = row.Cells["maHB"].Value.ToString();
                txtMaHB.Text = maHB;
                
                // Lấy maSV và chọn trong combo box
                string maSV = row.Cells["maSV"].Value.ToString();
                foreach (var item in cboMaSV.Items)
                {
                    DataRowView drv = item as DataRowView;
                    if (drv != null && drv["maSv"].ToString() == maSV)
                    {
                        cboMaSV.SelectedItem = item;
                        break;
                    }
                }
                
                cboMaSV.Enabled = false;
                cboXepLoaiHB.Text = row.Cells["xepLoaiHB"].Value?.ToString() ?? "Khá";
                txtGhiChu.Text = row.Cells["ghiChu"].Value?.ToString() ?? "";
            }
        }

        private void frmHocBong_GUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
