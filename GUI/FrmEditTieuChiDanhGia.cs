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
    public partial class FrmEditTieuChiDanhGia : Form
    {
        public FrmEditTieuChiDanhGia()
        {
            InitializeComponent();
        }
        TieuChiDanhGia_BUS tcdgBUS = new TieuChiDanhGia_BUS();
        private void FrmEditTieuChiDanhGia_Load(object sender, EventArgs e)
        {
            dtGVTieuChiDanhGia.DataSource = tcdgBUS.LayDsTieuChiDanhGia();
            txtMaTieuChi.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaTieuChi.Text.Trim()=="" || txtTenTieuChi.Text.Trim() == "" || txtDiemToiDa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    TieuChiDanhGia_ET tcdgET = new TieuChiDanhGia_ET()
                    {
                        MaTieuChi = txtMaTieuChi.Text,
                        TenTieuChi = txtTenTieuChi.Text,
                        DiemToiDa = int.Parse(txtDiemToiDa.Text)
                    };
                    bool them = tcdgBUS.ThemTieuChiDanhGia(tcdgET);
                    if (them)
                    {
                        MessageBox.Show("Thêm thành công");
                        dtGVTieuChiDanhGia.DataSource = tcdgBUS.LayDsTieuChiDanhGia();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTieuChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    bool xoa = tcdgBUS.XoaTieuChiDanhGia(txtMaTieuChi.Text);
                    if (xoa)
                    {
                        MessageBox.Show("Xóa thành công");
                        dtGVTieuChiDanhGia.DataSource = tcdgBUS.LayDsTieuChiDanhGia();
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaTieuChi.Text.Trim() == "" || txtTenTieuChi.Text.Trim() == "" || txtDiemToiDa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    TieuChiDanhGia_ET tcdgET = new TieuChiDanhGia_ET()
                    {
                        MaTieuChi = txtMaTieuChi.Text,
                        TenTieuChi = txtTenTieuChi.Text,
                        DiemToiDa = int.Parse(txtDiemToiDa.Text)
                    };
                    bool sua = tcdgBUS.SuaTieuChi(tcdgET);
                    if (sua)
                    {
                        dtGVTieuChiDanhGia.DataSource = tcdgBUS.LayDsTieuChiDanhGia();
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtGVTieuChiDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaTieuChi.Text = dtGVTieuChiDanhGia.Rows[dong].Cells[0].Value.ToString();
            txtTenTieuChi.Text = dtGVTieuChiDanhGia.Rows[dong].Cells[1].Value.ToString();
            txtDiemToiDa.Text = dtGVTieuChiDanhGia.Rows[dong].Cells[2].Value.ToString();
            txtMaTieuChi.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTieuChi.Clear();
            txtTenTieuChi.Clear();
            txtDiemToiDa.Clear();
            txtMaTieuChi.Enabled = true;
            txtMaTieuChi.Focus();
            dtGVTieuChiDanhGia.DataSource = tcdgBUS.LayDsTieuChiDanhGia();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtMaTieuChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã tiêu chí");
            }
            else
                dtGVTieuChiDanhGia.DataSource = tcdgBUS.TimKiemTieuChi(txtMaTieuChi.Text);
        }

        private void txtDiemToiDa_TextChanged(object sender, EventArgs e)
        {
            string input = txtDiemToiDa.Text;

            if (string.IsNullOrWhiteSpace(input)) return;

            if (!int.TryParse(input, out int diem))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemToiDa.Text = "";
                txtDiemToiDa.Focus();
                return;
            }

            if (diem > 100)
            {
                txtDiemToiDa.Text = "100";
                txtDiemToiDa.SelectionStart = txtDiemToiDa.Text.Length;
            }
        }
    }
}
