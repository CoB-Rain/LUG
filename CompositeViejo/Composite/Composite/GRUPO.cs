using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class GRUPO : PERMISO
    {
		private List<PERMISO>	permisos = new List<PERMISO>();

		public List<PERMISO> Permisos
		{
			get { return permisos; }
			
		}


        public override bool Validar(PERMISO otro)
        {
            bool ok = false;
            int indice = 0;
            while (!ok && indice < permisos.Count) {
                ok = ok || permisos[indice].Validar(otro); 
                indice++;
            }
            return ok;
        }

    }
}