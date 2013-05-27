using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ThanhVienBUS
    {
        public static List<ThanhVienDTO> SelectThanhVienAll()
        {
            return ThanhVienDAO.SelectThanhVienAll();
        }

        public static ThanhVienDTO SelectThanhVienById(string MaThanhVien)
        {
            return ThanhVienDAO.SelectThanhVienById(MaThanhVien);
        }
        public static bool InsertThanhVien(ThanhVienDTO tvDTO)
        {
            return ThanhVienDAO.InsertThanhVien(tvDTO);
        }

        public static bool UpdateThanhVienById(ThanhVienDTO tvDTO)
        {
            return ThanhVienDAO.UpdateThanhVienById(tvDTO);
        }

        public static bool DeleteThanhVienById(string MaThanhVien)
        {
            return ThanhVienDAO.DeleteThanhVienById(MaThanhVien);
        }
    }

}
