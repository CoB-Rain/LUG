using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    internal class ACCESO
    {
        SqlConnection conexion;
        string StrConexion = "Integrated Security=SSPI;Initial Catalog=BatallaNaval;Data Source=.";

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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            if(parametros != null)
            {
                cmd.Parameters.AddRange(parametros.ToArray());
            }

            return cmd;
        }

        public int Escribir(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            int filas = 0;
            try
            {
                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                filas = -1;
            }
            cmd.Dispose();
            cmd = null;
            return filas;
        }

        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = CrearComando(sql, parametros);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            adapter = null;
            return tabla;
        }

        public int LeerEscalar(string sql)
        {
            SqlCommand cmd = CrearComando(sql);
            int res = int.Parse(cmd.ExecuteScalar().ToString());
            return res;
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
