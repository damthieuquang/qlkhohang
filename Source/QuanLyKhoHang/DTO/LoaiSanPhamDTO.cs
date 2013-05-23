using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class LoaiSanPhamDTO
    {
        //Ma Loai San Pham
        private string _maLoaiSanPham;

        public string MaLoaiSanPham
        {
            get { return _maLoaiSanPham; }
            set { _maLoaiSanPham = value; }
        }

        //Ten Loai San Pham
        private string _tenLoaiSanPham;

        public string TenLoaiSanPham
        {
            get { return _tenLoaiSanPham; }
            set { _tenLoaiSanPham = value; }
        }
    }
}
