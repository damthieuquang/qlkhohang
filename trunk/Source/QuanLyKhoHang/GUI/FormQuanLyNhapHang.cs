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
    public partial class FormQuanLyNhapHang : Form
    {
        public FormQuanLyNhapHang()
        {
            InitializeComponent();
        }
        private bool boolNgayDatTu = false;
        private bool boolNgayDatDen = false;
        private bool boolNgayNhanTu = false;
        private bool boolNgayNhanDen = false;

        private void enableButton()
        {
            btnXemChiTiet.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void disableButton()
        {
            btnXemChiTiet.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }


        private void KhoiTao()
        {
            int stt = 1;
            List<PhieuNhapDTO> listPhieuNhapDTO = PhieuNhapBUS.SelectPhieuNhapAll();
            if (listPhieuNhapDTO != null)
            {
                dataGridView_TraCuuNhapHang.Rows.Clear();
                PhieuNhapDTO item = new PhieuNhapDTO();

                for (int i = 0; i < listPhieuNhapDTO.Count; i++)
                {
                    item = listPhieuNhapDTO[i];
                    dataGridView_TraCuuNhapHang.Rows.Add(
                           (stt++).ToString(),
                           item.MaPhieuNhap,
                           DonHangBUS.SelectDonHangById(item.MaDonHang).MaDonHang,
                          DonHangBUS.SelectDonHangById(item.MaDonHang).NgayLap.ToString("dd/MM/yyy"),
                          item.NgayNhan.ToString("dd/MM/yyy"),
                           NhanVienBUS.SelectNhanVienById(item.MaNhanVien).TenNhanVien);
                }
                //Data
                enableButton();
            }
            else
            {
                disableButton();
            }

        }

        private void Search()
        {
            DateTime dateNgayDatTu = new DateTime();
            DateTime dateNgayDatDen = new DateTime();
            DateTime dateNgayDatHienTai = new DateTime();

            DateTime dateNgayNhanTu = new DateTime();
            DateTime dateNgayNhanDen = new DateTime();
            DateTime dateNgayNhanHienTai = new DateTime();

            if (boolNgayDatTu)
                dateNgayDatTu = dateTimePickerNgayDatTu.Value.Date;
            else
                dateNgayDatTu = new DateTime(1, 1, 1).Date;


            if (boolNgayDatDen)
                dateNgayDatDen = dateTimePickerNgayDatDen.Value.Date;
            else
                dateNgayDatDen = DateTime.Now.Date;

            if (boolNgayNhanTu)
                dateNgayNhanTu = dateTimePickerNgayDatTu.Value.Date;
            else
                dateNgayNhanTu = new DateTime(1, 1, 1).Date;


            if (boolNgayNhanDen)
                dateNgayNhanDen = dateTimePickerNgayNhanDen.Value.Date;
            else
                dateNgayNhanDen = DateTime.Now.Date;



            int stt = 0;
            int vt = -1;
            for (int i = 0; i < dataGridView_TraCuuNhapHang.RowCount; i++)
            {
                string[] chuoiNgayDat = dataGridView_TraCuuNhapHang.Rows[i].Cells[clNgayDat.Index].Value.ToString().Split('/');
                dateNgayDatHienTai = new DateTime(int.Parse(chuoiNgayDat[2]), int.Parse(chuoiNgayDat[1]), int.Parse(chuoiNgayDat[0])).Date;

                string[] chuoiNgayNhan = dataGridView_TraCuuNhapHang.Rows[i].Cells[clNgayNhan.Index].Value.ToString().Split('/');
                dateNgayNhanHienTai = new DateTime(int.Parse(chuoiNgayNhan[2]), int.Parse(chuoiNgayNhan[1]), int.Parse(chuoiNgayNhan[0])).Date;
                dataGridView_TraCuuNhapHang.Rows[i].Visible = false;
                if (dataGridView_TraCuuNhapHang.Rows[i].Cells[clMaPhieuNhap.Index].Value.ToString().ToUpper().IndexOf(txtMaPhieuNhap.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuNhapHang.Rows[i].Cells[clMaDonHang.Index].Value.ToString().ToUpper().IndexOf(txtMaDonHang.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuNhapHang.Rows[i].Cells[clNguoiNhan.Index].Value.ToString().ToUpper().IndexOf(txtNguoiNhan.Text.ToString().ToUpper()) >= 0
                    && dateNgayDatTu.CompareTo(dateNgayDatHienTai) <= 0 && dateNgayDatDen.CompareTo(dateNgayDatHienTai) >= 0
                    && dateNgayDatTu.CompareTo(dateNgayDatDen) <= 0
                    && dateNgayNhanTu.CompareTo(dateNgayNhanHienTai) <= 0 && dateNgayNhanDen.CompareTo(dateNgayNhanHienTai) >= 0
                    && dateNgayNhanTu.CompareTo(dateNgayNhanDen) <= 0
                   )
                {
                    stt++;
                    dataGridView_TraCuuNhapHang.Rows[i].Visible = true;
                    dataGridView_TraCuuNhapHang.Rows[i].Cells["clSTT"].Value = stt.ToString();
                    vt = i;
                    break;
                }
            }

            for (int i = vt + 1; i < dataGridView_TraCuuNhapHang.RowCount; i++)
            {
                string[] chuoiNgayDat = dataGridView_TraCuuNhapHang.Rows[i].Cells[clNgayDat.Index].Value.ToString().Split('/');
                dateNgayDatHienTai = new DateTime(int.Parse(chuoiNgayDat[2]), int.Parse(chuoiNgayDat[1]), int.Parse(chuoiNgayDat[0])).Date;

                string[] chuoiNgayNhan = dataGridView_TraCuuNhapHang.Rows[i].Cells[clNgayNhan.Index].Value.ToString().Split('/');
                dateNgayNhanHienTai = new DateTime(int.Parse(chuoiNgayNhan[2]), int.Parse(chuoiNgayNhan[1]), int.Parse(chuoiNgayNhan[0])).Date;

                dataGridView_TraCuuNhapHang.Rows[i].Visible = false;
                if (dataGridView_TraCuuNhapHang.Rows[i].Cells[clMaPhieuNhap.Index].Value.ToString().ToUpper().IndexOf(txtMaPhieuNhap.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuNhapHang.Rows[i].Cells[clMaDonHang.Index].Value.ToString().ToUpper().IndexOf(txtMaDonHang.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuNhapHang.Rows[i].Cells[clNguoiNhan.Index].Value.ToString().ToUpper().IndexOf(txtNguoiNhan.Text.ToString().ToUpper()) >= 0
                    && dateNgayDatTu.CompareTo(dateNgayDatHienTai) <= 0 && dateNgayDatDen.CompareTo(dateNgayDatHienTai) >= 0
                    && dateNgayDatTu.CompareTo(dateNgayDatDen) <= 0
                    && dateNgayNhanTu.CompareTo(dateNgayNhanHienTai) <= 0 && dateNgayNhanDen.CompareTo(dateNgayNhanHienTai) >= 0
                    && dateNgayNhanTu.CompareTo(dateNgayNhanDen) <= 0
                   )
                {
                    stt++;
                    dataGridView_TraCuuNhapHang.Rows[i].Visible = true;
                    dataGridView_TraCuuNhapHang.Rows[i].Cells["clSTT"].Value = stt.ToString();
                }
            }

            if (vt == -1)
            {
                disableButton();
            }
            else
            {
                enableButton();
                dataGridView_TraCuuNhapHang.CurrentCell = dataGridView_TraCuuNhapHang.Rows[vt].Cells[0];
                dataGridView_TraCuuNhapHang.CurrentCell.Selected = true;
            }
        }


        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtMaDonHang_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtNguoiNhan_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dateTimePickerNgayDatTu_ValueChanged(object sender, EventArgs e)
        {
            boolNgayDatTu = true;
            Search();
        }

        private void dateTimePickerNgayDatDen_ValueChanged(object sender, EventArgs e)
        {
            boolNgayDatDen = true;
            Search();
        }

        private void dateTimePickerNgayNhanTu_ValueChanged(object sender, EventArgs e)
        {
            boolNgayNhanTu = true;
            Search();
        }

        private void dateTimePickerNgayNhanDen_ValueChanged(object sender, EventArgs e)
        {
            boolNgayNhanDen = true;
            Search();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            dateTimePickerNgayDatTu.Value = DateTime.Now;
            boolNgayDatTu = false;
            dateTimePickerNgayDatDen.Value = DateTime.Now;
            boolNgayDatDen = false;
            dateTimePickerNgayNhanTu.Value = DateTime.Now;
            boolNgayNhanTu = false;
            dateTimePickerNgayNhanDen.Value = DateTime.Now;
            boolNgayNhanDen = false;
            txtMaPhieuNhap.Text = null;
            txtMaDonHang.Text = null;
            txtNguoiNhan.Text = null;

            if (dataGridView_TraCuuNhapHang.RowCount > 0)
            {
                dataGridView_TraCuuNhapHang.CurrentCell = dataGridView_TraCuuNhapHang.Rows[0].Cells[0];
                dataGridView_TraCuuNhapHang.CurrentCell.Selected = true;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FormNhapHang fQLNhapHang = new FormNhapHang();
            fQLNhapHang.MaPhieuNhap = dataGridView_TraCuuNhapHang.CurrentRow.Cells[clMaPhieuNhap.Index].Value.ToString();
            fQLNhapHang.Status = 3;//Xem Dialog
            fQLNhapHang.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xóa đơn Nhập Hàng", "Nhập Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                string id = dataGridView_TraCuuNhapHang.CurrentRow.Cells["clMaPhieuNhap"].Value.ToString();
                List<ChiTietPhieuNhapDTO> listChiTietPhieuNhapDTO = ChiTietPhieuNhapBUS.SelectChiTietPhieuNhapByMaPhieuNhap(id);
                bool xoa = true;
                for (int i = 0; i < listChiTietPhieuNhapDTO.Count; i++)
                {
                    if (SanPhamBUS.SelectSanPhamById(listChiTietPhieuNhapDTO[i].MaSanPham).SoLuongTon < listChiTietPhieuNhapDTO[i].SLNhan)
                    {
                        xoa = false;
                    }
                }
                if (xoa)
                {
                    int Index = dataGridView_TraCuuNhapHang.CurrentRow.Index;
                    int stt = int.Parse(dataGridView_TraCuuNhapHang.CurrentRow.Cells[clSTT.Index].Value.ToString());
                    string maDonHang = PhieuNhapBUS.SelectPhieuNhapById(id).MaDonHang;
                    if (PhieuNhapBUS.DeletePhieuNhapByID(id))
                    {
                        dataGridView_TraCuuNhapHang.Rows.RemoveAt(Index);
                        if (dataGridView_TraCuuNhapHang.RowCount > 0)
                        {
                            bool f = false;
                            for (int i = 0; i < Index; i++)
                            {
                                if (dataGridView_TraCuuNhapHang.Rows[i].Visible == true)
                                {
                                    f = true;
                                    break;
                                }
                            }


                            for (int i = Index; i < dataGridView_TraCuuNhapHang.RowCount; i++)
                            {
                                if (dataGridView_TraCuuNhapHang.Rows[i].Visible == true)
                                {
                                    dataGridView_TraCuuNhapHang.Rows[i].Cells["clSTT"].Value = stt.ToString();
                                    stt++;
                                    f = true;
                                }
                            }

                            if (f == false)
                            {
                                disableButton();
                            }
                            else
                            {
                                enableButton();
                            }
                        }
                        else
                        {
                            disableButton();
                        }

                        //Update

                        //Up date  so luong da nhan trong bang chi tiet don hang va so luong ton
                        List<ChiTietDonHangDTO> listchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(maDonHang);
                        SanPhamDTO sanPhamDTO = new SanPhamDTO();
                        bool falg = true;
                        int tongCV = 0;
                        for (int i = 0; i < listchiTietDonHangDTO.Count; i++)
                        {
                            //chi tiet don hang
                            listchiTietDonHangDTO[i].SLDaNhan = listchiTietDonHangDTO[i].SLDaNhan - listChiTietPhieuNhapDTO[i].SLNhan;
                            tongCV += listChiTietPhieuNhapDTO[i].SLNhan * SanPhamBUS.SelectSanPhamById(listChiTietPhieuNhapDTO[i].MaSanPham).CV;
                            ChiTietDonHangBUS.UpdateChiTietDonHangById(listchiTietDonHangDTO[i]);
                            if (listchiTietDonHangDTO[i].SLDaNhan != listchiTietDonHangDTO[i].SoLuong)
                            {
                                falg = false;
                            }

                            //so luong ton
                            sanPhamDTO = SanPhamBUS.SelectSanPhamById(listChiTietPhieuNhapDTO[i].MaSanPham);
                            sanPhamDTO.SoLuongTon = sanPhamDTO.SoLuongTon - listChiTietPhieuNhapDTO[i].SLNhan;
                            SanPhamBUS.UpdateSanPhamById(sanPhamDTO);
                        }

                        //update trang thai don hang
                        DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(maDonHang);
                        if (falg)//Da nhan (tat ca SlDaNhan == SoLuong)
                        {
                            donHangDTO.TrangThai = "Đã nhận";
                        }
                        else//Nhan mot phan (con it nhat mot san pham chua nhan het)
                        {
                            donHangDTO.TrangThai = "Nhận một phần";
                        }
                        DonHangBUS.UpdateDonHangById(donHangDTO);

                        //update tong cv
                        ThamSoDTO thamSoDTO = ThamSoBUS.SelectThamSoById("TS004");
                        thamSoDTO.GiaTri = (int.Parse(thamSoDTO.GiaTri) - tongCV).ToString();
                        ThamSoBUS.UpdateThamSoById(thamSoDTO);

                        MessageBox.Show("Xóa thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã bán, không cho phép xóa phiếu nhập " + id);
                }

            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            FormNhapHang fQLNhapHang = new FormNhapHang();
            fQLNhapHang.MaPhieuNhap = dataGridView_TraCuuNhapHang.CurrentRow.Cells["clMaPhieuNhap"].Value.ToString();
            fQLNhapHang.Status = 4;
            fQLNhapHang.ShowDialog();
        }

        private void FormQuanLyNhapHang_Activated(object sender, EventArgs e)
        {
            KhoiTao();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            FormNhapHang frm = (FormNhapHang)ThongTin.KiemTraTonTai(typeof(FormNhapHang), this.ParentForm);
            if (frm != null)
            {
                frm.taoMoi = true;
                frm.Activate();
            }
            else
            {
                FormNhapHang fNhapHang = new FormNhapHang();
                fNhapHang.taoMoi = true;
                fNhapHang.MdiParent = this.ParentForm;
                fNhapHang.Show();
            }
        }

    }
}
