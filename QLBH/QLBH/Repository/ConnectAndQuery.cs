using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Repository
{
    class ConnectAndQuery
    {
        SqlConnection sqlConnection;

        public ConnectAndQuery()
        {
        }
        public void Connect()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=DESKTOP-RPK6PAD\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True";
            sqlConnection.Open();
        }

        public void DisConnect()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public DataTable LoadData(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public void Run(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}