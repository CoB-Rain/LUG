using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Composite
{
    public class ACCESO
    {
        private SqlConnection cn;

        public void Abrir()
        {
            cn = new SqlConnection("Initial Catalog=BDPERMISO; Data Source=.; Integrated Security=SSPI");
            cn.Open();
        
        }

        public void Cerrar()
        { 
            cn.Close();
            cn = null;
            GC.Collect();   
        }

        public SqlCommand CrearComando(string sql, List<SqlParameter> paramentros = null)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (paramentros != null) {
                
                cmd.Parameters.AddRange(paramentros.ToArray());
            }
            return cmd;
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

        public DataTable Leer(string sql, List<SqlParameter> parametros  = null) 
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter())
            { 
                da.SelectCommand = CrearComando(sql, parametros);
                da.Fill(dt);
                da.Dispose();
            }
            return dt;
        }
    }
}
