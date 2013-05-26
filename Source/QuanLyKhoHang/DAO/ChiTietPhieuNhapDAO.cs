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
            sqlParams.Add(new SqlParameter("@SoLuong", chiTietPhieuNhapDTO.SoLuong));
            sqlParams.Add(new SqlParameter("@SLDaNhan", chiTietPhieuNhapDTO.SLDaNhan));
            sqlParams.Add(new SqlParameter("@SLConLai", chiTietPhieuNhapDTO.SLConLai));
            sqlParams.Add(new SqlParameter("@GhiChu", chiTietPhieuNhapDTO.GhiChu));
            return DataProvider.ExecuteNoneQuery("usp_InsertChiTietPhieuNhap", sqlParams);
        }
        public static bool UpdateChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuNhap", chiTietPhieuNhapDTO.MaChiTietPhieuNhap));
            sqlParams.Add(new SqlParameter("@MaPhieuNhap", chiTietPhieuNhapDTO.MaPhieuNhap));
            sqlParams.Add(new SqlParameter("@MaSanPham", chiTietPhieuNhapDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@SoLuong", chiTietPhieuNhapDTO.SoLuong));
            sqlParams.Add(new SqlParameter("@SLDaNhan", chiTietPhieuNhapDTO.SLDaNhan));
            sqlParams.Add(new SqlParameter("@SLConLai", chiTietPhieuNhapDTO.SLConLai));
            sqlParams.Add(new SqlParameter("@GhiChu", chiTietPhieuNhapDTO.GhiChu));
            return DataProvider.ExecuteNoneQuery("usp_UpdateChiTietPhieuNhapById", sqlParams);
        }
        public static bool DeleteChiTietPhieuNhap(string maChiTietPhieuNhap)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuNhap", maChiTietPhieuNhap));
            return DataProvider.ExecuteNoneQuery("usp_DeleteChiTietPhieuNhapById", sqlParams);
        }
        public static List<ChiTietPhieuNhapDTO> SelectChiTietPhieuNhapAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectChiTietPhieuNhapAll");
            List<ChiTietPhieuNhapDTO> listChiTietPhieuNhapDTO = new List<ChiTietPhieuNhapDTO>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                chiTietPhieuNhapDTO.MaChiTietPhieuNhap = dataRow["MaChiTietPhieuNhap"].ToString();
                chiTietPhieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                chiTietPhieuNhapDTO.MaSanPham = dataRow["MaPhieuNhap"].ToString();
                chiTietPhieuNhapDTO.SoLuong = Int32.Parse(dataRow["SoLuong"].ToString());
                chiTietPhieuNhapDTO.SLDaNhan = Int32.Parse(dataRow["SLDaNhan"].ToString());
                chiTietPhieuNhapDTO.SLConLai = Int32.Parse(dataRow["SLConLai"].ToString());
                chiTietPhieuNhapDTO.GhiChu = dataRow["GhiChu"].ToString();
                listChiTietPhieuNhapDTO.Add(chiTietPhieuNhapDTO);
            }
            return listChiTietPhieuNhapDTO;
        }
        public static List<ChiTietPhieuNhapDTO> SelectChiTietPhieuNhapById(string maChiTietPhieuNhap)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuNhap", maChiTietPhieuNhap));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectChiTietPhieuNhapById", sqlParams);
            List<ChiTietPhieuNhapDTO> listChiTietPhieuNhapDTO = new List<ChiTietPhieuNhapDTO>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                chiTietPhieuNhapDTO.MaChiTietPhieuNhap = dataRow["MaChiTietPhieuNhap"].ToString();
                chiTietPhieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                chiTietPhieuNhapDTO.MaSanPham = dataRow["MaSanPham"].ToString();
                chiTietPhieuNhapDTO.SoLuong = Int32.Parse(dataRow["SoLuong"].ToString());
                chiTietPhieuNhapDTO.SLDaNhan = Int32.Parse(dataRow["SLDaNhan"].ToString());
                chiTietPhieuNhapDTO.SLConLai = Int32.Parse(dataRow["SLConLai"].ToString());
                chiTietPhieuNhapDTO.GhiChu = dataRow["GhiChu"].ToString();
                listChiTietPhieuNhapDTO.Add(chiTietPhieuNhapDTO);
            }
            return listChiTietPhieuNhapDTO;
        }
    }
}
