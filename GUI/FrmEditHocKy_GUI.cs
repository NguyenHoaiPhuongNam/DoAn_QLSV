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
    public partial class FrmEditHocKy_GUI : Form
    {
        public FrmEditHocKy_GUI()
        {
            InitializeComponent();
        }
        HocKy_BUS hkBus = new HocKy_BUS();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaHocKy.Text.Trim()=="" || txtTenHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    HocKy_ET hk = new HocKy_ET(txtMaHocKy.Text,txtTenHocKy.Text);
                    bool them = hkBus.ThemHocKy(hk);
                    if (them)
                    {
                        MessageBox.Show("Thêm thành công !");
                        dtGVHocKy.DataSource = hkBus.LayDSHocKy();
                    }
                    else
                    {
                        MessageBox.Show("Học kỳ này đã có. Vui lòng nhập học kỳ khác !");

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmEditHocKy_GUI_Load(object sender, EventArgs e)
        {
            dtGVHocKy.DataSource = hkBus.LayDSHocKy();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHocKy.Text.Trim() == "" )
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    var kt = hkBus.KT_MaKH(txtMaHocKy.Text);
                    if (kt)
                    {
                        MessageBox.Show("Học kỳ không tồn tại trong bảng học kỳ");
                    }
                    else
                    {
                        bool xoa = hkBus.XoaHocKy(txtMaHocKy.Text);
                        if (xoa)
                        {
                            MessageBox.Show("Xóa thành công !");
                            dtGVHocKy.DataSource = hkBus.LayDSHocKy();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại !");

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
            if (txtMaHocKy.Text.Trim() == "" || txtTenHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    HocKy_ET hk = new HocKy_ET(txtMaHocKy.Text, txtTenHocKy.Text);
                    bool sua = hkBus.SuaHocKy(hk);
                    if (sua)
                    {
                        dtGVHocKy.DataSource = hkBus.LayDSHocKy();
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại. Không tìm thất thấy học kỳ");
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
            txtMaHocKy.Clear();
            txtTenHocKy.Clear();
            txtMaHocKy.Focus();
            dtGVHocKy.DataSource = hkBus.LayDSHocKy();
        }

        private void dtGVHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            try
            {
                var cellValueMaHocKy = dtGVHocKy.Rows[dong].Cells[0].Value;
                var cellValueTenHocKy = dtGVHocKy.Rows[dong].Cells[1].Value;

                txtMaHocKy.Text = cellValueMaHocKy != null ? cellValueMaHocKy.ToString().Trim() : "";
                txtTenHocKy.Text = cellValueTenHocKy != null ? cellValueTenHocKy.ToString().Trim() : "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtMaHocKy.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                     dtGVHocKy.DataSource = hkBus.TimKiemHocKyTheoMa(txtMaHocKy.Text);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
