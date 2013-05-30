using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class LoaiPhieuXuatDAO
    {
        public static string CreateLoaiPhieuXuatId()
        {
            return (string)DataProvider.ExecuteScalar("usp_CreateLoaiPhieuXuatId");
        }

        public static bool InsertLoaiPhieuXuat(LoaiPhieuXuatDTO loaiPhieuXuatDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaLoaiPhieuXuat", loaiPhieuXuatDTO.MaLoaiPhieuXuat));
            sqlParamas.Add(new SqlParameter("@TenLoaiPhieuXuat", loaiPhieuXuatDTO.TenLoaiPhieuXuat));
            return DataProvider.ExecuteNoneQuery("usp_InsertLoaiPhieuXuat", sqlParamas);
        }

        public static bool UpdateLoaiPhieuXuatById(LoaiPhieuXuatDTO loaiPhieuXuatDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaLoaiPhieuXuat", loaiPhieuXuatDTO.MaLoaiPhieuXuat));
            sqlParamas.Add(new SqlParameter("@TenLoaiPhieuXuat", loaiPhieuXuatDTO.TenLoaiPhieuXuat));
            return DataProvider.ExecuteNoneQuery("usp_UpdateLoaiPhieuXuatById", sqlParamas);
        }

        public static bool DeleteLoaiPhieuXuatById(string maLoaiPhieuXuat)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaLoaiPhieuXuat", maLoaiPhieuXuat));
            return DataProvider.ExecuteNoneQuery("usp_DeleteLoaiPhieuXuatById", sqlParamas);
        }

        public static List<LoaiPhieuXuatDTO> SelectLoaiPhieuXuatAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectLoaiPhieuXuatAll");
            List<LoaiPhieuXuatDTO> listLoaiPhieuXuatDTO = new List<LoaiPhieuXuatDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    LoaiPhieuXuatDTO loaiPhieuXuatDTO = new LoaiPhieuXuatDTO();
                    loaiPhieuXuatDTO.MaLoaiPhieuXuat = dataRow["MaLoaiPhieuXuat"].ToString();
                    loaiPhieuXuatDTO.TenLoaiPhieuXuat = dataRow["TenLoaiPhieuXuat"].ToString();
                    listLoaiPhieuXuatDTO.Add(loaiPhieuXuatDTO);
                }
            }
            else
            {
                listLoaiPhieuXuatDTO = null;
            }
            return listLoaiPhieuXuatDTO;
        }

        public static LoaiPhieuXuatDTO SelectLoaiPhieuXuatById(string MaLoaiPhieuXuat)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaLoaiPhieuXuat", MaLoaiPhieuXuat));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectLoaiPhieuXuatById", sqlParamas);

            LoaiPhieuXuatDTO loaiPhieuXuatDTO = new LoaiPhieuXuatDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                loaiPhieuXuatDTO.MaLoaiPhieuXuat = dataRow["MaLoaiPhieuXuat"].ToString();
                loaiPhieuXuatDTO.TenLoaiPhieuXuat = dataRow["TenLoaiPhieuXuat"].ToString();
            }
            else
            {
                loaiPhieuXuatDTO = null;
            }

            return loaiPhieuXuatDTO;
        }
    }
}
