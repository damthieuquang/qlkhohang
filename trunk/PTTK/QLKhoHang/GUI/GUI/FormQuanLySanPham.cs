using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLySanPham : Form
    {
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }

        private void FormQuanLySanPham_Activated(object sender, EventArgs e)
        {
            panelYesNo.Location = new Point(12, 400);
            panelYesNo.Parent = this;
            KhoiTao();
        }

        //Biến đếm:
        //public int dem = 0;
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

            LoaiSanPhamDTO all = new LoaiSanPhamDTO();
            all.MaLoaiSanPham = "";
            all.TenLoaiSanPham = "Tất cả";

            lstcbspDTO.Insert(0, all);

            cmbMaLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cmbMaLoaiSanPham.ValueMember = "MaLoaiSanPham";
            cmbMaLoaiSanPham.DataSource = lstcbspDTO;
            cmbMaLoaiSanPham.SelectedIndex = 0;

            List<LoaiSanPhamDTO> lstcbspDTO2 = LoaiSanPhamBUS.SelectLoaiSanPhamAll();
            ColLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            ColLoaiSanPham.ValueMember = "MaLoaiSanPham";
            ColLoaiSanPham.DataSource = lstcbspDTO2;
            ColLoaiSanPham.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;


            if (listSanPhamDTO != null)
            {
                SanPhamDTO item = new SanPhamDTO();
                dataGridView_QuanLySanPham.Rows.Clear();
                for (int i = 0; i < listSanPhamDTO.Count; i++)
                {
                    item = listSanPhamDTO[i];
                    dataGridView_QuanLySanPham.Rows.Add((i + 1).ToString(), item.MaSanPham, item.TenSanPham, item.CV.ToString(), item.DonGia.ToString(), item.DonGiaTV.ToString(), item.SoLuongTon.ToString(), item.MaLoaiSanPham);
                    dataGridView_QuanLySanPham.Rows[i].ReadOnly = true;
                }
                buttonLamLai.Enabled = true;
                buttonEnabled();
            }
            else
            {
                buttonLamLai.Enabled = false;
                buttonDisabled();
            }

        }

        /*
        * Hàm Search
        * Lấy các giá trị từ các textbox --> tìm kiếm và cập nhật lại DataGridView
       */
        private void Search()
        {

            int stt = 0;
            int vt = -1;
            for (int i = 0; i < dataGridView_QuanLySanPham.RowCount; i++)
            {

                dataGridView_QuanLySanPham.Rows[i].Visible = false;

                if (dataGridView_QuanLySanPham.Rows[i].Cells["ColMaSanPham"].Value.ToString().ToUpper().IndexOf(textBoxMaSanPham.Text.ToString().ToUpper()) >= 0
                            && dataGridView_QuanLySanPham.Rows[i].Cells["ColTenSanPham"].Value.ToString().ToUpper().IndexOf(textBoxTenSanPham.Text.ToString().ToUpper()) >= 0
                           && dataGridView_QuanLySanPham.Rows[i].Cells["ColCV"].Value.ToString().ToUpper().IndexOf(textBoxCV.Text.ToString().ToUpper()) >= 0
                           && dataGridView_QuanLySanPham.Rows[i].Cells["ColDonGia"].Value.ToString().ToUpper().IndexOf(textBoxDonGia.Text.ToString().ToUpper()) >= 0
                           && dataGridView_QuanLySanPham.Rows[i].Cells["ColDonGiaTV"].Value.ToString().ToUpper().IndexOf(textBoxDonGiaTV.Text.ToString().ToUpper()) >= 0
                          && (cmbMaLoaiSanPham.SelectedValue.ToString() == "" || dataGridView_QuanLySanPham.Rows[i].Cells["ColLoaiSanPham"].Value.ToString().ToUpper().IndexOf(cmbMaLoaiSanPham.SelectedValue.ToString().ToUpper()) >= 0))
                {
                    stt++;
                    dataGridView_QuanLySanPham.Rows[i].Visible = true;
                    dataGridView_QuanLySanPham.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                    vt = i;
                    break;
                }
            }

            for (int i = vt + 1; i < dataGridView_QuanLySanPham.RowCount; i++)
            {

                dataGridView_QuanLySanPham.Rows[i].Visible = false;


                if (dataGridView_QuanLySanPham.Rows[i].Cells["ColMaSanPham"].Value.ToString().ToUpper().IndexOf(textBoxMaSanPham.Text.ToString().ToUpper()) >= 0
                            && dataGridView_QuanLySanPham.Rows[i].Cells["ColTenSanPham"].Value.ToString().ToUpper().IndexOf(textBoxTenSanPham.Text.ToString().ToUpper()) >= 0
                           && dataGridView_QuanLySanPham.Rows[i].Cells["ColCV"].Value.ToString().ToUpper().IndexOf(textBoxCV.Text.ToString().ToUpper()) >= 0
                           && dataGridView_QuanLySanPham.Rows[i].Cells["ColDonGia"].Value.ToString().ToUpper().IndexOf(textBoxDonGia.Text.ToString().ToUpper()) >= 0
                           && dataGridView_QuanLySanPham.Rows[i].Cells["ColDonGiaTV"].Value.ToString().ToUpper().IndexOf(textBoxDonGiaTV.Text.ToString().ToUpper()) >= 0
                          && (cmbMaLoaiSanPham.SelectedValue.ToString() == "" || dataGridView_QuanLySanPham.Rows[i].Cells["ColLoaiSanPham"].Value.ToString().ToUpper().IndexOf(cmbMaLoaiSanPham.SelectedValue.ToString().ToUpper()) >= 0))
                {
                    stt++;
                    dataGridView_QuanLySanPham.Rows[i].Visible = true;
                    dataGridView_QuanLySanPham.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                }
            }

            if (vt == -1)// khon co dong nao thoa
            {
                buttonDisabled();
            }
            else
            {
                buttonEnabled();
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[vt].Cells[0];
                dataGridView_QuanLySanPham.CurrentCell.Selected = true;
            }

        }

        //Ham hieu chinh cac nut man hinh
        private void buttonEnabled()
        {

            buttonCapNhat.Enabled = true;
            buttonXoa.Enabled = true;
        }

        private void buttonDisabled()
        {
            buttonCapNhat.Enabled = false;
            buttonXoa.Enabled = false;
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
            dataGridView_QuanLySanPham.Columns["ColSoLuongTon"].Visible = true;
            ColLoaiSanPham.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;


            //Cập nhật lại các giá trị ban đầu cho Pannel
            panelYesNo.Visible = false;
            panelTimKiem.Visible = true;
            groupBoxTimKiem.Enabled = true;
            groupBoxDanhSach.Text = "Danh sách sản phẩm";

            Status = 0;
            Index = -1;

            for (int i = 0; i < dataGridView_QuanLySanPham.RowCount; i++)
            {
                dataGridView_QuanLySanPham.Rows[i].Visible = true;
            }

            dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[0].Cells[0];
            //Khởi động lại các nút:
            if (dataGridView_QuanLySanPham.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_QuanLySanPham.Rows.Count; i++)
                {
                    if (dataGridView_QuanLySanPham.Rows[i].Visible == true)
                    {
                        buttonEnabled();
                        break;
                    }
                }
            }
            else
                buttonDisabled();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonThem_Click(object sender, EventArgs e)
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
            dataGridView_QuanLySanPham.Columns["ColSoLuongTon"].Visible = false;

            //Hien cot loai sa pham
            ColLoaiSanPham.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            dataGridView_QuanLySanPham.Rows[i].Cells[ColLoaiSanPham.Index].Value = "LSP01";


            //Đưa cột Mã loại sản phẩm về dạng combobox
            //dataGridView_QuanLySanPham.Columns["ColLoaiSanPham"].DisplayIndex = 1;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[i].Cells["ColTenSanPham"];
            dataGridView_QuanLySanPham.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Thêm";
            groupBoxTimKiem.Enabled = false;
            groupBoxDanhSach.Text = "Thêm sản phẩm mới";

            //Lưu trạng thái đang thực hiện
            Status = 1;//Thêm tham số
            Index = i;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            Index = dataGridView_QuanLySanPham.CurrentRow.Index;

            //Lưu lại giá trị cần cập nhật, khôi phục lại khi cập nhật không thành công hoặc hủy
            SanPhamDTO backup = new SanPhamDTO();
            backup.MaSanPham = dataGridView_QuanLySanPham.CurrentRow.Cells["ColMaSanPham"].Value.ToString().Trim();
            backup.TenSanPham = dataGridView_QuanLySanPham.CurrentRow.Cells["ColTenSanPham"].Value.ToString().Trim();
            backup.CV = int.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColCV"].Value.ToString());
            backup.DonGia = float.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColDonGia"].Value.ToString());
            backup.DonGiaTV = float.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColDonGiaTV"].Value.ToString());
            //backup.SoLuongTon = int.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColSoLuongTon"].Value.ToString());
            backup.MaLoaiSanPham = dataGridView_QuanLySanPham.CurrentRow.Cells["ColLoaiSanPham"].Value.ToString().Trim();
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
            dataGridView_QuanLySanPham.Columns["ColSoLuongTon"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColTenSanPham"];
            dataGridView_QuanLySanPham.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Cập Nhật";
            groupBoxTimKiem.Enabled = false;
            groupBoxDanhSach.Text = "Cập nhật sản phẩm";

            Status = 2;//cập nhật tham số            
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xóa sản phẩm", "Sản Phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                //if(dem)
                Index = dataGridView_QuanLySanPham.CurrentRow.Index;
                string id = dataGridView_QuanLySanPham.CurrentRow.Cells["ColMaSanPham"].Value.ToString().Trim();
                int stt = int.Parse(dataGridView_QuanLySanPham.CurrentRow.Cells["ColSTT"].Value.ToString());
                if (SanPhamBUS.DeleteSanPhamById(id))
                {
                    dataGridView_QuanLySanPham.Rows.RemoveAt(Index);
                    if (dataGridView_QuanLySanPham.RowCount > 0)
                    {
                        bool flag = false;
                        for (int i = 0; i < Index; i++)
                        {
                            if (dataGridView_QuanLySanPham.Rows[i].Visible == true)
                            {
                                flag = true;
                            }
                        }
                        for (int i = Index; i < dataGridView_QuanLySanPham.RowCount; i++)
                        {
                            if (dataGridView_QuanLySanPham.Rows[i].Visible == true)
                            {
                                dataGridView_QuanLySanPham.Rows[i].Cells["ColSTT"].Value = i.ToString();
                                stt++;
                                flag = true;
                            }
                        }

                        if (flag == false)
                        {
                            buttonDisabled();
                        }
                    }
                    else
                    {
                        buttonDisabled();
                    }
                }
            }
        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            cmbMaLoaiSanPham.SelectedItem = 0;
            textBoxMaSanPham.Text = null;
            textBoxTenSanPham.Text = null;
            textBoxCV.Text = null;
            textBoxDonGia.Text = null;
            textBoxDonGiaTV.Text = null;
            Reset();
        }

        private void textBoxMaSanPham_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxDonGia_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxTenSanPham_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxCV_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxDonGiaTV_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbMaLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            int k;
            float j;

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
            else if (int.TryParse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColCV"].Value.ToString(), out k) == false)
            {
                MessageBox.Show("Giá trị CV phải là số");
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
            else if (float.TryParse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGia"].Value.ToString(), out j) == false)
            {
                MessageBox.Show("Giá trị đơn giá phải là số");
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
            else if (float.TryParse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGiaTV"].Value.ToString(), out j) == false)
            {
                MessageBox.Show("Giá trị đơn giá thành viên phải là số");
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGiaTV"];
                dataGridView_QuanLySanPham.BeginEdit(true);
                flag = false;
            }
            else if (dataGridView_QuanLySanPham.Rows[Index].Cells["ColLoaiSanPham"].Value == null)
            {
                MessageBox.Show("Giá trị mã loại sản phẩm không được để trống");
                dataGridView_QuanLySanPham.CurrentCell = dataGridView_QuanLySanPham.Rows[Index].Cells["ColLoaiSanPham"];
                dataGridView_QuanLySanPham.BeginEdit(true);
                flag = false;
            }

            if (flag)
            {
                SanPhamDTO sanphamDTO = new SanPhamDTO();
                sanphamDTO.TenSanPham = dataGridView_QuanLySanPham.Rows[Index].Cells["ColTenSanPham"].Value.ToString().Trim();
                sanphamDTO.CV = int.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColCV"].Value.ToString());
                sanphamDTO.DonGia = float.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGia"].Value.ToString());
                sanphamDTO.DonGiaTV = float.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColDonGiaTV"].Value.ToString());
                sanphamDTO.SoLuongTon = 0;//int.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColSoLuongTon"].Value.ToString());
                sanphamDTO.MaLoaiSanPham = dataGridView_QuanLySanPham.Rows[Index].Cells["ColLoaiSanPham"].Value.ToString().Trim();
                if (Status == 1)//Them tham so
                {
                    sanphamDTO.MaSanPham = SanPhamBUS.CreateSanPhamId().Trim();
                    dataGridView_QuanLySanPham.Rows[Index].Cells["ColMaSanPham"].Value = sanphamDTO.MaSanPham;
                    dataGridView_QuanLySanPham.Rows[Index].Cells["ColSTT"].Value = (Index + 1).ToString();
                    if (SanPhamBUS.InsertSanPham(sanphamDTO))
                    {
                        dataGridView_QuanLySanPham.Rows[Index].ReadOnly = true;
                        dataGridView_QuanLySanPham.Rows[dataGridView_QuanLySanPham.Rows.Count - 1].Cells["ColSoLuongTon"].Value = sanphamDTO.SoLuongTon;
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
                    sanphamDTO.SoLuongTon = int.Parse(dataGridView_QuanLySanPham.Rows[Index].Cells["ColSoLuongTon"].Value.ToString());
                    sanphamDTO.MaSanPham = dataGridView_QuanLySanPham.Rows[Index].Cells["ColMaSanPham"].Value.ToString().Trim();
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
                        dataGridView_QuanLySanPham.Rows[Index].Cells["ColLoaiSanPham"].Value = BackupSanPhamDTO.MaLoaiSanPham;
                        dataGridView_QuanLySanPham.Rows[Index].ReadOnly = true;
                    }
                }

                Reset();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
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
                dataGridView_QuanLySanPham.Rows[Index].Cells["ColLoaiSanPham"].Value = BackupSanPhamDTO.MaLoaiSanPham;
                dataGridView_QuanLySanPham.Rows[Index].ReadOnly = true;
            }

            Reset();
        }


    }
}
