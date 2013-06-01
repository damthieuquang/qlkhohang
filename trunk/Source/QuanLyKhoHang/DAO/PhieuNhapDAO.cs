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

        public static bool UpdatePhieuNhapById(PhieuNhapDTO phieuNhapDTO)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuNhap", phieuNhapDTO.MaPhieuNhap));
            sqlParamas.Add(new SqlParameter("@MaDonHang", phieuNhapDTO.MaDonHang));
            sqlParamas.Add(new SqlParameter("@NgayNhan", phieuNhapDTO.NgayNhan));
            sqlParamas.Add(new SqlParameter("@MaNhanVien", phieuNhapDTO.MaNhanVien));
            return DataProvider.ExecuteNoneQuery("usp_UpdatePhieuNhapById",sqlParamas);
        }

        public static bool DeletePhieuNhapById(string maPhieuNhap)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuNhap", maPhieuNhap));
            //SqlParameter para = new SqlParameter("@MaPhieuNhap",phieuNhapDTO.MaPhieuNhap); mot cach viet khac
            return DataProvider.ExecuteNoneQuery("usp_DeletePhieuNhapById", sqlParamas);
        }

        public static List<PhieuNhapDTO> SelectPhieuNhapAll()
        {
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectPhieuNhapAll");
            List<PhieuNhapDTO> listPhieuNhapDTO = new List<PhieuNhapDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                    phieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                    phieuNhapDTO.MaDonHang = dataRow["MaDonHang"].ToString();
                    phieuNhapDTO.NgayNhan = DateTime.Parse(dataRow["NgayNhan"].ToString());
                    phieuNhapDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                    listPhieuNhapDTO.Add(phieuNhapDTO);
                }
            }
            else
            {
                listPhieuNhapDTO = null;
            }
            
            return listPhieuNhapDTO;
        }

        public static PhieuNhapDTO SelectPhieuNhapById(string MaPhieuNhap)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaPhieuNhap",MaPhieuNhap));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectPhieuNhapById", sqlParamas);

            PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                phieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                phieuNhapDTO.MaDonHang = dataRow["MaDonHang"].ToString();
                phieuNhapDTO.NgayNhan = DateTime.Parse(dataRow["NgayNhan"].ToString());
                phieuNhapDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
            }
            else
            {
                phieuNhapDTO = null;
            }
            return phieuNhapDTO;
        }

        public static List<PhieuNhapDTO> SelectPhieuNhapByMaDonHang(string MaDonHang)
        {
            List<SqlParameter> sqlParamas = new List<SqlParameter>();
            sqlParamas.Add(new SqlParameter("@MaDonHang", MaDonHang));
            DataTable dataTable = DataProvider.ExecuteReader("usp_SelectPhieuNhapByMaDonHang", sqlParamas);

            List<PhieuNhapDTO> listPhieuNhapDTO = new List<PhieuNhapDTO>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
                    phieuNhapDTO.MaPhieuNhap = dataRow["MaPhieuNhap"].ToString();
                    phieuNhapDTO.MaDonHang = dataRow["MaDonHang"].ToString();
                    phieuNhapDTO.NgayNhan = DateTime.Parse(dataRow["NgayNhan"].ToString());
                    phieuNhapDTO.MaNhanVien = dataRow["MaNhanVien"].ToString();
                    listPhieuNhapDTO.Add(phieuNhapDTO);
                }
            }
            else
            {
                listPhieuNhapDTO = null;
            }

            return listPhieuNhapDTO;
        }
        
    }
}
