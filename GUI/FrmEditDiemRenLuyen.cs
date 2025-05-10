using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmEditDiemRenLuyen : Form
    {
        public FrmEditDiemRenLuyen()
        {
            InitializeComponent();
        }
        DiemRenLuyen_BUS drlBUS = new DiemRenLuyen_BUS();
        private void FrmEditDiemRenLuyen_Load(object sender, EventArgs e)
        {
            dtGVDiemRenLuyen.DataSource = drlBUS.LayDSDiemRenLuyen();
            cbBHocKy.DataSource = drlBUS.LayHocKy();
            cbBHocKy.DisplayMember = "tenHocKy";
            cbBHocKy.ValueMember = "maHocKy";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtDiemToiDa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {

                    DiemRenLuyen_ET drlET = new DiemRenLuyen_ET(txtMaSV.Text, cbBHocKy.SelectedValue.ToString(),
                                                            int.Parse(txtDiemToiDa.Text),int.Parse(txtDiemDatDuoc.Text));
                    
                    bool them = drlBUS.ThemDiemRenLuyen(drlET);
                    if (them)
                    {
                        MessageBox.Show("Thêm thành công");
                        dtGVDiemRenLuyen.DataSource = drlBUS.LayDSDiemRenLuyen();
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên này đã có điểm rèn luyện trong học kỳ này!");
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
            dtGVDiemRenLuyen.DataSource = drlBUS.TimKiemDRLTheoMaSV(txtMaSV.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
                return;
            }

            try
            {
                bool kt = drlBUS.KT_maSV_maHk_TonTai(txtMaSV.Text, cbBHocKy.SelectedValue.ToString());
                bool xoaThanhCong = drlBUS.XoaDiemRenLuyen(txtMaSV.Text, cbBHocKy.SelectedValue.ToString());
                if (kt)
                {
                    MessageBox.Show("Sinh viên không có trong bảng điểm rèn luyện");
                }
                else
                {
                    if (xoaThanhCong)
                    {
                        MessageBox.Show("Xóa thành công");
                        dtGVDiemRenLuyen.DataSource = drlBUS.LayDSDiemRenLuyen();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtDiemToiDa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập dữ liệu");
            }
            else
            {
                try
                {
                    DiemRenLuyen_ET drlET = new DiemRenLuyen_ET(txtMaSV.Text, cbBHocKy.SelectedValue.ToString(),
                                                             int.Parse(txtDiemToiDa.Text), int.Parse(txtDiemDatDuoc.Text));
                    bool sua = drlBUS.SuaDrl(drlET);
                    if (sua)
                    {
                        MessageBox.Show("Sua thanh cong");
                        dtGVDiemRenLuyen.DataSource = drlBUS.LayDSDiemRenLuyen();
                    }
                    else
                    {
                        MessageBox.Show("Sua that bai");

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
            txtDiemToiDa.Clear();
            txtMaSV.Clear();
            txtDiemDatDuoc.Clear();
            txtMaSV.Focus();
            txtMaSV.Enabled = true;
            cbBHocKy.Enabled = true;
            dtGVDiemRenLuyen.DataSource = drlBUS.LayDSDiemRenLuyen();

        }

        private void dtGVDiemRenLuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMaSV.Text = dtGVDiemRenLuyen.Rows[dong].Cells[0].Value.ToString();
            cbBHocKy.SelectedValue = dtGVDiemRenLuyen.Rows[dong].Cells[1].Value.ToString();
            txtDiemToiDa.Text = dtGVDiemRenLuyen.Rows[dong].Cells[2].Value.ToString();
            txtDiemDatDuoc.Text = dtGVDiemRenLuyen.Rows[dong].Cells[3].Value.ToString();
            txtMaSV.Enabled = false;
            cbBHocKy.Enabled = false;
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

        private void txtDiemDatDuoc_TextChanged(object sender, EventArgs e)
        {
            string input = txtDiemDatDuoc.Text;

            if (string.IsNullOrWhiteSpace(input))
                return;

            if (!int.TryParse(input, out int diemDatDuoc))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemDatDuoc.Text = "";
                txtDiemDatDuoc.Focus();
                return;
            }

            if (diemDatDuoc > 100)
            {
                txtDiemDatDuoc.Text = "100";
                txtDiemDatDuoc.SelectionStart = txtDiemDatDuoc.Text.Length;
                return;
            }

            if (int.TryParse(txtDiemToiDa.Text, out int diemToiDa))
            {
                if (diemDatDuoc > diemToiDa)
                {
                    MessageBox.Show("Điểm đạt được không thể lớn hơn điểm tối đa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiemDatDuoc.Text = "";
                    txtDiemDatDuoc.Focus();
                }
            }
        }
    }
}
