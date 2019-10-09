using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace LabAppLibrary.DAO
{
    class Conexao
    {
        SqlConnection sql = new SqlConnection();
        public string DB { get; } = @"Data Source=labappdb.c8nnr2bvs2jz.us-west-1.rds.amazonaws.com;Initial Catalog=LabApp;User ID=admin;Password=1012585pM";
        public Conexao()
        {
            sql.ConnectionString = DB;
        }

        public Conexao(string bancoDados)
        {
            DB = bancoDados;
            sql.ConnectionString = DB;
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
