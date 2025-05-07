namespace GUI
{
    partial class frmSinhVienVPHocVu_GUI
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
            this.btnXoaSVVPHocVu = new System.Windows.Forms.Button();
            this.btnSuaSVVPHocVu = new System.Windows.Forms.Button();
            this.btnThemSVVPHocVu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHinhThucXuLy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayViPham = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaViPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSVVPHocVu = new System.Windows.Forms.DataGridView();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLoaiViPham = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numDiemTru = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVVPHocVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemTru)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaSVVPHocVu
            // 
            this.btnXoaSVVPHocVu.Location = new System.Drawing.Point(230, 205);
            this.btnXoaSVVPHocVu.Name = "btnXoaSVVPHocVu";
            this.btnXoaSVVPHocVu.Size = new System.Drawing.Size(75, 52);
            this.btnXoaSVVPHocVu.TabIndex = 41;
            this.btnXoaSVVPHocVu.Text = "Xóa SV Vi Phạm Học Vụ";
            this.btnXoaSVVPHocVu.UseVisualStyleBackColor = true;
            this.btnXoaSVVPHocVu.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaSVVPHocVu
            // 
            this.btnSuaSVVPHocVu.Location = new System.Drawing.Point(377, 205);
            this.btnSuaSVVPHocVu.Name = "btnSuaSVVPHocVu";
            this.btnSuaSVVPHocVu.Size = new System.Drawing.Size(75, 52);
            this.btnSuaSVVPHocVu.TabIndex = 40;
            this.btnSuaSVVPHocVu.Text = "Sửa SV Vi Phạm Học Vụ";
            this.btnSuaSVVPHocVu.UseVisualStyleBackColor = true;
            this.btnSuaSVVPHocVu.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemSVVPHocVu
            // 
            this.btnThemSVVPHocVu.Location = new System.Drawing.Point(93, 205);
            this.btnThemSVVPHocVu.Name = "btnThemSVVPHocVu";
            this.btnThemSVVPHocVu.Size = new System.Drawing.Size(75, 52);
            this.btnThemSVVPHocVu.TabIndex = 39;
            this.btnThemSVVPHocVu.Text = "Thêm SV Vi Phạm Học Vụ";
            this.btnThemSVVPHocVu.UseVisualStyleBackColor = true;
            this.btnThemSVVPHocVu.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Điểm Trừ:";
            // 
            // txtHinhThucXuLy
            // 
            this.txtHinhThucXuLy.Location = new System.Drawing.Point(383, 78);
            this.txtHinhThucXuLy.Name = "txtHinhThucXuLy";
            this.txtHinhThucXuLy.Size = new System.Drawing.Size(100, 20);
            this.txtHinhThucXuLy.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Hình Thức Xử Lý:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày Vi Phạm:";
            // 
            // dtpNgayViPham
            // 
            this.dtpNgayViPham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayViPham.Location = new System.Drawing.Point(118, 111);
            this.dtpNgayViPham.Name = "dtpNgayViPham";
            this.dtpNgayViPham.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayViPham.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã SV:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(383, 49);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(100, 20);
            this.txtMoTa.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mô Tả:";
            // 
            // txtMaViPham
            // 
            this.txtMaViPham.Location = new System.Drawing.Point(118, 15);
            this.txtMaViPham.Name = "txtMaViPham";
            this.txtMaViPham.Size = new System.Drawing.Size(100, 20);
            this.txtMaViPham.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Vi Phạm:";
            // 
            // dgvSVVPHocVu
            // 
            this.dgvSVVPHocVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSVVPHocVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSVVPHocVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSVVPHocVu.Location = new System.Drawing.Point(0, 295);
            this.dgvSVVPHocVu.Name = "dgvSVVPHocVu";
            this.dgvSVVPHocVu.Size = new System.Drawing.Size(534, 155);
            this.dgvSVVPHocVu.TabIndex = 21;
            this.dgvSVVPHocVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViPham_CellClick);
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(118, 45);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(100, 21);
            this.cboMaSV.TabIndex = 42;
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(118, 75);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(100, 21);
            this.cboHocKy.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Mã Học Kỳ:";
            // 
            // txtLoaiViPham
            // 
            this.txtLoaiViPham.Location = new System.Drawing.Point(383, 15);
            this.txtLoaiViPham.Name = "txtLoaiViPham";
            this.txtLoaiViPham.Size = new System.Drawing.Size(100, 20);
            this.txtLoaiViPham.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Loại Vi Phạm:";
            // 
            // numDiemTru
            // 
            this.numDiemTru.Location = new System.Drawing.Point(383, 110);
            this.numDiemTru.Name = "numDiemTru";
            this.numDiemTru.Size = new System.Drawing.Size(100, 20);
            this.numDiemTru.TabIndex = 49;
            // 
            // frmSinhVienVPHocVu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.numDiemTru);
            this.Controls.Add(this.txtLoaiViPham);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboMaSV);
            this.Controls.Add(this.btnXoaSVVPHocVu);
            this.Controls.Add(this.btnSuaSVVPHocVu);
            this.Controls.Add(this.btnThemSVVPHocVu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHinhThucXuLy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayViPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaViPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSVVPHocVu);
            this.Name = "frmSinhVienVPHocVu_GUI";
            this.Text = "SinhVienVPHocVu_GUI";
            this.Load += new System.EventHandler(this.frmSinhVienVPHocVu_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSVVPHocVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemTru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaSVVPHocVu;
        private System.Windows.Forms.Button btnSuaSVVPHocVu;
        private System.Windows.Forms.Button btnThemSVVPHocVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHinhThucXuLy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayViPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaViPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSVVPHocVu;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoaiViPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDiemTru;
    }
}