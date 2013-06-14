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

using DTO;
using BUS;

namespace GUI
{
    public partial class FormXuatHang : Form
    {
        public FormXuatHang()
        {
            InitializeComponent();
        }

        // Toàn cục
        private DateTime DateTimeSystem; 
        public int Status = 0;// Biến trạng thái của Form 0: Tạo, 1: Cập nhật
        public string MaPhieuXuat;
        public ThanhVienDTO thanhVienDTO;
        private int TongCV = 0;
        private bool IsThanhVien = false;

        private void Load_Default()
        {
            //ngay he thong
            DateTimeSystem = DateTime.Now;
            txtNgayBan.Text = DateTimeSystem.ToString("dd/MM/yyyy");
            
            //load nhan vien xuat hang
            txtMaNhanVien.Text = ThongTin.NhanVienDTO.MaNhanVien;
            txtNhanVienBanHang.Text = ThongTin.NhanVienDTO.TenNhanVien;

            //tao ma phieu xuat
            string MaPhieuXuat = "PX" + DateTimeSystem.ToString("yyMMddhhmmss");
            txtMaPhieuXuat.Text = MaPhieuXuat.ToString();
        }

        //Status=0 Load_Default(), thanhphanNhap và DataGripView khi status = 0
        private void Load_Create()
        {
            Load_Default();

            //lamlai thanh phan nhap
            txtMaThanhVien.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtTenKhachHang.ReadOnly = false;
            txtDiaChi.ReadOnly = false;

            //Load Datagripview
            int stt = 1;
            List<SanPhamDTO> listSanPhamDTO = SanPhamBUS.SelectSanPhamAll();
            if (listSanPhamDTO != null)
            {
                dataGridView_XuatHang.Rows.Clear();
                SanPhamDTO sanPhamDTO = new SanPhamDTO();
                for (int i = 0; i < listSanPhamDTO.Count; i++)
                {
                    sanPhamDTO = listSanPhamDTO[i];
                    dataGridView_XuatHang.Rows.Add(stt, sanPhamDTO.MaSanPham, sanPhamDTO.TenSanPham, sanPhamDTO.CV, sanPhamDTO.DonGia, sanPhamDTO.SoLuongTon, 0, 0);
                    stt++;
                }
            }
            btnTao.Enabled = false;
        }

