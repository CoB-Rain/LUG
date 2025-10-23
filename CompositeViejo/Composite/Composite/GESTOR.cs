using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class GESTOR
    {
        public static List<PERMISO> Permisos = new List<PERMISO>();
        public List<PERMISO> DevolverPermisos()
        { 
            Permisos.Clear();
            ACCESO ac = new ACCESO();
            ac.Abrir();
            DataTable dt = ac.Leer("DEVOLVER_PERMISOS");
            ac.Cerrar();

            List<PERMISO>temp = new List<PERMISO>();
            foreach (DataRow dr in dt.Rows)
            {
                PERMISO p;
                if (dr["GRUPO"].ToString() == "SI")
                {
                    p = new GRUPO();
                }
                else
                { 
                    p = new PERMISO();
                }
                p.Nombre = dr["Nombre"].ToString();
                p.ID = int.Parse(dr["ID_PERMISO"].ToString());

                if( (from PERMISO per in temp
                     where per.ID == p.ID
                     select per).FirstOrDefault() == null )
                {
                    temp.Add(p);
                }

            }

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["GRUPO"].ToString() == "SI")
                {
                    GRUPO grupo = (from PERMISO gg in temp
                               where gg.ID == int.Parse(dr["ID_PERMISO"].ToString())
                                   select gg).First() as GRUPO;
                    
                    PERMISO HIJO = (from PERMISO gg in temp
                                   where gg.ID == int.Parse(dr["ID_HIJO"].ToString())
                                    select gg).First();
                    grupo.Permisos.Add(HIJO);

                }
            }
            Permisos.AddRange(temp);
            return temp;
        }



        public void SetearPermisos(USUARIO usu)
        {
            usu.Permisos.Clear();
            ACCESO ac = new ACCESO();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(ac.CrearParametro("@id", usu.Id));
            ac.Abrir();
            DataTable dt = ac.Leer("DEVOLVER_PERMISOS_USUARIO",parametros);
            ac.Cerrar();
            foreach (DataRow dr in dt.Rows)
            {
                PERMISO permiso = (from PERMISO gg in Permisos
                               where gg.ID == int.Parse(dr["ID_PERMISO"].ToString())
                               select gg).First() ;
                usu.Permisos.Add(permiso);

            }
        }
    }
}
