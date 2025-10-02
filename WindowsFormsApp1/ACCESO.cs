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
        SqlConnection conexion;
        //cadena de conexion para el objeto SqlConnection
        string StrConexion = "Integrated Security=SSPI;Initial Catalog=BASE;Data Source=.";


        //Abrir la conexion
        public void Abrir()
        {
            conexion = new SqlConnection();
            //le paso la cadena de conexion
            conexion.ConnectionString = StrConexion;
            //abro la conexion
            conexion.Open();
        }

        //Cerrar la conexion
        public void Cerrar()
        {
            //cierro la conexion y la borro
            conexion.Close();
            conexion = null;
            GC.Collect();
        }

        //Metodo para crear comandos SQL
        private SqlCommand CrearComando(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            //La cadena sql
            cmd.CommandText = sql;
            //el tipo de comando, puede ser texto o contra procedimientos almacenados
            cmd.CommandType = CommandType.Text;
            //el comando tambien va a poseer la conexion
            cmd.Connection = conexion;
            //retorno el comando terminado
            return cmd;
        }

        //Metodo para escribir comandos SQL
        public int Escribir(string sql)
        {
            int filasAfectadas = 0;
            SqlCommand cmd = CrearComando(sql);
            try
            {
                //Ejecuta la consulta SQL y me devuelve el total de filas afectadas, NO DEVUELVE UNA CONSULTA
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //excepcion, nunca pueden existir filas afectadas negativas
                filasAfectadas = -1;
            }
            cmd.Dispose();
            cmd = null;
            return filasAfectadas;
        }

        //Metodo para leer comandos SQL
        public SqlDataReader Leer(string sql)
        {
            //Creo un comando
            SqlCommand cmd = CrearComando(sql);
            //creo un objeto del tipo SqlDataReader y le paso, del comando que cree, el execute reader
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }


    }
}