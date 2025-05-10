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
    public partial class FrmEditKetQuaDanhGia_GUI : Form
    {
        public FrmEditKetQuaDanhGia_GUI()
        {
            InitializeComponent();
        }
        KetQuaDanhGia_BUS kqdgBUS = new KetQuaDanhGia_BUS();
        private void KetQuaDanhGia_GUI_Load(object sender, EventArgs e)
        {
            dtGVKetQuaDanhGia.DataSource = kqdgBUS.LayDSKetQuaDanhGia();
            cbBTenHocKy.DataSource = kqdgBUS.LayDSHocKy();
            cbBTenHocKy.DisplayMember = "tenHocKy";
            cbBTenHocKy.ValueMember = "maHocKy";
            cbBTenTieuChi.DataSource = kqdgBUS.LayDsTieuChiDanhGia();
            cbBTenTieuChi.DisplayMember = "tenTieuChi";
            cbBTenTieuChi.ValueMember = "maTieuChi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text.Trim()== "" || txtDiemDatDuoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    
                    KetQuaDanhGia_ET kqdgET = new KetQuaDanhGia_ET()
                    {
                        MaSv = txtMaSV.Text,
                        MaHocKy = cbBTenHocKy.SelectedValue.ToString(),
                        MaTieuChi = cbBTenTieuChi.SelectedValue.ToString(),
                        DiemDatDuoc = int.Parse(txtDiemDatDuoc.Text)

                    };
                    bool kt = kqdgBUS.KT_TonTaiKetQuaDanhGia(txtMaSV.Text, cbBTenHocKy.SelectedValue.ToString(), cbBTenTieuChi.SelectedValue.ToString());
                    if (kt == false)
                    {
                        MessageBox.Show("Kết quả đánh giá đã tồn tại");
                    }
                    else
                    {
                        bool them = kqdgBUS.ThemKetQuaDanhGia(kqdgET);
                        if (them)
                        {
                            MessageBox.Show("Thêm thành công");
                            dtGVKetQuaDanhGia.DataSource = kqdgBUS.LayDSKetQuaDanhGia();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                    }

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
               
                
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên");
            }
            else
            {
                try
                {
                    dtGVKetQuaDanhGia.DataSource = kqdgBUS.TimKiemKetQuaDanhGia(txtMaSV.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text.Trim()== "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên, chọn tên học kỳ, tên tiêu chí");
            }
            else
            {
                try
                {
                    var kt = kqdgBUS.KT_TonTaiKetQuaDanhGia(txtMaSV.Text, cbBTenHocKy.SelectedValue.ToString(), cbBTenTieuChi.SelectedValue.ToString());
                    if (kt)
                    {
                        MessageBox.Show("Kêt quả đánh giá không tồn tại trong bảng kết quả đánh giá");
                    }
                    else
                    {
                        DialogResult submit = MessageBox.Show("Bạn có muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (submit == DialogResult.Yes)
                        {
                            bool xoa = kqdgBUS.XoaKetQuaDanhGia(txtMaSV.Text, cbBTenHocKy.SelectedValue.ToString(), cbBTenTieuChi.SelectedValue.ToString());
                            if (xoa)
                            {
                                MessageBox.Show("Xóa thành công");
                                dtGVKetQuaDanhGia.DataSource = kqdgBUS.LayDSKetQuaDanhGia();
                            }
                            else
                            {
                                MessageBox.Show("Xóa thất bại");
                            }
                        }
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
            if (txtMaSV.Text.Trim() == "" || txtDiemDatDuoc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    

                        KetQuaDanhGia_ET kqdgET = new KetQuaDanhGia_ET()
                        {
                            MaSv = txtMaSV.Text,
                            MaHocKy = cbBTenHocKy.SelectedValue.ToString(),
                            MaTieuChi = cbBTenTieuChi.SelectedValue.ToString(),
                            DiemDatDuoc = int.Parse(txtDiemDatDuoc.Text)

                        };
                        bool sua = kqdgBUS.SuaKetQuaDanhGia(kqdgET);
                        if (sua)
                        {
                            MessageBox.Show("Sửa thành công");
                            dtGVKetQuaDanhGia.DataSource = kqdgBUS.LayDSKetQuaDanhGia();
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

        private void dtGVKetQuaDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSV.Text = dtGVKetQuaDanhGia.Rows[dong].Cells[0].Value.ToString();
            cbBTenHocKy.SelectedValue = dtGVKetQuaDanhGia.Rows[dong].Cells[1].Value.ToString();
            cbBTenTieuChi.SelectedValue = dtGVKetQuaDanhGia.Rows[dong].Cells[2].Value.ToString();
            txtDiemDatDuoc.Text = dtGVKetQuaDanhGia.Rows[dong].Cells[3].Value.ToString();
            txtMaSV.Enabled = false;
            cbBTenTieuChi.Enabled = false;
            cbBTenHocKy.Enabled = false;
            txtDiemDatDuoc.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtDiemDatDuoc.Clear();
            cbBTenHocKy.SelectedIndex = 0;
            cbBTenTieuChi.SelectedIndex = 0;
            txtMaSV.Enabled = true;
            cbBTenHocKy.Enabled = true;
            cbBTenTieuChi.Enabled = true;
        }
    }
}
