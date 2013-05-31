namespace GUI
{
    partial class FormNhapHang
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
            this.btnTao = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtNhanVienNhanHang = new System.Windows.Forms.TextBox();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtNgayNhan = new System.Windows.Forms.TextBox();
            this.txtDonDatHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.btnTimPhieuNhap = new System.Windows.Forms.Button();
            this.dataGridView_NhapHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(188, 383);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(86, 23);
            this.btnTao.TabIndex = 82;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(318, 383);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(86, 23);
            this.btnTaoMoi.TabIndex = 81;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(598, 383);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(86, 23);
            this.btnLamLai.TabIndex = 80;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(717, 383);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 23);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Tên nhân viên nhận hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Ngày nhận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Ngày đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Số tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Đơn đặt hàng";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(556, 108);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(154, 20);
            this.txtMaNhanVien.TabIndex = 70;
            // 
            // txtNhanVienNhanHang
            // 
            this.txtNhanVienNhanHang.Location = new System.Drawing.Point(556, 151);
            this.txtNhanVienNhanHang.Name = "txtNhanVienNhanHang";
            this.txtNhanVienNhanHang.ReadOnly = true;
            this.txtNhanVienNhanHang.Size = new System.Drawing.Size(154, 20);
            this.txtNhanVienNhanHang.TabIndex = 69;
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(188, 108);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.ReadOnly = true;
            this.txtNgayDat.Size = new System.Drawing.Size(154, 20);
            this.txtNgayDat.TabIndex = 68;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(188, 151);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.Size = new System.Drawing.Size(154, 20);
            this.txtSoTien.TabIndex = 67;
            // 
            // txtNgayNhan
            // 
            this.txtNgayNhan.Location = new System.Drawing.Point(556, 66);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.ReadOnly = true;
            this.txtNgayNhan.Size = new System.Drawing.Size(154, 20);
            this.txtNgayNhan.TabIndex = 66;
            // 
            // txtDonDatHang
            // 
            this.txtDonDatHang.Location = new System.Drawing.Point(188, 66);
            this.txtDonDatHang.Name = "txtDonDatHang";
            this.txtDonDatHang.Size = new System.Drawing.Size(154, 20);
            this.txtDonDatHang.TabIndex = 65;
           
           this.txtDonDatHang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDonDatHang_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Mã phiếu nhập";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(395, 22);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.ReadOnly = true;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(154, 20);
            this.txtMaPhieuNhap.TabIndex = 87;
            // 
            // btnTimPhieuNhap
            // 
            this.btnTimPhieuNhap.Location = new System.Drawing.Point(443, 383);
            this.btnTimPhieuNhap.Name = "btnTimPhieuNhap";
            this.btnTimPhieuNhap.Size = new System.Drawing.Size(108, 23);
            this.btnTimPhieuNhap.TabIndex = 89;
            this.btnTimPhieuNhap.Text = "Tìm phiếu nhập";
            this.btnTimPhieuNhap.UseVisualStyleBackColor = true;
            this.btnTimPhieuNhap.Click += new System.EventHandler(this.btnTimPhieuNhap_Click);
            // 
            // dataGridView_NhapHang
            // 
            this.dataGridView_NhapHang.AllowUserToAddRows = false;
            this.dataGridView_NhapHang.AllowUserToDeleteRows = false;
            this.dataGridView_NhapHang.AllowUserToResizeColumns = false;
            this.dataGridView_NhapHang.AllowUserToResizeRows = false;
            this.dataGridView_NhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clSoLuong,
            this.clDaNhan,
            this.clSLNhan,
            this.clGhiChu});
            this.dataGridView_NhapHang.Location = new System.Drawing.Point(58, 228);
            this.dataGridView_NhapHang.Name = "dataGridView_NhapHang";
            this.dataGridView_NhapHang.RowHeadersVisible = false;
            this.dataGridView_NhapHang.Size = new System.Drawing.Size(745, 150);
            this.dataGridView_NhapHang.TabIndex = 90;
            this.dataGridView_NhapHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NhapHang_CellEndEdit);
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.HeaderText = "Mã sản phẩm";
            this.clMaSanPham.Name = "clMaSanPham";
            this.clMaSanPham.ReadOnly = true;
            this.clMaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.Name = "clTenSanPham";
            this.clTenSanPham.ReadOnly = true;
            this.clTenSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            this.clSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clDaNhan
            // 
            this.clDaNhan.HeaderText = "Đã nhận";
            this.clDaNhan.Name = "clDaNhan";
            this.clDaNhan.ReadOnly = true;
            this.clDaNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clSLNhan
            // 
            this.clSLNhan.HeaderText = "SL Nhận";
            this.clSLNhan.Name = "clSLNhan";
            this.clSLNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Enabled = false;
            this.btnCapNhap.Location = new System.Drawing.Point(58, 383);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(86, 23);
            this.btnCapNhap.TabIndex = 91;
            this.btnCapNhap.Text = "Cập Nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.dataGridView_NhapHang);
            this.Controls.Add(this.btnTimPhieuNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaPhieuNhap);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtNhanVienNhanHang);
            this.Controls.Add(this.txtNgayDat);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtNgayNhan);
            this.Controls.Add(this.txtDonDatHang);
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtNhanVienNhanHang;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtDonDatHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Button btnTimPhieuNhap;
        private System.Windows.Forms.DataGridView dataGridView_NhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.Button btnCapNhap;
    }
}