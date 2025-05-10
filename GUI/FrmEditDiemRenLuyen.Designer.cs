namespace GUI
{
    partial class FrmEditDiemRenLuyen
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
            this.cbBHocKy = new System.Windows.Forms.ComboBox();
            this.dtGVDiemRenLuyen = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemToiDa = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiemDatDuoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDiemRenLuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoc kỳ:";
            // 
            // cbBHocKy
            // 
            this.cbBHocKy.FormattingEnabled = true;
            this.cbBHocKy.Location = new System.Drawing.Point(155, 73);
            this.cbBHocKy.Name = "cbBHocKy";
            this.cbBHocKy.Size = new System.Drawing.Size(150, 28);
            this.cbBHocKy.TabIndex = 1;
            // 
            // dtGVDiemRenLuyen
            // 
            this.dtGVDiemRenLuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVDiemRenLuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVDiemRenLuyen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVDiemRenLuyen.Location = new System.Drawing.Point(0, 300);
            this.dtGVDiemRenLuyen.Name = "dtGVDiemRenLuyen";
            this.dtGVDiemRenLuyen.RowHeadersWidth = 62;
            this.dtGVDiemRenLuyen.RowTemplate.Height = 28;
            this.dtGVDiemRenLuyen.Size = new System.Drawing.Size(800, 150);
            this.dtGVDiemRenLuyen.TabIndex = 2;
            this.dtGVDiemRenLuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVDiemRenLuyen_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(537, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 42);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(338, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 41);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(155, 23);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(150, 26);
            this.txtMaSV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "MSSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điểm tối đa:";
            // 
            // txtDiemToiDa
            // 
            this.txtDiemToiDa.Location = new System.Drawing.Point(155, 125);
            this.txtDiemToiDa.Name = "txtDiemToiDa";
            this.txtDiemToiDa.Size = new System.Drawing.Size(150, 26);
            this.txtDiemToiDa.TabIndex = 7;
            this.txtDiemToiDa.TextChanged += new System.EventHandler(this.txtDiemToiDa_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(537, 82);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 42);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(537, 143);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 42);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(537, 206);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(112, 42);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới ";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Điểm đạt được:";
            // 
            // txtDiemDatDuoc
            // 
            this.txtDiemDatDuoc.Location = new System.Drawing.Point(155, 177);
            this.txtDiemDatDuoc.Name = "txtDiemDatDuoc";
            this.txtDiemDatDuoc.Size = new System.Drawing.Size(150, 26);
            this.txtDiemDatDuoc.TabIndex = 12;
            this.txtDiemDatDuoc.TextChanged += new System.EventHandler(this.txtDiemDatDuoc_TextChanged);
            // 
            // FrmEditDiemRenLuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiemDatDuoc);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiemToiDa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtGVDiemRenLuyen);
            this.Controls.Add(this.cbBHocKy);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditDiemRenLuyen";
            this.Text = "FrmEditDiemRenLuyen";
            this.Load += new System.EventHandler(this.FrmEditDiemRenLuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVDiemRenLuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBHocKy;
        private System.Windows.Forms.DataGridView dtGVDiemRenLuyen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemToiDa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiemDatDuoc;
    }
}