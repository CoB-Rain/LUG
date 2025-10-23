using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Composite
{
    public class USUARIO
    {
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
		 
		private List<PERMISO> permisos = new List<PERMISO>();

		public List<PERMISO> Permisos
		{
			get { return permisos; }
			
		}


		public bool TienePermiso(PERMISO p)
		{
			bool ok = false;
			int indice = 0;
			while (!ok && indice < permisos.Count)
			{
				ok = ok || permisos[indice].Validar(p);
				indice++;
			}
			return ok;
		}


	}
}
