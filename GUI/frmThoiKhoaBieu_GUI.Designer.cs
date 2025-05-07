namespace GUI
{
    partial class frmThoiKhoaBieu_GUI
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
            this.btnXoaTKB = new System.Windows.Forms.Button();
            this.btnSuaTKB = new System.Windows.Forms.Button();
            this.btnThemTKB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayHoc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTKB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.cboMaHocPhan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpGBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpGKT = new System.Windows.Forms.DateTimePicker();
            this.numTBD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numTKT = new System.Windows.Forms.NumericUpDown();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTKT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaTKB
            // 
            this.btnXoaTKB.Location = new System.Drawing.Point(230, 205);
            this.btnXoaTKB.Name = "btnXoaTKB";
            this.btnXoaTKB.Size = new System.Drawing.Size(75, 52);
            this.btnXoaTKB.TabIndex = 41;
            this.btnXoaTKB.Text = "Xóa Thời Khóa Biểu";
            this.btnXoaTKB.UseVisualStyleBackColor = true;
            this.btnXoaTKB.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaTKB
            // 
            this.btnSuaTKB.Location = new System.Drawing.Point(377, 205);
            this.btnSuaTKB.Name = "btnSuaTKB";
            this.btnSuaTKB.Size = new System.Drawing.Size(75, 52);
            this.btnSuaTKB.TabIndex = 40;
            this.btnSuaTKB.Text = "Sửa Thời Khóa Biểu";
            this.btnSuaTKB.UseVisualStyleBackColor = true;
            this.btnSuaTKB.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemTKB
            // 
            this.btnThemTKB.Location = new System.Drawing.Point(77, 205);
            this.btnThemTKB.Name = "btnThemTKB";
            this.btnThemTKB.Size = new System.Drawing.Size(75, 52);
            this.btnThemTKB.TabIndex = 39;
            this.btnThemTKB.Text = "Thêm Thời Khóa Biểu";
            this.btnThemTKB.UseVisualStyleBackColor = true;
            this.btnThemTKB.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày Học:";
            // 
            // dtpNgayHoc
            // 
            this.dtpNgayHoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHoc.Location = new System.Drawing.Point(118, 91);
            this.dtpNgayHoc.Name = "dtpNgayHoc";
            this.dtpNgayHoc.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayHoc.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã Học Phần:";
            // 
            // txtTKB
            // 
            this.txtTKB.Location = new System.Drawing.Point(118, 15);
            this.txtTKB.Name = "txtTKB";
            this.txtTKB.Size = new System.Drawing.Size(100, 20);
            this.txtTKB.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã TKB:";
            // 
            // dgvTKB
            // 
            this.dgvTKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTKB.Location = new System.Drawing.Point(0, 295);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.Size = new System.Drawing.Size(514, 155);
            this.dgvTKB.TabIndex = 21;
            this.dgvTKB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKB_CellClick);
            // 
            // cboMaHocPhan
            // 
            this.cboMaHocPhan.FormattingEnabled = true;
            this.cboMaHocPhan.Location = new System.Drawing.Point(118, 57);
            this.cboMaHocPhan.Name = "cboMaHocPhan";
            this.cboMaHocPhan.Size = new System.Drawing.Size(100, 21);
            this.cboMaHocPhan.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Giờ Bắt Đầu:";
            // 
            // dtpGBD
            // 
            this.dtpGBD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGBD.Location = new System.Drawing.Point(118, 125);
            this.dtpGBD.Name = "dtpGBD";
            this.dtpGBD.ShowUpDown = true;
            this.dtpGBD.Size = new System.Drawing.Size(100, 20);
            this.dtpGBD.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Giờ Kết Thúc:";
            // 
            // dtpGKT
            // 
            this.dtpGKT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGKT.Location = new System.Drawing.Point(352, 15);
            this.dtpGKT.Name = "dtpGKT";
            this.dtpGKT.ShowUpDown = true;
            this.dtpGKT.Size = new System.Drawing.Size(100, 20);
            this.dtpGKT.TabIndex = 47;
            // 
            // numTBD
            // 
            this.numTBD.Location = new System.Drawing.Point(352, 50);
            this.numTBD.Name = "numTBD";
            this.numTBD.Size = new System.Drawing.Size(100, 20);
            this.numTBD.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tiết Bắt Đầu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Tiết Kết Thúc:";
            // 
            // numTKT
            // 
            this.numTKT.Location = new System.Drawing.Point(352, 88);
            this.numTKT.Name = "numTKT";
            this.numTKT.Size = new System.Drawing.Size(100, 20);
            this.numTKT.TabIndex = 51;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(351, 125);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(100, 20);
            this.txtPhong.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Phòng:";
            // 
            // frmThoiKhoaBieu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTKT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numTBD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpGKT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpGBD);
            this.Controls.Add(this.cboMaHocPhan);
            this.Controls.Add(this.btnXoaTKB);
            this.Controls.Add(this.btnSuaTKB);
            this.Controls.Add(this.btnThemTKB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTKB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTKB);
            this.Name = "frmThoiKhoaBieu_GUI";
            this.Text = "ThoiKhoaBieu_GUI";
            this.Load += new System.EventHandler(this.frmThoiKhoaBieu_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaTKB;
        private System.Windows.Forms.Button btnSuaTKB;
        private System.Windows.Forms.Button btnThemTKB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTKB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.ComboBox cboMaHocPhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpGBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpGKT;
        private System.Windows.Forms.NumericUpDown numTBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTKT;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label7;
    }
}