        //Load khi status =1
        //Chuyen sang trang thai cho XemChiTiet phieuxuat
        private void Load_Update()
        {
            //Load_Default();

            //Load Thong tin PhieuXuat
            PhieuXuatDTO phieuXuatDTO = PhieuXuatBUS.SelectPhieuXuatById(MaPhieuXuat);
            txtMaPhieuXuat.Text = phieuXuatDTO.MaPhieuXuat;
            if (phieuXuatDTO.MaThanhVien != "")
            {
                txtMaThanhVien.Text = phieuXuatDTO.MaThanhVien;
                txtMaThanhVien.ReadOnly = true;
            }
            else
            {
                txtTenKhachHang.Text = phieuXuatDTO.TenKhachHang;
                txtDiaChi.Text = phieuXuatDTO.DiaChi;
            }

            txtNgayBan.Text = phieuXuatDTO.NgayBan.ToString("dd/MM/yyyy");
            txtMaNhanVien.Text = phieuXuatDTO.MaNhanVien;
            txtNhanVienBanHang.Text = NhanVienBUS.SelectNhanVienById(phieuXuatDTO.MaNhanVien).TenNhanVien;


            

            //Thay đổi button Tạo thành Cập nhật
            btnTao.Text = "Cập nhật";
            btnTao.Enabled = true;

            btnTaoMoi.Visible = false;
            btnLamLai.Visible = false;
            btnTimPhieuXuat.Visible = false;

            //Truy vấn lấy ChiTietPhieuXuat theo MaDonHang
            List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
            listChiTietPhieuXuatDTO = ChiTietPhieuXuatBUS.SelectChiTietPhieuXuatByMaPhieuXuat(MaPhieuXuat);
            
           

            //Lấy tên sản phẩm
            SanPhamDTO sanphamDTO = new SanPhamDTO();
            for (int i = 0; i < listChiTietPhieuXuatDTO.Count; i++)
            {
                sanphamDTO = SanPhamBUS.SelectSanPhamById(listChiTietPhieuXuatDTO[i].MaSanPham);
                dataGridView_XuatHang.Rows.Add(i + 1, listChiTietPhieuXuatDTO[i].MaSanPham, sanphamDTO.TenSanPham, listChiTietPhieuXuatDTO[i].CV, listChiTietPhieuXuatDTO[i].DonGia, sanphamDTO.SoLuongTon, listChiTietPhieuXuatDTO[i].SoLuong,string.Format("{0:#,0.##}",listChiTietPhieuXuatDTO[i].ThanhTien) );
                dataGridView_XuatHang.Rows[i].ReadOnly = true;
            }
            dataGridView_XuatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            /*
             * //Thay đổi button Làm lại thành Hủy
            btnLamLai.Text = "Hủy";

            //Thay đổi button Tạo mới thành Xong
            btnTaoMoi.Text = "Xong";

            //Ẩn button Tìm phiếu xuất
            btnTimPhieuXuat.Visible = false;

            //Ẩn button Thoát
            btnThoat.Visible = false;

            //Ẩn button Thoát
            btnThoat.Visible = false;

            //Nhận Mã Phiếu Xuất từ Quản lý phiếu xuất
            PhieuXuatDTO phieuXuatDTO = new PhieuXuatDTO();
            phieuXuatDTO.MaPhieuXuat = MaPhieuXuat;

            //Truy vấn lấy ra Chi Tiết Phiếu Xuất theo Mã đơn hàng
            List<ChiTietPhieuXuatDTO> listChiPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
            listChiPhieuXuatDTO = ChiTietPhieuXuatBUS.SelectChiTietPhieuXuatByMaPhieuXuat(phieuXuatDTO.MaPhieuXuat.ToString());

            //Lấy Tên sản phẩm 
            for (int i = 0; i < listChiPhieuXuatDTO.Count; i++)
            {
                dataGridView_XuatHang.Rows.Add(i + 1, listChiPhieuXuatDTO[i].MaSanPham, SanPhamBUS.SelectSanPhamById(listChiPhieuXuatDTO[i].MaSanPham).TenSanPham, listChiPhieuXuatDTO[i].CV, listChiPhieuXuatDTO[i].DonGia, listChiPhieuXuatDTO[i].SoLuong, listChiPhieuXuatDTO[i].ThanhTien);
            }*/
        }
        /*Kiểm tra la ThanhVien
         * */
        private void txtMaThanhVien_Leave(object sender, EventArgs e)
        {/*
            thanhVienDTO = new ThanhVienDTO();
            if (txtMaThanhVien.TextLength == 5 && ThanhVienBUS.SelectThanhVienById(txtMaThanhVien.Text) != null)
            {
                thanhVienDTO = ThanhVienBUS.SelectThanhVienById(txtMaThanhVien.Text);
                txtTenKhachHang.Text = thanhVienDTO.TenThanhVien;
                txtDiaChi.Text = thanhVienDTO.DiaChi;
                txtTenKhachHang.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                IsThanhVien = true;
            }
            else
            {
                MessageBox.Show("Thành viên này không tồn tại");
                IsThanhVien = false;
            }*/
        }
       
        private void FormXuatHang_Load(object sender, EventArgs e)
        {
            //Load panel YesNo(hien tai dang an)
            panelYesNo.Location = new Point(16, 412);
            if (Status == 0 || Status == 4)
            {
                Load_Create();
            }
            else if (Status == 1)//????
            {
                btnTao.Text = "Cập nhật";
                Load_Update();
            }
            else
            {
                Load_Update();
                Update();
            }
        }
        
