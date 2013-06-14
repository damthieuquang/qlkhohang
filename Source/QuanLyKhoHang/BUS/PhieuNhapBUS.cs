using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class PhieuNhapBUS
    {
        public static List<PhieuNhapDTO> SelectPhieuNhapAll()
        {
            return PhieuNhapDAO.SelectPhieuNhapAll();
        }

        public static PhieuNhapDTO SelectPhieuNhapById(string MaPhieuNhap)
        {
            return PhieuNhapDAO.SelectPhieuNhapById(MaPhieuNhap);
        }
        public static List<PhieuNhapDTO> SelectPhieuNhapByMaNhanVien(string MaNhanVien)
        {
            return PhieuNhapDAO.SelectPhieuNhapByMaNhanVien(MaNhanVien);
        }
        public static List<PhieuNhapDTO> SelectPhieuNhapByMaDonHang(string MaDonHang)
        {
            return PhieuNhapDAO.SelectPhieuNhapByMaDonHang(MaDonHang);
        }
        public static bool InsertPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            return PhieuNhapDAO.InsertPhieuNhap(phieuNhapDTO);
        }

        public static bool UpdatePhieuNhapById(PhieuNhapDTO phieuNhapDTO)
        {
            return PhieuNhapDAO.UpdatePhieuNhapById(phieuNhapDTO);
        }

        public static bool DeletePhieuNhapByID(string phieuNhapDTO)
        {
            return PhieuNhapDAO.DeletePhieuNhapById(phieuNhapDTO);
        }
    }
}
