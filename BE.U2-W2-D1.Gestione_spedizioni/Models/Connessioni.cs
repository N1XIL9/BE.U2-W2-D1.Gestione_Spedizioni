﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BE.U2_W2_D1.Gestione_spedizioni.Models
{
    public class Connessioni
    {
        public static SqlConnection GetConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["Spedizioni"].ToString();
            SqlConnection sql = new SqlConnection(con);
            return sql;
        }

        public static SqlCommand GetCommand(string query, SqlConnection sql)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = sql;
            com.CommandText = query;
            return com;
        }

        public static SqlCommand GetStoreProcedure(string query, SqlConnection sql)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = sql;
            com.CommandType = System.Data.CommandType.StoredProcedure;
            com.CommandText = query;
            return com;
        }
    }
}