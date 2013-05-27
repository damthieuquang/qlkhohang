using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAO
{
    public class ThanhVienDAO
    {
        public static List<ThanhVienDTO> SelectThanhVienAll()
        {
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ExecuteReader("usp_SelectThanhVienAll");
            List<ThanhVienDTO> lsttvDTO = new List<ThanhVienDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dtRow in dataTable.Rows)
                {
                    ThanhVienDTO tvDTO = new ThanhVienDTO();
                    tvDTO.MaThanhVien = dtRow["MaThanhVien"].ToString();
                    tvDTO.TenThanhVien = dtRow["TenThanhVien"].ToString();
                    tvDTO.CV = int.Parse(dtRow["CV"].ToString());
                    tvDTO.DiaChi = dtRow["DiaChi"].ToString();
                    tvDTO.TienNo = float.Parse(dtRow["TienNo"].ToString());
                    lsttvDTO.Add(tvDTO);
                }
            }
            else
                lsttvDTO = null;
            return lsttvDTO;
        }

        public static ThanhVienDTO SelectThanhVienById(string MaThanhVien)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaThanhVien",MaThanhVien));
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ExecuteReader("usp_SelectThanhVienById", sqlParams);
            ThanhVienDTO tvDTO = new ThanhVienDTO();
            //List<ThanhVienDTO> lsttvDTO = new List<ThanhVienDTO>();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dtRow = dataTable.Rows[0];
                tvDTO.MaThanhVien = dtRow["MaThanhVien"].ToString();
                tvDTO.TenThanhVien = dtRow["TenThanhVien"].ToString();
                tvDTO.CV = int.Parse(dtRow["CV"].ToString());
                tvDTO.DiaChi = dtRow["DiaChi"].ToString();
                tvDTO.TienNo = float.Parse(dtRow["TienNo"].ToString());
                //lsttvDTO.Add(tvDTO);
            }
            else
                tvDTO = null;
            return tvDTO;
        }

        public static bool InsertThanhVien(ThanhVienDTO tvDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaThanhVien",tvDTO.MaThanhVien));
            sqlParams.Add(new SqlParameter("@TenThanhVien", tvDTO.TenThanhVien));
            sqlParams.Add(new SqlParameter("@CV", tvDTO.CV));
            sqlParams.Add(new SqlParameter("@DiaChi", tvDTO.DiaChi));
            sqlParams.Add(new SqlParameter("@TienNo", tvDTO.TienNo));
            return DataProvider.ExecuteNoneQuery("usp_InsertThanhVien", sqlParams);
        }

        public static bool UpdateThanhVienById(ThanhVienDTO tvDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaThanhVien", tvDTO.MaThanhVien));
            sqlParams.Add(new SqlParameter("@TenThanhVien", tvDTO.TenThanhVien));
            sqlParams.Add(new SqlParameter("@CV", tvDTO.CV));
            sqlParams.Add(new SqlParameter("@DiaChi", tvDTO.DiaChi));
            sqlParams.Add(new SqlParameter("@TienNo", tvDTO.TienNo));
            return DataProvider.ExecuteNoneQuery("usp_UpdateThanhVienById", sqlParams);
        }

        public static bool DeleteThanhVienById(string MaThanhVien)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaThanhVien",MaThanhVien));
            return DataProvider.ExecuteNoneQuery("usp_DeleteThanhVienById", sqlParams);
        }

        public static string CreateThanhVienId()
        {
            return (string)DataProvider.ExecuteScalar("usp_CreateThanhVienId");
        }
    }
}




