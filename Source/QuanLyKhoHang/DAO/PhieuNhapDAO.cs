using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class PhieuNhapDAO
    {
        public static bool InsertPhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuNhap", phieuNhapDTO.MaPhieuNhap));
            sqlParamas.Add(new SqlParameter("@MaDonHang", phieuNhapDTO.MaDonHang));
            sqlParamas.Add(new SqlParameter("@NgayNhan", phieuNhapDTO.NgayNhan));
            sqlParamas.Add(new SqlParameter("@MaNhanVien", phieuNhapDTO.MaNhanVien));
            return DataProvider.ExecuteNoneQuery("usp_InsertPhieuNhap",sqlParamas);
        }

        public static bool UpdatePhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuNhap", phieuNhapDTO.MaPhieuNhap));
            sqlParamas.Add(new SqlParameter("@MaDonHang", phieuNhapDTO.MaDonHang));
            sqlParamas.Add(new SqlParameter("@NgayNhan", phieuNhapDTO.NgayNhan));
            sqlParamas.Add(new SqlParameter("@MaNhanVien", phieuNhapDTO.MaNhanVien));
            return DataProvider.ExecuteNoneQuery("usp_UpdatePhieuNhapById",sqlParamas);
        }

        public static bool DeletePhieuNhap(PhieuNhapDTO phieuNhapDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuNhap",phieuNhapDTO.MaPhieuNhap));
            //SqlParameter para = new SqlParameter("@MaPhieuNhap",phieuNhapDTO.MaPhieuNhap); mot cach viet khac
            return DataProvider.ExecuteNoneQuery("usp_DeletePhieuNhapById", sqlParamas);
        }

        public static List<PhieuNhapDTO> SelectPhieuNhapAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectPhieuNhapAll");
            List<PhieuNhapDTO> listPhieuNhapDTO = new List<PhieuNhapDTO>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                phieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                phieuNhapDTO.MaDonHang = dataRow["MaDonHang"].ToString();
                phieuNhapDTO.NgayNhan = DateTime.Parse(dataRow["NgayNhan"].ToString());
                phieuNhapDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                listPhieuNhapDTO.Add(phieuNhapDTO);
            }
            return listPhieuNhapDTO;
        }

        public static List<PhieuNhapDTO> SelectPhieuNhapById(string MaPhieuNhap)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuNhap",MaPhieuNhap));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectPhieuNhapById", sqlParamas);
            List<PhieuNhapDTO> listphieuNhapDTO = new List<PhieuNhapDTO>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                phieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                phieuNhapDTO.MaDonHang = dataRow["MaDonHang"].ToString();
                phieuNhapDTO.NgayNhan = DateTime.Parse(dataRow["NgayNhan"].ToString());
                phieuNhapDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                listphieuNhapDTO.Add(phieuNhapDTO);
            }
            return listphieuNhapDTO;
        }
    }
}
