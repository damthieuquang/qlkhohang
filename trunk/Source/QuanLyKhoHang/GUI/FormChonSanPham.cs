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
    public partial class FormChonSanPham : Form
    {
        public FormChonSanPham()
        {
            InitializeComponent();
        }

        public List<SanPhamDTO> listsanPhamDTO_ChonSanPham = new List<SanPhamDTO>();

        private void FormChonSanPham_Load(object sender, EventArgs e)
        {
            List<SanPhamDTO> sanPhamDTO = new List<SanPhamDTO>();
            sanPhamDTO = SanPhamBUS.SelectSanPhamAll();

            for (int i = 0; i < sanPhamDTO.Count; i++)
            {
                dataGridView_ChoSanPham.Rows.Add(i + 1, sanPhamDTO[i].MaSanPham, sanPhamDTO[i].TenSanPham);
            }

        }

        private void dataGridView_ChoSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_ChoSanPham.CurrentRow.Cells[e.ColumnIndex].Selected)
            {                
                SanPhamDTO sanpham = new SanPhamDTO();
                sanpham.MaSanPham = dataGridView_ChoSanPham.CurrentRow.Cells["clMaSanPham"].Value.ToString();
                listsanPhamDTO_ChonSanPham.Add(sanpham);
            }
        }

        private bool CheckOut_Selected()
        {
            for (int i = 0; i < dataGridView_ChoSanPham.Rows.Count; i++)
            {
                if (dataGridView_ChoSanPham.Rows[i].Cells["clCheck"].Selected)
                    return false;
            }
            return true;
        }

        private void btn_Xong_Click(object sender, EventArgs e)
        {
            if (CheckOut_Selected() == true)
            {
                DialogResult result = MessageBox.Show("Chưa có sản phẩm nào được chọn, bạn muốn thoát?", "Sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    btn_Huy_Click(sender, e);
                }
                else if (result == DialogResult.No)
                {                    
                    //FormChonSanPham_Load(sender, e);
                }
                return;
            }
            Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            listsanPhamDTO_ChonSanPham.Clear();
            
            Dispose();
        }
    }
}
