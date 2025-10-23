using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Mapper<T>
    {
        internal Acceso acceso;

        public abstract void Insertar(T obj);

        public abstract void Editar(T obj);

        public abstract void Borrar(T obj);

        public abstract List<T>  Listar ();

    }
}
