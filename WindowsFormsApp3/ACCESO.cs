using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public class ACCESO
    {
        SqlConnection conexion;
        SqlTransaction tx; //objeto del tipo SqlTransaction para hacer mis transacciones
        string StrConexion = "Integrated Security=SSPI; Initial Catalog=BASE3; Data Source=.";

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
            cmd.CommandType = CommandType.StoredProcedure;//para procedimientos almacenados
            
            if(parametros != null)
            {
                //otra forma de guardar mis parametros es con addrange.
                //hace automaticamente el foreach
                cmd.Parameters.AddRange(parametros.ToArray());
            }
            if(tx != null)
            {
                cmd.Transaction = tx;
            }

            return cmd;
        }

        //ADO DESCONECTADO
        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            //Para ado desconectado necesitamos un objeto del tipo SqlDataAdapter
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = CrearComando(sql, parametros);//le guardamos al adaptador lo que va a llenar en la tabla con SelectCommand
            DataTable tabla = new DataTable();//tabla la cual mi adaptador va a llenar
            adaptador.Fill(tabla);//le decimos al adaptador que llene la tabla con Fill()
            adaptador = null;//una vez ya llenamos la tabla, vaciamos los datos del adaptador
            return tabla;//y retornamos la tabla con la informacion.

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
            catch (Exception)
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
            //la transaccion la inicia mi objeto SqlConnection
            tx = conexion.BeginTransaction();
        }

        public void ConfirmarTx()
        {
            //mi objeto SqlTransaction confirma la transaccion
            tx.Commit();
            tx = null;
        }

        public void DeshacerTx()
        {
            //mi objeto SqlTransaction deshace la transaccion
            tx.Rollback();
            tx = null;
        }
    }
}