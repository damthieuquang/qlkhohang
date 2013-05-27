using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class PhieuXuatDAO
    {
        public static bool InsertPhieuXuat(PhieuXuatDTO phieuXuatDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuXuat", phieuXuatDTO.MaPhieuXuat));
            sqlParamas.Add(new SqlParameter("@NgayBan", phieuXuatDTO.NgayBan));
            sqlParamas.Add(new SqlParameter("@MaThanhVien", phieuXuatDTO.MaThanhVien));
            sqlParamas.Add(new SqlParameter("@MaNhanVien", phieuXuatDTO.MaNhanVien));
            sqlParamas.Add(new SqlParameter("@TenKhachHang", phieuXuatDTO.TenKhachHang));
            sqlParamas.Add(new SqlParameter("@DiaChi", phieuXuatDTO.DiaChi));
            sqlParamas.Add(new SqlParameter("@MaLoaiPhieuXuat", phieuXuatDTO.MaLoaiPhieuXuat));
            return DataProvider.ExecuteNoneQuery("usp_InsertPhieuXuat", sqlParamas);
        }

        public static bool UpdatePhieuXuat(PhieuXuatDTO phieuXuatDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuXuat", phieuXuatDTO.MaPhieuXuat));
            sqlParamas.Add(new SqlParameter("@NgayBan", phieuXuatDTO.NgayBan));
            sqlParamas.Add(new SqlParameter("@MaThanhVien", phieuXuatDTO.MaThanhVien));
            sqlParamas.Add(new SqlParameter("@MaNhanVien", phieuXuatDTO.MaNhanVien));
            sqlParamas.Add(new SqlParameter("@TenKhachHang", phieuXuatDTO.TenKhachHang));
            sqlParamas.Add(new SqlParameter("@DiaChi", phieuXuatDTO.DiaChi));
            sqlParamas.Add(new SqlParameter("@MaLoaiPhieuXuat", phieuXuatDTO.MaLoaiPhieuXuat));
            return DataProvider.ExecuteNoneQuery("usp_UpdatePhieuXuatById", sqlParamas);
        }

        public static bool DeletePhieuXuat(PhieuXuatDTO phieuXuatDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuXuat", phieuXuatDTO.MaPhieuXuat));
            //SqlParameter para = new SqlParameter("@MaPhieuNhap",phieuNhapDTO.MaPhieuNhap); mot cach viet khac
            return DataProvider.ExecuteNoneQuery("usp_DeletePhieuXuatById", sqlParamas);
        }

        public static List<PhieuXuatDTO> SelectPhieuXuatAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectPhieuXuatAll");
            List<PhieuXuatDTO> listPhieuXuatDTO = new List<PhieuXuatDTO>();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PhieuXuatDTO phieuXuatDTO = new PhieuXuatDTO();
                    phieuXuatDTO.MaPhieuXuat = dataRow["MaPhieuXuat"].ToString();
                    phieuXuatDTO.NgayBan = DateTime.Parse(dataRow["NgayBan"].ToString());
                    phieuXuatDTO.MaThanhVien = dataRow["MaThanhVien"].ToString();
                    phieuXuatDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                    phieuXuatDTO.TenKhachHang = dataRow["TenKhachHang"].ToString();
                    phieuXuatDTO.DiaChi = dataRow["DiaChi"].ToString();
                    phieuXuatDTO.MaLoaiPhieuXuat = dataRow["MaLoaiPhieuXuat"].ToString();
                    listPhieuXuatDTO.Add(phieuXuatDTO);
                }
            }
            else
            {
                listPhieuXuatDTO = null;
            }
            
            return listPhieuXuatDTO;
        }

        public static PhieuXuatDTO SelectPhieuXuatById(string MaPhieuXuat)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuXuat", MaPhieuXuat));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectPhieuXuatById", sqlParamas);

            PhieuXuatDTO phieuXuatDTO = new PhieuXuatDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                phieuXuatDTO.MaPhieuXuat = dataRow["MaPhieuXuat"].ToString();
                phieuXuatDTO.NgayBan = DateTime.Parse(dataRow["NgayBan"].ToString());
                phieuXuatDTO.MaThanhVien = dataRow["MaThanhVien"].ToString();
                phieuXuatDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                phieuXuatDTO.TenKhachHang = dataRow["TenKhachHang"].ToString();
                phieuXuatDTO.DiaChi = dataRow["DiaChi"].ToString();
                phieuXuatDTO.MaLoaiPhieuXuat = dataRow["MaLoaiPhieuXuat"].ToString();
            }
            else
            {
                phieuXuatDTO = null;
            }
            return phieuXuatDTO;
        }
    }
}
