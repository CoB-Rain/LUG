using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class PERSONA
    {
		private ACCESO acceso = new ACCESO();

		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private int _edad;

		public int Edad
		{
			get { return _edad; }
			set { _edad = value; }
		}

		public static List<PERSONA> Listar()
		{
			List<PERSONA> personas = new List<PERSONA>();
			ACCESO acceso = new ACCESO();
			acceso.Abrir();

			SqlDataReader reader = acceso.Leer("SELECT ID_PERSONA, NOMBRE, APELLIDO, EDAD FROM PERSONA");
			while (reader.Read())
			{
				PERSONA p = new PERSONA();
				p._id = reader.GetInt32(0);
				//p._nombre = reader.GetString(1);
				p._nombre = reader[1].ToString();
				p._apellido = reader["APELLIDO"].ToString();
				p.Edad = int.Parse(reader["EDAD"].ToString());
				personas.Add(p);
			}
			reader.Close();

			acceso.Cerrar();
			acceso = null;
			return personas;
		}

		public int Insertar()
		{
			string sql = $"INSERT INTO PERSONA (ID_PERSONA, NOMBRE, APELLIDO, EDAD) VALUES ({_id}, '{_nombre}', '{_apellido}', {_edad})";
			acceso.Abrir();
			int res = acceso.Escribir(sql);
			acceso.Cerrar();
			return res;
		}

		public int Editar()
		{
            string sql = $"UPDATE PERSONA SET NOMBRE = '{_nombre}', APELLIDO = '{_apellido}', EDAD = {_edad} WHERE ID_PERSONA = {_id}";
            acceso.Abrir();
            int res = acceso.Escribir(sql);
            acceso.Cerrar();
            return res;
        }

        public int Borrar()
		{
            string sql = $"DELETE FROM PERSONA WHERE ID_PERSONA = {_id}";
            acceso.Abrir();
            int res = acceso.Escribir(sql);
            acceso.Cerrar();
            return res;
        }
    }
}