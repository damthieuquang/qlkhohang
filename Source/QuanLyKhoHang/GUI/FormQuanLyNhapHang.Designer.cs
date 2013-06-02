﻿namespace GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTu = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView_TraCuuNhapHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerDen);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerTu);
            this.groupBoxTimKiem.Controls.Add(this.txtMaPhieuNhap);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.label4);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(12, 16);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 100);
            this.groupBoxTimKiem.TabIndex = 22;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // dateTimePickerDen
            // 
            this.dateTimePickerDen.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDen.Location = new System.Drawing.Point(618, 22);
            this.dateTimePickerDen.Name = "dateTimePickerDen";
            this.dateTimePickerDen.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerDen.TabIndex = 6;
            this.dateTimePickerDen.ValueChanged += new System.EventHandler(this.dateTimePickerDen_ValueChanged);
            // 
            // dateTimePickerTu
            // 
            this.dateTimePickerTu.Checked = false;
            this.dateTimePickerTu.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTu.Location = new System.Drawing.Point(381, 22);
            this.dateTimePickerTu.Name = "dateTimePickerTu";
            this.dateTimePickerTu.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerTu.TabIndex = 5;
            this.dateTimePickerTu.ValueChanged += new System.EventHandler(this.dateTimePickerTu_ValueChanged);
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(149, 22);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(150, 20);
            this.txtMaPhieuNhap.TabIndex = 4;
            this.txtMaPhieuNhap.TextChanged += new System.EventHandler(this.txtMaPhieuNhap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến";
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dataGridView_TraCuuNhapHang);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(12, 131);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(860, 267);
            this.groupBoxDanhSach.TabIndex = 23;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh Sách Nhập Hàng";
            // 
            // dataGridView_TraCuuNhapHang
            // 
            this.dataGridView_TraCuuNhapHang.AllowUserToAddRows = false;
            this.dataGridView_TraCuuNhapHang.AllowUserToDeleteRows = false;
            this.dataGridView_TraCuuNhapHang.AllowUserToResizeColumns = false;
            this.dataGridView_TraCuuNhapHang.AllowUserToResizeRows = false;
            this.dataGridView_TraCuuNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_TraCuuNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_TraCuuNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TraCuuNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaPhieuNhap,
            this.clNgayDat,
            this.clNgayNhan,
            this.clNguoiNhan,
            this.clSoLuong});
            this.dataGridView_TraCuuNhapHang.Location = new System.Drawing.Point(16, 19);
            this.dataGridView_TraCuuNhapHang.Name = "dataGridView_TraCuuNhapHang";
            this.dataGridView_TraCuuNhapHang.RowHeadersVisible = false;
            this.dataGridView_TraCuuNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TraCuuNhapHang.Size = new System.Drawing.Size(831, 239);
            this.dataGridView_TraCuuNhapHang.TabIndex = 14;
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
            // clMaPhieuNhap
            // 
            this.clMaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.clMaPhieuNhap.Name = "clMaPhieuNhap";
            this.clMaPhieuNhap.ReadOnly = true;
            this.clMaPhieuNhap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNgayDat
            // 
            this.clNgayDat.HeaderText = "Ngày đặt";
            this.clNgayDat.Name = "clNgayDat";
            this.clNgayDat.ReadOnly = true;
            this.clNgayDat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNgayNhan
            // 
            this.clNgayNhan.HeaderText = "Ngày Nhận";
            this.clNgayNhan.Name = "clNgayNhan";
            this.clNgayNhan.ReadOnly = true;
            this.clNgayNhan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNguoiNhan
            // 
            this.clNguoiNhan.HeaderText = "Người Nhận";
            this.clNguoiNhan.Name = "clNguoiNhan";
            this.clNguoiNhan.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(572, 426);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(759, 426);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 23);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(393, 426);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(100, 23);
            this.btnLamLai.TabIndex = 18;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(28, 426);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(100, 23);
            this.btnXemChiTiet.TabIndex = 17;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(196, 426);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(103, 23);
            this.btnCapNhat.TabIndex = 24;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // FormQuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXemChiTiet);
            this.Name = "FormQuanLyNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhập hàng";
            this.Load += new System.EventHandler(this.FormQuanLyNhapHang_Load);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerDen;
        private System.Windows.Forms.DateTimePicker dateTimePickerTu;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.DataGridView dataGridView_TraCuuNhapHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.Button btnCapNhat;


    }
}