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
    public partial class FormNhapHang : Form
    {
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private DateTime NgayNhap;

        private static string CreatePhieuNhapId()
        {
            return "PN" + DateTime.Now.ToString("yyMMddhhmmss");
        }

     
        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Text = CreatePhieuNhapId();
            DateTime ngayNhan = DateTime.Now;
            NgayNhap = ngayNhan;
            txtNgayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");
            txtMaNhanVien.Text = ThongTin.NhanVienDTO.MaNhanVien;
            txtNhanVienNhanHang.Text = ThongTin.NhanVienDTO.TenNhanVien;
        }

        private void txtDonDatHang_KeyUp(object sender, KeyEventArgs e)
        {
            string id = txtDonDatHang.Text;
            DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(id);

            if (donHangDTO != null)
            {
                txtNgayDat.Text = donHangDTO.NgayLap.ToString("dd/MM/yyyy");
                txtSoTien.Text = donHangDTO.ThanhTien.ToString();
                List<ChiTietDonHangDTO> LchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(id);
            
                for (int i = 0; i < LchiTietDonHangDTO.Count; i++)
                {
                    ChiTietDonHangDTO chiTietDonHangDTO = LchiTietDonHangDTO[i];
                    SanPhamDTO sanPhamDTO = SanPhamBUS.SelectSanPhamById(chiTietDonHangDTO.MaSanPham.ToString());
                    dataGridView_NhapHang.Rows.Add((i + 1).ToString(), chiTietDonHangDTO.MaSanPham.ToString(), sanPhamDTO.TenSanPham.ToString(), chiTietDonHangDTO.SoLuong.ToString(), chiTietDonHangDTO.SLDaNhan.ToString(), "", "");
                }
            }
            else
            {
                txtNgayDat.Text = "";
                txtSoTien.Text = "";
                dataGridView_NhapHang.Rows.Clear();
            }



        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNgayDat.Text = null;
            txtSoTien.Text = null;
            txtDonDatHang.Text = null;
            dataGridView_NhapHang.Rows.Clear();
        }
    
        private void dataGridView_NhapHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                DataGridViewCell cell = dataGridView_NhapHang.CurrentCell;
                string chuoi = dataGridView_NhapHang.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
                int so = 0;
                if (int.TryParse(chuoi, out so))
                {

                    int SoLuong = int.Parse(dataGridView_NhapHang.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString());
                    if (SoLuong < so)
                    {
                        cell.Value = "";
                        MessageBox.Show("Khong hop le");
                        dataGridView_NhapHang.ClearSelection();
                        dataGridView_NhapHang.CurrentCell = cell;
                        dataGridView_NhapHang.CurrentCell.Selected = true;

                    }
                    else
                    {
                        int kq = SoLuong - so;
                        dataGridView_NhapHang.CurrentRow.Cells[e.ColumnIndex + 1].Value = kq.ToString();
                    }

                }
                else
                {
                    cell.Value = "";
                    MessageBox.Show("Khong hop le");
                    dataGridView_NhapHang.ClearSelection();
                    dataGridView_NhapHang.CurrentCell = cell;
                    dataGridView_NhapHang.CurrentCell.Selected = true;
                }
            }
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
        private void btnTimPhieuNhap_Click(object sender, EventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(FormQuanLyNhapHang));
            if (frm != null)
                frm.Activate();
            else
            {
                FormQuanLyNhapHang fQLNhapHang = new FormQuanLyNhapHang();
                fQLNhapHang.MdiParent = this.MdiParent;
                fQLNhapHang.Show();
            }
        }
        bool flag;
        private bool KiemTraTao()
        {
            PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
            string loi = "";
            flag = true;
            if (txtDonDatHang.Text == "")
            {
                loi = "Ma DOn Hang Khong dc de trong";
                flag = false;

            }
            else
            {
                string id = txtDonDatHang.Text;
                DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(id);

                if (donHangDTO != null)
                {
                    phieuNhapDTO.MaPhieuNhap = txtMaPhieuNhap.Text;
                    phieuNhapDTO.MaNhanVien = txtMaNhanVien.Text;
                    phieuNhapDTO.NgayNhan = NgayNhap;
                    phieuNhapDTO.MaDonHang = txtDonDatHang.Text;
                }
                else
                {
                    loi = "Ma Don Hang Khong Ton Tai";
                    flag = false;
                }
            }

            List<ChiTietPhieuNhapDTO> ListChiTietPhieuNhapDTO = new List<ChiTietPhieuNhapDTO>();
            if (flag == true)
            {

                for (int i = 0; i < dataGridView_NhapHang.RowCount; i++)
                {
                    ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                    chiTietPhieuNhapDTO.MaChiTietPhieuNhap = txtMaPhieuNhap.Text;
                    if (i > 100)
                    {
                        chiTietPhieuNhapDTO.MaChiTietPhieuNhap += (i + 1).ToString();

                    }
                    else if (i > 10)
                    {
                        chiTietPhieuNhapDTO.MaChiTietPhieuNhap += "0" + (i + 1).ToString();
                    }
                    else
                    {
                        chiTietPhieuNhapDTO.MaChiTietPhieuNhap += "00" + (i + 1).ToString();
                    }

                    chiTietPhieuNhapDTO.MaPhieuNhap = txtMaPhieuNhap.Text;
                    chiTietPhieuNhapDTO.MaSanPham = dataGridView_NhapHang.Rows[i].Cells["clMaSanPham"].Value.ToString();
                    if (dataGridView_NhapHang.Rows[i].Cells["clDaNhan"].Value.ToString() == "")
                    {
                        loi = "Khong Duoc De Trong So Luong Da Nhan";
                        flag = false;
                     
                    }
                    else
                    {
                        chiTietPhieuNhapDTO.SLNhan = int.Parse(dataGridView_NhapHang.Rows[i].Cells["clSLNhan"].Value.ToString());
                    }

                    chiTietPhieuNhapDTO.GhiChu = dataGridView_NhapHang.Rows[i].Cells["clGhiChu"].Value.ToString();
                    ListChiTietPhieuNhapDTO.Add(chiTietPhieuNhapDTO);


                }
            }


            if (flag == true)
            {
                if (PhieuNhapBUS.InsertPhieuNhap(phieuNhapDTO))
                {

                    foreach (ChiTietPhieuNhapDTO ct in ListChiTietPhieuNhapDTO)
                    {
                        //MessageBox.Show(ct.MaSanPham + ct.SoLuong.ToString());
                        ChiTietPhieuNhapBUS.InsertChiTietPhieuNhap(ct);
                    }
                    MessageBox.Show("Tạo Thành Công");

                }
                else
                {
                    MessageBox.Show("Tạo Không Thành Công");
                }
            }
            else
            {
                MessageBox.Show(loi);
            }
            return flag;

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn Lưu Đơn Nhập Hàng Không:", "Phiếu Nhập", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                flag = KiemTraTao();
                if (flag == true)
                {

                    txtMaPhieuNhap.Text = CreatePhieuNhapId();
                    DateTime ngayNhan = DateTime.Now;
                    NgayNhap = ngayNhan;
                    txtNgayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");
                    txtMaNhanVien.Text = ThongTin.NhanVienDTO.MaNhanVien;
                    txtNhanVienNhanHang.Text = ThongTin.NhanVienDTO.TenNhanVien;
                    txtNgayDat.Text = null;
                    txtSoTien.Text = null;
                    txtDonDatHang.Text = null;
                    dataGridView_NhapHang.Rows.Clear();
                }
                
            }
            else if (result == DialogResult.No)
            {

                txtMaPhieuNhap.Text = CreatePhieuNhapId();
                DateTime ngayNhan = DateTime.Now;
                txtNgayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");
                txtMaNhanVien.Text = ThongTin.NhanVienDTO.MaNhanVien;
                txtNhanVienNhanHang.Text = ThongTin.NhanVienDTO.TenNhanVien;
                txtNgayDat.Text = null;
                txtSoTien.Text = null;
                txtDonDatHang.Text = null;
                dataGridView_NhapHang.Rows.Clear();
            }

        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            KiemTraTao();
        }
        

    }
}
