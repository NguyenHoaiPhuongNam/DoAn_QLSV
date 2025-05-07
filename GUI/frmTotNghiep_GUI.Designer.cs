namespace GUI
{
    partial class frmTotNghiep_GUI
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
            this.btnXoaHocBong = new System.Windows.Forms.Button();
            this.btnSuaHocBong = new System.Windows.Forms.Button();
            this.btnThemHocBong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayTotNghiep = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTotNghiep = new System.Windows.Forms.DataGridView();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboXepLoai = new System.Windows.Forms.ComboBox();
            this.numSTCDatDuoc = new System.Windows.Forms.NumericUpDown();
            this.numSTCYeuCau = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotNghiep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTCDatDuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTCYeuCau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaHocBong
            // 
            this.btnXoaHocBong.Location = new System.Drawing.Point(234, 165);
            this.btnXoaHocBong.Name = "btnXoaHocBong";
            this.btnXoaHocBong.Size = new System.Drawing.Size(75, 52);
            this.btnXoaHocBong.TabIndex = 41;
            this.btnXoaHocBong.Text = "Xóa SV Tốt Nghiệp";
            this.btnXoaHocBong.UseVisualStyleBackColor = true;
            this.btnXoaHocBong.Click += new System.EventHandler(this.btnXoaTotNghiep_Click);
            // 
            // btnSuaHocBong
            // 
            this.btnSuaHocBong.Location = new System.Drawing.Point(381, 165);
            this.btnSuaHocBong.Name = "btnSuaHocBong";
            this.btnSuaHocBong.Size = new System.Drawing.Size(75, 52);
            this.btnSuaHocBong.TabIndex = 40;
            this.btnSuaHocBong.Text = "Sửa SV Tốt Nghiệp";
            this.btnSuaHocBong.UseVisualStyleBackColor = true;
            this.btnSuaHocBong.Click += new System.EventHandler(this.btnSuaTotNghiep_Click);
            // 
            // btnThemHocBong
            // 
            this.btnThemHocBong.Location = new System.Drawing.Point(81, 165);
            this.btnThemHocBong.Name = "btnThemHocBong";
            this.btnThemHocBong.Size = new System.Drawing.Size(75, 52);
            this.btnThemHocBong.TabIndex = 39;
            this.btnThemHocBong.Text = "Thêm SV Tốt Nghiệp";
            this.btnThemHocBong.UseVisualStyleBackColor = true;
            this.btnThemHocBong.Click += new System.EventHandler(this.btnThemTotNghiep_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tổng STC Yêu Cầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ngày Tốt Nghiệp:";
            // 
            // dtpNgayTotNghiep
            // 
            this.dtpNgayTotNghiep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTotNghiep.Location = new System.Drawing.Point(135, 51);
            this.dtpNgayTotNghiep.Name = "dtpNgayTotNghiep";
            this.dtpNgayTotNghiep.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayTotNghiep.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tổng STC Đạt Đươc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã SV:";
            // 
            // dgvTotNghiep
            // 
            this.dgvTotNghiep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotNghiep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotNghiep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTotNghiep.Location = new System.Drawing.Point(0, 262);
            this.dgvTotNghiep.Name = "dgvTotNghiep";
            this.dgvTotNghiep.Size = new System.Drawing.Size(579, 188);
            this.dgvTotNghiep.TabIndex = 21;
            this.dgvTotNghiep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotNghiep_CellClick);
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(135, 15);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(100, 21);
            this.cboMaSV.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Xếp Loại:";
            // 
            // cboXepLoai
            // 
            this.cboXepLoai.FormattingEnabled = true;
            this.cboXepLoai.Location = new System.Drawing.Point(135, 87);
            this.cboXepLoai.Name = "cboXepLoai";
            this.cboXepLoai.Size = new System.Drawing.Size(100, 21);
            this.cboXepLoai.TabIndex = 45;
            // 
            // numSTCDatDuoc
            // 
            this.numSTCDatDuoc.Location = new System.Drawing.Point(404, 16);
            this.numSTCDatDuoc.Name = "numSTCDatDuoc";
            this.numSTCDatDuoc.Size = new System.Drawing.Size(120, 20);
            this.numSTCDatDuoc.TabIndex = 46;
            // 
            // numSTCYeuCau
            // 
            this.numSTCYeuCau.Location = new System.Drawing.Point(404, 53);
            this.numSTCYeuCau.Name = "numSTCYeuCau";
            this.numSTCYeuCau.Size = new System.Drawing.Size(120, 20);
            this.numSTCYeuCau.TabIndex = 47;
            // 
            // frmTotNghiep_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.numSTCYeuCau);
            this.Controls.Add(this.numSTCDatDuoc);
            this.Controls.Add(this.cboXepLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMaSV);
            this.Controls.Add(this.btnXoaHocBong);
            this.Controls.Add(this.btnSuaHocBong);
            this.Controls.Add(this.btnThemHocBong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayTotNghiep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTotNghiep);
            this.Name = "frmTotNghiep_GUI";
            this.Text = "Quản lý sinh viên tốt nghiệp";
            this.Load += new System.EventHandler(this.frmTotNghiep_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotNghiep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTCDatDuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTCYeuCau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaHocBong;
        private System.Windows.Forms.Button btnSuaHocBong;
        private System.Windows.Forms.Button btnThemHocBong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayTotNghiep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTotNghiep;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboXepLoai;
        private System.Windows.Forms.NumericUpDown numSTCDatDuoc;
        private System.Windows.Forms.NumericUpDown numSTCYeuCau;
    }
}