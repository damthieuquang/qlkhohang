using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DonHangDTO
    {
        //Ma Don Hang
        private string _maDonHang;

        public string MaDonHang
        {
            get { return _maDonHang; }
            set { _maDonHang = value;}
        }

        //Ngay Lap
        private DateTime _ngayLap;

        public DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }

        //Ma Nhan Vien
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        //Thanh Tien
        private float _thanhTien;

        public float ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }

        //Trang Thai
        private string _trangThai;

        public string TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

    }
}
