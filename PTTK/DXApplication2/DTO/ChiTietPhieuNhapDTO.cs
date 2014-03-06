using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        //Ma CHi Tiet Phieu Nhap
        private string _maChiTietPhieuNhap;

        public string MaChiTietPhieuNhap
        {
            get { return _maChiTietPhieuNhap; }
            set { _maChiTietPhieuNhap = value; }
        }

        //Ma Phieu Nhap
        private string _maPhieuNhap;

        public string MaPhieuNhap
        {
            get { return _maPhieuNhap; }
            set { _maPhieuNhap = value; }
        }

        //Ma San Pham
        private string _maSanPham;

        public string MaSanPham
        {
            get { return _maSanPham; }
            set { _maSanPham = value; }
        }

      

        //So Luong Da Nhan
        private int _slNhan;

        public int SLNhan
        {
            get { return _slNhan; }
            set { _slNhan = value; }
        }

        //Ghi Chu
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
    }
}
