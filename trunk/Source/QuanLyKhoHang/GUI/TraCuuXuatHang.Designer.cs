namespace GUI
{
    partial class FormTraCuuXuatHang
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.GridView_TraCuuXuatHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayBanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtThoiGianBatDau = new System.Windows.Forms.TextBox();
            this.txtThoiGianKetThuc = new System.Windows.Forms.TextBox();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TraCuuXuatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(452, 376);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(347, 376);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(244, 376);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 24;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(139, 376);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemChiTiet.TabIndex = 23;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(37, 376);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 22;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã phiếu xuất";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(564, 376);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // GridView_TraCuuXuatHang
            // 
            this.GridView_TraCuuXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_TraCuuXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaPhieuXuat,
            this.clNgayBanHang,
            this.clNguoiMua,
            this.clSoLuong,
            this.clSoTien});
            this.GridView_TraCuuXuatHang.Location = new System.Drawing.Point(33, 194);
            this.GridView_TraCuuXuatHang.Name = "GridView_TraCuuXuatHang";
            this.GridView_TraCuuXuatHang.Size = new System.Drawing.Size(644, 150);
            this.GridView_TraCuuXuatHang.TabIndex = 21;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            // 
            // clMaPhieuXuat
            // 
            this.clMaPhieuXuat.HeaderText = "Mã phiếu xuất";
            this.clMaPhieuXuat.Name = "clMaPhieuXuat";
            this.clMaPhieuXuat.ReadOnly = true;
            // 
            // clNgayBanHang
            // 
            this.clNgayBanHang.HeaderText = "Ngày bán hàng";
            this.clNgayBanHang.Name = "clNgayBanHang";
            this.clNgayBanHang.ReadOnly = true;
            // 
            // clNguoiMua
            // 
            this.clNguoiMua.HeaderText = "Người mua";
            this.clNguoiMua.Name = "clNguoiMua";
            this.clNguoiMua.ReadOnly = true;
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
            // txtThoiGianBatDau
            // 
            this.txtThoiGianBatDau.Location = new System.Drawing.Point(268, 130);
            this.txtThoiGianBatDau.Name = "txtThoiGianBatDau";
            this.txtThoiGianBatDau.Size = new System.Drawing.Size(154, 20);
            this.txtThoiGianBatDau.TabIndex = 20;
            // 
            // txtThoiGianKetThuc
            // 
            this.txtThoiGianKetThuc.Location = new System.Drawing.Point(268, 168);
            this.txtThoiGianKetThuc.Name = "txtThoiGianKetThuc";
            this.txtThoiGianKetThuc.Size = new System.Drawing.Size(154, 20);
            this.txtThoiGianKetThuc.TabIndex = 19;
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(268, 56);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(232, 20);
            this.txtMaPhieuXuat.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Thời gian bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Từ";
            // 
            // FormTraCuuXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 439);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.GridView_TraCuuXuatHang);
            this.Controls.Add(this.txtThoiGianBatDau);
            this.Controls.Add(this.txtThoiGianKetThuc);
            this.Controls.Add(this.txtMaPhieuXuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormTraCuuXuatHang";
            this.Text = "Tra Cứu Xuất Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TraCuuXuatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView GridView_TraCuuXuatHang;
        private System.Windows.Forms.TextBox txtThoiGianBatDau;
        private System.Windows.Forms.TextBox txtThoiGianKetThuc;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoTien;

    }
}