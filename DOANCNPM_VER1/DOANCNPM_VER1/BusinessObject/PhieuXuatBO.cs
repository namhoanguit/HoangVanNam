using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCNPM_VER1.VO
{
    class PhieuXuatBO
    {
        private string _MaPhieuXuat;

        public string MaPhieuXuat
        {
            get { return _MaPhieuXuat; }
            set { _MaPhieuXuat = value; }
        }
        private string _MaDaiLy;

        public string MaDaiLy
        {
            get { return _MaDaiLy; }
            set { _MaDaiLy = value; }
        }
        private DateTime _NgayLapPhieu;

        public DateTime NgayLapPhieu
        {
            get { return _NgayLapPhieu; }
            set { _NgayLapPhieu = value; }
        }
        private int _TongTien;

        public int TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
    }
}
