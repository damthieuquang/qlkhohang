namespace GUI
{
    partial class FormQuanLyThamSo
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
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.textBoxGiaTri = new System.Windows.Forms.TextBox();
            this.textBoxTenThamSo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaThamSo = new System.Windows.Forms.TextBox();
            this.groupBoxDSThamSo = new System.Windows.Forms.GroupBox();
            this.dataGridViewThamSo = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaThamSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenThamSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonLamLai = new System.Windows.Forms.Button();
            this.panelYesNo = new System.Windows.Forms.Panel();
            this.buttonNo = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.groupBoxTimKiem.SuspendLayout();
            this.groupBoxDSThamSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThamSo)).BeginInit();
            this.panelTimKiem.SuspendLayout();
            this.panelYesNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Controls.Add(this.textBoxGiaTri);
            this.groupBoxTimKiem.Controls.Add(this.textBoxTenThamSo);
            this.groupBoxTimKiem.Controls.Add(this.label3);
            this.groupBoxTimKiem.Controls.Add(this.label2);
            this.groupBoxTimKiem.Controls.Add(this.label1);
            this.groupBoxTimKiem.Controls.Add(this.textBoxMaThamSo);
            this.groupBoxTimKiem.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(860, 69);
            this.groupBoxTimKiem.TabIndex = 0;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Tìm kiếm";
            // 
            // textBoxGiaTri
            // 
            this.textBoxGiaTri.Location = new System.Drawing.Point(612, 27);
            this.textBoxGiaTri.Name = "textBoxGiaTri";
            this.textBoxGiaTri.Size = new System.Drawing.Size(125, 20);
            this.textBoxGiaTri.TabIndex = 5;
            this.textBoxGiaTri.TextChanged += new System.EventHandler(this.textBoxGiaTri_TextChanged);
            // 
            // textBoxTenThamSo
            // 
            this.textBoxTenThamSo.Location = new System.Drawing.Point(396, 27);
            this.textBoxTenThamSo.Name = "textBoxTenThamSo";
            this.textBoxTenThamSo.Size = new System.Drawing.Size(125, 20);
            this.textBoxTenThamSo.TabIndex = 4;
            this.textBoxTenThamSo.TextChanged += new System.EventHandler(this.textBoxTenThamSo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá trị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tham số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tham số";
            // 
            // textBoxMaThamSo
            // 
            this.textBoxMaThamSo.Location = new System.Drawing.Point(156, 27);
            this.textBoxMaThamSo.Name = "textBoxMaThamSo";
            this.textBoxMaThamSo.Size = new System.Drawing.Size(125, 20);
            this.textBoxMaThamSo.TabIndex = 0;
            this.textBoxMaThamSo.TextChanged += new System.EventHandler(this.textBoxMaThamSo_TextChanged);
            // 
            // groupBoxDSThamSo
            // 
            this.groupBoxDSThamSo.Controls.Add(this.dataGridViewThamSo);
            this.groupBoxDSThamSo.Location = new System.Drawing.Point(12, 107);
            this.groupBoxDSThamSo.Name = "groupBoxDSThamSo";
            this.groupBoxDSThamSo.Size = new System.Drawing.Size(860, 284);
            this.groupBoxDSThamSo.TabIndex = 1;
            this.groupBoxDSThamSo.TabStop = false;
            this.groupBoxDSThamSo.Text = "Danh sách tham số";
            // 
            // dataGridViewThamSo
            // 
            this.dataGridViewThamSo.AllowUserToAddRows = false;
            this.dataGridViewThamSo.AllowUserToDeleteRows = false;
            this.dataGridViewThamSo.AllowUserToResizeColumns = false;
            this.dataGridViewThamSo.AllowUserToResizeRows = false;
            this.dataGridViewThamSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewThamSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewThamSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThamSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaThamSo,
            this.ColTenThamSo,
            this.ColGiaTri});
            this.dataGridViewThamSo.Location = new System.Drawing.Point(13, 26);
            this.dataGridViewThamSo.Name = "dataGridViewThamSo";
            this.dataGridViewThamSo.RowHeadersVisible = false;
            this.dataGridViewThamSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThamSo.Size = new System.Drawing.Size(835, 243);
            this.dataGridViewThamSo.TabIndex = 0;
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
            // ColMaThamSo
            // 
            this.ColMaThamSo.HeaderText = "Mã tham số";
            this.ColMaThamSo.Name = "ColMaThamSo";
            this.ColMaThamSo.ReadOnly = true;
            this.ColMaThamSo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColTenThamSo
            // 
            this.ColTenThamSo.HeaderText = "Tên tham số";
            this.ColTenThamSo.Name = "ColTenThamSo";
            this.ColTenThamSo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColGiaTri
            // 
            this.ColGiaTri.HeaderText = "Giá trị";
            this.ColGiaTri.Name = "ColGiaTri";
            this.ColGiaTri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.Controls.Add(this.buttonThoat);
            this.panelTimKiem.Controls.Add(this.buttonXoa);
            this.panelTimKiem.Controls.Add(this.buttonCapNhat);
            this.panelTimKiem.Controls.Add(this.buttonThem);
            this.panelTimKiem.Controls.Add(this.buttonLamLai);
            this.panelTimKiem.Location = new System.Drawing.Point(12, 400);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(860, 52);
            this.panelTimKiem.TabIndex = 2;
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
            // panelYesNo
            // 
            this.panelYesNo.Controls.Add(this.buttonNo);
            this.panelYesNo.Controls.Add(this.buttonYes);
            this.panelYesNo.Location = new System.Drawing.Point(0, 333);
            this.panelYesNo.Name = "panelYesNo";
            this.panelYesNo.Size = new System.Drawing.Size(860, 52);
            this.panelYesNo.TabIndex = 6;
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
            // FormQuanLyThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelYesNo);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.groupBoxDSThamSo);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Name = "FormQuanLyThamSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyThamSo";
            this.Load += new System.EventHandler(this.FormQuanLyThamSo_Load);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            this.groupBoxDSThamSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThamSo)).EndInit();
            this.panelTimKiem.ResumeLayout(false);
            this.panelYesNo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.GroupBox groupBoxDSThamSo;
        private System.Windows.Forms.TextBox textBoxGiaTri;
        private System.Windows.Forms.TextBox textBoxTenThamSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaThamSo;
        private System.Windows.Forms.DataGridView dataGridViewThamSo;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonLamLai;
        private System.Windows.Forms.Panel panelYesNo;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaThamSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenThamSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiaTri;
    }
}