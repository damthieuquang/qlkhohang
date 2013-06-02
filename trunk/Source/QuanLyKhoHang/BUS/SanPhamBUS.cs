using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> SelectSanPhamAll()
        {
            return SanPhamDAO.SelectSanPhamAll();
        }

        public static SanPhamDTO SelectSanPhamById(string MaSanPham)
        {
            return SanPhamDAO.SelectSanPhamById(MaSanPham);
        }

        public static bool InsertSanPham(SanPhamDTO spDTO)
        {
            return SanPhamDAO.InsertSanPham(spDTO);
        }

        public static bool UpdateSanPhamById(SanPhamDTO spDTO)
        {
            return SanPhamDAO.UpdateSanPhamById(spDTO);
        }
        public static bool UpdateSanPhamByMaSanPham(string MaSanPham,int SoLuong)
        {
            return SanPhamDAO.UpdateSanPhamByMaSanPham(MaSanPham, SoLuong);
        }
        public static bool DeleteSanPhamById(string MaSanPham)
        {
            return SanPhamDAO.DeleteSanPhamById(MaSanPham);
        }

	public static string CreateSanPhamId()
        {
            return SanPhamDAO.CreateSanPhamId();
        }
    }
}
