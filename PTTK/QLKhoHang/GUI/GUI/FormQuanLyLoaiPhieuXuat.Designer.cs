namespace GUI
{
    partial class FormQuanLyLoaiPhieuXuat
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
            this.groupBoxDSLoaiPhieuXuat = new System.Windows.Forms.GroupBox();
            this.dataGridViewLoaiPhieuXuat = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaLoaiPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenLoaiPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonYes = new System.Windows.Forms.Button();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.textBoxTenLoaiPhieuXuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaLoaiPhieuXuat = new System.Windows.Forms.TextBox();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonLamLai = new System.Windows.Forms.Button();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.groupBoxDSLoaiPhieuXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiPhieuXuat)).BeginInit();
            this.panelYesNo.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            this.groupBoxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDSLoaiPhieuXuat
            // 
            this.groupBoxDSLoaiPhieuXuat.Controls.Add(this.dataGridViewLoaiPhieuXuat);
            this.groupBoxDSLoaiPhieuXuat.Location = new System.Drawing.Point(71, 87);
            this.groupBoxDSLoaiPhieuXuat.Name = "groupBoxDSLoaiPhieuXuat";
            this.groupBoxDSLoaiPhieuXuat.Size = new System.Drawing.Size(860, 319);
            this.groupBoxDSLoaiPhieuXuat.TabIndex = 12;
            this.groupBoxDSLoaiPhieuXuat.TabStop = false;
            this.groupBoxDSLoaiPhieuXuat.Text = "Danh sách loại phiếu xuất ";
            // 
            // dataGridViewLoaiPhieuXuat
            // 
            this.dataGridViewLoaiPhieuXuat.AllowUserToAddRows = false;
            this.dataGridViewLoaiPhieuXuat.AllowUserToDeleteRows = false;
            this.dataGridViewLoaiPhieuXuat.AllowUserToResizeColumns = false;
            this.dataGridViewLoaiPhieuXuat.AllowUserToResizeRows = false;
            this.dataGridViewLoaiPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoaiPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLoaiPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoaiPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaLoaiPhieuXuat,
            this.ColTenLoaiPhieuXuat});
            this.dataGridViewLoaiPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLoaiPhieuXuat.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLoaiPhieuXuat.Name = "dataGridViewLoaiPhieuXuat";
            this.dataGridViewLoaiPhieuXuat.RowHeadersVisible = false;
            this.dataGridViewLoaiPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoaiPhieuXuat.Size = new System.Drawing.Size(854, 300);
            this.dataGridViewLoaiPhieuXuat.TabIndex = 0;
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
            // ColMaLoaiPhieuXuat
            // 
            this.ColMaLoaiPhieuXuat.HeaderText = "Mã loại phiếu xuất";
            this.ColMaLoaiPhieuXuat.Name = "ColMaLoaiPhieuXuat";
            this.ColMaLoaiPhieuXuat.ReadOnly = true;
            this.ColMaLoaiPhieuXuat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTenLoaiPhieuXuat
            // 
            this.ColTenLoaiPhieuXuat.HeaderText = "Tên loại phiếu xuất";
            this.ColTenLoaiPhieuXuat.Name = "ColTenLoaiPhieuXuat";
            this.ColTenLoaiPhieuXuat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // panelYesNo
            // 
            this.panelYesNo.Controls.Add(this.buttonNo);
            this.panelYesNo.Controls.Add(this.buttonYes);
            this.panelYesNo.Location = new System.Drawing.Point(74, 412);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(860, 52);
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
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // textBoxTenLoaiPhieuXuat
            // 
            this.textBoxTenLoaiPhieuXuat.Location = new System.Drawing.Point(526, 27);
            this.textBoxTenLoaiPhieuXuat.Name = "textBoxTenLoaiPhieuXuat";
            this.textBoxTenLoaiPhieuXuat.Size = new System.Drawing.Size(125, 20);
            this.textBoxTenLoaiPhieuXuat.TabIndex = 4;
            this.textBoxTenLoaiPhieuXuat.TextChanged += new System.EventHandler(this.textBoxTenLoaiPhieuXuat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại phiếu xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại phiếu xuất";
            // 
            // textBoxMaLoaiPhieuXuat
            // 
            this.textBoxMaLoaiPhieuXuat.Location = new System.Drawing.Point(258, 27);
            this.textBoxMaLoaiPhieuXuat.Name = "textBoxMaLoaiPhieuXuat";
            this.textBoxMaLoaiPhieuXuat.Size = new System.Drawing.Size(125, 20);
            this.textBoxMaLoaiPhieuXuat.TabIndex = 0;
            this.textBoxMaLoaiPhieuXuat.TextChanged += new System.EventHandler(this.textBoxMaLoaiPhieuXuat_TextChanged);
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
            this.panelTimKiem.Controls.Add(this.buttonThoat);
            this.panelTimKiem.Controls.Add(this.buttonXoa);
            this.panelTimKiem.Controls.Add(this.buttonCapNhat);
            this.panelTimKiem.Controls.Add(this.buttonThem);
            this.panelTimKiem.Controls.Add(this.buttonLamLai);
            this.panelTimKiem.Location = new System.Drawing.Point(74, 446);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(860, 52);
            this.panelTimKiem.TabIndex = 13;
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxTenLoaiPhieuXuat);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.textBoxMaLoaiPhieuXuat);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(71, 12);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 69);
            this.groupBoxTimKiem.TabIndex = 11;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // FormQuanLyLoaiPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.groupBoxDSLoaiPhieuXuat);
            this.Controls.Add(this.panelYesNo);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Name = "FormQuanLyLoaiPhieuXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý loại phiếu xuất";
            this.Load += new System.EventHandler(this.FormQuanLyLoaiPhieuXuat_Load);
            this.groupBoxDSLoaiPhieuXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoaiPhieuXuat)).EndInit();
            this.panelYesNo.ResumeLayout(false);
            this.panelTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDSLoaiPhieuXuat;
        private System.Windows.Forms.DataGridView dataGridViewLoaiPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaLoaiPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenLoaiPhieuXuat;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.TextBox textBoxTenLoaiPhieuXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaLoaiPhieuXuat;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonLamLai;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
    }
}