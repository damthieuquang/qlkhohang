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
    public partial class FormChiTietNhanVien : Form
    {
        public FormChiTietNhanVien()
        {
            InitializeComponent();
        }

        public string maNhanVien;


        private void FormChiTietNhanVien_Load(object sender, EventArgs e)
        {
            //Tao node goc
            TreeNode nodeNhanVien = new TreeNode();
            nodeNhanVien.Text = NhanVienBUS.SelectNhanVienById(maNhanVien).TenNhanVien;
            nodeNhanVien.Tag = "NULL|NULL";
            treeViewNhanVien.Nodes.Add(nodeNhanVien);

            //Node cap 2
            TreeNode nodeNhapHang = new TreeNode();
            nodeNhapHang.Text = "Nhập hàng";
            nodeNhapHang.Tag = "NhapHang|NULL";
            nodeNhanVien.Nodes.Add("Nhập hàng");
            TreeNode nodeXuatHang = new TreeNode();
            nodeXuatHang.Text = "Xuất hàng";
            nodeXuatHang.Tag = "XuatHang|NULL";
            nodeNhanVien.Nodes.Add(nodeXuatHang);

            //Node cap 3
            List<PhieuNhapDTO> listPhieuNhapDTO = PhieuNhapBUS.SelectPhieuNhapAll();
            if (listPhieuNhapDTO != null)
            {
                foreach (PhieuNhapDTO itemPhieuNhapDTO in listPhieuNhapDTO)
                {
                    nodeNhapHang.Nodes.Add(itemPhieuNhapDTO.NgayNhan.ToString("dd/MM/yyyy"));
                }
            }

            List<PhieuXuatDTO> listPhieuXuatDTO = PhieuXuatBUS.SelectPhieuXuatAll();
            if (listPhieuXuatDTO != null)
            {
                foreach (PhieuXuatDTO itemPhieuXuatDTO in listPhieuXuatDTO)
                {
                    nodeXuatHang.Nodes.Add(itemPhieuXuatDTO.NgayBan.ToString("dd/MM/yyyy"));
                }
            }  

            //Load 
        }

        private void treeViewNhanVien_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

    }
}
