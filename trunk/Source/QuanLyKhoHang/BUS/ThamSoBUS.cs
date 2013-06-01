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

        public static bool UpdateThamSoById(ThamSoDTO thamSoDTO)
        {
            return ThamSoDAO.UpdateThamSoById(thamSoDTO);
        }

        public static bool DeleteThamSoById(string maThamSo)
        {
            return ThamSoDAO.DeleteThamSoById(maThamSo);
        }

        public static string CreateThamSoId()
        {
            return ThamSoDAO.CreateThamSoId();
        }
    }
}
