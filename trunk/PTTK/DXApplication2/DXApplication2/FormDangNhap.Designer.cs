namespace DXApplication2
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
            this.textBoxMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.textBoxMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.buttonDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.buttonThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(211, 65);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(144, 20);
            this.textBoxMaNhanVien.TabIndex = 0;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.EditValue = "";
            this.textBoxMatKhau.Location = new System.Drawing.Point(211, 131);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(144, 20);
            this.textBoxMatKhau.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(103, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(103, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.Appearance.Options.UseFont = true;
            this.buttonDangNhap.Location = new System.Drawing.Point(124, 194);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(75, 23);
            this.buttonDangNhap.TabIndex = 4;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Appearance.Options.UseFont = true;
            this.buttonThoat.Location = new System.Drawing.Point(258, 194);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            this.buttonThoat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonThoat_KeyDown);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(462, 260);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.textBoxMaNhanVien);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDangNhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textBoxMaNhanVien;
        private DevExpress.XtraEditors.TextEdit textBoxMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton buttonDangNhap;
        private DevExpress.XtraEditors.SimpleButton buttonThoat;

    }
}