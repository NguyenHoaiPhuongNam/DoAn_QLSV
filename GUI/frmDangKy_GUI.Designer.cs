namespace GUI
{
    partial class frmDangKy_GUI
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
            this.cboMaHP = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.btnXoaDangKy = new System.Windows.Forms.Button();
            this.btnSuaDangKy = new System.Windows.Forms.Button();
            this.btnThemDangKy = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDangKy = new System.Windows.Forms.DataGridView();
            this.cboMaLopHP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaHK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMaHP
            // 
            this.cboMaHP.FormattingEnabled = true;
            this.cboMaHP.Location = new System.Drawing.Point(137, 75);
            this.cboMaHP.Name = "cboMaHP";
            this.cboMaHP.Size = new System.Drawing.Size(100, 21);
            this.cboMaHP.TabIndex = 63;
            this.cboMaHP.SelectedIndexChanged += new System.EventHandler(this.cboMaHP_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Mã Học Phần:";
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(137, 45);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(100, 21);
            this.cboMaSV.TabIndex = 61;
            // 
            // btnXoaDangKy
            // 
            this.btnXoaDangKy.Location = new System.Drawing.Point(233, 147);
            this.btnXoaDangKy.Name = "btnXoaDangKy";
            this.btnXoaDangKy.Size = new System.Drawing.Size(75, 52);
            this.btnXoaDangKy.TabIndex = 60;
            this.btnXoaDangKy.Text = "Xóa Đăng Ký";
            this.btnXoaDangKy.UseVisualStyleBackColor = true;
            this.btnXoaDangKy.Click += new System.EventHandler(this.btnXoaDangKy_Click);
            // 
            // btnSuaDangKy
            // 
            this.btnSuaDangKy.Location = new System.Drawing.Point(380, 147);
            this.btnSuaDangKy.Name = "btnSuaDangKy";
            this.btnSuaDangKy.Size = new System.Drawing.Size(75, 52);
            this.btnSuaDangKy.TabIndex = 59;
            this.btnSuaDangKy.Text = "Sửa Đăng Ký";
            this.btnSuaDangKy.UseVisualStyleBackColor = true;
            this.btnSuaDangKy.Click += new System.EventHandler(this.btnSuaDangKy_Click);
            // 
            // btnThemDangKy
            // 
            this.btnThemDangKy.Location = new System.Drawing.Point(96, 147);
            this.btnThemDangKy.Name = "btnThemDangKy";
            this.btnThemDangKy.Size = new System.Drawing.Size(75, 52);
            this.btnThemDangKy.TabIndex = 58;
            this.btnThemDangKy.Text = "Thêm Đăng Ký";
            this.btnThemDangKy.UseVisualStyleBackColor = true;
            this.btnThemDangKy.Click += new System.EventHandler(this.btnThemDangKy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã SV:";
            // 
            // dgvDangKy
            // 
            this.dgvDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangKy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDangKy.Location = new System.Drawing.Point(0, 271);
            this.dgvDangKy.Name = "dgvDangKy";
            this.dgvDangKy.Size = new System.Drawing.Size(554, 179);
            this.dgvDangKy.TabIndex = 47;
            this.dgvDangKy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDangKy_CellClick);
            // 
            // cboMaLopHP
            // 
            this.cboMaLopHP.FormattingEnabled = true;
            this.cboMaLopHP.Location = new System.Drawing.Point(368, 72);
            this.cboMaLopHP.Name = "cboMaLopHP";
            this.cboMaLopHP.Size = new System.Drawing.Size(100, 21);
            this.cboMaLopHP.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Mã Lớp HP:";
            // 
            // cboMaHK
            // 
            this.cboMaHK.FormattingEnabled = true;
            this.cboMaHK.Location = new System.Drawing.Point(368, 42);
            this.cboMaHK.Name = "cboMaHK";
            this.cboMaHK.Size = new System.Drawing.Size(100, 21);
            this.cboMaHK.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã Học Kỳ:";
            // 
            // frmDangKy_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.cboMaLopHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaHK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaHP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboMaSV);
            this.Controls.Add(this.btnXoaDangKy);
            this.Controls.Add(this.btnSuaDangKy);
            this.Controls.Add(this.btnThemDangKy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDangKy);
            this.Name = "frmDangKy_GUI";
            this.Text = "Quản lý đăng ký học phần";
            this.Load += new System.EventHandler(this.frmDangKy_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMaHP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.Button btnXoaDangKy;
        private System.Windows.Forms.Button btnSuaDangKy;
        private System.Windows.Forms.Button btnThemDangKy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDangKy;
        private System.Windows.Forms.ComboBox cboMaLopHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaHK;
        private System.Windows.Forms.Label label2;
    }
}