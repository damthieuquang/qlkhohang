using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class SanPhamDTO
    {
        //Ma San Pham
        private string _maSanPham;

        public string MaSanPham
        {
            get { return _maSanPham; }
            set { _maSanPham = value; }
        }

        //Ten San Pham
        private string _tenSanPham;

        public string TenSanPham
        {
            get { return _tenSanPham; }
            set { _tenSanPham = value; }
        }

        //CV
        private int _cV;

        public int CV
        {
            get { return _cV; }
            set { _cV = value; }
        }

        //Don Gia
        private float _donGia;

        public float DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        //Don Gia Thanh Vien
        private float _donGiaTV;

        public float DonGiaTV
        {
            get { return _donGiaTV; }
            set { _donGiaTV = value; }
        }

        //So Luong Ton
        private int _soLuongTon;

        public int SoLuongTon
        {
            get { return _soLuongTon; }
            set { _soLuongTon = value; }
        }

        //Ma Loai San Pham
        private string _maLoaiSanPham;

        public string MaLoaiSanPham
        {
            get { return _maLoaiSanPham; }
            set { _maLoaiSanPham = value; }
        }
    }
}
