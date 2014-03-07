using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class PhieuXuatBUS
    {
        public static List<PhieuXuatDTO> SelectPhieuXuatAll()
        {
            return PhieuXuatDAO.SelectPhieuXuatAll();
        }

        public static PhieuXuatDTO SelectPhieuXuatById(string MaPhieuXuat)
        {
            return PhieuXuatDAO.SelectPhieuXuatById(MaPhieuXuat);
        }

        public static List<PhieuXuatDTO> SelectPhieuXuatByMaThanhVien(string MaThanhVien)
        {
            return PhieuXuatDAO.SelectPhieuXuatByMaThanhVien(MaThanhVien);
        }

        public static List<PhieuXuatDTO> SelectPhieuXuatByMaNhanVien(string MaNhanVien)
        {
            return PhieuXuatDAO.SelectPhieuXuatByMaNhanVien(MaNhanVien);
        }

        public static bool InsertPhieuXuat(PhieuXuatDTO phieuXuatDTO)
        {
            return PhieuXuatDAO.InsertPhieuXuat(phieuXuatDTO);
        }

        public static bool UpdatePhieuXuatById(PhieuXuatDTO phieuXuatDTO)
        {
            return PhieuXuatDAO.UpdatePhieuXuatById(phieuXuatDTO);
        }

        public static bool DeletePhieuXuatById(string maPhieuXuat)
        {
            return PhieuXuatDAO.DeletePhieuXuatById(maPhieuXuat);
        }
       
    }
}
