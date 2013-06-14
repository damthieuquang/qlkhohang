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
    public partial class FormQuanLyNhanVien : Form
    {
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        //Status = 1: Thêm nhân viên
        //Status = 2: Cập nhật nhân viên
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
        private NhanVienDTO _backupNhanVienDTO;

        public NhanVienDTO BackupNhanVienDTO
        {
            get { return _backupNhanVienDTO; }
            set { _backupNhanVienDTO = value; }
        }

        private void KhoiTaoComboBoxLoaiNhanVien()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("text");
            dt.Columns.Add("value");
            dt.Rows.Add("Tất cả", "");
            dt.Rows.Add("Giám đốc", "0");
            dt.Rows.Add("Nhân viên", "1");
            comboBoxLoaiNhanVien.DisplayMember = "text";
            comboBoxLoaiNhanVien.ValueMember = "value";
            comboBoxLoaiNhanVien.DataSource = dt;

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("text");
            dt2.Columns.Add("value");
            dt2.Rows.Add("Giám đốc", "0");
            dt2.Rows.Add("Nhân viên", "1");
            clComboBoxLoaiNhanVien.DataSource = dt2;
            clComboBoxLoaiNhanVien.DisplayMember = "text";
            clComboBoxLoaiNhanVien.ValueMember = "value";



        }

        private void KhoiTao()
        {
            List<NhanVienDTO> listNhanVienDTO = NhanVienBUS.SelectNhanVienAll();
            if (listNhanVienDTO != null)
            {
                dataGridView_NhanVien.Rows.Clear();
                NhanVienDTO item = new NhanVienDTO();
                for (int i = 0; i < listNhanVienDTO.Count; i++)
                {
                    item = listNhanVienDTO[i];
                    dataGridView_NhanVien.Rows.Add((i + 1).ToString(), item.MaNhanVien, item.TenNhanVien, item.MatKhau, item.LoaiNhanVien.ToString());
                    dataGridView_NhanVien.Rows[i].ReadOnly = true;
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
        //ham hieu chinh cac nut:
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

        //Ham search:
        private void Search()
        {
            int stt = 0;
            int vt = -1;
            for (int i = 0; i < dataGridView_NhanVien.RowCount; i++)
            {
                dataGridView_NhanVien.Rows[i].Visible = false;
                if (dataGridView_NhanVien.Rows[i].Cells["clMaNhanVien"].Value.ToString().ToUpper().IndexOf(txtMaNhanVien.Text.ToString().ToUpper()) >= 0
                    && dataGridView_NhanVien.Rows[i].Cells["clTenNhanVien"].Value.ToString().ToUpper().IndexOf(txtTenNhanVien.Text.ToString().ToUpper()) >= 0
                    && (comboBoxLoaiNhanVien.SelectedValue.ToString() == "" || dataGridView_NhanVien.Rows[i].Cells["clComboBoxLoaiNhanVien"].Value.ToString().ToUpper().IndexOf(comboBoxLoaiNhanVien.SelectedValue.ToString().ToUpper()) >= 0))
                {
                    stt++;
                    dataGridView_NhanVien.Rows[i].Visible = true;
                    dataGridView_NhanVien.Rows[i].Cells["clSTT"].Value = stt.ToString();
                    vt = i;
                    break;
                }
            }
           
            for (int i = vt + 1; i < dataGridView_NhanVien.RowCount; i++)
            {

                dataGridView_NhanVien.Rows[i].Visible = false;
                if (dataGridView_NhanVien.Rows[i].Cells["clMaNhanVien"].Value.ToString().ToUpper().IndexOf(txtMaNhanVien.Text.ToString().ToUpper()) >= 0
                     && dataGridView_NhanVien.Rows[i].Cells["clTenNhanVien"].Value.ToString().ToUpper().IndexOf(txtTenNhanVien.Text.ToString().ToUpper()) >= 0
                     && (comboBoxLoaiNhanVien.SelectedValue.ToString() == "" || dataGridView_NhanVien.Rows[i].Cells["clComboBoxLoaiNhanVien"].Value.ToString().ToUpper().IndexOf(comboBoxLoaiNhanVien.SelectedValue.ToString().ToUpper()) >= 0))
                {
                    stt++;
                    dataGridView_NhanVien.Rows[i].Visible = true;
                    dataGridView_NhanVien.Rows[i].Cells["clSTT"].Value = stt.ToString();
                }
            }

            if (vt == -1)// khon co dong nao thoa
            {
                buttonDisabled();
            }
            else
            {
                buttonEnabled();
                dataGridView_NhanVien.CurrentCell = dataGridView_NhanVien.Rows[vt].Cells[0];
                dataGridView_NhanVien.CurrentCell.Selected = true;
            }
        }


        private void Reset()
        {
            //Cập nhật lại các giá trị ban đầu cho DataGridView
            dataGridView_NhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView_NhanVien.Columns["clSTT"].Visible = true;
            dataGridView_NhanVien.Columns["clMaNhanVien"].Visible = true;
            dataGridView_NhanVien.Columns[clComboBoxLoaiNhanVien.Index].Visible = true;
            clComboBoxLoaiNhanVien.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;


            //Cập nhật lại các giá trị ban đầu cho Pannel
            panelYesNo.Visible = false;
            panelTimKiem.Visible = true;
            groupBoxTimKiem.Enabled = true;
            groupBoxDanhSach.Text = "Danh sách nhân viên";

            Status = 0;
            Index = -1;

            for (int i = 0; i < dataGridView_NhanVien.RowCount; i++)
            {
                dataGridView_NhanVien.Rows[i].Visible = true;
            }

            dataGridView_NhanVien.CurrentCell = dataGridView_NhanVien.Rows[0].Cells[0];
            //Khởi động lại các nút:
            if (dataGridView_NhanVien.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView_NhanVien.Rows.Count; i++)
                {
                    if (dataGridView_NhanVien.Rows[i].Visible == true)
                    {
                        buttonEnabled();
                        break;
                    }
                }
            }
            else
                buttonDisabled();
        }

        private void FormQuanLyNhanVien_Activated(object sender, EventArgs e)
        {
            KhoiTaoComboBoxLoaiNhanVien();
            KhoiTao();
            panelYesNo.Parent = panelFull;
            panelYesNo.Location = new Point(17, 390);
        }

        private void FormQuanLyNhanVien_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panelFull.Width) / 2;
            panelFull.Location = new Point(x, panelFull.Location.Y);
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void comboBoxLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }



        private void buttonLamLai_Click(object sender, EventArgs e)
        {
            comboBoxLoaiNhanVien.SelectedIndex = 0;
            txtMaNhanVien.Text = null;
            txtTenNhanVien.Text = null;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int i;
            //Ẩn các dòng không cần thiết
            for (i = 0; i < dataGridView_NhanVien.RowCount; i++)
            {
                dataGridView_NhanVien.Rows[i].Visible = false;
            }

            //Them một dòng vào cuối DataGridView
            //chuyển sang chế độ select cell
            //Cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridView_NhanVien.Rows.Add();
            dataGridView_NhanVien.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_NhanVien.Rows[i].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT và mã)
            dataGridView_NhanVien.Columns["clSTT"].Visible = false;
            dataGridView_NhanVien.Columns["clMaNhanVien"].Visible = false;

            //Hiện cột comboxloai nhân vien
            dataGridView_NhanVien.Rows[i].Cells["clComboBoxLoaiNhanVien"].Value = "0";
            clComboBoxLoaiNhanVien.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;


            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_NhanVien.CurrentCell = dataGridView_NhanVien.Rows[i].Cells["clTenNhanVien"];
            dataGridView_NhanVien.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Thêm";
            groupBoxTimKiem.Enabled = false;
            groupBoxDanhSach.Text = "Thêm nhân viên mới";

            //Lưu trạng thái đang thực hiện
            Status = 1;//Thêm 
            Index = i;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            //Lấy vị trí cần cập nhật
            Index = dataGridView_NhanVien.CurrentRow.Index;

            //Lưu lại giá trị cần cập nhật, khôi phục lại khi cập nhật không thành công hoặc hủy
            NhanVienDTO backup = new NhanVienDTO();
            backup.MaNhanVien = dataGridView_NhanVien.CurrentRow.Cells["clMaNhanVien"].Value.ToString();
            backup.TenNhanVien = dataGridView_NhanVien.CurrentRow.Cells["clTenNhanVien"].Value.ToString();
            backup.MatKhau = dataGridView_NhanVien.CurrentRow.Cells["clMatKhau"].Value.ToString();
            backup.LoaiNhanVien = int.Parse(dataGridView_NhanVien.CurrentRow.Cells["clComboBoxLoaiNhanVien"].Value.ToString());
            BackupNhanVienDTO = backup;


            //Ẩn các dòng không cần thiết
            for (int i = 0; i < dataGridView_NhanVien.RowCount; i++)
            {
                if (i != Index)
                {
                    dataGridView_NhanVien.Rows[i].Visible = false;
                }
            }

            //chuyển sang chế độ select cell, cập nhật lại thuộc tính readOnly cho phép chỉnh sữa
            dataGridView_NhanVien.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_NhanVien.Rows[Index].ReadOnly = false;

            //Ẩn các cột không cần thiết (STT)
            dataGridView_NhanVien.Columns["clSTT"].Visible = false;

            //Hiện cột comboxloai nhân vien
            clComboBoxLoaiNhanVien.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;

            //Set mặc định ô sẽ chỉnh sữa đầu tiên
            dataGridView_NhanVien.CurrentCell = dataGridView_NhanVien.Rows[Index].Cells["clTenNhanVien"];
            dataGridView_NhanVien.BeginEdit(true);

            //Show panel thêm và ẩn đi panel tìm kiếm
            panelYesNo.Visible = true;
            panelTimKiem.Visible = false;
            buttonYes.Text = "Cập nhật";
            groupBoxTimKiem.Enabled = false;
            groupBoxDanhSach.Text = "Cập nhật nhân viên";

            Status = 2;//cập nhật
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (dataGridView_NhanVien.Rows[Index].Cells["clTenNhanVien"].Value == null)
            {
                MessageBox.Show("Tên nhân viên không được để trống");
                dataGridView_NhanVien.CurrentCell = dataGridView_NhanVien.Rows[Index].Cells["clTenNhanVien"];
                flag = false;
            }
            else if (dataGridView_NhanVien.Rows[Index].Cells["clMatKhau"].Value == null)
            {
                MessageBox.Show("Mật khẩu không được để trống");
                dataGridView_NhanVien.CurrentCell = dataGridView_NhanVien.Rows[Index].Cells["clMatKhau"];
                flag = false;
            }

            if (flag)
            {
                NhanVienDTO nhanVienDTO = new NhanVienDTO();
                nhanVienDTO.TenNhanVien = dataGridView_NhanVien.Rows[Index].Cells["clTenNhanVien"].Value.ToString();
                nhanVienDTO.MatKhau = dataGridView_NhanVien.Rows[Index].Cells["clMatKhau"].Value.ToString();
                nhanVienDTO.LoaiNhanVien = int.Parse(dataGridView_NhanVien.CurrentRow.Cells["clComboBoxLoaiNhanVien"].Value.ToString());

                if (Status == 1)//Them tham so
                {
                    nhanVienDTO.MaNhanVien = NhanVienBUS.CreateNhanVienById();
                    dataGridView_NhanVien.Rows[Index].Cells["clMaNhanVien"].Value = nhanVienDTO.MaNhanVien;
                    dataGridView_NhanVien.Rows[Index].Cells["clSTT"].Value = (Index + 1).ToString();


                    if (NhanVienBUS.InsertNhanVien(nhanVienDTO))
                    {
                        dataGridView_NhanVien.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        dataGridView_NhanVien.Rows.RemoveAt(Index);
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else if (Status == 2)
                {
                    nhanVienDTO.MaNhanVien = dataGridView_NhanVien.Rows[Index].Cells["clMaNhanVien"].Value.ToString();
                    if (NhanVienBUS.UpdateNhanVienById(nhanVienDTO))
                    {
                        dataGridView_NhanVien.Rows[Index].ReadOnly = true;
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        dataGridView_NhanVien.Rows[Index].Cells["clTenNhanVien"].Value = BackupNhanVienDTO.TenNhanVien;
                        dataGridView_NhanVien.Rows[Index].Cells["clMatKhau"].Value = BackupNhanVienDTO.MatKhau;
                        dataGridView_NhanVien.CurrentRow.Cells["clComboBoxLoaiNhanVien"].Value = BackupNhanVienDTO.LoaiNhanVien.ToString();
                        dataGridView_NhanVien.Rows[Index].ReadOnly = true;
                    }
                }

                Reset();
            }
            else
            {
                dataGridView_NhanVien.BeginEdit(true);
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            if (Status == 1)
            {
                dataGridView_NhanVien.Rows.RemoveAt(Index);
            }
            else if (Status == 2)
            {
                dataGridView_NhanVien.Rows[Index].Cells["clTenNhanVien"].Value = BackupNhanVienDTO.TenNhanVien;
                dataGridView_NhanVien.Rows[Index].Cells["clMatKhau"].Value = BackupNhanVienDTO.MatKhau;
                dataGridView_NhanVien.CurrentRow.Cells["clComboBoxLoaiNhanVien"].Value = BackupNhanVienDTO.LoaiNhanVien.ToString();
            }

            Reset();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xóa nhân viên", "Nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //Lấy vị trí cần xóa
            if (res == DialogResult.Yes)
            {
                Index = dataGridView_NhanVien.CurrentRow.Index;
                string id = dataGridView_NhanVien.CurrentRow.Cells["clMaNhanVien"].Value.ToString().Trim();
                int stt = int.Parse(dataGridView_NhanVien.CurrentRow.Cells["clSTT"].Value.ToString());
                if (NhanVienBUS.DeleteNhanVienById(id))
                {
                    dataGridView_NhanVien.Rows.RemoveAt(Index);
                    if (dataGridView_NhanVien.Rows.Count > 0)
                    {
                        bool flag = false;
                        for (int i = 0; i < Index; i++)
                        {
                            if (dataGridView_NhanVien.Rows[i].Visible == true)
                            {
                                flag = true;
                            }
                        }
                        for (int i = Index; i < dataGridView_NhanVien.RowCount; i++)
                        {
                            if (dataGridView_NhanVien.Rows[i].Visible == true)
                            {
                                dataGridView_NhanVien.Rows[i].Cells["clSTT"].Value = stt.ToString();
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
                        buttonDisabled();
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonXemChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietNhanVien fChiTietNhanVien = new FormChiTietNhanVien();
            fChiTietNhanVien.maNhanVien = dataGridView_NhanVien.CurrentRow.Cells[clMaNhanVien.Index].Value.ToString();
            fChiTietNhanVien.ShowDialog();
        }



    }
}
