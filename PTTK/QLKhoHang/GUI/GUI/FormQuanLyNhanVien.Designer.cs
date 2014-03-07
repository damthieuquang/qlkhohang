namespace GUI
{
    partial class FormQuanLyNhanVien
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
            this.comboBoxLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.clComboBoxLoaiNhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonXemChiTiet = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonLamLai = new System.Windows.Forms.Button();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFull = new System.Windows.Forms.Panel();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).BeginInit();
            this.panelYesNo.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.panelFull.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxLoaiNhanVien
            // 
            this.comboBoxLoaiNhanVien.FormattingEnabled = true;
            this.comboBoxLoaiNhanVien.Location = new System.Drawing.Point(664, 30);
            this.comboBoxLoaiNhanVien.Name = "comboBoxLoaiNhanVien";
            this.comboBoxLoaiNhanVien.Size = new System.Drawing.Size(150, 21);
            this.comboBoxLoaiNhanVien.TabIndex = 44;
            this.comboBoxLoaiNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiNhanVien_SelectedIndexChanged);
            // 
            // clComboBoxLoaiNhanVien
            // 
            this.clComboBoxLoaiNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clComboBoxLoaiNhanVien.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.clComboBoxLoaiNhanVien.HeaderText = "Loại nhân viên";
            this.clComboBoxLoaiNhanVien.Name = "clComboBoxLoaiNhanVien";
            this.clComboBoxLoaiNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clComboBoxLoaiNhanVien.Width = 150;
            // 
            // clMatKhau
            // 
            this.clMatKhau.HeaderText = "Mật khẩu";
            this.clMatKhau.Name = "clMatKhau";
            this.clMatKhau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clTenNhanVien
            // 
            this.clTenNhanVien.HeaderText = "Tên nhân viên";
            this.clTenNhanVien.Name = "clTenNhanVien";
            this.clTenNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clMaNhanVien
            // 
            this.clMaNhanVien.HeaderText = "Mã nhân viên";
            this.clMaNhanVien.Name = "clMaNhanVien";
            this.clMaNhanVien.ReadOnly = true;
            this.clMaNhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // dataGridView_NhanVien
            // 
            this.dataGridView_NhanVien.AllowUserToAddRows = false;
            this.dataGridView_NhanVien.AllowUserToDeleteRows = false;
            this.dataGridView_NhanVien.AllowUserToResizeColumns = false;
            this.dataGridView_NhanVien.AllowUserToResizeRows = false;
            this.dataGridView_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaNhanVien,
            this.clTenNhanVien,
            this.clMatKhau,
            this.clComboBoxLoaiNhanVien});
            this.dataGridView_NhanVien.Location = new System.Drawing.Point(6, 17);
            this.dataGridView_NhanVien.MultiSelect = false;
            this.dataGridView_NhanVien.Name = "dataGridView_NhanVien";
            this.dataGridView_NhanVien.RowHeadersVisible = false;
            this.dataGridView_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_NhanVien.Size = new System.Drawing.Size(848, 243);
            this.dataGridView_NhanVien.TabIndex = 44;
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(311, 15);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonXemChiTiet
            // 
            this.buttonXemChiTiet.Location = new System.Drawing.Point(21, 14);
            this.buttonXemChiTiet.Name = "buttonXemChiTiet";
            this.buttonXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.buttonXemChiTiet.TabIndex = 6;
            this.buttonXemChiTiet.Text = "Xem chi tiết";
            this.buttonXemChiTiet.UseVisualStyleBackColor = true;
            this.buttonXemChiTiet.Click += new System.EventHandler(this.buttonXemChiTiet_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(758, 14);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(264, 14);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(183, 14);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(75, 23);
            this.buttonCapNhat.TabIndex = 3;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(418, 15);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "Hủy";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // panelYesNo
            // 
            this.panelYesNo.Controls.Add(this.buttonNo);
            this.panelYesNo.Controls.Add(this.buttonYes);
            this.panelYesNo.Location = new System.Drawing.Point(14, 188);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(840, 52);
            this.panelYesNo.TabIndex = 45;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(102, 14);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonLamLai
            // 
            this.buttonLamLai.Location = new System.Drawing.Point(345, 14);
            this.buttonLamLai.Name = "buttonLamLai";
            this.buttonLamLai.Size = new System.Drawing.Size(75, 23);
            this.buttonLamLai.TabIndex = 1;
            this.buttonLamLai.Text = "Làm lại";
            this.buttonLamLai.UseVisualStyleBackColor = true;
            this.buttonLamLai.Click += new System.EventHandler(this.buttonLamLai_Click);
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.Controls.Add(this.buttonXemChiTiet);
            this.panelTimKiem.Controls.Add(this.buttonThoat);
            this.panelTimKiem.Controls.Add(this.buttonXoa);
            this.panelTimKiem.Controls.Add(this.buttonCapNhat);
            this.panelTimKiem.Controls.Add(this.buttonThem);
            this.panelTimKiem.Controls.Add(this.buttonLamLai);
            this.panelTimKiem.Location = new System.Drawing.Point(17, 390);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(840, 52);
            this.panelTimKiem.TabIndex = 47;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.comboBoxLoaiNhanVien);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.txtMaNhanVien);
            this.groupBoxTimKiem.Controls.Add(this.txtTenNhanVien);
            this.groupBoxTimKiem.Controls.Add(this.label5);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(5, 7);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 80);
            this.groupBoxTimKiem.TabIndex = 45;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(130, 30);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(150, 20);
            this.txtMaNhanVien.TabIndex = 32;
            this.txtMaNhanVien.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(390, 30);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(150, 20);
            this.txtTenNhanVien.TabIndex = 42;
            this.txtTenNhanVien.TextChanged += new System.EventHandler(this.txtTenNhanVien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Loại nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên nhân viên";
            // 
            // panelFull
            // 
            this.panelFull.Controls.Add(this.panelTimKiem);
            this.panelFull.Controls.Add(this.groupBoxDanhSach);
            this.panelFull.Controls.Add(this.groupBoxTimKiem);
            this.panelFull.Controls.Add(this.btnTraCuu);
            this.panelFull.Location = new System.Drawing.Point(58, 26);
            this.panelFull.Name = "panelFull";
            this.panelFull.Size = new System.Drawing.Size(870, 450);
            this.panelFull.TabIndex = 46;
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.panelYesNo);
            this.groupBoxDanhSach.Controls.Add(this.dataGridView_NhanVien);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(5, 104);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(860, 269);
            this.groupBoxDanhSach.TabIndex = 46;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách nhân viên";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(-99, 350);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 36;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Controls.Add(this.panelFull);
            this.Name = "FormQuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormQuanLyNhanVien_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).EndInit();
            this.panelYesNo.ResumeLayout(false);
            this.panelTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.panelFull.ResumeLayout(false);
            this.groupBoxDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLoaiNhanVien;
        private System.Windows.Forms.DataGridViewComboBoxColumn clComboBoxLoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridView dataGridView_NhanVien;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonXemChiTiet;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonLamLai;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFull;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.Button btnTraCuu;
    }
}