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
    public partial class FormQuanLyThanhVien : Form
    {
        public FormQuanLyThanhVien()
        {
            InitializeComponent();
        }
        private void FormQuanLyThanhVien_Load(object sender, EventArgs e)
        {
            panelYesNo.Location = new Point(12, 350);

            KhoiTao();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int i;
            //Ẩn các dòng không cần thiết
            for (i = 0; i < dataGridView_QuanLyThanhVien.RowCount; i++)
            {
                dataGridView_QuanLyThanhVien.Rows[i].Visible = false;
            }

            //Them một dòng vào cuối DataGridView
            //chuyển sang chế độ select cell
            //Cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridView_QuanLyThanhVien.Rows.Add();
            dataGridView_QuanLyThanhVien.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_QuanLyThanhVien.Rows[i].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT và mã)
            dataGridView_QuanLyThanhVien.Columns["ColSTT"].Visible = false;
            dataGridView_QuanLyThanhVien.Columns["ColMaThanhVien"].Visible = false;
            dataGridView_QuanLyThanhVien.Columns["ColCV"].Visible = false;
            dataGridView_QuanLyThanhVien.Columns["ColTienNo"].Visible = false;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_QuanLyThanhVien.CurrentCell = dataGridView_QuanLyThanhVien.Rows[i].Cells["ColTenThanhVien"];
            dataGridView_QuanLyThanhVien.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm

            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Thêm";
            groupBoxTimKiem.Enabled = false;
            groupBoxDSThamSo.Text = "Thêm thành viên mới";

            //Lưu trạng thái đang thực hiện
            Status = 1;//Thêm tham số
            Index = i;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {

            Index = dataGridView_QuanLyThanhVien.CurrentRow.Index;

            //Lưu lại giá trị cần cập nhật, khôi phục lại khi cập nhật không thành công hoặc hủy
            ThanhVienDTO backup = new ThanhVienDTO();
            backup.MaThanhVien = dataGridView_QuanLyThanhVien.CurrentRow.Cells["ColMaThanhVien"].Value.ToString().Trim();
            backup.TenThanhVien = dataGridView_QuanLyThanhVien.CurrentRow.Cells["ColTenThanhVien"].Value.ToString().Trim();
            backup.DiaChi = dataGridView_QuanLyThanhVien.CurrentRow.Cells["ColDiaChi"].Value.ToString().Trim();
            //backup.CV = int.Parse(dataGridView_QuanLyThanhVien.CurrentRow.Cells["ColCV"].Value.ToString());
            //backup.TienNo = float.Parse(dataGridView_QuanLyThanhVien.CurrentRow.Cells["ColTienNo"].Value.ToString());
            BackupThanhVienDTO = backup;


            //Ẩn các dòng không cần thiết
            for (int i = 0; i < dataGridView_QuanLyThanhVien.RowCount; i++)
            {
                if (i != Index)
                {
                    dataGridView_QuanLyThanhVien.Rows[i].Visible = false;
                }
            }

            //chuyển sang chế độ select cell, cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridView_QuanLyThanhVien.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_QuanLyThanhVien.Rows[Index].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT)
            dataGridView_QuanLyThanhVien.Columns["ColSTT"].Visible = false;
            dataGridView_QuanLyThanhVien.Columns["ColCV"].Visible = false;
            dataGridView_QuanLyThanhVien.Columns["ColTienNo"].Visible = false;


            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_QuanLyThanhVien.CurrentCell = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTenThanhVien"];
            dataGridView_QuanLyThanhVien.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm

            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Cập Nhật";
            groupBoxTimKiem.Enabled = false;
            groupBoxDSThamSo.Text = "Cập nhật thành viên";

            Status = 2;//cập nhật tham số

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Xóa thành viên", "Thành viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                Index = dataGridView_QuanLyThanhVien.CurrentRow.Index;
                string id = dataGridView_QuanLyThanhVien.CurrentRow.Cells["ColMaThanhVien"].Value.ToString().Trim();
                bool xoa = ThanhVienBUS.DeleteThanhVienById(id);
                if (xoa == true)
                {
                    dataGridView_QuanLyThanhVien.Rows.RemoveAt(Index);
                    if (dataGridView_QuanLyThanhVien.Rows.Count > 0)
                    {
                        bool flag = false;
                        for (int i = 0; i < Index; i++)
                        {
                            if (dataGridView_QuanLyThanhVien.Rows[i].Visible == true)
                            {
                                flag = true;
                            }
                        }
                        for (int i = Index; i < dataGridView_QuanLyThanhVien.RowCount; i++)
                        {
                            if (dataGridView_QuanLyThanhVien.Rows[i].Visible == true)
                            {
                                dataGridView_QuanLyThanhVien.Rows[i].Cells["ColSTT"].Value = (i).ToString();
                                flag = true;
                            }
                        }
                        if (flag == false)
                        {
                            buttonDisabled();
                        }
                    }
                }
                else
                {
                    buttonEnabled();
                }
            }
        }

        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            textBoxMaThanhVien.Text = null;
            textBoxTenThanhVien.Text = null;
            textBoxDiaChi.Text = null;
            textBoxCV.Text = null;
            textBoxTienNo.Text = null;
           
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTenThanhVien"].Value == null)
            {
                MessageBox.Show("Tên thành viên không được để trống");
                dataGridView_QuanLyThanhVien.CurrentCell = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTenThanhVien"];
                dataGridView_QuanLyThanhVien.BeginEdit(true);
                flag = false;
            }
            else if (dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColDiaChi"].Value == null)
            {
                MessageBox.Show("Địa chỉ không được để trống");
                dataGridView_QuanLyThanhVien.CurrentCell = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColDiaChi"];
                dataGridView_QuanLyThanhVien.BeginEdit(true);
                flag = false;
            }




            if (flag)
            {
                //ThanhVienDTO tvDTO = new ThanhVienDTO();
                //tvDTO.TenThanhVien = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTenThanhVien"].Value.ToString();
                //tvDTO.DiaChi = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColDiaChi"].Value.ToString();
                //tvDTO.CV = 0;//int.Parse(dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColCV"].Value.ToString());
                //tvDTO.TienNo = 0;//float.Parse(dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTienNo"].Value.ToString());
                if (Status == 1)//Them tham so
                {
                    ThanhVienDTO tvDTO = new ThanhVienDTO();
                    tvDTO.TenThanhVien = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTenThanhVien"].Value.ToString().Trim();
                    tvDTO.DiaChi = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColDiaChi"].Value.ToString().Trim();
                    tvDTO.CV = 0;
                    tvDTO.TienNo = 0;
                    tvDTO.MaThanhVien = ThanhVienBUS.CreateThanhVienId().Trim();
                    dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColMaThanhVIen"].Value = tvDTO.MaThanhVien;
                    dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColSTT"].Value = (Index + 1).ToString();
                    if (ThanhVienBUS.InsertThanhVien(tvDTO))
                    {
                        dataGridView_QuanLyThanhVien.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Thêm thành công");
                        dataGridView_QuanLyThanhVien.Rows[dataGridView_QuanLyThanhVien.Rows.Count - 1].Cells["ColCV"].Value = tvDTO.CV;
                        dataGridView_QuanLyThanhVien.Rows[dataGridView_QuanLyThanhVien.Rows.Count - 1].Cells["ColTienNo"].Value = tvDTO.TienNo;
                    }
                    else
                    {
                        dataGridView_QuanLyThanhVien.Rows.RemoveAt(Index);
                        MessageBox.Show("Thêm thất bại");
                    }

                }
                else if (Status == 2)
                {
                    ThanhVienDTO tvDTO = new ThanhVienDTO();
                    tvDTO.TenThanhVien = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTenThanhVien"].Value.ToString().Trim();
                    tvDTO.DiaChi = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColDiaChi"].Value.ToString().Trim();
                    tvDTO.CV = int.Parse(dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColCV"].Value.ToString().Trim());
                    tvDTO.TienNo = float.Parse(dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTienNo"].Value.ToString().Trim());
                    tvDTO.MaThanhVien = dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColMaThanhVien"].Value.ToString().Trim();
                    if (ThanhVienBUS.UpdateThanhVienById(tvDTO))
                    {
                        dataGridView_QuanLyThanhVien.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTenThanhVien"].Value = BackupThanhVienDTO.TenThanhVien;
                        dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColDiaChi"].Value = BackupThanhVienDTO.DiaChi;
                        dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColCV"].Value = BackupThanhVienDTO.CV;
                        dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTienNo"].Value = BackupThanhVienDTO.TienNo;
                        dataGridView_QuanLyThanhVien.Rows[Index].ReadOnly = true;
                    }
                }

                Reset();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            if (Status == 1)
            {
                dataGridView_QuanLyThanhVien.Rows.RemoveAt(Index);
            }
            else if (Status == 2)
            {

                dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTenThanhVien"].Value = BackupThanhVienDTO.TenThanhVien;
                dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColDiaChi"].Value = BackupThanhVienDTO.DiaChi;
                dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColCV"].Value = BackupThanhVienDTO.CV;
                dataGridView_QuanLyThanhVien.Rows[Index].Cells["ColTienNo"].Value = BackupThanhVienDTO.TienNo;
                dataGridView_QuanLyThanhVien.Rows[Index].ReadOnly = true;
            }

            Reset();
        }

        private void textBoxMaThanhVien_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxTenThanhVien_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        //------------------Ham-------------------------------
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
        private ThanhVienDTO _backupThanhVienDTO;

        public ThanhVienDTO BackupThanhVienDTO
        {
            get { return _backupThanhVienDTO; }
            set { _backupThanhVienDTO = value; }
        }


        /*
         * Hàm KhoiTao
         * Tải toàn bộ danh sách tham số
        */
        private void KhoiTao()
        {
            //panelTimKiem.Visible = true;
            List<ThanhVienDTO> lsttsDTO = ThanhVienBUS.SelectThanhVienAll();
            if (lsttsDTO != null)
            {
                ThanhVienDTO item = new ThanhVienDTO();
                dataGridView_QuanLyThanhVien.Rows.Clear();
                for (int i = 0; i < lsttsDTO.Count; i++)
                {
                    item = lsttsDTO[i];
                    dataGridView_QuanLyThanhVien.Rows.Add((i + 1).ToString(), item.MaThanhVien, item.TenThanhVien, item.DiaChi, item.CV, item.TienNo);
                    dataGridView_QuanLyThanhVien.Rows[i].ReadOnly = true;
                }
                buttonLamLai.Enabled = false;
            }
            else
            {
                buttonLamLai.Enabled = true;
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
            for (int i = 0; i < dataGridView_QuanLyThanhVien.RowCount; i++)
            {

                dataGridView_QuanLyThanhVien.Rows[i].Visible = false;

                if (dataGridView_QuanLyThanhVien.Rows[i].Cells["ColMaThanhVien"].Value.ToString().ToUpper().IndexOf(textBoxMaThanhVien.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyThanhVien.Rows[i].Cells["ColTenThanhVien"].Value.ToString().ToUpper().IndexOf(textBoxTenThanhVien.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyThanhVien.Rows[i].Cells["ColDiaChi"].Value.ToString().ToUpper().IndexOf(textBoxDiaChi.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyThanhVien.Rows[i].Cells["ColCV"].Value.ToString().ToUpper().IndexOf(textBoxCV.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyThanhVien.Rows[i].Cells["ColTienNo"].Value.ToString().ToUpper().IndexOf(textBoxTienNo.Text.ToString().ToUpper()) >= 0)
                {
                    stt++;
                    dataGridView_QuanLyThanhVien.Rows[i].Visible = true;
                    dataGridView_QuanLyThanhVien.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                    vt = i;
                    break;
                }
            }

            for (int i = vt + 1; i < dataGridView_QuanLyThanhVien.RowCount; i++)
            {

                dataGridView_QuanLyThanhVien.Rows[i].Visible = false;


                if (dataGridView_QuanLyThanhVien.Rows[i].Cells["ColMaThanhVien"].Value.ToString().ToUpper().IndexOf(textBoxMaThanhVien.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyThanhVien.Rows[i].Cells["ColTenThanhVien"].Value.ToString().ToUpper().IndexOf(textBoxTenThanhVien.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyThanhVien.Rows[i].Cells["ColDiaChi"].Value.ToString().ToUpper().IndexOf(textBoxDiaChi.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyThanhVien.Rows[i].Cells["ColCV"].Value.ToString().ToUpper().IndexOf(textBoxCV.Text.ToString().ToUpper()) >= 0
                    && dataGridView_QuanLyThanhVien.Rows[i].Cells["ColTienNo"].Value.ToString().ToUpper().IndexOf(textBoxTienNo.Text.ToString().ToUpper()) >= 0)
                {
                    stt++;
                    dataGridView_QuanLyThanhVien.Rows[i].Visible = true;
                    dataGridView_QuanLyThanhVien.Rows[i].Cells["ColSTT"].Value = stt.ToString();
                }
            }

            if (vt == -1)// khon co dong nao thoa
            {
                buttonDisabled();
            }
            else
            {
                buttonEnabled();
                dataGridView_QuanLyThanhVien.CurrentCell = dataGridView_QuanLyThanhVien.Rows[vt].Cells[0];
                dataGridView_QuanLyThanhVien.CurrentCell.Selected = true;
            }
        }
        // Ham hien thi cac button
        private void buttonEnabled()
        {
            buttonXemChiTiet.Enabled = true;
            buttonCapNhat.Enabled = true;
            buttonXoa.Enabled = true;
        }

        private void buttonDisabled()
        {
            buttonXemChiTiet.Enabled = false;
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
            dataGridView_QuanLyThanhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView_QuanLyThanhVien.Columns["ColSTT"].Visible = true;
            dataGridView_QuanLyThanhVien.Columns["ColMaThanhVien"].Visible = true;
            dataGridView_QuanLyThanhVien.Columns["ColCV"].Visible = true;
            dataGridView_QuanLyThanhVien.Columns["ColTienNo"].Visible = true;

            //Cập nhật lại các giá trị ban đầu cho Pannel
            panelYesNo.Visible = false;
            panelTimKiem.Visible = true;
            groupBoxTimKiem.Enabled = true;
            groupBoxDSThamSo.Text = "Danh sách thành viên";

            Status = 0;
            Index = -1;

            for (int i = 0; i < dataGridView_QuanLyThanhVien.RowCount; i++)
            {
                dataGridView_QuanLyThanhVien.Rows[i].Visible = true;
            }

        }
    }
}
