using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormQuanLyXuatHang : Form
    {
        public FormQuanLyXuatHang()
        {
            InitializeComponent();
        }


        private bool boolTu = false;
        private bool boolDen = false;

        private void buttonEnabled()
        {
            btnXemChiTiet.Enabled = true;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void buttonDisabled()
        {
            btnXemChiTiet.Enabled = false;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void KhoiTao()
        {
            List<PhieuXuatDTO> listPhieuXuatDTO = PhieuXuatBUS.SelectPhieuXuatAll();
            List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
            int soLuong = 0;
            float thanhTien = 0;
            if (listPhieuXuatDTO != null)
            {
                dataGridView_TraCuuXuatHang.Rows.Clear();
                PhieuXuatDTO phieuXuatDTO = new PhieuXuatDTO();
                for (int i = 0; i < listPhieuXuatDTO.Count; i++)
                {
                    phieuXuatDTO = listPhieuXuatDTO[i];
                    listChiTietPhieuXuatDTO = ChiTietPhieuXuatBUS.SelectChiTietPhieuXuatByMaPhieuXuat(phieuXuatDTO.MaPhieuXuat);
                    if (listChiTietPhieuXuatDTO != null)
                    {
                        for (int j = 0; j < listChiTietPhieuXuatDTO.Count; j++)
                        {
                            soLuong += listChiTietPhieuXuatDTO[j].SoLuong;
                            thanhTien += listChiTietPhieuXuatDTO[j].ThanhTien;
                        }
                    }

                    dataGridView_TraCuuXuatHang.Rows.Add(
                        (i + 1).ToString(),
                        phieuXuatDTO.MaPhieuXuat,
                        phieuXuatDTO.NgayBan.ToString("dd/MM/yyyy"),
                        phieuXuatDTO.TenKhachHang,
                        NhanVienBUS.SelectNhanVienById(phieuXuatDTO.MaNhanVien).TenNhanVien,
                        soLuong.ToString(),
                        string.Format("{0:0,0.##}", thanhTien));
                }
                btnLamLai.Enabled = true;
            }
            else
            {
                buttonDisabled();
                btnLamLai.Enabled = false;
            }
        }

        
        //true nếu không tồn tại, ngược lại  tồn tại
        private bool KiemTraDong_KhongTonTai()
        {
            for (int i = 0; i < dataGridView_TraCuuXuatHang.Rows.Count; i++)
            {
                if (dataGridView_TraCuuXuatHang.Rows[i].Visible)
                {
                    return false;
                }
            }
            return true;
        }

        private void Search()
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

            int stt = 0;
            for (int i = 0; i < dataGridView_TraCuuXuatHang.RowCount;i++)
            {
                string[] chuoi = dataGridView_TraCuuXuatHang.Rows[i].Cells["clNgayBanHang"].Value.ToString().Split('/');
                dateHienTai = new DateTime(int.Parse(chuoi[2]), int.Parse(chuoi[1]), int.Parse(chuoi[0])).Date;
                dataGridView_TraCuuXuatHang.Rows[i].Visible = false;
                int vt = -1;
                if (dataGridView_TraCuuXuatHang.Rows[i].Cells["clMaPhieuXuat"].Value.ToString().ToUpper().IndexOf(txtMaPhieuXuat.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuXuatHang.Rows[i].Cells["clNguoiBan"].Value.ToString().ToUpper().IndexOf(txtNguoiBan.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuXuatHang.Rows[i].Cells["clNguoiMua"].Value.ToString().ToUpper().IndexOf(txtNguoiMua.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuXuatHang.Rows[i].Cells["clSoLuong"].Value.ToString().ToUpper().IndexOf(txtSoLuong.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuXuatHang.Rows[i].Cells["clSoTien"].Value.ToString().ToUpper().IndexOf(txtSoTien.Text.ToString().ToUpper()) >= 0)
                {
                    stt++;
                    dataGridView_TraCuuXuatHang.Rows[i].Visible = true;
                    dataGridView_TraCuuXuatHang.Rows[i].Cells["clSTT"].Value = stt.ToString();
                    vt = i;
                }
                if (vt == -1)
                {
                    buttonDisabled();
                }
                else
                {
                    buttonEnabled();
                    dataGridView_TraCuuXuatHang.CurrentCell = dataGridView_TraCuuXuatHang.Rows[vt].Cells[0]; // QUAN TRONG  
                    dataGridView_TraCuuXuatHang.CurrentCell.Selected = true;     // QUAN TRONG  
                }
            }
        }
        
        private void FormQuanLyXuatHang_Load(object sender, EventArgs e)
        {
            KhoiTao();
        }

        private void txtMaPhieuXuat_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtNguoiMua_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtNguoiBan_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dateTimePickerTu_ValueChanged(object sender, EventArgs e)
        {
            boolTu = true;
            Search();//
            boolTu = false;
        }

        private void dateTimePickerDen_ValueChanged(object sender, EventArgs e)
        {
            boolDen = true;
            Search();
            boolDen = false;
        }

        private void Clear_ThanhPhanNhap()
        {
            txtMaPhieuXuat.Clear();
            txtNguoiMua.Clear();
            txtNguoiBan.Clear();
            txtSoLuong.Clear();
            txtSoTien.Clear();
        }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            dateTimePickerTu.Value = DateTime.Now;
            dateTimePickerDen.Value = DateTime.Now;
            Clear_ThanhPhanNhap();
            if (dataGridView_TraCuuXuatHang.RowCount > 0)
            {
                dataGridView_TraCuuXuatHang.CurrentCell = dataGridView_TraCuuXuatHang.Rows[0].Cells[0];
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            /*int dem = 0;
            for (int i = 0; i < dataGridView_TraCuuXuatHang.Rows.Count; i++)
            {
                if (dataGridView_TraCuuXuatHang.Rows[i].Visible == true)
                    dem++;
            }
            if (dem == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Quản lý xuất hàng");
            }
            else
            {
                FormXuatHang fQLXuatHang = new FormXuatHang();
                fQLXuatHang.MaPhieuXuat = dataGridView_TraCuuXuatHang.CurrentRow.Cells["clMaPhieuXuat"].Value.ToString();
                fQLXuatHang.Status = 1;
                fQLXuatHang.ShowDialog();
            }*/
            
            if (KiemTraDong_KhongTonTai() == false)
            {
                FormXuatHang fQLXuatHang = new FormXuatHang();
                fQLXuatHang.MaPhieuXuat = dataGridView_TraCuuXuatHang.CurrentRow.Cells["clMaPhieuXuat"].Value.ToString();
                fQLXuatHang.Status = 1;
                fQLXuatHang.ShowDialog();
                if (fQLXuatHang.Status == 2)
                {
                    PhieuXuatDTO phieuXuatDTO = PhieuXuatBUS.SelectPhieuXuatById(fQLXuatHang.MaPhieuXuat);

                    int soLuong = 0;
                    float thanhTien = 0;
                    List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
                    listChiTietPhieuXuatDTO = ChiTietPhieuXuatBUS.SelectChiTietPhieuXuatByMaPhieuXuat(phieuXuatDTO.MaPhieuXuat);
                    if (listChiTietPhieuXuatDTO != null)
                    {
                        for (int j = 0; j < listChiTietPhieuXuatDTO.Count; j++)
                        {
                            soLuong += listChiTietPhieuXuatDTO[j].SoLuong;
                            thanhTien += listChiTietPhieuXuatDTO[j].ThanhTien;
                        }
                    }
                    dataGridView_TraCuuXuatHang.CurrentRow.Cells[clSoLuong.Index].Value = soLuong;
                    dataGridView_TraCuuXuatHang.CurrentRow.Cells[clSoTien.Index].Value = string.Format("{0:#,0.##}",thanhTien);
                }
                
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Quản lý xuất hàng");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            /*int dem = 0;
            for (int i = 0; i < dataGridView_TraCuuXuatHang.Rows.Count; i++)
            {
                if (dataGridView_TraCuuXuatHang.Rows[i].Visible == true)
                    dem++;
            }
            if (dem == 0)
            {
                MessageBox.Show("Không có dữ liệu để cập nhật", "Quản lý xuất hàng");
               */ /*
                 * txtMaPhieuXuat.Clear();
                txtNguoiMua.Clear();
                txtNguoiBan.Clear();
                txtSoLuong.Clear();
                txtSoTien.Clear();
                */
            /*}
            else
            {
                FormXuatHang fQLXuatHang = new FormXuatHang();
                fQLXuatHang.Status = 2;
                fQLXuatHang.MaPhieuXuat = dataGridView_TraCuuXuatHang.CurrentRow.Cells[clMaPhieuXuat.Index].Value.ToString();
                fQLXuatHang.ShowDialog();
            }*/
            if (KiemTraDong_KhongTonTai() == false)
            {
                FormXuatHang fQLXuatHang = new FormXuatHang();
                fQLXuatHang.Status = 2;
                fQLXuatHang.MaPhieuXuat = dataGridView_TraCuuXuatHang.CurrentRow.Cells[clMaPhieuXuat.Index].Value.ToString();
                fQLXuatHang.ShowDialog();
                
                PhieuXuatDTO phieuXuatDTO = PhieuXuatBUS.SelectPhieuXuatById(fQLXuatHang.MaPhieuXuat);
                int soLuong = 0;
                float thanhTien = 0;
                List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
                listChiTietPhieuXuatDTO = ChiTietPhieuXuatBUS.SelectChiTietPhieuXuatByMaPhieuXuat(phieuXuatDTO.MaPhieuXuat);
                if (listChiTietPhieuXuatDTO != null)
                {
                    for (int j = 0; j < listChiTietPhieuXuatDTO.Count; j++)
                    {
                        soLuong += listChiTietPhieuXuatDTO[j].SoLuong;
                        thanhTien += listChiTietPhieuXuatDTO[j].ThanhTien;
                    }
                }

                dataGridView_TraCuuXuatHang.CurrentRow.Cells[clSoLuong.Index].Value = soLuong;
                dataGridView_TraCuuXuatHang.CurrentRow.Cells[clSoTien.Index].Value = string.Format("{0:#,0.##}", thanhTien);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để cập nhật", "Quản lý xuất hàng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {    
            /*int dem = 0;
            for (int i = 0; i < dataGridView_TraCuuXuatHang.Rows.Count; i++)
            {
                if (dataGridView_TraCuuXuatHang.Rows[i].Visible == true)
                    dem++;
            }
            if (dem == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa");
            }
            if(KiemTraDong_KhongTonTai() == true)
            {
                MessageBox.Show("Không có dữ liệu để xóa");
            }
            else
            {*/
            DialogResult result = MessageBox.Show("Xóa phiếu xuất", "Phiếu xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (result == DialogResult.Yes)
            {
                int Index = dataGridView_TraCuuXuatHang.CurrentRow.Index;//LOI
                string id = dataGridView_TraCuuXuatHang.CurrentRow.Cells["clMaPhieuXuat"].Value.ToString();
                if (PhieuXuatBUS.DeletePhieuXuatById(id))
                {
                    dataGridView_TraCuuXuatHang.Rows.RemoveAt(Index);
                    if (dataGridView_TraCuuXuatHang.RowCount > 0)
                    {
                        for (int i = Index; i < dataGridView_TraCuuXuatHang.RowCount; i++)
                        {
                            dataGridView_TraCuuXuatHang.Rows[i].Cells["clSTT"].Value = (i + 1).ToString();
                        }
                    }
                    else
                    {
                        buttonDisabled();
                    }
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            Form frm = ThongTin.KiemTraTonTai(typeof(FormXuatHang), this.ParentForm);
            if (frm != null)
            {
                FormXuatHang f = (FormXuatHang)frm;
                f.Status = 4;
                f.Activate();
            }
            else
            {
                FormXuatHang fQLXuatHang = new FormXuatHang();
                fQLXuatHang.MdiParent = this.ParentForm;
                fQLXuatHang.Show();
            }
        }

        private void FormQuanLyXuatHang_Activated(object sender, EventArgs e)
        {
            FormQuanLyXuatHang_Load(sender, e);
            btnLamLai_Click(sender, e);
        }

       
    }
}
