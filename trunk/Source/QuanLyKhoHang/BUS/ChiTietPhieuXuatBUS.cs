using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ChiTietPhieuXuatBUS
    {
        public static bool InsertChiTietPhieuXuat(ChiTietPhieuXuatDTO chiTietPhieuXuatDTO)
        {
            return ChiTietPhieuXuatDAO.InsertChiTietPhieuXuat(chiTietPhieuXuatDTO);
        }

        public static bool UpdateChiTietPhieuXuat(ChiTietPhieuXuatDTO chiTietPhieuXuatDTO)
        {
            return ChiTietPhieuXuatDAO.UpdateChiTietPhieuXuat(chiTietPhieuXuatDTO);
        }

        public static bool DeleteChiTietPhieuXuat(string maChiTietPhieuXuat)
        {
            return ChiTietPhieuXuatDAO.DeleteChiTietPhieuXuat(maChiTietPhieuXuat);
        }

        public static List<ChiTietPhieuXuatDTO> SelectChiTietPhieuXuatAll()
        {
            return ChiTietPhieuXuatDAO.SelectChiTietPhieuXuatAll();
        }

        public static ChiTietPhieuXuatDTO SelectChiTietPhieuXuatById(string MaChiTietPhieuXuat)
        {
            return ChiTietPhieuXuatDAO.SelectChiTietPhieuXuatById(MaChiTietPhieuXuat);
        }
    }

}
