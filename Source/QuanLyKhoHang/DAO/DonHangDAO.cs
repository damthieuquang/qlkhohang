﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DonHangDAO
    {
        public static bool InsertDonHang(DonHangDTO donHangDTO)
        {


            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", donHangDTO.MaDonHang));
            sqlParams.Add(new SqlParameter("@NgayLap", donHangDTO.NgayLap));
            sqlParams.Add(new SqlParameter("@MaNhanVien", donHangDTO.MaNhanVien));
            sqlParams.Add(new SqlParameter("@ThanhTien", donHangDTO.ThanhTien));
            sqlParams.Add(new SqlParameter("@TrangThai", donHangDTO.TrangThai));

            return DataProvider.ExecuteNoneQuery("usp_InsertDonHang ", sqlParams);

        }
        public static bool UpdateDonHangById(DonHangDTO donHangDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", donHangDTO.MaDonHang));
            sqlParams.Add(new SqlParameter("@NgayLap", donHangDTO.NgayLap));
            sqlParams.Add(new SqlParameter("@MaNhanVien", donHangDTO.MaNhanVien));
            sqlParams.Add(new SqlParameter("@ThanhTien", donHangDTO.ThanhTien));
            sqlParams.Add(new SqlParameter("@TrangThai", donHangDTO.TrangThai));
            return DataProvider.ExecuteNoneQuery("usp_UpdateDonHangById ", sqlParams);
        }
        public static bool DeleteDonHangById(string maDonHang)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", maDonHang));
            return DataProvider.ExecuteNoneQuery("usp_DeleteDonHangById", sqlParams);
        }

        public static List<DonHangDTO> SelectDonHangAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectDonHangAll");
            List<DonHangDTO> listDonHangDTO = new List<DonHangDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    DonHangDTO donHangDTO = new DonHangDTO();
                    donHangDTO.MaDonHang = dataRow["MaDonHang"].ToString();
                    donHangDTO.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                    donHangDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                    donHangDTO.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                    donHangDTO.TrangThai = dataRow["TrangThai"].ToString();
                    listDonHangDTO.Add(donHangDTO);
                }
            }
            else
            {
                listDonHangDTO = null;
            }
            return listDonHangDTO;
        }

        public static DonHangDTO SelectDonHangById(string maDonHang)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", maDonHang));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectDonHangById", sqlParams);
            
            DonHangDTO donHangDTO = new DonHangDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                donHangDTO.MaDonHang = dataRow["MaDonHang"].ToString();
                donHangDTO.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                donHangDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                donHangDTO.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                donHangDTO.TrangThai = dataRow["TrangThai"].ToString();
            }
            else
            {
                donHangDTO = null;
            }

            return donHangDTO;
        }
        public static DonHangDTO SearchDonHangById(string maDonHang)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", maDonHang));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SearchDonHangById", sqlParams);

            DonHangDTO donHangDTO = new DonHangDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                donHangDTO.MaDonHang = dataRow["MaDonHang"].ToString();
                donHangDTO.NgayLap = DateTime.Parse(dataRow["NgayLap"].ToString());
                donHangDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                donHangDTO.ThanhTien = float.Parse(dataRow["ThanhTien"].ToString());
                donHangDTO.TrangThai = dataRow["TrangThai"].ToString();
            }
            else
            {
                donHangDTO = null;
            }

            return donHangDTO;
        }
    }

}
