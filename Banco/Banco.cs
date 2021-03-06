﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Reserva.Banco
{
    public static class BD
    {
        public static string CONNECTION_STRING = "Data Source=.;Initial Catalog=db_reserva;Persist Security Info=True;User ID=sa; Password=sadministrador";

        public static Connection Conexao
        {
            get { return Connection.GetInstance(); }
        }

        public static SqlDataReader Reader(string query, SqlParameter[] paramns = null)
        {
            SqlDataReader reader = null;
            Conexao.Execute(delegate(SqlCommand cmd) {
                cmd.CommandText = query;
                if (!Convert.Equals(paramns, null)) cmd.Parameters.AddRange(paramns);
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            });

            return reader;
        }

        public static DataTable DataTable(string query, SqlParameter[] paramns = null)
        {
            DataTable dt = new DataTable();

            Conexao.Execute(delegate(SqlDataAdapter adpter) {
                adpter.SelectCommand.CommandText = query;
                if (!Convert.Equals(paramns, null)) adpter.SelectCommand.Parameters.AddRange(paramns);
                adpter.Fill(dt);
            });
            
           return dt;
        }

        public static Int32 ExecuteNonQuery(string query, SqlParameter[] paramns = null)
        {
            Int32 result = 0;
            Conexao.Execute(delegate(SqlCommand cmd)
            {
                cmd.CommandText = query;
                if (!Convert.Equals(paramns, null)) cmd.Parameters.AddRange(paramns);
                result = cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            });

            return result;
        }

    }
}
