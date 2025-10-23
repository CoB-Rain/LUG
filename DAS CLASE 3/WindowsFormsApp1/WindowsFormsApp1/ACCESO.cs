using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class ACCESO
    {
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        public void Abrir()
        { 
            conexion = new SqlConnection();
            conexion.ConnectionString = "INTEGRATED SECURITY=SSPI; INITIAL CATALOG = BASE; DATA SOURCE=.";
            conexion.Open();
        }

        public void Cerrar()
        {
            conexion.Close();
            conexion=null;
            GC.Collect();
        }

        public void IniciarTx()
        {
            if (conexion.State == ConnectionState.Open)
            {
                transaccion = conexion.BeginTransaction();
            }
        }

        public void ConfirmarTx()
        { 
            transaccion.Commit();
            transaccion=null;
        }

        public void DeshacerTx()
        { 
            transaccion.Rollback();
            transaccion = null;
        }

        private SqlCommand CrearComando(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters.ToArray());
            }
            if (transaccion != null)
            { 
                cmd.Transaction = transaccion;
            }
            return cmd;
        }

        public int Escribir(string sql, List<SqlParameter> parametros)
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
            cmd.Parameters.Clear();
            return filas;
        }

        public SqlDataReader Leer(string sql, List<SqlParameter> parametros=null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public SqlParameter CrearParametro(string nombre, int valor, ParameterDirection direccion = ParameterDirection.Input )
        { 
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;    
            parametro.DbType = DbType.Int32;
            parametro.Direction = direccion;
            return parametro;
        
        }



    }
}