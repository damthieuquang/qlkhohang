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
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }

        private DateTime DateTimeSystem;
        private int MoneySum = 0;
        private void FormDonHang_Load(object sender, EventArgs e)
        {         
            //Load Ma Nhan Vien
            txtMaNhanVien.Text = ThongTin.NhanVienDTO.MaNhanVien;

            //Load ten nhan vien
            txtTenNhanVien.Text = ThongTin.NhanVienDTO.TenNhanVien;
            //tao ngay he thong
            DateTimeSystem = DateTime.Now;
            txtNgayLap.Text = DateTimeSystem.ToString("dd/MM/yyyy");

            //tao ma don hang
            string MaDonHang;
            MaDonHang = "DH" + DateTimeSystem.ToString("yyMMddhhmmss");
            txtMaDonHang.Text = MaDonHang.ToString();

            //tao MaStockist va Dia chi Stockist
            List<ThamSoDTO> listthamSoDTO = ThamSoBUS.SelectThamSoAll();
            string MaStockist = "";
            string DiaChiStockist = "";
            foreach (ThamSoDTO thamSoDTO in listthamSoDTO)
            {
                if (thamSoDTO.TenThamSo == "MaStockist")
                {
                    MaStockist = thamSoDTO.GiaTri;
                }
                if (thamSoDTO.TenThamSo == "DiaChiStockist")
                {
                    DiaChiStockist = thamSoDTO.GiaTri;
                }
            }
            txtMaStockist.Text = MaStockist;
            txtDiaChiStockist.Text = DiaChiStockist;
            int stt = 1;
            List<SanPhamDTO> listSanPhamDTO = SanPhamBUS.SelectSanPhamAll();

            foreach (SanPhamDTO sanPhamDTO in listSanPhamDTO)
            {
                if (sanPhamDTO.CV != 0)
                {
                    dataGridView_TaoDonHang.Rows.Add(stt, sanPhamDTO.MaSanPham, sanPhamDTO.TenSanPham, sanPhamDTO.CV, sanPhamDTO.DonGia, 0, 0);
                    stt++;
                }
            }
            
        }

        private void dataGridView_TaoDonHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int kq = 0;
            int SoLuong = int.Parse(dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex].Value.ToString());
            int DonGia = int.Parse(dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString());
            if (SoLuong*DonGia > 0)
            {
                kq = SoLuong * DonGia;
            }            
            dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex + 1].Value = kq.ToString();

            int MoneyCurrent = CalcMoney(dataGridView_TaoDonHang);
            labelTongTien.Text = "Sum = " + MoneyCurrent.ToString();
        }

        private int CalcMoney(DataGridView data)
        {
            MoneySum = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                MoneySum += int.Parse(data.Rows[i].Cells["clThanhTien"].Value.ToString());
            }
            return MoneySum;
        }

        private void dateTimePicker1_MouseCaptureChanged(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = dateTimePicker1.Value.ToShortDateString();
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            DonHangDTO donHangDTO = new DonHangDTO();
            donHangDTO.MaDonHang = txtMaDonHang.Text;
            donHangDTO.NgayLap = DateTimeSystem;
            donHangDTO.MaNhanVien = ThongTin.NhanVienDTO.MaNhanVien;
            donHangDTO.ThanhTien = MoneySum;
            donHangDTO.TrangThai = "Thanh Cong";

            if (DonHangBUS.InsertDonHang(donHangDTO))
            {
                MessageBox.Show("Nhập dữ liệu thành công");
            }
            else
            {
                MessageBox.Show("Nhập dữ liệu thất bại");
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            dataGridView_TaoDonHang.Rows.Clear();
            FormDonHang_Load(sender,e);
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_TaoDonHang.Rows.Count; i++)
            {
                dataGridView_TaoDonHang.Rows[i].Cells["clSoLuong"].Value = 0;
                dataGridView_TaoDonHang.Rows[i].Cells["clThanhTien"].Value = 0;
            }
            labelTongTien.Visible = false;
        }              
    }
}
