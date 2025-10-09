using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
    public class PRODUCTO
    {
        DAL.MP_PRODUCTO mp = new DAL.MP_PRODUCTO();
        public void Grabar(BE.PRODUCTO producto)
        {
            if(producto.ID == 0)
            {
                mp.Insertar(producto);
            }
            else
            {
                mp.Editar(producto);
            }
        }

        public void Borrar(BE.PRODUCTO producto)
        {
            mp.Borrar(producto);
        }

        public List<BE.PRODUCTO> Listar()
        {
            return mp.Listar();
        }

    }
}
