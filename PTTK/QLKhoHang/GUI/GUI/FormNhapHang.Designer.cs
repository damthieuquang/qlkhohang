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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnYes = new System.Windows.Forms.Button();
            this.dataGridView_NhapHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimPhieuNhap = new System.Windows.Forms.Button();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxChiTietPhieuNhap = new System.Windows.Forms.GroupBox();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxThongTinPhieuNhap = new System.Windows.Forms.GroupBox();
            this.txtDonDatHang = new System.Windows.Forms.TextBox();
            this.txtNgayNhan = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.txtNhanVienNhanHang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapHang)).BeginInit();
            this.groupBoxChiTietPhieuNhap.SuspendLayout();
            this.panelYesNo.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.groupBoxThongTinPhieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(302, 12);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Cập nhật";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // dataGridView_NhapHang
            // 
            this.dataGridView_NhapHang.AllowUserToAddRows = false;
            this.dataGridView_NhapHang.AllowUserToDeleteRows = false;
            this.dataGridView_NhapHang.AllowUserToResizeColumns = false;
            this.dataGridView_NhapHang.AllowUserToResizeRows = false;
            this.dataGridView_NhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_NhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clSoLuong,
            this.clDaNhan,
            this.clSLNhan,
            this.clGhiChu});
            this.dataGridView_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_NhapHang.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_NhapHang.Name = "dataGridView_NhapHang";
            this.dataGridView_NhapHang.RowHeadersVisible = false;
            this.dataGridView_NhapHang.Size = new System.Drawing.Size(854, 213);
            this.dataGridView_NhapHang.TabIndex = 90;
            this.dataGridView_NhapHang.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_NhapHang_EditingControlShowing);
            // 
            // clSTT
            // 
            this.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clSTT.DefaultCellStyle = dataGridViewCellStyle7;
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSTT.Width = 50;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            this.clSoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clSoLuong.DefaultCellStyle = dataGridViewCellStyle8;
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            this.clSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clDaNhan
            // 
            this.clDaNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clDaNhan.DefaultCellStyle = dataGridViewCellStyle9;
            this.clDaNhan.HeaderText = "Đã nhận";
            this.clDaNhan.Name = "clDaNhan";
            this.clDaNhan.ReadOnly = true;
            this.clDaNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clSLNhan
            // 
            this.clSLNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clSLNhan.DefaultCellStyle = dataGridViewCellStyle10;
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
            // btnTimPhieuNhap
            // 
            this.btnTimPhieuNhap.Location = new System.Drawing.Point(222, 13);
            this.btnTimPhieuNhap.Name = "btnTimPhieuNhap";
            this.btnTimPhieuNhap.Size = new System.Drawing.Size(108, 23);
            this.btnTimPhieuNhap.TabIndex = 89;
            this.btnTimPhieuNhap.Text = "Tìm phiếu nhập";
            this.btnTimPhieuNhap.UseVisualStyleBackColor = true;
            this.btnTimPhieuNhap.Click += new System.EventHandler(this.btnTimPhieuNhap_Click);
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(450, 13);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(86, 23);
            this.btnCapNhap.TabIndex = 91;
            this.btnCapNhap.Text = "Cập Nhập";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Visible = false;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(218, 108);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(154, 20);
            this.txtTrangThai.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Trạng thái";
            // 
            // groupBoxChiTietPhieuNhap
            // 
            this.groupBoxChiTietPhieuNhap.Controls.Add(this.panelYesNo);
            this.groupBoxChiTietPhieuNhap.Controls.Add(this.dataGridView_NhapHang);
            this.groupBoxChiTietPhieuNhap.Location = new System.Drawing.Point(70, 174);
            this.groupBoxChiTietPhieuNhap.Name = "groupBoxChiTietPhieuNhap";
            this.groupBoxChiTietPhieuNhap.Size = new System.Drawing.Size(860, 232);
            this.groupBoxChiTietPhieuNhap.TabIndex = 96;
            this.groupBoxChiTietPhieuNhap.TabStop = false;
            this.groupBoxChiTietPhieuNhap.Text = "Chi tiết phiếu nhập";
            // 
            // panelYesNo
            // 
            this.panelYesNo.Controls.Add(this.btnNo);
            this.panelYesNo.Controls.Add(this.btnYes);
            this.panelYesNo.Location = new System.Drawing.Point(10, 108);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(841, 47);
            this.panelYesNo.TabIndex = 92;
            this.panelYesNo.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(424, 11);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Hủy";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.btnCapNhap);
            this.panelChucNang.Controls.Add(this.btnThoat);
            this.panelChucNang.Controls.Add(this.btnLamLai);
            this.panelChucNang.Controls.Add(this.btnTaoMoi);
            this.panelChucNang.Controls.Add(this.btnTimPhieuNhap);
            this.panelChucNang.Controls.Add(this.btnTao);
            this.panelChucNang.Location = new System.Drawing.Point(80, 412);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(841, 47);
            this.panelChucNang.TabIndex = 97;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(733, 13);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 23);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(349, 13);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(86, 23);
            this.btnLamLai.TabIndex = 80;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(120, 13);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(86, 23);
            this.btnTaoMoi.TabIndex = 81;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnTao
            // 
            this.btnTao.Enabled = false;
            this.btnTao.Location = new System.Drawing.Point(16, 13);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(86, 23);
            this.btnTao.TabIndex = 82;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Mã phiếu nhập";
            // 
            // groupBoxThongTinPhieuNhap
            // 
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.txtTrangThai);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.label8);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.label7);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.txtDonDatHang);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.txtNgayNhan);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.txtSoTien);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.txtNgayDat);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.txtMaPhieuNhap);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.txtNhanVienNhanHang);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.txtMaNhanVien);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.label1);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.label2);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.label3);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.label6);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.label4);
            this.groupBoxThongTinPhieuNhap.Controls.Add(this.label5);
            this.groupBoxThongTinPhieuNhap.Location = new System.Drawing.Point(70, 12);
            this.groupBoxThongTinPhieuNhap.Name = "groupBoxThongTinPhieuNhap";
            this.groupBoxThongTinPhieuNhap.Size = new System.Drawing.Size(860, 144);
            this.groupBoxThongTinPhieuNhap.TabIndex = 95;
            this.groupBoxThongTinPhieuNhap.TabStop = false;
            this.groupBoxThongTinPhieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // txtDonDatHang
            // 
            this.txtDonDatHang.Location = new System.Drawing.Point(218, 21);
            this.txtDonDatHang.Name = "txtDonDatHang";
            this.txtDonDatHang.Size = new System.Drawing.Size(154, 20);
            this.txtDonDatHang.TabIndex = 65;
            this.txtDonDatHang.TextChanged += new System.EventHandler(this.txtDonDatHang_TextChanged);
            // 
            // txtNgayNhan
            // 
            this.txtNgayNhan.Location = new System.Drawing.Point(587, 50);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.ReadOnly = true;
            this.txtNgayNhan.Size = new System.Drawing.Size(154, 20);
            this.txtNgayNhan.TabIndex = 66;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(218, 79);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.Size = new System.Drawing.Size(154, 20);
            this.txtSoTien.TabIndex = 67;
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(218, 50);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.ReadOnly = true;
            this.txtNgayDat.Size = new System.Drawing.Size(154, 20);
            this.txtNgayDat.TabIndex = 68;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(587, 21);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.ReadOnly = true;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(154, 20);
            this.txtMaPhieuNhap.TabIndex = 87;
            // 
            // txtNhanVienNhanHang
            // 
            this.txtNhanVienNhanHang.Location = new System.Drawing.Point(587, 108);
            this.txtNhanVienNhanHang.Name = "txtNhanVienNhanHang";
            this.txtNhanVienNhanHang.ReadOnly = true;
            this.txtNhanVienNhanHang.Size = new System.Drawing.Size(154, 20);
            this.txtNhanVienNhanHang.TabIndex = 69;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(587, 79);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(154, 20);
            this.txtMaNhanVien.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Đơn đặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Số tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Ngày đặt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Tên nhân viên nhận hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Ngày nhận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Mã nhân viên";
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.groupBoxChiTietPhieuNhap);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.groupBoxThongTinPhieuNhap);
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập hàng";
            this.Activated += new System.EventHandler(this.FormNhapHang_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapHang)).EndInit();
            this.groupBoxChiTietPhieuNhap.ResumeLayout(false);
            this.panelYesNo.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.groupBoxThongTinPhieuNhap.ResumeLayout(false);
            this.groupBoxThongTinPhieuNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.DataGridView dataGridView_NhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSLNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.Button btnTimPhieuNhap;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxChiTietPhieuNhap;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxThongTinPhieuNhap;
        private System.Windows.Forms.TextBox txtDonDatHang;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.TextBox txtNhanVienNhanHang;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}