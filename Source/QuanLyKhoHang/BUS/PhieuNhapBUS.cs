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

        public static List<PhieuNhapDTO> SelectPhieuNhapById(string MaPhieuNhap)
        {
            return PhieuNhapDAO.SelectPhieuNhapById(MaPhieuNhap);
        }

        public static bool InsertPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            return PhieuNhapDAO.InsertPhieuNhap(phieuNhapDTO);
        }

        public static bool UpdatePhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            return PhieuNhapDAO.UpdatePhieuNhap(phieuNhapDTO);
        }

        public static bool DeletePhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            return PhieuNhapDAO.DeletePhieuNhap(phieuNhapDTO);
        }
    }
}
