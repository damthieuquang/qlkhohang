namespace DXApplication2
{
    partial class FormNhapHang
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGridView_NhapHang = new DevExpress.XtraGrid.GridControl();
            this.groupControl_ChiTietPhieuNhap = new DevExpress.XtraEditors.GroupControl();
            this.groupControl_NghiepVu = new DevExpress.XtraEditors.GroupControl();
            this.ThongTin_navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl_ThongTinPhieuDat = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhanVienNhanHang = new DevExpress.XtraEditors.TextEdit();
            this.txtTrangThai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayNhan = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPhieuNhap = new DevExpress.XtraEditors.TextEdit();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayDat = new DevExpress.XtraEditors.TextEdit();
            this.txtDonDatHang = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ChiTietPhieuNhap)).BeginInit();
            this.groupControl_ChiTietPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_NghiepVu)).BeginInit();
            this.groupControl_NghiepVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTin_navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThongTinPhieuDat)).BeginInit();
            this.groupControl_ThongTinPhieuDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVienNhanHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonDatHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dataGridView_NhapHang;
            this.gridView1.Name = "gridView1";
            // 
            // dataGridView_NhapHang
            // 
            this.dataGridView_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_NhapHang.Location = new System.Drawing.Point(2, 21);
            this.dataGridView_NhapHang.MainView = this.gridView1;
            this.dataGridView_NhapHang.Name = "dataGridView_NhapHang";
            this.dataGridView_NhapHang.Size = new System.Drawing.Size(783, 286);
            this.dataGridView_NhapHang.TabIndex = 0;
            this.dataGridView_NhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl_ChiTietPhieuNhap
            // 
            this.groupControl_ChiTietPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl_ChiTietPhieuNhap.Controls.Add(this.dataGridView_NhapHang);
            this.groupControl_ChiTietPhieuNhap.Location = new System.Drawing.Point(185, 239);
            this.groupControl_ChiTietPhieuNhap.Name = "groupControl_ChiTietPhieuNhap";
            this.groupControl_ChiTietPhieuNhap.Size = new System.Drawing.Size(787, 309);
            this.groupControl_ChiTietPhieuNhap.TabIndex = 6;
            this.groupControl_ChiTietPhieuNhap.Text = "Chi tiết phiếu nhập";
            // 
            // groupControl_NghiepVu
            // 
            this.groupControl_NghiepVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl_NghiepVu.Controls.Add(this.ThongTin_navBarControl);
            this.groupControl_NghiepVu.Location = new System.Drawing.Point(12, 12);
            this.groupControl_NghiepVu.Name = "groupControl_NghiepVu";
            this.groupControl_NghiepVu.Size = new System.Drawing.Size(166, 536);
            this.groupControl_NghiepVu.TabIndex = 4;
            this.groupControl_NghiepVu.Text = "Nghiệp vụ";
            // 
            // ThongTin_navBarControl
            // 
            this.ThongTin_navBarControl.ActiveGroup = this.navBarGroup1;
            this.ThongTin_navBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThongTin_navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.ThongTin_navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem9});
            this.ThongTin_navBarControl.Location = new System.Drawing.Point(5, 24);
            this.ThongTin_navBarControl.Name = "ThongTin_navBarControl";
            this.ThongTin_navBarControl.OptionsNavPane.ExpandedWidth = 140;
            this.ThongTin_navBarControl.Size = new System.Drawing.Size(140, 507);
            this.ThongTin_navBarControl.TabIndex = 0;
            this.ThongTin_navBarControl.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Chức năng";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup1.LargeImage = global::DXApplication2.Properties.Resources.piestylepie_32x32;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Tạo đơn hàng";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Tạo mới";
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Làm lại";
            this.navBarItem7.Name = "navBarItem7";
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Tìm kiếm";
            this.navBarItem9.Name = "navBarItem9";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Báo biểu";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.LargeImage = global::DXApplication2.Properties.Resources.edittask_32x32;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Đơn hàng";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = global::DXApplication2.Properties.Resources.newcontact_16x16;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Nhập hàng";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImage = global::DXApplication2.Properties.Resources.editcontact_16x16;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Xuất hàng";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImage = global::DXApplication2.Properties.Resources.redo_16x16;
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Sản phẩm mua nhiều";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImage = global::DXApplication2.Properties.Resources.editdatasource_16x16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(399, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Mã nhân viên";
            // 
            // groupControl_ThongTinPhieuDat
            // 
            this.groupControl_ThongTinPhieuDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.labelControl7);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.labelControl8);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.txtNhanVienNhanHang);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.txtTrangThai);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.labelControl4);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.labelControl5);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.labelControl6);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.labelControl3);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.labelControl2);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.labelControl1);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.txtMaNhanVien);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.txtNgayNhan);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.txtMaPhieuNhap);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.txtSoTien);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.txtNgayDat);
            this.groupControl_ThongTinPhieuDat.Controls.Add(this.txtDonDatHang);
            this.groupControl_ThongTinPhieuDat.Location = new System.Drawing.Point(185, 12);
            this.groupControl_ThongTinPhieuDat.Name = "groupControl_ThongTinPhieuDat";
            this.groupControl_ThongTinPhieuDat.Size = new System.Drawing.Size(787, 221);
            this.groupControl_ThongTinPhieuDat.TabIndex = 5;
            this.groupControl_ThongTinPhieuDat.Text = "Thông tin phiếu đặt";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(399, 171);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(113, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Tên nhân viên nhận";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(41, 171);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 16);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Trạng thái";
            // 
            // txtNhanVienNhanHang
            // 
            this.txtNhanVienNhanHang.Enabled = false;
            this.txtNhanVienNhanHang.Location = new System.Drawing.Point(515, 168);
            this.txtNhanVienNhanHang.Name = "txtNhanVienNhanHang";
            this.txtNhanVienNhanHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVienNhanHang.Properties.Appearance.Options.UseFont = true;
            this.txtNhanVienNhanHang.Size = new System.Drawing.Size(150, 22);
            this.txtNhanVienNhanHang.TabIndex = 13;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(170, 168);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Properties.Appearance.Options.UseFont = true;
            this.txtTrangThai.Size = new System.Drawing.Size(150, 22);
            this.txtTrangThai.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(399, 87);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Ngày nhận";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(399, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 16);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "Mã phiếu nhập";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(41, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Số tiền";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(41, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Ngày đặt";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(41, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Đơn đặt hàng";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(515, 128);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(150, 22);
            this.txtMaNhanVien.TabIndex = 5;
            // 
            // txtNgayNhan
            // 
            this.txtNgayNhan.Enabled = false;
            this.txtNgayNhan.Location = new System.Drawing.Point(515, 84);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayNhan.Properties.Appearance.Options.UseFont = true;
            this.txtNgayNhan.Size = new System.Drawing.Size(150, 22);
            this.txtNgayNhan.TabIndex = 4;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Enabled = false;
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(515, 34);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuNhap.Properties.Appearance.Options.UseFont = true;
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(150, 22);
            this.txtMaPhieuNhap.TabIndex = 3;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Enabled = false;
            this.txtSoTien.Location = new System.Drawing.Point(170, 128);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtSoTien.Size = new System.Drawing.Size(150, 22);
            this.txtSoTien.TabIndex = 2;
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Enabled = false;
            this.txtNgayDat.Location = new System.Drawing.Point(170, 84);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDat.Properties.Appearance.Options.UseFont = true;
            this.txtNgayDat.Size = new System.Drawing.Size(150, 22);
            this.txtNgayDat.TabIndex = 1;
            // 
            // txtDonDatHang
            // 
            this.txtDonDatHang.Location = new System.Drawing.Point(170, 37);
            this.txtDonDatHang.Name = "txtDonDatHang";
            this.txtDonDatHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonDatHang.Properties.Appearance.Options.UseFont = true;
            this.txtDonDatHang.Size = new System.Drawing.Size(150, 22);
            this.txtDonDatHang.TabIndex = 0;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Controls.Add(this.groupControl_ChiTietPhieuNhap);
            this.Controls.Add(this.groupControl_NghiepVu);
            this.Controls.Add(this.groupControl_ThongTinPhieuDat);
            this.Name = "FormNhapHang";
            this.Text = "Nhập hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ChiTietPhieuNhap)).EndInit();
            this.groupControl_ChiTietPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_NghiepVu)).EndInit();
            this.groupControl_NghiepVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThongTin_navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_ThongTinPhieuDat)).EndInit();
            this.groupControl_ThongTinPhieuDat.ResumeLayout(false);
            this.groupControl_ThongTinPhieuDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVienNhanHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonDatHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl dataGridView_NhapHang;
        private DevExpress.XtraEditors.GroupControl groupControl_ChiTietPhieuNhap;
        private DevExpress.XtraEditors.GroupControl groupControl_NghiepVu;
        private DevExpress.XtraNavBar.NavBarControl ThongTin_navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl_ThongTinPhieuDat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.TextEdit txtNgayNhan;
        private DevExpress.XtraEditors.TextEdit txtMaPhieuNhap;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private DevExpress.XtraEditors.TextEdit txtNgayDat;
        private DevExpress.XtraEditors.TextEdit txtDonDatHang;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNhanVienNhanHang;
        private DevExpress.XtraEditors.TextEdit txtTrangThai;
    }
}