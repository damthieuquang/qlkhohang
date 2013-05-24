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
    }
}
