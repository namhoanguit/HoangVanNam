using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DOANCNPM_VER1.Setting
{
    class HeThong:DataTable
    {
        public static SqlConnection _Connection;
        public SqlDataAdapter _DataAdapter;
        public SqlCommand _Command;
        public static string _StrConn;

        public HeThong()
        {
            _StrConn = @"Data Source=TOBI\TOBI;Initial Catalog=QuanLyDaiLy;Integrated Security=True";
            _DataAdapter = new SqlDataAdapter();
            _Connection = new SqlConnection();
            _Command = new SqlCommand();
        }

        public void CaiDatHeThong(SqlCommand command)
        {
            DataTable _Table = new DataTable();
            if(_Connection.State == ConnectionState.Closed || _Connection.State == ConnectionState.Broken ||_Connection == null)
            {
                _Connection = new SqlConnection(_StrConn);
                _Connection.Open();
            }
            _Command = command;
            _Command.Connection = _Connection;
            _DataAdapter = new SqlDataAdapter(_Command);
            _Table.Clear();
            _DataAdapter.Fill(this);
        }

        public void CapNhat()
        {
            SqlCommandBuilder buider = new SqlCommandBuilder(_DataAdapter);
            _DataAdapter.Update(this);
        }

        public static bool MoKetNoi()
        {
            try
            {
                if (_Connection == null)
                    _Connection = new SqlConnection(_StrConn);
                if (_Connection.State == ConnectionState.Closed)
                    _Connection.Open();
                return true;
            }
            catch
            {
                _Connection.Close();
                return false;
            }
        }

        public int ThucThiLenhQuery()
        {
            int result = 0;
            SqlTransaction _SqlTransaction = null;
            // m_Dataset = new DataSet();
            try
            {
                _SqlTransaction = _Connection.BeginTransaction();

                _Command.Connection = _Connection;
                _Command.Transaction = _SqlTransaction;

                _DataAdapter = new SqlDataAdapter();
                _DataAdapter.SelectCommand = _Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(_DataAdapter);

                result = _DataAdapter.Update(this);
                //m_DataAdapter.Fill(m_Dataset);
                _SqlTransaction.Commit();
            }
            catch (Exception e)
            {
                if (_SqlTransaction != null) _SqlTransaction.Rollback();
            }
            return result;
        }

        public int ThucThiLenhQuery(SqlCommand command) 
        {

            int result = 0;
            SqlTransaction _SqlTransaction = null;
            try
            {
                _SqlTransaction = _Connection.BeginTransaction();
                command.Connection = _Connection;
                command.Transaction = _SqlTransaction;
                result = command.ExecuteNonQuery();
                this.AcceptChanges();
                _SqlTransaction.Commit();

            }
            catch (Exception e)
            {
                if (_SqlTransaction != null) _SqlTransaction.Rollback();
                throw;
            }
            return result;
        }

        public object ExecuteScalar(SqlCommand command)
        {
            object result = null;
            SqlTransaction _SqlTransaction = null;
            _SqlTransaction = _Connection.BeginTransaction();
            command.Connection = _Connection;
            command.Transaction = _SqlTransaction;
            result = command.ExecuteScalar();
            this.AcceptChanges();
            _SqlTransaction.Commit();
            if (result == DBNull.Value)
            {
                result = null;
            }
            return result;
        }

    }
}
