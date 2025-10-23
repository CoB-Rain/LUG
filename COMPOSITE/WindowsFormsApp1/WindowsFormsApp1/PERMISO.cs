using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class PERMISO
    {
		public PERMISO() { }

		public PERMISO(string name, int id) {
			this.id = id;
			this.nombre = name;	
		}


		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public virtual bool Validar(PERMISO p)
		{ 
			return this.id == p.Id;
		}


	}
}