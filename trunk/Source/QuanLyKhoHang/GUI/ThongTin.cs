using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Windows.Forms;

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

        private static ThamSoDTO _thamSoDTO;
        
        public static ThamSoDTO ThamSoDTO
        {
            get { return _thamSoDTO; }
            set { _thamSoDTO = value; }
        }

        //Kiểm tra datagridview có rỗng không
        public static bool CheckOut(DataGridView data)
        {
            if (data.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
