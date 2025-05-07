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
    public partial class FrmSinhVienChinh_GUI : Form
    {
        public FrmSinhVienChinh_GUI()
        {
            InitializeComponent();
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
            
            OpenChildForm(new frmThongTinSV_GUI());
        }
    }
}