        // kiểm tra tồn tại dòng có thành tiền khác 0
        /*private bool CheckDataOn_Row_DataGriView(DataGridView data)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataGridViewRow Row = data.Rows[i];
                if (int.Parse(Row.Cells["clThanhTien"].Value.ToString()) > 0)
                {
                    return true;
                }
            }
            return false;
        }*/

        private bool Process_Button()
        {
            //Lấy các trường để insert vào bảng PhieuXuat
            PhieuXuatDTO phieuXuatDTO = new PhieuXuatDTO();
            phieuXuatDTO.MaPhieuXuat = txtMaPhieuXuat.Text;
            phieuXuatDTO.NgayBan = DateTimeSystem;
            phieuXuatDTO.MaNhanVien = ThongTin.NhanVienDTO.MaNhanVien;
            
            if (txtMaThanhVien.Text == "")
            {
                //MaThanhVien Thamchieu bang ThanhVien => notnull=>sua storeproc
                phieuXuatDTO.MaThanhVien = null;

                if (txtTenKhachHang.Text == "")
                {
                    MessageBox.Show("Tên khách hàng không hợp lệ");
                    return false ;
                }
                else
                {
                    phieuXuatDTO.TenKhachHang = txtTenKhachHang.Text;
                }

                if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Địa chỉ không hợp lệ");
                    return false;
                }
                else
                {
                    phieuXuatDTO.DiaChi = txtDiaChi.Text;
                }
                phieuXuatDTO.MaLoaiPhieuXuat = "LPX02";
            }
            else
            {
                phieuXuatDTO.MaThanhVien = txtMaThanhVien.Text;
                phieuXuatDTO.TenKhachHang = txtTenKhachHang.Text;
                phieuXuatDTO.DiaChi = txtDiaChi.Text;
                phieuXuatDTO.MaLoaiPhieuXuat = "LPX01";
            }

            //Lấy các trường để insert vào bảng ChiTietPhieuXuat
            List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
            SanPhamDTO sanPhamDTO = new SanPhamDTO();
            for (int i = 0; i < dataGridView_XuatHang.Rows.Count; i++)
            {
                ChiTietPhieuXuatDTO chiTietPhieuXuatDTO = new ChiTietPhieuXuatDTO();
                DataGridViewRow Row = dataGridView_XuatHang.Rows[i];
                int check;
                int.TryParse(Row.Cells["clSoLuong"].Value.ToString(),out check);
                if (check > 0)
                {
                    chiTietPhieuXuatDTO.MaChiTietPhieuXuat = txtMaPhieuXuat.Text;
                    if (i > 100)
                    {
                        chiTietPhieuXuatDTO.MaChiTietPhieuXuat += (i + 1).ToString();
                    }
                    else if (i > 100)
                    {
                        chiTietPhieuXuatDTO.MaChiTietPhieuXuat += "0" + (i + 1).ToString();
                    }
                    else
                    {
                        chiTietPhieuXuatDTO.MaChiTietPhieuXuat += "00" + (i + 1).ToString();
                    }

                    chiTietPhieuXuatDTO.MaPhieuXuat = txtMaPhieuXuat.Text;
                    chiTietPhieuXuatDTO.MaSanPham = Row.Cells["clMaSanPham"].Value.ToString();
                    chiTietPhieuXuatDTO.CV = int.Parse(Row.Cells["clCV"].Value.ToString());
                    chiTietPhieuXuatDTO.SoLuong = int.Parse(Row.Cells["clSoLuong"].Value.ToString());
                    chiTietPhieuXuatDTO.DonGia = float.Parse(Row.Cells["clDonGia"].Value.ToString());
                    chiTietPhieuXuatDTO.ThanhTien = float.Parse(Row.Cells["clThanhTien"].Value.ToString());
                    listChiTietPhieuXuatDTO.Add(chiTietPhieuXuatDTO);

                    //Tinh SoLuongTon của sản phẩm
                    int SoLuongTon = int.Parse(Row.Cells["clSoLuongTon"].Value.ToString()) - int.Parse(Row.Cells["clSoLuong"].Value.ToString());
                    sanPhamDTO = SanPhamBUS.SelectSanPhamById(chiTietPhieuXuatDTO.MaSanPham);
                    sanPhamDTO.SoLuongTon = SoLuongTon;
                    SanPhamBUS.UpdateSanPhamById(sanPhamDTO);

                    //Tinh TongCV
                    TongCV += int.Parse(Row.Cells["clCV"].Value.ToString()) * int.Parse(Row.Cells["clSoLuong"].Value.ToString());
                }
            }

