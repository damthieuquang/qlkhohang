using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        public static bool InsertLoaiSanPham(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            return LoaiSanPhamDAO.InsertLoaiSanPham(loaiSanPhamDTO);
        }

        public static bool UpdateLoaiSanPham(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            return LoaiSanPhamDAO.UpdateLoaiSanPham(loaiSanPhamDTO);
        }

        public static bool DeleteLoaiSanPham(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            return LoaiSanPhamDAO.DeleteLoaiSanPham(loaiSanPhamDTO);
        }

        public static List<LoaiSanPhamDTO> SelectLoaiSanPhamAll()
        {
            return LoaiSanPhamDAO.SelectLoaiSanPhamAll();
        }

        public static LoaiSanPhamDTO SelectLoaiSanPhamById(string MaLoaiSanPham)
        {
            return LoaiSanPhamDAO.SelectLoaiSanPhamById(MaLoaiSanPham);
        }
    }
}
