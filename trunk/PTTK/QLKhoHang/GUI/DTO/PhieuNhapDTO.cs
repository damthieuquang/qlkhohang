using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuNhapDTO
    {
        //Ma Phieu Nhap
        private string _maPhieuNhap;

        public string MaPhieuNhap
        {
            get { return _maPhieuNhap; }
            set { _maPhieuNhap = value; }
        }

        //Ma Don Hang
        private string _maDonHang;

        public string MaDonHang
        {
            get { return _maDonHang; }
            set { _maDonHang = value; }
        }

        //Ngay Nhan
        private DateTime _ngayNhan;

        public DateTime NgayNhan
        {
            get { return _ngayNhan; }
            set { _ngayNhan = value; }
        }

        //Ma Nhan Vien
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
    }
}
