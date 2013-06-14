namespace GUI
{
    partial class FormChiTietThanhVien
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSanPham = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerDen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTu = new System.Windows.Forms.DateTimePicker();
            this.textBoxNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMaThanhVien = new System.Windows.Forms.Label();
            this.labelTenThanhVien = new System.Windows.Forms.Label();
            this.labelTongCV = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.dataGridViewChiTiet = new System.Windows.Forms.DataGridView();
            this.clPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLamLai = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewChiTiet);
            this.splitContainer1.Size = new System.Drawing.Size(969, 461);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonThoat);
            this.groupBox2.Controls.Add(this.buttonLamLai);
            this.groupBox2.Controls.Add(this.textBoxSanPham);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimePickerDen);
            this.groupBox2.Controls.Add(this.dateTimePickerTu);
            this.groupBox2.Controls.Add(this.textBoxNhanVien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(11, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 254);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // textBoxSanPham
            // 
            this.textBoxSanPham.Location = new System.Drawing.Point(70, 173);
            this.textBoxSanPham.Name = "textBoxSanPham";
            this.textBoxSanPham.Size = new System.Drawing.Size(107, 20);
            this.textBoxSanPham.TabIndex = 14;
            this.textBoxSanPham.TextChanged += new System.EventHandler(this.textBoxSanPham_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sản phẩm";
            // 
            // dateTimePickerDen
            // 
            this.dateTimePickerDen.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDen.Location = new System.Drawing.Point(70, 83);
            this.dateTimePickerDen.Name = "dateTimePickerDen";
            this.dateTimePickerDen.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerDen.TabIndex = 12;
            this.dateTimePickerDen.ValueChanged += new System.EventHandler(this.dateTimePickerDen_ValueChanged);
            // 
            // dateTimePickerTu
            // 
            this.dateTimePickerTu.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTu.Location = new System.Drawing.Point(70, 50);
            this.dateTimePickerTu.Name = "dateTimePickerTu";
            this.dateTimePickerTu.Size = new System.Drawing.Size(107, 20);
            this.dateTimePickerTu.TabIndex = 11;
            this.dateTimePickerTu.ValueChanged += new System.EventHandler(this.dateTimePickerTu_ValueChanged);
            // 
            // textBoxNhanVien
            // 
            this.textBoxNhanVien.Location = new System.Drawing.Point(70, 128);
            this.textBoxNhanVien.Name = "textBoxNhanVien";
            this.textBoxNhanVien.Size = new System.Drawing.Size(107, 20);
            this.textBoxNhanVien.TabIndex = 10;
            this.textBoxNhanVien.TextChanged += new System.EventHandler(this.textBoxNhanVien_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày bán:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaThanhVien);
            this.groupBox1.Controls.Add(this.labelTenThanhVien);
            this.groupBox1.Controls.Add(this.labelTongCV);
            this.groupBox1.Controls.Add(this.labelDiaChi);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 161);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thành viên";
            // 
            // labelMaThanhVien
            // 
            this.labelMaThanhVien.AutoSize = true;
            this.labelMaThanhVien.Location = new System.Drawing.Point(8, 28);
            this.labelMaThanhVien.Name = "labelMaThanhVien";
            this.labelMaThanhVien.Size = new System.Drawing.Size(35, 13);
            this.labelMaThanhVien.TabIndex = 0;
            this.labelMaThanhVien.Text = "label1";
            // 
            // labelTenThanhVien
            // 
            this.labelTenThanhVien.AutoSize = true;
            this.labelTenThanhVien.Location = new System.Drawing.Point(8, 62);
            this.labelTenThanhVien.Name = "labelTenThanhVien";
            this.labelTenThanhVien.Size = new System.Drawing.Size(35, 13);
            this.labelTenThanhVien.TabIndex = 1;
            this.labelTenThanhVien.Text = "label2";
            // 
            // labelTongCV
            // 
            this.labelTongCV.AutoSize = true;
            this.labelTongCV.Location = new System.Drawing.Point(8, 131);
            this.labelTongCV.Name = "labelTongCV";
            this.labelTongCV.Size = new System.Drawing.Size(35, 13);
            this.labelTongCV.TabIndex = 3;
            this.labelTongCV.Text = "label4";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(8, 96);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(35, 13);
            this.labelDiaChi.TabIndex = 2;
            this.labelDiaChi.Text = "label3";
            // 
            // dataGridViewChiTiet
            // 
            this.dataGridViewChiTiet.AllowUserToAddRows = false;
            this.dataGridViewChiTiet.AllowUserToDeleteRows = false;
            this.dataGridViewChiTiet.AllowUserToResizeColumns = false;
            this.dataGridViewChiTiet.AllowUserToResizeRows = false;
            this.dataGridViewChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChiTiet.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clPhieuXuat,
            this.clNgayBan,
            this.clNhanVien,
            this.clSanPham,
            this.clSoLuong,
            this.clThanhTien});
            this.dataGridViewChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChiTiet.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewChiTiet.Name = "dataGridViewChiTiet";
            this.dataGridViewChiTiet.RowHeadersVisible = false;
            this.dataGridViewChiTiet.Size = new System.Drawing.Size(751, 461);
            this.dataGridViewChiTiet.TabIndex = 0;
            // 
            // clPhieuXuat
            // 
            this.clPhieuXuat.HeaderText = "Phiếu xuất";
            this.clPhieuXuat.Name = "clPhieuXuat";
            // 
            // clNgayBan
            // 
            this.clNgayBan.HeaderText = "Ngày Bán";
            this.clNgayBan.Name = "clNgayBan";
            // 
            // clNhanVien
            // 
            this.clNhanVien.HeaderText = "Nhân viên";
            this.clNhanVien.Name = "clNhanVien";
            // 
            // clSanPham
            // 
            this.clSanPham.HeaderText = "Sản phẩm";
            this.clSanPham.Name = "clSanPham";
            // 
            // clSoLuong
            // 
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            // 
            // clThanhTien
            // 
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            // 
            // buttonLamLai
            // 
            this.buttonLamLai.Location = new System.Drawing.Point(6, 210);
            this.buttonLamLai.Name = "buttonLamLai";
            this.buttonLamLai.Size = new System.Drawing.Size(75, 23);
            this.buttonLamLai.TabIndex = 15;
            this.buttonLamLai.Text = "Làm lại";
            this.buttonLamLai.UseVisualStyleBackColor = true;
            this.buttonLamLai.Click += new System.EventHandler(this.buttonLamLai_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(114, 210);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 16;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // FormChiTietThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 461);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormChiTietThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết thành viên";
            this.Load += new System.EventHandler(this.FormChiTietThanhVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMaThanhVien;
        private System.Windows.Forms.Label labelTenThanhVien;
        private System.Windows.Forms.Label labelTongCV;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewChiTiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.TextBox textBoxNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.DateTimePicker dateTimePickerDen;
        private System.Windows.Forms.DateTimePicker dateTimePickerTu;
        private System.Windows.Forms.TextBox textBoxSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonLamLai;
    }
}