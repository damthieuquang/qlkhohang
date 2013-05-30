using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//new
using System.Configuration;
using System.IO;
using Microsoft;// Dùng để sử dụng thư viện Microsoft.Office.Interop.Excel

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
        private float MoneySum = 0;   
        public int Status = 0;// Biến trạng thái của Form 0: Tạo, 1: Cập nhật
        float ChietKhau = 0;
        public string MaDonHang;

        //Load các thành phần mặc định, bất kể Status
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
        //Load khi status = 0
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
            label_TongTienTruoc.Text = "Tổng tiền trước chiết khấu: 0";
            label_TongTienSau.Text = "Tổng tiền: 0";
        }
        //Load khi status = 1
        private void Load_Update()
        {
            Load_Default();
            // Thay đổi button Tạo thành Cập nhật
            btnTao.Text = "Cập nhật";

            // Thay đổi button Làm lại thành Hủy
            btnLamLai.Text = "Hủy";

            // Thay đổi button Tạo mới thành Xong
            btnTaoMoi.Text = "Xong";

            // Ẩn button tìm đơn hàng
            btnTimDonHang.Visible = false;

            // Aar button Thoát
            btnThoat.Visible = false;

            // Nhận Mã đơn hàng từ Quản lý Đơn Hàng
            DonHangDTO donHangDTO = new DonHangDTO();
            donHangDTO.MaDonHang = MaDonHang;

            // Truy vấn lấy ra Chi tiết đơn hàng theo mã đơn hàng
            List<ChiTietDonHangDTO> listctDonHangDTO = new List<ChiTietDonHangDTO>();
            listctDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(donHangDTO.MaDonHang.ToString());

            // Lấy tên sản phẩm
            for (int i = 0; i < listctDonHangDTO.Count; i++)
            {
                dataGridView_TaoDonHang.Rows.Add(i + 1, listctDonHangDTO[i].MaSanPham, SanPhamBUS.SelectSanPhamById(listctDonHangDTO[i].MaSanPham).TenSanPham, listctDonHangDTO[i].CV, listctDonHangDTO[i].DonGia, listctDonHangDTO[i].SoLuong, listctDonHangDTO[i].ThanhTien);
            }
            Show_Label();
            
        }        

        private void FormDonHang_Load(object sender, EventArgs e)
        {            
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
        //Tính toán tiền khi tại các dòng có số lượng khác 0
        private float CalcMoney(DataGridView data)
        {
            MoneySum = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                MoneySum += float.Parse(data.Rows[i].Cells["clThanhTien"].Value.ToString());
            }
            return MoneySum;
        }
        // Thực thi khi button Tạo có status = 0
        private bool Process_Button()
        {
            // Lấy các trường để insert vào bảng DonHang
                DonHangDTO donHangDTO = new DonHangDTO();
                donHangDTO.MaDonHang = txtMaDonHang.Text;
                donHangDTO.NgayLap = DateTimeSystem;
                donHangDTO.MaNhanVien = ThongTin.NhanVienDTO.MaNhanVien;
                donHangDTO.ThanhTien = MoneySum;
                donHangDTO.TrangThai = "Chưa nhận";

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
        // Thực thi khi button Tạo có status = 1
        private void Update_Button()
        {
            
        }
        // Thực thi khi button Làm Lại có status = 0
        private void Process_ButtonRemake()
        {
            for (int i = 0; i < dataGridView_TaoDonHang.Rows.Count; i++)
            {
                dataGridView_TaoDonHang.Rows[i].Cells["clSoLuong"].Value = 0;
                dataGridView_TaoDonHang.Rows[i].Cells["clThanhTien"].Value = 0;
            }
            
        }
        // Thực thi khi button Làm Lại có status = 1
        private void Update_ButtonRemake()
        {
            Close();
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
        //Bắt sự kiện thay đổi dữ liện liên quan đến số lượng
        private void dataGridView_TaoDonHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            float kq = 0;
            DataGridViewCell cell = dataGridView_TaoDonHang.CurrentCell;
            // Sửa lỗi trường hợp để ô ở cột số lượng rỗng
            if (dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex].Value == null)
            {
                dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex].Value = 0;
            }
            int SoLuong = 0;
            float DonGia;
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

            DonGia = float.Parse(dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString());
            if (SoLuong * DonGia > 0)
            {
                kq = SoLuong * DonGia;
            }
            dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex + 1].Value = string.Format("{0:0,0.##}", kq.ToString());
          
            Show_Label();
        }
        //Dùng để đưa thông tin về tiền của đơn hàng tại thời điểm đang xét
        private void Show_Label()
        {
            float MoneyCurrent = CalcMoney(dataGridView_TaoDonHang);
            label_TongTienTruoc.Text = "Tổng tiền trước: " + string.Format("{0:0,0.##}", MoneyCurrent.ToString());

            label_TongTienSau.Text = "Tổng tiền: " + string.Format("{0:0,0.##}", (MoneyCurrent - (MoneyCurrent * ChietKhau)).ToString());
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
            if (Status == 0)
            {
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
                return;
            }
            Close();
        }

        // Hàm xử lý xuất file Excel sử dụng thư viện Microsoft
        public static void ExportToExcel(DataGridView dgView)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            try
            {
                // instantiating the excel application class
                object misValue = System.Reflection.Missing.Value;
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook currentWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet currentWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)currentWorkbook.ActiveSheet;
                currentWorksheet.Columns.ColumnWidth = 18;
                if (dgView.Rows.Count > 0)
                {
                    //currentWorksheet.Cells[1, 1] = DateTime.Now.ToString("s");
                    int i = 1;
                    foreach (DataGridViewColumn dgviewColumn in dgView.Columns)
                    {
                        // Excel work sheet indexing starts with 1
                        currentWorksheet.Cells[1, i] = dgviewColumn.HeaderText.ToString().ToUpper();
                        ++i;
                    }
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = currentWorksheet.get_Range("A2", "G2");
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0xFF0000;
                    
                    //headerColumnRange.EntireColumn.AutoFit();
                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dgView.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow dgRow = dgView.Rows[rowIndex];
                        for (int cellIndex = 0; cellIndex < dgRow.Cells.Count; cellIndex++)
                        {
                            currentWorksheet.Cells[rowIndex + 3, cellIndex + 1] = dgRow.Cells[cellIndex].Value;
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fullTextRange = currentWorksheet.get_Range("A1", "G" + (rowIndex + 1).ToString());
                    fullTextRange.WrapText = true;//Tự động xuống dòng khi chữ quá dài
                    fullTextRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;//Canh lề trái cho chữ
                }
                else
                {
                    string timeStamp = DateTime.Now.ToString("s");
                    timeStamp = timeStamp.Replace(':', '-');
                    timeStamp = timeStamp.Replace("T", "__");
                    currentWorksheet.Cells[1, 1] = timeStamp;
                    currentWorksheet.Cells[1, 2] = "No error occured";
                }
                using (SaveFileDialog exportSaveFileDialog = new SaveFileDialog())
                {
                    exportSaveFileDialog.Title = "Select Excel File";
                    exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx";

                    if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
                    {
                        string fullFileName = exportSaveFileDialog.FileName;
                        // currentWorkbook.SaveCopyAs(fullFileName);
                        // indicating that we already saved the workbook, otherwise call to Quit() will pop up
                        // the save file dialogue box

                        currentWorkbook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, System.Reflection.Missing.Value, misValue, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);
                        currentWorkbook.Saved = true;
                        MessageBox.Show("Xuất file thành công", "Xuất file Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (excelApp != null)
                {
                    excelApp.Quit();
                }
            }
        }      

        //Xuất file sang Excel
        private void btnXuatFile_Click(object sender, EventArgs e)
        {           
            ExportToExcel(dataGridView_TaoDonHang);
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
        //Kiểm tra người nhập vào có phải là số hay không
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kiem tra 
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
        //Chuyển sang quản lý đơn hàng
        private void btnTimDonHang_Click(object sender, EventArgs e)
        {
            FormQuanLyDonHang QLDonHang = new FormQuanLyDonHang();
            QLDonHang.ShowDialog();
        }

    }
}
