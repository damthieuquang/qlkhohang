using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class PhieuXuatDTO
    {
        //Ma Phieu Xuat
        private string _maPhieuXuat;

        public string MaPhieuXuat
        {
            get { return _maPhieuXuat; }
            set { _maPhieuXuat = value; }
        }

        //Ngay Ban
        private DateTime _ngayBan;

        public DateTime NgayBan
        {
            get { return _ngayBan; }
            set { _ngayBan = value; }
        }

        //Ma Thanh Vien
        private string _maThanhVien;

        public string MaThanhVien
        {
            get { return _maThanhVien; }
            set { _maThanhVien = value; }
        }

        //Ma Nhan Vien
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        //Ten Khach Hang
        private string _tenKhachHang;

        public string TenKhachHang
        {
            get { return _tenKhachHang; }
            set { _tenKhachHang = value; }
        }

        //Dia Chi
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        //Ma Loai Phieu Xuat
        private string _maLoaiPhieuXuat;

        public string MaLoaiPhieuXuat
        {
            get { return _maLoaiPhieuXuat; }
            set { _maLoaiPhieuXuat = value; }
        }
    }
}
