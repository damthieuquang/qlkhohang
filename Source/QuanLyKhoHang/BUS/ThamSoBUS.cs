using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class ThamSoBUS
    {
        public static List<ThamSoDTO> SelectThamSoAll()
        {
            return ThamSoDAO.SelectThamSoAll();
        }

        public static ThamSoDTO SelectThamSoById(string MaThamSo)
        {
            return ThamSoDAO.SelectThamSoById(MaThamSo);
        }

        public static bool InsertThamSo(ThamSoDTO thamSoDTO)
        {
            return ThamSoDAO.InsertThamSo(thamSoDTO);
        }

        public static bool UpdateThamSo(ThamSoDTO thamSoDTO)
        {
            return ThamSoDAO.UpdateThamSo(thamSoDTO);
        }

        public static bool DeletePhieuNhap(ThamSoDTO thamSoDTO)
        {
            return ThamSoDAO.DeleteThamSo(thamSoDTO);
        }
    }
}
