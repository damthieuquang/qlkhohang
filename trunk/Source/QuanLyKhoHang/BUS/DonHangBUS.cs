using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class DonHangBUS
    {
        public static List<DonHangDTO> SelectDonHangAll()
        {
            return DonHangDAO.SelectDonHangAll();
        }
        public static bool InsertDonHang(DonHangDTO donHangDTO)
        {
            return DonHangDAO.InsertDonHang(donHangDTO);
        }
        public static bool UpdateDonHangById(DonHangDTO donHangDTO)
        {
            return DonHangDAO.UpdateDonHangById(donHangDTO);
        }
        public static bool DeleteDonHangById(string maDonHang)
        {
            return DonHangDAO.DeleteDonHangById(maDonHang);
        }
        public static DonHangDTO SelectDonHangById(string maDonHang)
        {
            return DonHangDAO.SelectDonHangById(maDonHang);
        }
    }
}
