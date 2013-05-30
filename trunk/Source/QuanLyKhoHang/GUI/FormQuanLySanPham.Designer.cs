namespace GUI
{
    partial class FormQuanLySanPham
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
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonLamLai = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.textBoxCV = new System.Windows.Forms.TextBox();
            this.textBoxTenSanPham = new System.Windows.Forms.TextBox();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.textBoxDonGiaTV = new System.Windows.Forms.TextBox();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoLuongTon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaSanPham = new System.Windows.Forms.TextBox();
            this.dataGridView_QuanLySanPham = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGiaTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDSThamSo = new System.Windows.Forms.GroupBox();
            this.cmbMaLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.panelTimKiem.SuspendLayout();
            this.panelYesNo.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLySanPham)).BeginInit();
            this.groupBoxDSThamSo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.Controls.Add(this.buttonThoat);
            this.panelTimKiem.Controls.Add(this.buttonXoa);
            this.panelTimKiem.Controls.Add(this.buttonCapNhat);
            this.panelTimKiem.Controls.Add(this.buttonThem);
            this.panelTimKiem.Controls.Add(this.buttonLamLai);
            this.panelTimKiem.Location = new System.Drawing.Point(18, 459);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(860, 52);
            this.panelTimKiem.TabIndex = 9;
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
            this.buttonXoa.Location = new System.Drawing.Point(194, 14);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click_1);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(113, 14);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(75, 23);
            this.buttonCapNhat.TabIndex = 3;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click_1);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(32, 14);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click_1);
            // 
            // buttonLamLai
            // 
            this.buttonLamLai.Location = new System.Drawing.Point(275, 14);
            this.buttonLamLai.Name = "buttonLamLai";
            this.buttonLamLai.Size = new System.Drawing.Size(75, 23);
            this.buttonLamLai.TabIndex = 1;
            this.buttonLamLai.Text = "Làm lại";
            this.buttonLamLai.UseVisualStyleBackColor = true;
            this.buttonLamLai.Click += new System.EventHandler(this.buttonLamLai_Click_1);
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(311, 15);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(75, 23);
            this.buttonYes.TabIndex = 0;
            this.buttonYes.Text = "Yes";
            this.buttonYes.UseVisualStyleBackColor = true;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click_1);
            // 
            // panelYesNo
            // 
            this.panelYesNo.Controls.Add(this.buttonNo);
            this.panelYesNo.Controls.Add(this.buttonYes);
            this.panelYesNo.Location = new System.Drawing.Point(12, 383);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(860, 52);
            this.panelYesNo.TabIndex = 10;
            this.panelYesNo.Visible = false;
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(418, 15);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(75, 23);
            this.buttonNo.TabIndex = 1;
            this.buttonNo.Text = "Hủy";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click_1);
            // 
            // textBoxCV
            // 
            this.textBoxCV.Location = new System.Drawing.Point(164, 65);
            this.textBoxCV.Name = "textBoxCV";
            this.textBoxCV.Size = new System.Drawing.Size(125, 20);
            this.textBoxCV.TabIndex = 5;
            // 
            // textBoxTenSanPham
            // 
            this.textBoxTenSanPham.Location = new System.Drawing.Point(164, 39);
            this.textBoxTenSanPham.Name = "textBoxTenSanPham";
            this.textBoxTenSanPham.Size = new System.Drawing.Size(125, 20);
            this.textBoxTenSanPham.TabIndex = 4;
            this.textBoxTenSanPham.TextChanged += new System.EventHandler(this.textBoxTenSanPham_TextChanged_1);
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.cmbMaLoaiSanPham);
            this.groupBoxTimKiem.Controls.Add(this.textBoxDonGiaTV);
            this.groupBoxTimKiem.Controls.Add(this.textBoxDonGia);
            this.groupBoxTimKiem.Controls.Add(this.textBoxCV);
            this.groupBoxTimKiem.Controls.Add(this.label7);
            this.groupBoxTimKiem.Controls.Add(this.label4);
            this.groupBoxTimKiem.Controls.Add(this.textBoxSoLuongTon);
            this.groupBoxTimKiem.Controls.Add(this.label6);
            this.groupBoxTimKiem.Controls.Add(this.textBoxTenSanPham);
            this.groupBoxTimKiem.Controls.Add(this.label5);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.textBoxMaSanPham);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(18, 12);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 133);
            this.groupBoxTimKiem.TabIndex = 7;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // textBoxDonGiaTV
            // 
            this.textBoxDonGiaTV.Location = new System.Drawing.Point(597, 94);
            this.textBoxDonGiaTV.Name = "textBoxDonGiaTV";
            this.textBoxDonGiaTV.Size = new System.Drawing.Size(125, 20);
            this.textBoxDonGiaTV.TabIndex = 5;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(164, 91);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(125, 20);
            this.textBoxDonGia.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Đơn giá TV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // textBoxSoLuongTon
            // 
            this.textBoxSoLuongTon.Location = new System.Drawing.Point(597, 42);
            this.textBoxSoLuongTon.Name = "textBoxSoLuongTon";
            this.textBoxSoLuongTon.Size = new System.Drawing.Size(125, 20);
            this.textBoxSoLuongTon.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mã loại sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng tồn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // textBoxMaSanPham
            // 
            this.textBoxMaSanPham.Location = new System.Drawing.Point(394, 10);
            this.textBoxMaSanPham.Name = "textBoxMaSanPham";
            this.textBoxMaSanPham.Size = new System.Drawing.Size(125, 20);
            this.textBoxMaSanPham.TabIndex = 0;
            this.textBoxMaSanPham.TextChanged += new System.EventHandler(this.textBoxMaSanPham_TextChanged_1);
            // 
            // dataGridView_QuanLySanPham
            // 
            this.dataGridView_QuanLySanPham.AllowUserToAddRows = false;
            this.dataGridView_QuanLySanPham.AllowUserToDeleteRows = false;
            this.dataGridView_QuanLySanPham.AllowUserToResizeColumns = false;
            this.dataGridView_QuanLySanPham.AllowUserToResizeRows = false;
            this.dataGridView_QuanLySanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_QuanLySanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_QuanLySanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QuanLySanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaSanPham,
            this.ColTenSanPham,
            this.ColCV,
            this.ColDonGia,
            this.ColDonGiaTV,
            this.ColSoLuongTon,
            this.ColMaLoaiSanPham});
            this.dataGridView_QuanLySanPham.Location = new System.Drawing.Point(13, 26);
            this.dataGridView_QuanLySanPham.Name = "dataGridView_QuanLySanPham";
            this.dataGridView_QuanLySanPham.RowHeadersVisible = false;
            this.dataGridView_QuanLySanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_QuanLySanPham.Size = new System.Drawing.Size(835, 198);
            this.dataGridView_QuanLySanPham.TabIndex = 0;
            // 
            // ColSTT
            // 
            this.ColSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.ReadOnly = true;
            this.ColSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSTT.Width = 50;
            // 
            // ColMaSanPham
            // 
            this.ColMaSanPham.HeaderText = "Mã sản phẩm";
            this.ColMaSanPham.Name = "ColMaSanPham";
            this.ColMaSanPham.ReadOnly = true;
            this.ColMaSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTenSanPham
            // 
            this.ColTenSanPham.HeaderText = "Tên sản phẩm";
            this.ColTenSanPham.Name = "ColTenSanPham";
            this.ColTenSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCV
            // 
            this.ColCV.HeaderText = "CV";
            this.ColCV.Name = "ColCV";
            this.ColCV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDonGia
            // 
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.Name = "ColDonGia";
            // 
            // ColDonGiaTV
            // 
            this.ColDonGiaTV.HeaderText = "Đơn giá TV";
            this.ColDonGiaTV.Name = "ColDonGiaTV";
            // 
            // ColSoLuongTon
            // 
            this.ColSoLuongTon.HeaderText = "Số lượng tồn";
            this.ColSoLuongTon.Name = "ColSoLuongTon";
            // 
            // ColMaLoaiSanPham
            // 
            this.ColMaLoaiSanPham.HeaderText = "Mã loại sản phẩm";
            this.ColMaLoaiSanPham.Name = "ColMaLoaiSanPham";
            // 
            // groupBoxDSThamSo
            // 
            this.groupBoxDSThamSo.Controls.Add(this.dataGridView_QuanLySanPham);
            this.groupBoxDSThamSo.Location = new System.Drawing.Point(18, 151);
            this.groupBoxDSThamSo.Name = "groupBoxDSThamSo";
            this.groupBoxDSThamSo.Size = new System.Drawing.Size(860, 284);
            this.groupBoxDSThamSo.TabIndex = 8;
            this.groupBoxDSThamSo.TabStop = false;
            this.groupBoxDSThamSo.Text = "Danh sách tham số";
            // 
            // cmbMaLoaiSanPham
            // 
            this.cmbMaLoaiSanPham.FormattingEnabled = true;
            this.cmbMaLoaiSanPham.Location = new System.Drawing.Point(597, 67);
            this.cmbMaLoaiSanPham.Name = "cmbMaLoaiSanPham";
            this.cmbMaLoaiSanPham.Size = new System.Drawing.Size(125, 21);
            this.cmbMaLoaiSanPham.TabIndex = 6;
            // 
            // FormQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 523);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.panelYesNo);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.groupBoxDSThamSo);
            this.Name = "FormQuanLySanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.FormQuanLySanPham_Load);
            this.panelTimKiem.ResumeLayout(false);
            this.panelYesNo.ResumeLayout(false);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLySanPham)).EndInit();
            this.groupBoxDSThamSo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonLamLai;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.TextBox textBoxCV;
        private System.Windows.Forms.TextBox textBoxTenSanPham;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaSanPham;
        private System.Windows.Forms.DataGridView dataGridView_QuanLySanPham;
        private System.Windows.Forms.GroupBox groupBoxDSThamSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGiaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaLoaiSanPham;
        private System.Windows.Forms.TextBox textBoxDonGiaTV;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoLuongTon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaLoaiSanPham;

    }
}