using System;
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
        public static bool UpdateDonHang(DonHangDTO donHangDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", donHangDTO.MaDonHang));
            sqlParams.Add(new SqlParameter("@NgayLap", donHangDTO.NgayLap));
            sqlParams.Add(new SqlParameter("@MaNhanVien", donHangDTO.MaNhanVien));
            sqlParams.Add(new SqlParameter("@ThanhTien", donHangDTO.ThanhTien));
            sqlParams.Add(new SqlParameter("@TrangThai", donHangDTO.TrangThai));
            return DataProvider.ExecuteNoneQuery("usp_UpdateDonHangById ", sqlParams);
        }
        public static bool DeleteDonHang(string maDonHang)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", maDonHang));
            return DataProvider.ExecuteNoneQuery("usp_DeleteDonHangById", sqlParams);
        }
        public List<DonHangDTO> SelectDonHangAll()
        {
            SqlDataReader reader = DataProvider.ExecuteReader("usp_SelectDonHangAll");
            List<DonHangDTO> donHangDTO = new List<DonHangDTO>();

            while (reader.Read())
            {
                DonHangDTO row = new DonHangDTO();
                row.MaDonHang = reader.GetString(0);
                row.NgayLap = reader.GetDateTime(1);
                row.MaNhanVien = reader.GetString(2);
                row.ThanhTien = reader.GetFloat(3);
                row.TrangThai = reader.GetString(4);
                donHangDTO.Add(row);
            }

            return donHangDTO;
        }
        public List<DonHangDTO> SelectDonHangById(string maDonHang)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", maDonHang));

            SqlDataReader reader = DataProvider.ExecuteReader("usp_SelectDonHangById", sqlParams);
            List<DonHangDTO> donHangDTO = new List<DonHangDTO>();

            while (reader.Read())
            {
                DonHangDTO row = new DonHangDTO();
                row.MaDonHang = reader.GetString(0);
                row.NgayLap = reader.GetDateTime(1);
                row.MaNhanVien = reader.GetString(2);
                row.ThanhTien = reader.GetFloat(3);
                row.TrangThai = reader.GetString(4);
                donHangDTO.Add(row);
            }

            return donHangDTO;

        }
    }

}
