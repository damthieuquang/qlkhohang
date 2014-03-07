namespace GUI
{
    partial class FormDangNhap
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(168, 145);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 11;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(40, 145);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(75, 23);
            this.buttonDangNhap.TabIndex = 10;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã nhân viên";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(120, 105);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.PasswordChar = 'x';
            this.textBoxMatKhau.Size = new System.Drawing.Size(142, 20);
            this.textBoxMatKhau.TabIndex = 7;
            this.textBoxMatKhau.Text = "123456";
            this.textBoxMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMatKhau_KeyDown);
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(120, 71);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(142, 20);
            this.textBoxMaNhanVien.TabIndex = 6;
            this.textBoxMaNhanVien.Text = "NV001";
            this.textBoxMaNhanVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMaNhanVien_KeyDown);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.textBoxMaNhanVien);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
    }
}