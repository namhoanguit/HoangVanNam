using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOANCNPM_VER1.DataPlayer
{
    class CT_PhieuNhapData
    {
        private DataConnection _DataConnection;
        public CT_PhieuNhapData()
        {
            _DataConnection = new DataConnection();
        }

        public DataTable LayTatCaCT_PN_D()
        {
            string _Query = "select * from CT_PNH";
            return _DataConnection.Read(_Query);  
        }

        public DataTable LayTatCaMatHang()
        {
            string _Query = "select *from MATHANG";
            return _DataConnection.Read(_Query);
        }
        public DataTable LayCT_PN_TheoMaPN_D(string maPhieuNhap)
        {
            string _Query = " select *from CT_PNH where MaPhieuNhapHang = '" + maPhieuNhap + "'";
            return _DataConnection.Read(_Query);
        }

        public void InsertCT_PN_D(string maCT_PN, string maPhieuNhap, string maMatHang, int soLuong, int donGia, int thanhTien)
        {
            string _Query = "insert into CT_PNH values('" + maCT_PN + "','" + maPhieuNhap + "','" + maMatHang + "' , " + soLuong + "," + donGia + "," + thanhTien + ")";
            _DataConnection.Write(_Query);
        }

        public void DeleteCT_PN_D(string maCT_PN)
        {
            string _Query = "delete from CT_PNH where MaCT_PNH = '" + maCT_PN + "'";
            _DataConnection.Write(_Query);
        }

        public void UpdateCT_PN_D(string maCT_PN, string maPhieuNhap, string maMatHang, int soLuong, int donGia, int thanhTien)
        {
            string _Query = "update CT_PNH set MaCT_PNH = '"+maCT_PN+"',MaMatHang = '"+maMatHang+"',MaPhieuXuatHang = '"+maPhieuNhap+"', SoLuong = "+soLuong+",DonGia = "+donGia+",ThanhTien = "+thanhTien+"";
            _DataConnection.Write(_Query);
        }
         
    }
}
