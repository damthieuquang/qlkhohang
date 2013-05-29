using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        public static bool InsertChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuNhap", chiTietPhieuNhapDTO.MaChiTietPhieuNhap));
            sqlParams.Add(new SqlParameter("@MaPhieuNhap", chiTietPhieuNhapDTO.MaPhieuNhap));
            sqlParams.Add(new SqlParameter("@MaSanPham", chiTietPhieuNhapDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@SLNhan", chiTietPhieuNhapDTO.SLNhan));
            sqlParams.Add(new SqlParameter("@GhiChu", chiTietPhieuNhapDTO.GhiChu));
            return DataProvider.ExecuteNoneQuery("usp_InsertChiTietPhieuNhap", sqlParams);
        }
        public static bool UpdateChiTietPhieuNhapById(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuNhap", chiTietPhieuNhapDTO.MaChiTietPhieuNhap));
            sqlParams.Add(new SqlParameter("@MaPhieuNhap", chiTietPhieuNhapDTO.MaPhieuNhap));
            sqlParams.Add(new SqlParameter("@MaSanPham", chiTietPhieuNhapDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@SLNhan", chiTietPhieuNhapDTO.SLNhan));
            sqlParams.Add(new SqlParameter("@GhiChu", chiTietPhieuNhapDTO.GhiChu));
            return DataProvider.ExecuteNoneQuery("usp_UpdateChiTietPhieuNhapById", sqlParams);
        }
        public static bool DeleteChiTietPhieuNhapById(string maChiTietPhieuNhap)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuNhap", maChiTietPhieuNhap));
            return DataProvider.ExecuteNoneQuery("usp_DeleteChiTietPhieuNhapById", sqlParams);
        }
        public static List<ChiTietPhieuNhapDTO> SelectChiTietPhieuNhapAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectChiTietPhieuNhapAll");
            List<ChiTietPhieuNhapDTO> listChiTietPhieuNhapDTO = new List<ChiTietPhieuNhapDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                    chiTietPhieuNhapDTO.MaChiTietPhieuNhap = dataRow["MaChiTietPhieuNhap"].ToString();
                    chiTietPhieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                    chiTietPhieuNhapDTO.MaSanPham = dataRow["MaPhieuNhap"].ToString();
                    chiTietPhieuNhapDTO.SLNhan = Int32.Parse(dataRow["SLNhan"].ToString());
                    chiTietPhieuNhapDTO.GhiChu = dataRow["GhiChu"].ToString();
                    listChiTietPhieuNhapDTO.Add(chiTietPhieuNhapDTO);
                }
            }
            else
            {
                listChiTietPhieuNhapDTO = null;
            }
            return listChiTietPhieuNhapDTO;
        }
        public static ChiTietPhieuNhapDTO SelectChiTietPhieuNhapById(string maChiTietPhieuNhap)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuNhap", maChiTietPhieuNhap));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectChiTietPhieuNhapById", sqlParams);
            ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];

                chiTietPhieuNhapDTO.MaChiTietPhieuNhap = dataRow["MaChiTietPhieuNhap"].ToString();
                chiTietPhieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                chiTietPhieuNhapDTO.MaSanPham = dataRow["MaSanPham"].ToString();
                chiTietPhieuNhapDTO.SLNhan = Int32.Parse(dataRow["SLNhan"].ToString());
                chiTietPhieuNhapDTO.GhiChu = dataRow["GhiChu"].ToString();
            }
            else
            {
                chiTietPhieuNhapDTO = null;
            }

            return chiTietPhieuNhapDTO;
        }
    }
}
