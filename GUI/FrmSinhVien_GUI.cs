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
    public partial class FrmSinhVien_GUI : Form
    {
        private string maAccount;

        public FrmSinhVien_GUI(string maAccount)
        {
            InitializeComponent();
            this.maAccount = maAccount;
        }


        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinSV_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new FrmThongTinSV_GUI(maAccount));
        }

        private void FrmSinhVien_GUI_Load(object sender, EventArgs e)
        {
            DangNhap_GUI dangNhap_GUI = new DangNhap_GUI();
           // string ma = dangNhap_GUI.LayTxtMa();
           // txtMaSV.Text = ma;
        }
    }
}
