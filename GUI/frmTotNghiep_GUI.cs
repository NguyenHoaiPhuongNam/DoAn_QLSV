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
    public partial class frmTotNghiep_GUI : Form
    {
        TotNghiep_BUS tnBUS = new TotNghiep_BUS();
        string maSV;

        public frmTotNghiep_GUI()
        {
            InitializeComponent();
            LoadData();
            SetupXepLoai();
        }

        private void LoadData()
        {
            dgvTotNghiep.DataSource = tnBUS.LayDSTotNghiep();
            cboMaSV.DataSource = tnBUS.LayDSSinhVien();
            cboMaSV.DisplayMember = "TenSV";
            cboMaSV.ValueMember = "maSv";
            ResetInputs();
        }

        private void SetupXepLoai()
        {
            cboXepLoai.Items.Add("Xuất sắc");
            cboXepLoai.Items.Add("Giỏi");
            cboXepLoai.Items.Add("Khá");
            cboXepLoai.Items.Add("Trung bình");
            cboXepLoai.SelectedIndex = 0;
        }

        private void ResetInputs()
        {
            if (cboMaSV.Items.Count > 0)
                cboMaSV.SelectedIndex = 0;
            
            dtpNgayTotNghiep.Value = DateTime.Now;
            cboXepLoai.SelectedIndex = -1;
            numSTCDatDuoc.Value = 0;
            numSTCYeuCau.Value = 0;
            maSV = string.Empty;
        }

        private void btnThemTotNghiep_Click(object sender, EventArgs e)
        {
            if (cboMaSV.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TotNghiep_ET tnET = new TotNghiep_ET
            {
                MaSV = cboMaSV.SelectedValue.ToString(),
                NgayTotNghiep = dtpNgayTotNghiep.Value,
                XepLoai = cboXepLoai.Text,
                TongSoTinChiDatDuoc = (int?)numSTCDatDuoc.Value,
                TongSoTinChiYeuCau = (int?)numSTCYeuCau.Value
            };

            if (tnBUS.ThemTotNghiep(tnET))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaTotNghiep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TotNghiep_ET tnET = new TotNghiep_ET
            {
                MaSV = maSV,
                NgayTotNghiep = dtpNgayTotNghiep.Value,
                XepLoai = cboXepLoai.Text,
                TongSoTinChiDatDuoc = (int?)numSTCDatDuoc.Value,
                TongSoTinChiYeuCau = (int?)numSTCYeuCau.Value
            };

            if (tnBUS.SuaTotNghiep(tnET))
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTotNghiep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (tnBUS.XoaTotNghiep(maSV))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvTotNghiep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTotNghiep.Rows[e.RowIndex];
                maSV = row.Cells["maSV"].Value.ToString();
                
                cboMaSV.Enabled = false;
                dtpNgayTotNghiep.Value = row.Cells["ngayTotNghiep"].Value != DBNull.Value 
                    ? Convert.ToDateTime(row.Cells["ngayTotNghiep"].Value) 
                    : DateTime.Now;
                
                cboXepLoai.Text = row.Cells["xepLoai"].Value?.ToString() ?? "Khá";
                
                numSTCDatDuoc.Value = row.Cells["tongSoTinChiDatDuoc"].Value != DBNull.Value 
                    ? Convert.ToDecimal(row.Cells["tongSoTinChiDatDuoc"].Value) 
                    : 0;
                
                numSTCYeuCau.Value = row.Cells["tongSoTinChiYeuCau"].Value != DBNull.Value 
                    ? Convert.ToDecimal(row.Cells["tongSoTinChiYeuCau"].Value) 
                    : 0;
            }
        }

        private void frmTotNghiep_GUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
