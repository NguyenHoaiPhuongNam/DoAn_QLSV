namespace GUI
{
    partial class frmDSSinhVienThamGiaSuKien
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvThamGia = new System.Windows.Forms.DataGridView();
            this.btnDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(485, 47);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 32);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập mã Sự Kiện :";
            // 
            // txtSK
            // 
            this.txtSK.Location = new System.Drawing.Point(331, 52);
            this.txtSK.Name = "txtSK";
            this.txtSK.Size = new System.Drawing.Size(118, 22);
            this.txtSK.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Danh Sách Sinh Viên Tham Gia Sư Kiện";
            // 
            // dgvThamGia
            // 
            this.dgvThamGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThamGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThamGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThamGia.Location = new System.Drawing.Point(0, 260);
            this.dgvThamGia.Name = "dgvThamGia";
            this.dgvThamGia.RowHeadersWidth = 51;
            this.dgvThamGia.RowTemplate.Height = 24;
            this.dgvThamGia.Size = new System.Drawing.Size(800, 190);
            this.dgvThamGia.TabIndex = 12;
            // 
            // btnDS
            // 
            this.btnDS.Enabled = false;
            this.btnDS.Location = new System.Drawing.Point(667, 130);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(93, 63);
            this.btnDS.TabIndex = 13;
            this.btnDS.Text = "In Dách Sách ThamGia";
            this.btnDS.UseVisualStyleBackColor = true;
            // 
            // frmDSSinhVienThamGiaSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvThamGia);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSK);
            this.Name = "frmDSSinhVienThamGiaSuKien";
            this.Text = "frmDSSinhVienThamGiaSuKien";
            this.Load += new System.EventHandler(this.frmDSSinhVienThamGiaSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvThamGia;
        private System.Windows.Forms.Button btnDS;
    }
}