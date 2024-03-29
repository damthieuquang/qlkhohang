﻿using BUS;
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
    public partial class FormChonSanPham : Form
    {
        public FormChonSanPham()
        {
            InitializeComponent();
        }

        public List<SanPhamDTO> listsanPhamDTO_ChonSanPham = new List<SanPhamDTO>();
        public bool huy = true;

        private void Search()
        {
            int vt = -1;
            for (int i = dataGridView_ChonSanPham.RowCount - 1; i >= 0; i--)
            {
                dataGridView_ChonSanPham.Rows[i].Visible = false;
                if (dataGridView_ChonSanPham.Rows[i].Cells[clTenSanPham.Index].Value.ToString().ToUpper().IndexOf(textBoxTenSanPham.Text.ToString().ToUpper()) >= 0
                   && (comboBoxLoaiSanPham.SelectedValue.ToString() == "Tất cả" || dataGridView_ChonSanPham.Rows[i].Cells[clLoaiSanPham.Index].Value.ToString().ToUpper().IndexOf(comboBoxLoaiSanPham.SelectedValue.ToString().ToUpper()) >= 0))
                {
                    vt = i;
                    dataGridView_ChonSanPham.Rows[i].Visible = true;
                }
            }

            if (vt == -1)
            {
                btn_Xong.Enabled = false;
            }
            else
            {
                dataGridView_ChonSanPham.CurrentCell = dataGridView_ChonSanPham.Rows[vt].Cells[clCheck.Index];
                dataGridView_ChonSanPham.CurrentCell.Selected = true;
                btn_Xong.Enabled = true;
            }
        }

        private void FormChonSanPham_Load(object sender, EventArgs e)
        {
            List<SanPhamDTO> sanPhamDTO = new List<SanPhamDTO>();
            sanPhamDTO = SanPhamBUS.SelectSanPhamAll();

            for (int i = 0; i < sanPhamDTO.Count; i++)
            {
                dataGridView_ChonSanPham.Rows.Add(i + 1, sanPhamDTO[i].MaSanPham, sanPhamDTO[i].TenSanPham, LoaiSanPhamBUS.SelectLoaiSanPhamById(sanPhamDTO[i].MaLoaiSanPham).TenLoaiSanPham, false);
            }


            List<LoaiSanPhamDTO> lstcbspDTO = LoaiSanPhamBUS.SelectLoaiSanPhamAll();

            LoaiSanPhamDTO all = new LoaiSanPhamDTO();
            all.MaLoaiSanPham = "Tất cả";
            all.TenLoaiSanPham = "Tất cả";

            lstcbspDTO.Insert(0, all);

            comboBoxLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            comboBoxLoaiSanPham.ValueMember = "TenLoaiSanPham";
            comboBoxLoaiSanPham.DataSource = lstcbspDTO;
            comboBoxLoaiSanPham.SelectedIndex = 0;
        }

        private void btn_Xong_Click(object sender, EventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < dataGridView_ChonSanPham.RowCount; i++)
            {
                if (dataGridView_ChonSanPham.Rows[i].Cells[clCheck.Index].Value.ToString() == "True")
                {
                    listsanPhamDTO_ChonSanPham.Add(SanPhamBUS.SelectSanPhamById(dataGridView_ChonSanPham.Rows[i].Cells[clMaSanPham.Index].Value.ToString()));
                    flag = true;
                }
            }

            if (flag == false)
            {
                DialogResult result = MessageBox.Show("Chưa có sản phẩm nào được chọn, bạn muốn thoát?", "Sản phẩm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    huy = true;
                    this.Dispose();
                }
            }
            else
            {
                huy = false;
                this.Dispose();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            huy = true;
            this.Dispose();
            Dispose();            
        }

        private void textBoxTenSanPham_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void comboBoxLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
