using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class JUEGO
    {
        public event delEnviarCasillero EnviarCasillero;
        public event delEnviarBarco EnviarBarco;
        public event delInformar Agua;
        public event delInformar Tocado;
        public event delInformar Hundir;
        public event delInformar Ganar;
        public event delInformar Perder;
        public event delInformar Empatar;

        BE.TABLERO tablero;
        List<BE.BARCO> barcos = new List<BE.BARCO>();

        public void IniciarJuego(int cantidad, int dimensiones)
        {
            BLL.TABLERO gestorTablero = new BLL.TABLERO();
            BLL.BARCO gestorBarco = new BLL.BARCO();

            tablero = gestorTablero.CrearTablero(cantidad, dimensiones);
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.BatallaNaval));
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.PortaAviones));
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.Fragata));
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.Buque));
            barcos.Add(gestorBarco.CrearBarco(BE.TipoBarco.Acorazado));

            foreach(BE.CASILLERO casillero in tablero.Casilleros)
            {
                EnviarCasillero(casillero);
            }

            foreach(BE.BARCO barco in barcos)
            {
                EnviarBarco(barco);
            }
        }

        public void UbicarBarco()
        {

        }
    }
}