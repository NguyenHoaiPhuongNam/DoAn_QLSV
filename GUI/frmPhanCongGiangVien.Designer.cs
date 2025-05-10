namespace GUI
{
    partial class frmPhanCongGiangVien
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
            this.dgvDanhSachPC = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPC1GV = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaHP = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPC)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danh Sách Phân Công";
            // 
            // dgvDanhSachPC
            // 
            this.dgvDanhSachPC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachPC.Location = new System.Drawing.Point(0, 260);
            this.dgvDanhSachPC.Name = "dgvDanhSachPC";
            this.dgvDanhSachPC.RowHeadersWidth = 51;
            this.dgvDanhSachPC.RowTemplate.Height = 24;
            this.dgvDanhSachPC.Size = new System.Drawing.Size(800, 190);
            this.dgvDanhSachPC.TabIndex = 10;
            this.dgvDanhSachPC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPC_CellClick);
            this.dgvDanhSachPC.Click += new System.EventHandler(this.dgvDanhSachPC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPC1GV);
            this.groupBox2.Controls.Add(this.btnDS);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(415, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 172);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btnPC1GV
            // 
            this.btnPC1GV.Location = new System.Drawing.Point(254, 111);
            this.btnPC1GV.Name = "btnPC1GV";
            this.btnPC1GV.Size = new System.Drawing.Size(113, 52);
            this.btnPC1GV.TabIndex = 5;
            this.btnPC1GV.Text = "Phân Công 1 Giảng Viên";
            this.btnPC1GV.UseVisualStyleBackColor = true;
            this.btnPC1GV.Click += new System.EventHandler(this.btnPC1GV_Click);
            // 
            // btnDS
            // 
            this.btnDS.Location = new System.Drawing.Point(245, 35);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(84, 52);
            this.btnDS.TabIndex = 4;
            this.btnDS.Text = "In Danh Sách Giang Viên";
            this.btnDS.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(130, 111);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(130, 35);
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
            this.groupBox1.Controls.Add(this.cboMaHP);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cboMaHP
            // 
            this.cboMaHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHP.FormattingEnabled = true;
            this.cboMaHP.Location = new System.Drawing.Point(132, 80);
            this.cboMaHP.Name = "cboMaHP";
            this.cboMaHP.Size = new System.Drawing.Size(122, 24);
            this.cboMaHP.TabIndex = 6;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(246, 123);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(77, 28);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Học Phần :";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(132, 29);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(122, 22);
            this.txtMa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giảng Viên :";
            // 
            // frmPhanCongGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDanhSachPC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhanCongGiangVien";
            this.Text = "frmPhanCongGiangVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanCongGiangVien_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanCongGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDanhSachPC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPC1GV;
        private System.Windows.Forms.ComboBox cboMaHP;
    }
}