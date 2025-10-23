using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class EQUIPO
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string equipo;

		public string Equipo
		{
			get { return equipo; }
			set { equipo = value; }
		}

		private BARRIO barrio;

		public BARRIO Barrio
		{
			get { return barrio; }
			set { barrio = value; }
		}

		public static List<EQUIPO> ListarEquipos()
		{
            List<EQUIPO> equipos = new List<EQUIPO>();

			List<BARRIO> barrios = BARRIO.Listar();

			ACCESO acceso = new ACCESO();
			acceso.Abrir();
			DataTable tabla = acceso.Leer("EQUIPO_LISTAR");
			acceso.Cerrar();


			foreach (DataRow registro in tabla.Rows)
			{
				EQUIPO equipo = new EQUIPO();
				equipo.id = int.Parse(registro["ID_EQUIPO"].ToString());
				equipo.equipo = registro["equipo"].ToString();

				equipo.barrio = (from BARRIO b in barrios
								where b.Id== int.Parse(registro["ID_BARRIO"].ToString())
								select b
					           ).First();
			
				equipos.Add(equipo);
			}


			return equipos;
        }


		public void Insertar()
		{

			List<SqlParameter> parametros = new List<SqlParameter>();
            ACCESO acceso = new ACCESO();
            
			parametros.Add(acceso.CrearParametro("@equipo", this.equipo));
            parametros.Add(acceso.CrearParametro("@id_barrio", this.barrio.Id));
            acceso.Abrir();
			acceso.Escribir("EQUIPO_INSERTAR",parametros);
			acceso.Cerrar();

        }

        public void Editar()
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            ACCESO acceso = new ACCESO();

            parametros.Add(acceso.CrearParametro("@id", this.id));
            parametros.Add(acceso.CrearParametro("@equipo", this.equipo));
            parametros.Add(acceso.CrearParametro("@id_barrio", this.barrio.Id));
            acceso.Abrir();
            acceso.Escribir("EQUIPO_EDITAR", parametros);
            acceso.Cerrar();

        }

        public void Borrar()
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            ACCESO acceso = new ACCESO();

            parametros.Add(acceso.CrearParametro("@id", this.id));
            acceso.Abrir();
            acceso.Escribir("EQUIPO_BORRAR", parametros);
            acceso.Cerrar();

        }
    }
}