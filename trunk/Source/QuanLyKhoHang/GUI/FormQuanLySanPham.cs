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
    public partial class FormQuanLySanPham : Form
    {
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }

        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            panelYesNo.Location = new Point(12, 400);
            KhoiTao();
        }

        //Status = 1: Thêm tham số
        //Status = 2: Cập nhật Tham Số
        //Status = 0: Hoàn thành xử lý
        private int _status;

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        //lưu vị trí dang xu ly
        private int _index;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        //
        private SanPhamDTO _backupSanPhamDTO;

        public SanPhamDTO BackupSanPhamDTO
        {
            get { return _backupSanPhamDTO; }
            set { _backupSanPhamDTO = value; }
        }


        /*
         * Hàm KhoiTao
         * Tải toàn bộ danh sách tham số
        */
        private void KhoiTao()
        {
            List<SanPhamDTO> listSanPhamDTO = SanPhamBUS.SelectSanPhamAll();
            List<LoaiSanPhamDTO> lstcbspDTO = LoaiSanPhamBUS.SelectLoaiSanPhamAll();
            if (lstcbspDTO != null)
            {
                foreach (LoaiSanPhamDTO dtRow in lstcbspDTO)
                {
                    cmbMaLoaiSanPham.Items.Add(dtRow.MaLoaiSanPham);
                }
            }
            cmbMaLoaiSanPham.SelectedItem = null;
            if (listSanPhamDTO != null)
            {
                SanPhamDTO item = new SanPhamDTO();
                dataGridView_QuanLySanPham.Rows.Clear();
                for (int i = 0; i < listSanPhamDTO.Count; i++)
                {
                    item = listSanPhamDTO[i];
                    dataGridView_QuanLySanPham.Rows.Add((i + 1).ToString(), item.MaSanPham, item.TenSanPham, item.CV,item.DonGia, item.DonGiaTV, item.SoLuongTon,item.MaLoaiSanPham);
                    dataGridView_QuanLySanPham.Rows[i].ReadOnly = true;
                }
            }

        }

        /*
        * Hàm Search
        * Lấy các giá trị từ các textbox --> tìm kiếm và cập nhật lại DataGridView
       */
        private void Search()
        {
            int stt = 0;
            for (int i = 0; i < dataGridView_QuanLySanPham.RowCount; i++)
            {
                dataGridView_QuanLySanPham.Rows[i].Visible = false;
                if (dataGridView_QuanLySanPham.Rows[i].Cells["ColMaSanPham"].Value.ToString().ToUpper().IndexOf(textBoxMaSanPham.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLySanPham.Rows[i].Cells["ColTenSanPham"].Value.ToString().ToUpper().IndexOf(textBoxTenSanPham.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLySanPham.Rows[i].Cells["ColCV"].Value.ToString().ToUpper().IndexOf(textBoxCV.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLySanPham.Rows[i].Cells["ColDonGia"].Value.ToString().ToUpper().IndexOf(textBoxDonGia.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLySanPham.Rows[i].Cells["ColDonGiaTV"].Value.ToString().ToUpper().IndexOf(textBoxDonGiaTV.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLySanPham.Rows[i].Cells["ColSoLuongTon"].Value.ToString().ToUpper().IndexOf(textBoxSoLuongTon.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLySanPham.Rows[i].Cells["ColMaLoaiSanPham"].Value.ToString().ToUpper().IndexOf(cmbMaLoaiSanPham.SelectedValue.ToString().ToUpper()) >= 0)
                {
                    stt++;
                    dataGridView_QuanLySanPham.Rows[i].Visible = true;
                    dataGridView_QuanLySanPham.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                }
            }
        }

        /*
          * Hàm Reset
          * Cập nhật lại các thuộc tính ban đầu cho DataGridView và panel 
         */
        private void Reset()
        {
            //Cập nhật lại các giá trị ban đầu cho DataGridView
            dataGridView_QuanLySanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView_QuanLySanPham.Columns["ColSTT"].Visible = true;
            dataGridView_QuanLySanPham.Columns["ColMaSanPham"].Visible = true;


            //Cập nhật lại các giá trị ban đầu cho Pannel
            panelYesNo.Visible = false;
            groupBoxTimKiem.Visible = true;
            groupBoxDSThamSo.Text = "Danh sách sản phẩm";

            Status = 0;
            Index = -1;

            for (int i = 0; i < dataGridView_QuanLySanPham.RowCount; i++)
            {
                dataGridView_QuanLySanPham.Rows[i].Visible = true;
            }

            dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[0].Cells[0];
        }




        private void textBoxTenSanPham_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxMaSanPham_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

       

        
        

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            int i;
            //Ẩn các dòng không cần thiết
            for (i = 0; i < dataGridView_QuanLySanPham.RowCount; i++)
            {
                dataGridView_QuanLySanPham.Rows[i].Visible = false;
            }

            //Them một dòng vào cuối DataGridView
            //chuyển sang chế độ select cell
            //Cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridView_QuanLySanPham.Rows.Add();
            dataGridView_QuanLySanPham.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_QuanLySanPham.Rows[i].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT và mã)
            dataGridView_QuanLySanPham.Columns["ColSTT"].Visible = false;
            dataGridView_QuanLySanPham.Columns["ColMaSanPham"].Visible = false;

            //Đưa cột Mã loại sản phẩm về dạng combobox
            //dataGridView_QuanLySanPham.Columns["ColMaLoaiSanPham"].DisplayIndex = 1;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[i].Cells["ColTenSanPham"];
            dataGridView_QuanLySanPham.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Location = new Point(12, 400);
            panelYesNo.Visible = true;
            buttonYes.Text = "Thêm";
            groupBoxTimKiem.Visible = false;
            groupBoxDSThamSo.Text = "Thêm sản phẩm mới";

            //Lưu trạng thái đang thực hiện
            Status = 1;//Thêm tham số
            Index = i;
        }

        private void buttonCapNhat_Click_1(object sender, EventArgs e)
        {
            //Lấy vị trí cần cập nhật
            Index = dataGridView_QuanLySanPham.CurrentRow.Index;

            //Lưu lại giá trị cần cập nhật, khôi phục lại khi cập nhật không thành công hoặc hủy
            SanPhamDTO backup = new SanPhamDTO();
            backup.MaSanPham = dataGridView_QuanLySanPham.CurrentRow.Cells["ColMaSanPham"].Value.ToString();
            backup.TenSanPham = dataGridView_QuanLySanPham.CurrentRow.Cells["ColTenSanPham"].Value.ToString();
            backup.CV = int.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColCV"].Value.ToString());
            backup.DonGia = float.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColDonGia"].Value.ToString());
            backup.DonGiaTV = float.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColDonGiaTV"].Value.ToString());
            backup.SoLuongTon = int.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColSoLuongTon"].Value.ToString());
            backup.MaLoaiSanPham = dataGridView_QuanLySanPham.CurrentRow.Cells["ColMaLoaiSanPham"].Value.ToString();
            BackupSanPhamDTO = backup;


            //Ẩn các dòng không cần thiết
            for (int i = 0; i < dataGridView_QuanLySanPham.RowCount; i++)
            {
                if (i != Index)
                {
                    dataGridView_QuanLySanPham.Rows[i].Visible = false;
                }
            }

            //chuyển sang chế độ select cell, cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridView_QuanLySanPham.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_QuanLySanPham.Rows[Index].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT)
            dataGridView_QuanLySanPham.Columns["ColSTT"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColTenSanPham"];
            dataGridView_QuanLySanPham.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Location = new Point(12, 400);
            panelYesNo.Visible = true;
            buttonYes.Text = "Cập Nhật";
            groupBoxTimKiem.Visible = false;
            groupBoxDSThamSo.Text = "Cập nhật sản phẩm";

            Status = 2;//cập nhật tham số

        }

        private void buttonXoa_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xóa sản phẩm", "Sản Phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                Index = dataGridView_QuanLySanPham.CurrentRow.Index;
                string id = dataGridView_QuanLySanPham.CurrentRow.Cells["ColMaSanPham"].Value.ToString();
                if (SanPhamBUS.DeleteSanPhamById(id))
                {
                    dataGridView_QuanLySanPham.Rows.RemoveAt(Index);
                    for (int i = Index; i < dataGridView_QuanLySanPham.RowCount; i++)
                    {
                        dataGridView_QuanLySanPham.Rows[i].Cells["ColSTT"].Value = (i + 1).ToString();
                    }
                }
            }
        }

        private void buttonLamLai_Click_1(object sender, EventArgs e)
        {
            textBoxMaSanPham.Text = null;
            textBoxTenSanPham.Text = null;
            textBoxCV.Text = null;
            textBoxDonGia.Text = null;
            textBoxDonGiaTV.Text = null;
            textBoxSoLuongTon.Text = null;
            cmbMaLoaiSanPham.SelectedItem = null;
        }

        private void buttonYes_Click_1(object sender, EventArgs e)
        {
            bool flag = true;
            if (dataGridView_QuanLySanPham.Rows[Index].Cells["ColTenSanPham"].Value == null)
            {
                MessageBox.Show("Tên sản phẩm không được để trống");
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColTenSanPham"];
                dataGridView_QuanLySanPham.BeginEdit(true);
                flag = false;
            }
            else if (dataGridView_QuanLySanPham.Rows[Index].Cells["ColCV"].Value == null)
            {
                MessageBox.Show("Giá trị CV không được để trống");
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColCV"];
                dataGridView_QuanLySanPham.BeginEdit(true);
                flag = false;
            }
            else if (dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGia"].Value == null)
            {
                MessageBox.Show("Giá trị đơn giá không được để trống");
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGia"];
                dataGridView_QuanLySanPham.BeginEdit(true);
                flag = false;
            }
            else if (dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGiaTV"].Value == null)
            {
                MessageBox.Show("Giá trị đơn giá TV không được để trống");
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGiaTV"];
                dataGridView_QuanLySanPham.BeginEdit(true);
                flag = false;
            }
            else if (dataGridView_QuanLySanPham.Rows[Index].Cells["ColSoLuongTon"].Value == null)
            {
                MessageBox.Show("Giá trị số lượng tồn không được để trống");
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColSoLuongTon"];
                dataGridView_QuanLySanPham.BeginEdit(true);
                flag = false;
            }
            else if (dataGridView_QuanLySanPham.Rows[Index].Cells["ColMaLoaiSanPham"].Value == null)
            {
                MessageBox.Show("Giá trị mã loại sản phẩm không được để trống");
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColMaLoaiSanPham"];
                dataGridView_QuanLySanPham.BeginEdit(true);
                flag = false;
            }

            if (flag)
            {
                SanPhamDTO sanphamDTO = new SanPhamDTO();
                sanphamDTO.TenSanPham = dataGridView_QuanLySanPham.Rows[Index].Cells["ColTenSanPham"].Value.ToString();
                sanphamDTO.CV = int.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColCV"].Value.ToString());
                sanphamDTO.DonGia = float.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGia"].Value.ToString());
                sanphamDTO.DonGiaTV = float.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGiaTV"].Value.ToString());
                sanphamDTO.SoLuongTon = int.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColSoLuongTon"].Value.ToString());
                sanphamDTO.MaLoaiSanPham = dataGridView_QuanLySanPham.Rows[Index].Cells["ColMaLoaiSanPham"].Value.ToString();
                if (Status == 1)//Them tham so
                {
                    sanphamDTO.MaSanPham = SanPhamBUS.CreateSanPhamId();
                    dataGridView_QuanLySanPham.Rows[Index].Cells["ColSanPham"].Value = sanphamDTO.MaSanPham;
                    dataGridView_QuanLySanPham.Rows[Index].Cells["ColSTT"].Value = (Index + 1).ToString();
                    if (SanPhamBUS.InsertSanPham(sanphamDTO))
                    {
                        dataGridView_QuanLySanPham.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        dataGridView_QuanLySanPham.Rows.RemoveAt(Index);
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else if (Status == 2)
                {
                    sanphamDTO.MaSanPham = dataGridView_QuanLySanPham.Rows[Index].Cells["ColMaSanPham"].Value.ToString();
                    if (SanPhamBUS.UpdateSanPhamById(sanphamDTO))
                    {
                        dataGridView_QuanLySanPham.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        dataGridView_QuanLySanPham.Rows[Index].Cells["ColTenSanPham"].Value = BackupSanPhamDTO.TenSanPham;
                        dataGridView_QuanLySanPham.Rows[Index].Cells["ColCV"].Value = BackupSanPhamDTO.CV;
                        dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGia"].Value = BackupSanPhamDTO.DonGia;
                        dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGiaTV"].Value = BackupSanPhamDTO.DonGiaTV;
                        dataGridView_QuanLySanPham.Rows[Index].Cells["ColSoLuongTon"].Value = BackupSanPhamDTO.SoLuongTon;
                        dataGridView_QuanLySanPham.Rows[Index].Cells["ColMaLoaiSanPham"].Value = BackupSanPhamDTO.MaLoaiSanPham;
                        dataGridView_QuanLySanPham.Rows[Index].ReadOnly = true;
                    }
                }

                Reset();
            }

        }

        private void buttonNo_Click_1(object sender, EventArgs e)
        {
            if (Status == 1)
            {
                dataGridView_QuanLySanPham.Rows.RemoveAt(Index);
            }
            else if (Status == 2)
            {
                dataGridView_QuanLySanPham.Rows[Index].Cells["ColTenSanPham"].Value = BackupSanPhamDTO.TenSanPham;
                dataGridView_QuanLySanPham.Rows[Index].Cells["ColCV"].Value = BackupSanPhamDTO.CV;
                dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGia"].Value = BackupSanPhamDTO.DonGia;
                dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGiaTV"].Value = BackupSanPhamDTO.DonGiaTV;
                dataGridView_QuanLySanPham.Rows[Index].Cells["ColSoLuongTon"].Value = BackupSanPhamDTO.SoLuongTon;
                dataGridView_QuanLySanPham.Rows[Index].Cells["ColMaLoaiSanPham"].Value = BackupSanPhamDTO.MaLoaiSanPham;
                dataGridView_QuanLySanPham.Rows[Index].ReadOnly = true;
            }

            Reset();
        }

        private void textBoxMaSanPham_TextChanged_1(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxTenSanPham_TextChanged_1(object sender, EventArgs e)
        {
            Search();
        }
       
        
    }
}
