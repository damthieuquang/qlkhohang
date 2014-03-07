using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        public static NhanVienDTO SelectNhanVienById (string maNhanVien)
        {
            return NhanVienDAO.SelectNhanVienById(maNhanVien);
        }
        public static List<NhanVienDTO> SelectNhanVienAll()
        {
            return NhanVienDAO.SelectNhanVienAll();
        }
        public static bool InsertNhanVien(NhanVienDTO nhanVienDTO)
        {
            return NhanVienDAO.InsertNhanVien(nhanVienDTO);
        }
        public static bool UpdateNhanVienById(NhanVienDTO nhanVienDTO)
        {
            return NhanVienDAO.UpdateNhanVienById(nhanVienDTO);
        }
        public static bool DeleteNhanVienById(string maNhanVien)
        {
            return NhanVienDAO.DeleteNhanVienById(maNhanVien);
        }

        public static string CreateNhanVienById()
        {
            return NhanVienDAO.CreateNhanVientId();
        }
       
    }
}
