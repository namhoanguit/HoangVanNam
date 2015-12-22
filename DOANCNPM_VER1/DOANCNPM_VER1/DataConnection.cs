using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANCNPM_VER1
{
    class DataConnection
    {
      //  public SqlConnection cn = new SqlConnection();
        //const string _StrConn = @"Data Source=TOBI;Initial Catalog=QuanLyDaiLy123;Integrated Security=True";
        //const string _StrConn = @"Data Source=(LocalDB)\v11.0;Initial Catalog=QuanLyDaiLy1;Integrated Security=True";
       // const string _StrConn = @"Data Source=HOANGTUAN\TUAN;Initial Catalog=D:\HOC KY 6\PHÁT TRIỂN, VẬN HÀNH, BẢO TRÌ PHẦN MỀM\DOANCNPM_VER3\FILE SQL\QUANLYDAILY1.MDF;Integrated Security=True";
        //const string _StrConn = @"Data Source=.;Initial Catalog=QuanLyDaiLy123;Integrated Security=True";
        const string _StrConn = @"Data Source=NAMHOANG;Initial Catalog=QuanLyDaiLy;Integrated Security=True";
        SqlConnection _SqlConnection;
        public DataConnection()
        {
            _SqlConnection = new SqlConnection(_StrConn);
        }
        public SqlConnection OpenConnnection()
        {
            if (_SqlConnection.State != System.Data.ConnectionState.Open)
            {
                _SqlConnection.Open();
            }
            return _SqlConnection;
        }

        public DataTable Read(string sql_query)
        {
            //mo ket noi
            SqlConnection sql_con = OpenConnnection();
            DataTable data_table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_query, sql_con);
            adapter.Fill(data_table);
            adapter.Dispose();
            return data_table;
        }

        public DataTable XemDL(string sql)
        {
            OpenConnnection();
            SqlConnection cn = OpenConnnection();
            SqlDataAdapter adap = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;

          
        }
        //ghi xuống database
        public void Write(string sql_query)
        {
            try
            {
                SqlConnection sql_con = OpenConnnection();
                SqlCommand sql_cmd = new SqlCommand(sql_query, sql_con);
                sql_cmd.ExecuteNonQuery();
                //sql_cmd.Dispose();
            }
            catch
            {

            }
        }


        //public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
        //{
        //    SqlCommand myCommand = new SqlCommand();
        //    try
        //    {
        //        myCommand.Connection = openConnection();
        //        myCommand.CommandText = _query;
        //        myCommand.Parameters.AddRange(sqlParameter);
        //        myAdapter.InsertCommand = myCommand;
        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //    }
        //    return true;
        //}

        //public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        //{
        //    SqlCommand myCommand = new SqlCommand();
        //    try
        //    {
        //        myCommand.Connection = openConnection();
        //        myCommand.CommandText = _query;
        //        myCommand.Parameters.AddRange(sqlParameter);
        //        myAdapter.UpdateCommand = myCommand;
        //        myCommand.ExecuteNonQuery();
        //    }
        //    catch (SqlException e)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //    }
        //    return true;
        //}
    }    
}
