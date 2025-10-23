using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class USUARIO
    {
        DAL.MP_USUARIO mp = new DAL.MP_USUARIO();

        public void Grabar(BE.USUARIO usuario)
        {
            if(usuario.ID == 0)
            {
                mp.Insertar(usuario);
            }
            else
            {
                mp.Editar(usuario);
            }
        }

        public void Borrar(BE.USUARIO usuario)
        {
            mp.Borrar(usuario);
        }

        public List<BE.USUARIO> Listar()
        {
            return mp.Listar();
        }

        public BE.USUARIO Buscar(BE.USUARIO usuario)
        {
            return mp.Buscar(usuario);
        }
    }
}