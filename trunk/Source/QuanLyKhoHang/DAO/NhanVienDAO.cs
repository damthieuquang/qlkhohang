using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public static bool InsertNhanVien(NhanVienDTO nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaNhanVien", nhanVienDTO.MaNhanVien));
            sqlParams.Add(new SqlParameter("@TenNhanVien", nhanVienDTO.TenNhanVien));
            sqlParams.Add(new SqlParameter("@MatKhau", nhanVienDTO.MatKhau));
            sqlParams.Add(new SqlParameter("@LoaiNhanVien", nhanVienDTO.LoaiNhanVien));
            return DataProvider.ExecuteNoneQuery("usp_InsertNhanVien", sqlParams);
        }
        public static bool UpdateNhanVienById(NhanVienDTO nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaNhanVien", nhanVienDTO.MaNhanVien));
            sqlParams.Add(new SqlParameter("@TenNhanVien", nhanVienDTO.TenNhanVien));
            sqlParams.Add(new SqlParameter("@MatKhau", nhanVienDTO.MatKhau));
            sqlParams.Add(new SqlParameter("@LoaiNhanVien", nhanVienDTO.LoaiNhanVien));
            return DataProvider.ExecuteNoneQuery("usp_UpdateNhanVienById", sqlParams);
        }
        public static bool DeleteNhanVienById(string maNhanVien)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaNhanVien", maNhanVien));
            return DataProvider.ExecuteNoneQuery("usp_DeleteNhanVienById", sqlParams);
        }
        public static List<NhanVienDTO> SelectNhanVienAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectNhanVienAll");
            List<NhanVienDTO> listNhanVienDTO = new List<NhanVienDTO>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                NhanVienDTO nhanVienDTO = new NhanVienDTO();
                nhanVienDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                nhanVienDTO.TenNhanVien = dataRow["TenNhanVien"].ToString();
                nhanVienDTO.MatKhau = dataRow["MatKhau"].ToString();
                nhanVienDTO.LoaiNhanVien = Int32.Parse(dataRow["LoaiNhanVien"].ToString());

                listNhanVienDTO.Add(nhanVienDTO);
            }
            return listNhanVienDTO;
        }
        public static NhanVienDTO SelectNhanVienById(string maNhanVien)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaNhanVien", maNhanVien));

            DataTable dataTable  = DataProvider.ExecuteReader("usp_SelectNhanVienById", sqlParams);
            NhanVienDTO nhanVienDTO = new NhanVienDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                nhanVienDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                nhanVienDTO.TenNhanVien = dataRow["TenNhanVien"].ToString();
                nhanVienDTO.MatKhau = dataRow["MatKhau"].ToString();
                nhanVienDTO.LoaiNhanVien = int.Parse(dataRow["LoaiNhanVien"].ToString());
            }
            else
            {
                nhanVienDTO = null;
            }

            return nhanVienDTO;

        }

        public static string CreateNhanVientId()
        {
            return (string)DataProvider.ExecuteScalar("usp_CreateNhanVienId");
        }

    }
}
