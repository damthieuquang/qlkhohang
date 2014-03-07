using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        public static ChiTietPhieuNhapDTO SelectChiTietPhieuNhapById(string maChiTietPhieuNhap)
        {
            return ChiTietPhieuNhapDAO.SelectChiTietPhieuNhapById(maChiTietPhieuNhap);
        }
        public static List<ChiTietPhieuNhapDTO> SelectChiTietPhieuNhapByMaPhieuNhap(string maPhieuNhap)
        {
            return ChiTietPhieuNhapDAO.SelectChiTietPhieuNhapByMaPhieuNhap(maPhieuNhap);
        }
        public static List<ChiTietPhieuNhapDTO> SelectChiTietPhieuNhapAll()
        {
            return ChiTietPhieuNhapDAO.SelectChiTietPhieuNhapAll();
        }
        public static bool InsertChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            return ChiTietPhieuNhapDAO.InsertChiTietPhieuNhap(chiTietPhieuNhapDTO);
        }
        public static bool UpdateChiTietPhieuNhapById(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            return ChiTietPhieuNhapDAO.UpdateChiTietPhieuNhapById(chiTietPhieuNhapDTO);
        }

        public static bool DeleteChiTietPhieuNhapById(string maChiTietPhieuNhap)
        {
            return ChiTietPhieuNhapDAO.DeleteChiTietPhieuNhapById(maChiTietPhieuNhap);
        }
    }
}
