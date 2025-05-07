namespace GUI
{
    partial class frmSinhVienn_GUI
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.cboAccountSV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.btnThongTin1SV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 295);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(525, 155);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(33, 216);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(75, 52);
            this.btnThemSV.TabIndex = 18;
            this.btnThemSV.Text = "Thêm Sinh Viên";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Location = new System.Drawing.Point(245, 216);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(75, 52);
            this.btnSuaSV.TabIndex = 19;
            this.btnSuaSV.Text = "Sửa Sinh Viên";
            this.btnSuaSV.UseVisualStyleBackColor = true;
            this.btnSuaSV.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(134, 216);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(75, 52);
            this.btnXoaSV.TabIndex = 20;
            this.btnXoaSV.Text = "Xóa Sinh Viên";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cboAccountSV
            // 
            this.cboAccountSV.FormattingEnabled = true;
            this.cboAccountSV.Location = new System.Drawing.Point(360, 125);
            this.cboAccountSV.Name = "cboAccountSV";
            this.cboAccountSV.Size = new System.Drawing.Size(100, 21);
            this.cboAccountSV.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Account:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(360, 54);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Địa Chỉ:";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(360, 12);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(100, 20);
            this.txtSdt.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "SĐT:";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(184, 130);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(39, 17);
            this.rdoNu.TabIndex = 55;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(123, 130);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(47, 17);
            this.rdoNam.TabIndex = 54;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ngày Sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(123, 91);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySinh.TabIndex = 51;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(123, 51);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Họ Tên:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Email:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(123, 9);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSV.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mã SV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Lớp Học:";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(360, 90);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(100, 21);
            this.cboLopHoc.TabIndex = 65;
            // 
            // btnThongTin1SV
            // 
            this.btnThongTin1SV.Location = new System.Drawing.Point(360, 216);
            this.btnThongTin1SV.Name = "btnThongTin1SV";
            this.btnThongTin1SV.Size = new System.Drawing.Size(75, 52);
            this.btnThongTin1SV.TabIndex = 66;
            this.btnThongTin1SV.Text = "Thông Tin 1 Sinh Viên";
            this.btnThongTin1SV.UseVisualStyleBackColor = true;
            this.btnThongTin1SV.Click += new System.EventHandler(this.btnThongTin1SV_Click);
            // 
            // frmSinhVien_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.btnThongTin1SV);
            this.Controls.Add(this.cboLopHoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboAccountSV);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnSuaSV);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "frmSinhVien_GUI";
            this.Text = "SinhVien_GUI";
            this.Load += new System.EventHandler(this.frmSinhVien_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.ComboBox cboAccountSV;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.Button btnThongTin1SV;
    }
}