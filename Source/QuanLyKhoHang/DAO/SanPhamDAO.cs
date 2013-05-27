using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class SanPhamDAO
    {
        public static List<SanPhamDTO> SelectSanPhamAll()
        {
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ExecuteReader("usp_SelectSanPhamAll");
            List<SanPhamDTO> lstspDTO = new List<SanPhamDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dtRow in dataTable.Rows)
                {
                    SanPhamDTO spDTO = new SanPhamDTO();
                    spDTO.MaSanPham = dtRow["MaSanPham"].ToString();
                    spDTO.TenSanPham = dtRow["TenSanPham"].ToString();
                    spDTO.CV = int.Parse(dtRow["CV"].ToString());
                    spDTO.DonGia = float.Parse(dtRow["DonGia"].ToString());
                    spDTO.DonGiaTV = float.Parse(dtRow["DonGiaTV"].ToString());
                    spDTO.SoLuongTon = int.Parse(dtRow["SoLuongTon"].ToString());
                    spDTO.MaLoaiSanPham = dtRow["MaLoaiSanPham"].ToString();
                    //select sp.MaSanPham, sp.TenSanPham, sp.CV, sp.DonGia, sp.DonGiaTV, sp.SoLuongTon, sp.MaLoaiSanPham
                    lstspDTO.Add(spDTO);
                }
            }
            else
                lstspDTO = null;
            return lstspDTO;
        }
        public static SanPhamDTO SelectSanPhamById(string MaSanPham)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaSanPham", MaSanPham));
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ExecuteReader("usp_SelectSanPhamById", sqlParams);
            SanPhamDTO spDTO = new SanPhamDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dtRow = dataTable.Rows[0];
                //List<SanPhamDTO> lstspDTO = new List<SanPhamDTO>();

                spDTO.MaSanPham = dtRow["MaSanPham"].ToString();
                spDTO.TenSanPham = dtRow["TenSanPham"].ToString();
                spDTO.CV = int.Parse(dtRow["CV"].ToString());
                spDTO.DonGia = float.Parse(dtRow["DonGia"].ToString());
                spDTO.DonGiaTV = float.Parse(dtRow["DonGiaTV"].ToString());
                spDTO.SoLuongTon = int.Parse(dtRow["SoLuongTon"].ToString());
                spDTO.MaLoaiSanPham = dtRow["MaLoaiSanPham"].ToString();
                //select sp.MaSanPham, sp.TenSanPham, sp.CV, sp.DonGia, sp.DonGiaTV, sp.SoLuongTon, sp.MaLoaiSanPham
                // lstspDTO.Add(spDTO);
            }
            else
                spDTO = null;
            return spDTO;
        }

        public static bool InsertSanPham(SanPhamDTO spDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaSanPham",spDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@TenSanPham", spDTO.TenSanPham));
            sqlParams.Add(new SqlParameter("@CV", spDTO.CV));
            sqlParams.Add(new SqlParameter("@DonGia", spDTO.DonGia));
            sqlParams.Add(new SqlParameter("@DonGiaTV", spDTO.DonGiaTV));
            sqlParams.Add(new SqlParameter("@SoLuongTon", spDTO.SoLuongTon));
            sqlParams.Add(new SqlParameter("@MaLoaiSanPham", spDTO.MaLoaiSanPham));
            return DataProvider.ExecuteNoneQuery("usp_InsertSanPham", sqlParams);
        }

        public static bool UpdateSanPhamById(SanPhamDTO spDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaSanPham", spDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@TenSanPham", spDTO.TenSanPham));
            sqlParams.Add(new SqlParameter("@CV", spDTO.CV));
            sqlParams.Add(new SqlParameter("@DonGia", spDTO.DonGia));
            sqlParams.Add(new SqlParameter("@DonGiaTV", spDTO.DonGiaTV));
            sqlParams.Add(new SqlParameter("@SoLuongTon", spDTO.SoLuongTon));
            sqlParams.Add(new SqlParameter("@MaLoaiSanPham", spDTO.MaLoaiSanPham));
            return DataProvider.ExecuteNoneQuery("usp_UpdateSanPhamById", sqlParams);
        }

        public static bool DeleteSanPhamById(string MaSanPham)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaSanPham", MaSanPham));
            return DataProvider.ExecuteNoneQuery("usp_DeleteSanPhamById", sqlParams);
        }

        public static string CreateSanPhamId()
        {
            return (string)DataProvider.ExecuteScalar("usp_CreateSanPhamId");
        }
    }
}
