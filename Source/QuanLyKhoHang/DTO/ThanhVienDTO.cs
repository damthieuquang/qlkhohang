using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class ThanhVienDTO
    {
        //Ma Thanh Vien
        private string _maThanhVien;

        public string MaThanhVien
        {
            get { return _maThanhVien; }
            set { _maThanhVien = value; }
        }

        //Ten Thanh Vien
        private string _tenThanhVien;

        public string TenThanhVien
        {
            get { return _tenThanhVien; }
            set { _tenThanhVien = value; }
        }

        //Dia Chi 
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        //CV
        private int _cV;

        public int CV
        {
            get { return _cV; }
            set { _cV = value; }
        }

        //Tien No
        private float _tienNo;

        public float TienNo
        {
            get { return _tienNo; }
            set { _tienNo = value; }
        }
    }
}
