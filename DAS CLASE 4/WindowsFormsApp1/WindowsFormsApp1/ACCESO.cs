using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public class ACCESO
    {
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        public void Abrir()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Initial Catalog=FUTBOL; Integrated Security=SSPI; Data Source=.";
            conexion.Open();
        }

        public void Cerrar()
        { 
            conexion.Close();   
            conexion = null;
            GC.Collect();
        }

        public void IniciarTX()
        { 
            transaccion = conexion.BeginTransaction();
        }
        public void Deshacer()
        { 
            transaccion.Rollback();
            transaccion=null;
        }
        public void Confirmar()
        {
            transaccion.Commit();
            transaccion = null;
        }

        private SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            if (transaccion != null)
            {
                cmd.Transaction = transaccion;
            }
            if (parametros != null)
            { 
                cmd.Parameters.AddRange(parametros.ToArray());
            }
            return cmd;
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


        public int Escribir(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = CrearComando(sql, parameters);
            int filas = 0;
            try
            {
                filas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                filas = -1;
                
            }
            cmd.Parameters.Clear();
            return filas;
        }

        public DataTable Leer(string sql, List<SqlParameter> parametros = null) 
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = CrearComando(sql, parametros);

            DataTable tabla = new DataTable();

            adaptador.Fill(tabla);

            adaptador.Dispose();
            adaptador = null;

            return tabla;
        }

    }
}