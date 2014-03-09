using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.IO;

namespace GUI
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }

        #region Biến toàn cục
        // Toàn cục
        private DateTime DateTimeSystem;
        private float MoneySum = 0;
        public int Status = 0;// Biến trạng thái của Form 0: Tạo, 1: Cập nhật, 2 chuyển sang cập nhật từ nút cập nhật của QLDonHang
        float ChietKhau = 0;
        public string MaDonHang;
        private bool huy = false;

        #endregion

        #region Load các from
        //Load các thành phần mặc định, bất kể Status
        private void Load_Default()
        {

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
            //Cho chọn sản phẩm
            FormChonSanPham ChonSanPham = new FormChonSanPham();
            ChonSanPham.ShowDialog();
            huy = ChonSanPham.huy;
            if (!huy)
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


                int stt = 1;
                List<SanPhamDTO> listSanPhamDTO = ChonSanPham.listsanPhamDTO_ChonSanPham;

                foreach (SanPhamDTO sanPhamDTO in listSanPhamDTO)
                {
                    dataGridView_TaoDonHang.Rows.Add(stt, sanPhamDTO.MaSanPham, sanPhamDTO.TenSanPham, sanPhamDTO.CV, sanPhamDTO.DonGia, 0, 0);
                    stt++;
                }
                btnTao.Enabled = true;

                label_TongTienTruoc.Text = "Tổng tiền trước chiết khấu: 0";
                label_TongTienSau.Text = "Tổng tiền: 0";

            }
        }

        //Load khi status = 1
        private void Load_Update()
        {
            Load_Default();
            //txtMaNhanVien.Text = MaNhanVien;

            //Load thoong tin don hang
            DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(MaDonHang);
            txtMaDonHang.Text = donHangDTO.MaDonHang;
            txtNgayLap.Text = donHangDTO.NgayLap.ToString("dd/MM/yyyy");
            txtMaNhanVien.Text = donHangDTO.MaNhanVien;
            txtTenNhanVien.Text = NhanVienBUS.SelectNhanVienById(donHangDTO.MaNhanVien).TenNhanVien;

            //Load panel YesNo(hien tai dang an)
            panelYesNo.Location = new Point(16, 409);

            // Thay đổi button Tạo thành Cập nhật
            btnTao.Text = "Cập nhật";
            btnTao.Enabled = true;

            btnTaoMoi.Visible = false;
            btnLamLai.Visible = false;
            btnTimDonHang.Visible = false;

            //Doi vi tri button Xuat File
            btnXuatFile.Location = new Point(158, 11);


            // Truy vấn lấy ra Chi tiết đơn hàng theo mã đơn hàng
            List<ChiTietDonHangDTO> listctDonHangDTO = new List<ChiTietDonHangDTO>();
            listctDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(MaDonHang);

            dataGridView_TaoDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Lấy tên sản phẩm
            for (int i = 0; i < listctDonHangDTO.Count; i++)
            {
                dataGridView_TaoDonHang.Rows.Add(i + 1, listctDonHangDTO[i].MaSanPham, SanPhamBUS.SelectSanPhamById(listctDonHangDTO[i].MaSanPham).TenSanPham, listctDonHangDTO[i].CV, string.Format("{0:#,0.##}", listctDonHangDTO[i].DonGia), listctDonHangDTO[i].SoLuong, string.Format("{0:#,0.##}", listctDonHangDTO[i].ThanhTien));
                dataGridView_TaoDonHang.Rows[i].ReadOnly = true;
            }
            Show_Label();

        }
        #endregion

        #region Nhóm hàm Xử lý
        // kiểm tra tồn tại dòng có thành tiền khác 0
        private bool CheckDataOn_Row_DataGridView(DataGridView data)
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

        // Thay đổi FormDonHang khi Status = 2
        private void Update()
        {
            panelYesNo.Visible = true;
            panelYesNo.Parent = this;
            panelChucNang.Visible = false;
            dataGridView_TaoDonHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            for (int i = 0; i < dataGridView_TaoDonHang.RowCount; i++)
            {
                dataGridView_TaoDonHang.Rows[i].ReadOnly = false;
            }
            Status = 2;

            dataGridView_TaoDonHang.CurrentCell = dataGridView_TaoDonHang.Rows[0].Cells[clSoLuong.Index];
            dataGridView_TaoDonHang.CurrentCell.Selected = true;
            dataGridView_TaoDonHang.BeginEdit(true);

        }
        // Thực thi khi button Làm Lại có status = 0
        private void Process_ButtonRemake()
        {
            btnTao.Enabled = false;
            for (int i = 0; i < dataGridView_TaoDonHang.Rows.Count; i++)
            {
                dataGridView_TaoDonHang.Rows[i].Cells["clSoLuong"].Value = 0;
                dataGridView_TaoDonHang.Rows[i].Cells["clThanhTien"].Value = 0;
            }

            label_TongTienTruoc.Text = "Tổng tiền trước chiết khấu: 0";
            label_TongTienSau.Text = "Tổng tiền: 0";

        }
        // Thực thi khi button Làm Lại có status = 1
        private void Update_ButtonRemake()
        {
            Close();
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
        #endregion

        #region Nhóm hàm sự kiện
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            if (Status == 0)
            {
                Process_ButtonRemake();
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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
            dataGridView_TaoDonHang.CurrentRow.Cells[e.ColumnIndex + 1].Value = string.Format("{0:#,0.##}", kq);

            Show_Label();
        }

        //Dùng để đưa thông tin về tiền của đơn hàng tại thời điểm đang xét
        private void Show_Label()
        {
            float MoneyCurrent = CalcMoney(dataGridView_TaoDonHang);
            label_TongTienTruoc.Text = "Tổng tiền trước: " + string.Format("{0:#,0.##}", MoneyCurrent);

            label_TongTienSau.Text = "Tổng tiền: " + string.Format("{0:#,0.##}", (MoneyCurrent * (1.0 - (ChietKhau / 10))));
        }

        // Hàm xử lý xuất file Excel sử dụng thư viện Microsoft
        private void ExportToExcel(DataGridView dgView)
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
                    currentWorksheet.Cells[4, 1] = "Mã Stockist";
                    currentWorksheet.Cells[4, 2] = "____________";
                    currentWorksheet.Cells[5, 1] = "Địa chỉ Stockist";
                    currentWorksheet.Cells[5, 2] = "____________";
                    currentWorksheet.Cells[6, 1] = "Ngày Tạo:";
                    currentWorksheet.Cells[6, 2] = txtNgayLap.Text;

                    Microsoft.Office.Interop.Excel.Range mm = currentWorksheet.get_Range("C1", "G1");
                    mm.MergeCells = true;
                    mm.Font.Bold = true;
                    mm.Font.Size = 20;
                    mm.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    mm.Cells[1, 1] = "ĐƠN ĐẶT HÀNG STOCKIST";
                    //currentWorksheet.Cells[1, 7] = "ĐƠN ĐẶT HÀNG STOCKIST";                                        

                    mm = currentWorksheet.get_Range("D3", "G6");
                    mm.MergeCells = true;
                    mm.WrapText = true;
                    mm.Cells[Type.Missing, Type.Missing] = "Công ty TNHH Synergy Việt Nam; Số 27 - tổ 41, Phường Trung Hoà; Quận Cầu Giấy, Hà Nội, Việt Nam; Tel: 84-4 35562535 - Fax: 84-4 35562356";

                    currentWorksheet.Cells[2, 6] = "VIET NAM";
                    //currentWorksheet.Cells[3, 7] = "Công ty TNHH Synergy Việt Nam";
                    //currentWorksheet.Cells[4, 7] = "Số 27 - tổ 41, Phường Trung Hoà";
                    //currentWorksheet.Cells[5, 7] = "Quận Cầu Giấy, Hà Nội, Việt Nam";
                    //currentWorksheet.Cells[6, 7] = "Tel: 84-4 35562535   - Fax: 84-4 35562356";
                    int i = 1;
                    foreach (DataGridViewColumn dgviewColumn in dgView.Columns)
                    {
                        // Excel work sheet indexing starts with 1
                        currentWorksheet.Cells[7, i] = dgviewColumn.HeaderText.ToString().ToUpper();
                        ++i;
                    }
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = currentWorksheet.get_Range("A7", "G7");
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0x000000;


                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dgView.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow dgRow = dgView.Rows[rowIndex];
                        for (int cellIndex = 0; cellIndex < dgRow.Cells.Count; cellIndex++)
                        {
                            currentWorksheet.Cells[rowIndex + 8, cellIndex + 1] = dgRow.Cells[cellIndex].Value;
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fullTextRange = currentWorksheet.get_Range("A8", "G" + (rowIndex + 1).ToString());
                    fullTextRange.WrapText = true;//Tự động xuống dòng khi chữ quá dài
                    fullTextRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;//Canh lề trái cho chữ                  

                    for (int row = 0; row < 3; row++)
                    {
                        string cell1, cell2;
                        cell1 = "A" + (rowIndex + 8 + row).ToString();
                        cell2 = "F" + (rowIndex + 8 + row).ToString();
                        Microsoft.Office.Interop.Excel.Range MergeRowRange = currentWorksheet.get_Range(cell1, cell2);
                        MergeRowRange.MergeCells = true;
                        MergeRowRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

                    }
                    currentWorksheet.Cells[rowIndex + 8, 1] = "Tổng tiền trước chiết khấu:";
                    currentWorksheet.Cells[rowIndex + 8, 7] = CalcMoney(dgView);

                    currentWorksheet.Cells[rowIndex + 9, 1] = "Chiết khấu:";
                    currentWorksheet.Cells[rowIndex + 9, 7] = string.Format("{0:#,0.##}", ChietKhau);

                    currentWorksheet.Cells[rowIndex + 10, 1] = "Tổng tiền thanh toán:";
                    currentWorksheet.Cells[rowIndex + 10, 7] = string.Format("{0:#,0.##}", CalcMoney(dgView) * (1.0 - (ChietKhau / 10)));

                    Microsoft.Office.Interop.Excel.Range AllRange = currentWorksheet.get_Range("A1", "G" + (rowIndex + 10).ToString());
                    AllRange.Columns.AutoFit();
                    AllRange = currentWorksheet.get_Range("A7", "G" + (rowIndex + 10).ToString());
                    AllRange.Borders.Color = 0x000000;
                    try
                    {
                        string currentpath = Directory.GetCurrentDirectory().ToString();
                        string dir = Directory.GetParent(currentpath).ToString();
                        for (int j = 0; j < 2; j++)
                            dir = Directory.GetParent(dir).ToString();
                        string logo = dir + @"\Images\logo.jpg";
                        string flag = dir + @"\Images\logo.jpg";
                        currentWorksheet.Shapes.AddPicture(logo, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 140, 40);
                        currentWorksheet.Shapes.AddPicture(flag, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 380, 27, 23, 15);
                    }
                    catch
                    {
                        MessageBox.Show("Không tìm thấy tập tin ảnh");
                    }

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xuất", "Xuất file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    //string timeStamp = DateTime.Now.ToString("s");
                    //timeStamp = timeStamp.Replace(':', '-');
                    //timeStamp = timeStamp.Replace("T", "__");
                    //currentWorksheet.Cells[1, 1] = timeStamp;
                    //currentWorksheet.Cells[1, 2] = "No error occured";
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

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView_TaoDonHang);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (Status == 0 || Status == 4)
            {
                if (CheckDataOn_Row_DataGridView(dataGridView_TaoDonHang))
                {
                    Process_Button();
                    dataGridView_TaoDonHang.Rows.Clear();
                    FormDonHang_Load(sender, e);
                }
                else
                {
                    dataGridView_TaoDonHang.CurrentCell = dataGridView_TaoDonHang.Rows[0].Cells[clSoLuong.Index];
                    dataGridView_TaoDonHang.CurrentCell.Selected = true;
                    dataGridView_TaoDonHang.BeginEdit(true);
                    MessageBox.Show("Đơn hàng không hợp lệ, tất cả số lượng sản phẩm đều bằng không", "Đơn hàng");
                }
            }
            else
            {
                if (DonHangBUS.SelectDonHangById(MaDonHang).TrangThai == "Chưa nhận")
                {
                    Update();
                }
                else
                {
                    MessageBox.Show("Đơn hàng đã nhận, không cho phép cập nhật", "Quản lý đơn hàng");

                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (Status == 0 || Status == 4)
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
                else if (Status == 4)
                {
                    dataGridView_TaoDonHang.Rows.Clear();
                    FormDonHang_Load(sender, e);
                }

                return;
            }

            else
            {
                Close();
            }
        }

        private void btnTimDonHang_Click(object sender, EventArgs e)
        {
            Form frm = ThongTin.KiemTraTonTai(typeof(FormQuanLyDonHang), this.ParentForm);
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormQuanLyDonHang fQLDonHang = new FormQuanLyDonHang();
                fQLDonHang.MdiParent = this.ParentForm;
                fQLDonHang.Show();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Dispose();// tat va giai phong tai nguyen
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (CheckDataOn_Row_DataGridView(dataGridView_TaoDonHang))
            {
                List<ChiTietDonHangDTO> listctDonHangDTO = new List<ChiTietDonHangDTO>();
                listctDonHangDTO = ChiTietDonHangBUS.SelectChiTietDonHangByMaDonHang(MaDonHang);

                for (int i = 0; i < listctDonHangDTO.Count; i++)
                {
                    listctDonHangDTO[i].SoLuong = int.Parse(dataGridView_TaoDonHang.Rows[i].Cells["clSoLuong"].Value.ToString());
                    listctDonHangDTO[i].ThanhTien = float.Parse(dataGridView_TaoDonHang.Rows[i].Cells["clThanhTien"].Value.ToString());
                    ChiTietDonHangBUS.UpdateChiTietDonHangById(listctDonHangDTO[i]);
                }
                CalcMoney(dataGridView_TaoDonHang);
                DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(MaDonHang);
                donHangDTO.ThanhTien = MoneySum;
                DonHangBUS.UpdateDonHangById(donHangDTO);
                MessageBox.Show("Cập nhật thành công", "Cập nhật đơn hàng");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Đơn hàng không hợp lệ, tất cả số lượng sản phẩm đều bằng không", "Đơn hàng");
                dataGridView_TaoDonHang.CurrentCell = dataGridView_TaoDonHang.Rows[0].Cells[clSoLuong.Index];
                dataGridView_TaoDonHang.CurrentCell.Selected = true;
                dataGridView_TaoDonHang.BeginEdit(true);
            }
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
        #endregion

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            if (Status == 0 || Status == 4)
            {
                Load_Create();
            }
            else
            {
                btnTao.Text = "Cập nhật";
                Load_Update();
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (huy)
            {
                this.Dispose();
            }
            else if (Status == 2)
            {
                Update();
            }
            else if (Status == 0)
            {
                dataGridView_TaoDonHang.CurrentCell = dataGridView_TaoDonHang.Rows[0].Cells[clSoLuong.Index];
                dataGridView_TaoDonHang.CurrentCell.Selected = true;
                dataGridView_TaoDonHang.BeginEdit(true);
            }
        }

        private void FormDonHang_Activated(object sender, EventArgs e)
        {
            if (Status == 4)
            {
                btnTaoMoi_Click(sender, e);
            }
        }


    }
}
