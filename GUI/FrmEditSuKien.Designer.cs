namespace GUI
{
    partial class FrmEditSuKien
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
            this.txtMaSuKien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSuKien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemCong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dtGVSuKien = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.dtPKthoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtPKthoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVSuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sự kiên:";
            // 
            // txtMaSuKien
            // 
            this.txtMaSuKien.Location = new System.Drawing.Point(263, 53);
            this.txtMaSuKien.Name = "txtMaSuKien";
            this.txtMaSuKien.Size = new System.Drawing.Size(100, 26);
            this.txtMaSuKien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sự kiện:";
            // 
            // txtTenSuKien
            // 
            this.txtTenSuKien.Location = new System.Drawing.Point(263, 132);
            this.txtTenSuKien.Name = "txtTenSuKien";
            this.txtTenSuKien.Size = new System.Drawing.Size(100, 26);
            this.txtTenSuKien.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm cộng:";
            // 
            // txtDiemCong
            // 
            this.txtDiemCong.Location = new System.Drawing.Point(263, 225);
            this.txtDiemCong.Name = "txtDiemCong";
            this.txtDiemCong.Size = new System.Drawing.Size(100, 26);
            this.txtDiemCong.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian bắt đầu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian kết thúc:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(253, 313);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 55);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(411, 313);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 55);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(565, 313);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 55);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(723, 313);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(116, 55);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtGVSuKien
            // 
            this.dtGVSuKien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVSuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVSuKien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVSuKien.Location = new System.Drawing.Point(0, 433);
            this.dtGVSuKien.Name = "dtGVSuKien";
            this.dtGVSuKien.RowHeadersWidth = 62;
            this.dtGVSuKien.RowTemplate.Height = 28;
            this.dtGVSuKien.Size = new System.Drawing.Size(1150, 271);
            this.dtGVSuKien.TabIndex = 3;
            this.dtGVSuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVSuKien_CellClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(895, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 55);
            this.button5.TabIndex = 4;
            this.button5.Text = "In DS sự kiện";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dtPKthoiGianBatDau
            // 
            this.dtPKthoiGianBatDau.CustomFormat = "yyyy-MM-dd";
            this.dtPKthoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPKthoiGianBatDau.Location = new System.Drawing.Point(612, 59);
            this.dtPKthoiGianBatDau.Name = "dtPKthoiGianBatDau";
            this.dtPKthoiGianBatDau.Size = new System.Drawing.Size(156, 26);
            this.dtPKthoiGianBatDau.TabIndex = 5;
            // 
            // dtPKthoiGianKetThuc
            // 
            this.dtPKthoiGianKetThuc.CustomFormat = "yyy-MM-dd";
            this.dtPKthoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPKthoiGianKetThuc.Location = new System.Drawing.Point(612, 138);
            this.dtPKthoiGianKetThuc.Name = "dtPKthoiGianKetThuc";
            this.dtPKthoiGianKetThuc.Size = new System.Drawing.Size(156, 26);
            this.dtPKthoiGianKetThuc.TabIndex = 6;
            // 
            // FrmEditSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 704);
            this.Controls.Add(this.dtPKthoiGianKetThuc);
            this.Controls.Add(this.dtPKthoiGianBatDau);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dtGVSuKien);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiemCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSuKien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSuKien);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditSuKien";
            this.Text = "SuKien_GUI";
            this.Load += new System.EventHandler(this.FrmEditSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVSuKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSuKien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSuKien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemCong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dtGVSuKien;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dtPKthoiGianBatDau;
        private System.Windows.Forms.DateTimePicker dtPKthoiGianKetThuc;
    }
}