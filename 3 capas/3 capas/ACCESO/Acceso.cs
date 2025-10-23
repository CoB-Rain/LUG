using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace Acceso
{
    public class ACCESO
    {
        SqlConnection conexion;
        SqlTransaction tx;


        public void Abrir()
        {
            conexion = new SqlConnection(@"INTEGRATED SECURITY=SSPI; DATA SOURCE=.; INITIAL CATALOG=BASE");
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
            if (parametros != null)
            {
                cmd.Parameters.AddRange(parametros.ToArray());
            }
            if (tx != null)
            {
                cmd.Transaction = tx;
            }
            return cmd;
        }

        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();

            adaptador.SelectCommand = CrearComando(sql, parametros);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            adaptador = null;
            return tabla;
        }
        public int LeerEscalar(string sql, List<SqlParameter> parametros = null)
        {
            int res = 0;
            SqlCommand cmd = CrearComando(sql);
            res = int.Parse(cmd.ExecuteScalar().ToString());

            return res;
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
            SqlParameter par = new SqlParameter(nombre, valor);
            par.DbType = DbType.String;
            return par;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter par = new SqlParameter(nombre, valor);
            par.DbType = DbType.Int32;
            return par;
        }

        public void IniciarTx()
        {
            tx = conexion.BeginTransaction();

        }

        public void Confirmar()
        {
            tx.Commit();
            tx = null;
        }

        public void Rollback()
        {
            tx.Rollback();
            tx = null;
        }
    }
}
