using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class JUGADOR
    {
        DAL.MP_JUGADOR mp = new DAL.MP_JUGADOR();

        public void Insertar(BE.JUGADOR jugador)
        {
            mp.Insertar(jugador);
        }

        public void Editar(BE.JUGADOR jugador)
        {
            mp.Editar(jugador);
        }

        public void Borrar(BE.JUGADOR jugador)
        {
            mp.Borrar(jugador);
        }

        public List<BE.JUGADOR> Listar()
        {
            return mp.Listar();
        }
    }
}