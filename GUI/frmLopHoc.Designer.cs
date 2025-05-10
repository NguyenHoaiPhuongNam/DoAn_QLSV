namespace GUI
{
    partial class frmLopHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.cboMaNganh = new System.Windows.Forms.ComboBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInDSLop = new System.Windows.Forms.Button();
            this.btnThongTinLopHoc = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLopHoc = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.cboMaGV);
            this.groupBox1.Controls.Add(this.cboMaNganh);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.txtKhoaHoc);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(376, 114);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(83, 25);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboMaGV
            // 
            this.cboMaGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(338, 62);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(121, 24);
            this.cboMaGV.TabIndex = 9;
            // 
            // cboMaNganh
            // 
            this.cboMaNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNganh.FormattingEnabled = true;
            this.cboMaNganh.Location = new System.Drawing.Point(338, 13);
            this.cboMaNganh.Name = "cboMaNganh";
            this.cboMaNganh.Size = new System.Drawing.Size(121, 24);
            this.cboMaNganh.TabIndex = 8;
            this.cboMaNganh.SelectedIndexChanged += new System.EventHandler(this.cboMaNganh_SelectedIndexChanged);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(99, 64);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(100, 22);
            this.txtTenLop.TabIndex = 7;
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(99, 117);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(100, 22);
            this.txtKhoaHoc.TabIndex = 6;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(99, 15);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 22);
            this.txtMaLop.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Giảng Viên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Ngành :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khóa Học :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lớp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnInDSLop);
            this.groupBox2.Controls.Add(this.btnThongTinLopHoc);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(529, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(157, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 59);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(25, 93);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 59);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(157, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 59);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInDSLop
            // 
            this.btnInDSLop.Location = new System.Drawing.Point(157, 93);
            this.btnInDSLop.Name = "btnInDSLop";
            this.btnInDSLop.Size = new System.Drawing.Size(91, 59);
            this.btnInDSLop.TabIndex = 2;
            this.btnInDSLop.Text = "In Danh Sách Lớp";
            this.btnInDSLop.UseVisualStyleBackColor = true;
            // 
            // btnThongTinLopHoc
            // 
            this.btnThongTinLopHoc.Location = new System.Drawing.Point(25, 166);
            this.btnThongTinLopHoc.Name = "btnThongTinLopHoc";
            this.btnThongTinLopHoc.Size = new System.Drawing.Size(91, 59);
            this.btnThongTinLopHoc.TabIndex = 1;
            this.btnThongTinLopHoc.Text = "Thông Tin 1 Lớp";
            this.btnThongTinLopHoc.UseVisualStyleBackColor = true;
            this.btnThongTinLopHoc.Click += new System.EventHandler(this.btnThongTinLopHoc_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(25, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 59);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Danh  Sách Các Lớp Học";
            // 
            // dgvLopHoc
            // 
            this.dgvLopHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLopHoc.Location = new System.Drawing.Point(0, 300);
            this.dgvLopHoc.Name = "dgvLopHoc";
            this.dgvLopHoc.RowHeadersWidth = 51;
            this.dgvLopHoc.RowTemplate.Height = 24;
            this.dgvLopHoc.Size = new System.Drawing.Size(800, 150);
            this.dgvLopHoc.TabIndex = 11;
            this.dgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopHoc_CellClick);
            // 
            // frmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLopHoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLopHoc";
            this.Text = "frmLopHoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLopHoc_FormClosing);
            this.Load += new System.EventHandler(this.frmLopHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.ComboBox cboMaNganh;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInDSLop;
        private System.Windows.Forms.Button btnThongTinLopHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLopHoc;
        private System.Windows.Forms.Button btnLamMoi;
    }
}