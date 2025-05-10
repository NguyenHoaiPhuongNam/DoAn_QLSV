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
    public partial class FrmEditHocPhan_GUI : Form
    {
        public FrmEditHocPhan_GUI()
        {
            InitializeComponent();
        }
        HocPhan_BUS hpBus = new HocPhan_BUS();

        private void FrmEditHocPhan_GUI_Load(object sender, EventArgs e)
        {
            try
            {
                dtGVHocPhan.DataSource = hpBus.LayDSHocPhan();
                cbBTenHocKy.DataSource = hpBus.LayDSHocKy();
                cbBTenHocKy.DisplayMember = "tenHocKy";
                cbBTenHocKy.ValueMember = "maHocKy";
                cbBSoTinChi.Text = "1";
                cbBLoaiHocPhan.Text = "Bắt buộc";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void dtGVHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaHocPhan.Text = dtGVHocPhan.Rows[dong].Cells[0].Value.ToString().Trim();
            txtTenHocPhan.Text = dtGVHocPhan.Rows[dong].Cells[1].Value.ToString().Trim();
            cbBTenHocKy.SelectedValue = dtGVHocPhan.Rows[dong].Cells[2].Value.ToString();
            cbBLoaiHocPhan.SelectedItem = dtGVHocPhan.Rows[dong].Cells[3].Value.ToString();
            cbBSoTinChi.SelectedItem = dtGVHocPhan.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaHocPhan.Text.Trim()== ""&& txtTenHocPhan.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }
            else
            {
                try
                {
                    HocPhan_ET hpET = new HocPhan_ET()
                    {
                        MaHocPhan = txtMaHocPhan.Text,
                        TenHocPhan = txtTenHocPhan.Text,
                        MaHocKy = cbBTenHocKy.SelectedValue.ToString(),
                        LoaiHP = cbBLoaiHocPhan.Text,
                        SoTinChi = int.Parse(cbBSoTinChi.Text)
                    };
                    bool them = hpBus.ThemHocPhan(hpET);
                    if (them)
                    {
                        MessageBox.Show("Thêm thành công");
                        dtGVHocPhan.DataSource = hpBus.LayDSHocPhan();
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

        private void cbBTenHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaHocPhan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã học phần");
            }
            else
            {
                try
                {
                    bool xoa = hpBus.XoaHocPhan(txtMaHocPhan.Text);
                    if (xoa)
                    {
                        dtGVHocPhan.DataSource = hpBus.LayDSHocPhan();
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
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
            if (txtMaHocPhan.Text.Trim() == "" && txtTenHocPhan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }
            else
            {
                try
                {
                    HocPhan_ET hpET = new HocPhan_ET()
                    {
                        MaHocPhan = txtMaHocPhan.Text,
                        TenHocPhan = txtTenHocPhan.Text,
                        MaHocKy = cbBTenHocKy.SelectedValue.ToString(),
                        LoaiHP = cbBLoaiHocPhan.Text,
                        SoTinChi = int.Parse(cbBSoTinChi.Text)
                    };
                    bool sua = hpBus.SuaHocPhan(hpET);
                    if (sua)
                    {
                        dtGVHocPhan.DataSource = hpBus.LayDSHocPhan();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtMaHocPhan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã học phần");
            }
            else
            {
                try
                {
                   dtGVHocPhan.DataSource = hpBus.TimKiemHocPhan(txtMaHocPhan.Text);
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHocPhan.Clear();
            txtTenHocPhan.Clear();
            txtMaHocPhan.Focus();
            dtGVHocPhan.DataSource = hpBus.LayDSHocPhan();
            cbBSoTinChi.Text = "1";
            cbBLoaiHocPhan.Text = "Bắt buộc";
        }
    }
}
