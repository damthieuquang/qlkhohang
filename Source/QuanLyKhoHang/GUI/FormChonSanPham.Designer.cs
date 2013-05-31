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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_ChoSanPham = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Xong = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChoSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_ChoSanPham);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 378);
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
            this.dataGridView_ChoSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChoSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaSanPham,
            this.clTenSanPham,
            this.clCheck});
            this.dataGridView_ChoSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ChoSanPham.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_ChoSanPham.Name = "dataGridView_ChoSanPham";
            this.dataGridView_ChoSanPham.RowHeadersVisible = false;
            this.dataGridView_ChoSanPham.Size = new System.Drawing.Size(353, 359);
            this.dataGridView_ChoSanPham.TabIndex = 0;
            this.dataGridView_ChoSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ChoSanPham_CellContentClick);
            // 
            // clSTT
            // 
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
            // clCheck
            // 
            this.clCheck.HeaderText = "Chọn";
            this.clCheck.Name = "clCheck";
            this.clCheck.Width = 50;
            // 
            // btn_Xong
            // 
            this.btn_Xong.Location = new System.Drawing.Point(398, 29);
            this.btn_Xong.Name = "btn_Xong";
            this.btn_Xong.Size = new System.Drawing.Size(75, 23);
            this.btn_Xong.TabIndex = 1;
            this.btn_Xong.Text = "Xong";
            this.btn_Xong.UseVisualStyleBackColor = true;
            this.btn_Xong.Click += new System.EventHandler(this.btn_Xong_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(398, 69);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 2;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // FormChonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 466);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Xong);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChonSanPham";
            this.Text = "Chọn sản phẩm";
            this.Load += new System.EventHandler(this.FormChonSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChoSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_ChoSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheck;
        private System.Windows.Forms.Button btn_Xong;
        private System.Windows.Forms.Button btn_Huy;
    }
}