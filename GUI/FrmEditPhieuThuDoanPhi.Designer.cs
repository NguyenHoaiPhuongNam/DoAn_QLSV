namespace GUI
{
    partial class FrmEditPhieuThuDoanPhi
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
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtMaSVThuPhi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSVNopPhi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dtGVPhieuThuDoanPhi = new System.Windows.Forms.DataGridView();
            this.dtPKNgayThu = new System.Windows.Forms.DateTimePicker();
            this.cbBMaPhi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVPhieuThuDoanPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(279, 71);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(130, 26);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // txtMaSVThuPhi
            // 
            this.txtMaSVThuPhi.Location = new System.Drawing.Point(279, 131);
            this.txtMaSVThuPhi.Name = "txtMaSVThuPhi";
            this.txtMaSVThuPhi.Size = new System.Drawing.Size(130, 26);
            this.txtMaSVThuPhi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên thu phí:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sinh viên nộp phí:";
            // 
            // txtMaSVNopPhi
            // 
            this.txtMaSVNopPhi.Location = new System.Drawing.Point(279, 201);
            this.txtMaSVNopPhi.Name = "txtMaSVNopPhi";
            this.txtMaSVNopPhi.Size = new System.Drawing.Size(130, 26);
            this.txtMaSVNopPhi.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã phí:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày thu:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(220, 297);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 55);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(394, 297);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 55);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(560, 297);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 55);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(725, 297);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(109, 55);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(814, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "In DS phiếu thu đoàn phí";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dtGVPhieuThuDoanPhi
            // 
            this.dtGVPhieuThuDoanPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVPhieuThuDoanPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVPhieuThuDoanPhi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVPhieuThuDoanPhi.Location = new System.Drawing.Point(0, 420);
            this.dtGVPhieuThuDoanPhi.Name = "dtGVPhieuThuDoanPhi";
            this.dtGVPhieuThuDoanPhi.RowHeadersWidth = 62;
            this.dtGVPhieuThuDoanPhi.RowTemplate.Height = 28;
            this.dtGVPhieuThuDoanPhi.Size = new System.Drawing.Size(1123, 273);
            this.dtGVPhieuThuDoanPhi.TabIndex = 5;
            this.dtGVPhieuThuDoanPhi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVPhieuThuDoanPhi_CellClick);
            // 
            // dtPKNgayThu
            // 
            this.dtPKNgayThu.CustomFormat = "yyyy-MM-dd";
            this.dtPKNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPKNgayThu.Location = new System.Drawing.Point(576, 134);
            this.dtPKNgayThu.Name = "dtPKNgayThu";
            this.dtPKNgayThu.Size = new System.Drawing.Size(136, 26);
            this.dtPKNgayThu.TabIndex = 6;
            // 
            // cbBMaPhi
            // 
            this.cbBMaPhi.FormattingEnabled = true;
            this.cbBMaPhi.Location = new System.Drawing.Point(576, 65);
            this.cbBMaPhi.Name = "cbBMaPhi";
            this.cbBMaPhi.Size = new System.Drawing.Size(136, 28);
            this.cbBMaPhi.TabIndex = 7;
            // 
            // FrmEditPhieuThuDoanPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 693);
            this.Controls.Add(this.cbBMaPhi);
            this.Controls.Add(this.dtPKNgayThu);
            this.Controls.Add(this.dtGVPhieuThuDoanPhi);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSVNopPhi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaSVThuPhi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditPhieuThuDoanPhi";
            this.Text = "FrmEditPhieuThuDoanPhi";
            this.Load += new System.EventHandler(this.FrmEditPhieuThuDoanPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVPhieuThuDoanPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtMaSVThuPhi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSVNopPhi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dtGVPhieuThuDoanPhi;
        private System.Windows.Forms.DateTimePicker dtPKNgayThu;
        private System.Windows.Forms.ComboBox cbBMaPhi;
    }
}