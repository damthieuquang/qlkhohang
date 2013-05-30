using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;

namespace GUI
{
    public class ThongTin
    {
        private static NhanVienDTO _nhanVienDTO;

        public static NhanVienDTO NhanVienDTO
        {
            get { return ThongTin._nhanVienDTO; }
            set { ThongTin._nhanVienDTO = value; }
        }

        private ThamSoDTO _thamSoDTO;
        
        public ThamSoDTO ThamSoDTO
        {
            get { return _thamSoDTO; }
            set { _thamSoDTO = value; }
        }
    }
}
