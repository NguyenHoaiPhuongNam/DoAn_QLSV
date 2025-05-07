namespace GUI
{
    partial class frmDiemHocPhan_GUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaLopHP = new System.Windows.Forms.ComboBox();
            this.btnXoaDiemHP = new System.Windows.Forms.Button();
            this.btnSuaDiemHP = new System.Windows.Forms.Button();
            this.btnThemDiemHP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvĐiemHocPhan = new System.Windows.Forms.DataGridView();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.txtDiemQuaTrinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvĐiemHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Điểm Quá Trình:";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(351, 55);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(100, 20);
            this.txtDiemThi.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Điểm Thi:";
            // 
            // cboMaLopHP
            // 
            this.cboMaLopHP.FormattingEnabled = true;
            this.cboMaLopHP.Location = new System.Drawing.Point(127, 52);
            this.cboMaLopHP.Name = "cboMaLopHP";
            this.cboMaLopHP.Size = new System.Drawing.Size(100, 21);
            this.cboMaLopHP.TabIndex = 84;
            // 
            // btnXoaDiemHP
            // 
            this.btnXoaDiemHP.Location = new System.Drawing.Point(229, 149);
            this.btnXoaDiemHP.Name = "btnXoaDiemHP";
            this.btnXoaDiemHP.Size = new System.Drawing.Size(75, 52);
            this.btnXoaDiemHP.TabIndex = 83;
            this.btnXoaDiemHP.Text = "Xóa Điểm Học Phần";
            this.btnXoaDiemHP.UseVisualStyleBackColor = true;
            this.btnXoaDiemHP.Click += new System.EventHandler(this.btnXoaDiemHP_Click);
            // 
            // btnSuaDiemHP
            // 
            this.btnSuaDiemHP.Location = new System.Drawing.Point(376, 149);
            this.btnSuaDiemHP.Name = "btnSuaDiemHP";
            this.btnSuaDiemHP.Size = new System.Drawing.Size(75, 52);
            this.btnSuaDiemHP.TabIndex = 82;
            this.btnSuaDiemHP.Text = "Sửa Điểm Học Phần";
            this.btnSuaDiemHP.UseVisualStyleBackColor = true;
            this.btnSuaDiemHP.Click += new System.EventHandler(this.btnSuaDiemHP_Click);
            // 
            // btnThemDiemHP
            // 
            this.btnThemDiemHP.Location = new System.Drawing.Point(76, 149);
            this.btnThemDiemHP.Name = "btnThemDiemHP";
            this.btnThemDiemHP.Size = new System.Drawing.Size(75, 52);
            this.btnThemDiemHP.TabIndex = 81;
            this.btnThemDiemHP.Text = "Thêm Điểm Học Phần";
            this.btnThemDiemHP.UseVisualStyleBackColor = true;
            this.btnThemDiemHP.Click += new System.EventHandler(this.btnThemDiemHP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Mã Lớp HP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Mã SV:";
            // 
            // dgvĐiemHocPhan
            // 
            this.dgvĐiemHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvĐiemHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvĐiemHocPhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvĐiemHocPhan.Location = new System.Drawing.Point(0, 253);
            this.dgvĐiemHocPhan.Name = "dgvĐiemHocPhan";
            this.dgvĐiemHocPhan.Size = new System.Drawing.Size(565, 197);
            this.dgvĐiemHocPhan.TabIndex = 77;
            this.dgvĐiemHocPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvĐiemHocPhan_CellClick);
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(127, 15);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(100, 21);
            this.cboMaSV.TabIndex = 89;
            // 
            // txtDiemQuaTrinh
            // 
            this.txtDiemQuaTrinh.Location = new System.Drawing.Point(351, 15);
            this.txtDiemQuaTrinh.Name = "txtDiemQuaTrinh";
            this.txtDiemQuaTrinh.Size = new System.Drawing.Size(100, 20);
            this.txtDiemQuaTrinh.TabIndex = 90;
            // 
            // frmDiemHocPhan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.txtDiemQuaTrinh);
            this.Controls.Add(this.cboMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiemThi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMaLopHP);
            this.Controls.Add(this.btnXoaDiemHP);
            this.Controls.Add(this.btnSuaDiemHP);
            this.Controls.Add(this.btnThemDiemHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvĐiemHocPhan);
            this.Name = "frmDiemHocPhan_GUI";
            this.Text = "DiemHocPhan_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvĐiemHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaLopHP;
        private System.Windows.Forms.Button btnXoaDiemHP;
        private System.Windows.Forms.Button btnSuaDiemHP;
        private System.Windows.Forms.Button btnThemDiemHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvĐiemHocPhan;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.TextBox txtDiemQuaTrinh;
    }
}