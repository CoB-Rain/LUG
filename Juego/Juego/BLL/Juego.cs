using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL
{
    public class Juego
    {
        public static bool PERMITEJUGAR = true;
        private BE.FICHA temporal;

        public event delEnviarFicha EnviarFicha;
        public event delInformar Error;
        public event delInformar Acierto;
        public event delInformar Ganar;

        BE.TABLERO tablero;
        public void IniciarJuego(int dimensiones, int cantidad)
        {
            if (cantidad % 2 == 0)
            {
                BLL.TABLERO gestorTablero = new BLL.TABLERO();
                tablero = gestorTablero.CrearTablero(cantidad, dimensiones);

                foreach (BE.FICHA ficha in tablero.Fichas)
                {
                    EnviarFicha(ficha);
                
                }           
            
            }     

        }


        public void DescubrirFicha(BE.FICHA ficha)
        {

            if (temporal == null)
            {
                temporal = ficha;
            }
            else if (ficha.Imagen == temporal.Imagen)
            {
                Acierto();
                temporal = null;
                int cantidad = (from FICHA f in tablero.Fichas
                                where f.estado == Estado.Descubierto
                                select ficha).Count();
                if (cantidad == tablero.Fichas.Count)
                {
                    Ganar();
                }
            }
            else
            {
                BLL.Juego.PERMITEJUGAR = false;
                ficha.estado = Estado.Oculto;
                temporal.estado = Estado.Oculto;
                temporal = null;
                Error();
            }
        }
    }
}
