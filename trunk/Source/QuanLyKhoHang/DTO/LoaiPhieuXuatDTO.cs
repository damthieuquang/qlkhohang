using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class LoaiPhieuXuatDTO
    {
        //Ma Loai Phieu Xuat
        private string _maLoaiPhieuXuat;

        public string MaLoaiPhieuXuat
        {
            get { return _maLoaiPhieuXuat; }
            set { _maLoaiPhieuXuat = value; }
        }

        //Ten Loai Phieu Xuat
        private string _tenLoaiPhieuXuat;

        public string TenLoaiPhieuXuat
        {
            get { return _tenLoaiPhieuXuat; }
            set { _tenLoaiPhieuXuat = value; }
        }
    }
}
