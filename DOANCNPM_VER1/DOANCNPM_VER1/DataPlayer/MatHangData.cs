using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANCNPM_VER1.DataPlayer
{
    class MatHangData
    {
        DataConnection _DataConnection;
        public MatHangData()
        {
            _DataConnection = new DataConnection();
        }

        public DataTable LayTatCaMatHang_D()
        {
            string _Query = "select * from MATHANG";
            return _DataConnection.Read(_Query);
        }
        public void InsertMatHang_D(string maMatHang, string tenMatHang, string maDVT , int soLuongTon)
        {
            string _Query = "insert into MATHANG values ('"+maMatHang+"','"+tenMatHang+"','"+maDVT+"',"+soLuongTon+")";
            _DataConnection.Write(_Query);
        }

        public void UpdateMatHang_D(string maMatHang, string tenMatHang, string maDVT, int soLuongTon)
        {
            string _Query = "update MATHANG set MaMatHang = '" + maMatHang + "', TenMatHang = '" + tenMatHang + "', MaDonViTinh = '" + maDVT + "',SoLuongTon =  '" + soLuongTon + "' ";
            _DataConnection.Write(_Query);
        }

        public void DeleteMatHang_D(string maMatHang)
        {
            string _Query = "delete from MATHANG where MaMatHang = '"+maMatHang+"'";
            _DataConnection.Write(_Query);
        }

    }
}
