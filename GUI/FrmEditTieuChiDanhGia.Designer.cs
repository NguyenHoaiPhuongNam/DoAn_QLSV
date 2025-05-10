namespace GUI
{
    partial class FrmEditTieuChiDanhGia
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
            this.txtMaTieuChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTieuChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemToiDa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtGVTieuChiDanhGia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVTieuChiDanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tiêu chí:";
            // 
            // txtMaTieuChi
            // 
            this.txtMaTieuChi.Location = new System.Drawing.Point(209, 49);
            this.txtMaTieuChi.Name = "txtMaTieuChi";
            this.txtMaTieuChi.Size = new System.Drawing.Size(100, 26);
            this.txtMaTieuChi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tiêu chí:";
            // 
            // txtTenTieuChi
            // 
            this.txtTenTieuChi.Location = new System.Drawing.Point(209, 112);
            this.txtTenTieuChi.Name = "txtTenTieuChi";
            this.txtTenTieuChi.Size = new System.Drawing.Size(199, 26);
            this.txtTenTieuChi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm tối đa:";
            // 
            // txtDiemToiDa
            // 
            this.txtDiemToiDa.Location = new System.Drawing.Point(209, 184);
            this.txtDiemToiDa.Name = "txtDiemToiDa";
            this.txtDiemToiDa.Size = new System.Drawing.Size(100, 26);
            this.txtDiemToiDa.TabIndex = 1;
            this.txtDiemToiDa.TextChanged += new System.EventHandler(this.txtDiemToiDa_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(359, 45);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(114, 36);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(508, 49);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 36);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(508, 104);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(508, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(636, 49);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 36);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtGVTieuChiDanhGia
            // 
            this.dtGVTieuChiDanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVTieuChiDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVTieuChiDanhGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVTieuChiDanhGia.Location = new System.Drawing.Point(0, 292);
            this.dtGVTieuChiDanhGia.Name = "dtGVTieuChiDanhGia";
            this.dtGVTieuChiDanhGia.RowHeadersWidth = 62;
            this.dtGVTieuChiDanhGia.RowTemplate.Height = 28;
            this.dtGVTieuChiDanhGia.Size = new System.Drawing.Size(1012, 215);
            this.dtGVTieuChiDanhGia.TabIndex = 3;
            this.dtGVTieuChiDanhGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVTieuChiDanhGia_CellClick);
            // 
            // FrmEditTieuChiDanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 507);
            this.Controls.Add(this.dtGVTieuChiDanhGia);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtDiemToiDa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenTieuChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaTieuChi);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditTieuChiDanhGia";
            this.Text = "FrmEditTieuChiDanhGia";
            this.Load += new System.EventHandler(this.FrmEditTieuChiDanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVTieuChiDanhGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTieuChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTieuChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemToiDa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dtGVTieuChiDanhGia;
    }
}