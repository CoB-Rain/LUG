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


        private SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;

            if(parametros != null)
            {
                foreach(SqlParameter p in parametros)
                {
                    cmd.Parameters.Add(p);
                }
            }

            return cmd;
        }

        public int Escribir(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
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

        public SqlDataReader Leer(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public int LeerEscalar(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            int resultado = int.Parse(cmd.ExecuteScalar().ToString());
            return resultado;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = nombre;
            p.Value = valor;
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = nombre;
            p.Value = valor;
            p.DbType = DbType.Int32;
            return p;
        }
    }
}