using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class PERMISO
    {
		public PERMISO()
		{ }

        public PERMISO(int Id)
        {
		id = Id;	
		}
        private int id;

		public int ID
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

        public override string ToString()
        {
            return nombre;
        }

		public virtual bool Validar(PERMISO otro)
		{ 
			return id == otro.id;
		}

    }
}