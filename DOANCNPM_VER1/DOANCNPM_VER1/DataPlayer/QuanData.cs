using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DOANCNPM_VER1.Setting;
using System.Windows.Forms;

namespace DOANCNPM_VER1.DataPlayer
{
    class QuanData
    {
        DataConnection dbConnection;
        public QuanData()
        {
            dbConnection = new DataConnection();
        }

        public DataTable GetDSQuan()
        {
            string query = "select * from QUAN";
            return dbConnection.Read(query);
        }

        public void InsertQuan(string maQuan , string tenQuan)
        {
            string _Query = "insert into QUAN values ('"+maQuan+"','"+tenQuan+"')";
            dbConnection.Write(_Query);
        }

        public void DeleteQuan(string maQuan)
        {
            string _Query = "DELETE FROM QUAN where ( MaQuan = '" + maQuan + "' )";
            dbConnection.Write(_Query);
        }

        public void UpdateQuan(string maQuan,string tenQuan)
        {
            string _Query = "UPDATE QUAN SET MaQuan = '"+maQuan+"', TenQuan = '"+tenQuan+"' where MaQuan = '"+maQuan+"'";
            dbConnection.Write(_Query);
        }

    }
}
