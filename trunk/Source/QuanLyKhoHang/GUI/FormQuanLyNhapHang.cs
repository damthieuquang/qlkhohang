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
    public partial class FormQuanLyNhapHang : Form
    {
        public FormQuanLyNhapHang()
        {
            InitializeComponent();
        }
        private bool boolTu = false;
        private bool boolDen = false;
        private void KhoiTao()
        {
            int stt = 1;
            List<PhieuNhapDTO> listPhieuNhapDTO = PhieuNhapBUS.SelectPhieuNhapAll();
            if (listPhieuNhapDTO != null)
            {
                dataGridView_TraCuuNhapHang.Rows.Clear();
                PhieuNhapDTO item = new PhieuNhapDTO();
                ChiTietPhieuNhapDTO item1 = new ChiTietPhieuNhapDTO();
                for (int i = 0; i < listPhieuNhapDTO.Count; i++)
                {
                    item = listPhieuNhapDTO[i];
                    DonHangDTO donHangDTO = DonHangBUS.SelectDonHangById(item.MaDonHang);
                    List<ChiTietPhieuNhapDTO> listChiTietPhieuNhapDTO = ChiTietPhieuNhapBUS.SelectChiTietPhieuNhapByMaPhieuNhap(item.MaPhieuNhap);
                    
                    for (int j = 0; j < listChiTietPhieuNhapDTO.Count;j++ )
                    {
                        item1 = listChiTietPhieuNhapDTO[j];
                        dataGridView_TraCuuNhapHang.Rows.Add(
                            (stt++).ToString(),
                            item.MaPhieuNhap,
                           donHangDTO.NgayLap.ToString("dd/MM/yyy"),
                           item.NgayNhan.ToString("dd/MM/yyy"),
                            NhanVienBUS.SelectNhanVienById(item.MaNhanVien).TenNhanVien, item1.SLNhan);
                    }
                    
                }
            }
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
            for (int i = 0; i < dataGridView_TraCuuNhapHang.RowCount; i++)
            {
                string[] chuoi = dataGridView_TraCuuNhapHang.Rows[i].Cells["clNgayDat"].Value.ToString().Split('/');
                dateHienTai = new DateTime(int.Parse(chuoi[2]), int.Parse(chuoi[1]), int.Parse(chuoi[0])).Date;
                dataGridView_TraCuuNhapHang.Rows[i].Visible = false;
                if (dataGridView_TraCuuNhapHang.Rows[i].Cells["clMaPhieuNhap"].Value.ToString().ToUpper().IndexOf(txtMaPhieuNhap.Text.ToString().ToUpper()) >= 0
                    && dateTu.CompareTo(dateHienTai) <= 0 && dateDen.CompareTo(dateHienTai) >= 0
                   )
                {
                    stt++;
                    dataGridView_TraCuuNhapHang.Rows[i].Visible = true;
                    dataGridView_TraCuuNhapHang.Rows[i].Cells["clSTT"].Value = stt.ToString();
                }
            }
        }

        private void FormQuanLyNhapHang_Load(object sender, EventArgs e)
        {
            KhoiTao();
        }
        private void dateTimePickerTu_ValueChanged(object sender, EventArgs e)
        {
            boolTu = true;
            Search();
            boolTu = false;
        }

        private void dateTimePickerDen_ValueChanged(object sender, EventArgs e)
        {
            boolDen = true;
            Search();
            boolDen = false;
        }

        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            dateTimePickerTu.Value = DateTime.Now;
            dateTimePickerDen.Value = DateTime.Now;
            txtMaPhieuNhap = null;
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            FormNhapHang fQLNhapHang = new FormNhapHang();
            fQLNhapHang.MaPhieuNhap = dataGridView_TraCuuNhapHang.CurrentRow.Cells["clMaPhieuNhap"].Value.ToString();
            fQLNhapHang.Status = 1;
            fQLNhapHang.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xóa đơn Nhập Hàng", "Nhập Hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                int Index = dataGridView_TraCuuNhapHang.CurrentRow.Index;
                string id = dataGridView_TraCuuNhapHang.CurrentRow.Cells["clMaPhieuNhap"].Value.ToString();
                if (PhieuNhapBUS.DeletePhieuNhapByID(id))
                {
                    dataGridView_TraCuuNhapHang.Rows.RemoveAt(Index);
                    for (int i = Index; i < dataGridView_TraCuuNhapHang.RowCount; i++)
                    {
                        dataGridView_TraCuuNhapHang.Rows[i].Cells["clSTT"].Value = (i + 1).ToString();
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridView_TraCuuNhapHang.RowCount > 0)
            {
                FormNhapHang fQLNhapHang = new FormNhapHang();
                fQLNhapHang.MaPhieuNhap = dataGridView_TraCuuNhapHang.CurrentRow.Cells["clMaPhieuNhap"].Value.ToString();
                fQLNhapHang.Status = 1;
                fQLNhapHang.ShowDialog();
            }
            else
            {
                btnCapNhat.Enabled = false;
            }
        }
    }
}
