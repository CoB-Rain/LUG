using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class USUARIO
    {
		private int _idusu;

		public int ID_USU
		{
			get { return _idusu; }
			set { _idusu = value; }
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
	}
}