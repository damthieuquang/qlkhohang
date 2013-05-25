using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietDonHangDTO
    {

        //Ma Chi Tiet Don Hang
        private string _maChiTietDonHang;

        public string MaChiTietDonHang
        {
            get { return _maChiTietDonHang; }
            set { _maChiTietDonHang = value; }
        }

        //Ma Don Hang
        private string _maDonHang;

        public string MaDonHang
        {
            get { return _maDonHang; }
            set { _maDonHang = value; }
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
         
        //So Luong
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        //Don Gia 
        private float _donGia;

        public float DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
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
