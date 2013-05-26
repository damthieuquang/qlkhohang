using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormManHinhChinh : Form
    {
        public FormManHinhChinh()
        {
            InitializeComponent();
        }

        private Form KiemTraTonTai(Type formType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }

        private void FormManHinhChinh_Load(object sender, EventArgs e)
        {
            FormDangNhap fDangNhap = new FormDangNhap();
            fDangNhap.ShowDialog();
        }

        private void donHangToolStripMenuItemTaoDonHang_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormDonHang));
            if (frm != null)
                frm.Activate();
            else
            {
                FormDonHang fDonHang = new FormDonHang();
                fDonHang.MdiParent = this;
                fDonHang.Show();
            }
        }

        private void donHangToolStripMenuItemQLDonHang_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyDonHang));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyDonHang fQLDonHang = new FormQuanLyDonHang();
                fQLDonHang.MdiParent = this;
                fQLDonHang.Show();
            }
        }

        private void nhapHangToolStripMenuItemNhapHang_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormNhapHang));
            if (frm != null)
                frm.Activate();
            else
            {
                FormNhapHang fNhapHang = new FormNhapHang();
                fNhapHang.MdiParent = this;
                fNhapHang.Show();
            }
        }

        private void nhapHangToolStripMenuItemQLNhapHang_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyNhapHang));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyNhapHang fQLNhapHang = new FormQuanLyNhapHang();
                fQLNhapHang.MdiParent = this;
                fQLNhapHang.Show();
            }
        }

        private void xuatHangToolStripMenuItemXuatHang_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormXuatHang));
            if (frm != null)
                frm.Activate();
            else
            {
                FormXuatHang fXuatHang = new FormXuatHang();
                fXuatHang.MdiParent = this;
                fXuatHang.Show();
            }
        }

        private void xuatHangToolStripMenuItemQLXuatHang_Click(object sender, EventArgs e)
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

        private void xuatHangToolStripMenuItemQLLoaiPhieuXuat_Click(object sender, EventArgs e)
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

        private void sanPhamToolStripMenuItemQLSanPham_Click(object sender, EventArgs e)
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

        private void sanPhamToolStripMenuItemQLLaoiSanPham_Click(object sender, EventArgs e)
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

        private void thanhVienToolStripMenuItemQLThanhVien_Click(object sender, EventArgs e)
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

        private void nhanVienToolStripMenuItemQLNhanVien_Click(object sender, EventArgs e)
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

        private void heThongToolStripMenuItemQLThamSo_Click(object sender, EventArgs e)
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

        private void heThongToolStripMenuItemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
