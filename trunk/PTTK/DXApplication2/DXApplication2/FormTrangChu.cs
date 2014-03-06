using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class FormTrangChu : DevExpress.XtraEditors.XtraForm
    {
        public FormTrangChu()
        {
            InitializeComponent();                        
        }

        //Kiem tra cua so da duoc bat hay chua
        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }
        public static DataTable GetData()
        {
            DataTable tb = new DataTable();

            string ConnectionString = @"Data Source=THIEUQUANG\SQLEXPRESS;Initial Catalog=QLKhoHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string sql = "select * from nhanvien";

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(tb);

            con.Close();
            return tb;
        }        

        private void DonHang_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonControl1.Pages[1];            
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            //FormDangNhap fDangNhap = new FormDangNhap();
            //fDangNhap.ShowDialog();
            //if (ThongTin.NhanVienDTO.LoaiNhanVien == 1)
            //{
            //    donHangToolStripMenuItem.Enabled = false;
            //    xuatHangToolStripMenuItemQLLoaiPhieuXuat.Enabled = false;
            //    sanPhamToolStripMenuItem.Enabled = false;
            //    thanhVienToolStripMenuItem.Enabled = false;
            //    nhanVienToolStripMenuItem.Enabled = false;
            //    heThongToolStripMenuItemQLThamSo.Visible = false;
            //    heThongToolStripMenuItemSLDuLieu.Visible = false;
            //    heThongToolStripMenuItemPHDuLieu.Visible = false;
            //    heThongToolStripMenuItemCauHinhThietBi.Visible = false;
            //    heThongToolStripMenuItemCauHinhPhanMem.Visible = false;
            //    heThongToolStripMenuItemQLDuLieuXoa.Visible = false;
            //}
            //ribbonControl1.SelectedPage = ribbonControl1.Pages[3];
            
        }

        private void NhapHang_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonControl1.Pages[2];
        }

        private void XuatHang_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonControl1.Pages[3];
        }

        private void SanPham_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonControl1.Pages[4];
        }

        private void ThanhVien_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonControl1.Pages[5];
        }

        private void NhanVien_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = ribbonControl1.Pages[6];
        }

        private void DonHangMoi_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormDonHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormDonHang fDonHang = new FormDonHang();
                fDonHang.MdiParent = this;
                fDonHang.Show();
            }
        }

        private void QuanLyDonHang_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyDonHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormQuanLyDonHang fQuanLyDonHang = new FormQuanLyDonHang();
                fQuanLyDonHang.MdiParent = this;
                fQuanLyDonHang.Show();
            }
        }

        private void NhapHangMoi_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormNhapHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormNhapHang fNhapHang = new FormNhapHang();
                fNhapHang.MdiParent = this;
                fNhapHang.Show();
            }
        }

        private void QuanLyNhapHang_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyNhapHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormQuanLyNhapHang fQuanLyNhapHang = new FormQuanLyNhapHang();
                fQuanLyNhapHang.MdiParent = this;
                fQuanLyNhapHang.Show();
            }
        }

        private void XuatHangMoi_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormXuatHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormXuatHang fXuatHang = new FormXuatHang();
                fXuatHang.MdiParent = this;
                fXuatHang.Show();
            }
        }

        private void PhieuXuat_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyXuatHang));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyXuatHang fQLXuatHang = new FormQuanLyXuatHang();
                fQLXuatHang.MdiParent = this;
                fQLXuatHang.Show();
            }
        }

        private void LoaiPhieuXuat_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyLoaiPhieuXuat));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyLoaiPhieuXuat fQLLoaiPhieuXuat = new FormQuanLyLoaiPhieuXuat();
                fQLLoaiPhieuXuat.MdiParent = this;
                fQLLoaiPhieuXuat.Show();
            }
        }

        private void SanPhamMoi_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLySanPham));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLySanPham fQLSanPham = new FormQuanLySanPham();
                fQLSanPham.MdiParent = this;
                fQLSanPham.Show();
            }
        }

        private void LoaiSanPham_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyLoaiSanPham));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyLoaiSanPham fQLLoaiSanPham = new FormQuanLyLoaiSanPham();
                fQLLoaiSanPham.MdiParent = this;
                fQLLoaiSanPham.Show();
            }
        }

        private void ThanhVienMoi_barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyThanhVien));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyThanhVien fQLThanhVien = new FormQuanLyThanhVien();
                fQLThanhVien.MdiParent = this;
                fQLThanhVien.Show();
            }
        }

        private void NhanVienMoi_barButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyNhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyNhanVien fQLNhanVien = new FormQuanLyNhanVien();
                fQLNhanVien.MdiParent = this;
                fQLNhanVien.Show();
            }
        }

        private void barButtonItem_ThamSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyThamSo));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyThamSo fQLThamSo = new FormQuanLyThamSo();
                fQLThamSo.MdiParent = this;
                fQLThamSo.Show();
            }
        }
    }
}
