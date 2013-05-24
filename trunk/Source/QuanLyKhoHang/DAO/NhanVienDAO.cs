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
        public static bool UpdateNhanVien(NhanVienDTO nhanVienDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaNhanVien", nhanVienDTO.MaNhanVien));
            sqlParams.Add(new SqlParameter("@TenNhanVien", nhanVienDTO.TenNhanVien));
            sqlParams.Add(new SqlParameter("@MatKhau", nhanVienDTO.MatKhau));
            sqlParams.Add(new SqlParameter("@LoaiNhanVien", nhanVienDTO.LoaiNhanVien));
            return DataProvider.ExecuteNoneQuery("usp_UpdateNhanVienById", sqlParams);
        }
        public static bool DeleteNhanVien(string maNhanVien)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaNhanVien", maNhanVien));
            return DataProvider.ExecuteNoneQuery("usp_DeleteNhanVienById", sqlParams);
        }
        public List<NhanVienDTO> SelectNhanVienAll()
        {
            SqlDataReader reader = DataProvider.ExecuteReader("usp_SelectNhanVienAll");
            List<NhanVienDTO> nhanVienDTO = new List<NhanVienDTO>();

            while (reader.Read())
            {
                NhanVienDTO row = new NhanVienDTO();
                row.MaNhanVien = reader.GetString(0);
                row.TenNhanVien = reader.GetString(1);
                row.MatKhau = reader.GetString(2);
                row.LoaiNhanVien = reader.GetInt32(3);
                nhanVienDTO.Add(row);
            }

            return nhanVienDTO;
        }
        public List<NhanVienDTO> SelectNhanVienById(string maNhanVien)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaNhanVien", maNhanVien));

            SqlDataReader reader = DataProvider.ExecuteReader("usp_SelectNhanVienById", sqlParams);
            List<NhanVienDTO> nhanVienDTO = new List<NhanVienDTO>();

            while (reader.Read())
            {
                NhanVienDTO row = new NhanVienDTO();
                row.MaNhanVien = reader.GetString(0);
                row.TenNhanVien = reader.GetString(1);
                row.MatKhau = reader.GetString(2);
                row.LoaiNhanVien = reader.GetInt32(3);
                nhanVienDTO.Add(row);
            }

            return nhanVienDTO;

        }
    }
}
