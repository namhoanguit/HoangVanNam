using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANCNPM_VER1.DataPlayer
{
    class CT_PhieuXuatData
    {
        private DataConnection _DataConnection;
        public CT_PhieuXuatData()
        {
            _DataConnection = new DataConnection();
        }

        public DataTable LayTatCaCT_PX_D()
        {
            string _Query = "select * from CT_PXH ";
            return _DataConnection.Read(_Query);  
        }

        public DataTable LayTatCaMatHang()
        {
            string _Query = "select *from MATHANG";
            return _DataConnection.Read(_Query);
        }
        public DataTable LayCT_PX_TheoMaDL_D(string maPhieuXuat)
        {
            string _Query = " select *from CT_PXH where MaPhieuXuatHang = '" + maPhieuXuat + "'";
            return _DataConnection.Read(_Query);
        }

        public void InsertCT_PX_D(string maCT_PX, string maPhieuXuat, string maMatHang, int soLuong, int donGia, int thanhTien)
        {
            string _Query = "insert into CT_PXH values('"+maCT_PX+"','"+maPhieuXuat+"','"+maMatHang+"' , "+soLuong+","+donGia+","+thanhTien+")";
            _DataConnection.Write(_Query);
        }

        public void DeleteCT_PX_D(string maCT_PX)
        {
            string _Query = "delete from CT_PXH where MaCT_PXH = '" + maCT_PX + "'";
            _DataConnection.Write(_Query);
        }

        public void UpdateCT_PX_D(string maCT_PX, string maPhieuXuat, string maMatHang, int soLuong, int donGia, int thanhTien)
        {
            string _Query = "update CT_PXH set MaCT_PXH = '"+maCT_PX+"',MaMatHang = '"+maMatHang+"',MaPhieuXuatHang = '"+maPhieuXuat+"', SoLuong = "+soLuong+",DonGia = "+donGia+",ThanhTien = "+thanhTien+"";
            _DataConnection.Write(_Query);
        }
         
    }
}
