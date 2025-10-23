using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace BK_RES
{
    public class ACCESO
    {

        SqlConnection conn;

        public void Abrir()
        {

            conn = new SqlConnection();
            conn.ConnectionString = "Initial Catalog= BASE ; Data Source=.; Integrated Security=SSPI";
            conn.Open();

        }


        public void Cerrar()
        {

            conn.Close();
            conn = null;
            GC.Collect();
           
        }

        private SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null, CommandType tipo = CommandType.StoredProcedure)
        {

            SqlCommand c = new SqlCommand();
            c.CommandText = sql;
            c.CommandType = tipo;
            c.Connection = conn;
            if (parametros != null)
            { 
                c.Parameters.AddRange(parametros.ToArray());
            }
            return c;

        }

        public int Escribir(string sql ,List<SqlParameter> parametros = null)
        {

            SqlCommand c = CrearComando(sql, parametros );
            int filasAfectadas = 0;
            try
            {

                filasAfectadas = c.ExecuteNonQuery();

            } catch (Exception ex)
            {

                filasAfectadas = -1;

            }
            c.Parameters.Clear();

            c.Dispose();    
            return filasAfectadas;

        }

        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            DataTable table = new DataTable();
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            { 
                dataAdapter.SelectCommand = CrearComando(sql,parametros);
                dataAdapter.Fill(table);
                dataAdapter.Dispose();
            }

            return table;
        }

        public void Backup()
        {
            string ruta = @"D:\BKS" ;
            ruta += "\\BK"+ (Directory.GetFiles(ruta).Length + 1).ToString();
                       
            
            string query = $"BACKUP DATABASE[BASE] TO DISK = N'{ruta}' WITH NOFORMAT, NOINIT, NAME = N'BASE-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = CrearComando( query,null,CommandType.Text);

            cmd.ExecuteNonQuery();
        
        }

        public void Restore(string filename)
        {

            string BKLOG = @"C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\Backup\BASE_LogBackup_2024 - 10 - 23_20 - 36 - 25.bak";
            string query = $"EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'BASE'; USE MASTER;";
            query += $"ALTER DATABASE [BASE] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; ";
            query += $"DROP DATABASE [BASE]";
            query += $"RESTORE DATABASE [BASE] FROM  DISK = N'{filename}' WITH  FILE = 1,  NOUNLOAD,  STATS = 5 ; " ;
            query += $"ALTER DATABASE[BASE] SET MULTI_USER";
            SqlCommand cmd = CrearComando(query, null, CommandType.Text);

            cmd.ExecuteNonQuery();
        }

    }
}
