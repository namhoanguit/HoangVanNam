using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOANCNPM_VER1.DataPlayer
{
    class PhieuNhapHangData
    {
        DataConnection dbConnection;
        public PhieuNhapHangData()
        {
            dbConnection = new DataConnection();
        }

        public DataTable LaytatCaPhieuNhap()
        {
            string query = "select * from PHIEUNHAPHANG";
            return dbConnection.Read(query);
        }

        public void InsertPhieuNhap_D(string maPhieuNhap, DateTime ngayLapPhieu,int tongTien)
        {
            string _NgayLapPhieu = ngayLapPhieu.ToString("dd/MM/yyyy");
            string _Query = "insert into PHIEUNHAPHANG values ('" + maPhieuNhap + "'," + _NgayLapPhieu + "," + tongTien + ")";
            dbConnection.Write(_Query);
        }

        public void DeletePhieuNhap_D(string maPhieuNhap)
        {
            string _Query = "DELETE FROM PHIEUNHAPHANG where ( MaPhieuNhapHang = '" + maPhieuNhap + "' )";
            dbConnection.Write(_Query);
        }

        public void UpdatePhieuNhap_D(string maPhieuNhap,  DateTime ngayLapPhieu, int tienTong)
        {
            string _Query = "UPDATE PHIEUNHAPHANG SET MaPhieuNhapHang = '" + maPhieuNhap + "' , NgayLapPhieu = '" + ngayLapPhieu + "',TongTien = '" + tienTong + "' where MaPhieuNhapHang = '" + maPhieuNhap + "' ";
            dbConnection.Write(_Query);
        }
    }
}
