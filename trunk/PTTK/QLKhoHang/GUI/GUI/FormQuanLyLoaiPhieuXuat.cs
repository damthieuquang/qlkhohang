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
    public partial class FormQuanLyLoaiPhieuXuat : Form
    {
        public FormQuanLyLoaiPhieuXuat()
        {
            InitializeComponent();
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
        private int _index;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
        private LoaiPhieuXuatDTO _backupThamSoDTO;

        public LoaiPhieuXuatDTO BackupThamSoDTO
        {
            get { return _backupThamSoDTO; }
            set { _backupThamSoDTO = value; }
        }

        /*
         * Hàm Khoi Tao
         * Tải danh sách loại phiếu xuất
        */
        private void KhoiTao()
        {
            List<LoaiPhieuXuatDTO> listLoaiPhieuXuatDTO = LoaiPhieuXuatBUS.SelectLoaiPhieuXuatAll();
            if (listLoaiPhieuXuatDTO != null)
            {
                LoaiPhieuXuatDTO loaiPhieuXuatDTO = new LoaiPhieuXuatDTO();
                dataGridViewLoaiPhieuXuat.Rows.Clear();
                for (int i = 0; i < listLoaiPhieuXuatDTO.Count; i++)
                {
                    loaiPhieuXuatDTO = listLoaiPhieuXuatDTO[i];
                    dataGridViewLoaiPhieuXuat.Rows.Add((i + 1).ToString(), loaiPhieuXuatDTO.MaLoaiPhieuXuat, loaiPhieuXuatDTO.TenLoaiPhieuXuat);
                    dataGridViewLoaiPhieuXuat.Rows[i].ReadOnly = true;
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

        //ham hieu chinh cac button:
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
         * Hàm Search 
         * Lấy các giá trị từ các textbox --> tìm kiếm và cập nhật lại DataGridView
       */
        private void Search()
        {
            int stt = 0;
            int vt = -1;
            for (int i = 0; i < dataGridViewLoaiPhieuXuat.Rows.Count; i++)
            {
                dataGridViewLoaiPhieuXuat.Rows[i].Visible = false;
                if (dataGridViewLoaiPhieuXuat.Rows[i].Cells["ColMaLoaiPhieuXuat"].Value.ToString().ToUpper().IndexOf(textBoxMaLoaiPhieuXuat.Text.ToString().ToUpper()) >= 0
                    && dataGridViewLoaiPhieuXuat.Rows[i].Cells["ColTenLoaiPhieuXuat"].Value.ToString().ToUpper().IndexOf(textBoxTenLoaiPhieuXuat.Text.ToString().ToUpper()) >= 0
                    )
                {
                    stt++;
                    dataGridViewLoaiPhieuXuat.Rows[i].Visible = true;
                    dataGridViewLoaiPhieuXuat.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                    vt = i;
                    break;
                }
            }

            for (int i = vt + 1; i < dataGridViewLoaiPhieuXuat.Rows.Count; i++)
            {
                dataGridViewLoaiPhieuXuat.Rows[i].Visible = false;
                if (dataGridViewLoaiPhieuXuat.Rows[i].Cells["ColMaLoaiPhieuXuat"].Value.ToString().ToUpper().IndexOf(textBoxMaLoaiPhieuXuat.Text.ToString().ToUpper()) >= 0
                    && dataGridViewLoaiPhieuXuat.Rows[i].Cells["ColTenLoaiPhieuXuat"].Value.ToString().ToUpper().IndexOf(textBoxTenLoaiPhieuXuat.Text.ToString().ToUpper()) >= 0
                    )
                {
                    stt++;
                    dataGridViewLoaiPhieuXuat.Rows[i].Visible = true;
                    dataGridViewLoaiPhieuXuat.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                }
            }

            if (vt == -1)
            {
                buttonDisabled();
            }
            else
            {
                buttonEnabled();
                dataGridViewLoaiPhieuXuat.CurrentCell = dataGridViewLoaiPhieuXuat.Rows[vt].Cells[0];
                dataGridViewLoaiPhieuXuat.CurrentCell.Selected = true;
            }
        }

        /*
          * Hàm Reset
          * Cập nhật lại các thuộc tính ban đầu cho DataGridView và panel 
         */
        private void Reset()
        {
            //Cập nhật lại các giá trị ban đầu cho DataGridView
            dataGridViewLoaiPhieuXuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewLoaiPhieuXuat.Columns["ColSTT"].Visible = true;
            dataGridViewLoaiPhieuXuat.Columns["ColMaLoaiPhieuXuat"].Visible = true;

            //Cập nhật  lại các giá trị ban đầu cho Panel
            panelYesNo.Visible = false;
            panelTimKiem.Visible = true;
            groupBoxTimKiem.Enabled = true;
            groupBoxDSLoaiPhieuXuat.Text = "Danh sách loại phiếu xuất";

            textBoxMaLoaiPhieuXuat.Text = null;
            textBoxTenLoaiPhieuXuat.Text = null;

            Status = 0;
            Index = -1;

            for (int i = 0; i < dataGridViewLoaiPhieuXuat.RowCount; i++)
            {
                dataGridViewLoaiPhieuXuat.Rows[i].Visible = true;
            }
            dataGridViewLoaiPhieuXuat.CurrentCell = dataGridViewLoaiPhieuXuat.Rows[0].Cells[0];

            //Khởi động lại các nút:
            if (dataGridViewLoaiPhieuXuat.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewLoaiPhieuXuat.Rows.Count; i++)
                {
                    if (dataGridViewLoaiPhieuXuat.Rows[i].Visible == true)
                    {
                        buttonEnabled();
                        break;
                    }
                }
            }
            else
            {
                buttonDisabled();
            }
        }

        private void FormQuanLyLoaiPhieuXuat_Load(object sender, EventArgs e)
        {
            panelYesNo.Location = new Point(74, 446);
            KhoiTao();
        }

        private void textBoxMaLoaiPhieuXuat_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxTenLoaiPhieuXuat_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            textBoxMaLoaiPhieuXuat.Clear();
            textBoxTenLoaiPhieuXuat.Clear();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int i;

            //Ẩn các dòng không cần thiết
            for (i = 0; i < dataGridViewLoaiPhieuXuat.RowCount; i++)
            {
                dataGridViewLoaiPhieuXuat.Rows[i].Visible = false;
            }

            //Them một dòng vào cuối DataGridView
            //chuyển sang chế độ select cell
            //Cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridViewLoaiPhieuXuat.Rows.Add();
            dataGridViewLoaiPhieuXuat.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewLoaiPhieuXuat.Rows[i].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT và mã)
            dataGridViewLoaiPhieuXuat.Columns["ColSTT"].Visible = false;
            dataGridViewLoaiPhieuXuat.Columns["ColMaLoaiPhieuXuat"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridViewLoaiPhieuXuat.CurrentCell = dataGridViewLoaiPhieuXuat.Rows[i].Cells["ColTenLoaiPhieuXuat"];
            dataGridViewLoaiPhieuXuat.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Location = new Point(12, 400);
            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Thêm";
            groupBoxTimKiem.Enabled = false;
            groupBoxDSLoaiPhieuXuat.Text = "Thêm loại phiếu xuất mới";

            //Lưu trạng thái đang thực hiện
            Status = 1;//Thêm loại phiếu xuất
            Index = i;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            //Lấy vị trí cần cập nhật
            Index = dataGridViewLoaiPhieuXuat.CurrentRow.Index;

            //Lưu lại giá trị cần cập nhật, khôi phục lại khi cập nhật không thành công hoặc hủy
            LoaiPhieuXuatDTO backup = new LoaiPhieuXuatDTO();
            backup.MaLoaiPhieuXuat = dataGridViewLoaiPhieuXuat.CurrentRow.Cells["ColMaLoaiPhieuXuat"].Value.ToString();
            backup.TenLoaiPhieuXuat = dataGridViewLoaiPhieuXuat.CurrentRow.Cells["ColTenLoaiPhieuXuat"].Value.ToString();
            BackupThamSoDTO = backup;


            for (int i = 0; i < dataGridViewLoaiPhieuXuat.RowCount; i++)
            {
                if (i != Index)
                {
                    dataGridViewLoaiPhieuXuat.Rows[i].Visible = false;
                }
            }

            //chuyển sang chế độ select cell, cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridViewLoaiPhieuXuat.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewLoaiPhieuXuat.Rows[Index].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT và mã)
            dataGridViewLoaiPhieuXuat.Columns["ColSTT"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridViewLoaiPhieuXuat.CurrentCell = dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColTenLoaiPhieuXuat"];
            dataGridViewLoaiPhieuXuat.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Location = new Point(12, 400);
            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Cập nhật";
            groupBoxTimKiem.Enabled = false;
            groupBoxDSLoaiPhieuXuat.Text = "Cập nhật loại phiếu xuất mới";

            //Lưu trạng thái đang thực hiện
            Status = 2;//Cập nhật loại phiếu xuất
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColTenLoaiPhieuXuat"].Value == null)
            {
                MessageBox.Show("Tên loại phiếu xuất không được để trống");
                dataGridViewLoaiPhieuXuat.CurrentCell = dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColTenLoaiPhieuXuat"];
                dataGridViewLoaiPhieuXuat.BeginEdit(true);
                flag = false;
            }

            if (flag)
            {
                LoaiPhieuXuatDTO loaiPhieuXuatDTO = new LoaiPhieuXuatDTO();
                loaiPhieuXuatDTO.TenLoaiPhieuXuat = dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColTenLoaiPhieuXuat"].Value.ToString();
                if (Status == 1)    //Thêm loại phiếu xuất
                {
                    loaiPhieuXuatDTO.MaLoaiPhieuXuat = LoaiPhieuXuatBUS.CreateLoaiPhieuXuatId();
                    dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColMaLoaiPhieuXuat"].Value = loaiPhieuXuatDTO.MaLoaiPhieuXuat;
                    dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColSTT"].Value = (Index + 1).ToString();
                    if (LoaiPhieuXuatBUS.InsertLoaiPhieuXuat(loaiPhieuXuatDTO))
                    {
                        dataGridViewLoaiPhieuXuat.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        dataGridViewLoaiPhieuXuat.Rows.RemoveAt(Index);
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else if (Status == 2)
                {
                    loaiPhieuXuatDTO.MaLoaiPhieuXuat = dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColMaLoaiPhieuXuat"].Value.ToString();
                    if (LoaiPhieuXuatBUS.UpdateLoaiPhieuXuatById(loaiPhieuXuatDTO))
                    {
                        dataGridViewLoaiPhieuXuat.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColTenLoaiPhieuXuat"].Value = BackupThamSoDTO.TenLoaiPhieuXuat;
                        dataGridViewLoaiPhieuXuat.Rows[Index].ReadOnly = true;
                    }
                }
                Reset();
            }
            else
            {
                dataGridViewLoaiPhieuXuat.BeginEdit(true);
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            if (Status == 1)
            {
                dataGridViewLoaiPhieuXuat.Rows.RemoveAt(Index);
            }
            else if (Status == 2)
            {
                dataGridViewLoaiPhieuXuat.Rows[Index].Cells["ColTenLoaiPhieuXuat"].Value = BackupThamSoDTO.TenLoaiPhieuXuat;
                dataGridViewLoaiPhieuXuat.Rows[Index].ReadOnly = true;
            }
            Reset();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa loại phiếu xuất", "loại phiếu xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //Lấy vị trí xóa
            if (result == DialogResult.Yes)
            {
                int i;
                Index = dataGridViewLoaiPhieuXuat.CurrentRow.Index;
                string id = dataGridViewLoaiPhieuXuat.CurrentRow.Cells["ColMaLoaiPhieuXuat"].Value.ToString();
                int stt = int.Parse(dataGridViewLoaiPhieuXuat.CurrentRow.Cells["ColSTT"].Value.ToString());
                if (LoaiPhieuXuatBUS.DeleteLoaiPhieuXuatById(id))
                {
                    dataGridViewLoaiPhieuXuat.Rows.RemoveAt(Index);
                    if (dataGridViewLoaiPhieuXuat.Rows.Count > 0)
                    {
                        bool flag = false;
                        for (i = 0; i < Index; i++)
                        {
                            if (dataGridViewLoaiPhieuXuat.Rows[i].Visible == true)
                            {
                                flag = true;
                            }
                        }
                        for (i = Index; i < dataGridViewLoaiPhieuXuat.Rows.Count; i++)
                        {
                            if (dataGridViewLoaiPhieuXuat.Rows[i].Visible == true)
                            {
                                dataGridViewLoaiPhieuXuat.Rows[i].Cells["ColSTT"].Value = stt.ToString();
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

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }


    }
}
