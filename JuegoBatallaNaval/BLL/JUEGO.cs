using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class JUEGO
    {
        internal BE.TABLERO tablero = new BE.TABLERO();
        internal List<BE.BARCO> barcos = new List<BE.BARCO>();

        public void IniciarJuego(int cantidad, int dimensiones)
        {
            BLL.TABLERO gestorTablero = new BLL.TABLERO();
            tablero = gestorTablero.CrearTablero(cantidad, dimensiones);
            ObtenerBarcos();
        }

        private void ObtenerBarcos()
        {
            BLL.BARCO gestorBarco = new BLL.BARCO();

            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.BatallaNaval));
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.PortaAviones));
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.Fragata));
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.Buque));
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.Acorazado));
        }
    }
}