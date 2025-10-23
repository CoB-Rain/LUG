using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class BARRIO
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string barrio;

		public string Barrio
		{
			get { return barrio; }
			set { barrio = value; }
		}


		public static List<BARRIO> Listar()
		{ 
			ACCESO acceso = new ACCESO();
			acceso.Abrir();
			DataTable tabla = acceso.Leer("BARRIO_LISTAR");
			acceso.Cerrar();

            List<BARRIO> barrios = new List<BARRIO>();

			foreach (DataRow registro in tabla.Rows)
			{
				BARRIO barrio = new BARRIO();
				barrio.id = int.Parse(registro["ID_BARRIO"].ToString());
				barrio.barrio = registro["barrio"].ToString();
				barrios.Add(barrio);			}


			return barrios;

        }

        public override string ToString()
        {
            return barrio;
        }
    }
}