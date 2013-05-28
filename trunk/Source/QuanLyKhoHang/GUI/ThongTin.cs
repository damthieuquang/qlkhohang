﻿using System;
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

        private static DonHangDTO _donHangDTO;

        public static DonHangDTO DonHangDTO
        {
            get { return ThongTin._donHangDTO; }
            set { ThongTin._donHangDTO = value; }
        }
    }
}
