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
    public partial class FormChiTietThanhVien : Form
    {
        public FormChiTietThanhVien()
        {
            InitializeComponent();
        }

        public string maThanhVien;
        private bool boolTu = false;
        private bool boolDen = false;

        private void FormChiTietThanhVien_Load(object sender, EventArgs e)
        {
            ThanhVienDTO thanhVienDTO = ThanhVienBUS.SelectThanhVienById(maThanhVien);
            labelMaThanhVien.Text = "Mã thành viên: " + maThanhVien;
            labelTenThanhVien.Text = "Tên thành viên: " + thanhVienDTO.TenThanhVien;
            labelDiaChi.Text = "Địa chỉ: " + thanhVienDTO.DiaChi;
            labelTongCV.Text = "Tổng CV: " + thanhVienDTO.CV.ToString();

            List<PhieuXuatDTO> listPhieuXuatDTO = PhieuXuatBUS.SelectPhieuXuatByMaThanhVien(maThanhVien);
            if (listPhieuXuatDTO != null)
            {
                dataGridViewChiTiet.Rows.Clear();
                List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
                foreach (PhieuXuatDTO itemPhieuXuat in listPhieuXuatDTO)
                {
                    listChiTietPhieuXuatDTO = ChiTietPhieuXuatBUS.SelectChiTietPhieuXuatByMaPhieuXuat(itemPhieuXuat.MaPhieuXuat);
                    if (listChiTietPhieuXuatDTO!=null)
                    {
                        foreach (ChiTietPhieuXuatDTO itemCTPX in listChiTietPhieuXuatDTO)
                        {
                            dataGridViewChiTiet.Rows.Add(
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
        }

        void Search()
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


            for (int i = 0; i < dataGridViewChiTiet.RowCount; i++)
            {
                string[] chuoi = dataGridViewChiTiet.Rows[i].Cells[clNgayBan.Index].Value.ToString().Split('/');
                dateHienTai = new DateTime(int.Parse(chuoi[2]), int.Parse(chuoi[1]), int.Parse(chuoi[0])).Date;
                dataGridViewChiTiet.Rows[i].Visible = false;

                if (dataGridViewChiTiet.Rows[i].Cells[clNhanVien.Index].Value.ToString().ToUpper().IndexOf(textBoxNhanVien.Text.ToString().ToUpper()) >= 0
                    && dataGridViewChiTiet.Rows[i].Cells[clSanPham.Index].Value.ToString().ToUpper().IndexOf(textBoxSanPham.Text.ToString().ToUpper()) >= 0
                    && dateTu.CompareTo(dateHienTai) <= 0 && dateDen.CompareTo(dateHienTai) >= 0
                    && dateTu.CompareTo(dateDen) <= 0
                   )
                {
                    dataGridViewChiTiet.Rows[i].Visible = true;
                }
            }
        }

        private void textBoxNhanVien_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxSanPham_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dateTimePickerTu_ValueChanged(object sender, EventArgs e)
        {
            boolTu = true;
            Search();
        }

        private void dateTimePickerDen_ValueChanged(object sender, EventArgs e)
        {
            boolDen = true;
            Search();
        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            dateTimePickerTu.Value = DateTime.Now;
            boolTu = false;
            dateTimePickerDen.Value = DateTime.Now;
            boolDen = false;
            textBoxNhanVien.Text = null;
            textBoxSanPham.Text = null;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
