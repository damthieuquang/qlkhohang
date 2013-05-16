﻿namespace GUI
{
    partial class NhapHang
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
            this.GridView_NhapHang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tatMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtNhanVienNhanHang = new System.Windows.Forms.TextBox();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtNgayNhan = new System.Windows.Forms.TextBox();
            this.txtDonDatHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimPhieuNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_NhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(109, 384);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(86, 23);
            this.btnTao.TabIndex = 82;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(254, 384);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(86, 23);
            this.btnTaoMoi.TabIndex = 81;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(531, 384);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(86, 23);
            this.btnLamLai.TabIndex = 80;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(668, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 23);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // GridView_NhapHang
            // 
            this.GridView_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_NhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clSoLuong,
            this.clDaNhan,
            this.clConLai,
            this.clGhiChu});
            this.GridView_NhapHang.Location = new System.Drawing.Point(40, 203);
            this.GridView_NhapHang.Name = "GridView_NhapHang";
            this.GridView_NhapHang.Size = new System.Drawing.Size(744, 150);
            this.GridView_NhapHang.TabIndex = 77;
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
            // tatMaNhanVien
            // 
            this.tatMaNhanVien.Location = new System.Drawing.Point(556, 108);
            this.tatMaNhanVien.Name = "tatMaNhanVien";
            this.tatMaNhanVien.Size = new System.Drawing.Size(154, 20);
            this.tatMaNhanVien.TabIndex = 70;
            // 
            // txtNhanVienNhanHang
            // 
            this.txtNhanVienNhanHang.Location = new System.Drawing.Point(556, 151);
            this.txtNhanVienNhanHang.Name = "txtNhanVienNhanHang";
            this.txtNhanVienNhanHang.Size = new System.Drawing.Size(154, 20);
            this.txtNhanVienNhanHang.TabIndex = 69;
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(188, 108);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(154, 20);
            this.txtNgayDat.TabIndex = 68;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(188, 151);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(154, 20);
            this.txtSoTien.TabIndex = 67;
            // 
            // txtNgayNhan
            // 
            this.txtNgayNhan.Location = new System.Drawing.Point(556, 66);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.Size = new System.Drawing.Size(154, 20);
            this.txtNgayNhan.TabIndex = 66;
            // 
            // txtDonDatHang
            // 
            this.txtDonDatHang.Location = new System.Drawing.Point(188, 66);
            this.txtDonDatHang.Name = "txtDonDatHang";
            this.txtDonDatHang.Size = new System.Drawing.Size(154, 20);
            this.txtDonDatHang.TabIndex = 65;
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
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(154, 20);
            this.txtMaPhieuNhap.TabIndex = 87;
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
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clDaNhan
            // 
            this.clDaNhan.HeaderText = "Đã nhận";
            this.clDaNhan.Name = "clDaNhan";
            this.clDaNhan.ReadOnly = true;
            // 
            // clConLai
            // 
            this.clConLai.HeaderText = "Còn lại";
            this.clConLai.Name = "clConLai";
            this.clConLai.ReadOnly = true;
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            // 
            // btnTimPhieuNhap
            // 
            this.btnTimPhieuNhap.Location = new System.Drawing.Point(385, 384);
            this.btnTimPhieuNhap.Name = "btnTimPhieuNhap";
            this.btnTimPhieuNhap.Size = new System.Drawing.Size(108, 23);
            this.btnTimPhieuNhap.TabIndex = 89;
            this.btnTimPhieuNhap.Text = "Tìm phiếu nhập";
            this.btnTimPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 436);
            this.Controls.Add(this.btnTimPhieuNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaPhieuNhap);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.GridView_NhapHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tatMaNhanVien);
            this.Controls.Add(this.txtNhanVienNhanHang);
            this.Controls.Add(this.txtNgayDat);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtNgayNhan);
            this.Controls.Add(this.txtDonDatHang);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_NhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView GridView_NhapHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tatMaNhanVien;
        private System.Windows.Forms.TextBox txtNhanVienNhanHang;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtDonDatHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.Button btnTimPhieuNhap;
    }
}