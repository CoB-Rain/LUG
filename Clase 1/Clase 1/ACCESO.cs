using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;

namespace Clase_1
{
    public class ACCESO
    {
        SqlConnection conexion;

        public void Abrir()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=.; Initial Catalog=BASE; Integrated Security=SSPI";
            conexion.Open();
        }

        public void Cerrar()
        {
            conexion.Close();
            conexion=null;
            GC.Collect();
        }

        public SqlDataReader Leer(string sql)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
            return comando.ExecuteReader();
        }

        public int LeerEsacalar(string sql)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

            int resultado =int.Parse( comando.ExecuteScalar().ToString());
            return resultado;
        }

        public int Escribir(string sql)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = sql;
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

            int resultado = 0;
            try
            {
                resultado = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                resultado = -1;
            }
            return resultado;
        }

    }
}