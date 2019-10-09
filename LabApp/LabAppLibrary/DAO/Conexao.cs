using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LabAppLibrary.DAO
{
    class Conexao
    {
        SqlConnection sql = new SqlConnection();
        public Conexao()
        {
            sql.ConnectionString = @"";
        }

        public SqlConnection conectar()
        {
            if (sql.State == System.Data.ConnectionState.Closed)
                sql.Open();
            return sql;
        }
        public void desconectar()
        {
            if (sql.State == System.Data.ConnectionState.Open)
                sql.Close();
        }
    }
}
