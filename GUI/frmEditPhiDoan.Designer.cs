namespace GUI
{
    partial class frmEditPhiDoan
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
            this.txtMaDoanPhi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPKNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dTPKNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtGVPhiDoan = new System.Windows.Forms.DataGridView();
            this.cbBMaHocKy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVPhiDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaDoanPhi
            // 
            this.txtMaDoanPhi.Location = new System.Drawing.Point(204, 67);
            this.txtMaDoanPhi.Name = "txtMaDoanPhi";
            this.txtMaDoanPhi.Size = new System.Drawing.Size(100, 26);
            this.txtMaDoanPhi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phí đoàn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã học kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(204, 140);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(100, 26);
            this.txtSoTien.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // dtPKNgayBatDau
            // 
            this.dtPKNgayBatDau.CustomFormat = "yyyy-MM-dd";
            this.dtPKNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPKNgayBatDau.Location = new System.Drawing.Point(429, 70);
            this.dtPKNgayBatDau.Name = "dtPKNgayBatDau";
            this.dtPKNgayBatDau.Size = new System.Drawing.Size(200, 26);
            this.dtPKNgayBatDau.TabIndex = 10;
            // 
            // dTPKNgayKetThuc
            // 
            this.dTPKNgayKetThuc.CustomFormat = "yyyy-MM-dd";
            this.dTPKNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPKNgayKetThuc.Location = new System.Drawing.Point(431, 149);
            this.dTPKNgayKetThuc.Name = "dTPKNgayKetThuc";
            this.dTPKNgayKetThuc.Size = new System.Drawing.Size(200, 26);
            this.dTPKNgayKetThuc.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(114, 279);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 37);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(291, 279);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 37);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(447, 279);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(113, 37);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(782, 83);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 80);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "In DS phí đoàn";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(616, 279);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(113, 37);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtGVPhiDoan
            // 
            this.dtGVPhiDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVPhiDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVPhiDoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVPhiDoan.Location = new System.Drawing.Point(0, 405);
            this.dtGVPhiDoan.Name = "dtGVPhiDoan";
            this.dtGVPhiDoan.RowHeadersWidth = 62;
            this.dtGVPhiDoan.RowTemplate.Height = 28;
            this.dtGVPhiDoan.Size = new System.Drawing.Size(967, 150);
            this.dtGVPhiDoan.TabIndex = 17;
            this.dtGVPhiDoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVPhiDoan_CellClick);
            // 
            // cbBMaHocKy
            // 
            this.cbBMaHocKy.FormattingEnabled = true;
            this.cbBMaHocKy.Location = new System.Drawing.Point(204, 210);
            this.cbBMaHocKy.Name = "cbBMaHocKy";
            this.cbBMaHocKy.Size = new System.Drawing.Size(100, 28);
            this.cbBMaHocKy.TabIndex = 18;
            // 
            // frmEditPhiDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.cbBMaHocKy);
            this.Controls.Add(this.dtGVPhiDoan);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dTPKNgayKetThuc);
            this.Controls.Add(this.dtPKNgayBatDau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDoanPhi);
            this.Name = "frmEditPhiDoan";
            this.Text = "frmEditPhiDoan";
            this.Load += new System.EventHandler(this.frmEditPhiDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVPhiDoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaDoanPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPKNgayBatDau;
        private System.Windows.Forms.DateTimePicker dTPKNgayKetThuc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dtGVPhiDoan;
        private System.Windows.Forms.ComboBox cbBMaHocKy;
    }
}