using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace WindowsFormsApp2
{
    public class ACCESO
    {
        SqlConnection conexion;
        string StrConexion = "Integrated Security=SSPI;Initial Catalog=BASE;Data Source=.";

        public void Abrir()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = StrConexion;
            conexion.Open();
        }

        public void Cerrar()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }


        private SqlCommand CrearComando(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            return cmd;
        }

        public int Escribir(string sql)
        {
            SqlCommand cmd = CrearComando(sql);
            int filasAfectadas = 0;
            try
            {
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                filasAfectadas = -1;
            }
            cmd.Dispose();
            cmd = null;
            return filasAfectadas;
        }

        public SqlDataReader Leer(string sql)
        {
            SqlCommand cmd = CrearComando(sql);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}