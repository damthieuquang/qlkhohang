﻿using System;
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

        public static string CreateNhanVientId()
        {
            return (string)DataProvider.ExecuteScalar("usp_CreateNhanVienId");
        }
      
    }
}