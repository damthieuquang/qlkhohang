namespace GUI
{
    partial class FormChonSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ChoSanPham = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Xong = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTenSanPham = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChoSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_ChoSanPham);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // dataGridView_ChoSanPham
            // 
            this.dataGridView_ChoSanPham.AllowUserToAddRows = false;
            this.dataGridView_ChoSanPham.AllowUserToDeleteRows = false;
            this.dataGridView_ChoSanPham.AllowUserToResizeColumns = false;
            this.dataGridView_ChoSanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChoSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ChoSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChoSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clLoaiSanPham,
            this.clCheck});
            this.dataGridView_ChoSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ChoSanPham.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_ChoSanPham.Name = "dataGridView_ChoSanPham";
            this.dataGridView_ChoSanPham.RowHeadersVisible = false;
            this.dataGridView_ChoSanPham.Size = new System.Drawing.Size(455, 345);
            this.dataGridView_ChoSanPham.TabIndex = 0;
            // 
            // clSTT
            // 
            this.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            this.clSTT.Width = 30;
            // 
            // clMaSanPham
            // 
            this.clMaSanPham.HeaderText = "Mã sản phẩm";
            this.clMaSanPham.Name = "clMaSanPham";
            this.clMaSanPham.ReadOnly = true;
            this.clMaSanPham.Visible = false;
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.Name = "clTenSanPham";
            this.clTenSanPham.ReadOnly = true;
            // 
            // clLoaiSanPham
            // 
            this.clLoaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clLoaiSanPham.HeaderText = "Loại sản phẩm";
            this.clLoaiSanPham.Name = "clLoaiSanPham";
            this.clLoaiSanPham.ReadOnly = true;
            this.clLoaiSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clCheck
            // 
            this.clCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clCheck.HeaderText = "Chọn";
            this.clCheck.Name = "clCheck";
            this.clCheck.Width = 50;
            // 
            // btn_Xong
            // 
            this.btn_Xong.Location = new System.Drawing.Point(146, 454);
            this.btn_Xong.Name = "btn_Xong";
            this.btn_Xong.Size = new System.Drawing.Size(75, 23);
            this.btn_Xong.TabIndex = 1;
            this.btn_Xong.Text = "Xong";
            this.btn_Xong.UseVisualStyleBackColor = true;
            this.btn_Xong.Click += new System.EventHandler(this.btn_Xong_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(257, 454);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 2;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxLoaiSanPham);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxTenSanPham);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // comboBoxLoaiSanPham
            // 
            this.comboBoxLoaiSanPham.FormattingEnabled = true;
            this.comboBoxLoaiSanPham.Location = new System.Drawing.Point(320, 21);
            this.comboBoxLoaiSanPham.Name = "comboBoxLoaiSanPham";
            this.comboBoxLoaiSanPham.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoaiSanPham.TabIndex = 6;
            this.comboBoxLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoaiSanPham_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại sản phẩm";
            // 
            // textBoxTenSanPham
            // 
            this.textBoxTenSanPham.Location = new System.Drawing.Point(109, 21);
            this.textBoxTenSanPham.Name = "textBoxTenSanPham";
            this.textBoxTenSanPham.Size = new System.Drawing.Size(100, 20);
            this.textBoxTenSanPham.TabIndex = 4;
            this.textBoxTenSanPham.TextChanged += new System.EventHandler(this.textBoxTenSanPham_TextChanged);
            // 
            // FormChonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Xong);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChonSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn sản phẩm";
            this.Load += new System.EventHandler(this.FormChonSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChoSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_ChoSanPham;
        private System.Windows.Forms.Button btn_Xong;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLoaiSanPham;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxLoaiSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTenSanPham;
    }
}