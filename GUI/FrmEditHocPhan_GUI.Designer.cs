namespace GUI
{
    partial class FrmEditHocPhan_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHocPhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenHocPhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtGVHocPhan = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBTenHocKy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBLoaiHocPhan = new System.Windows.Forms.ComboBox();
            this.cbBSoTinChi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần:";
            // 
            // txtMaHocPhan
            // 
            this.txtMaHocPhan.Location = new System.Drawing.Point(170, 64);
            this.txtMaHocPhan.Name = "txtMaHocPhan";
            this.txtMaHocPhan.Size = new System.Drawing.Size(100, 26);
            this.txtMaHocPhan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên học phần:";
            // 
            // txtTenHocPhan
            // 
            this.txtTenHocPhan.Location = new System.Drawing.Point(170, 117);
            this.txtTenHocPhan.Name = "txtTenHocPhan";
            this.txtTenHocPhan.Size = new System.Drawing.Size(100, 26);
            this.txtTenHocPhan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số tín chỉ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(297, 56);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 43);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(549, 56);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 43);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(549, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(668, 56);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(109, 43);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(668, 127);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 43);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtGVHocPhan
            // 
            this.dtGVHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVHocPhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVHocPhan.Location = new System.Drawing.Point(0, 302);
            this.dtGVHocPhan.Name = "dtGVHocPhan";
            this.dtGVHocPhan.RowHeadersWidth = 62;
            this.dtGVHocPhan.RowTemplate.Height = 28;
            this.dtGVHocPhan.Size = new System.Drawing.Size(844, 150);
            this.dtGVHocPhan.TabIndex = 3;
            this.dtGVHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVHocPhan_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên học kỳ:";
            // 
            // cbBTenHocKy
            // 
            this.cbBTenHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBTenHocKy.FormattingEnabled = true;
            this.cbBTenHocKy.Location = new System.Drawing.Point(170, 174);
            this.cbBTenHocKy.Name = "cbBTenHocKy";
            this.cbBTenHocKy.Size = new System.Drawing.Size(100, 28);
            this.cbBTenHocKy.TabIndex = 4;
            this.cbBTenHocKy.SelectedIndexChanged += new System.EventHandler(this.cbBTenHocKy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại học phần:";
            // 
            // cbBLoaiHocPhan
            // 
            this.cbBLoaiHocPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBLoaiHocPhan.FormattingEnabled = true;
            this.cbBLoaiHocPhan.Items.AddRange(new object[] {
            "Bắt buộc",
            "Tự Chọn"});
            this.cbBLoaiHocPhan.Location = new System.Drawing.Point(417, 113);
            this.cbBLoaiHocPhan.Name = "cbBLoaiHocPhan";
            this.cbBLoaiHocPhan.Size = new System.Drawing.Size(100, 28);
            this.cbBLoaiHocPhan.TabIndex = 6;
            // 
            // cbBSoTinChi
            // 
            this.cbBSoTinChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBSoTinChi.FormattingEnabled = true;
            this.cbBSoTinChi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbBSoTinChi.Location = new System.Drawing.Point(170, 230);
            this.cbBSoTinChi.Name = "cbBSoTinChi";
            this.cbBSoTinChi.Size = new System.Drawing.Size(100, 28);
            this.cbBSoTinChi.TabIndex = 7;
            // 
            // FrmEditHocPhan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 452);
            this.Controls.Add(this.cbBSoTinChi);
            this.Controls.Add(this.cbBLoaiHocPhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBTenHocKy);
            this.Controls.Add(this.dtGVHocPhan);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenHocPhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaHocPhan);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditHocPhan_GUI";
            this.Text = "FrmEditHocPhan_GUI";
            this.Load += new System.EventHandler(this.FrmEditHocPhan_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHocPhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHocPhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dtGVHocPhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBTenHocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBLoaiHocPhan;
        private System.Windows.Forms.ComboBox cbBSoTinChi;
    }
}