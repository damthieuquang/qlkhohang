﻿namespace GUI
{
    partial class FormDonHang
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
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaStockist = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.txtDiaChiStockist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimDonHang = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnCapNhatSanPham = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.dataGridView_TaoDonHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaoDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(201, 87);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(154, 20);
            this.txtTenNhanVien.TabIndex = 46;
            // 
            // txtMaStockist
            // 
            this.txtMaStockist.Location = new System.Drawing.Point(201, 141);
            this.txtMaStockist.Name = "txtMaStockist";
            this.txtMaStockist.ReadOnly = true;
            this.txtMaStockist.Size = new System.Drawing.Size(154, 20);
            this.txtMaStockist.TabIndex = 45;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(569, 36);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(154, 20);
            this.txtNgayLap.TabIndex = 44;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(201, 36);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(154, 20);
            this.txtMaNhanVien.TabIndex = 43;
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(569, 87);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.ReadOnly = true;
            this.txtMaDonHang.Size = new System.Drawing.Size(154, 20);
            this.txtMaDonHang.TabIndex = 48;
            // 
            // txtDiaChiStockist
            // 
            this.txtDiaChiStockist.Location = new System.Drawing.Point(569, 141);
            this.txtDiaChiStockist.Name = "txtDiaChiStockist";
            this.txtDiaChiStockist.ReadOnly = true;
            this.txtDiaChiStockist.Size = new System.Drawing.Size(154, 20);
            this.txtDiaChiStockist.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mã Stockist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Mã đơn hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Địa chỉ Stockist";
            // 
            // btnTimDonHang
            // 
            this.btnTimDonHang.Location = new System.Drawing.Point(537, 393);
            this.btnTimDonHang.Name = "btnTimDonHang";
            this.btnTimDonHang.Size = new System.Drawing.Size(86, 23);
            this.btnTimDonHang.TabIndex = 60;
            this.btnTimDonHang.Text = "Tìm đơn hàng";
            this.btnTimDonHang.UseVisualStyleBackColor = true;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(408, 393);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(86, 23);
            this.btnXuatFile.TabIndex = 59;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(297, 393);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(86, 23);
            this.btnLamLai.TabIndex = 58;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(182, 393);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(86, 23);
            this.btnTaoMoi.TabIndex = 57;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(71, 393);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(86, 23);
            this.btnTao.TabIndex = 56;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(676, 393);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 23);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Location = new System.Drawing.Point(513, 350);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnXoaSanPham.TabIndex = 64;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatSanPham
            // 
            this.btnCapNhatSanPham.Location = new System.Drawing.Point(364, 350);
            this.btnCapNhatSanPham.Name = "btnCapNhatSanPham";
            this.btnCapNhatSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnCapNhatSanPham.TabIndex = 63;
            this.btnCapNhatSanPham.Text = "Cập nhật sản phẩm";
            this.btnCapNhatSanPham.UseVisualStyleBackColor = true;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(226, 350);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnThemSanPham.TabIndex = 62;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TaoDonHang
            // 
            this.dataGridView_TaoDonHang.AllowUserToAddRows = false;
            this.dataGridView_TaoDonHang.AllowUserToDeleteRows = false;
            this.dataGridView_TaoDonHang.AllowUserToResizeColumns = false;
            this.dataGridView_TaoDonHang.AllowUserToResizeRows = false;
            this.dataGridView_TaoDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_TaoDonHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_TaoDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaoDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clCV,
            this.clDonGia,
            this.clSoLuong,
            this.clThanhTien});
            this.dataGridView_TaoDonHang.Location = new System.Drawing.Point(53, 171);
            this.dataGridView_TaoDonHang.Name = "dataGridView_TaoDonHang";
            this.dataGridView_TaoDonHang.RowHeadersVisible = false;
            this.dataGridView_TaoDonHang.Size = new System.Drawing.Size(744, 150);
            this.dataGridView_TaoDonHang.TabIndex = 65;
            this.dataGridView_TaoDonHang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TaoDonHang_CellEndEdit);
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
            this.clMaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.Name = "clTenSanPham";
            this.clTenSanPham.ReadOnly = true;
            this.clTenSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clCV
            // 
            this.clCV.HeaderText = "CV";
            this.clCV.Name = "clCV";
            this.clCV.ReadOnly = true;
            this.clCV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            this.clDonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clThanhTien
            // 
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            this.clThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_MouseCaptureChanged);
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Location = new System.Drawing.Point(697, 350);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(0, 13);
            this.labelTongTien.TabIndex = 67;
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView_TaoDonHang);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.btnCapNhatSanPham);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.btnTimDonHang);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.txtDiaChiStockist);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaStockist);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.txtMaNhanVien);
            this.Name = "FormDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng";
            this.Load += new System.EventHandler(this.FormDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaoDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaStockist;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.TextBox txtDiaChiStockist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimDonHang;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnCapNhatSanPham;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.DataGridView dataGridView_TaoDonHang;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.Label labelTongTien;
    }
}