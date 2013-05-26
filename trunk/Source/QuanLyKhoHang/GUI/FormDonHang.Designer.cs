namespace GUI
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
            this.tatMaDonHang = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaoDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(160, 92);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(154, 20);
            this.txtTenNhanVien.TabIndex = 46;
            // 
            // txtMaStockist
            // 
            this.txtMaStockist.Location = new System.Drawing.Point(160, 146);
            this.txtMaStockist.Name = "txtMaStockist";
            this.txtMaStockist.Size = new System.Drawing.Size(154, 20);
            this.txtMaStockist.TabIndex = 45;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(528, 41);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(154, 20);
            this.txtNgayLap.TabIndex = 44;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(160, 41);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(154, 20);
            this.txtMaNhanVien.TabIndex = 43;
            // 
            // tatMaDonHang
            // 
            this.tatMaDonHang.Location = new System.Drawing.Point(528, 92);
            this.tatMaDonHang.Name = "tatMaDonHang";
            this.tatMaDonHang.Size = new System.Drawing.Size(154, 20);
            this.tatMaDonHang.TabIndex = 48;
            // 
            // txtDiaChiStockist
            // 
            this.txtDiaChiStockist.Location = new System.Drawing.Point(528, 146);
            this.txtDiaChiStockist.Name = "txtDiaChiStockist";
            this.txtDiaChiStockist.Size = new System.Drawing.Size(154, 20);
            this.txtDiaChiStockist.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mã Stockist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Mã đơn hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Địa chỉ Stockist";
            // 
            // btnTimDonHang
            // 
            this.btnTimDonHang.Location = new System.Drawing.Point(496, 398);
            this.btnTimDonHang.Name = "btnTimDonHang";
            this.btnTimDonHang.Size = new System.Drawing.Size(86, 23);
            this.btnTimDonHang.TabIndex = 60;
            this.btnTimDonHang.Text = "Tìm đơn hàng";
            this.btnTimDonHang.UseVisualStyleBackColor = true;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(367, 398);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(86, 23);
            this.btnXuatFile.TabIndex = 59;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(256, 398);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(86, 23);
            this.btnLamLai.TabIndex = 58;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(141, 398);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(86, 23);
            this.btnTaoMoi.TabIndex = 57;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(30, 398);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(86, 23);
            this.btnTao.TabIndex = 56;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(635, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 23);
            this.btnThoat.TabIndex = 61;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.Location = new System.Drawing.Point(472, 355);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnXoaSanPham.TabIndex = 64;
            this.btnXoaSanPham.Text = "Xóa sản phẩm";
            this.btnXoaSanPham.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatSanPham
            // 
            this.btnCapNhatSanPham.Location = new System.Drawing.Point(323, 355);
            this.btnCapNhatSanPham.Name = "btnCapNhatSanPham";
            this.btnCapNhatSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnCapNhatSanPham.TabIndex = 63;
            this.btnCapNhatSanPham.Text = "Cập nhật sản phẩm";
            this.btnCapNhatSanPham.UseVisualStyleBackColor = true;
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.Location = new System.Drawing.Point(185, 355);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(110, 23);
            this.btnThemSanPham.TabIndex = 62;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TaoDonHang
            // 
            this.dataGridView_TaoDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TaoDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clCV,
            this.clDonGia,
            this.clSoLuong,
            this.clThanhTien});
            this.dataGridView_TaoDonHang.Location = new System.Drawing.Point(12, 176);
            this.dataGridView_TaoDonHang.Name = "dataGridView_TaoDonHang";
            this.dataGridView_TaoDonHang.Size = new System.Drawing.Size(744, 150);
            this.dataGridView_TaoDonHang.TabIndex = 65;
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
            // clDonGia
            // 
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clThanhTien
            // 
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // FormDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 461);
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
            this.Controls.Add(this.tatMaDonHang);
            this.Controls.Add(this.txtDiaChiStockist);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaStockist);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.txtMaNhanVien);
            this.Name = "FormDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TaoDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaStockist;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox tatMaDonHang;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
    }
}