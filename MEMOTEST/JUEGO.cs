using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MEMOTEST
{
    public class JUEGO
    {
        public static Random rnd = new Random();
        public event delError EnviarError;

        CASILLERO casilleroPrevio = null;

        public void CompararCasillero(CASILLERO casillero)
        {
            if(casilleroPrevio == null)
            {
                casilleroPrevio = casillero;
            }
            else
            {
                bool ok = casilleroPrevio.Ficha.Numero == casillero.Ficha.Numero;
                if(ok)
                {
                    casilleroPrevio.Ficha.Estado = ESTADO.Inmovil;
                    casillero.Ficha.Estado = ESTADO.Inmovil;
                }
                else
                {
                    casilleroPrevio.Ficha.Estado = ESTADO.Cubierto;
                    casillero.Ficha.Estado = ESTADO.Cubierto;
                    EnviarError();
                }
                casilleroPrevio = null;
            }


        }


        public bool Ganador(TABLERO tablero)
        {
            int cantidad = (from CASILLERO c in tablero.Casilleros
                            where c.Ficha.Estado == ESTADO.Inmovil
                            select c).Count();
            return cantidad == tablero.Casilleros.Count();
        }

    }
}