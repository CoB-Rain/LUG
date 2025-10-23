using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso;

namespace Negocio
{
    public class Titulo
    {
        private Acceso.ACCESO acceso;

        public Acceso.ACCESO Acceso
        {
            set { acceso = value; }
        }



        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Insertar()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@titulo", this.descripcion));

            int res = acceso.Escribir("TITULO_INSERTAR", parametros);

            return res;
        }

        public override string ToString()
        {
            return this.descripcion;
        }

        public static List<Titulo> Listar()
        {
            ACCESO acceso = new ACCESO();
            acceso.Abrir();
            List<Titulo> titulos = new List<Titulo>();

            DataTable tabla = acceso.Leer("TITULO_LISTAR");
            acceso.Cerrar();

            foreach (DataRow registro in tabla.Rows)
            {
                Titulo titulo = new Titulo();
                titulo.id = int.Parse(registro["ID"].ToString());
                titulo.descripcion = registro["Descripcion"].ToString();
                titulos.Add(titulo);
            }

            return titulos;

        }

    }
}
