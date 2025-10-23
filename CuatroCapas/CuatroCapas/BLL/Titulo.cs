using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Titulo
    {
        MP_TItulo mapper = new MP_TItulo();
        public List<BE.Titulo> Listar()
        {
        
            return mapper.Listar();        
        
        }

        public void Borrar(BE.Titulo titulo)
        { 
            mapper.Borrar(titulo);
        
        }

        public void Grabar(BE.Titulo titulo)
        {
            if (titulo.Id == 0)
            {
                mapper.Insertar(titulo);
            }
            else
            { 
                mapper.Editar(titulo);
            }

        }

    }
}
