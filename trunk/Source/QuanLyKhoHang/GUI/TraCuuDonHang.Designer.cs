namespace GUI
{
    partial class FormTraCuuDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.txtThoiGianKetThuc = new System.Windows.Forms.TextBox();
            this.txtThoiGianBatDau = new System.Windows.Forms.TextBox();
            this.GridView_TraCuuDonHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TraCuuDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(253, 43);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(232, 20);
            this.txtMaDonHang.TabIndex = 4;
            // 
            // txtThoiGianKetThuc
            // 
            this.txtThoiGianKetThuc.Location = new System.Drawing.Point(253, 155);
            this.txtThoiGianKetThuc.Name = "txtThoiGianKetThuc";
            this.txtThoiGianKetThuc.Size = new System.Drawing.Size(154, 20);
            this.txtThoiGianKetThuc.TabIndex = 5;
            // 
            // txtThoiGianBatDau
            // 
            this.txtThoiGianBatDau.Location = new System.Drawing.Point(253, 117);
            this.txtThoiGianBatDau.Name = "txtThoiGianBatDau";
            this.txtThoiGianBatDau.Size = new System.Drawing.Size(154, 20);
            this.txtThoiGianBatDau.TabIndex = 6;
            // 
            // GridView_TraCuuDonHang
            // 
            this.GridView_TraCuuDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_TraCuuDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaDonHang,
            this.clNgayDatHang,
            this.clNguoiDat,
            this.clSoLuong,
            this.clSoTien});
            this.GridView_TraCuuDonHang.Location = new System.Drawing.Point(18, 181);
            this.GridView_TraCuuDonHang.Name = "GridView_TraCuuDonHang";
            this.GridView_TraCuuDonHang.Size = new System.Drawing.Size(644, 150);
            this.GridView_TraCuuDonHang.TabIndex = 7;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            // 
            // clMaDonHang
            // 
            this.clMaDonHang.HeaderText = "Mã đơn hàng";
            this.clMaDonHang.Name = "clMaDonHang";
            this.clMaDonHang.ReadOnly = true;
            // 
            // clNgayDatHang
            // 
            this.clNgayDatHang.HeaderText = "Ngày đặt hàng";
            this.clNgayDatHang.Name = "clNgayDatHang";
            this.clNgayDatHang.ReadOnly = true;
            // 
            // clNguoiDat
            // 
            this.clNguoiDat.HeaderText = "Người đặt";
            this.clNguoiDat.Name = "clNguoiDat";
            this.clNguoiDat.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clSoTien
            // 
            this.clSoTien.HeaderText = "Số tiền";
            this.clSoTien.Name = "clSoTien";
            this.clSoTien.ReadOnly = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(22, 363);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 8;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(124, 363);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemChiTiet.TabIndex = 9;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(229, 363);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(332, 363);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(437, 363);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(549, 363);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // FormTraCuuDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 432);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.GridView_TraCuuDonHang);
            this.Controls.Add(this.txtThoiGianBatDau);
            this.Controls.Add(this.txtThoiGianKetThuc);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTraCuuDonHang";
            this.Text = "Tra Cứu Đơn Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TraCuuDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.TextBox txtThoiGianKetThuc;
        private System.Windows.Forms.TextBox txtThoiGianBatDau;
        private System.Windows.Forms.DataGridView GridView_TraCuuDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoTien;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}