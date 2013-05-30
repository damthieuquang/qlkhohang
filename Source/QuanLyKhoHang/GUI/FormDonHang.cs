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
        // Toàn cục
        private DateTime DateTimeSystem;
        private int MoneySum = 0;   
        private int Status = 0;// 0: Tạo, 1: Cập nhật
        float ChietKhau = 0;

        private void Load_Default()
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
            MaDonHang = "DH" + DateTimeSystem.ToString("yyMMddhhmmss");//yyMMddhhmmss
            txtMaDonHang.Text = MaDonHang.ToString();

            //tao MaStockist va Dia chi Stockist
            List<ThamSoDTO> listthamSoDTO = ThamSoBUS.SelectThamSoAll();
            string MaStockist = "";
            string DiaChiStockist = "";
            
            
            foreach (ThamSoDTO thamSo in listthamSoDTO)
            {
                
                if (thamSo.TenThamSo == "MaStockist")
                {
                    MaStockist = thamSo.GiaTri;                                                            
                }
                if (thamSo.TenThamSo == "DiaChiStockist")
                {
                    DiaChiStockist = thamSo.GiaTri;
                }
                if (thamSo.TenThamSo == "ChietKhau")
                {
                    ChietKhau = float.Parse(thamSo.GiaTri.ToString());
                }
            }
            Label_ChietKhau.Text = "Chiết khấu: " + ChietKhau.ToString();
            txtMaStockist.Text = MaStockist;
            txtDiaChiStockist.Text = DiaChiStockist;
            
        }

        private void Load_Create()
        {
            Load_Default();
            int stt = 1;
            List<SanPhamDTO> listSanPhamDTO = SanPhamBUS.SelectSanPhamAll();

            foreach (SanPhamDTO sanPhamDTO in listSanPhamDTO)
            {


                dataGridView_TaoDonHang.Rows.Add(stt, sanPhamDTO.MaSanPham, sanPhamDTO.TenSanPham, sanPhamDTO.CV, sanPhamDTO.DonGia, 0, 0);
                stt++;
            }
        }

        private void Load_Update()
        {
            Load_Default();
            // Thay đổi button Tạo thành Cập nhật
            btnTao.Text = "Cập nhật";

            // Nhận Mã đơn hàng từ Quản lý Đơn Hàng
            DonHangDTO donHangDTO = new DonHangDTO();
            donHangDTO.MaDonHang = txtMaDonHang.Text;

            // Truy vấn lấy ra Chi tiết đơn hàng theo mã đơn hàng
            List<ChiTietDonHangDTO> listctDonHangDTO = new List<ChiTietDonHangDTO>();
            listctDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(donHangDTO.MaDonHang.ToString());
            List<SanPhamDTO> listSanPhamDTO = new List<SanPhamDTO>();

            foreach (ChiTietDonHangDTO chitiet in listctDonHangDTO)
            {
                listSanPhamDTO.Add(SanPhamBUS.SelectSanPhamById(chitiet.MaSanPham.ToString()));
            }

            for (int i = 0; i < listSanPhamDTO.Count; i++)
            {
                dataGridView_TaoDonHang.Rows.Add(i + 1, listSanPhamDTO[i].MaSanPham.ToString(), listSanPhamDTO[i].TenSanPham.ToString(), listSanPhamDTO[i].CV, listSanPhamDTO[i].DonGia, 0, 0);
            }
            //Chose_Product();
        }

        private void Chose_Product()
        {
           
            FormChonSanPham frm = new FormChonSanPham();
            frm.Show();
            //frm.Activate();
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            Status = 0;
            if (Status == 0)
            {
                Load_Create();
                return;
            }
            btnTao.Text = "Cập nhật";
            Load_Update();
        }

        private bool CheckDataOn_Row_DataGridView(DataGridView data)// kiểm tra tồn tại dòng có thành tiền khác 0
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataGridViewRow Row = data.Rows[i];
                if (float.Parse(Row.Cells["clThanhTien"].Value.ToString()) > 0)
                {
                    return true;
                }
            }
            return false;
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

        private bool Process_Button()
        {
            // Lấy các trường để insert vào bảng DonHang
                DonHangDTO donHangDTO = new DonHangDTO();
                donHangDTO.MaDonHang = txtMaDonHang.Text;
                donHangDTO.NgayLap = DateTimeSystem;
                donHangDTO.MaNhanVien = ThongTin.NhanVienDTO.MaNhanVien;
                donHangDTO.ThanhTien = MoneySum;
                donHangDTO.TrangThai = "Thanh Cong";

                // Lấy các trường để insert vào bảng ChiTietDonHang
                List<ChiTietDonHangDTO> listctdonHangDTO = new List<ChiTietDonHangDTO>();
                for (int i = 0; i < dataGridView_TaoDonHang.Rows.Count; i++)
                {
                    ChiTietDonHangDTO ctdonHangDTO = new ChiTietDonHangDTO();
                    DataGridViewRow Row = dataGridView_TaoDonHang.Rows[i];
                    int check;
                    int.TryParse(Row.Cells["clSoLuong"].Value.ToString(), out check);
                    if (check > 0)
                    {
                        ctdonHangDTO.MaChiTietDonHang = txtMaDonHang.Text;
                        if (i > 100)
                        {
                            ctdonHangDTO.MaChiTietDonHang += (i + 1).ToString();
                        }
                        else if (i > 10)
                        {
                            ctdonHangDTO.MaChiTietDonHang += "0" + (i + 1).ToString();
                        }
                        else
                        {
                            ctdonHangDTO.MaChiTietDonHang += "00" + (i + 1).ToString();
                        }
                        ctdonHangDTO.MaDonHang = txtMaDonHang.Text;
                        ctdonHangDTO.MaSanPham = Row.Cells["clMaSanPham"].Value.ToString();
                        ctdonHangDTO.CV = int.Parse(Row.Cells["clCV"].Value.ToString());
                        ctdonHangDTO.SoLuong = int.Parse(Row.Cells["clSoLuong"].Value.ToString());
                        ctdonHangDTO.DonGia = float.Parse(Row.Cells["clDonGia"].Value.ToString());
                        ctdonHangDTO.ThanhTien = float.Parse(Row.Cells["clThanhTien"].Value.ToString());
                        listctdonHangDTO.Add(ctdonHangDTO);
                    }
                }

                //insert dữ liệu

                if (DonHangBUS.InsertDonHang(donHangDTO))
                {
                    foreach (ChiTietDonHangDTO ctdonHangDTO in listctdonHangDTO)
                    {
                        ChiTietDonHangBUS.InsertChiTietDonHang(ctdonHangDTO);
                    }
                    MessageBox.Show("Nhập dữ liệu thành công");
                    return true;
                    //btnTao.Text = "Cập nhật";
                }
                else
                {
                    MessageBox.Show("Nhập dữ liệu thất bại");
                }
                return false;
            
        }

        private void Update_Button()
        {
            
        }

        private void Process_ButtonRemake()
        {
            for (int i = 0; i < dataGridView_TaoDonHang.Rows.Count; i++)
            {
                dataGridView_TaoDonHang.Rows[i].Cells["clSoLuong"].Value = 0;
                dataGridView_TaoDonHang.Rows[i].Cells["clThanhTien"].Value = 0;
            }
            
        }

        private void Update_ButtonRemake()
        {

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            if (Status == 0)
            {
                Process_ButtonRemake();
                return;
            }
            Update_ButtonRemake();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void dataGridView_TaoDonHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int kq = 0;
            DataGridViewCell cell = dataGridView_TaoDonHang.CurrentCell;
            int SoLuong, DonGia;
            if (int.TryParse(dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex].Value.ToString(), out SoLuong))
            {
                SoLuong = int.Parse(dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex].Value.ToString());
            }
            else
            {
                cell.Value = 0;
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
                dataGridView_TaoDonHang.ClearSelection();
                dataGridView_TaoDonHang.CurrentCell = cell;
                dataGridView_TaoDonHang.CurrentCell.Selected = true;

                return;
            }

            DonGia = int.Parse(dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString());
            if (SoLuong * DonGia > 0)
            {
                kq = SoLuong * DonGia;
            }
            dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex + 1].Value = kq.ToString();

            int MoneyCurrent = CalcMoney(dataGridView_TaoDonHang);
            label_TongTienTruoc.Text = MoneyCurrent.ToString();
            label_TongTienSau.Text = (MoneyCurrent * ChietKhau).ToString();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (Status == 0)
            {
                if (Process_Button())
                {
                    dataGridView_TaoDonHang.Rows.Clear();
                    FormDonHang_Load(sender, e);
                }
                return;
            }
            // Ngược lại là 1, nút cập nhật
            Update_Button();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            Status = 0;
            DialogResult result = MessageBox.Show("Bạn Muốn Lưu Đơn Hàng Không:", "Đơn hàng", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                btnTao_Click(sender, e);
            }
            else if (result == DialogResult.No)
            {
                dataGridView_TaoDonHang.Rows.Clear();
                FormDonHang_Load(sender, e);
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView_TaoDonHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {          
            //if (dataGridView_TaoDonHang.Rows.Count > 0 && e.ColumnIndex == 5)
            //{
            //    int dongia = int.Parse(dataGridView_TaoDonHang.CurrentRow.Cells["clDonGia"].Value.ToString());
            //    int soluong = int.Parse(dataGridView_TaoDonHang.CurrentRow.Cells["clSoLuong"].Value.ToString());
            //    dataGridView_TaoDonHang.CurrentRow.Cells["clThanhTien"].Value = (dongia * soluong).ToString();
            //}
            //int Money = CalcMoney(dataGridView_TaoDonHang);
            //label_TongTienTruoc.Text = Money.ToString();                
        }

        private void dataGridView_TaoDonHang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView_TaoDonHang.CurrentCellAddress.X == dataGridView_TaoDonHang.Columns[5].DisplayIndex)
            {
                TextBox txt = e.Control as TextBox;
                txt.Name = "clSoLuong";
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(txt_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(txt_KeyPress);
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kim tra 
            TextBox txt = sender as TextBox;
            if (txt.Name == "clSoLuong")
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
        }

    }
}
