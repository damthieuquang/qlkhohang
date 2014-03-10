using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChiTietNhanVien : Form
    {
        public FormChiTietNhanVien()
        {
            InitializeComponent();
        }

        public string maNhanVien;
        private bool boolTu = false;
        private bool boolDen = false;
        private bool boolTu2 = false;
        private bool boolDen2 = false;

        private void FormChiTietNhanVien_Load(object sender, EventArgs e)
        {
            NhanVienDTO nhanVienDTO = NhanVienBUS.SelectNhanVienById(maNhanVien);
            labelMaNhanVien.Text = "Mã nhân viên: " + nhanVienDTO.MaNhanVien;
            labelTenNhanVien.Text = "Tên nhân viên: " + nhanVienDTO.TenNhanVien;

            dataGridViewXuatHang.Dock = DockStyle.Fill;
            dataGridViewNhapHang.Dock = DockStyle.Fill;

            List<PhieuXuatDTO> listPhieuXuatDTO = PhieuXuatBUS.SelectPhieuXuatByMaNhanVien(maNhanVien);
            if (listPhieuXuatDTO != null)
            {
                dataGridViewXuatHang.Rows.Clear();
                List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
                foreach (PhieuXuatDTO itemPhieuXuat in listPhieuXuatDTO)
                {
                    listChiTietPhieuXuatDTO = ChiTietPhieuXuatBUS.SelectChiTietPhieuXuatByMaPhieuXuat(itemPhieuXuat.MaPhieuXuat);
                    if (listChiTietPhieuXuatDTO != null)
                    {
                        foreach (ChiTietPhieuXuatDTO itemCTPX in listChiTietPhieuXuatDTO)
                        {
                            dataGridViewXuatHang.Rows.Add(
                                itemPhieuXuat.MaPhieuXuat,
                                itemPhieuXuat.NgayBan.ToString("dd/MM/yyyy"),
                                NhanVienBUS.SelectNhanVienById(itemPhieuXuat.MaNhanVien).TenNhanVien,
                                SanPhamBUS.SelectSanPhamById(itemCTPX.MaSanPham).TenSanPham,
                                itemCTPX.SoLuong.ToString(),
                                string.Format("{0:#,0.##}", itemCTPX.ThanhTien)
                                );
                        }
                    }
                }

            }

            List<PhieuNhapDTO> listPhieuNhapDTO = PhieuNhapBUS.SelectPhieuNhapByMaNhanVien(maNhanVien);
            if (listPhieuNhapDTO != null)
            {
                dataGridViewNhapHang.Rows.Clear();
                List<ChiTietPhieuNhapDTO> listChiTietPhieuNhapDTO = new List<ChiTietPhieuNhapDTO>();
                foreach (PhieuNhapDTO itemPhieuNhap in listPhieuNhapDTO)
                {
                    listChiTietPhieuNhapDTO = ChiTietPhieuNhapBUS.SelectChiTietPhieuNhapByMaPhieuNhap(itemPhieuNhap.MaPhieuNhap);
                    if (listChiTietPhieuNhapDTO != null)
                    {
                        foreach (ChiTietPhieuNhapDTO itemCTPN in listChiTietPhieuNhapDTO)
                        {
                            dataGridViewNhapHang.Rows.Add(
                                itemPhieuNhap.MaPhieuNhap,
                                itemPhieuNhap.NgayNhan.ToString("dd/MM/yyyy"),
                                itemPhieuNhap.MaDonHang,
                                DonHangBUS.SelectDonHangById(itemPhieuNhap.MaDonHang).NgayLap.ToString("dd/MM/yyyy"),
                                NhanVienBUS.SelectNhanVienById(itemPhieuNhap.MaNhanVien).TenNhanVien,
                                SanPhamBUS.SelectSanPhamById(itemCTPN.MaSanPham).TenSanPham,
                                itemCTPN.SLNhan.ToString()
                                );
                        }
                    }
                }

            }

            comboBoxNhapXuat.Items.Add("Nhâp hàng");
            comboBoxNhapXuat.Items.Add("Xuất hàng");
            comboBoxNhapXuat.SelectedIndex = 0;
        }

        private void comboBoxNhapXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNhapXuat.SelectedItem.ToString() == "Nhâp hàng")
            {
                dataGridViewNhapHang.Visible = true;
                dataGridViewXuatHang.Visible = false;
                labelNgay.Text = "Ngày nhận:";


            }
            else
            {
                dataGridViewNhapHang.Visible = false;
                dataGridViewXuatHang.Visible = true;
                labelNgay.Text = "Ngày bán:";
                panelNgayDat.Enabled = false;
            }
            buttonLamLai_Click(sender, e);
        }

        void SearchXuatHang()
        {
            if (dataGridViewXuatHang.RowCount > 0)
            {
                DateTime dateTu = new DateTime();
                DateTime dateDen = new DateTime();
                DateTime dateHienTai = new DateTime();
                if (boolTu)
                {
                    dateTu = dateTimePickerTu.Value.Date;
                }
                else
                {
                    dateTu = new DateTime(1, 1, 1).Date;
                }

                if (boolDen)
                {
                    dateDen = dateTimePickerDen.Value.Date;
                }
                else
                {
                    dateDen = DateTime.Now.Date;
                }


                for (int i = 0; i < dataGridViewXuatHang.RowCount; i++)
                {
                    string[] chuoi = dataGridViewXuatHang.Rows[i].Cells[clNgayBan.Index].Value.ToString().Split('/');
                    dateHienTai = new DateTime(int.Parse(chuoi[2]), int.Parse(chuoi[1]), int.Parse(chuoi[0])).Date;
                    dataGridViewXuatHang.Rows[i].Visible = false;

                    if (dataGridViewXuatHang.Rows[i].Cells[clNhanVien.Index].Value.ToString().ToUpper().IndexOf(textBoxNhanVien.Text.ToString().ToUpper()) >= 0
                        && dataGridViewXuatHang.Rows[i].Cells[clSanPham.Index].Value.ToString().ToUpper().IndexOf(textBoxSanPham.Text.ToString().ToUpper()) >= 0
                        && dateTu.CompareTo(dateHienTai) <= 0 && dateDen.CompareTo(dateHienTai) >= 0
                        && dateTu.CompareTo(dateDen) <= 0
                       )
                    {
                        dataGridViewXuatHang.Rows[i].Visible = true;
                    }
                }
            }
        }

        void SearchNhapHang()
        {
            if (dataGridViewNhapHang.RowCount > 0)
            {
                DateTime dateNgayDatTu = new DateTime();
                DateTime dateNgayDatDen = new DateTime();
                DateTime dateNgayDatHienTai = new DateTime();

                DateTime dateNgayNhanTu = new DateTime();
                DateTime dateNgayNhanDen = new DateTime();
                DateTime dateNgayNhanHienTai = new DateTime();

                if (boolTu2)
                    dateNgayDatTu = dateTimePickerTu2.Value.Date;
                else
                    dateNgayDatTu = new DateTime(1, 1, 1).Date;


                if (boolDen2)
                    dateNgayDatDen = dateTimePickerDen2.Value.Date;
                else
                    dateNgayDatDen = DateTime.Now.Date;

                if (boolTu)
                    dateNgayNhanTu = dateTimePickerTu.Value.Date;
                else
                    dateNgayNhanTu = new DateTime(1, 1, 1).Date;


                if (boolDen)
                    dateNgayNhanDen = dateTimePickerDen.Value.Date;
                else
                    dateNgayNhanDen = DateTime.Now.Date;


                for (int i = 0; i < dataGridViewNhapHang.RowCount; i++)
                {
                    string[] chuoiNgayDat = dataGridViewNhapHang.Rows[i].Cells[clNgayDat.Index].Value.ToString().Split('/');
                    dateNgayDatHienTai = new DateTime(int.Parse(chuoiNgayDat[2]), int.Parse(chuoiNgayDat[1]), int.Parse(chuoiNgayDat[0])).Date;

                    string[] chuoiNgayNhan = dataGridViewNhapHang.Rows[i].Cells[clNgayNhan.Index].Value.ToString().Split('/');
                    dateNgayNhanHienTai = new DateTime(int.Parse(chuoiNgayNhan[2]), int.Parse(chuoiNgayNhan[1]), int.Parse(chuoiNgayNhan[0])).Date;
                    dataGridViewNhapHang.Rows[i].Visible = false;

                    if (dataGridViewNhapHang.Rows[i].Cells[clNhanVien2.Index].Value.ToString().ToUpper().IndexOf(textBoxNhanVien.Text.ToString().ToUpper()) >= 0
                        && dataGridViewNhapHang.Rows[i].Cells[clSanPham2.Index].Value.ToString().ToUpper().IndexOf(textBoxSanPham.Text.ToString().ToUpper()) >= 0
                        && dateNgayDatTu.CompareTo(dateNgayDatHienTai) <= 0 && dateNgayDatDen.CompareTo(dateNgayDatHienTai) >= 0
                        && dateNgayDatTu.CompareTo(dateNgayDatDen) <= 0
                        && dateNgayNhanTu.CompareTo(dateNgayNhanHienTai) <= 0 && dateNgayNhanDen.CompareTo(dateNgayNhanHienTai) >= 0
                        && dateNgayNhanTu.CompareTo(dateNgayNhanDen) <= 0
                       )
                    {
                        dataGridViewNhapHang.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void textBoxNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxNhapXuat.SelectedItem.ToString() == "Nhâp hàng")
            {
                SearchNhapHang();
            }
            else
            {
                SearchXuatHang();
            }
        }

        private void textBoxSanPham_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxNhapXuat.SelectedItem.ToString() == "Nhâp hàng")
            {
                SearchNhapHang();
            }
            else
            {
                SearchXuatHang();
            }
        }

        private void dateTimePickerTu_ValueChanged(object sender, EventArgs e)
        {
            boolTu = true;
            if (comboBoxNhapXuat.SelectedItem.ToString() == "Nhâp hàng")
            {
                SearchNhapHang();
            }
            else
            {
                SearchXuatHang();
            }
        }

        private void dateTimePickerDen_ValueChanged(object sender, EventArgs e)
        {
            boolDen = true;
            if (comboBoxNhapXuat.SelectedItem.ToString() == "Nhâp hàng")
            {
                SearchNhapHang();
            }
            else
            {
                SearchXuatHang();
            }
        }

        private void dateTimePickerTu2_ValueChanged(object sender, EventArgs e)
        {
            boolTu2 = true;
            if (comboBoxNhapXuat.SelectedItem.ToString() == "Nhâp hàng")
            {
                SearchNhapHang();
            }
            else
            {
                SearchXuatHang();
            }
        }

        private void dateTimePickerDen2_ValueChanged(object sender, EventArgs e)
        {
            boolDen2 = true;
            if (comboBoxNhapXuat.SelectedItem.ToString() == "Nhâp hàng")
            {
                SearchNhapHang();
            }
            else
            {
                SearchXuatHang();
            }
        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            dateTimePickerTu.Value = DateTime.Now;
            boolTu = false;
            dateTimePickerDen.Value = DateTime.Now;
            boolDen = false;
            dateTimePickerTu2.Value = DateTime.Now;
            boolTu2 = false;
            dateTimePickerDen2.Value = DateTime.Now;
            boolDen2 = false;
            textBoxNhanVien.Text = null;
            textBoxSanPham.Text = null;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
