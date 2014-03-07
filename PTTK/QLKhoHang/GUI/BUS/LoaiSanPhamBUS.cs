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
        public static string CreateLoaiSanPhamId()
        {
            return LoaiSanPhamDAO.CreateLoaiSanPhamId();
        }
        public static bool InsertLoaiSanPham(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            return LoaiSanPhamDAO.InsertLoaiSanPham(loaiSanPhamDTO);
        }

        public static bool UpdateLoaiSanPhamById(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            return LoaiSanPhamDAO.UpdateLoaiSanPhamById(loaiSanPhamDTO);
        }

        public static bool DeleteLoaiSanPhamById(string maLoaiSanPham)
        {
            return LoaiSanPhamDAO.DeleteLoaiSanPhamById(maLoaiSanPham);
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
