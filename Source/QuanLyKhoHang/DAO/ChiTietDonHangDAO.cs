using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ChiTietDonHangDAO
    {
        public static List<ChiTietDonHangDTO> SelectChiTietDonHangAll()
        {
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ExecuteReader("usp_SelectChiTietDonHangAll");
            List<ChiTietDonHangDTO> lstctdhDTO = new List<ChiTietDonHangDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dtRow in dataTable.Rows)
                {
                    ChiTietDonHangDTO ctdhDTO = new ChiTietDonHangDTO();
                    ctdhDTO.MaChiTietDonHang = dtRow["MaChiTietDonHang"].ToString();
                    ctdhDTO.MaDonHang = dtRow["MaDonHang"].ToString();
                    ctdhDTO.MaSanPham = dtRow["MaSanPham"].ToString();
                    ctdhDTO.CV = int.Parse(dtRow["CV"].ToString());
                    ctdhDTO.SoLuong = int.Parse(dtRow["SoLuong"].ToString());
                    ctdhDTO.DonGia = float.Parse(dtRow["DonGia"].ToString());
                    ctdhDTO.ThanhTien = float.Parse(dtRow["ThanhTien"].ToString());
                    lstctdhDTO.Add(ctdhDTO);
                    //select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien
                }
            }
            else
                lstctdhDTO = null;
            return lstctdhDTO;
        }

        public static ChiTietDonHangDTO SelectChiTietDonHangById(string MaChiTietDonHang)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietDonHang",MaChiTietDonHang));
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ExecuteReader("usp_SelectChiTietDonHangById",sqlParams);
            ChiTietDonHangDTO ctdhDTO = new ChiTietDonHangDTO();
            
            if (dataTable.Rows.Count > 0)
            {
                //<ChiTietDonHangDTO> lstctdhDTO = new List<ChiTietDonHangDTO>();

                DataRow dtRow = dataTable.Rows[0];

                ctdhDTO.MaChiTietDonHang = dtRow["MaChiTietDonHang"].ToString();
                ctdhDTO.MaDonHang = dtRow["MaDonHang"].ToString();
                ctdhDTO.MaSanPham = dtRow["MaSanPham"].ToString();
                ctdhDTO.CV = int.Parse(dtRow["CV"].ToString());
                ctdhDTO.SoLuong = int.Parse(dtRow["SoLuong"].ToString());
                ctdhDTO.DonGia = float.Parse(dtRow["DonGia"].ToString());
                ctdhDTO.ThanhTien = float.Parse(dtRow["ThanhTien"].ToString());
                // lstctdhDTO.Add(ctdhDTO);
                //select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien
            }
            else
                ctdhDTO = null;
            return ctdhDTO;
        }

        public static List<ChiTietDonHangDTO> SelectChiTietDonHangByMaDonHang(string MaDonHang)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaDonHang", MaDonHang));
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.ExecuteReader("usp_SelectChiTietDonHangByMaDonHang", sqlParams);
            List<ChiTietDonHangDTO> lstctdhDTO = new List<ChiTietDonHangDTO>();
          
            if (dataTable.Rows.Count > 0)
            {

                //<ChiTietDonHangDTO> lstctdhDTO = new List<ChiTietDonHangDTO>();
                foreach (DataRow dtRow in dataTable.Rows)
                {
                    ChiTietDonHangDTO ctdhDTO = new ChiTietDonHangDTO();

                    ctdhDTO.MaChiTietDonHang = dtRow["MaChiTietDonHang"].ToString();
                    ctdhDTO.MaDonHang = dtRow["MaDonHang"].ToString();
                    ctdhDTO.MaSanPham = dtRow["MaSanPham"].ToString();
                    ctdhDTO.CV = int.Parse(dtRow["CV"].ToString());
                    ctdhDTO.SoLuong = int.Parse(dtRow["SoLuong"].ToString());
                    ctdhDTO.DonGia = float.Parse(dtRow["DonGia"].ToString());
                    ctdhDTO.ThanhTien = float.Parse(dtRow["ThanhTien"].ToString());
                     lstctdhDTO.Add(ctdhDTO);
                    //select ct.MaChiTietDonHang, ct.MaDonHang, ct.MaSanPham, ct.CV, ct.SoLuong, ct.DonGia, ct.ThanhTien
                }
            }
            else
                lstctdhDTO = null;
            return lstctdhDTO;
        }

        public static bool InsertChiTietDonHang(ChiTietDonHangDTO ctdhDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietDonHang",ctdhDTO.MaChiTietDonHang));
            sqlParams.Add(new SqlParameter("@MaDonHang", ctdhDTO.MaDonHang));
            sqlParams.Add(new SqlParameter("@MaSanPham", ctdhDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@CV", ctdhDTO.CV));
            sqlParams.Add(new SqlParameter("@SoLuong", ctdhDTO.SoLuong));
            sqlParams.Add(new SqlParameter("@DonGia", ctdhDTO.DonGia));
            sqlParams.Add(new SqlParameter("@ThanhTien", ctdhDTO.ThanhTien));
            return DataProvider.ExecuteNoneQuery("usp_InsertChiTietDonHang",sqlParams);
        }

        public static bool UpdateChiTietDonHangById(ChiTietDonHangDTO ctdhDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietDonHang", ctdhDTO.MaChiTietDonHang));
            sqlParams.Add(new SqlParameter("@MaDonHang", ctdhDTO.MaDonHang));
            sqlParams.Add(new SqlParameter("@MaSanPham", ctdhDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@CV", ctdhDTO.CV));
            sqlParams.Add(new SqlParameter("@SoLuong", ctdhDTO.SoLuong));
            sqlParams.Add(new SqlParameter("@DonGia", ctdhDTO.DonGia));
            sqlParams.Add(new SqlParameter("@ThanhTien", ctdhDTO.ThanhTien));
            return DataProvider.ExecuteNoneQuery("usp_UpdateChiTietDonHangById",sqlParams);
        }

        public static bool DeleteChiTietDonHangById(string MaChiTietDonHang)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietDonHang", MaChiTietDonHang));
            return DataProvider.ExecuteNoneQuery("usp_InsertChiTietDonHang",sqlParams);
        }
    }
}
