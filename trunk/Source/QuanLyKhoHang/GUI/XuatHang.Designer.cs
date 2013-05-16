namespace GUI
{
    partial class XuatHang
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.GridView_XuatHang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tatMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtNhanVienBanHang = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.txtMaThanhVien = new System.Windows.Forms.TextBox();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnCapNhatSanPham = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimPhieuNhap = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_XuatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Mã phiếu xuất";
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(382, 20);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(154, 20);
            this.txtMaPhieuXuat.TabIndex = 102;
            // 
            // GridView_XuatHang
            // 
            this.GridView_XuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_XuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clCV,
            this.clSoLuong,
            this.clDonGia,
            this.clThanhTien});
            this.GridView_XuatHang.Location = new System.Drawing.Point(27, 201);
            this.GridView_XuatHang.Name = "GridView_XuatHang";
            this.GridView_XuatHang.Size = new System.Drawing.Size(744, 150);
            this.GridView_XuatHang.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 100;
            this.label6.Text = "Tên nhân viên bán hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Mã thành viên";
            // 
            // tatMaNhanVien
            // 
            this.tatMaNhanVien.Location = new System.Drawing.Point(543, 106);
            this.tatMaNhanVien.Name = "tatMaNhanVien";
            this.tatMaNhanVien.Size = new System.Drawing.Size(154, 20);
            this.tatMaNhanVien.TabIndex = 94;
            // 
            // txtNhanVienBanHang
            // 
            this.txtNhanVienBanHang.Location = new System.Drawing.Point(543, 149);
            this.txtNhanVienBanHang.Name = "txtNhanVienBanHang";
            this.txtNhanVienBanHang.Size = new System.Drawing.Size(154, 20);
            this.txtNhanVienBanHang.TabIndex = 93;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(175, 106);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(154, 20);
            this.txtTenKhachHang.TabIndex = 92;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(175, 149);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(154, 20);
            this.txtDiaChi.TabIndex = 91;
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(543, 64);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(154, 20);
            this.txtNgayBan.TabIndex = 90;
            // 
            // txtMaThanhVien
            // 
            this.txtMaThanhVien.Location = new System.Drawing.Point(175, 64);
            this.txtMaThanhVien.Name = "txtMaThanhVien";
            this.txtMaThanhVien.Size = new System.Drawing.Size(154, 20);
            this.txtMaThanhVien.TabIndex = 89;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Location = new System.Drawing.Point(485, 366);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnXoaSanPham.TabIndex = 112;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatSanPham
            // 
            this.btnCapNhatSanPham.Location = new System.Drawing.Point(336, 366);
            this.btnCapNhatSanPham.Name = "btnCapNhatSanPham";
            this.btnCapNhatSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnCapNhatSanPham.TabIndex = 111;
            this.btnCapNhatSanPham.Text = "Cập nhật sản phẩm";
            this.btnCapNhatSanPham.UseVisualStyleBackColor = true;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(198, 366);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnThemSanPham.TabIndex = 110;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(648, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 23);
            this.btnThoat.TabIndex = 109;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.HeaderText = "Mã sản phẩm";
            this.clMaSanPham.Name = "clMaSanPham";
            this.clMaSanPham.ReadOnly = true;
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.Name = "clTenSanPham";
            this.clTenSanPham.ReadOnly = true;
            // 
            // clCV
            // 
            this.clCV.HeaderText = "CV";
            this.clCV.Name = "clCV";
            this.clCV.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            // 
            // clThanhTien
            // 
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // btnTimPhieuNhap
            // 
            this.btnTimPhieuNhap.Location = new System.Drawing.Point(338, 409);
            this.btnTimPhieuNhap.Name = "btnTimPhieuNhap";
            this.btnTimPhieuNhap.Size = new System.Drawing.Size(108, 23);
            this.btnTimPhieuNhap.TabIndex = 116;
            this.btnTimPhieuNhap.Text = "Tìm phiếu nhập";
            this.btnTimPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(62, 409);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(86, 23);
            this.btnTao.TabIndex = 115;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(207, 409);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(86, 23);
            this.btnTaoMoi.TabIndex = 114;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(484, 409);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(86, 23);
            this.btnLamLai.TabIndex = 113;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 444);
            this.Controls.Add(this.btnTimPhieuNhap);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.btnCapNhatSanPham);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaPhieuXuat);
            this.Controls.Add(this.GridView_XuatHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tatMaNhanVien);
            this.Controls.Add(this.txtNhanVienBanHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtNgayBan);
            this.Controls.Add(this.txtMaThanhVien);
            this.Name = "XuatHang";
            this.Text = "XuatHang";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_XuatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.DataGridView GridView_XuatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tatMaNhanVien;
        private System.Windows.Forms.TextBox txtNhanVienBanHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtNgayBan;
        private System.Windows.Forms.TextBox txtMaThanhVien;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnCapNhatSanPham;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.Button btnTimPhieuNhap;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnLamLai;
    }
}