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

        private DateTime NgayHeThong;
        private int stt = 0;
        private void FormDonHang_Load(object sender, EventArgs e)
        {         
            //tao ngay he thong
            NgayHeThong = DateTime.Now;
            txtNgayLap.Text = NgayHeThong.ToString("dd/MM/yyyy");

            //tao ma don hang
            string MaDonHang;
            MaDonHang = "DH" + NgayHeThong.ToString("MMddyyhhmmss");
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
            int SoLuong = int.Parse(dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex].Value.ToString());
            int DonGia = int.Parse(dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString());
            int kq = SoLuong * DonGia;
            dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex + 1].Value = kq.ToString();

        }

        private void dateTimePicker1_MouseCaptureChanged(object sender, EventArgs e)
        {
            DateTimePicker picker = new DateTimePicker();
            txtTenNhanVien.Text = picker.Value.ToShortDateString();
        }

              
    }
}
