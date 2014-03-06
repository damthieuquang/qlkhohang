using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietPhieuXuatDTO
    {
        //Ma Chi Tiet Phieu Xuat
        private string _maChiTietPhieuXuat;

        public string MaChiTietPhieuXuat
        {
            get { return _maChiTietPhieuXuat; }
            set { _maChiTietPhieuXuat = value; }
        }

        //Ma Phieu Xuat
        private string _maPhieuXuat;

        public string MaPhieuXuat
        {
            get { return _maPhieuXuat; }
            set { _maPhieuXuat = value; }
        }

        //Ma San Pham
        private string _maSanPham;

        public string MaSanPham
        {
            get { return _maSanPham; }
            set { _maSanPham = value; }
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

        //So Luong
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        //Thanh Tien

        private float _thanhTien;

        public float ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
        }
    }
}
