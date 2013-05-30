using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ChiTietDonHangBUS
    {
        public static List<ChiTietDonHangDTO> SelectChiTietDonHangAll()
        {
            return ChiTietDonHangDAO.SelectChiTietDonHangAll();
        }

        public static ChiTietDonHangDTO SelectChiTietDonHangById(string MaChiTietDonHang)
        {
            return ChiTietDonHangDAO.SelectChiTietDonHangById(MaChiTietDonHang);
        }

        public static List<ChiTietDonHangDTO> SelectChiTietDonHangByMaDonHang(string MaDonHang)
        {
            return ChiTietDonHangDAO.SelectChiTietDonHangByMaDonHang(MaDonHang);
        }

        public static bool InsertChiTietDonHang(ChiTietDonHangDTO ctdhDTO)
        {
            return ChiTietDonHangDAO.InsertChiTietDonHang(ctdhDTO);
        }

        public static bool UpdateChiTietDonHangById(ChiTietDonHangDTO ctdhDTO)
        {
            return ChiTietDonHangDAO.UpdateChiTietDonHangById(ctdhDTO);
        }

        public static bool DeleteChiTietDonHangById(string MaChiTietDonHang)
        {
            return ChiTietDonHangDAO.DeleteChiTietDonHangById(MaChiTietDonHang);
        }
    }
}