            //insert dữ liệu
            if (PhieuXuatBUS.InsertPhieuXuat(phieuXuatDTO))
            {
                foreach (ChiTietPhieuXuatDTO chiTietPhieuXuatDTO in listChiTietPhieuXuatDTO)
                {
                    ChiTietPhieuXuatBUS.InsertChiTietPhieuXuat(chiTietPhieuXuatDTO);
                }
                if (IsThanhVien == true)
                {
                    thanhVienDTO.CV += TongCV;
                    ThanhVienBUS.UpdateThanhVienById(thanhVienDTO);
                }

                MessageBox.Show("Nhập dữ liệu thành công");
                return true;
            }
            else
            {
                MessageBox.Show("Nhập dữ liệu thất bại");
            }
            return false;
        }

        //Thay đổi FormXuatHang khi Status =2 
        //ẩn hiện panelYesNo vs PanelChucNang, cho phép người dùng Sửa PhieuXuat
        private void Update()
        {
            panelYesNo.Visible = true;
            panelYesNo.Parent = this;
            panelChucNang.Visible = false;
            dataGridView_XuatHang.SelectionMode = DataGridViewSelectionMode.CellSelect;
            for (int i = 0; i < dataGridView_XuatHang.RowCount; i++)
            {
                dataGridView_XuatHang.Rows[i].ReadOnly = false;
            }
            Status = 2;
            dataGridView_XuatHang.CurrentCell=dataGridView_XuatHang.Rows[0].Cells[clSoLuong.Index];
            dataGridView_XuatHang.CurrentCell.Selected = true;
            dataGridView_XuatHang.BeginEdit(true);
        }

