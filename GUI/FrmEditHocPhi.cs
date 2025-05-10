using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmEditHocPhi : Form
    {
        public FrmEditHocPhi()
        {
            InitializeComponent();
        }
        HocPhi_BUS hpBUS = new HocPhi_BUS();
        private void FrmEditHocPhi_Load(object sender, EventArgs e)
        {
            txtMaHocPhi.Focus();
            dtGVHocPhi.DataSource = hpBUS.LayDSHocPhi();
            cbBMaHocPhan.DataSource = hpBUS.LayDSMaHocPhan();
            cbBMaHocPhan.DisplayMember = "tenHocPhan";
            cbBMaHocPhan.ValueMember = "maHocPhan"; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHocPhi.Text.Trim() == "" && txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    if (hpBUS.KT_hocPhi(txtMaSV.Text, cbBMaHocPhan.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Sinh viên đã có trong bảng học phí ");
                    }
                    else
                    {
                        var ngay = DateTime.Parse("1/1/2000");
                        HocPhi_ET hpET = new HocPhi_ET(txtMaHocPhi.Text, txtMaSV.Text, cbBMaHocPhan.SelectedValue.ToString(), txtMaNhanVien.Text,
                                                        int.Parse(txtSoTinChi.Text), int.Parse(txtDonGia.Text), int.Parse(txtTongTien.Text), ngay, txtTrangThai.Text);
                        bool them = hpBUS.ThemHocPhi(hpET);

                        if (them)
                        {
                            MessageBox.Show("Thêm thành công");
                            dtGVHocPhi.DataSource = hpBUS.LayDSHocPhi();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thât bại");
                        }
                    }
                   
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void cbBMaHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbBMaHocPhan.Text))
            {
                txtSoTinChi.Text = Convert.ToString(hpBUS.LaySoTinChi(cbBMaHocPhan.SelectedValue.ToString()));
            }
            double tong = Convert.ToDouble(txtSoTinChi.Text) * Convert.ToDouble(txtDonGia.Text);
            txtTongTien.Text = tong.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHocPhi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    bool xoa = hpBUS.XoaHocPhi(txtMaHocPhi.Text);
                    if (xoa)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        dtGVHocPhi.DataSource = hpBUS.LayDSHocPhi();
                    }
                    else
                    {
                        MessageBox.Show("Xoa that bai");
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
            if (txtMaHocPhi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    HocPhi_ET hpET = new HocPhi_ET(txtMaHocPhi.Text, txtMaSV.Text, cbBMaHocPhan.SelectedValue.ToString(), txtMaNhanVien.Text,
                                                   int.Parse(txtSoTinChi.Text), int.Parse(txtDonGia.Text), int.Parse(txtTongTien.Text), dtPkNgayDongHocPhi.Value, txtTrangThai.Text);
                    bool sua = hpBUS.SuaHocPhi(hpET);
                    if (sua)
                    {
                        MessageBox.Show("Sua thanh cong");
                        dtGVHocPhi.DataSource = hpBUS.LayDSHocPhi();
                    }
                    else
                    {
                        MessageBox.Show("Sua that bai");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    dtGVHocPhi.DataSource = hpBUS.TimKiemHocPhiTheoMaSV(txtMaSV.Text);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHocPhi.Clear();
            txtMaSV.Clear();
            txtTrangThai.Text = "Chưa đóng";
            dtGVHocPhi.DataSource = hpBUS.LayDSHocPhi();

        }

        private void dtGVHocPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaHocPhi.Text = dtGVHocPhi.Rows[dong].Cells[0].Value.ToString().Trim();
            txtMaSV.Text = dtGVHocPhi.Rows[dong].Cells[1].Value.ToString().Trim();
            cbBMaHocPhan.SelectedValue = dtGVHocPhi.Rows[dong].Cells[2].Value.ToString();
            txtMaNhanVien.Text = dtGVHocPhi.Rows[dong].Cells[3].Value.ToString().Trim();
            var cellValue = dtGVHocPhi.Rows[dong].Cells[7].Value;

            if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
            {
                dtPkNgayDongHocPhi.Value = DateTime.Parse("1/1/2000");
            }
            else
            {
                dtPkNgayDongHocPhi.Value = Convert.ToDateTime(cellValue);
            }
            txtTrangThai.Text = dtGVHocPhi.Rows[dong].Cells[8].Value.ToString().Trim();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrangThai_TextChanged(object sender, EventArgs e)
        {
            if(txtTrangThai.Text == "Đã đóng")
            {
                dtPkNgayDongHocPhi.Value = DateTime.Now;
            }
        }
    }
}
