namespace GUI
{
    partial class frmNhanVienQuanLy_GUI
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
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNVQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNVQuanLy = new System.Windows.Forms.DataGridView();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.cboAccountNVQL = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVQuanLy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(233, 221);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(75, 52);
            this.btnXoaSV.TabIndex = 41;
            this.btnXoaSV.Text = "Xóa NV Quản Lý";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Location = new System.Drawing.Point(380, 221);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(75, 52);
            this.btnSuaSV.TabIndex = 40;
            this.btnSuaSV.Text = "Sửa NV Quản Lý";
            this.btnSuaSV.UseVisualStyleBackColor = true;
            this.btnSuaSV.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(80, 221);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(75, 52);
            this.btnThemSV.TabIndex = 39;
            this.btnThemSV.Text = "Thêm NV Quản Lý";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Mã Khoa:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(355, 60);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Địa Chỉ:";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(355, 18);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(100, 20);
            this.txtSdt.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "SĐT:";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(179, 136);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(39, 17);
            this.rdoNu.TabIndex = 32;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(118, 136);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(47, 17);
            this.rdoNam.TabIndex = 31;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày Sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(118, 97);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySinh.TabIndex = 28;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(118, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Họ Tên:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email:";
            // 
            // txtMaNVQL
            // 
            this.txtMaNVQL.Location = new System.Drawing.Point(118, 15);
            this.txtMaNVQL.Name = "txtMaNVQL";
            this.txtMaNVQL.Size = new System.Drawing.Size(100, 20);
            this.txtMaNVQL.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã NV:";
            // 
            // dgvNVQuanLy
            // 
            this.dgvNVQuanLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNVQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNVQuanLy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNVQuanLy.Location = new System.Drawing.Point(0, 295);
            this.dgvNVQuanLy.Name = "dgvNVQuanLy";
            this.dgvNVQuanLy.Size = new System.Drawing.Size(563, 155);
            this.dgvNVQuanLy.TabIndex = 21;
            this.dgvNVQuanLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.FormattingEnabled = true;
            this.cboMaKhoa.Location = new System.Drawing.Point(355, 97);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(100, 21);
            this.cboMaKhoa.TabIndex = 42;
            // 
            // cboAccountNVQL
            // 
            this.cboAccountNVQL.FormattingEnabled = true;
            this.cboAccountNVQL.Location = new System.Drawing.Point(355, 131);
            this.cboAccountNVQL.Name = "cboAccountNVQL";
            this.cboAccountNVQL.Size = new System.Drawing.Size(100, 21);
            this.cboAccountNVQL.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Account:";
            // 
            // frmNhanVienQuanLy_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.cboAccountNVQL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboMaKhoa);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnSuaSV);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNVQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNVQuanLy);
            this.Name = "frmNhanVienQuanLy_GUI";
            this.Text = "NhanVienQuanLy_GUI";
            this.Load += new System.EventHandler(this.frmNhanVienQuanLy_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNVQuanLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNVQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNVQuanLy;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.ComboBox cboAccountNVQL;
        private System.Windows.Forms.Label label9;
    }
}