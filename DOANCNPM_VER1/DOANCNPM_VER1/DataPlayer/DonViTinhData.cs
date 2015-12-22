using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOANCNPM_VER1.DataPlayer
{
    class DonViTinhData
    {
        DataConnection _DataConnection;
        public DonViTinhData()
        {
            _DataConnection = new DataConnection();
        }

        public DataTable GetDS_DonViTinh()
        {
            string query = "select * from DONVITINH";
            return _DataConnection.Read(query);
        }

        public void Insert_DonViTinh_D(string maDVT, string tenDVT)
        {
            string _Query = "insert into DONVITINH values ('" + maDVT + "','" + tenDVT + "')";
            _DataConnection.Write(_Query);
        }

        public void Delete_DonViTinh_D(string maDVT)
        {
            string _Query = "DELETE FROM DONVITINH where ( MaDonViTinh = '" + maDVT + "' )";
            _DataConnection.Write(_Query);
        }

        public void Update_DonViTinh_D(string maDVT, string tenDVT)
        {
            string _Query = "UPDATE DONVITINH SET MaDonViTinh = '" + maDVT + "', TenDonViTinh = '" + tenDVT + "' where MaDonViTinh = '" + maDVT + "'";
            _DataConnection.Write(_Query);
        }
    }
}
