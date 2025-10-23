using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        MP_PERSONA mapper = new MP_PERSONA();

        public void Grabar(BE.PERSONA persona)
        {
            if (persona.Id == 0)
            {
                mapper.Insertar(persona);
            }
            else
            {
                mapper.Editar(persona);
            }
        }

        public List<BE.PERSONA> listar()
        {
            return mapper.Listar();
        }
        public void Borrar(BE.PERSONA persona)
        {
            mapper.Borrar(persona);
        }
    }
}
