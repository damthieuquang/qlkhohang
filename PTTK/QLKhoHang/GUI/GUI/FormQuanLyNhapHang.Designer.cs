namespace GUI
{
    partial class FormQuanLyNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerNgayNhanDen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayNhanTu = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNguoiNhan = new System.Windows.Forms.TextBox();
            this.clNguoiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayDatDen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayDatTu = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.clNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_TraCuuNhapHang = new System.Windows.Forms.DataGridView();
            this.clMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuNhapHang)).BeginInit();
            this.groupBoxDanhSach.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // clNgayDat
            // 
            this.clNgayDat.HeaderText = "Ngày đặt";
            this.clNgayDat.Name = "clNgayDat";
            this.clNgayDat.ReadOnly = true;
            this.clNgayDat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateTimePickerNgayNhanDen
            // 
            this.dateTimePickerNgayNhanDen.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayNhanDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayNhanDen.Location = new System.Drawing.Point(644, 74);
            this.dateTimePickerNgayNhanDen.Name = "dateTimePickerNgayNhanDen";
            this.dateTimePickerNgayNhanDen.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerNgayNhanDen.TabIndex = 16;
            this.dateTimePickerNgayNhanDen.ValueChanged += new System.EventHandler(this.dateTimePickerNgayNhanDen_ValueChanged);
            // 
            // dateTimePickerNgayNhanTu
            // 
            this.dateTimePickerNgayNhanTu.Checked = false;
            this.dateTimePickerNgayNhanTu.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayNhanTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayNhanTu.Location = new System.Drawing.Point(644, 45);
            this.dateTimePickerNgayNhanTu.Name = "dateTimePickerNgayNhanTu";
            this.dateTimePickerNgayNhanTu.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerNgayNhanTu.TabIndex = 15;
            this.dateTimePickerNgayNhanTu.ValueChanged += new System.EventHandler(this.dateTimePickerNgayNhanTu_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Từ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(600, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ngày nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày đặt";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(135, 45);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(150, 20);
            this.txtMaDonHang.TabIndex = 10;
            this.txtMaDonHang.TextChanged += new System.EventHandler(this.txtMaDonHang_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã đơn hàng";
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(135, 74);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiNhan.TabIndex = 8;
            this.txtNguoiNhan.TextChanged += new System.EventHandler(this.txtNguoiNhan_TextChanged);
            // 
            // clNguoiNhan
            // 
            this.clNguoiNhan.HeaderText = "Người Nhận";
            this.clNguoiNhan.Name = "clNguoiNhan";
            this.clNguoiNhan.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(397, 434);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 23);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(801, 434);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 23);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(503, 434);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(100, 23);
            this.btnLamLai.TabIndex = 27;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(76, 434);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(100, 23);
            this.btnXemChiTiet.TabIndex = 26;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Người nhận";
            // 
            // dateTimePickerNgayDatDen
            // 
            this.dateTimePickerNgayDatDen.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayDatDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayDatDen.Location = new System.Drawing.Point(370, 74);
            this.dateTimePickerNgayDatDen.Name = "dateTimePickerNgayDatDen";
            this.dateTimePickerNgayDatDen.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerNgayDatDen.TabIndex = 6;
            this.dateTimePickerNgayDatDen.ValueChanged += new System.EventHandler(this.dateTimePickerNgayDatDen_ValueChanged);
            // 
            // dateTimePickerNgayDatTu
            // 
            this.dateTimePickerNgayDatTu.Checked = false;
            this.dateTimePickerNgayDatTu.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgayDatTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgayDatTu.Location = new System.Drawing.Point(370, 45);
            this.dateTimePickerNgayDatTu.Name = "dateTimePickerNgayDatTu";
            this.dateTimePickerNgayDatTu.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerNgayDatTu.TabIndex = 5;
            this.dateTimePickerNgayDatTu.ValueChanged += new System.EventHandler(this.dateTimePickerNgayDatTu_ValueChanged);
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(135, 17);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(150, 20);
            this.txtMaPhieuNhap.TabIndex = 4;
            this.txtMaPhieuNhap.TextChanged += new System.EventHandler(this.txtMaPhieuNhap_TextChanged);
            // 
            // clNgayNhan
            // 
            this.clNgayNhan.HeaderText = "Ngày Nhận";
            this.clNgayNhan.Name = "clNgayNhan";
            this.clNgayNhan.ReadOnly = true;
            this.clNgayNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(182, 434);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(100, 23);
            this.btnTaoMoi.TabIndex = 33;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ";
            // 
            // clMaPhieuNhap
            // 
            this.clMaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.clMaPhieuNhap.Name = "clMaPhieuNhap";
            this.clMaPhieuNhap.ReadOnly = true;
            this.clMaPhieuNhap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clSTT
            // 
            this.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clSTT.Width = 50;
            // 
            // dataGridView_TraCuuNhapHang
            // 
            this.dataGridView_TraCuuNhapHang.AllowUserToAddRows = false;
            this.dataGridView_TraCuuNhapHang.AllowUserToDeleteRows = false;
            this.dataGridView_TraCuuNhapHang.AllowUserToResizeColumns = false;
            this.dataGridView_TraCuuNhapHang.AllowUserToResizeRows = false;
            this.dataGridView_TraCuuNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_TraCuuNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_TraCuuNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TraCuuNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaPhieuNhap,
            this.clMaDonHang,
            this.clNgayDat,
            this.clNgayNhan,
            this.clNguoiNhan});
            this.dataGridView_TraCuuNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_TraCuuNhapHang.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_TraCuuNhapHang.Name = "dataGridView_TraCuuNhapHang";
            this.dataGridView_TraCuuNhapHang.RowHeadersVisible = false;
            this.dataGridView_TraCuuNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TraCuuNhapHang.Size = new System.Drawing.Size(854, 250);
            this.dataGridView_TraCuuNhapHang.TabIndex = 14;
            // 
            // clMaDonHang
            // 
            this.clMaDonHang.HeaderText = "Mã đơn hàng";
            this.clMaDonHang.Name = "clMaDonHang";
            this.clMaDonHang.ReadOnly = true;
            this.clMaDonHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dataGridView_TraCuuNhapHang);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(62, 136);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(860, 269);
            this.groupBoxDanhSach.TabIndex = 31;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách phiếu nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(288, 434);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(103, 23);
            this.btnCapNhat.TabIndex = 32;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerNgayNhanDen);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerNgayNhanTu);
            this.groupBoxTimKiem.Controls.Add(this.label8);
            this.groupBoxTimKiem.Controls.Add(this.label9);
            this.groupBoxTimKiem.Controls.Add(this.label7);
            this.groupBoxTimKiem.Controls.Add(this.label6);
            this.groupBoxTimKiem.Controls.Add(this.txtMaDonHang);
            this.groupBoxTimKiem.Controls.Add(this.label5);
            this.groupBoxTimKiem.Controls.Add(this.txtNguoiNhan);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerNgayDatDen);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerNgayDatTu);
            this.groupBoxTimKiem.Controls.Add(this.txtMaPhieuNhap);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.label4);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(62, 25);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 105);
            this.groupBoxTimKiem.TabIndex = 30;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // FormQuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Name = "FormQuanLyNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhập hàng";
            this.Activated += new System.EventHandler(this.FormQuanLyNhapHang_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuNhapHang)).EndInit();
            this.groupBoxDanhSach.ResumeLayout(false);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayDat;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhanDen;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayNhanTu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNguoiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiNhan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDatDen;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDatTu;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridView dataGridView_TraCuuNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDonHang;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
    }
}