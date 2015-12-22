using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DOANCNPM_VER1.DataPlayer
{
    class LoaiDaiLyData
    {
        DataConnection dbConnection;
        public LoaiDaiLyData()
        {
            dbConnection = new DataConnection();
        }

        public DataTable GetDSLoaiDL_D()
        {
            string query = "select * from LOAIDAILY";
            return dbConnection.Read(query);
        }

        public void InsertLoaiDL_D(string maLoaiDL , string tenLoaiDL)
        {
            string _Query = "insert into LOAIDAILY values ('" + maLoaiDL + "','" + tenLoaiDL + "')";
            dbConnection.Write(_Query);
        }

        public void DeleteLoaiDL_D(string maLoaiDL)
        {
            string _Query = "DELETE FROM LOAIDAILY where ( MaLoaiDaiLy = '" + maLoaiDL + "' )";
            dbConnection.Write(_Query);
        }

        public void UpdateLoaiDL_D(string maLoaiDL, string tenLoaiDL)
        {
            string _Query = "UPDATE LOAIDAILY SET MaLoaiDaiLy = '" + maLoaiDL + "', TenLoaiDaiLy = '" + tenLoaiDL + "' where MaLoaiDaiLy = '" + maLoaiDL + "'";
            dbConnection.Write(_Query);
        }
    }
}

