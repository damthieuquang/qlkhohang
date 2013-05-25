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

        public static List<PhieuXuatDTO> SelectPhieuXuatById(string MaPhieuXuat)
        {
            return PhieuXuatDAO.SelectPhieuXuatById(MaPhieuXuat);
        }

        public static bool InsertPhieuXuat(PhieuXuatDTO phieuXuatDTO)
        {
            return PhieuXuatDAO.InsertPhieuXuat(phieuXuatDTO);
        }

        public static bool UpdatePhieuXuat(PhieuXuatDTO phieuXuatDTO)
        {
            return PhieuXuatDAO.UpdatePhieuXuat(phieuXuatDTO);
        }

        public static bool DeletePhieuXuat(PhieuXuatDTO phieuXuatDTO)
        {
            return PhieuXuatDAO.DeletePhieuXuat(phieuXuatDTO);
        }
    }
}
