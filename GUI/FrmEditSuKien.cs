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
    public partial class FrmEditSuKien : Form
    {
        public FrmEditSuKien()
        {
            InitializeComponent();
        }
        SuKien_BUS suKien_BUS = new SuKien_BUS();
        private void FrmEditSuKien_Load(object sender, EventArgs e)
        {
            dtGVSuKien.DataSource = suKien_BUS.LayDSSuKien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSuKien.Text.Trim() == "" || txtTenSuKien.Text.Trim() == "" || txtDiemCong.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu");
                }
                else if (dtPKthoiGianBatDau.Value > dtPKthoiGianKetThuc.Value)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu");
                }
                else
                {
                    SuKien_ET suKien_ET = new SuKien_ET()
                    {
                        MaSK = txtMaSuKien.Text,
                        TenSK = txtTenSuKien.Text,
                        DiemCong = Convert.ToInt16(txtDiemCong.Text),
                        ThoiGianBatDau = dtPKthoiGianBatDau.Value,
                        ThoiGianKetThuc = dtPKthoiGianKetThuc.Value
                    };
                    bool them = suKien_BUS.ThemSuKien(suKien_ET);
                    if (them)
                    {
                        MessageBox.Show("Thêm  thành công");
                        dtGVSuKien.DataSource = suKien_BUS.LayDSSuKien();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSuKien.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu");
                }
                else
                {
                    bool xoa = suKien_BUS.XoaSuKien(txtMaSuKien.Text);
                    if (xoa)
                    {
                        MessageBox.Show("Xóa thành công");
                        dtGVSuKien.DataSource = suKien_BUS.LayDSSuKien();
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
            try
            {
                if (txtMaSuKien.Text.Trim() == "" || txtTenSuKien.Text.Trim() == "" || txtDiemCong.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập dữ liệu");
                }
                else if (dtPKthoiGianBatDau.Value > dtPKthoiGianKetThuc.Value)
                {
                    MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu");
                }
                else
                {
                    SuKien_ET suKien_ET = new SuKien_ET()
                    {
                        MaSK = txtMaSuKien.Text,
                        TenSK = txtTenSuKien.Text,
                        DiemCong = Convert.ToInt16(txtDiemCong.Text),
                        ThoiGianBatDau = dtPKthoiGianBatDau.Value,
                        ThoiGianKetThuc = dtPKthoiGianKetThuc.Value
                    };
                    bool them = suKien_BUS.SuaSuKien(suKien_ET);
                    if (them)
                    {
                        MessageBox.Show("Sửa thành công");
                        dtGVSuKien.DataSource = suKien_BUS.LayDSSuKien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtGVSuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSuKien.Text = dtGVSuKien.Rows[dong].Cells[0].Value.ToString();
            txtTenSuKien.Text = dtGVSuKien.Rows[dong].Cells[1].Value.ToString();
            txtDiemCong.Text = dtGVSuKien.Rows[dong].Cells[2].Value.ToString();
            dtPKthoiGianBatDau.Text = dtGVSuKien.Rows[dong].Cells[3].Value.ToString();
            dtPKthoiGianKetThuc.Text = dtGVSuKien.Rows[dong].Cells[4].Value.ToString();
            txtMaSuKien.Enabled = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSuKien.Clear();
            txtTenSuKien.Clear();
            txtDiemCong.Clear();
            dtPKthoiGianBatDau.Value = DateTime.Now;
            dtPKthoiGianKetThuc.Value = DateTime.Now;
            txtMaSuKien.Enabled = true;
        }
    }
}
