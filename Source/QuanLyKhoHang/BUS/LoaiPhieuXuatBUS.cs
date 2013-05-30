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
        public static bool InsertLoaiPhieuXuat(LoaiPhieuXuatDTO loaiPhieuXuatDTO)
        {
            return LoaiPhieuXuatDAO.InsertLoaiPhieuXuat(loaiPhieuXuatDTO);
        }

        public static bool UpdateLoaiPhieuXuat(LoaiPhieuXuatDTO loaiPhieuXuatDTO)
        {
            return LoaiPhieuXuatDAO.UpdateLoaiPhieuXuat(loaiPhieuXuatDTO);
        }

        public static bool DeleteLoaiPhieuXuat(string maLoaiPhieuXuat)
        {
            return LoaiPhieuXuatDAO.DeleteLoaiPhieuXuat(maLoaiPhieuXuat);
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
