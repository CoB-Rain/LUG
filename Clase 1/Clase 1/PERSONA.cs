using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Clase_1
{
    public class PERSONA
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}


		public void Insertar()
		{
			string sql = "select isnull(max(id),0  )+1 from persona";
			ACCESO acceso = new ACCESO();
			acceso.Abrir();
			this.id = acceso.LeerEsacalar(sql) ;
			sql = $"Insert into PERSONA (id, nombre, edad) values ( {id} , '{nombre}', {edad} ) ";
			acceso.Escribir(sql) ;
			acceso.Cerrar();
        }



        public void Editar()
        {
            string sql = $"update persona set nombre = '{nombre}', edad={edad} where id = {id} ";
            ACCESO acceso = new ACCESO();
            acceso.Abrir();
            acceso.Escribir(sql);
            acceso.Cerrar();
        }


        public void Borrar()
        {
            string sql = $"delete from persona where id = {id} ";
            ACCESO acceso = new ACCESO();
            acceso.Abrir();
            acceso.Escribir(sql);
            acceso.Cerrar();
        }


        public static List<PERSONA> Listar()
		{
            List<PERSONA> personas = new List<PERSONA>();
            ACCESO acceso = new ACCESO();
            acceso.Abrir();

			SqlDataReader lector = acceso.Leer("Select * from persona");
			while (lector.Read())
			{
				PERSONA p = new PERSONA();
				p.id = int.Parse(lector["ID"].ToString());
				p.nombre = lector["nombre"].ToString();
                p.edad= int.Parse(lector["Edad"].ToString());
				personas.Add(p);
            }
			lector.Close();
			acceso.Cerrar() ;
			return personas ;
        }

	}
}