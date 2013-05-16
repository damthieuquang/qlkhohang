namespace GUI
{
    partial class TraCuuThanhVien
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
            this.txtMaThanhVien = new System.Windows.Forms.TextBox();
            this.txtTenThanhVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridView_TraCuuThanhVien = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TraCuuThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaThanhVien
            // 
            this.txtMaThanhVien.Location = new System.Drawing.Point(252, 43);
            this.txtMaThanhVien.Name = "txtMaThanhVien";
            this.txtMaThanhVien.Size = new System.Drawing.Size(154, 20);
            this.txtMaThanhVien.TabIndex = 24;
            // 
            // txtTenThanhVien
            // 
            this.txtTenThanhVien.Location = new System.Drawing.Point(252, 81);
            this.txtTenThanhVien.Name = "txtTenThanhVien";
            this.txtTenThanhVien.Size = new System.Drawing.Size(154, 20);
            this.txtTenThanhVien.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên thành viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã thành viên";
            // 
            // GridView_TraCuuThanhVien
            // 
            this.GridView_TraCuuThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_TraCuuThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaThanhVien,
            this.clTenThanhVien,
            this.clCV,
            this.clTongNo});
            this.GridView_TraCuuThanhVien.Location = new System.Drawing.Point(36, 142);
            this.GridView_TraCuuThanhVien.Name = "GridView_TraCuuThanhVien";
            this.GridView_TraCuuThanhVien.Size = new System.Drawing.Size(543, 150);
            this.GridView_TraCuuThanhVien.TabIndex = 25;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            this.clSTT.ReadOnly = true;
            // 
            // clMaThanhVien
            // 
            this.clMaThanhVien.HeaderText = "Mã thành viên";
            this.clMaThanhVien.Name = "clMaThanhVien";
            this.clMaThanhVien.ReadOnly = true;
            // 
            // clTenThanhVien
            // 
            this.clTenThanhVien.HeaderText = "Tên thành viên";
            this.clTenThanhVien.Name = "clTenThanhVien";
            this.clTenThanhVien.ReadOnly = true;
            // 
            // clCV
            // 
            this.clCV.HeaderText = "CV";
            this.clCV.Name = "clCV";
            this.clCV.ReadOnly = true;
            // 
            // clTongNo
            // 
            this.clTongNo.HeaderText = "Tổng nợ";
            this.clTongNo.Name = "clTongNo";
            this.clTongNo.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(472, 331);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(367, 331);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(75, 23);
            this.btnXuatFile.TabIndex = 30;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(264, 331);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 29;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(159, 331);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemChiTiet.TabIndex = 28;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(57, 331);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 27;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // TraCuuThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 392);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.GridView_TraCuuThanhVien);
            this.Controls.Add(this.txtMaThanhVien);
            this.Controls.Add(this.txtTenThanhVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "TraCuuThanhVien";
            this.Text = "TraCuuThanhVien";
            ((System.ComponentModel.ISupportInitialize)(this.GridView_TraCuuThanhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaThanhVien;
        private System.Windows.Forms.TextBox txtTenThanhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridView_TraCuuThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongNo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnTraCuu;
    }
}