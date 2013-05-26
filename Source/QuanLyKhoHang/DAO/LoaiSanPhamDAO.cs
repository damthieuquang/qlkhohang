using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class LoaiSanPhamDAO
    {
        public static string CreateLoaiSanPhamId()
        {
            return (string)DataProvider.ExecuteScalar("usp_CreateLoaiSanPhamId");
        }

        public static bool InsertLoaiSanPham(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaLoaiSanPham", loaiSanPhamDTO.MaLoaiSanPham));
            sqlParamas.Add(new SqlParameter("@TenLoaiSanPham", loaiSanPhamDTO.TenLoaiSanPham));
            return DataProvider.ExecuteNoneQuery("usp_InsertLoaiSanPham", sqlParamas);
        }

        public static bool UpdateLoaiSanPham(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaLoaiSanPham", loaiSanPhamDTO.MaLoaiSanPham));
            sqlParamas.Add(new SqlParameter("@TenLoaiSanPham", loaiSanPhamDTO.TenLoaiSanPham));
            return DataProvider.ExecuteNoneQuery("usp_UpdateLoaiSanPhamById ", sqlParamas);
        }

        public static bool DeleteLoaiSanPham(LoaiSanPhamDTO loaiSanPhamDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaLoaiSanPham", loaiSanPhamDTO.MaLoaiSanPham));
            return DataProvider.ExecuteNoneQuery("usp_DeleteLoaiSanPhamById", sqlParamas);
        }

        public static List<LoaiSanPhamDTO> SelectLoaiSanPhamAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectLoaiSanPhamAll");
            List<LoaiSanPhamDTO> listLoaiSanPhamDTO = new List<LoaiSanPhamDTO>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                LoaiSanPhamDTO loaiSanPhamDTO = new LoaiSanPhamDTO();
                loaiSanPhamDTO.MaLoaiSanPham = dataRow["MaLoaiSanPham"].ToString();
                loaiSanPhamDTO.TenLoaiSanPham = dataRow["TenLoaiSanPham"].ToString();
                listLoaiSanPhamDTO.Add(loaiSanPhamDTO);
            }
            return listLoaiSanPhamDTO;
        }

        public static List<LoaiSanPhamDTO> SelectLoaiSanPhamById(string MaLoaiSanPham)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaLoaiSanPham", MaLoaiSanPham));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectLoaiSanPhamById", sqlParamas);
            List<LoaiSanPhamDTO> listLoaiSanPhamDTO = new List<LoaiSanPhamDTO>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                LoaiSanPhamDTO loaiSanPhamDTO = new LoaiSanPhamDTO();
                loaiSanPhamDTO.MaLoaiSanPham = dataRow["MaLoaiSanPham"].ToString();
                loaiSanPhamDTO.TenLoaiSanPham = dataRow["TenLoaiSanPham"].ToString();
                listLoaiSanPhamDTO.Add(loaiSanPhamDTO);
            }
            return listLoaiSanPhamDTO;
        }

    }
}
