using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class PRODUCTO
    {
		private ACCESO acceso = new ACCESO();
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


		public static List<PRODUCTO> Listar()
		{
            List<PRODUCTO> productos = new List<PRODUCTO>();

			ACCESO acceso = new ACCESO();
			acceso.Abrir();
			SqlDataReader lector = acceso.Leer("PRODUCTO_LISTAR");

			while (lector.Read()) 
			{
				PRODUCTO p = new PRODUCTO();
				p.id = int.Parse(lector["ID_PRODUCTO"].ToString());	
				p.Descripcion = lector["DESCRIPCION"].ToString();
				productos.Add(p);
			}
			lector.Close();
			lector = null;
			acceso.Cerrar();
			return productos;
        }


		public void Insertar()
		{
			acceso.Abrir();

			List<SqlParameter> parametros = new List<SqlParameter>();

			parametros.Add(acceso.CrearParametro("@nombre",this.descripcion));

			acceso.Escribir("PRODUCTO_INSERTAR", parametros);

			acceso.Cerrar();

		}

        public void Editar()
        {
            acceso.Abrir();

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(acceso.CrearParametro("@nom", this.descripcion));
            parametros.Add(acceso.CrearParametro("@id", this.id));

            acceso.Escribir("PRODUCTO_Editar", parametros);

            acceso.Cerrar();

        }


        public void Borrar()
        {
            acceso.Abrir();

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", this.id));

            acceso.Escribir("PRODUCTO_Borrar", parametros);

            acceso.Cerrar();

        }
    }
}