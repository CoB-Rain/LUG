using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp3
{
    public class TITULO
    {
		private ACCESO _acceso;

		public ACCESO Acceso
		{
			set { _acceso = value; }
		}

		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}

		public int Insertar()
		{
			List<SqlParameter> parametros = new List<SqlParameter>();
			parametros.Add(_acceso.CrearParametro("@titulo", this._descripcion));
			
			int res = _acceso.Escribir("TITULO_INSERTAR", parametros);

			return res;
		}

        public override string ToString()
        {
            return this._descripcion;
        }

		public static List<TITULO> Listar(ACCESO acceso)
		{
			List<TITULO> titulos = new List<TITULO>();

			DataTable tabla = acceso.Leer("TITULO_LISTAR");

			foreach (DataRow registro in tabla.Rows)
			{
				TITULO titulo = new TITULO();
				titulo._id = int.Parse(registro["ID"].ToString());
				titulo._descripcion = registro["Descripcion"].ToString();
				titulos.Add(titulo);
			}

			return titulos;
		}
	}
}