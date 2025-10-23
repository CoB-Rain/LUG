using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class USUARIO
    {
        private List<PERMISO> permisos = new List<PERMISO>();

        public List<PERMISO> Permisos
        {
            get { return permisos; }

        }
        public  bool Validar(PERMISO p)
        {
            bool ok = false;
            int indice = 0;

            while (indice < permisos.Count && !ok)
            {
                ok = permisos[indice].Validar(p);
                indice++;
            }
            return ok;
        }
    }
}