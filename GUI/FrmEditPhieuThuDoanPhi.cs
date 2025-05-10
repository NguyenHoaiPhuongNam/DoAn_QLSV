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
    public partial class FrmEditPhieuThuDoanPhi : Form
    {
        public FrmEditPhieuThuDoanPhi()
        {
            InitializeComponent();
        }
        PhieuThuDoanPhi_BUS phieuThuDoanPhi_BUS = new PhieuThuDoanPhi_BUS();

        private void FrmEditPhieuThuDoanPhi_Load(object sender, EventArgs e)
        {
            dtGVPhieuThuDoanPhi.DataSource = phieuThuDoanPhi_BUS.LayDSPhieuThuDoanPhi();
            cbBMaPhi.DataSource = phieuThuDoanPhi_BUS.LayDSPhiDoan();
            cbBMaPhi.DisplayMember = "maPhi";
            cbBMaPhi.ValueMember = "maPhi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaPhieu.Text.Trim() == ""|| txtMaSVNopPhi.Text.Trim() == "" || txtMaSVThuPhi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
               
            }
            else if(txtMaSVNopPhi.Text == txtMaSVThuPhi.Text)
            {
                MessageBox.Show("Mã sinh viên thu phí và sinh viên nộp phí không được trùng nhau");
                

            }
            else
            {
                try
                {
                    PhieuThuDoanPhi_ET phieuThuDoanPhi_ET = new PhieuThuDoanPhi_ET()
                    {
                        MaPhieu = txtMaPhieu.Text,
                        MaSVThuPhi = txtMaSVThuPhi.Text,
                        MaSVNopPhi = txtMaSVNopPhi.Text,
                        MaPhi = cbBMaPhi.SelectedValue.ToString(),
                        NgayThu = dtPKNgayThu.Value
                    };
                    bool them = phieuThuDoanPhi_BUS.ThemPhieuThuDoanPhi(phieuThuDoanPhi_ET);
                    if (them)
                    {
                        MessageBox.Show("Thêm thành công");
                        dtGVPhieuThuDoanPhi.DataSource = phieuThuDoanPhi_BUS.LayDSPhieuThuDoanPhi();
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
            try
            {
                if (txtMaPhieu.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu");
                }
                else
                {
                    bool xoa = phieuThuDoanPhi_BUS.XoaPhieuThuDoanPhi(txtMaPhieu.Text);
                    if (xoa)
                    {
                        MessageBox.Show("Xóa thành công");
                        dtGVPhieuThuDoanPhi.DataSource = phieuThuDoanPhi_BUS.LayDSPhieuThuDoanPhi();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text.Trim() == "" || txtMaSVNopPhi.Text.Trim() == "" || txtMaSVThuPhi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");

            }
            else if (txtMaSVNopPhi.Text == txtMaSVThuPhi.Text)
            {
                MessageBox.Show("Mã sinh viên thu phí và sinh viên nộp phí không được trùng nhau");


            }
            else
            {
                try
                {
                    PhieuThuDoanPhi_ET phieuThuDoanPhi_ET = new PhieuThuDoanPhi_ET()
                    {
                        MaPhieu = txtMaPhieu.Text,
                        MaSVThuPhi = txtMaSVThuPhi.Text,
                        MaSVNopPhi = txtMaSVNopPhi.Text,
                        MaPhi = cbBMaPhi.SelectedValue.ToString(),
                        NgayThu = dtPKNgayThu.Value
                    };
                    bool sua = phieuThuDoanPhi_BUS.SuaPhieuThuDoanPhi(phieuThuDoanPhi_ET);
                    if (sua)
                    {
                        MessageBox.Show("Sửa thành công");
                        dtGVPhieuThuDoanPhi.DataSource = phieuThuDoanPhi_BUS.LayDSPhieuThuDoanPhi();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtGVPhieuThuDoanPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaPhieu.Text = dtGVPhieuThuDoanPhi.Rows[dong].Cells[0].Value.ToString().Trim();
            txtMaSVThuPhi.Text = dtGVPhieuThuDoanPhi.Rows[dong].Cells[1].Value.ToString().Trim();
            txtMaSVNopPhi.Text = dtGVPhieuThuDoanPhi.Rows[dong].Cells[2].Value.ToString().Trim();
            cbBMaPhi.Text = dtGVPhieuThuDoanPhi.Rows[dong].Cells[3].Value.ToString();
            dtPKNgayThu.Text = dtGVPhieuThuDoanPhi.Rows[dong].Cells[4].Value.ToString();
            txtMaPhieu.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtMaSVNopPhi.Clear();
            txtMaSVThuPhi.Clear();
            cbBMaPhi.SelectedIndex = 0;
            dtPKNgayThu.Value = DateTime.Now;
            txtMaPhieu.Enabled = true;
        }
    }
}
