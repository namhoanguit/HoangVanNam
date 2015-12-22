using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOANCNPM_VER1.Controller;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace DOANCNPM_VER1.DataPlayer
{
    class PhieuXuatHangData
    {
        DataConnection dbConnection;
        public PhieuXuatHangData()
        {
            dbConnection = new DataConnection();
        }

        public DataTable GetDSPhieuXuat_D()
        {
            string query = "select * from PHIEUXUATHANG";
            return dbConnection.Read(query);
        }

        public DataTable LayTatCaPhieuXuatVaCT_PX_D()
        {
            string _Query = "select * from PHIEUXUATHANG FULL OUTER JOIN CT_PXH ON PHIEUXUATHANG.MaPhieuXuatHang = CT_PXH.MaPhieuXuatHang";
            return dbConnection.Read(_Query);
        }

        public void InsertPhieuXuat_D(string maPhieuXuat, string maDaiLy, DateTime ngayLapPhieu,int tongTien)
        {
            string _NgayLapPhieu = ngayLapPhieu.ToString("dd/MM/yyyy");
            string _Query = "insert into PHIEUXUATHANG values ('"+maPhieuXuat+"','"+maDaiLy+"',"+_NgayLapPhieu+","+tongTien+")";
            dbConnection.Write(_Query);
        }

        public void DeletePhieuXuat_D(string maPhieuXuat)
        {
            string _Query = "DELETE FROM PHIEUXUATHANG where ( MaPhieuXuatHang = '" + maPhieuXuat + "' )";
            dbConnection.Write(_Query);
        }

        public void UpdatePhieuXuat_D(string maPhieuXuat, string maDaiLy, DateTime ngayLapPhieu, int tienTong)
        {
            string _Query = "UPDATE PHIEUXUATHANG SET MaPhieuXuatHang = '" + maPhieuXuat + "', MaDaiLy = '" + maDaiLy + "', NgayLapPhieu = '"+ngayLapPhieu+"',TongTien = '"+tienTong+"' where MaPhieuXuatHang = '" + maPhieuXuat + "' ";
            dbConnection.Write(_Query);
        }
    }
}
