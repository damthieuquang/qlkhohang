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
        /********* Các Biến Sử Dung*********/
        private DateTime NgayNhap;
        bool flag;
        public int Status = 0;// Biến trạng thái của Form 0: Tạo, 1: Cập nhật
        public string MaPhieuNhap;//Biến Mã Phiếu Nhập Để Truyền Vào Quản Lý Nhập Hàng
        /********* Các Hàm Khai Báo Sử Dụng*********/
        private void KhoiTaoNutBanDau()//Khởi Tạo Nút Ban Đầu
        {
            btnCapNhap.Enabled = false;
            btnTao.Enabled = true;
            btnTaoMoi.Enabled = true;
            btnThoat.Enabled = true;
            btnTimPhieuNhap.Enabled = true;
            btnLamLai.Enabled = true;
        }
        private static string CreatePhieuNhapId()//Tạo Mã Phiếu Nhập
        {
            return "PN" + DateTime.Now.ToString("yyMMddhhmmss");
        }
        private void KhoiTaoBanDau()//Khởi Tạo Ban Đầu
        {
            txtMaPhieuNhap.Text = CreatePhieuNhapId();
            DateTime ngayNhan = DateTime.Now;
            NgayNhap = ngayNhan;
            txtNgayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");
            txtMaNhanVien.Text = ThongTin.NhanVienDTO.MaNhanVien;
            txtNhanVienNhanHang.Text = ThongTin.NhanVienDTO.TenNhanVien;
        }
        private void KhoiTaoNhapMaDonHang()//KHởi Tạo Dữ Liệu Datagidview Khi Gõ Vào Mã Đơn Hàng
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
                    if (int.Parse(chiTietDonHangDTO.SoLuong.ToString()) == int.Parse(chiTietDonHangDTO.SLDaNhan.ToString()))
                    {
                        dataGridView_NhapHang.Rows.Add((i + 1).ToString(), chiTietDonHangDTO.MaSanPham.ToString(), sanPhamDTO.TenSanPham.ToString(), chiTietDonHangDTO.SoLuong.ToString(), chiTietDonHangDTO.SLDaNhan.ToString(), "0", "");
                    }
                    else
                    {
                        dataGridView_NhapHang.Rows.Add((i + 1).ToString(), chiTietDonHangDTO.MaSanPham.ToString(), sanPhamDTO.TenSanPham.ToString(), chiTietDonHangDTO.SoLuong.ToString(), chiTietDonHangDTO.SLDaNhan.ToString(), "", "");
                    }
                }
            }
            else
            {
                txtNgayDat.Text = "";
                txtSoTien.Text = "";
                dataGridView_NhapHang.Rows.Clear();
            }
        }
        private void Load_Update()//Khởi Tạo Load Update
        {
            PhieuNhapDTO phieuNhapDTO = PhieuNhapBUS.SelectPhieuNhapById(MaPhieuNhap);
            txtMaPhieuNhap.Text = MaPhieuNhap;
            NgayNhap = phieuNhapDTO.NgayNhan;
            txtNgayNhan.Text = NgayNhap.ToString("dd/MM/yyyy");
            txtMaNhanVien.Text = phieuNhapDTO.MaNhanVien.ToString();
            NhanVienDTO nhanVienDTO = NhanVienBUS.SelectNhanVienById(phieuNhapDTO.MaNhanVien.ToString());
            txtNhanVienNhanHang.Text = nhanVienDTO.TenNhanVien.ToString();
            txtDonDatHang.ReadOnly = true;
            txtDonDatHang.Text = phieuNhapDTO.MaDonHang.ToString();
            KhoiTaoNhapMaDonHang();

        }
        private void KhoiTaoNutUpDate()//Khởi Tạo Nút Update
        {
            btnTao.Enabled = false;
            btnLamLai.Enabled = false;
            btnTaoMoi.Enabled = false;
            btnCapNhap.Enabled = true;
        }
        private void FormNhapHang_Load(object sender, EventArgs e)//Khời Tạo Giá Trị Khi Form Load Ban Dau
        {
            if (Status == 0)//Status = 0 Khởi Tạo
            {
                KhoiTaoBanDau();
            }
            else
            {
                Load_Update();
                KhoiTaoNutUpDate();
                MessageBox.Show(Status.ToString());
            }
        }
        private void txtDonDatHang_KeyUp(object sender, KeyEventArgs e)//Khởi Tạo Giá Trị Datagridview Khi Nhập Mã Đơn Hàng
        {
            KhoiTaoNhapMaDonHang();
        }
        private void btnThoat_Click(object sender, EventArgs e)//Nút Thoát Chương Trình
        {
            this.Close();
        }
        private void btnLamLai_Click(object sender, EventArgs e)//Nút Reset Form 
        {
            
                txtNgayDat.Text = null;
                txtSoTien.Text = null;
                txtDonDatHang.Text = null;
                dataGridView_NhapHang.Rows.Clear();
        
        }
        private Form KiemTraTonTai(Type formType)//Kiểm Tra Xem Form Có Tồn Tại Hay Không
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formType)
                    return f;
            }
            return null;
        }
        private void btnTimPhieuNhap_Click(object sender, EventArgs e)//Nút Chuyển Qua Form Quản Lý Nhập Hàng
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
        private void dataGridView_NhapHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)//Hàm Xử Lý Sự Kiện Khi Nhập Số Lượng Xong
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewCell cell = dataGridView_NhapHang.CurrentCell;
                string chuoi = dataGridView_NhapHang.CurrentRow.Cells[e.ColumnIndex].Value.ToString();
                int so = 0;
                if (int.TryParse(chuoi, out so))//Kiểm Tra Xem Có Phải Là Số 0
                {
                    int SoLuong = int.Parse(dataGridView_NhapHang.CurrentRow.Cells[e.ColumnIndex - 2].Value.ToString());
                    int DaNhan = int.Parse(dataGridView_NhapHang.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString());
                    int temp= int.Parse(dataGridView_NhapHang.CurrentRow.Cells[5].Value.ToString());
                    if (temp < 0)
                    {
                        cell.Value = "";
                        MessageBox.Show("Không Được Nhập Số Âm");
                        dataGridView_NhapHang.ClearSelection();
                        dataGridView_NhapHang.CurrentCell = cell;
                        dataGridView_NhapHang.CurrentCell.Selected = true;
                    }
                    else if (SoLuong == DaNhan)
                    {
                        MessageBox.Show("Số Lượng Đã Nhận Đủ");
                        cell.Value = 0;
                   
                    }
                    else if (SoLuong < temp)
                    {
                        MessageBox.Show("Không Hợp Lệ");
                        cell.Value = 0;
                    }
                }
                else
                {
                    cell.Value = "";
                    MessageBox.Show("Không Hợp Lệ");
                    dataGridView_NhapHang.ClearSelection();
                    dataGridView_NhapHang.CurrentCell = cell;
                    dataGridView_NhapHang.CurrentCell.Selected = true;
                }
            }
        }
        private bool KiemTraTaoInsert()//Kiểm Tra Tạo Dữ Liệu Có Hợp Lệ Hay Không
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
                    if (dataGridView_NhapHang.Rows[i].Cells["clSLNhan"].Value.ToString() == "")
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
                        ChiTietPhieuNhapBUS.InsertChiTietPhieuNhap(ct);
                    }
                    //Up date chi tiet don hang
                    string id = txtDonDatHang.Text;
                    List<ChiTietDonHangDTO> listchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(id);//lay tren database
                    foreach (ChiTietDonHangDTO ctdh in listchiTietDonHangDTO)
                    {
                        ctdh.SLDaNhan = 0;
                    }
                    List<PhieuNhapDTO> listPhieuNhapSVN = PhieuNhapBUS.SelectPhieuNhapByMaDonHang(id);
                    ChiTietPhieuNhapDTO itemChiTietPhieuNhap = new ChiTietPhieuNhapDTO();
                    foreach (PhieuNhapDTO itemPhieuNhap in listPhieuNhapSVN)
                    {
                        List<ChiTietPhieuNhapDTO> listChiTietPhieuNhap = ChiTietPhieuNhapBUS.SelectChiTietPhieuNhapByMaPhieuNhap(itemPhieuNhap.MaPhieuNhap);
                        for (int i = 0; i < listChiTietPhieuNhap.Count; i++)
                        {
                            listchiTietDonHangDTO[i].SLDaNhan += listChiTietPhieuNhap[i].SLNhan;
                        }
                    }
                    foreach (ChiTietDonHangDTO ctdh in listchiTietDonHangDTO)
                    {
                        ChiTietDonHangBUS.UpdateChiTietDonHangById(ctdh);
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
        private bool KiemTraUpDate()//Kiểm Tra Update Dữ Liệu Có Hợp Lệ Hay Không
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
                    if (dataGridView_NhapHang.Rows[i].Cells["clSLNhan"].Value.ToString() == "")
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
                if (PhieuNhapBUS.UpdatePhieuNhapById(phieuNhapDTO))
                {
                    foreach (ChiTietPhieuNhapDTO ct in ListChiTietPhieuNhapDTO)
                    {
                        ChiTietPhieuNhapBUS.UpdateChiTietPhieuNhapById(ct);
                    }
                    //Up date chi tiet don hang
                    string id = txtDonDatHang.Text;
                    List<ChiTietDonHangDTO> listchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(id);//lay tren database
                    foreach (ChiTietDonHangDTO ctdh in listchiTietDonHangDTO)
                    {
                        ctdh.SLDaNhan = 0;
                    }
                    List<PhieuNhapDTO> listPhieuNhapSVN = PhieuNhapBUS.SelectPhieuNhapByMaDonHang(id);
                    ChiTietPhieuNhapDTO itemChiTietPhieuNhap = new ChiTietPhieuNhapDTO();
                    foreach (PhieuNhapDTO itemPhieuNhap in listPhieuNhapSVN)
                    {
                        List<ChiTietPhieuNhapDTO> listChiTietPhieuNhap = ChiTietPhieuNhapBUS.SelectChiTietPhieuNhapByMaPhieuNhap(itemPhieuNhap.MaPhieuNhap);
                        for (int i = 0; i < listChiTietPhieuNhap.Count; i++)
                        {
                            listchiTietDonHangDTO[i].SLDaNhan += listChiTietPhieuNhap[i].SLNhan;
                        }
                    }
                    foreach (ChiTietDonHangDTO ctdh in listchiTietDonHangDTO)
                    {
                        ChiTietDonHangBUS.UpdateChiTietDonHangById(ctdh);
                    }
                    MessageBox.Show("Cập Nhập Thành Công");

                }
                else
                {
                    MessageBox.Show("Cập Nhập Thất Bại");
                }
            }
            else
            {
                MessageBox.Show(loi);
            }
            return flag;
        }
        private void btnTao_Click(object sender, EventArgs e)//Nút Tạo
        {
            if (KiemTraTaoInsert())
            {
                btnCapNhap.Enabled = true;
                btnLamLai.Enabled = false;
                btnTao.Enabled = false;
                txtDonDatHang.ReadOnly = true;
                Status = 1;
            }
  
        }
        private void btnCapNhap_Click(object sender, EventArgs e)//Nút Cập Nhập
        {
            KiemTraUpDate();
            Status = 1;

        }
        private void btnTaoMoi_Click(object sender, EventArgs e)// Xử Lý Nút Tạo Mới
        {
                DialogResult result = MessageBox.Show("Bạn Muốn Lưu Đơn Nhập Hàng Không", "Phiếu Nhập", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    if (Status == 0)
                    {
                        flag = KiemTraTaoInsert();
                        if (flag == true)
                        {
                            KhoiTaoBanDau();
                            txtNgayDat.Text = "";
                            txtSoTien.Text = "";
                            txtDonDatHang.Text = "";
                            dataGridView_NhapHang.Rows.Clear();
                        }
                    }
                    else
                    {
                        KiemTraUpDate();
                        KhoiTaoBanDau();
                        KhoiTaoNutBanDau();
                        txtNgayDat.Text = "";
                        txtSoTien.Text = "";
                        txtDonDatHang.Text = "";
                        txtDonDatHang.ReadOnly = false;
                        dataGridView_NhapHang.Rows.Clear();
                    }
                }
                else if (result == DialogResult.No)
                {
                    KhoiTaoBanDau();
                    txtNgayDat.Text = "";
                    txtSoTien.Text = "";
                    txtDonDatHang.Text = "";
                    dataGridView_NhapHang.Rows.Clear();
                }
        }

    }
}
