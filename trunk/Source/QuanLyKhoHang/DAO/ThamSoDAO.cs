using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ThamSoDAO
    {

        public static bool InsertThamSo(ThamSoDTO thamSoDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaThamSo", thamSoDTO.MaThamSo));
            sqlParamas.Add(new SqlParameter("@TenThamSo", thamSoDTO.TenThamSo));
            sqlParamas.Add(new SqlParameter("@GiaTri", thamSoDTO.GiaTri));      
            return DataProvider.ExecuteNoneQuery("usp_InsertThamSo", sqlParamas);
        }

        public static bool UpdateThamSo(ThamSoDTO thamSoDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaThamSo", thamSoDTO.MaThamSo));
            sqlParamas.Add(new SqlParameter("@TenThamSo", thamSoDTO.TenThamSo));
            sqlParamas.Add(new SqlParameter("@GiaTri", thamSoDTO.GiaTri)); 
            return DataProvider.ExecuteNoneQuery("usp_UpdateThamSoById", sqlParamas);
        }

        public static bool DeleteThamSo(string maThamSo)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaThamSo", maThamSo));
            //SqlParameter para = new SqlParameter("@MaPhieuNhap",phieuNhapDTO.MaPhieuNhap); mot cach viet khac
            return DataProvider.ExecuteNoneQuery("usp_DeleteThamSoById", sqlParamas);
        }

        public static List<ThamSoDTO> SelectThamSoAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectThamSoAll");
            List<ThamSoDTO> listThamSoDTO = new List<ThamSoDTO>();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ThamSoDTO thamSoDTO = new ThamSoDTO();
                    thamSoDTO.MaThamSo = dataRow["MaThamSo"].ToString();
                    thamSoDTO.TenThamSo = dataRow["TenThamSo"].ToString();
                    thamSoDTO.GiaTri = dataRow["GiaTri"].ToString();
                    listThamSoDTO.Add(thamSoDTO);
                }
            }
            else
            {
                listThamSoDTO = null;
            }
            
            return listThamSoDTO;
        }

        public static ThamSoDTO SelectThamSoById(string MaThamSo)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaThamSo", MaThamSo));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectThamSoById", sqlParamas);

            ThamSoDTO thamSoDTO = new ThamSoDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                thamSoDTO.MaThamSo = dataRow["MaThamSo"].ToString();
                thamSoDTO.TenThamSo = dataRow["TenThamSo"].ToString();
                thamSoDTO.GiaTri = dataRow["GiaTri"].ToString();
            }
            else
            {
                thamSoDTO = null;
            }
            return thamSoDTO;
        }

        public static string CreateThamSoId()
        {
            return (string)DataProvider.ExecuteScalar("usp_CreateThamSoId");
        }

    }
}
