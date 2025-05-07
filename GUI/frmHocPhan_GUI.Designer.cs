namespace GUI
{
    partial class frmHocPhan_GUI
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
            this.btnXoaHP = new System.Windows.Forms.Button();
            this.btnSuaHP = new System.Windows.Forms.Button();
            this.btnThemHP = new System.Windows.Forms.Button();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            this.cboMaHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiHocPhan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaHP
            // 
            this.btnXoaHP.Location = new System.Drawing.Point(222, 164);
            this.btnXoaHP.Name = "btnXoaHP";
            this.btnXoaHP.Size = new System.Drawing.Size(75, 52);
            this.btnXoaHP.TabIndex = 41;
            this.btnXoaHP.Text = "Xóa Học Phần";
            this.btnXoaHP.UseVisualStyleBackColor = true;
            // 
            // btnSuaHP
            // 
            this.btnSuaHP.Location = new System.Drawing.Point(369, 164);
            this.btnSuaHP.Name = "btnSuaHP";
            this.btnSuaHP.Size = new System.Drawing.Size(75, 52);
            this.btnSuaHP.TabIndex = 40;
            this.btnSuaHP.Text = "Sửa Học Phần";
            this.btnSuaHP.UseVisualStyleBackColor = true;
            // 
            // btnThemHP
            // 
            this.btnThemHP.Location = new System.Drawing.Point(69, 164);
            this.btnThemHP.Name = "btnThemHP";
            this.btnThemHP.Size = new System.Drawing.Size(75, 52);
            this.btnThemHP.TabIndex = 39;
            this.btnThemHP.Text = "Thêm Học Phần";
            this.btnThemHP.UseVisualStyleBackColor = true;
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(143, 80);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(100, 20);
            this.txtHP.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên Học Phần:";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(143, 38);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(100, 20);
            this.txtMaHP.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Học Phần:";
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHocPhan.Location = new System.Drawing.Point(0, 254);
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.Size = new System.Drawing.Size(510, 196);
            this.dgvHocPhan.TabIndex = 21;
            // 
            // cboMaHocKy
            // 
            this.cboMaHocKy.FormattingEnabled = true;
            this.cboMaHocKy.Location = new System.Drawing.Point(366, 41);
            this.cboMaHocKy.Name = "cboMaHocKy";
            this.cboMaHocKy.Size = new System.Drawing.Size(100, 21);
            this.cboMaHocKy.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã Học Kỳ:";
            // 
            // cboLoaiHocPhan
            // 
            this.cboLoaiHocPhan.FormattingEnabled = true;
            this.cboLoaiHocPhan.Location = new System.Drawing.Point(366, 77);
            this.cboLoaiHocPhan.Name = "cboLoaiHocPhan";
            this.cboLoaiHocPhan.Size = new System.Drawing.Size(100, 21);
            this.cboLoaiHocPhan.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Loại Học Phần:";
            // 
            // HocPhan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.cboLoaiHocPhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMaHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoaHP);
            this.Controls.Add(this.btnSuaHP);
            this.Controls.Add(this.btnThemHP);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHocPhan);
            this.Name = "HocPhan_GUI";
            this.Text = "HocPhan_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaHP;
        private System.Windows.Forms.Button btnSuaHP;
        private System.Windows.Forms.Button btnThemHP;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.ComboBox cboMaHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiHocPhan;
        private System.Windows.Forms.Label label4;
    }
}