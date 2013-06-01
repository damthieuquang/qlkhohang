namespace GUI
{
    partial class FormQuanLyLoaiSanPham
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
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.textBoxTenLoaiSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaLoaiSanPham = new System.Windows.Forms.TextBox();
            this.buttonNo = new System.Windows.Forms.Button();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.buttonYes = new System.Windows.Forms.Button();
            this.dataGridView_QuanLyLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDSThamSo = new System.Windows.Forms.GroupBox();
            this.panelTimKiem.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.panelYesNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLyLoaiSanPham)).BeginInit();
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
            this.panelTimKiem.Location = new System.Drawing.Point(18, 398);
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
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxTenLoaiSanPham);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.textBoxMaLoaiSanPham);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(18, 10);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 69);
            this.groupBoxTimKiem.TabIndex = 7;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // textBoxTenLoaiSanPham
            // 
            this.textBoxTenLoaiSanPham.Location = new System.Drawing.Point(526, 29);
            this.textBoxTenLoaiSanPham.Name = "textBoxTenLoaiSanPham";
            this.textBoxTenLoaiSanPham.Size = new System.Drawing.Size(125, 20);
            this.textBoxTenLoaiSanPham.TabIndex = 4;
            this.textBoxTenLoaiSanPham.TextChanged += new System.EventHandler(this.textBoxTenLoaiSanPham_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại sản phẩm";
            // 
            // textBoxMaLoaiSanPham
            // 
            this.textBoxMaLoaiSanPham.Location = new System.Drawing.Point(258, 29);
            this.textBoxMaLoaiSanPham.Name = "textBoxMaLoaiSanPham";
            this.textBoxMaLoaiSanPham.Size = new System.Drawing.Size(125, 20);
            this.textBoxMaLoaiSanPham.TabIndex = 0;
            this.textBoxMaLoaiSanPham.TextChanged += new System.EventHandler(this.textBoxMaLoaiSanPham_TextChanged);
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
            this.panelYesNo.Location = new System.Drawing.Point(6, 331);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(860, 52);
            this.panelYesNo.TabIndex = 10;
            this.panelYesNo.Visible = false;
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
            // dataGridView_QuanLyLoaiSanPham
            // 
            this.dataGridView_QuanLyLoaiSanPham.AllowUserToAddRows = false;
            this.dataGridView_QuanLyLoaiSanPham.AllowUserToDeleteRows = false;
            this.dataGridView_QuanLyLoaiSanPham.AllowUserToResizeColumns = false;
            this.dataGridView_QuanLyLoaiSanPham.AllowUserToResizeRows = false;
            this.dataGridView_QuanLyLoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_QuanLyLoaiSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_QuanLyLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_QuanLyLoaiSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaLoaiSanPham,
            this.ColTenLoaiSanPham});
            this.dataGridView_QuanLyLoaiSanPham.Location = new System.Drawing.Point(13, 26);
            this.dataGridView_QuanLyLoaiSanPham.Name = "dataGridView_QuanLyLoaiSanPham";
            this.dataGridView_QuanLyLoaiSanPham.RowHeadersVisible = false;
            this.dataGridView_QuanLyLoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_QuanLyLoaiSanPham.Size = new System.Drawing.Size(835, 243);
            this.dataGridView_QuanLyLoaiSanPham.TabIndex = 0;
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
            // ColMaLoaiSanPham
            // 
            this.ColMaLoaiSanPham.HeaderText = "Mã loại sản phẩm";
            this.ColMaLoaiSanPham.Name = "ColMaLoaiSanPham";
            this.ColMaLoaiSanPham.ReadOnly = true;
            this.ColMaLoaiSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTenLoaiSanPham
            // 
            this.ColTenLoaiSanPham.HeaderText = "Tên loại sản phẩm";
            this.ColTenLoaiSanPham.Name = "ColTenLoaiSanPham";
            this.ColTenLoaiSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBoxDSThamSo
            // 
            this.groupBoxDSThamSo.Controls.Add(this.dataGridView_QuanLyLoaiSanPham);
            this.groupBoxDSThamSo.Location = new System.Drawing.Point(18, 105);
            this.groupBoxDSThamSo.Name = "groupBoxDSThamSo";
            this.groupBoxDSThamSo.Size = new System.Drawing.Size(860, 284);
            this.groupBoxDSThamSo.TabIndex = 8;
            this.groupBoxDSThamSo.TabStop = false;
            this.groupBoxDSThamSo.Text = "Danh sách tham số";
            // 
            // FormQuanLyLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.panelYesNo);
            this.Controls.Add(this.groupBoxDSThamSo);
            this.Name = "FormQuanLyLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại sản phẩm";
            this.Load += new System.EventHandler(this.FormQuanLyLoaiSanPham_Load);
            this.panelTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.panelYesNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_QuanLyLoaiSanPham)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.TextBox textBoxTenLoaiSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaLoaiSanPham;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.DataGridView dataGridView_QuanLyLoaiSanPham;
        private System.Windows.Forms.GroupBox groupBoxDSThamSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenLoaiSanPham;
    }
}