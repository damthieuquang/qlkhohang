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
        public int Status = 0;// Biến trạng thái của Form 0: Tạo, 1:Xem,  2:Cap nhat 3:Xem Dialog , 4: cap nhat tu quan ly
        public bool taoMoi = false;//tao moi tu quan ly
        public string MaPhieuNhap;//Biến Mã Phiếu Nhập Để Truyền Vào Quản Lý Nhập Hàng

        /********* Các Hàm Khai Báo Sử Dụng*********/

        private  string CreatePhieuNhapId()//Tạo Mã Phiếu Nhập
        {
            NgayNhap = DateTime.Now;
            return "PN" + NgayNhap.ToString("yyMMddhhmmss");
        }

        private void KhoiTaoBanDau()//Khởi Tạo Ban Đầu
        {
            txtMaPhieuNhap.Text = CreatePhieuNhapId();
            txtNgayNhan.Text = NgayNhap.ToString("dd/MM/yyyy");
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
                txtTrangThai.Text = donHangDTO.TrangThai;

                if (Status == 0)
                {
                    List<ChiTietDonHangDTO> LchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(id);
                    for (int i = 0; i < LchiTietDonHangDTO.Count; i++)
                    {
                        ChiTietDonHangDTO chiTietDonHangDTO = LchiTietDonHangDTO[i];
                        SanPhamDTO sanPhamDTO = SanPhamBUS.SelectSanPhamById(chiTietDonHangDTO.MaSanPham.ToString());

                        dataGridView_NhapHang.Rows.Add((i + 1).ToString(),
                                                        chiTietDonHangDTO.MaSanPham.ToString(),
                                                        sanPhamDTO.TenSanPham.ToString(),
                                                        chiTietDonHangDTO.SoLuong.ToString(),
                                                        chiTietDonHangDTO.SLDaNhan.ToString(), "0", "");

                    }
                    dataGridView_NhapHang.CurrentCell = dataGridView_NhapHang.Rows[0].Cells[clSLNhan.Index];
                    dataGridView_NhapHang.CurrentCell.Selected = true;
                    dataGridView_NhapHang.BeginEdit(true);
                    btnTao.Enabled = true;
                }
                else
                {
                    List<ChiTietDonHangDTO> LchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(id);
                    List<ChiTietPhieuNhapDTO> listChiTietPhieuNhap = ChiTietPhieuNhapBUS.SelectChiTietPhieuNhapByMaPhieuNhap(txtMaPhieuNhap.Text);
                    for (int i = 0; i < LchiTietDonHangDTO.Count; i++)
                    {
                        ChiTietDonHangDTO chiTietDonHangDTO = LchiTietDonHangDTO[i];
                        SanPhamDTO sanPhamDTO = SanPhamBUS.SelectSanPhamById(chiTietDonHangDTO.MaSanPham.ToString());
                        LchiTietDonHangDTO[i].SLDaNhan = LchiTietDonHangDTO[i].SLDaNhan - listChiTietPhieuNhap[i].SLNhan;

                        dataGridView_NhapHang.Rows.Add((i + 1).ToString(),
                                                        chiTietDonHangDTO.MaSanPham.ToString(),
                                                        sanPhamDTO.TenSanPham.ToString(),
                                                        chiTietDonHangDTO.SoLuong.ToString(),
                                                        chiTietDonHangDTO.SLDaNhan.ToString(), listChiTietPhieuNhap[i].SLNhan.ToString(),
                                                        listChiTietPhieuNhap[i].GhiChu.ToString());

                    }
                   
                        dataGridView_NhapHang.ReadOnly = true;
                        dataGridView_NhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        btnCapNhap.Visible = true;
                        btnTao.Visible = true;
                        btnLamLai.Visible = false;
                        btnTaoMoi.Visible = false;
                        btnTimPhieuNhap.Visible = false;

                    if (Status == 4)
                    {
                        //Chuyen sang trang thai cap nhat
                        panelChucNang.Visible = false;
                        panelYesNo.Visible = true;
                        dataGridView_NhapHang.ReadOnly = false;
                        dataGridView_NhapHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        dataGridView_NhapHang.CurrentCell = dataGridView_NhapHang.Rows[0].Cells[clSLNhan.Index];
                        dataGridView_NhapHang.CurrentCell.Selected = true;
                        dataGridView_NhapHang.BeginEdit(true);
                        MaPhieuNhap = txtMaPhieuNhap.Text;
                    }
                }
               
            }
            else
            {
                txtNgayDat.Text = "";
                txtSoTien.Text = "";
                txtTrangThai.Text = "";
                btnTao.Enabled = false;
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
            txtNhanVienNhanHang.Text = NhanVienBUS.SelectNhanVienById(phieuNhapDTO.MaNhanVien).TenNhanVien;
            txtDonDatHang.ReadOnly = true;
            txtDonDatHang.Text = phieuNhapDTO.MaDonHang.ToString();
        }
        private void KhoiTaoNutUpDate()//Khởi Tạo Nút Update
        {
            btnTao.Enabled = false;
            btnLamLai.Enabled = false;
            btnTaoMoi.Enabled = false;
            btnCapNhap.Enabled = true;
        }


        //Kiem tra du lieu dau vao: -1 neu hop le, nguoc lai tra ve vi tri du lieu sai
        private int KiemTraDuLieu()
        {
            bool f = false;
            int slConLai = 0;
            for(int i   = 0; i< dataGridView_NhapHang.RowCount; i++)
            {
                if (dataGridView_NhapHang.Rows[i].Cells[clSLNhan.Index].Value == null)
                {
                    MessageBox.Show("Số lượng nhận sản phẩm thứ " + (i + 1).ToString() + "(" + dataGridView_NhapHang.Rows[i].Cells[clTenSanPham.Index].Value.ToString() + ") không được để trống");
                    return i;
                }
               
                slConLai = int.Parse(dataGridView_NhapHang.Rows[i].Cells[clSoLuong.Index].Value.ToString()) - int.Parse(dataGridView_NhapHang.Rows[i].Cells[clDaNhan.Index].Value.ToString());
                if (int.Parse(dataGridView_NhapHang.Rows[i].Cells[clSLNhan.Index].Value.ToString()) > slConLai)
                {
                    MessageBox.Show("Số lượng nhận sản phẩm thứ " + (i + 1).ToString() + "(" + dataGridView_NhapHang.Rows[i].Cells[clTenSanPham.Index].Value.ToString() + ")  lớn hơn số lượng có thể nhận là " + slConLai.ToString());
                    return i;
                }

                if (int.Parse(dataGridView_NhapHang.Rows[i].Cells[clSLNhan.Index].Value.ToString()) > 0)
                {
                    f = true;
                }

            }

            if (f == false)
            {
                MessageBox.Show("Phiếu nhập không hợp lệ, tất cả số lượng sản phẩm đều bằng 0", "Nhập hàng");
                return 0;
            }
            return -1;
        }

        private bool InsertPhieuNhap()
        {
            bool res = true;
            if (DonHangBUS.SelectDonHangById(txtDonDatHang.Text).TrangThai != "Đã nhận")
            { 
                int vt = KiemTraDuLieu();
                if (vt == -1)//du lieu hop le
                {
                    //Lay du lieu
                    PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                    phieuNhapDTO.MaPhieuNhap = txtMaPhieuNhap.Text;
                    phieuNhapDTO.MaNhanVien = txtMaNhanVien.Text;
                    phieuNhapDTO.NgayNhan = NgayNhap;
                    phieuNhapDTO.MaDonHang = txtDonDatHang.Text;

                    List<ChiTietPhieuNhapDTO> listChiTietPhieuNhapDTO = new List<ChiTietPhieuNhapDTO>();
                    int tongCV = 0;
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
                        chiTietPhieuNhapDTO.MaSanPham = dataGridView_NhapHang.Rows[i].Cells[clMaSanPham.Index].Value.ToString();
                        chiTietPhieuNhapDTO.SLNhan = int.Parse(dataGridView_NhapHang.Rows[i].Cells[clSLNhan.Index].Value.ToString());
                        tongCV += SanPhamBUS.SelectSanPhamById(chiTietPhieuNhapDTO.MaSanPham).CV * chiTietPhieuNhapDTO.SLNhan;
                        chiTietPhieuNhapDTO.GhiChu = dataGridView_NhapHang.Rows[i].Cells[clGhiChu.Index].Value.ToString();
                        listChiTietPhieuNhapDTO.Add(chiTietPhieuNhapDTO);
                    }

                    //Insert phieu nhap
                    if (PhieuNhapBUS.InsertPhieuNhap(phieuNhapDTO))
                    {
                        //Insert chi tiet phieu nhap
                        foreach (ChiTietPhieuNhapDTO ct in listChiTietPhieuNhapDTO)
                        {
                            ChiTietPhieuNhapBUS.InsertChiTietPhieuNhap(ct);
                        }

                        //Up date  so luong da nhan trong bang chi tiet don hang
                        string id = txtDonDatHang.Text;
                        List<ChiTietDonHangDTO> listchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(id);
                        bool f = true;
                        for (int i = 0; i < listchiTietDonHangDTO.Count; i++)
                        {
                            listchiTietDonHangDTO[i].SLDaNhan += listChiTietPhieuNhapDTO[i].SLNhan;
                            ChiTietDonHangBUS.UpdateChiTietDonHangById(listchiTietDonHangDTO[i]);
                            if (listchiTietDonHangDTO[i].SLDaNhan != listchiTietDonHangDTO[i].SoLuong)
                            {
                                f = false;
                            }
                        }

                        //update tong cv
                        ThamSoDTO thamsoDTO = ThamSoBUS.SelectThamSoById("TS004");
                        thamsoDTO.GiaTri = (int.Parse(thamsoDTO.GiaTri) + tongCV).ToString();
                        ThamSoBUS.UpdateThamSoById(thamsoDTO);


                        //update trang thai don hang
                        DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(id);
                        if (f)//Da nhan (tat ca SlDaNhan == SoLuong)
                        {
                            donHangDTO.TrangThai = "Đã nhận";
                        }
                        else//Nhan mot phan (con it nhat mot san pham chua nhan het)
                        {
                            donHangDTO.TrangThai = "Nhận một phần";
                        }
                        DonHangBUS.UpdateDonHangById(donHangDTO);


                        //Update so luong ton trong bang san pham
                        SanPhamDTO sanPhamDTO = new SanPhamDTO();
                        for (int i = 0; i < listChiTietPhieuNhapDTO.Count; i++)
                        {
                            sanPhamDTO = SanPhamBUS.SelectSanPhamById(listChiTietPhieuNhapDTO[i].MaSanPham);
                            sanPhamDTO.SoLuongTon += listChiTietPhieuNhapDTO[i].SLNhan;
                            SanPhamBUS.UpdateSanPhamById(sanPhamDTO);
                        }

                       


                        MessageBox.Show("Tạo Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Tạo Không Thành Công");
                        res = false;
                    }
                }
                else //du lieu ko hop le o vi tri vt
                {
                    dataGridView_NhapHang.CurrentCell = dataGridView_NhapHang.Rows[vt].Cells[clSLNhan.Index];
                    dataGridView_NhapHang.CurrentCell.Selected = true;
                    dataGridView_NhapHang.BeginEdit(true);
                    res = false;
                }
            }
            else // don hang da nhan
            {
                MessageBox.Show("Đon hàng " + txtDonDatHang.Text + " đã nhận xong, không thể tạo phiếu nhập");
                btnTao.Enabled = false;
                res = false;
            }
            return res;
          
        }

        private bool UpdatePhieuNhap()
        {
            int vt = KiemTraDuLieu();
            if (vt == -1)//du lieu hop le
            {
                List<ChiTietPhieuNhapDTO> listChiTietPhieuNhapDTO = ChiTietPhieuNhapBUS.SelectChiTietPhieuNhapByMaPhieuNhap(MaPhieuNhap);

                //Up date  so luong da nhan trong bang chi tiet don hang va so luong ton, chi tiet phieu nhap 
                string id = txtDonDatHang.Text;
                List<ChiTietDonHangDTO> listchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(id);
                SanPhamDTO sanPhamDTO = new SanPhamDTO();
                bool f = true;
                int SLNhan = 0;
                int tongCVTruoc = 0;
                int tongCVSau = 0;
                for (int i = 0; i < listchiTietDonHangDTO.Count; i++)
                {
                    //chi tiet don hang
                    SLNhan = int.Parse(dataGridView_NhapHang.Rows[i].Cells[clSLNhan.Index].Value.ToString());
                    listchiTietDonHangDTO[i].SLDaNhan = listchiTietDonHangDTO[i].SLDaNhan - listChiTietPhieuNhapDTO[i].SLNhan + SLNhan;
                    tongCVTruoc += listChiTietPhieuNhapDTO[i].SLNhan * SanPhamBUS.SelectSanPhamById(listChiTietPhieuNhapDTO[i].MaSanPham).CV;
                    tongCVSau += SLNhan * SanPhamBUS.SelectSanPhamById(listChiTietPhieuNhapDTO[i].MaSanPham).CV;
                    ChiTietDonHangBUS.UpdateChiTietDonHangById(listchiTietDonHangDTO[i]);
                    if (listchiTietDonHangDTO[i].SLDaNhan != listchiTietDonHangDTO[i].SoLuong)
                    {
                        f = false;
                    }

                    //so luong ton
                    sanPhamDTO = SanPhamBUS.SelectSanPhamById(listChiTietPhieuNhapDTO[i].MaSanPham);
                    sanPhamDTO.SoLuongTon = sanPhamDTO.SoLuongTon - listChiTietPhieuNhapDTO[i].SLNhan + SLNhan;
                    SanPhamBUS.UpdateSanPhamById(sanPhamDTO);

                    //Update chi tiet phieu nhap
                    listChiTietPhieuNhapDTO[i].SLNhan = SLNhan;
                    listChiTietPhieuNhapDTO[i].GhiChu = dataGridView_NhapHang.Rows[i].Cells[clGhiChu.Index].Value.ToString();
                    ChiTietPhieuNhapBUS.UpdateChiTietPhieuNhapById(listChiTietPhieuNhapDTO[i]);
                }

                //update tong cv
                ThamSoDTO thamSoDTO = ThamSoBUS.SelectThamSoById("TS004");
                thamSoDTO.GiaTri = (int.Parse(thamSoDTO.GiaTri) - tongCVTruoc + tongCVSau).ToString();
                ThamSoBUS.UpdateThamSoById(thamSoDTO);

                //update trang thai don hang
                DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(id);
                if (f)//Da nhan (tat ca SlDaNhan == SoLuong)
                {
                    donHangDTO.TrangThai = "Đã nhận";
                }
                else//Nhan mot phan (con it nhat mot san pham chua nhan het)
                {
                    donHangDTO.TrangThai = "Nhận một phần";
                }
                DonHangBUS.UpdateDonHangById(donHangDTO);

                MessageBox.Show("Cập nhật thành công");

                return true;

            }
            else //du lieu ko hop le o vi tri vt
            {
                dataGridView_NhapHang.CurrentCell = dataGridView_NhapHang.Rows[vt].Cells[clSLNhan.Index];
                dataGridView_NhapHang.CurrentCell.Selected = true;
                dataGridView_NhapHang.BeginEdit(true);
                return false;
            }
        }

        private void TaoMoiPhieuNhap()
        {
            KhoiTaoBanDau();
            txtNgayDat.Text = "";
            txtSoTien.Text = "";
            txtDonDatHang.Text = "";
            txtTrangThai.Text = "";
            txtDonDatHang.ReadOnly = false;
            dataGridView_NhapHang.Rows.Clear();
            btnCapNhap.Visible = false;
            btnLamLai.Enabled = true;
            btnTao.Visible = true;
            btnTao.Enabled = false;
            
            panelChucNang.Visible = true;
            panelYesNo.Visible = false;
            btnTimPhieuNhap.Visible = true;
            btnLamLai.Visible = true;
            dataGridView_NhapHang.ReadOnly = false;
            dataGridView_NhapHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            Status = 0;
        }

        private void txtDonDatHang_TextChanged(object sender, EventArgs e)
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
            txtTrangThai.Text = null;
            dataGridView_NhapHang.Rows.Clear();

        }
      
        private void btnTimPhieuNhap_Click(object sender, EventArgs e)//Nút Chuyển Qua Form Quản Lý Nhập Hàng
        {
            Form frm = ThongTin.KiemTraTonTai(typeof(FormQuanLyNhapHang), this.ParentForm);
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormQuanLyNhapHang fQLDonHang = new FormQuanLyNhapHang();
                fQLDonHang.MdiParent = this.ParentForm;
                fQLDonHang.Show();
            }
        }

        private void btnTao_Click(object sender, EventArgs e)//Nút Tạo
        {
            if (Status == 0)//Tao
            {
                if (InsertPhieuNhap())
                {
                    //Câp nhat tran thai button
                    btnTao.Visible = false;
                    btnCapNhap.Visible = true;
                    btnLamLai.Enabled = false;
                    txtDonDatHang.ReadOnly = true;
                    dataGridView_NhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView_NhapHang.ReadOnly = true;
                    Status = 1;
                }
            }

        }


        private void btnCapNhap_Click(object sender, EventArgs e)//Nút Cập Nhập
        {
            //Chuyen sang trang thai cap nhat
            panelChucNang.Visible = false;
            panelYesNo.Visible = true;
            dataGridView_NhapHang.ReadOnly = false;
            dataGridView_NhapHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_NhapHang.CurrentCell = dataGridView_NhapHang.Rows[0].Cells[clSLNhan.Index];
            dataGridView_NhapHang.CurrentCell.Selected = true;
            dataGridView_NhapHang.BeginEdit(true);
            MaPhieuNhap = txtMaPhieuNhap.Text;
            Status = 2;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)// Xử Lý Nút Tạo Mới
        {
            taoMoi = false;
            if (Status == 0)
            {
                if (btnTao.Enabled == true)
                {
                    DialogResult result = MessageBox.Show("Bạn Muốn Lưu Phiếu Nhập Không", "Phiếu Nhập", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        if (InsertPhieuNhap())
                        {
                            TaoMoiPhieuNhap();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        TaoMoiPhieuNhap();
                    }
                }
                else
                {
                    TaoMoiPhieuNhap();
                }
            }
            else if (Status == 2)
            {
                DialogResult result = MessageBox.Show("Bạn Muốn Lưu Phiếu Nhập Không", "Phiếu Nhập", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    if (UpdatePhieuNhap())
                    {
                        TaoMoiPhieuNhap();
                    }
                }
                else if (result == DialogResult.No)
                {
                    TaoMoiPhieuNhap();
                }
            }
            else if (Status == 1)//Xem
            {
                TaoMoiPhieuNhap();
            }
        }

        private void dataGridView_NhapHang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView_NhapHang.CurrentCellAddress.X == dataGridView_NhapHang.Columns[clSLNhan.Index].DisplayIndex)
            {
                TextBox txt = e.Control as TextBox;
                txt.Name = clSLNhan.HeaderText;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
                }
            }
            else
            {
                TextBox txt = e.Control as TextBox;
                txt.Name = clGhiChu.HeaderText;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kiem tra 
            TextBox txt = sender as TextBox;
            if (txt.Name == clSLNhan.HeaderText)
            {
                //Là các ký tự số hoặc điều khiển
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (Status == 4)
            {
                this.Dispose();
            }
            else
            {
                //Chuyen sang trang thai xem
                panelChucNang.Visible = true;
                panelYesNo.Visible = false;
                dataGridView_NhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_NhapHang.ReadOnly = true;
                Status = 1;

                //Phuc hoi du lieu cu
                List<ChiTietPhieuNhapDTO> listChiTietPhieuNhap = ChiTietPhieuNhapBUS.SelectChiTietPhieuNhapByMaPhieuNhap(MaPhieuNhap);
                for (int i = 0; i < listChiTietPhieuNhap.Count; i++)
                {
                    dataGridView_NhapHang.Rows[i].Cells[clSLNhan.Index].Value = listChiTietPhieuNhap[i].SLNhan.ToString();
                    dataGridView_NhapHang.Rows[i].Cells[clGhiChu.Index].Value = listChiTietPhieuNhap[i].GhiChu.ToString();
                }
            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (UpdatePhieuNhap())
            {
                //Chuyen sang trang thai xem
                panelChucNang.Visible = true;
                panelYesNo.Visible = false;
                dataGridView_NhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_NhapHang.ReadOnly = true;
                Status = 1;
            }
        }

        private void FormNhapHang_Activated(object sender, EventArgs e)
        {
            btnCapNhap.Location = new Point(16, 13);
            panelYesNo.Location = new Point(22, 403);
            panelYesNo.Parent = this;
            if (taoMoi)
            {
                btnTaoMoi_Click(sender, e);
            }
            else if (Status == 0)//Status = 0 Khởi Tạo
            {
                KhoiTaoBanDau();
            }
            else if (Status == 3 || Status == 4)//Xem hoac Cap Nhat
            {
                Load_Update();
            }
        }
    }
}
