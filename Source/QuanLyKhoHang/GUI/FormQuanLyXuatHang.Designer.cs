namespace GUI
{
    partial class FormQuanLyXuatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtNguoiBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNguoiMua = new System.Windows.Forms.TextBox();
            this.dateTimePickerDen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTu = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView_TraCuuXuatHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayBanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuXuatHang)).BeginInit();
            this.panelChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(381, 55);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(150, 20);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số tiền";
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.txtSoTien);
            this.groupBoxTimKiem.Controls.Add(this.txtNguoiBan);
            this.groupBoxTimKiem.Controls.Add(this.label7);
            this.groupBoxTimKiem.Controls.Add(this.txtSoLuong);
            this.groupBoxTimKiem.Controls.Add(this.label6);
            this.groupBoxTimKiem.Controls.Add(this.label5);
            this.groupBoxTimKiem.Controls.Add(this.txtNguoiMua);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerDen);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerTu);
            this.groupBoxTimKiem.Controls.Add(this.txtMaPhieuXuat);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.label4);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(12, 6);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 116);
            this.groupBoxTimKiem.TabIndex = 18;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(618, 55);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(150, 20);
            this.txtSoTien.TabIndex = 14;
            this.txtSoTien.TextChanged += new System.EventHandler(this.txtSoTien_TextChanged);
            // 
            // txtNguoiBan
            // 
            this.txtNguoiBan.Location = new System.Drawing.Point(149, 89);
            this.txtNguoiBan.Name = "txtNguoiBan";
            this.txtNguoiBan.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiBan.TabIndex = 13;
            this.txtNguoiBan.TextChanged += new System.EventHandler(this.txtNguoiBan_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Người bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            // 
            // txtNguoiMua
            // 
            this.txtNguoiMua.Location = new System.Drawing.Point(149, 55);
            this.txtNguoiMua.Name = "txtNguoiMua";
            this.txtNguoiMua.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiMua.TabIndex = 7;
            this.txtNguoiMua.TextChanged += new System.EventHandler(this.txtNguoiMua_TextChanged);
            // 
            // dateTimePickerDen
            // 
            this.dateTimePickerDen.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDen.Location = new System.Drawing.Point(618, 19);
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
            this.dateTimePickerTu.Location = new System.Drawing.Point(381, 19);
            this.dateTimePickerTu.Name = "dateTimePickerTu";
            this.dateTimePickerTu.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerTu.TabIndex = 5;
            this.dateTimePickerTu.ValueChanged += new System.EventHandler(this.dateTimePickerTu_ValueChanged);
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(149, 19);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(150, 20);
            this.txtMaPhieuXuat.TabIndex = 4;
            this.txtMaPhieuXuat.TextChanged += new System.EventHandler(this.txtMaPhieuXuat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người mua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đến";
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.dataGridView_TraCuuXuatHang);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(12, 128);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(860, 267);
            this.groupBoxDanhSach.TabIndex = 19;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách phiếu xuất";
            // 
            // dataGridView_TraCuuXuatHang
            // 
            this.dataGridView_TraCuuXuatHang.AllowUserToAddRows = false;
            this.dataGridView_TraCuuXuatHang.AllowUserToDeleteRows = false;
            this.dataGridView_TraCuuXuatHang.AllowUserToResizeColumns = false;
            this.dataGridView_TraCuuXuatHang.AllowUserToResizeRows = false;
            this.dataGridView_TraCuuXuatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_TraCuuXuatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_TraCuuXuatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TraCuuXuatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaPhieuXuat,
            this.clNgayBanHang,
            this.clNguoiMua,
            this.clNguoiBan,
            this.clSoLuong,
            this.clSoTien});
            this.dataGridView_TraCuuXuatHang.Location = new System.Drawing.Point(16, 20);
            this.dataGridView_TraCuuXuatHang.Name = "dataGridView_TraCuuXuatHang";
            this.dataGridView_TraCuuXuatHang.RowHeadersVisible = false;
            this.dataGridView_TraCuuXuatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TraCuuXuatHang.Size = new System.Drawing.Size(831, 239);
            this.dataGridView_TraCuuXuatHang.TabIndex = 14;
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
            // clMaPhieuXuat
            // 
            this.clMaPhieuXuat.HeaderText = "Mã phiếu xuất";
            this.clMaPhieuXuat.Name = "clMaPhieuXuat";
            this.clMaPhieuXuat.ReadOnly = true;
            this.clMaPhieuXuat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNgayBanHang
            // 
            this.clNgayBanHang.HeaderText = "Ngày bán hàng";
            this.clNgayBanHang.Name = "clNgayBanHang";
            this.clNgayBanHang.ReadOnly = true;
            this.clNgayBanHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNguoiMua
            // 
            this.clNguoiMua.HeaderText = "Người mua";
            this.clNguoiMua.Name = "clNguoiMua";
            this.clNguoiMua.ReadOnly = true;
            this.clNguoiMua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNguoiBan
            // 
            this.clNguoiBan.HeaderText = "Người bán";
            this.clNguoiBan.Name = "clNguoiBan";
            this.clNguoiBan.ReadOnly = true;
            this.clNguoiBan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.ReadOnly = true;
            // 
            // clSoTien
            // 
            this.clSoTien.HeaderText = "Số Tiền";
            this.clSoTien.Name = "clSoTien";
            this.clSoTien.ReadOnly = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(27, 19);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(100, 23);
            this.btnXemChiTiet.TabIndex = 9;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(712, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(544, 19);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(100, 23);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(287, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 23);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(417, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.btnTaoMoi);
            this.panelChucNang.Controls.Add(this.btnXemChiTiet);
            this.panelChucNang.Controls.Add(this.btnLamLai);
            this.panelChucNang.Controls.Add(this.btnThoat);
            this.panelChucNang.Controls.Add(this.btnCapNhat);
            this.panelChucNang.Controls.Add(this.btnXoa);
            this.panelChucNang.Location = new System.Drawing.Point(12, 398);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(860, 60);
            this.panelChucNang.TabIndex = 20;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(156, 19);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(100, 23);
            this.btnTaoMoi.TabIndex = 14;
            this.btnTaoMoi.Text = "Tạo phiếu xuất";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // FormQuanLyXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.panelChucNang);
            this.Name = "FormQuanLyXuatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý xuất hàng";
            this.Activated += new System.EventHandler(this.FormQuanLyXuatHang_Activated);
            this.Load += new System.EventHandler(this.FormQuanLyXuatHang_Load);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuXuatHang)).EndInit();
            this.panelChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNguoiMua;
        private System.Windows.Forms.DateTimePicker dateTimePickerDen;
        private System.Windows.Forms.DateTimePicker dateTimePickerTu;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.DataGridView dataGridView_TraCuuXuatHang;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.TextBox txtNguoiBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayBanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoTien;
        private System.Windows.Forms.Button btnTaoMoi;


    }
}