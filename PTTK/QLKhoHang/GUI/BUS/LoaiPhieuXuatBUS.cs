using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class LoaiPhieuXuatBUS
    {
        public static string CreateLoaiPhieuXuatId()
        {
            return LoaiPhieuXuatDAO.CreateLoaiPhieuXuatId();
        }
        public static bool InsertLoaiPhieuXuat(LoaiPhieuXuatDTO loaiPhieuXuatDTO)
        {
            return LoaiPhieuXuatDAO.InsertLoaiPhieuXuat(loaiPhieuXuatDTO);
        }

        public static bool UpdateLoaiPhieuXuatById(LoaiPhieuXuatDTO loaiPhieuXuatDTO)
        {
            return LoaiPhieuXuatDAO.UpdateLoaiPhieuXuatById(loaiPhieuXuatDTO);
        }

        public static bool DeleteLoaiPhieuXuatById(string maLoaiPhieuXuat)
        {
            return LoaiPhieuXuatDAO.DeleteLoaiPhieuXuatById(maLoaiPhieuXuat);
        }

        public static List<LoaiPhieuXuatDTO> SelectLoaiPhieuXuatAll()
        {
            return LoaiPhieuXuatDAO.SelectLoaiPhieuXuatAll();
        }

        public static LoaiPhieuXuatDTO SelectLoaiPhieuXuatById(string MaLoaiPhieuXuat)
        {
            return LoaiPhieuXuatDAO.SelectLoaiPhieuXuatById(MaLoaiPhieuXuat);
        }
    }
}
