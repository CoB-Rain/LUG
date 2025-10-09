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
        private SqlConnection conexion;
        string StrConexion = "Initial Catalog=PARCIAL; Integrated Security=SSPI; Data Source=.";

        public void Abrir()
        {
            conexion = new SqlConnection(StrConexion);
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
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            if(parametros != null)
            {
                cmd.Parameters.AddRange(parametros.ToArray());
            }

            return cmd;
        }

        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = CrearComando(sql, parametros);
            da.Fill(tabla);
            return tabla;
        }

        public int Escribir(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            int filas = 0;
            try
            {
                filas = cmd.ExecuteNonQuery();  
            }
            catch (Exception ex)
            {
                filas = -1;
            }
            return filas;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Int32;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, float valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Single;
            return p;
        }
    }
}
