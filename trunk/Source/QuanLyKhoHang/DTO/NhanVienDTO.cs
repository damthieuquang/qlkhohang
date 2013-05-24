using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        //Ma Nhan Vien
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }

        //Ten Nhan Ven
        private string _tenNhanVien;

        public string TenNhanVien
        {
            get { return _tenNhanVien; }
            set { _tenNhanVien = value; }
        }

        //Mat Kau
        private string _matKhau;

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

        //Loai Nhan Vien
        private int _loaiNhanVien;

        public int LoaiNhanVien
        {
            get { return _loaiNhanVien; }
            set { _loaiNhanVien = value; }
        }
    }
}
