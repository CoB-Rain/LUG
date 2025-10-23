using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_TItulo : Mapper<BE.Titulo>
    {
        public MP_TItulo() { 
            acceso = new Acceso();
        }

        public override void Borrar(Titulo obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", obj.Id));
            acceso.Abrir();
            int res = acceso.Escribir("TITULO_BORRAR", parametros);
            acceso.Cerrar();
        }

        public override void Editar(Titulo obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ID", obj.Id));
            parametros.Add(acceso.CrearParametro("@desc", obj.Descripcion));
            acceso.Abrir();
            int res = acceso.Escribir("TITULO_EDITAR", parametros);
            acceso.Cerrar();
        }

        public override void Insertar(Titulo obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@titulo", obj.Descripcion));
            acceso.Abrir();
            int res = acceso.Escribir("TITULO_INSERTAR", parametros);
            acceso.Cerrar();

        }

        public override List<Titulo> Listar()
        {
            acceso.Abrir();
            List<Titulo> titulos = new List<Titulo>();

            DataTable tabla = acceso.Leer("TITULO_LISTAR");
            acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Titulo titulo = new Titulo();
                titulo.Id = int.Parse(registro["ID"].ToString());
                titulo.Descripcion = registro["Descripcion"].ToString();
                titulos.Add(titulo);
            }

            return titulos;
        }
    }
}
