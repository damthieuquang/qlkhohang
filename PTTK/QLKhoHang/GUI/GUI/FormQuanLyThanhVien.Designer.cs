namespace GUI
{
    partial class FormQuanLyThanhVien
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
            this.groupBoxDSThamSo = new System.Windows.Forms.GroupBox();
            this.dataGridView_QuanLyThanhVien = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTienNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.textBoxTienNo = new System.Windows.Forms.TextBox();
            this.textBoxCV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenThanhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaThanhVien = new System.Windows.Forms.TextBox();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXemChiTiet = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonLamLai = new System.Windows.Forms.Button();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.groupBoxDSThamSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLyThanhVien)).BeginInit();
            this.panelYesNo.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDSThamSo
            // 
            this.groupBoxDSThamSo.Controls.Add(this.dataGridView_QuanLyThanhVien);
            this.groupBoxDSThamSo.Location = new System.Drawing.Point(61, 152);
            this.groupBoxDSThamSo.Name = "groupBoxDSThamSo";
            this.groupBoxDSThamSo.Size = new System.Drawing.Size(860, 288);
            this.groupBoxDSThamSo.TabIndex = 12;
            this.groupBoxDSThamSo.TabStop = false;
            this.groupBoxDSThamSo.Text = "Danh sách tham số";
            // 
            // dataGridView_QuanLyThanhVien
            // 
            this.dataGridView_QuanLyThanhVien.AllowUserToAddRows = false;
            this.dataGridView_QuanLyThanhVien.AllowUserToDeleteRows = false;
            this.dataGridView_QuanLyThanhVien.AllowUserToResizeColumns = false;
            this.dataGridView_QuanLyThanhVien.AllowUserToResizeRows = false;
            this.dataGridView_QuanLyThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_QuanLyThanhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_QuanLyThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QuanLyThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaThanhVien,
            this.ColTenThanhVien,
            this.ColDiaChi,
            this.ColCV,
            this.ColTienNo});
            this.dataGridView_QuanLyThanhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_QuanLyThanhVien.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_QuanLyThanhVien.Name = "dataGridView_QuanLyThanhVien";
            this.dataGridView_QuanLyThanhVien.RowHeadersVisible = false;
            this.dataGridView_QuanLyThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_QuanLyThanhVien.Size = new System.Drawing.Size(854, 269);
            this.dataGridView_QuanLyThanhVien.TabIndex = 0;
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
            // ColMaThanhVien
            // 
            this.ColMaThanhVien.HeaderText = "Mã thành viên";
            this.ColMaThanhVien.Name = "ColMaThanhVien";
            this.ColMaThanhVien.ReadOnly = true;
            this.ColMaThanhVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTenThanhVien
            // 
            this.ColTenThanhVien.HeaderText = "Tên thành viên";
            this.ColTenThanhVien.Name = "ColTenThanhVien";
            this.ColTenThanhVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColDiaChi
            // 
            this.ColDiaChi.HeaderText = "Địa chỉ";
            this.ColDiaChi.Name = "ColDiaChi";
            this.ColDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColCV
            // 
            this.ColCV.HeaderText = "Tổng CV";
            this.ColCV.Name = "ColCV";
            this.ColCV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTienNo
            // 
            this.ColTienNo.HeaderText = "Tiền nợ";
            this.ColTienNo.Name = "ColTienNo";
            this.ColTienNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelYesNo
            // 
            this.panelYesNo.Controls.Add(this.buttonNo);
            this.panelYesNo.Controls.Add(this.buttonYes);
            this.panelYesNo.Location = new System.Drawing.Point(12, 370);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(860, 61);
            this.panelYesNo.TabIndex = 14;
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
            this.buttonNo.TextChanged += new System.EventHandler(this.buttonNo_TextChanged);
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
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
            // textBoxTienNo
            // 
            this.textBoxTienNo.Location = new System.Drawing.Point(617, 83);
            this.textBoxTienNo.Name = "textBoxTienNo";
            this.textBoxTienNo.Size = new System.Drawing.Size(125, 20);
            this.textBoxTienNo.TabIndex = 4;
            // 
            // textBoxCV
            // 
            this.textBoxCV.Location = new System.Drawing.Point(156, 80);
            this.textBoxCV.Name = "textBoxCV";
            this.textBoxCV.Size = new System.Drawing.Size(125, 20);
            this.textBoxCV.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tiền nợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng CV";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(617, 48);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(125, 20);
            this.textBoxDiaChi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa chỉ";
            // 
            // textBoxTenThanhVien
            // 
            this.textBoxTenThanhVien.Location = new System.Drawing.Point(156, 45);
            this.textBoxTenThanhVien.Name = "textBoxTenThanhVien";
            this.textBoxTenThanhVien.Size = new System.Drawing.Size(125, 20);
            this.textBoxTenThanhVien.TabIndex = 4;
            this.textBoxTenThanhVien.TextChanged += new System.EventHandler(this.textBoxTenThanhVien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thành viên";
            // 
            // textBoxMaThanhVien
            // 
            this.textBoxMaThanhVien.Location = new System.Drawing.Point(406, 19);
            this.textBoxMaThanhVien.Name = "textBoxMaThanhVien";
            this.textBoxMaThanhVien.Size = new System.Drawing.Size(125, 20);
            this.textBoxMaThanhVien.TabIndex = 0;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxTienNo);
            this.groupBoxTimKiem.Controls.Add(this.textBoxCV);
            this.groupBoxTimKiem.Controls.Add(this.label5);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.textBoxDiaChi);
            this.groupBoxTimKiem.Controls.Add(this.label4);
            this.groupBoxTimKiem.Controls.Add(this.textBoxTenThanhVien);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.textBoxMaThanhVien);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(61, 25);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 121);
            this.groupBoxTimKiem.TabIndex = 11;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã thành viên";
            // 
            // buttonXemChiTiet
            // 
            this.buttonXemChiTiet.Location = new System.Drawing.Point(356, 14);
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
            this.buttonXoa.Location = new System.Drawing.Point(194, 14);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(113, 14);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(75, 23);
            this.buttonCapNhat.TabIndex = 3;
            this.buttonCapNhat.Text = "Cập nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(32, 14);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonLamLai
            // 
            this.buttonLamLai.Location = new System.Drawing.Point(275, 14);
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
            this.panelTimKiem.Location = new System.Drawing.Point(64, 446);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(860, 52);
            this.panelTimKiem.TabIndex = 13;
            // 
            // FormQuanLyThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.groupBoxDSThamSo);
            this.Controls.Add(this.panelYesNo);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Name = "FormQuanLyThanhVien";
            this.Text = "Quản lý thành viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormQuanLyThanhVien_Activated);
            this.groupBoxDSThamSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLyThanhVien)).EndInit();
            this.panelYesNo.ResumeLayout(false);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.panelTimKiem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDSThamSo;
        private System.Windows.Forms.DataGridView dataGridView_QuanLyThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTienNo;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.TextBox textBoxTienNo;
        private System.Windows.Forms.TextBox textBoxCV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTenThanhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaThanhVien;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXemChiTiet;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonLamLai;
        private System.Windows.Forms.Panel panelTimKiem;
    }
}