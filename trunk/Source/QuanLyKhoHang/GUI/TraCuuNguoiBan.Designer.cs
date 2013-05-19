namespace GUI
{
    partial class FormTraCuuNguoiBan
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
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtThoiGianBatDau = new System.Windows.Forms.TextBox();
            this.txtThoiGianKetThuc = new System.Windows.Forms.TextBox();
            this.txtMaNguoiBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNguoiBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_TraCuuNguoiBan = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoTienNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoTienChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuNguoiBan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(370, 364);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 38;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(195, 364);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemChiTiet.TabIndex = 37;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(40, 364);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 36;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã người bán";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(557, 364);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtThoiGianBatDau
            // 
            this.txtThoiGianBatDau.Location = new System.Drawing.Point(282, 118);
            this.txtThoiGianBatDau.Name = "txtThoiGianBatDau";
            this.txtThoiGianBatDau.Size = new System.Drawing.Size(154, 20);
            this.txtThoiGianBatDau.TabIndex = 34;
            // 
            // txtThoiGianKetThuc
            // 
            this.txtThoiGianKetThuc.Location = new System.Drawing.Point(282, 156);
            this.txtThoiGianKetThuc.Name = "txtThoiGianKetThuc";
            this.txtThoiGianKetThuc.Size = new System.Drawing.Size(154, 20);
            this.txtThoiGianKetThuc.TabIndex = 33;
            // 
            // txtMaNguoiBan
            // 
            this.txtMaNguoiBan.Location = new System.Drawing.Point(282, 22);
            this.txtMaNguoiBan.Name = "txtMaNguoiBan";
            this.txtMaNguoiBan.Size = new System.Drawing.Size(232, 20);
            this.txtMaNguoiBan.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên người bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Từ";
            // 
            // txtTenNguoiBan
            // 
            this.txtTenNguoiBan.Location = new System.Drawing.Point(282, 60);
            this.txtTenNguoiBan.Name = "txtTenNguoiBan";
            this.txtTenNguoiBan.Size = new System.Drawing.Size(232, 20);
            this.txtTenNguoiBan.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Thời gian bán:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView_TraCuuNguoiBan
            // 
            this.dataGridView_TraCuuNguoiBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TraCuuNguoiBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaNhanVien,
            this.clTenNhanVien,
            this.clNgayBan,
            this.clSoTienNhan,
            this.clSoTienChi});
            this.dataGridView_TraCuuNguoiBan.Location = new System.Drawing.Point(22, 182);
            this.dataGridView_TraCuuNguoiBan.Name = "dataGridView_TraCuuNguoiBan";
            this.dataGridView_TraCuuNguoiBan.Size = new System.Drawing.Size(640, 150);
            this.dataGridView_TraCuuNguoiBan.TabIndex = 44;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            // 
            // clMaNhanVien
            // 
            this.clMaNhanVien.HeaderText = "Mã nhân viên";
            this.clMaNhanVien.Name = "clMaNhanVien";
            this.clMaNhanVien.ReadOnly = true;
            // 
            // clTenNhanVien
            // 
            this.clTenNhanVien.HeaderText = "Tên nhân viên";
            this.clTenNhanVien.Name = "clTenNhanVien";
            this.clTenNhanVien.ReadOnly = true;
            // 
            // clNgayBan
            // 
            this.clNgayBan.HeaderText = "Ngày bán";
            this.clNgayBan.Name = "clNgayBan";
            this.clNgayBan.ReadOnly = true;
            // 
            // clSoTienNhan
            // 
            this.clSoTienNhan.HeaderText = "Số tiền nhận";
            this.clSoTienNhan.Name = "clSoTienNhan";
            this.clSoTienNhan.ReadOnly = true;
            // 
            // clSoTienChi
            // 
            this.clSoTienChi.HeaderText = "Số tiền chi";
            this.clSoTienChi.Name = "clSoTienChi";
            this.clSoTienChi.ReadOnly = true;
            // 
            // FormTraCuuNguoiBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 437);
            this.Controls.Add(this.dataGridView_TraCuuNguoiBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenNguoiBan);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtThoiGianBatDau);
            this.Controls.Add(this.txtThoiGianKetThuc);
            this.Controls.Add(this.txtMaNguoiBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormTraCuuNguoiBan";
            this.Text = "Theo Dõi - Tra Cứu Người Bán";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuNguoiBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtThoiGianBatDau;
        private System.Windows.Forms.TextBox txtThoiGianKetThuc;
        private System.Windows.Forms.TextBox txtMaNguoiBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNguoiBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_TraCuuNguoiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoTienNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoTienChi;
    }
}