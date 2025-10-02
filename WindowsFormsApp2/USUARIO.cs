using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2
{
    public class USUARIO
    {
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

		private string _contraseña;

		public string Contraseña
		{
			get { return _contraseña; }
			set { _contraseña = value; }
		}

		private SEXO _sexo;

		public SEXO Sexo
		{
			get { return _sexo; }
			set { _sexo = value; }
		}
	}
}