        //Thực thi khi button Làm Lại có status = 0: reset thanhphanNhap,clSoLuong,clThanhTien
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            if (Status == 0)
            {
                //lamlai thanh phan nhap
                txtMaThanhVien.Clear();
                txtTenKhachHang.Clear();
                txtDiaChi.Clear();
                txtTenKhachHang.ReadOnly = false;
                txtDiaChi.ReadOnly = false;

                //lamlai Datagripview
                for (int i = 0; i < dataGridView_XuatHang.Rows.Count; i++)
                {
                    dataGridView_XuatHang.Rows[i].Cells["clSoLuong"].Value = 0;
                    dataGridView_XuatHang.Rows[i].Cells["clThanhTien"].Value = 0;
                }
                return;
            }
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //Bắt sự kiện thay đổi dữ liệu liên quan đến số lượng
        private void dataGridView_XuatHang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView_XuatHang.CurrentCellAddress.X == dataGridView_XuatHang.Columns[6].DisplayIndex)
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
            TextBox txt = sender as TextBox;
            if (txt.Name == "clSoLuong")
            {
                //Là các ký số hoặc điều khiển
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

        private void dataGridView_XuatHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            btnTao.Enabled = true;
            float thanhtien = 0;
            int SoLuong = 0;
            float DonGia;

            //xử lý clSoLuong là null
            if (dataGridView_XuatHang.CurrentRow.Cells[e.ColumnIndex].Value == null)
            {
                dataGridView_XuatHang.CurrentRow.Cells[e.ColumnIndex].Value = 0;
            }

            //xử lý clSoLuong > clSoLuongTon
            else if (int.Parse(dataGridView_XuatHang.CurrentRow.Cells[e.ColumnIndex].Value.ToString()) > int.Parse(dataGridView_XuatHang.CurrentRow.Cells[e.ColumnIndex - 1].Value.ToString()))
            {
                MessageBox.Show("Số lượng sản phẩm không được vượt quá số lượng tồn");
                dataGridView_XuatHang.CurrentRow.Cells[e.ColumnIndex].Value = 0;
            }
            else
            {
                SoLuong = int.Parse(dataGridView_XuatHang.CurrentRow.Cells[e.ColumnIndex].Value.ToString());
            }
            DonGia = float.Parse(dataGridView_XuatHang.CurrentRow.Cells[e.ColumnIndex - 2].Value.ToString());
            
            
            if (SoLuong > 0)
            {
                thanhtien = SoLuong * DonGia;
            }
            dataGridView_XuatHang.CurrentRow.Cells[e.ColumnIndex + 1].Value = string.Format("{0:#,0.##}",thanhtien);
        }

        //Kiem tra datagripview co tồn tại dòng có clSoLuong !=0 không
        private bool CheckOut_clSoLuong(DataGridView data)
        {
            for(int i=0;i<data.Rows.Count;i++)
            {
                if (int.Parse(data.Rows[i].Cells["clSoLuong"].Value.ToString()) > 0)
                {
                    return true;
                }             
            }
            return false;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (Status == 0 || Status == 4)
            {
                if (CheckOut_clSoLuong(dataGridView_XuatHang))
                {
                    if (Process_Button() == true)
                    {
                        dataGridView_XuatHang.Rows.Clear();
                        FormXuatHang_Load(sender, e);

                    }
                }
                else
                {
                    dataGridView_XuatHang.CurrentCell = dataGridView_XuatHang.Rows[0].Cells[clSoLuong.Index];
                    dataGridView_XuatHang.CurrentCell.Selected = true;
                    dataGridView_XuatHang.BeginEdit(true);
                    MessageBox.Show("Phiếu xuất không hợp lệ, tất cả số lượng sản phẩm đều bằng không","Phiếu xuất");
                }
            }
            else
            {
                Update();
            }
            
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (Status == 0 || Status == 4)
            {
                if (btnTao.Enabled == true)
                {
                    DialogResult result = MessageBox.Show("Bạn Muốn Lưu Đơn Hàng Không:", "Đơn hàng", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        btnTao_Click(sender, e);
                    }
                    else if (result == DialogResult.No)
                    {
                        dataGridView_XuatHang.Rows.Clear();
                        FormXuatHang_Load(sender, e);
                    }
                    else if (Status == 4)
                    {
                        dataGridView_XuatHang.Rows.Clear();
                        FormXuatHang_Load(sender, e);
                    }
                    return;
                }
                else
                {
                    dataGridView_XuatHang.Rows.Clear();
                    FormXuatHang_Load(sender, e);
                }
            }
            else
            {
                Close();
            }
        }
        
        //Chuyen sang quan ly phieu xuat
        private void btnTimPhieuXuat_Click(object sender, EventArgs e)
        {
            Form frm = ThongTin.KiemTraTonTai(typeof(FormQuanLyXuatHang), this.ParentForm);
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormQuanLyXuatHang fQLXuatHang = new FormQuanLyXuatHang();
                fQLXuatHang.MdiParent = this.ParentForm;
                fQLXuatHang.Show();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //Cập nhật lại phiếu xuất
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (CheckOut_clSoLuong(dataGridView_XuatHang))
            {
                List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
                listChiTietPhieuXuatDTO = ChiTietPhieuXuatBUS.SelectChiTietPhieuXuatByMaPhieuXuat(MaPhieuXuat);

                int cv = 0;
                int cv2 = 0;
                int SoLuongTon = 0;
                SanPhamDTO sanPhamDTO = new SanPhamDTO();
                for (int i = 0; i < listChiTietPhieuXuatDTO.Count; i++)
                {

                    //Tính lại SoLuongTon của sản phẩm
                    SoLuongTon = listChiTietPhieuXuatDTO[i].SoLuong - int.Parse(dataGridView_XuatHang.Rows[i].Cells["clSoLuong"].Value.ToString());
                    sanPhamDTO = SanPhamBUS.SelectSanPhamById(listChiTietPhieuXuatDTO[i].MaSanPham);
                    sanPhamDTO.SoLuongTon += SoLuongTon;
                    SanPhamBUS.UpdateSanPhamById(sanPhamDTO);

                   //cv
                    cv2 += int.Parse(dataGridView_XuatHang.Rows[i].Cells["clSoLuong"].Value.ToString()) * int.Parse(dataGridView_XuatHang.Rows[i].Cells[clCV.Index].Value.ToString());
                    cv += listChiTietPhieuXuatDTO[i].CV * listChiTietPhieuXuatDTO[i].SoLuong;

                    listChiTietPhieuXuatDTO[i].SoLuong = int.Parse(dataGridView_XuatHang.Rows[i].Cells["clSoLuong"].Value.ToString());
                    listChiTietPhieuXuatDTO[i].ThanhTien = float.Parse(dataGridView_XuatHang.Rows[i].Cells["clThanhTien"].Value.ToString());
                    ChiTietPhieuXuatBUS.UpdateChiTietPhieuXuatById(listChiTietPhieuXuatDTO[i]);

                }

                //Tinh lai TongCV
                if (IsThanhVien == true)
                {
                    this.thanhVienDTO.CV = this.thanhVienDTO.CV - cv + cv2;
                    ThanhVienBUS.UpdateThanhVienById(this.thanhVienDTO);
                }
                MessageBox.Show("Cập nhật thành công", "Cập nhật đơn hàng");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Phiếu xuất không hợp lệ, tất cả số lượng sản phẩm đều bằng không", "Phiếu xuất");
                dataGridView_XuatHang.CurrentCell = dataGridView_XuatHang.Rows[0].Cells[clSoLuong.Index];
                dataGridView_XuatHang.CurrentCell.Selected = true;
                dataGridView_XuatHang.BeginEdit(true);
            }
        }

        private void FormXuatHang_Activated(object sender, EventArgs e)
        {
            if (Status == 4)
            {
                btnTaoMoi_Click(sender, e);
            }
        }

        private void txtMaThanhVien_TextChanged(object sender, EventArgs e)
        {
           
                thanhVienDTO = new ThanhVienDTO();
                if (ThanhVienBUS.SelectThanhVienById(txtMaThanhVien.Text) != null)
                {
                    thanhVienDTO = ThanhVienBUS.SelectThanhVienById(txtMaThanhVien.Text);
                    txtTenKhachHang.Text = thanhVienDTO.TenThanhVien;
                    txtDiaChi.Text = thanhVienDTO.DiaChi;
                    txtTenKhachHang.ReadOnly = true;
                    txtDiaChi.ReadOnly = true;
                    IsThanhVien = true;
                }
                else
                {
                    txtTenKhachHang.Text = "";
                    txtDiaChi.Text = "";
                    txtTenKhachHang.ReadOnly = false;
                    txtDiaChi.ReadOnly = false;
                    IsThanhVien = false;
                }
            
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "")
            {
                btnTao.Enabled = false;
            }
            else
            {
                btnTao.Enabled = true;
                if (txtMaThanhVien.Focused == false && Status == 0)
                {
                    txtMaThanhVien.Text = "";
                }
            }
        }

    }
}
