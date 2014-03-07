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

        public static bool UpdateChiTietPhieuXuatById(ChiTietPhieuXuatDTO chiTietPhieuXuatDTO)
        {
            return ChiTietPhieuXuatDAO.UpdateChiTietPhieuXuatById(chiTietPhieuXuatDTO);
        }

        public static bool DeleteChiTietPhieuXuatById(string maChiTietPhieuXuat)
        {
            return ChiTietPhieuXuatDAO.DeleteChiTietPhieuXuatById(maChiTietPhieuXuat);
        }

        public static List<ChiTietPhieuXuatDTO> SelectChiTietPhieuXuatAll()
        {
            return ChiTietPhieuXuatDAO.SelectChiTietPhieuXuatAll();
        }

        public static ChiTietPhieuXuatDTO SelectChiTietPhieuXuatById(string MaChiTietPhieuXuat)
        {
            return ChiTietPhieuXuatDAO.SelectChiTietPhieuXuatById(MaChiTietPhieuXuat);
        }

        public static List<ChiTietPhieuXuatDTO> SelectChiTietPhieuXuatByMaPhieuXuat(string MaPhieuXuat)
        {
            return ChiTietPhieuXuatDAO.SelectChiTietPhieuXuatByMaPhieuXuat(MaPhieuXuat);
        }

    }

}
