using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class ThamSoDTO
    {
        //Ma Tham So;
        private string _maThamSo;

        public string MaThamSo
        {
            get { return _maThamSo; }
            set { _maThamSo = value; }
        }

        //Ten Tham So
        private string _tenThamSo;

        public string TenThamSo
        {
            get { return _tenThamSo; }
            set { _tenThamSo = value; }
        }

        //Gia Tri
        private string _giaTri;

        public string GiaTri
        {
            get { return _giaTri; }
            set { _giaTri = value; }
        }
    }
}
