using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Acceso
    {
        SqlConnection con = new SqlConnection();
        public void Abrir()
        {
            con.ConnectionString = "Data Source=. ; Integrated Security= SSPI; Initial Catalog=COMPOSITE";
            con.Open();

        }
        public void Cerrar()
        {
            con.Close();
            GC.Collect();
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

        public SqlCommand CrearComando(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sql;
            command.Connection = con;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters.ToArray());
            }

            return command;


        }

        public int Escribir(string sql, List<SqlParameter> parameters = null)
        {
            int result = 0;
            SqlCommand comando = CrearComando(sql, parameters);
            try { comando.ExecuteNonQuery();
                result = 1;
            } catch (Exception ex) { result = -1; }
            return result;

        }
        public DataTable Leer(string sql, List<SqlParameter> parameters = null)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = CrearComando(sql, parameters);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            adapter = null;
            return table;


        }


    }
}