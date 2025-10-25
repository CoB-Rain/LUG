using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ADM
{
    public class Access
    {
        public SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=LOPO;Integrated Security=True;Trust Server Certificate=True");
        public SqlTransaction transaction;

        public void Open()
        {
            conexion.Open();
        }
        public void Close()
        {
            conexion.Close();
        }

        public void Start_Tx()
        {
            transaction = conexion.BeginTransaction();
        }
        public void Stop_Tx()
        {
            transaction.Rollback();
        }
        public void Commit_Tx()
        {
            transaction.Commit();
        }

        public void Escribir( string Query , SqlParameter[] sp  = null )
        {
            try
            {
                Open();
                Start_Tx();
                using ( SqlCommand cmd = new SqlCommand(Query , conexion) )
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    if ( sp is not null )
                        cmd.Parameters.AddRange( sp );

                    cmd.Transaction = transaction;
                    int resultado = cmd.ExecuteNonQuery();
                    Commit_Tx();
                }
            }
            catch ( Exception ex )
            {
                Stop_Tx();
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public DataTable Leer( string Query , SqlParameter[] sp = null)
        {
            DataTable dt = new DataTable();     
            try
            {
                Open();
                using ( SqlCommand cmd = new SqlCommand( Query , conexion ) )
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    if ( sp is not null )
                        cmd.Parameters.AddRange( sp );

                    using ( SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
            catch( Exception ex )
            {
                return dt;
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                Close();
            }
        }

    }
}
