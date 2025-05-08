using BUS;
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
    public partial class FrmThongTinSV_GUI : Form
    {
        private string maAccount;

        public FrmThongTinSV_GUI(string maAccount)
        {
            InitializeComponent();
            this.maAccount = maAccount;
        }
        ThongTinSV_BUS ttSV_BUS = new ThongTinSV_BUS();

        private void FrmThongTinSV_GUI_Load(object sender, EventArgs e)
        {
            var sv = ttSV_BUS.LaySinhVienTheoAccount(maAccount);
            if (sv != null)
            {
                lbMaSV.Text = sv.MaSv;
                // điền thêm các thông tin khác nếu cần
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên.");
            }
        }
    }
}
