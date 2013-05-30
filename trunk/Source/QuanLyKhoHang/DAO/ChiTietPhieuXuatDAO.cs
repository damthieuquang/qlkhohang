using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ChiTietPhieuXuatDAO
    {
        public static bool InsertChiTietPhieuXuat(ChiTietPhieuXuatDTO chiTietPhieuXuatDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuXuat", chiTietPhieuXuatDTO.MaChiTietPhieuXuat));
            sqlParams.Add(new SqlParameter("@MaPhieuXuat", chiTietPhieuXuatDTO.MaPhieuXuat));
            sqlParams.Add(new SqlParameter("@MaSanPham", chiTietPhieuXuatDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@CV", chiTietPhieuXuatDTO.CV));
            sqlParams.Add(new SqlParameter("@DonGia", chiTietPhieuXuatDTO.DonGia));
            sqlParams.Add(new SqlParameter("@SoLuong", chiTietPhieuXuatDTO.SoLuong));
            sqlParams.Add(new SqlParameter("@ThanhTien", chiTietPhieuXuatDTO.ThanhTien));
            return DataProvider.ExecuteNoneQuery("usp_InsertChiTietPhieuXuat", sqlParams);
        }

        public static bool UpdateChiTietPhieuXuatById(ChiTietPhieuXuatDTO chiTietPhieuXuatDTO)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("@MaChiTietPhieuXuat", chiTietPhieuXuatDTO.MaChiTietPhieuXuat));
            sqlParams.Add(new SqlParameter("@MaPhieuXuat", chiTietPhieuXuatDTO.MaPhieuXuat));
            sqlParams.Add(new SqlParameter("@MaSanPham", chiTietPhieuXuatDTO.MaSanPham));
            sqlParams.Add(new SqlParameter("@CV", chiTietPhieuXuatDTO.CV));
            sqlParams.Add(new SqlParameter("@DonGia", chiTietPhieuXuatDTO.DonGia));
            sqlParams.Add(new SqlParameter("@SoLuong", chiTietPhieuXuatDTO.SoLuong));
            sqlParams.Add(new SqlParameter("@ThanhTien", chiTietPhieuXuatDTO.ThanhTien));
            return DataProvider.ExecuteNoneQuery("usp_UpdateChiTietPhieuXuatById", sqlParams);
        }

        public static bool DeleteChiTietPhieuXuatById(string maChiTietPhieuXuat)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaChiTietPhieuXuat", maChiTietPhieuXuat));
            return DataProvider.ExecuteNoneQuery("usp_DeleteChiTietPhieuXuatById", sqlParamas);
        }

        public static List<ChiTietPhieuXuatDTO> SelectChiTietPhieuXuatAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectChiTietPhieuXuatAll");
            List<ChiTietPhieuXuatDTO> listChiTietPhieuXuatDTO = new List<ChiTietPhieuXuatDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ChiTietPhieuXuatDTO chiTietPhieuXuatDTO = new ChiTietPhieuXuatDTO();
                    chiTietPhieuXuatDTO.MaChiTietPhieuXuat = dataRow["MaChiTietPhieuXuat"].ToString();
                    chiTietPhieuXuatDTO.MaPhieuXuat = dataRow["MaPhieuXuat"].ToString();
                    chiTietPhieuXuatDTO.MaSanPham = dataRow["MaSanPham"].ToString();
                    chiTietPhieuXuatDTO.CV = Int32.Parse(dataRow["CV"].ToString());
                    chiTietPhieuXuatDTO.DonGia = Int32.Parse(dataRow["DonGia"].ToString());
                    chiTietPhieuXuatDTO.SoLuong = Int32.Parse(dataRow["SoLuong"].ToString());
                    chiTietPhieuXuatDTO.ThanhTien = Int32.Parse(dataRow["ThanhTien"].ToString());
                    listChiTietPhieuXuatDTO.Add(chiTietPhieuXuatDTO);
                }
            }
            else
            {
                listChiTietPhieuXuatDTO = null;
            }
            return listChiTietPhieuXuatDTO;
        }

        public static ChiTietPhieuXuatDTO SelectChiTietPhieuXuatById(string MaChiTietPhieuXuat)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaChiTietPhieuXuat", MaChiTietPhieuXuat));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectChiTietPhieuXuatById", sqlParamas);
            ChiTietPhieuXuatDTO chiTietPhieuXuatDTO = new ChiTietPhieuXuatDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                chiTietPhieuXuatDTO.MaChiTietPhieuXuat = dataRow["MaChiTietPhieuXuat"].ToString();
                chiTietPhieuXuatDTO.MaPhieuXuat = dataRow["MaPhieuXuat"].ToString();
                chiTietPhieuXuatDTO.MaSanPham = dataRow["MaSanPham"].ToString();
                chiTietPhieuXuatDTO.CV = Int32.Parse(dataRow["CV"].ToString());
                chiTietPhieuXuatDTO.DonGia = Int32.Parse(dataRow["DonGia"].ToString());
                chiTietPhieuXuatDTO.SoLuong = Int32.Parse(dataRow["SoLuong"].ToString());

            }
            else
            {
                chiTietPhieuXuatDTO = null;
            }

            return chiTietPhieuXuatDTO;
        }

        public static object maChiTietPhieuXuat { get; set; }
    }
}
