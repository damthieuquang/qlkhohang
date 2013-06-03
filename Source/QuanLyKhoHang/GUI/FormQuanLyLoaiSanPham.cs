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
    public partial class FormQuanLyLoaiSanPham : Form
    {
        public FormQuanLyLoaiSanPham()
        {
            InitializeComponent();
        }


        private void FormQuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            panelYesNo.Location = new Point(12, 350);
            KhoiTao();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColTenLoaiSanPham"].Value == null)
            {
                MessageBox.Show("Tên loại sản phẩm không được để trống");
                dataGridView_QuanLyLoaiSanPham.CurrentCell = dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColTenLoaiSanPham"];
                dataGridView_QuanLyLoaiSanPham.BeginEdit(true);
                flag = false;
            }


            if (flag)
            {
                LoaiSanPhamDTO lspDTO = new LoaiSanPhamDTO();
                lspDTO.TenLoaiSanPham = dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColTenLoaiSanPham"].Value.ToString();

                if (Status == 1)//Them tham so
                {
                    lspDTO.MaLoaiSanPham = LoaiSanPhamBUS.CreateLoaiSanPhamId();
                    dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColMaLoaiSanPham"].Value = lspDTO.MaLoaiSanPham;
                    dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColSTT"].Value = (Index + 1).ToString();
                    if (LoaiSanPhamBUS.InsertLoaiSanPham(lspDTO))
                    {
                        dataGridView_QuanLyLoaiSanPham.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        dataGridView_QuanLyLoaiSanPham.Rows.RemoveAt(Index);
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else if (Status == 2)
                {
                    lspDTO.MaLoaiSanPham = dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColMaLoaiSanPham"].Value.ToString();
                    if (LoaiSanPhamBUS.UpdateLoaiSanPhamById(lspDTO))
                    {
                        dataGridView_QuanLyLoaiSanPham.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColTenLoaiSanPham"].Value = BackupLoaiSanPhamDTO.TenLoaiSanPham;

                        dataGridView_QuanLyLoaiSanPham.Rows[Index].ReadOnly = true;
                    }
                }

                Reset();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            if (Status == 1)
            {
                dataGridView_QuanLyLoaiSanPham.Rows.RemoveAt(Index);
            }
            else if (Status == 2)
            {
                dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColTenLoaiSanPham"].Value = BackupLoaiSanPhamDTO.TenLoaiSanPham;

                dataGridView_QuanLyLoaiSanPham.Rows[Index].ReadOnly = true;
            }

            Reset();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int i;
            //Ẩn các dòng không cần thiết
            for (i = 0; i < dataGridView_QuanLyLoaiSanPham.RowCount; i++)
            {
                dataGridView_QuanLyLoaiSanPham.Rows[i].Visible = false;
            }

            //Them một dòng vào cuối DataGridView
            //chuyển sang chế độ select cell
            //Cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridView_QuanLyLoaiSanPham.Rows.Add();
            dataGridView_QuanLyLoaiSanPham.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_QuanLyLoaiSanPham.Rows[i].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT và mã)
            dataGridView_QuanLyLoaiSanPham.Columns["ColSTT"].Visible = false;
            dataGridView_QuanLyLoaiSanPham.Columns["ColMaLoaiSanPham"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_QuanLyLoaiSanPham.CurrentCell = dataGridView_QuanLyLoaiSanPham.Rows[i].Cells["ColTenLoaiSanPham"];
            dataGridView_QuanLyLoaiSanPham.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm

            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Thêm";
            groupBoxTimKiem.Enabled = false;
            groupBoxDSThamSo.Text = "Thêm loại sản phẩm mới";

            //Lưu trạng thái đang thực hiện
            Status = 1;//Thêm tham số
            Index = i;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {

            //Lấy vị trí cần cập nhật
            Index = dataGridView_QuanLyLoaiSanPham.CurrentRow.Index;

            //Lưu lại giá trị cần cập nhật, khôi phục lại khi cập nhật không thành công hoặc hủy
            LoaiSanPhamDTO backup = new LoaiSanPhamDTO();
            backup.MaLoaiSanPham = dataGridView_QuanLyLoaiSanPham.CurrentRow.Cells["ColMaLoaiSanPham"].Value.ToString();
            backup.TenLoaiSanPham = dataGridView_QuanLyLoaiSanPham.CurrentRow.Cells["ColTenLoaiSanPham"].Value.ToString();

            BackupLoaiSanPhamDTO = backup;


            //Ẩn các dòng không cần thiết
            for (int i = 0; i < dataGridView_QuanLyLoaiSanPham.RowCount; i++)
            {
                if (i != Index)
                {
                    dataGridView_QuanLyLoaiSanPham.Rows[i].Visible = false;
                }
            }

            //chuyển sang chế độ select cell, cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridView_QuanLyLoaiSanPham.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_QuanLyLoaiSanPham.Rows[Index].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT)
            dataGridView_QuanLyLoaiSanPham.Columns["ColSTT"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_QuanLyLoaiSanPham.CurrentCell = dataGridView_QuanLyLoaiSanPham.Rows[Index].Cells["ColTenLoaiSanPham"];
            dataGridView_QuanLyLoaiSanPham.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm

            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Cập Nhật";
            groupBoxTimKiem.Enabled = false;
            groupBoxDSThamSo.Text = "Cập nhật loại sản phẩm";

            Status = 2;//cập nhật tham số

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Xóa loại sản phẩm", "Loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                Index = dataGridView_QuanLyLoaiSanPham.CurrentRow.Index;
                string id = dataGridView_QuanLyLoaiSanPham.CurrentRow.Cells["ColMaLoaiSanPham"].Value.ToString();                
                if (LoaiSanPhamBUS.DeleteLoaiSanPhamById(id))
                {    
                
                    dataGridView_QuanLyLoaiSanPham.Rows.RemoveAt(Index);
                    if (dataGridView_QuanLyLoaiSanPham.Rows.Count > 0)
                    {
                        bool flag = false;
                        for (int i = 0; i < Index; i++)
                        {
                            if (dataGridView_QuanLyLoaiSanPham.Rows[i].Visible == true)
                            {
                                flag = true;
                            }
                        }
                        for (int i = Index; i < dataGridView_QuanLyLoaiSanPham.RowCount; i++)
                        {
                            if (dataGridView_QuanLyLoaiSanPham.Rows[i].Visible == true)
                            {
                                dataGridView_QuanLyLoaiSanPham.Rows[i].Cells["ColSTT"].Value = (i + 1).ToString();
                                flag = true;
                            }
                        }
                        if (flag == false)
                            buttonDisabled();
                    }
                    else
                        buttonEnabled();                    
                }
            }
        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            textBoxMaLoaiSanPham.Text = null;
            textBoxTenLoaiSanPham.Text = null;

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBoxMaLoaiSanPham_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxTenLoaiSanPham_TextChanged(object sender, EventArgs e)
        {
            Search();
        }



        //---------------------Hàm -----------------
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
        private LoaiSanPhamDTO _backupLoaiSanPhamDTO;

        public LoaiSanPhamDTO BackupLoaiSanPhamDTO
        {
            get { return _backupLoaiSanPhamDTO; }
            set { _backupLoaiSanPhamDTO = value; }
        }


        /*
         * Hàm KhoiTao
         * Tải toàn bộ danh sách tham số
        */
        private void KhoiTao()
        {
            List<LoaiSanPhamDTO> listlspDTO = LoaiSanPhamBUS.SelectLoaiSanPhamAll();
            if (listlspDTO != null)
            {
                LoaiSanPhamDTO item = new LoaiSanPhamDTO();
                dataGridView_QuanLyLoaiSanPham.Rows.Clear();
                for (int i = 0; i < listlspDTO.Count; i++)
                {
                    item = listlspDTO[i];
                    dataGridView_QuanLyLoaiSanPham.Rows.Add((i + 1).ToString(), item.MaLoaiSanPham, item.TenLoaiSanPham);
                    dataGridView_QuanLyLoaiSanPham.Rows[i].ReadOnly = true;
                }
                buttonLamLai.Enabled = true;
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
            for (int i = 0; i < dataGridView_QuanLyLoaiSanPham.RowCount; i++)
            {

                dataGridView_QuanLyLoaiSanPham.Rows[i].Visible = false;

                if (dataGridView_QuanLyLoaiSanPham.Rows[i].Cells["ColMaLoaiSanPham"].Value.ToString().ToUpper().IndexOf(textBoxMaLoaiSanPham.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyLoaiSanPham.Rows[i].Cells["ColTenLoaiSanPham"].Value.ToString().ToUpper().IndexOf(textBoxTenLoaiSanPham.Text.ToString().ToUpper()) >= 0)
                {
                    stt++;
                    dataGridView_QuanLyLoaiSanPham.Rows[i].Visible = true;
                    dataGridView_QuanLyLoaiSanPham.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                    vt = i;
                    break;
                }
            }

            for (int i = vt + 1; i < dataGridView_QuanLyLoaiSanPham.RowCount; i++)
            {

                dataGridView_QuanLyLoaiSanPham.Rows[i].Visible = false;
                if (dataGridView_QuanLyLoaiSanPham.Rows[i].Cells["ColMaLoaiSanPham"].Value.ToString().ToUpper().IndexOf(textBoxMaLoaiSanPham.Text.ToString().ToUpper()) >= 0
                     && dataGridView_QuanLyLoaiSanPham.Rows[i].Cells["ColTenLoaiSanPham"].Value.ToString().ToUpper().IndexOf(textBoxTenLoaiSanPham.Text.ToString().ToUpper()) >= 0)
                {
                    stt++;
                    dataGridView_QuanLyLoaiSanPham.Rows[i].Visible = true;
                    dataGridView_QuanLyLoaiSanPham.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                }
            }

            if (vt == -1)// khon co dong nao thoa
            {
                buttonDisabled();
            }
            else
            {
                buttonEnabled();
                dataGridView_QuanLyLoaiSanPham.CurrentCell = dataGridView_QuanLyLoaiSanPham.Rows[vt].Cells[0];
                dataGridView_QuanLyLoaiSanPham.CurrentCell.Selected = true;
            }
        }

        // Ham hien thi cac button
        private void buttonEnabled()
        {
            // buttonXemChiTiet.Enabled = true;
            buttonCapNhat.Enabled = true;
            buttonXoa.Enabled = true;
        }

        private void buttonDisabled()
        {
            //buttonXemChiTiet.Enabled = false;
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
            dataGridView_QuanLyLoaiSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView_QuanLyLoaiSanPham.Columns["ColSTT"].Visible = true;
            dataGridView_QuanLyLoaiSanPham.Columns["ColMaLoaiSanPham"].Visible = true;


            //Cập nhật lại các giá trị ban đầu cho Pannel
            panelYesNo.Visible = false;
            panelTimKiem.Visible = true;
            groupBoxTimKiem.Enabled = true;
            groupBoxDSThamSo.Text = "Danh sách loại sản phẩm";

            Status = 0;
            Index = -1;

            for (int i = 0; i < dataGridView_QuanLyLoaiSanPham.RowCount; i++)
            {
                dataGridView_QuanLyLoaiSanPham.Rows[i].Visible = true;
            }

            dataGridView_QuanLyLoaiSanPham .CurrentCell = dataGridView_QuanLyLoaiSanPham.Rows[0].Cells[0];
        }


    }
}
