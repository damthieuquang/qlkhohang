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
    public partial class FormQuanLyThamSo : Form
    {
        public FormQuanLyThamSo()
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

        //lưu vị trí dang xu ly
        private int _index;

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        //
        private ThamSoDTO _backupThamSoDTO;

        public ThamSoDTO BackupThamSoDTO
        {
            get { return _backupThamSoDTO; }
            set { _backupThamSoDTO = value; }
        }


        /*
         * Hàm KhoiTao
         * Tải toàn bộ danh sách tham số
        */
        private void KhoiTao()
        {
            List<ThamSoDTO> listThamSoDTO = ThamSoBUS.SelectThamSoAll();
            if (listThamSoDTO != null)
            {
                ThamSoDTO item = new ThamSoDTO();
                dataGridViewThamSo.Rows.Clear();
                for (int i = 0; i < listThamSoDTO.Count; i++)
                {
                    item = listThamSoDTO[i];
                    dataGridViewThamSo.Rows.Add((i + 1).ToString(), item.MaThamSo, item.TenThamSo, item.GiaTri);
                    dataGridViewThamSo.Rows[i].ReadOnly = true;
                }
                buttonLamLai.Enabled = true;
                buttonEnabled();


            }
            else
            {
                buttonDisabled();
                buttonLamLai.Enabled = false;
            }

        }
        //Hàm hiệu chỉnh các button:
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
            for (int i = 0; i < dataGridViewThamSo.Rows.Count; i++)
            {
                dataGridViewThamSo.Rows[i].Visible = false;
                if (dataGridViewThamSo.Rows[i].Cells["ColMaThamSo"].Value.ToString().ToUpper().IndexOf(textBoxMaThamSo.Text.ToString().ToUpper()) >= 0
                    && dataGridViewThamSo.Rows[i].Cells["ColTenThamSo"].Value.ToString().ToUpper().IndexOf(textBoxTenThamSo.Text.ToString().ToUpper()) >= 0
                    && dataGridViewThamSo.Rows[i].Cells["ColGiaTri"].Value.ToString().ToUpper().IndexOf(textBoxGiaTri.Text.ToString().ToUpper()) >= 0)
                {
                    stt++;
                    dataGridViewThamSo.Rows[i].Visible = true;
                    dataGridViewThamSo.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                    vt = i;
                    break;
                }
            }
            for (int i = vt + 1; i < dataGridViewThamSo.Rows.Count; i++)
            {
                dataGridViewThamSo.Rows[i].Visible = false;
                if (dataGridViewThamSo.Rows[i].Cells["ColMaThamSo"].Value.ToString().ToUpper().IndexOf(textBoxMaThamSo.Text.ToString().ToUpper()) >= 0
                    && dataGridViewThamSo.Rows[i].Cells["ColTenThamSo"].Value.ToString().ToUpper().IndexOf(textBoxTenThamSo.Text.ToString().ToUpper()) >= 0
                    && dataGridViewThamSo.Rows[i].Cells["ColGiaTri"].Value.ToString().ToUpper().IndexOf(textBoxGiaTri.Text.ToString().ToUpper()) >= 0)
                {
                    stt++;
                    dataGridViewThamSo.Rows[i].Visible = true;
                    dataGridViewThamSo.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                }
            }
            if (vt == -1)// khon co dong nao thoa
            {
                buttonDisabled();
            }
            else
            {
                buttonEnabled();
                dataGridViewThamSo.CurrentCell = dataGridViewThamSo.Rows[vt].Cells[0];
                dataGridViewThamSo.CurrentCell.Selected = true;
            }
        }

        /*
          * Hàm Reset
          * Cập nhật lại các thuộc tính ban đầu cho DataGridView và panel 
         */
        private void Reset()
        {
            //Cập nhật lại các giá trị ban đầu cho DataGridView
            dataGridViewThamSo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewThamSo.Columns["ColSTT"].Visible = true;
            dataGridViewThamSo.Columns["ColMaThamSo"].Visible = true;


            //Cập nhật lại các giá trị ban đầu cho Pannel
            panelYesNo.Visible = false;
            groupBoxTimKiem.Visible = true;
            groupBoxDSThamSo.Text = "Danh sách tham so";

            Status = 0;
            Index = -1;

            for (int i = 0; i < dataGridViewThamSo.RowCount; i++)
            {
                dataGridViewThamSo.Rows[i].Visible = true;
            }

            dataGridViewThamSo.CurrentCell = dataGridViewThamSo.Rows[0].Cells[0];
            //Khởi động lại các nút:
            if (dataGridViewThamSo.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridViewThamSo.Rows.Count; i++)
                {
                    if (dataGridViewThamSo.Rows[i].Visible == true)
                    {
                        buttonEnabled();
                        break;
                    }
                }
            }
            else
                buttonDisabled();

        }

        private void FormQuanLyThamSo_Activated(object sender, EventArgs e)
        {
            panelYesNo.Location = new Point(12, 400);
            KhoiTao();
        }

        private void textBoxMaThamSo_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxTenThamSo_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxGiaTri_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            textBoxMaThamSo.Text = null;
            textBoxTenThamSo.Text = null;
            textBoxGiaTri.Text = null;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int i;
            //Ẩn các dòng không cần thiết
            for (i = 0; i < dataGridViewThamSo.RowCount; i++)
            {
                dataGridViewThamSo.Rows[i].Visible = false;
            }

            //Them một dòng vào cuối DataGridView
            //chuyển sang chế độ select cell
            //Cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridViewThamSo.Rows.Add();
            dataGridViewThamSo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewThamSo.Rows[i].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT và mã)
            dataGridViewThamSo.Columns["ColSTT"].Visible = false;
            dataGridViewThamSo.Columns["ColMaThamSo"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridViewThamSo.CurrentCell = dataGridViewThamSo.Rows[i].Cells["ColTenThamSo"];
            dataGridViewThamSo.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Location = new Point(12, 400);
            panelYesNo.Visible = true;
            buttonYes.Text = "Thêm";
            groupBoxTimKiem.Visible = false;
            groupBoxDSThamSo.Text = "Thêm tham số mới";

            //Lưu trạng thái đang thực hiện
            Status = 1;//Thêm tham số
            Index = i;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            //Lấy vị trí cần cập nhật
            Index = dataGridViewThamSo.CurrentRow.Index;

            //Lưu lại giá trị cần cập nhật, khôi phục lại khi cập nhật không thành công hoặc hủy
            ThamSoDTO backup = new ThamSoDTO();
            backup.MaThamSo = dataGridViewThamSo.CurrentRow.Cells["ColMaThamSo"].Value.ToString().Trim();
            backup.TenThamSo = dataGridViewThamSo.CurrentRow.Cells["ColTenThamSo"].Value.ToString().Trim();
            backup.GiaTri = dataGridViewThamSo.CurrentRow.Cells["ColGiaTri"].Value.ToString();
            BackupThamSoDTO = backup;


            //Ẩn các dòng không cần thiết
            for (int i = 0; i < dataGridViewThamSo.RowCount; i++)
            {
                if (i != Index)
                {
                    dataGridViewThamSo.Rows[i].Visible = false;
                }
            }

            //chuyển sang chế độ select cell, cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridViewThamSo.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewThamSo.Rows[Index].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT)
            dataGridViewThamSo.Columns["ColSTT"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridViewThamSo.CurrentCell = dataGridViewThamSo.Rows[Index].Cells["ColTenThamSo"];
            dataGridViewThamSo.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Location = new Point(12, 400);
            panelYesNo.Visible = true;
            buttonYes.Text = "Cập Nhật";
            groupBoxTimKiem.Visible = false;
            groupBoxDSThamSo.Text = "Cập nhật tham số";

            Status = 2;//cập nhật tham số
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (dataGridViewThamSo.Rows[Index].Cells["ColTenThamSo"].Value == null)
            {
                MessageBox.Show("Tên tham số không được để trống");
                dataGridViewThamSo.CurrentCell = dataGridViewThamSo.Rows[Index].Cells["ColTenThamSo"];
                dataGridViewThamSo.BeginEdit(true);
                flag = false;
            }
            else if (dataGridViewThamSo.Rows[Index].Cells["ColGiaTri"].Value == null)
            {
                MessageBox.Show("Giá trị không được để trống");
                dataGridViewThamSo.CurrentCell = dataGridViewThamSo.Rows[Index].Cells["ColGiaTri"];
                dataGridViewThamSo.BeginEdit(true);
                flag = false;
            }

            if (flag)
            {
                ThamSoDTO thamSoDTO = new ThamSoDTO();
                thamSoDTO.TenThamSo = dataGridViewThamSo.Rows[Index].Cells["ColTenThamSo"].Value.ToString();
                thamSoDTO.GiaTri = dataGridViewThamSo.Rows[Index].Cells["ColGiaTri"].Value.ToString();
                if (Status == 1)//Them tham so
                {
                    thamSoDTO.MaThamSo = ThamSoBUS.CreateThamSoId();
                    dataGridViewThamSo.Rows[Index].Cells["ColMaThamSo"].Value = thamSoDTO.MaThamSo;
                    dataGridViewThamSo.Rows[Index].Cells["ColSTT"].Value = (Index + 1).ToString();
                    if (ThamSoBUS.InsertThamSo(thamSoDTO))
                    {
                        dataGridViewThamSo.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        dataGridViewThamSo.Rows.RemoveAt(Index);
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else if (Status == 2)
                {
                    thamSoDTO.MaThamSo = dataGridViewThamSo.Rows[Index].Cells["ColMaThamSo"].Value.ToString();
                    if (ThamSoBUS.UpdateThamSoById(thamSoDTO))
                    {
                        dataGridViewThamSo.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        dataGridViewThamSo.Rows[Index].Cells["ColTenThamSo"].Value = BackupThamSoDTO.TenThamSo;
                        dataGridViewThamSo.Rows[Index].Cells["ColGiaTri"].Value = BackupThamSoDTO.GiaTri;
                        dataGridViewThamSo.Rows[Index].ReadOnly = true;
                    }
                }

                Reset();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            if (Status == 1)
            {
                dataGridViewThamSo.Rows.RemoveAt(Index);
            }
            else if (Status == 2)
            {
                dataGridViewThamSo.Rows[Index].Cells["ColTenThamSo"].Value = BackupThamSoDTO.TenThamSo;
                dataGridViewThamSo.Rows[Index].Cells["ColGiaTri"].Value = BackupThamSoDTO.GiaTri;
                dataGridViewThamSo.Rows[Index].ReadOnly = true;
            }

            Reset();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xóa tham số", "Tham số", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                Index = dataGridViewThamSo.CurrentRow.Index;
                string id = dataGridViewThamSo.CurrentRow.Cells["ColMaThamSo"].Value.ToString().Trim();
                int stt = int.Parse(dataGridViewThamSo.CurrentRow.Cells["ColSTT"].Value.ToString());
                if (ThamSoBUS.DeleteThamSoById(id))
                {
                    dataGridViewThamSo.Rows.RemoveAt(Index);
                    if (dataGridViewThamSo.Rows.Count > 0)
                    {
                        bool flag = false;
                        for (int i = 0; i < Index; i++)
                        {
                            if (dataGridViewThamSo.Rows[i].Visible == true)
                            {
                                flag = true;
                            }
                        }
                        for (int i = Index; i < dataGridViewThamSo.Rows.Count; i++)
                        {
                            if (dataGridViewThamSo.Rows[i].Visible == true)
                            {
                                dataGridViewThamSo.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                                stt++;
                                flag = true;
                            }
                        }
                        if (flag == false)
                            buttonDisabled();
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
