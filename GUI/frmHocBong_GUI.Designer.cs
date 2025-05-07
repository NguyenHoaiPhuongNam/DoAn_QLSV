namespace GUI
{
    partial class frmHocBong_GUI
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
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.btnXoaHocBong = new System.Windows.Forms.Button();
            this.btnSuaHocBong = new System.Windows.Forms.Button();
            this.btnThemHocBong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHocBong = new System.Windows.Forms.DataGridView();
            this.cboXepLoaiHB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocBong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(351, 66);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 20);
            this.txtGhiChu.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Ghi Chú:";
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(127, 63);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(100, 21);
            this.cboMaSV.TabIndex = 64;
            // 
            // btnXoaHocBong
            // 
            this.btnXoaHocBong.Location = new System.Drawing.Point(229, 160);
            this.btnXoaHocBong.Name = "btnXoaHocBong";
            this.btnXoaHocBong.Size = new System.Drawing.Size(75, 52);
            this.btnXoaHocBong.TabIndex = 63;
            this.btnXoaHocBong.Text = "Xóa Học Bổng";
            this.btnXoaHocBong.UseVisualStyleBackColor = true;
            this.btnXoaHocBong.Click += new System.EventHandler(this.btnXoaHocBong_Click);
            // 
            // btnSuaHocBong
            // 
            this.btnSuaHocBong.Location = new System.Drawing.Point(376, 160);
            this.btnSuaHocBong.Name = "btnSuaHocBong";
            this.btnSuaHocBong.Size = new System.Drawing.Size(75, 52);
            this.btnSuaHocBong.TabIndex = 62;
            this.btnSuaHocBong.Text = "Sửa Học Bổng";
            this.btnSuaHocBong.UseVisualStyleBackColor = true;
            this.btnSuaHocBong.Click += new System.EventHandler(this.btnSuaHocBong_Click);
            // 
            // btnThemHocBong
            // 
            this.btnThemHocBong.Location = new System.Drawing.Point(76, 160);
            this.btnThemHocBong.Name = "btnThemHocBong";
            this.btnThemHocBong.Size = new System.Drawing.Size(75, 52);
            this.btnThemHocBong.TabIndex = 61;
            this.btnThemHocBong.Text = "Thêm Học Bổng";
            this.btnThemHocBong.UseVisualStyleBackColor = true;
            this.btnThemHocBong.Click += new System.EventHandler(this.btnThemHocBong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Mã SV:";
            // 
            // txtMaHB
            // 
            this.txtMaHB.Location = new System.Drawing.Point(127, 26);
            this.txtMaHB.Name = "txtMaHB";
            this.txtMaHB.ReadOnly = true;
            this.txtMaHB.Size = new System.Drawing.Size(100, 20);
            this.txtMaHB.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã HB:";
            // 
            // dgvHocBong
            // 
            this.dgvHocBong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocBong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocBong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHocBong.Location = new System.Drawing.Point(0, 295);
            this.dgvHocBong.Name = "dgvHocBong";
            this.dgvHocBong.Size = new System.Drawing.Size(537, 155);
            this.dgvHocBong.TabIndex = 55;
            this.dgvHocBong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocBong_CellClick);
            // 
            // cboXepLoaiHB
            // 
            this.cboXepLoaiHB.FormattingEnabled = true;
            this.cboXepLoaiHB.Location = new System.Drawing.Point(351, 23);
            this.cboXepLoaiHB.Name = "cboXepLoaiHB";
            this.cboXepLoaiHB.Size = new System.Drawing.Size(100, 21);
            this.cboXepLoaiHB.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Xếp Loại HB:";
            // 
            // frmHocBong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.cboXepLoaiHB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMaSV);
            this.Controls.Add(this.btnXoaHocBong);
            this.Controls.Add(this.btnSuaHocBong);
            this.Controls.Add(this.btnThemHocBong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHocBong);
            this.Name = "frmHocBong_GUI";
            this.Text = "Quản lý học bổng";
            this.Load += new System.EventHandler(this.frmHocBong_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocBong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.Button btnXoaHocBong;
        private System.Windows.Forms.Button btnSuaHocBong;
        private System.Windows.Forms.Button btnThemHocBong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHocBong;
        private System.Windows.Forms.ComboBox cboXepLoaiHB;
        private System.Windows.Forms.Label label2;
    }
}