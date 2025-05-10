namespace GUI
{
    partial class frmSinhVienThamGiaSuKien
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvThamGia = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoata = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.btnDSSV = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cboMaSK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamGia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danh Sách Sinh Viên Tham Gia Sư Kiện";
            // 
            // dgvThamGia
            // 
            this.dgvThamGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThamGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThamGia.Location = new System.Drawing.Point(0, 287);
            this.dgvThamGia.Name = "dgvThamGia";
            this.dgvThamGia.RowHeadersWidth = 51;
            this.dgvThamGia.RowTemplate.Height = 24;
            this.dgvThamGia.Size = new System.Drawing.Size(933, 190);
            this.dgvThamGia.TabIndex = 10;
            this.dgvThamGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThamGia_CellClick);
            
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoata);
            this.groupBox2.Controls.Add(this.btnDS);
            this.groupBox2.Controls.Add(this.btnDSSV);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(486, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnThoata
            // 
            this.btnThoata.Location = new System.Drawing.Point(278, 111);
            this.btnThoata.Name = "btnThoata";
            this.btnThoata.Size = new System.Drawing.Size(84, 52);
            this.btnThoata.TabIndex = 5;
            this.btnThoata.Text = "Thoát";
            this.btnThoata.UseVisualStyleBackColor = true;
            this.btnThoata.Click += new System.EventHandler(this.btnThoata_Click);
            // 
            // btnDS
            // 
            this.btnDS.Location = new System.Drawing.Point(278, 35);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(84, 52);
            this.btnDS.TabIndex = 4;
            this.btnDS.Text = "In Danh Sách Tham Gia";
            this.btnDS.UseVisualStyleBackColor = true;
            // 
            // btnDSSV
            // 
            this.btnDSSV.Location = new System.Drawing.Point(142, 111);
            this.btnDSSV.Name = "btnDSSV";
            this.btnDSSV.Size = new System.Drawing.Size(115, 52);
            this.btnDSSV.TabIndex = 3;
            this.btnDSSV.Text = "Danh Sách SV Trong 1 SK";
            this.btnDSSV.UseVisualStyleBackColor = true;
            this.btnDSSV.Click += new System.EventHandler(this.btnDSSV_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(142, 32);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 52);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(16, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 52);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 52);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.cboMaSK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(174, 115);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(79, 30);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cboMaSK
            // 
            this.cboMaSK.FormattingEnabled = true;
            this.cboMaSK.Location = new System.Drawing.Point(119, 78);
            this.cboMaSK.Name = "cboMaSK";
            this.cboMaSK.Size = new System.Drawing.Size(121, 24);
            this.cboMaSK.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = " Mã Sinh Viên :";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(119, 29);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(121, 22);
            this.txtMaSV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sự Kiện:";
            // 
            // frmSinhVienThamGiaSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvThamGia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSinhVienThamGiaSuKien";
            this.Text = "frmSinhVienThamGiaSuKien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSinhVienThamGiaSuKien_FormClosing);
            this.Load += new System.EventHandler(this.frmSinhVienThamGiaSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamGia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvThamGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDS;
        private System.Windows.Forms.Button btnDSSV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoata;
        private System.Windows.Forms.ComboBox cboMaSK;
        private System.Windows.Forms.Button btnLamMoi;
    }
}