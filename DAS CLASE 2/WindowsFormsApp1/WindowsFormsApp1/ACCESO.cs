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

        public void Abrir()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Initial Catalog=BASE2; Data Source=.; Integrated Security=SSPI";
            conexion.Open();
        
        }

        public void Cerrar()
        { 
            conexion.Close();
            conexion =null;
            GC.Collect();
        }


        private SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null)
        { 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            if (parametros != null)
            {

                cmd.Parameters.AddRange(parametros.ToArray());
            }

            return cmd;
        }


        public int Escribir(string sql, List<SqlParameter> parameters)
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
            return filas;
        }


        public int LeerEscalar(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = CrearComando(sql, parameters);
            int id = 0;
     
            id = int.Parse( cmd.ExecuteScalar().ToString()) ;
       
            return id;
        }

        public SqlDataReader Leer(string sql)
        {
            SqlCommand cmd = CrearComando(sql);
            SqlDataReader lector = cmd.ExecuteReader();
            return lector;

        }


        public SqlParameter CrearParametro(string nombre, string valor)
        { 
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.String;
            return parametro;
        }



        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Int32;
            return parametro;
        }




        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.DateTime;
            return parametro;
        }

    }
}