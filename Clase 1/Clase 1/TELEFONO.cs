using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Clase_1
{
    public class TELEFONO
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string numero;

		public string Numero
		{
			get { return numero; }
			set { numero = value; }
		}


		public static List<TELEFONO> Leer()
		{
            List<TELEFONO> telefonos = new List<TELEFONO>();
			ACCESO acceso = new ACCESO();
			acceso.Abrir();

			SqlDataReader lector = acceso.Leer("Select * from telefono");

			while (lector.Read())
			{
				TELEFONO tel = new TELEFONO();
				tel.id = lector.GetInt32(0);
				tel.numero = lector["numero"].ToString();
				telefonos.Add(tel);	
			}
			lector.Close();
			acceso.Cerrar();
			return telefonos;
        }


	}
}