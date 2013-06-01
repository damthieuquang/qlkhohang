namespace GUI
{
    partial class FormQuanLyDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView_TraCuuDonHang = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNguoiDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.comboBoxTrangThai = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNguoiDat = new System.Windows.Forms.TextBox();
            this.dateTimePickerDen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuDonHang)).BeginInit();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người đặt";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(149, 22);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(150, 20);
            this.txtMaDonHang.TabIndex = 4;
            this.txtMaDonHang.TextChanged += new System.EventHandler(this.txtMaDonHang_TextChanged);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(19, 19);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(100, 23);
            this.btnXemChiTiet.TabIndex = 9;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(488, 19);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(100, 23);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(250, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 23);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(370, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(728, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView_TraCuuDonHang
            // 
            this.dataGridView_TraCuuDonHang.AllowUserToAddRows = false;
            this.dataGridView_TraCuuDonHang.AllowUserToDeleteRows = false;
            this.dataGridView_TraCuuDonHang.AllowUserToResizeColumns = false;
            this.dataGridView_TraCuuDonHang.AllowUserToResizeRows = false;
            this.dataGridView_TraCuuDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_TraCuuDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_TraCuuDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TraCuuDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaDonHang,
            this.clNgayDat,
            this.clNguoiDat,
            this.clThanhTien,
            this.clTrangThai});
            this.dataGridView_TraCuuDonHang.Location = new System.Drawing.Point(16, 19);
            this.dataGridView_TraCuuDonHang.Name = "dataGridView_TraCuuDonHang";
            this.dataGridView_TraCuuDonHang.RowHeadersVisible = false;
            this.dataGridView_TraCuuDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_TraCuuDonHang.Size = new System.Drawing.Size(831, 239);
            this.dataGridView_TraCuuDonHang.TabIndex = 14;
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
            // clMaDonHang
            // 
            this.clMaDonHang.HeaderText = "Mã đơn hàng";
            this.clMaDonHang.Name = "clMaDonHang";
            this.clMaDonHang.ReadOnly = true;
            this.clMaDonHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNgayDat
            // 
            this.clNgayDat.HeaderText = "Ngày đặt";
            this.clNgayDat.Name = "clNgayDat";
            this.clNgayDat.ReadOnly = true;
            this.clNgayDat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clNguoiDat
            // 
            this.clNguoiDat.HeaderText = "Người đặt";
            this.clNguoiDat.Name = "clNguoiDat";
            this.clNguoiDat.ReadOnly = true;
            this.clNguoiDat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clThanhTien
            // 
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.ReadOnly = true;
            // 
            // clTrangThai
            // 
            this.clTrangThai.HeaderText = "Trạng thái";
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.ReadOnly = true;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.comboBoxTrangThai);
            this.groupBoxTimKiem.Controls.Add(this.txtThanhTien);
            this.groupBoxTimKiem.Controls.Add(this.label6);
            this.groupBoxTimKiem.Controls.Add(this.label5);
            this.groupBoxTimKiem.Controls.Add(this.txtNguoiDat);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerDen);
            this.groupBoxTimKiem.Controls.Add(this.dateTimePickerTu);
            this.groupBoxTimKiem.Controls.Add(this.txtMaDonHang);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.label4);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(12, 11);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 100);
            this.groupBoxTimKiem.TabIndex = 15;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.FormattingEnabled = true;
            this.comboBoxTrangThai.Location = new System.Drawing.Point(618, 59);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTrangThai.TabIndex = 11;
            this.comboBoxTrangThai.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrangThai_SelectedIndexChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(381, 59);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(150, 20);
            this.txtThanhTien.TabIndex = 10;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thành tiền";
            // 
            // txtNguoiDat
            // 
            this.txtNguoiDat.Location = new System.Drawing.Point(149, 59);
            this.txtNguoiDat.Name = "txtNguoiDat";
            this.txtNguoiDat.Size = new System.Drawing.Size(150, 20);
            this.txtNguoiDat.TabIndex = 7;
            this.txtNguoiDat.TextChanged += new System.EventHandler(this.txtNguoiDat_TextChanged);
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
            this.groupBoxDanhSach.Controls.Add(this.dataGridView_TraCuuDonHang);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(12, 126);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(860, 267);
            this.groupBoxDanhSach.TabIndex = 16;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách đơn hàng";
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.button1);
            this.panelChucNang.Controls.Add(this.btnXemChiTiet);
            this.panelChucNang.Controls.Add(this.btnLamLai);
            this.panelChucNang.Controls.Add(this.btnThoat);
            this.panelChucNang.Controls.Add(this.btnCapNhat);
            this.panelChucNang.Controls.Add(this.btnXoa);
            this.panelChucNang.Location = new System.Drawing.Point(12, 399);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(860, 60);
            this.panelChucNang.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tạo đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormQuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Name = "FormQuanLyDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            this.Activated += new System.EventHandler(this.FormQuanLyDonHang_Activated);
            this.Load += new System.EventHandler(this.FormQuanLyDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TraCuuDonHang)).EndInit();
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxDanhSach.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDonHang;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView_TraCuuDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNguoiDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrangThai;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNguoiDat;
        private System.Windows.Forms.DateTimePicker dateTimePickerDen;
        private System.Windows.Forms.ComboBox comboBoxTrangThai;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button button1;
    }
}