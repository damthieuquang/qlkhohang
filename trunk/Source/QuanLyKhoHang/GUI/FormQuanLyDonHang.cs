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
    public partial class FormQuanLyDonHang : Form
    {
        public FormQuanLyDonHang()
        {
            InitializeComponent();
        }

          private bool  boolTu = false;
          private bool boolDen = false;
          public bool activeForm = false;

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

          private void KhoiTaoComboBoxTrangThai()
          {
              DataTable dt = new DataTable();
              dt.Columns.Add("text");
              dt.Columns.Add("value");
              dt.Rows.Add("Tất cả", "");
              dt.Rows.Add("Đã nhận", "Đã nhận");
              dt.Rows.Add("Chưa nhận", "Chưa nhận");
              dt.Rows.Add("Nhận một phần", "Nhận một phần");


              comboBoxTrangThai.DisplayMember = "text";
              comboBoxTrangThai.ValueMember = "value";
              comboBoxTrangThai.DataSource = dt;
          }

        private void KhoiTao()
        {
            List<DonHangDTO> listDonHangDTO = DonHangBUS.SelectDonHangAll();
            if (listDonHangDTO != null)
            {
                dataGridView_TraCuuDonHang.Rows.Clear();
                DonHangDTO item = new DonHangDTO();
                for (int i = 0; i < listDonHangDTO.Count; i++)
                {
                    item = listDonHangDTO[i];
                    dataGridView_TraCuuDonHang.Rows.Add(
                        (i + 1).ToString(),
                        item.MaDonHang,
                        item.NgayLap.ToString("dd/MM/yyy"),
                        NhanVienBUS.SelectNhanVienById(item.MaNhanVien).TenNhanVien,
                        string.Format("{0:#,0.##}", item.ThanhTien),
                        item.TrangThai);
                }
                btnLamLai.Enabled = true;
            }
            else
            {
                buttonDisabled();
                btnLamLai.Enabled = false;
            }
        }


        //true nếu không tồn tại, ngược lại tồn tại
        private bool KiemTraDong_KhongTonTai()
        {
            for (int i = 0; i < dataGridView_TraCuuDonHang.Rows.Count; i++)
            {
                if (dataGridView_TraCuuDonHang.Rows[i].Visible)
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
                dateTu = new DateTime(1,1, 1).Date;
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
            int vt = -1;
            for (int i = 0; i < dataGridView_TraCuuDonHang.RowCount; i++)
            {
                string[] chuoi = dataGridView_TraCuuDonHang.Rows[i].Cells["clNgayDat"].Value.ToString().Split('/');
                dateHienTai = new DateTime(int.Parse(chuoi[2]), int.Parse(chuoi[1]), int.Parse(chuoi[0])).Date;
                dataGridView_TraCuuDonHang.Rows[i].Visible = false;

                if (dataGridView_TraCuuDonHang.Rows[i].Cells["clMaDonHang"].Value.ToString().ToUpper().IndexOf(txtMaDonHang.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuDonHang.Rows[i].Cells["clNguoiDat"].Value.ToString().ToUpper().IndexOf(txtNguoiDat.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuDonHang.Rows[i].Cells["clThanhTien"].Value.ToString().ToUpper().IndexOf(txtThanhTien.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuDonHang.Rows[i].Cells["clTrangThai"].Value.ToString().ToUpper().IndexOf(comboBoxTrangThai.SelectedValue.ToString().ToUpper()) >= 0
                    && dateTu.CompareTo(dateHienTai) <= 0 && dateDen.CompareTo(dateHienTai) >= 0
                    && dateTu.CompareTo(dateDen) <=0
                   )
                {
                    stt++;
                    dataGridView_TraCuuDonHang.Rows[i].Visible = true;
                    dataGridView_TraCuuDonHang.Rows[i].Cells["clSTT"].Value = stt.ToString();
                    vt = i;
                    break;
                }
            }

            for (int i = vt + 1; i< dataGridView_TraCuuDonHang.RowCount; i++)
            {
                string[] chuoi = dataGridView_TraCuuDonHang.Rows[i].Cells["clNgayDat"].Value.ToString().Split('/');
                dateHienTai = new DateTime(int.Parse(chuoi[2]), int.Parse(chuoi[1]), int.Parse(chuoi[0])).Date;
                dataGridView_TraCuuDonHang.Rows[i].Visible = false;

              
                if (dataGridView_TraCuuDonHang.Rows[i].Cells["clMaDonHang"].Value.ToString().ToUpper().IndexOf(txtMaDonHang.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuDonHang.Rows[i].Cells["clNguoiDat"].Value.ToString().ToUpper().IndexOf(txtNguoiDat.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuDonHang.Rows[i].Cells["clThanhTien"].Value.ToString().ToUpper().IndexOf(txtThanhTien.Text.ToString().ToUpper()) >= 0
                    && dataGridView_TraCuuDonHang.Rows[i].Cells["clTrangThai"].Value.ToString().ToUpper().IndexOf(comboBoxTrangThai.SelectedValue.ToString().ToUpper()) >= 0
                    && dateTu.CompareTo(dateHienTai) <= 0 && dateDen.CompareTo(dateHienTai) >= 0
                      && dateTu.CompareTo(dateDen) <= 0
                   )
                {
                    stt++;
                    dataGridView_TraCuuDonHang.Rows[i].Visible = true;
                    dataGridView_TraCuuDonHang.Rows[i].Cells["clSTT"].Value = stt.ToString();
                }
            }

            if (vt == -1)
            {
                buttonDisabled();
            }
            else
            {
                buttonEnabled();
                dataGridView_TraCuuDonHang.CurrentCell = dataGridView_TraCuuDonHang.Rows[vt].Cells[0];
                dataGridView_TraCuuDonHang.CurrentCell.Selected = true;
            }
        }

        private void FormQuanLyDonHang_Load(object sender, EventArgs e)
        {
            
            KhoiTao();
            KhoiTaoComboBoxTrangThai();
        }

        private void txtMaDonHang_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtNguoiDat_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void comboBoxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            
            dateTimePickerTu.Value = DateTime.Now;
            boolTu = false;
            dateTimePickerDen.Value = DateTime.Now;
            boolDen = false;  
            comboBoxTrangThai.SelectedIndex = 0;
            txtMaDonHang.Text = null;
            txtNguoiDat.Text = null;
            txtThanhTien.Text = null;
            
            if (dataGridView_TraCuuDonHang.RowCount > 0)
            {
                dataGridView_TraCuuDonHang.CurrentCell = dataGridView_TraCuuDonHang.Rows[0].Cells[0];
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (KiemTraDong_KhongTonTai() == false)
            {
                FormDonHang fQLDonHang = new FormDonHang();
                fQLDonHang.MaDonHang = dataGridView_TraCuuDonHang.CurrentRow.Cells[clMaDonHang.Index].Value.ToString();
                fQLDonHang.Status = 1;
                fQLDonHang.ShowDialog();
                if (fQLDonHang.Status == 2)
                {
                    DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(fQLDonHang.MaDonHang);
                    dataGridView_TraCuuDonHang.CurrentRow.Cells[clThanhTien.Index].Value = string.Format("{0:#,0.##}", donHangDTO.ThanhTien);
                }
                
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Quản lý đơn hàng");
            }                                   
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDong_KhongTonTai() == false)
            {
                if (dataGridView_TraCuuDonHang.CurrentRow.Cells[clTrangThai.Index].Value.ToString() == "Chưa nhận")
                {
                    FormDonHang fQLDonHang = new FormDonHang();
                    fQLDonHang.Status = 2;
                    fQLDonHang.MaDonHang = dataGridView_TraCuuDonHang.CurrentRow.Cells[clMaDonHang.Index].Value.ToString();
                    fQLDonHang.ShowDialog();
                    DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(fQLDonHang.MaDonHang);
                    dataGridView_TraCuuDonHang.CurrentRow.Cells[clThanhTien.Index].Value = string.Format("{0:#,0.##}", donHangDTO.ThanhTien);

                }
                else
                {
                    MessageBox.Show("Đơn hàng đã nhận, không cho phép cập nhật", "Quản lý đơn hàng");
                }
               
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để cập nhật", "Quản lý đơn hàng");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xóa đơn hàng", "Đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                int Index = dataGridView_TraCuuDonHang.CurrentRow.Index;
                string id = dataGridView_TraCuuDonHang.CurrentRow.Cells["clMaDonHang"].Value.ToString();
                if (DonHangBUS.DeleteDonHangById(id))
                {                    
                    dataGridView_TraCuuDonHang.Rows.RemoveAt(Index);
                    if (dataGridView_TraCuuDonHang.RowCount > 0)
                    {
                        for (int i = Index; i < dataGridView_TraCuuDonHang.RowCount; i++)
                        {
                            dataGridView_TraCuuDonHang.Rows[i].Cells["clSTT"].Value = (i + 1).ToString();
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
            this.Close();
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            Form frm = ThongTin.KiemTraTonTai(typeof(FormDonHang), this.ParentForm);
            if (frm != null)
            {
                FormDonHang f = (FormDonHang)frm;
                f.Status = 4;
                f.Activate();
            }
            else
            {
                FormDonHang fQLDonHang = new FormDonHang();
                fQLDonHang.MdiParent = this.ParentForm;
                fQLDonHang.Show();
            }
        }

        private void FormQuanLyDonHang_Activated(object sender, EventArgs e)
        {
            if (activeForm)
            {
                FormQuanLyDonHang_Load(sender, e);
                btnLamLai_Click(sender, e);
            }
        }

    }
}
