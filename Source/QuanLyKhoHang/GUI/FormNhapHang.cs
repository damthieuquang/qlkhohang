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
                        //MessageBox.Show(ct.MaSanPham + ct.SoLuong.ToString());
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
                        MessageBox.Show(ctdh.SLDaNhan.ToString());
                    }


                    /*
                    string id = txtDonDatHang.Text;


                    List<ChiTietDonHangDTO> LchiTietDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(id);
                    List<ChiTietDonHangDTO> listChiTiet = new List<ChiTietDonHangDTO>();
                    int j = 0;
                    for (int i = 0; i < dataGridView_NhapHang.RowCount; i++)
                    {
                        if (j < LchiTietDonHangDTO.Count)
                        {
                            ChiTietDonHangDTO chiTietDonHangDTO = LchiTietDonHangDTO[j];
                            ChiTietDonHangDTO ctdh1 = new ChiTietDonHangDTO();
                            ctdh1.MaChiTietDonHang = chiTietDonHangDTO.MaChiTietDonHang;
                            ctdh1.MaDonHang = chiTietDonHangDTO.MaDonHang;
                            ctdh1.MaSanPham = chiTietDonHangDTO.MaSanPham;
                            ctdh1.CV = chiTietDonHangDTO.CV;
                            ctdh1.SLDaNhan =  int.Parse(dataGridView_NhapHang.Rows[i].Cells["clSLNhan"].Value.ToString()) + int.Parse(dataGridView_NhapHang.Rows[i].Cells["clDaNhan"].Value.ToString());
                            ctdh1.SoLuong = chiTietDonHangDTO.SoLuong;
                            ctdh1.ThanhTien = chiTietDonHangDTO.ThanhTien;
                            listChiTiet.Add(ctdh1);

                        }
                        j++;
                    }
                     * 
                     * 

                    foreach (ChiTietDonHangDTO ctdh in listChiTiet)
                    {
                        ChiTietDonHangBUS.UpdateChiTietDonHangById(ctdh);
                        MessageBox.Show(ctdh.SLDaNhan.ToString());
                    }
                     */
                    MessageBox.Show("Tạo Thành Công");
                   /* txtMaPhieuNhap.Text = CreatePhieuNhapId();
                    DateTime ngayNhan = DateTime.Now;
                    NgayNhap = ngayNhan;
                    txtNgayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");
                    txtMaNhanVien.Text = ThongTin.NhanVienDTO.MaNhanVien;
                    txtNhanVienNhanHang.Text = ThongTin.NhanVienDTO.TenNhanVien;
                    txtNgayDat.Text = null;
                    txtSoTien.Text = null;
                    txtDonDatHang.Text = null;
                    dataGridView_NhapHang.Rows.Clear();*/
                    btnTao.Visible = false;
                    btnCapNhap.Enabled = true;
                    txtDonDatHang.ReadOnly = true;

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
                if (btnCapNhap.Visible == false)
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
                        txtDonDatHang.ReadOnly = false;
                    }
                    btnTao.Visible = true;
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

                btnTao.Visible = true;
                btnCapNhap.Enabled = false;
                txtDonDatHang.ReadOnly = false;
  
            }

        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            KiemTraTao();
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
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
                    /* else if (int.Parse(dataGridView_NhapHang.Rows[i].Cells["clSLNhan"].Value.ToString()) == int.Parse(dataGridView_NhapHang.Rows[i].Cells["clDaNhan"].Value.ToString()))
                     {
                         loi = "Da nhan Du";
                         flag = false;
                     }*/
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
                if (PhieuNhapBUS.UpdatePhieuNhap(phieuNhapDTO))
                {

                    foreach (ChiTietPhieuNhapDTO ct in ListChiTietPhieuNhapDTO)
                    {
                        //MessageBox.Show(ct.MaSanPham + ct.SoLuong.ToString());
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
                        MessageBox.Show(ctdh.SLDaNhan.ToString());
                    }

                    MessageBox.Show("Cập Nhập Thành Công");
                   /* txtMaPhieuNhap.Text = CreatePhieuNhapId();
                    DateTime ngayNhan = DateTime.Now;
                    NgayNhap = ngayNhan;
                    txtNgayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");
                    txtMaNhanVien.Text = ThongTin.NhanVienDTO.MaNhanVien;
                    txtNhanVienNhanHang.Text = ThongTin.NhanVienDTO.TenNhanVien;
                    txtNgayDat.Text = null;
                    txtSoTien.Text = null;
                    txtDonDatHang.Text = null;
                    dataGridView_NhapHang.Rows.Clear();*/
                   // btnTao.Visible = false;

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

        }
    }
        
        

    
}
