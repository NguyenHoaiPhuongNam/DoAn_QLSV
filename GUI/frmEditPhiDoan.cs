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
    public partial class frmEditPhiDoan : Form
    {
        public frmEditPhiDoan()
        {
            InitializeComponent();
        }
        PhiDoan_BUS phiDoan_BUS = new PhiDoan_BUS();


        private void dtGVPhiDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaDoanPhi.Text = dtGVPhiDoan.Rows[dong].Cells[0].Value.ToString();
            txtSoTien.Text = dtGVPhiDoan.Rows[dong].Cells[1].Value.ToString();
            cbBMaHocKy.SelectedValue = dtGVPhiDoan.Rows[dong].Cells[2].Value.ToString();
            dtPKNgayBatDau.Text = dtGVPhiDoan.Rows[dong].Cells[3].Value.ToString();
            dTPKNgayKetThuc.Text = dtGVPhiDoan.Rows[dong].Cells[4].Value.ToString();
            txtMaDoanPhi.Enabled = false;
        }

        private void frmEditPhiDoan_Load(object sender, EventArgs e)
        {
            dtGVPhiDoan.DataSource = phiDoan_BUS.LayDSPhiDoan();
            cbBMaHocKy.DataSource = phiDoan_BUS.LayDSHocKy();
            cbBMaHocKy.DisplayMember = "tenHocKy";
            cbBMaHocKy.ValueMember = "maHocKy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaDoanPhi.Text.Trim() == "" ||txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else if(dtPKNgayBatDau.Value >= dTPKNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");

            }
            else
            {
                try
                {
                    PhiDoan_ET phiDoan_ET = new PhiDoan_ET()
                    {
                        MaPhi = txtMaDoanPhi.Text,
                        SoTien = Convert.ToInt32(txtSoTien.Text),
                        MaHocKy = cbBMaHocKy.SelectedValue.ToString(),
                        NgayBatDau = Convert.ToDateTime(dtPKNgayBatDau.Value),
                        NgayKetThuc = Convert.ToDateTime(dTPKNgayKetThuc.Value)
                    };

                    bool them = phiDoan_BUS.ThemPhiDoan(phiDoan_ET);
                    if (them)
                    {
                        MessageBox.Show("Thêm thành công");
                        dtGVPhiDoan.DataSource = phiDoan_BUS.LayDSPhiDoan();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaDoanPhi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                bool tonTai = phiDoan_BUS.kT_TonTai_MaPhi_BenBangKhac(txtMaDoanPhi.Text);
                if (tonTai)
                {
                    MessageBox.Show("Mã phí đoàn có tồn tại bên PhieuThuDoanPhi");
                }
                else
                {
                    DialogResult muonXoa = MessageBox.Show("Bạn có muốn xóa ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (muonXoa == DialogResult.Yes)
                    {
                        try
                        {
                            bool xoa = phiDoan_BUS.XoaPhiDoan(txtMaDoanPhi.Text);
                            if (xoa)
                            {
                                MessageBox.Show("Xóa thành công");
                                dtGVPhiDoan.DataSource = phiDoan_BUS.LayDSPhiDoan();
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
                
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDoanPhi.Text.Trim() == "" || txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else if (dtPKNgayBatDau.Value >= dTPKNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");

            }
            else
            {
                try
                {
                    PhiDoan_ET phiDoan_ET = new PhiDoan_ET()
                    {
                        MaPhi = txtMaDoanPhi.Text,
                        SoTien = Convert.ToInt32(txtSoTien.Text),
                        MaHocKy = cbBMaHocKy.SelectedValue.ToString(),
                        NgayBatDau = Convert.ToDateTime(dtPKNgayBatDau.Value),
                        NgayKetThuc = Convert.ToDateTime(dTPKNgayKetThuc.Value)
                    };

                    bool xoa = phiDoan_BUS.SuaPhiDoan(phiDoan_ET);
                    if (xoa)
                    {
                        MessageBox.Show("Sửa thành công");
                        dtGVPhiDoan.DataSource = phiDoan_BUS.LayDSPhiDoan();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDoanPhi.Clear();
            txtSoTien.Clear();
            cbBMaHocKy.SelectedIndex = 0;
            dtPKNgayBatDau.Value = DateTime.Now;
            dTPKNgayKetThuc.Value = DateTime.Now;
            txtMaDoanPhi.Enabled = true;
        }
    }
}
