using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class BARCO
    {
        public BE.BARCO CrearBarco(TipoBarco tipoBarco)
        {
            BE.BARCO barco;

            switch (tipoBarco)
            {
                case TipoBarco.Acorazado:
                    barco = new BE.ACORAZADO();
                    break;
                case TipoBarco.Buque:
                    barco = new BE.BUQUE();
                    break;
                case TipoBarco.Fragata:
                    barco = new BE.FRAGATA();
                    break;
                case TipoBarco.PortaAvion:
                    barco = new BE.PORTA_AVION();
                    break;
                case TipoBarco.BatallaNaval:
                    barco = new BE.BATALLA_NAVAL();
                    break;
                default:
                    barco = null;
                    break;
            }
            return barco;
        }

        public bool UbicarBarco(BE.TABLERO tablero, BE.BARCO barco, BE.COORDENADA posicionInicial, DireccionEje eje)
        {
            bool ok = barco != null && tablero.Casilleros.Count > 0;
            if (ok)
            {
                if(eje == DireccionEje.Horizontal)
                {

                }
                else
                {

                }
            }
            return ok;
        }
    }
}