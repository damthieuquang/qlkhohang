namespace GUI
{
    partial class FormXuatHang
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnTimPhieuXuat = new System.Windows.Forms.Button();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaThanhVien = new System.Windows.Forms.TextBox();
            this.txtNhanVienBanHang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.dataGridView_XuatHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelYesNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_XuatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(47, 11);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(86, 23);
            this.btnTao.TabIndex = 56;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(700, 11);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 23);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(203, 11);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(86, 23);
            this.btnTaoMoi.TabIndex = 57;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnTimPhieuXuat
            // 
            this.btnTimPhieuXuat.Location = new System.Drawing.Point(513, 11);
            this.btnTimPhieuXuat.Name = "btnTimPhieuXuat";
            this.btnTimPhieuXuat.Size = new System.Drawing.Size(86, 23);
            this.btnTimPhieuXuat.TabIndex = 60;
            this.btnTimPhieuXuat.Text = "Tìm phiếu xuất";
            this.btnTimPhieuXuat.UseVisualStyleBackColor = true;
            this.btnTimPhieuXuat.Click += new System.EventHandler(this.btnTimPhieuXuat_Click);
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.btnTao);
            this.panelChucNang.Controls.Add(this.btnThoat);
            this.panelChucNang.Controls.Add(this.btnTaoMoi);
            this.panelChucNang.Controls.Add(this.btnLamLai);
            this.panelChucNang.Controls.Add(this.btnTimPhieuXuat);
            this.panelChucNang.Location = new System.Drawing.Point(67, 437);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(854, 47);
            this.panelChucNang.TabIndex = 82;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(361, 11);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(86, 23);
            this.btnLamLai.TabIndex = 58;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(211, 135);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(154, 20);
            this.txtDiaChi.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaPhieuXuat);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtMaThanhVien);
            this.groupBox1.Controls.Add(this.txtNhanVienBanHang);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(63, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 169);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã phiếu xuất";
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(211, 23);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.ReadOnly = true;
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(154, 20);
            this.txtMaPhieuXuat.TabIndex = 43;
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(579, 23);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.ReadOnly = true;
            this.txtNgayBan.Size = new System.Drawing.Size(154, 20);
            this.txtNgayBan.TabIndex = 44;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(211, 98);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(154, 20);
            this.txtTenKhachHang.TabIndex = 45;
            // 
            // txtMaThanhVien
            // 
            this.txtMaThanhVien.Location = new System.Drawing.Point(211, 59);
            this.txtMaThanhVien.Name = "txtMaThanhVien";
            this.txtMaThanhVien.Size = new System.Drawing.Size(154, 20);
            this.txtMaThanhVien.TabIndex = 46;
            this.txtMaThanhVien.TextChanged += new System.EventHandler(this.txtMaThanhVien_TextChanged);
            // 
            // txtNhanVienBanHang
            // 
            this.txtNhanVienBanHang.Location = new System.Drawing.Point(579, 98);
            this.txtNhanVienBanHang.Name = "txtNhanVienBanHang";
            this.txtNhanVienBanHang.ReadOnly = true;
            this.txtNhanVienBanHang.Size = new System.Drawing.Size(154, 20);
            this.txtNhanVienBanHang.TabIndex = 47;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(579, 59);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(154, 20);
            this.txtMaNhanVien.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Mã thành viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tên nhân viên bán hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ngày bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Mã nhân viên";
            // 
            // clThanhTien
            // 
            this.clThanhTien.FillWeight = 87.05584F;
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            this.clThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clSoLuong
            // 
            this.clSoLuong.FillWeight = 87.05584F;
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelYesNo);
            this.groupBox2.Controls.Add(this.dataGridView_XuatHang);
            this.groupBox2.Location = new System.Drawing.Point(63, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 234);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // panelYesNo
            // 
            this.panelYesNo.Controls.Add(this.btnNo);
            this.panelYesNo.Controls.Add(this.btnYes);
            this.panelYesNo.Location = new System.Drawing.Point(143, 130);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(854, 47);
            this.panelYesNo.TabIndex = 78;
            this.panelYesNo.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(424, 14);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Hủy";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(302, 15);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Cập nhật";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // dataGridView_XuatHang
            // 
            this.dataGridView_XuatHang.AllowUserToAddRows = false;
            this.dataGridView_XuatHang.AllowUserToDeleteRows = false;
            this.dataGridView_XuatHang.AllowUserToResizeColumns = false;
            this.dataGridView_XuatHang.AllowUserToResizeRows = false;
            this.dataGridView_XuatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_XuatHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_XuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_XuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clCV,
            this.clDonGia,
            this.clSoLuongTon,
            this.clSoLuong,
            this.clThanhTien});
            this.dataGridView_XuatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_XuatHang.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_XuatHang.Name = "dataGridView_XuatHang";
            this.dataGridView_XuatHang.RowHeadersVisible = false;
            this.dataGridView_XuatHang.Size = new System.Drawing.Size(854, 215);
            this.dataGridView_XuatHang.TabIndex = 65;
            this.dataGridView_XuatHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_XuatHang_CellEndEdit);
            this.dataGridView_XuatHang.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_XuatHang_EditingControlShowing);
            // 
            // clSTT
            // 
            this.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clSTT.FillWeight = 177.665F;
            this.clSTT.Frozen = true;
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSTT.Width = 50;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clMaSanPham.FillWeight = 87.05584F;
            this.clMaSanPham.Frozen = true;
            this.clMaSanPham.HeaderText = "Mã sản phẩm";
            this.clMaSanPham.Name = "clMaSanPham";
            this.clMaSanPham.ReadOnly = true;
            this.clMaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clMaSanPham.Width = 115;
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clTenSanPham.FillWeight = 87.05584F;
            this.clTenSanPham.Frozen = true;
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.Name = "clTenSanPham";
            this.clTenSanPham.ReadOnly = true;
            this.clTenSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clTenSanPham.Width = 125;
            // 
            // clCV
            // 
            this.clCV.FillWeight = 87.05584F;
            this.clCV.HeaderText = "CV";
            this.clCV.Name = "clCV";
            this.clCV.ReadOnly = true;
            this.clCV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clDonGia
            // 
            this.clDonGia.FillWeight = 87.05584F;
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            this.clDonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clSoLuongTon
            // 
            this.clSoLuongTon.FillWeight = 87F;
            this.clSoLuongTon.HeaderText = "Số lượng tồn";
            this.clSoLuongTon.Name = "clSoLuongTon";
            this.clSoLuongTon.ReadOnly = true;
            this.clSoLuongTon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xuất hàng";
            this.Activated += new System.EventHandler(this.FormXuatHang_Activated);
            this.Load += new System.EventHandler(this.FormXuatHang_Load);
            this.panelChucNang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelYesNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_XuatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnTimPhieuXuat;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.TextBox txtNgayBan;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtMaThanhVien;
        private System.Windows.Forms.TextBox txtNhanVienBanHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.DataGridView dataGridView_XuatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongTon;
    }
}